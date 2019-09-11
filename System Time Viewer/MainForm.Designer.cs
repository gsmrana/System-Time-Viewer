namespace System_Time_Viewer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxDateTimeFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxCurrentTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTimeZone = new System.Windows.Forms.ComboBox();
            this.buttonSetTimeZone = new System.Windows.Forms.Button();
            this.buttonSetFormat = new System.Windows.Forms.Button();
            this.buttonCopyCurrentTime = new System.Windows.Forms.Button();
            this.buttonCopyMarkedTime = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarkedTime = new System.Windows.Forms.TextBox();
            this.buttonCopyTimeSpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTimeSpan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDateTimeFormat
            // 
            this.textBoxDateTimeFormat.Location = new System.Drawing.Point(79, 90);
            this.textBoxDateTimeFormat.Name = "textBoxDateTimeFormat";
            this.textBoxDateTimeFormat.Size = new System.Drawing.Size(166, 20);
            this.textBoxDateTimeFormat.TabIndex = 8;
            this.textBoxDateTimeFormat.Text = "dd/MM/yyyy hh:mm:ss tt";
            this.textBoxDateTimeFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Format";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBoxCurrentTime
            // 
            this.textBoxCurrentTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCurrentTime.ForeColor = System.Drawing.Color.DarkViolet;
            this.textBoxCurrentTime.Location = new System.Drawing.Point(79, 12);
            this.textBoxCurrentTime.Name = "textBoxCurrentTime";
            this.textBoxCurrentTime.ReadOnly = true;
            this.textBoxCurrentTime.Size = new System.Drawing.Size(166, 20);
            this.textBoxCurrentTime.TabIndex = 5;
            this.textBoxCurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time Zone";
            // 
            // comboBoxTimeZone
            // 
            this.comboBoxTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeZone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxTimeZone.FormattingEnabled = true;
            this.comboBoxTimeZone.Location = new System.Drawing.Point(79, 116);
            this.comboBoxTimeZone.Name = "comboBoxTimeZone";
            this.comboBoxTimeZone.Size = new System.Drawing.Size(166, 21);
            this.comboBoxTimeZone.TabIndex = 9;
            // 
            // buttonSetTimeZone
            // 
            this.buttonSetTimeZone.Location = new System.Drawing.Point(251, 114);
            this.buttonSetTimeZone.Name = "buttonSetTimeZone";
            this.buttonSetTimeZone.Size = new System.Drawing.Size(40, 23);
            this.buttonSetTimeZone.TabIndex = 4;
            this.buttonSetTimeZone.Text = "Set";
            this.buttonSetTimeZone.UseVisualStyleBackColor = true;
            this.buttonSetTimeZone.Click += new System.EventHandler(this.ButtonSetTimeZone_Click);
            // 
            // buttonSetFormat
            // 
            this.buttonSetFormat.Location = new System.Drawing.Point(251, 87);
            this.buttonSetFormat.Name = "buttonSetFormat";
            this.buttonSetFormat.Size = new System.Drawing.Size(40, 23);
            this.buttonSetFormat.TabIndex = 3;
            this.buttonSetFormat.Text = "Set";
            this.buttonSetFormat.UseVisualStyleBackColor = true;
            this.buttonSetFormat.Click += new System.EventHandler(this.ButtonSetFormat_Click);
            // 
            // buttonCopyCurrentTime
            // 
            this.buttonCopyCurrentTime.Location = new System.Drawing.Point(251, 10);
            this.buttonCopyCurrentTime.Name = "buttonCopyCurrentTime";
            this.buttonCopyCurrentTime.Size = new System.Drawing.Size(40, 23);
            this.buttonCopyCurrentTime.TabIndex = 0;
            this.buttonCopyCurrentTime.Text = "Copy";
            this.buttonCopyCurrentTime.UseVisualStyleBackColor = true;
            this.buttonCopyCurrentTime.Click += new System.EventHandler(this.ButtonCopyCurrentTime_Click);
            // 
            // buttonCopyMarkedTime
            // 
            this.buttonCopyMarkedTime.Location = new System.Drawing.Point(251, 36);
            this.buttonCopyMarkedTime.Name = "buttonCopyMarkedTime";
            this.buttonCopyMarkedTime.Size = new System.Drawing.Size(40, 23);
            this.buttonCopyMarkedTime.TabIndex = 1;
            this.buttonCopyMarkedTime.Text = "Copy";
            this.buttonCopyMarkedTime.UseVisualStyleBackColor = true;
            this.buttonCopyMarkedTime.Click += new System.EventHandler(this.ButtonCopyMarkedTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Marked Time";
            // 
            // textBoxMarkedTime
            // 
            this.textBoxMarkedTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMarkedTime.ForeColor = System.Drawing.Color.Blue;
            this.textBoxMarkedTime.Location = new System.Drawing.Point(79, 38);
            this.textBoxMarkedTime.Name = "textBoxMarkedTime";
            this.textBoxMarkedTime.ReadOnly = true;
            this.textBoxMarkedTime.Size = new System.Drawing.Size(166, 20);
            this.textBoxMarkedTime.TabIndex = 6;
            this.textBoxMarkedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCopyTimeSpan
            // 
            this.buttonCopyTimeSpan.Location = new System.Drawing.Point(251, 62);
            this.buttonCopyTimeSpan.Name = "buttonCopyTimeSpan";
            this.buttonCopyTimeSpan.Size = new System.Drawing.Size(40, 23);
            this.buttonCopyTimeSpan.TabIndex = 2;
            this.buttonCopyTimeSpan.Text = "Copy";
            this.buttonCopyTimeSpan.UseVisualStyleBackColor = true;
            this.buttonCopyTimeSpan.Click += new System.EventHandler(this.ButtonCopyTimeSpan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time Span";
            // 
            // textBoxTimeSpan
            // 
            this.textBoxTimeSpan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTimeSpan.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxTimeSpan.Location = new System.Drawing.Point(79, 64);
            this.textBoxTimeSpan.Name = "textBoxTimeSpan";
            this.textBoxTimeSpan.ReadOnly = true;
            this.textBoxTimeSpan.Size = new System.Drawing.Size(166, 20);
            this.textBoxTimeSpan.TabIndex = 7;
            this.textBoxTimeSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 151);
            this.Controls.Add(this.buttonCopyTimeSpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTimeSpan);
            this.Controls.Add(this.buttonCopyMarkedTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMarkedTime);
            this.Controls.Add(this.buttonCopyCurrentTime);
            this.Controls.Add(this.buttonSetFormat);
            this.Controls.Add(this.buttonSetTimeZone);
            this.Controls.Add(this.comboBoxTimeZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCurrentTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDateTimeFormat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "System Time Viewer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDateTimeFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxCurrentTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTimeZone;
        private System.Windows.Forms.Button buttonSetTimeZone;
        private System.Windows.Forms.Button buttonSetFormat;
        private System.Windows.Forms.Button buttonCopyCurrentTime;
        private System.Windows.Forms.Button buttonCopyMarkedTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMarkedTime;
        private System.Windows.Forms.Button buttonCopyTimeSpan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTimeSpan;
    }
}

