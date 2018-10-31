namespace Reminder
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
            this.Title = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Tb_dsr = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_title = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Location = new System.Drawing.Point(41, 44);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(85, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Select Reminder";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // search
            // 
            this.search.FormattingEnabled = true;
            this.search.Location = new System.Drawing.Point(156, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(133, 21);
            this.search.TabIndex = 1;
            this.search.Text = "------ select event title------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tb_dsr
            // 
            this.Tb_dsr.Location = new System.Drawing.Point(155, 163);
            this.Tb_dsr.Name = "Tb_dsr";
            this.Tb_dsr.Size = new System.Drawing.Size(200, 20);
            this.Tb_dsr.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descreption";
            // 
            // Tb_title
            // 
            this.Tb_title.Location = new System.Drawing.Point(155, 125);
            this.Tb_title.Name = "Tb_title";
            this.Tb_title.Size = new System.Drawing.Size(200, 20);
            this.Tb_title.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Eventname ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Task Date";
            // 
            // TaskDate
            // 
            this.TaskDate.Location = new System.Drawing.Point(155, 86);
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.Size = new System.Drawing.Size(200, 20);
            this.TaskDate.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 255);
            this.Controls.Add(this.TaskDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tb_dsr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox Tb_dsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Tb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TaskDate;
    }
}