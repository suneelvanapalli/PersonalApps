namespace FindMyFiles
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
            this.txtSerchTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSerchTerm
            // 
            this.txtSerchTerm.Location = new System.Drawing.Point(101, 21);
            this.txtSerchTerm.Name = "txtSerchTerm";
            this.txtSerchTerm.Size = new System.Drawing.Size(293, 20);
            this.txtSerchTerm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Term";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(417, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Pattern";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(101, 60);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(84, 20);
            this.txtPattern.TabIndex = 1;
            this.txtPattern.Text = "*";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(101, 98);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFiles.Size = new System.Drawing.Size(508, 238);
            this.lstFiles.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Copy Selected Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Destination";
            // 
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(101, 373);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(293, 20);
            this.txtDestPath.TabIndex = 7;
            this.txtDestPath.Text = "D:\\Temp";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(615, 268);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(149, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 423);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerchTerm);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerchTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestPath;
        private System.Windows.Forms.Button btnOpen;
    }
}

