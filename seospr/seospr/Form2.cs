using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seospr
{
    public partial class Form2 : Form
    {
        public Form1 f1;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void nok_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            MyClass inst = new MyClass();
            inst.hrPar = hour_textF2.Text;
            inst.mnPar = min_textF2.Text;
            inst.scPar = sec_textF2.Text;
            

            if (inst.hrPar != "-1" && inst.mnPar != "-1" && inst.scPar != "-1")
            {
                DateTime dateTime = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, Convert.ToInt32(inst.hrPar), Convert.ToInt32(inst.mnPar), Convert.ToInt32(inst.scPar));

                if (dateTime < DateTime.Now)
                {
                    MessageBox.Show("Это время уже прошло");
                }
                else
                {
                    //MessageBox.Show(dateTime.ToString());
                    f1.timerStart(inst.hrPar, inst.mnPar, inst.scPar, dateTime);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Некоторые значения были пропущены");
            }
                
           
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = hour_textF2;
        }

        private void hour_textF2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.')) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show("Это поле числовое");
                }
            }

        }

        private void min_textF2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.')) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show("Это поле числовое");
                }
            }

        }

        private void sec_textF2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.')) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show("Это поле числовое");
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // закрытие окна по нажатию на ESC
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }


    public class MyClass
    {
        private string hour = null;
        private string min = null;
        private string sec = null;

        public string hrPar
        {
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Поле часы не может быть пустым");
                }
                else
                {
                    if (Regex.IsMatch(value.ToString(), @"[а-я]+$"))
                    {
                        MessageBox.Show("Часы не могут содержать строку");
                    }
                    else if (Convert.ToInt32(value) < 0 && Convert.ToInt32(value) > 24)
                    {
                        MessageBox.Show("Часы должны быть больше 0 и меньше 23");
                    }
                    else
                    {
                        hour = value;
                    }
                }
            }
            get
            {
                if (hour != null)
                    return hour;
                else
                    return "-1";
            }

        }

        public string mnPar
        {
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Поле минуты не может быть пустым");
                }
                else
                {

                    if (Regex.IsMatch(value.ToString(), @"[а-я]+$"))
                    {
                        MessageBox.Show("Минуты не могут содержать строку");
                    }
                    else if (Convert.ToInt32(value) > 59 && Convert.ToInt32(value) < 0)
                    {
                        MessageBox.Show("Минуты должны быть больше 0 и меньше 59");
                    }
                    else
                    {
                        min = value;
                    }
                }
            }
            get
            {
                if (min != null)
                    return min;
                else
                    return "-1";
            }
        }

        public string scPar
        {
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Поле секунды не может быть пустым");
                }
                else
                {
                    if (Regex.IsMatch(value.ToString(), @"[а-я]+$") && Regex.IsMatch(value.ToString(), @"[a-z]+$"))
                    {
                        MessageBox.Show("Секунды не могут содержать строку");
                    }
                    else if (Convert.ToInt32(value) > 59 && Convert.ToInt32(value) < 0)
                    {
                        MessageBox.Show("Секунды должны быть больше 0 и меньше 59");
                    }
                    else
                    {
                        sec = value;
                    }
                }
            }
            get
            {
                if (sec != null)
                    return sec;
                else
                    return "-1";
            }
        }

    }
}
