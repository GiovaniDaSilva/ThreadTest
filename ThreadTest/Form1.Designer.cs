namespace ThreadTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.txtMonitor = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnAddThead = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStart.Location = new System.Drawing.Point(11, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(503, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 87);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(502, 113);
            this.txtConsole.TabIndex = 1;
            this.txtConsole.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Processing";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 206);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(502, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.Location = new System.Drawing.Point(11, 382);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(134, 64);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop All";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop3.Location = new System.Drawing.Point(371, 382);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(70, 29);
            this.btnStop3.TabIndex = 5;
            this.btnStop3.Text = "Stop Id:";
            this.btnStop3.UseVisualStyleBackColor = false;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop2.Location = new System.Drawing.Point(265, 382);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(100, 29);
            this.btnStop2.TabIndex = 6;
            this.btnStop2.Text = "Stop Thread2";
            this.btnStop2.UseVisualStyleBackColor = false;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop1.Location = new System.Drawing.Point(160, 382);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(99, 29);
            this.btnStop1.TabIndex = 7;
            this.btnStop1.Text = "Stop Thread1";
            this.btnStop1.UseVisualStyleBackColor = false;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(11, 256);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.ReadOnly = true;
            this.txtMonitor.Size = new System.Drawing.Size(503, 120);
            this.txtMonitor.TabIndex = 8;
            this.txtMonitor.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Theads monitoring";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(160, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Error Thread1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancel2.Location = new System.Drawing.Point(265, 417);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 29);
            this.btnCancel2.TabIndex = 11;
            this.btnCancel2.Text = "Cancel Thread2";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnAddThead
            // 
            this.btnAddThead.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddThead.Enabled = false;
            this.btnAddThead.Location = new System.Drawing.Point(371, 417);
            this.btnAddThead.Name = "btnAddThead";
            this.btnAddThead.Size = new System.Drawing.Size(100, 29);
            this.btnAddThead.TabIndex = 12;
            this.btnAddThead.Text = "Add Thread";
            this.btnAddThead.UseVisualStyleBackColor = false;
            this.btnAddThead.Click += new System.EventHandler(this.btnAddThead_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(447, 387);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 23);
            this.txtId.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 452);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAddThead);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Processamento em Threads";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.RichTextBox txtMonitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnAddThead;
        private System.Windows.Forms.NumericUpDown txtId;
    }
}
