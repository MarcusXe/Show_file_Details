namespace Show_file_Details
{
    partial class search_bt
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
            this.filePath_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileName_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileExt_tb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.errorLog_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSize_tb = new System.Windows.Forms.TextBox();
            this.labelssd = new System.Windows.Forms.Label();
            this.DirName_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filePath_tb
            // 
            this.filePath_tb.Location = new System.Drawing.Point(78, 32);
            this.filePath_tb.Name = "filePath_tb";
            this.filePath_tb.Size = new System.Drawing.Size(205, 20);
            this.filePath_tb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "FilePath:";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FileName:";
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileName_tb
            // 
            this.fileName_tb.Location = new System.Drawing.Point(78, 58);
            this.fileName_tb.Name = "fileName_tb";
            this.fileName_tb.Size = new System.Drawing.Size(300, 20);
            this.fileName_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "FileExt:";
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileExt_tb
            // 
            this.fileExt_tb.Location = new System.Drawing.Point(78, 84);
            this.fileExt_tb.Name = "fileExt_tb";
            this.fileExt_tb.Size = new System.Drawing.Size(300, 20);
            this.fileExt_tb.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorLog_lb
            // 
            this.errorLog_lb.AutoSize = true;
            this.errorLog_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.errorLog_lb.Location = new System.Drawing.Point(3, 382);
            this.errorLog_lb.Name = "errorLog_lb";
            this.errorLog_lb.Size = new System.Drawing.Size(0, 13);
            this.errorLog_lb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "FileSize:";
            this.label4.UseCompatibleTextRendering = true;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileSize_tb
            // 
            this.fileSize_tb.Location = new System.Drawing.Point(78, 110);
            this.fileSize_tb.Name = "fileSize_tb";
            this.fileSize_tb.Size = new System.Drawing.Size(300, 20);
            this.fileSize_tb.TabIndex = 7;
            // 
            // labelssd
            // 
            this.labelssd.AutoSize = true;
            this.labelssd.Location = new System.Drawing.Point(16, 140);
            this.labelssd.Name = "labelssd";
            this.labelssd.Size = new System.Drawing.Size(52, 17);
            this.labelssd.TabIndex = 2;
            this.labelssd.Text = "DirName:";
            this.labelssd.UseCompatibleTextRendering = true;
            this.labelssd.Click += new System.EventHandler(this.label1_Click);
            // 
            // DirName_tb
            // 
            this.DirName_tb.Location = new System.Drawing.Point(81, 137);
            this.DirName_tb.Name = "DirName_tb";
            this.DirName_tb.Size = new System.Drawing.Size(297, 20);
            this.DirName_tb.TabIndex = 8;
            // 
            // search_bt
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 415);
            this.Controls.Add(this.DirName_tb);
            this.Controls.Add(this.fileSize_tb);
            this.Controls.Add(this.errorLog_lb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fileExt_tb);
            this.Controls.Add(this.fileName_tb);
            this.Controls.Add(this.labelssd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filePath_tb);
            this.Name = "search_bt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileName_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileExt_tb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorLog_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileSize_tb;
        private System.Windows.Forms.Label labelssd;
        private System.Windows.Forms.TextBox DirName_tb;
    }
}

