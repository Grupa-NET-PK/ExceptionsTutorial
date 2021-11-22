
namespace WindowsFormsApp1
{
    partial class DateConverter
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
            this.buttonSetDateInCalendar = new System.Windows.Forms.Button();
            this.textBoxUserDate = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.linkLabelInstruction = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonSetDateInCalendar
            // 
            this.buttonSetDateInCalendar.Location = new System.Drawing.Point(242, 229);
            this.buttonSetDateInCalendar.Name = "buttonSetDateInCalendar";
            this.buttonSetDateInCalendar.Size = new System.Drawing.Size(293, 23);
            this.buttonSetDateInCalendar.TabIndex = 2;
            this.buttonSetDateInCalendar.Text = "ustaw datę w kalendarzu";
            this.buttonSetDateInCalendar.UseVisualStyleBackColor = true;
            this.buttonSetDateInCalendar.Click += new System.EventHandler(this.buttonSetDateInCalendar_Click);
            // 
            // textBoxUserDate
            // 
            this.textBoxUserDate.Location = new System.Drawing.Point(339, 186);
            this.textBoxUserDate.Name = "textBoxUserDate";
            this.textBoxUserDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserDate.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(221, 268);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(338, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // linkLabelInstruction
            // 
            this.linkLabelInstruction.AutoSize = true;
            this.linkLabelInstruction.Location = new System.Drawing.Point(253, 132);
            this.linkLabelInstruction.Name = "linkLabelInstruction";
            this.linkLabelInstruction.Size = new System.Drawing.Size(269, 17);
            this.linkLabelInstruction.TabIndex = 0;
            this.linkLabelInstruction.TabStop = true;
            this.linkLabelInstruction.Text = "wprowadź datę w formacie DD-MM-RRRR";
            this.linkLabelInstruction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInstruction_LinkClicked);
            // 
            // DateConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelInstruction);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxUserDate);
            this.Controls.Add(this.buttonSetDateInCalendar);
            this.Name = "DateConverter";
            this.Text = "Date Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetDateInCalendar;
        private System.Windows.Forms.TextBox textBoxUserDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.LinkLabel linkLabelInstruction;
    }
}

