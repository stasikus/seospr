namespace seospr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.TextBox();
            this.capcha_text = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.error_lable = new System.Windows.Forms.Label();
            this.countTest = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ref_butt = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.ref_pic_capt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код";
            // 
            // login_text
            // 
            this.login_text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.login_text.Location = new System.Drawing.Point(81, 6);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(125, 20);
            this.login_text.TabIndex = 3;
            this.login_text.Text = "stasikusk@gmail.com";
            // 
            // pass_text
            // 
            this.pass_text.Location = new System.Drawing.Point(81, 33);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(125, 20);
            this.pass_text.TabIndex = 4;
            this.pass_text.Text = "CcQyarxbI3";
            // 
            // capcha_text
            // 
            this.capcha_text.Location = new System.Drawing.Point(400, 6);
            this.capcha_text.Name = "capcha_text";
            this.capcha_text.Size = new System.Drawing.Size(125, 20);
            this.capcha_text.TabIndex = 5;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(400, 31);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(125, 23);
            this.Submit_btn.TabIndex = 6;
            this.Submit_btn.Text = "Войти";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(5, 246);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(53);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(89, 70);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("http://www.seosprint.net/index.php", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            // 
            // error_lable
            // 
            this.error_lable.AutoSize = true;
            this.error_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_lable.ForeColor = System.Drawing.Color.Red;
            this.error_lable.Location = new System.Drawing.Point(531, 22);
            this.error_lable.Name = "error_lable";
            this.error_lable.Size = new System.Drawing.Size(142, 16);
            this.error_lable.TabIndex = 9;
            this.error_lable.Text = "Hеверные данные";
            this.error_lable.Visible = false;
            // 
            // countTest
            // 
            this.countTest.AutoSize = true;
            this.countTest.Location = new System.Drawing.Point(259, 25);
            this.countTest.Name = "countTest";
            this.countTest.Size = new System.Drawing.Size(0, 13);
            this.countTest.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(9, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(775, 245);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(212, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ref_butt
            // 
            this.ref_butt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ref_butt.BackgroundImage")));
            this.ref_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ref_butt.Location = new System.Drawing.Point(759, 36);
            this.ref_butt.Name = "ref_butt";
            this.ref_butt.Size = new System.Drawing.Size(25, 25);
            this.ref_butt.TabIndex = 13;
            this.ref_butt.UseVisualStyleBackColor = true;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(739, 6);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(0, 13);
            this.time_label.TabIndex = 14;
            // 
            // ref_pic_capt
            // 
            this.ref_pic_capt.BackColor = System.Drawing.SystemColors.Control;
            this.ref_pic_capt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ref_pic_capt.BackgroundImage")));
            this.ref_pic_capt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ref_pic_capt.Location = new System.Drawing.Point(368, 30);
            this.ref_pic_capt.Name = "ref_pic_capt";
            this.ref_pic_capt.Size = new System.Drawing.Size(25, 25);
            this.ref_pic_capt.TabIndex = 15;
            this.ref_pic_capt.UseVisualStyleBackColor = false;
            this.ref_pic_capt.Click += new System.EventHandler(this.ref_pic_capt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(268, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(360, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 43);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Column0
            // 
            this.Column0.FillWeight = 45F;
            this.Column0.Frozen = true;
            this.Column0.HeaderText = "Статус";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Width = 45;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 250F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 65F;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Одобрено";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 65;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 67F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Выполняют";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 67;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 65F;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Отклонено";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 65;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Баланс";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 60F;
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Поднять задание";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Text = "UP";
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 130F;
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Во сколько поднять";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "обновить если нет кода";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 322);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ref_pic_capt);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.ref_butt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.countTest);
            this.Controls.Add(this.error_lable);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.capcha_text);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(810, 360);
            this.MinimumSize = new System.Drawing.Size(810, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeoSprint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox capcha_text;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label error_lable;
        private System.Windows.Forms.Label countTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ref_butt;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Button ref_pic_capt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label4;
    }
}

