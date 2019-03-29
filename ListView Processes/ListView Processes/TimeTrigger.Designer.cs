namespace ListView_Processes
{
    partial class TimeTrigger
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.hoursText = new System.Windows.Forms.TextBox();
            this.minutesText = new System.Windows.Forms.TextBox();
            this.secondsText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.programmsToClose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Файл...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectFile);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2019, 3, 28, 15, 54, 44, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Запуск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StartTimeTrigger);
            // 
            // hoursText
            // 
            this.hoursText.Location = new System.Drawing.Point(290, 130);
            this.hoursText.MaxLength = 2;
            this.hoursText.Name = "hoursText";
            this.hoursText.Size = new System.Drawing.Size(21, 20);
            this.hoursText.TabIndex = 4;
            this.hoursText.Text = "HH";
            // 
            // minutesText
            // 
            this.minutesText.Location = new System.Drawing.Point(317, 130);
            this.minutesText.MaxLength = 2;
            this.minutesText.Name = "minutesText";
            this.minutesText.Size = new System.Drawing.Size(25, 20);
            this.minutesText.TabIndex = 5;
            this.minutesText.Text = "MM";
            // 
            // secondsText
            // 
            this.secondsText.Location = new System.Drawing.Point(348, 130);
            this.secondsText.MaxLength = 2;
            this.secondsText.Name = "secondsText";
            this.secondsText.Size = new System.Drawing.Size(21, 20);
            this.secondsText.TabIndex = 6;
            this.secondsText.Text = "SS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Завершение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.StartTimeTrigger);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите программу для запуска по времени";
            // 
            // programmsToClose
            // 
            this.programmsToClose.FormattingEnabled = true;
            this.programmsToClose.Location = new System.Drawing.Point(12, 79);
            this.programmsToClose.Name = "programmsToClose";
            this.programmsToClose.Size = new System.Drawing.Size(250, 21);
            this.programmsToClose.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите процесс для завершения по времени";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Выберите время для запуска/завершения";
            // 
            // TimeTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programmsToClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.secondsText);
            this.Controls.Add(this.minutesText);
            this.Controls.Add(this.hoursText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(483, 217);
            this.MinimumSize = new System.Drawing.Size(483, 217);
            this.Name = "TimeTrigger";
            this.Text = "Запуск по времени";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox hoursText;
        private System.Windows.Forms.TextBox minutesText;
        private System.Windows.Forms.TextBox secondsText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox programmsToClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}