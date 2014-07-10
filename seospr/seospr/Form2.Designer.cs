namespace seospr
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ok_btn = new System.Windows.Forms.Button();
            this.nok_btn = new System.Windows.Forms.Button();
            this.hour_textF2 = new System.Windows.Forms.TextBox();
            this.min_textF2 = new System.Windows.Forms.TextBox();
            this.sec_textF2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(10, 88);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "Готово";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // nok_btn
            // 
            this.nok_btn.Location = new System.Drawing.Point(103, 88);
            this.nok_btn.Name = "nok_btn";
            this.nok_btn.Size = new System.Drawing.Size(75, 23);
            this.nok_btn.TabIndex = 1;
            this.nok_btn.Text = "Отмена";
            this.nok_btn.UseVisualStyleBackColor = true;
            this.nok_btn.Click += new System.EventHandler(this.nok_btn_Click);
            // 
            // hour_textF2
            // 
            this.hour_textF2.Location = new System.Drawing.Point(10, 59);
            this.hour_textF2.MaxLength = 2;
            this.hour_textF2.Name = "hour_textF2";
            this.hour_textF2.Size = new System.Drawing.Size(40, 20);
            this.hour_textF2.TabIndex = 2;
            this.hour_textF2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_textF2_KeyPress);
            // 
            // min_textF2
            // 
            this.min_textF2.Location = new System.Drawing.Point(74, 59);
            this.min_textF2.MaxLength = 2;
            this.min_textF2.Name = "min_textF2";
            this.min_textF2.Size = new System.Drawing.Size(40, 20);
            this.min_textF2.TabIndex = 3;
            this.min_textF2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.min_textF2_KeyPress);
            // 
            // sec_textF2
            // 
            this.sec_textF2.Location = new System.Drawing.Point(138, 59);
            this.sec_textF2.MaxLength = 2;
            this.sec_textF2.Name = "sec_textF2";
            this.sec_textF2.Size = new System.Drawing.Size(40, 20);
            this.sec_textF2.TabIndex = 4;
            this.sec_textF2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sec_textF2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(120, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Часы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Минуты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Секунды";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 124);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sec_textF2);
            this.Controls.Add(this.min_textF2);
            this.Controls.Add(this.hour_textF2);
            this.Controls.Add(this.nok_btn);
            this.Controls.Add(this.ok_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SeoSprint";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button nok_btn;
        private System.Windows.Forms.TextBox hour_textF2;
        private System.Windows.Forms.TextBox min_textF2;
        private System.Windows.Forms.TextBox sec_textF2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}