using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Globalization;

namespace seospr
{

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        List<string> taskID = new List<string>();
        List<string> topic = new List<string>();
        List<string> approve = new List<string>();
        List<string> reject = new List<string>();
        List<string> awaite = new List<string>();
        List<string> working = new List<string>();
        List<string> balanse = new List<string>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Dictionary<int, DateTime> dictionary = new Dictionary<int, DateTime>();
        public bool flag = false;
        public int secondsF1; // Seconds.
        public int minutesF1; // Minutes.
        public int hoursF1;   // Hours.
        public int yearF1;
        public int monthF1;
        public int dayF1;
        public int rowNum;

        

        public void Start()
        {
            pictureBox2.Visible = true;
            webBrowser1.Navigate("http://www.seosprint.net/index.php");

            bool state = true;
            waitMht(2);
          //  while (state)
          //  {
          //      if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
          //      {
          //         Application.DoEvents();
         //           if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
         //          {
                       foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("A"))
                        {
                            if (el.InnerText != null && el.InnerText.Equals("Вход"))
                            {
                                el.InvokeMember("click");
                                break;
                            }
                        }

                        waitMht(1);
                        pictureBox1.Image = Getmg(); //get Captcha
                        state = false;
            //        }
            //    }
           // }
        }


        public Image Getmg() //get Captcha
        {
            try
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                label4.Visible = true;
                mshtml.HTMLWindow2 w2 = (mshtml.HTMLWindow2)webBrowser1.Document.Window.DomWindow;
                w2.execScript("var ctrlRange = document.body.createControlRange();ctrlRange.add(document.getElementById('siimage'));ctrlRange.execCommand('Copy');", "javascript");
            }
            catch 
            {
                pictureBox2.Visible = true;
                Start();
            }
                return Clipboard.GetImage();
            
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Submit_btn.Enabled = false;
            ref_pic_capt.Enabled = false;
            pictureBox3.Visible = true; //show load img
            HtmlElementCollection pageTextElements = webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement element in pageTextElements)
            {
                if (element.Name.Equals("asklemail"))
                    element.SetAttribute("value", login_text.Text);
                if (element.Name.Equals("asklpass"))
                    element.SetAttribute("value", pass_text.Text);
                if (element.Name.Equals("asklcode"))
                    element.SetAttribute("value", capcha_text.Text);
            }

            foreach (HtmlElement el in webBrowser1.Document.GetElementsByTagName("span"))
            {
                if (el.InnerText != null && el.InnerText.Equals("ВОЙТИ"))
                {
                    el.InvokeMember("click");
                    break;
                }
            }

            waitMht(1);
            
            HtmlElement form = webBrowser1.Document.GetElementById("logsubmit");
            if (form != null)
            {
                ref_pic_capt.Enabled = true;
                pictureBox3.Visible = false;
                Submit_btn.Enabled = true;
                error_lable.Visible = true;
                waitMht(2);
                error_lable.Visible = false;
            }
            else
            {
                goToTask();
            }
            

        }

        public void goToTask()
        {
            waitMht(2);
            webBrowser1.Navigate("http://www.seosprint.net/advmanager-task.php");
            waitMht(1);
            getTaskList();
        }

        public void getTaskList()
        {
                var file = webBrowser1.DocumentText;
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(file);
                var nodes = doc.DocumentNode.SelectNodes("//tr[contains(@id,'adv')]");

                if (nodes != null)
                {
                    flag = true;
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        pictureBox3.Visible = false; //hide load img
                        taskID.Add(nodes[i].Id.Remove(0, 3));
                        topic.Add(doc.DocumentNode.SelectSingleNode("//a[contains(@href,'" + taskID[i] + "')]").InnerText);
                        approve.Add(doc.DocumentNode.SelectSingleNode("//a[contains(@href,'advmanager-task-logs.php?adv=" + taskID[i] + "&mode=1')]").InnerText);
                        reject.Add(doc.DocumentNode.SelectSingleNode("//a[contains(@href,'advmanager-task-logs.php?adv=" + taskID[i] + "&mode=2')]").InnerText);
                        working.Add(doc.DocumentNode.SelectSingleNode("//a[contains(@href,'advmanager-task-logs.php?adv=" + taskID[i] + "&mode=0')]").InnerText);


                        bool balansCheck = doc.DocumentNode.InnerHtml.Contains("<span class=\"transport-moder\" title=\"Отправить рекламу на проверку арбитрам\" onclick=\"javascript:advevent(" + taskID[i] + "");
                        bool balansReplenishNone = doc.DocumentNode.InnerHtml.Contains("<span class=\"add-budgetnone\" title=\"Пополнить рекламный бюджет\" onclick=\"javascript:hideserfaddblock('serfadd" + taskID[i] + "");
                        bool balansWaitFor = doc.DocumentNode.InnerHtml.Contains("<span class=\"desctext\" style=\"text-decoration: blink\">Задание на");
                        bool balansReplenish = doc.DocumentNode.InnerHtml.Contains("<span class=\"add-budget\" title=\"Пополнить рекламный бюджет\" onclick=\"javascript:hideserfaddblock('serfadd" + taskID[i] + "");

                        
        
                        if (balansReplenish == true)
                        {
                            balanse.Add(doc.DocumentNode.SelectSingleNode("//span[contains(@onclick,'serfadd" + taskID[i] + "')]").InnerText);
                        }
                        else if (balansReplenishNone == true)
                        {
                            balanse.Add("Пополнить");
                        }
                        else if (balansCheck == true)
                        {
                            balanse.Add("Отправить на проверку");
                        }
                        else if (balansWaitFor == true)
                        {
                            balanse.Add("Ожидает проверки");
                        }
                       
                        

                   /*     var awaiteCheck = doc.DocumentNode.SelectSingleNode("//a[contains(@href,'advmanager-task-logs.php?adv=" + taskID[i] + "&mode=0')]").InnerText;
                        if (awaiteCheck == "0")
                        {
                            awaite.Add("[-]");
                        }
                        else
                        {
                            awaite.Add(doc.DocumentNode.SelectSingleNode("//span[contains(@class,'btnjob_" + taskID[i] + "')]").InnerText.Remove(0, 22));
                        }

                        
                        
/*
                        var balansWait = doc.DocumentNode.SelectSingleNode("//span[contains(@class,'transport-moder')]").InnerText;
                        if (balansWait == "Отправитьна проверку")
                            balanse.Add("Отправить");

                        var balanseCheck = doc.DocumentNode.SelectSingleNode("//span[contains(@onclick,'serfadd" + taskID[i] + "')]").InnerText;
                        if (balanseCheck == "0")
                        {
                            balanse.Add("Wait");
                        }
                        else
                        {
                            balanse.Add(doc.DocumentNode.SelectSingleNode("//span[contains(@onclick,'serfadd" + taskID[i] + "')]").InnerText);
                        }
                        */

                        this.dataGridView1.Rows.Add();

                        HtmlElementCollection status = webBrowser1.Document.GetElementById("advimg" + taskID[i] + "").GetElementsByTagName("span");

                        foreach (HtmlElement el in status)
                        {
                            if (el.InnerText != null && el.InnerText.Equals("Поднять!"))
                            {
                                el.InvokeMember("click");
                                break;
                            }
                        }

                        this.dataGridView1.Rows[i].Cells[0].Value = "ON";
                        this.dataGridView1.Rows[i].Cells[1].Value = topic[i];
                        this.dataGridView1.Rows[i].Cells[2].Value = approve[i];
                        this.dataGridView1.Rows[i].Cells[3].Value = working[i];
                        this.dataGridView1.Rows[i].Cells[4].Value = reject[i];
                        this.dataGridView1.Rows[i].Cells[5].Value = balanse[i];
                        dataGridView1.Refresh();
                    }
                    countTest.Text = nodes.Count.ToString();
                }
                else
                {
                    flag = false;
                }
        }
        
        public void waitMht(int sec) //wait for complite load page
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            }
            while (Tthen.AddSeconds(sec) > DateTime.Now);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var file = webBrowser1.DocumentText;
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(file);
            if (flag)
            {
                if (e.ColumnIndex == 6 && e.RowIndex != -1)
                {
                    if (balanse[e.RowIndex] != "Пополнить" && balanse[e.RowIndex] != "Отправить на проверку" && balanse[e.RowIndex] != "Ожидает проверки")
                    {
                       // taskUp(e.RowIndex);
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Нельзя выполнять данное действия (задание или на проверке или баланс отрицательный)");
                    }
                }
            }

            if (e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                if (balanse[e.RowIndex] != "Пополнить" && balanse[e.RowIndex] != "Отправить на проверку" && balanse[e.RowIndex] != "Ожидает проверки")
                {
                    rowNum = e.RowIndex;
                    Form2 f2 = new Form2();
                    f2.f1 = this;
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Нельзя выполнять данное действия (задание или на проверке или баланс отрицательный)");
                }
            }
        }

        public void taskUp(int rowNum7)
        {
            try
            {
                MessageBox.Show("Задание '" + topic[rowNum7] + "' поднято");
                /*открываем таблицу с кнопкой "поднять"*/
                HtmlElementCollection clickOpenUp = webBrowser1.Document.GetElementById("adv" + taskID[rowNum7] + "").GetElementsByTagName("span");

                foreach (HtmlElement el in clickOpenUp)
                {
                    if (el.InnerText != null && el.InnerText.Equals("↑")) //доделать чтоб сообщение выводилось 1 раз (3й элемент массива это стрелка)
                    {
                        el.InvokeMember("click");
                        break;
                    }
                    else
                    {
                        //MessageBox.Show("Задание " +topic[e.RowIndex]+ " находится уже в топовой позиции");
                    }
                }

                /*нажимаем на "поднять"*/
                HtmlElementCollection clickUp = webBrowser1.Document.GetElementById("taskup" + taskID[rowNum7] + "").GetElementsByTagName("span");

                foreach (HtmlElement el in clickUp)
                {
                    if (el.InnerText != null && el.InnerText.Equals("Поднять!"))
                    {
                        el.InvokeMember("click");
                        break;
                    }
                }
            }
            catch { MessageBox.Show("Поднять задание нельзя, что-то пошло не так..."); }
              
        }

/*
        private void timer_Tick(object sender, EventArgs e)
        {
            if ((minutesF1 == 0) && (hoursF1 == 0) && (secondsF1 == 0))
            {
                timer.Enabled = false;
                taskUp(rowNum); //call to method 
                MessageBox.Show("secc");
            }
            else
            { // Else continue counting.
                if (secondsF1 < 1)
                {
                    secondsF1 = 59;
                    if (minutesF1 == 0)
                    {
                        minutesF1 = 59;
                        if (hoursF1 != 0)
                            hoursF1 -= 1;

                    }
                    else
                    {
                        minutesF1 -= 1;
                    }
                }
                else
                    secondsF1 -= 1;
            }
        }
*/
        public void timerStart(string hour, string min, string sec, DateTime tm)
        {
            this.dataGridView1.Rows[rowNum].Cells[7].Value = tm;
            this.dataGridView1.Refresh(); 

            if (dictionary.Count == 0)
            {
                dictionary.Add(rowNum, tm); //добавления значение для 1го таймера
            }
            else
            {
                for (int i = 0; i < dictionary.Count; i++) //проверка если в строке уже есть таймер, то переприсвоить его
                {
                    if (dictionary.ContainsKey(rowNum))
                    {
                        dictionary[rowNum] = tm;
                    }
                    else
                    {
                        dictionary.Add(rowNum, tm);
                    }
                }
            }
            minimumTime();
        }

        public void minimumTime()
        {
            var minimum = dictionary.OrderBy(kvp => kvp.Value).First();
            var minKey = minimum.Key;
            var minValue = minimum.Value;

            hoursF1 = Convert.ToInt32(minValue.Hour);
            minutesF1 = Convert.ToInt32(minValue.Minute);
            secondsF1 = Convert.ToInt32(minValue.Second);
            yearF1 = minValue.Year;
            monthF1 = minValue.Month;
            dayF1 = minValue.Day;
        }

        public void globalTime_tick(object sender, EventArgs e)
        {
            DateTime ThToday = DateTime.Now;
            string ThData = ThToday.ToLongTimeString();
            time_label.Text = ThData;

            
            if ((yearF1 == System.DateTime.Now.Year) && (monthF1 == System.DateTime.Now.Month) && (dayF1 == System.DateTime.Now.Day) && (hoursF1 == System.DateTime.Now.Hour) && (minutesF1 == System.DateTime.Now.Minute) && (secondsF1 == System.DateTime.Now.Second))
            {
                var minimum = dictionary.OrderBy(kvp => kvp.Value).First();
                var minKey = minimum.Key;
                taskUp(minKey);
                dictionary.Remove(minKey);
                this.dataGridView1.Rows[minKey].Cells[7].Value = "";
                this.dataGridView1.Refresh(); 


                if (dictionary.Count > 0)
                {
                    minimumTime();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer globalTimer = new System.Windows.Forms.Timer();
            globalTimer.Tick += new EventHandler(globalTime_tick);
            globalTimer.Interval = 1000;
            globalTimer.Start();
        }

        private void ref_pic_capt_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label4.Visible = false;
            Start();
        }

        private void ref_butt_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Refresh();
        }

    }
}
