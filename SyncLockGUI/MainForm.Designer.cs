namespace SyncLockGUI
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
            this.txtBxBuf = new System.Windows.Forms.TextBox();
            this.txtxWriter = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBxReader1 = new System.Windows.Forms.TextBox();
            this.txtBxReader5 = new System.Windows.Forms.TextBox();
            this.txtBxReader4 = new System.Windows.Forms.TextBox();
            this.txtBxReader3 = new System.Windows.Forms.TextBox();
            this.txtBxReader2 = new System.Windows.Forms.TextBox();
            this.lblReader1 = new System.Windows.Forms.Label();
            this.lblReader5 = new System.Windows.Forms.Label();
            this.lblReader4 = new System.Windows.Forms.Label();
            this.lblReader3 = new System.Windows.Forms.Label();
            this.lblReader2 = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblBuffer = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxBuf
            // 
            this.txtBxBuf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxBuf.Location = new System.Drawing.Point(383, 31);
            this.txtBxBuf.Multiline = true;
            this.txtBxBuf.Name = "txtBxBuf";
            this.txtBxBuf.ReadOnly = true;
            this.txtBxBuf.Size = new System.Drawing.Size(273, 290);
            this.txtBxBuf.TabIndex = 0;
            // 
            // txtxWriter
            // 
            this.txtxWriter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtxWriter.Location = new System.Drawing.Point(83, 31);
            this.txtxWriter.Name = "txtxWriter";
            this.txtxWriter.ReadOnly = true;
            this.txtxWriter.Size = new System.Drawing.Size(294, 20);
            this.txtxWriter.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(55, 275);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBxReader1
            // 
            this.txtBxReader1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxReader1.Enabled = false;
            this.txtBxReader1.Location = new System.Drawing.Point(83, 74);
            this.txtBxReader1.Name = "txtBxReader1";
            this.txtBxReader1.ReadOnly = true;
            this.txtBxReader1.Size = new System.Drawing.Size(294, 20);
            this.txtBxReader1.TabIndex = 3;
            // 
            // txtBxReader5
            // 
            this.txtBxReader5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxReader5.Enabled = false;
            this.txtBxReader5.Location = new System.Drawing.Point(83, 178);
            this.txtBxReader5.Name = "txtBxReader5";
            this.txtBxReader5.ReadOnly = true;
            this.txtBxReader5.Size = new System.Drawing.Size(294, 20);
            this.txtBxReader5.TabIndex = 4;
            // 
            // txtBxReader4
            // 
            this.txtBxReader4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxReader4.Enabled = false;
            this.txtBxReader4.Location = new System.Drawing.Point(83, 152);
            this.txtBxReader4.Name = "txtBxReader4";
            this.txtBxReader4.ReadOnly = true;
            this.txtBxReader4.Size = new System.Drawing.Size(294, 20);
            this.txtBxReader4.TabIndex = 5;
            // 
            // txtBxReader3
            // 
            this.txtBxReader3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxReader3.Enabled = false;
            this.txtBxReader3.Location = new System.Drawing.Point(83, 126);
            this.txtBxReader3.Name = "txtBxReader3";
            this.txtBxReader3.ReadOnly = true;
            this.txtBxReader3.Size = new System.Drawing.Size(294, 20);
            this.txtBxReader3.TabIndex = 6;
            // 
            // txtBxReader2
            // 
            this.txtBxReader2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBxReader2.Enabled = false;
            this.txtBxReader2.Location = new System.Drawing.Point(83, 100);
            this.txtBxReader2.Name = "txtBxReader2";
            this.txtBxReader2.ReadOnly = true;
            this.txtBxReader2.Size = new System.Drawing.Size(294, 20);
            this.txtBxReader2.TabIndex = 7;
            // 
            // lblReader1
            // 
            this.lblReader1.AutoSize = true;
            this.lblReader1.Location = new System.Drawing.Point(12, 77);
            this.lblReader1.Name = "lblReader1";
            this.lblReader1.Size = new System.Drawing.Size(65, 13);
            this.lblReader1.TabIndex = 8;
            this.lblReader1.Text = "Reader №1:";
            // 
            // lblReader5
            // 
            this.lblReader5.AutoSize = true;
            this.lblReader5.Location = new System.Drawing.Point(12, 181);
            this.lblReader5.Name = "lblReader5";
            this.lblReader5.Size = new System.Drawing.Size(65, 13);
            this.lblReader5.TabIndex = 9;
            this.lblReader5.Text = "Reader №5:";
            // 
            // lblReader4
            // 
            this.lblReader4.AutoSize = true;
            this.lblReader4.Location = new System.Drawing.Point(12, 155);
            this.lblReader4.Name = "lblReader4";
            this.lblReader4.Size = new System.Drawing.Size(65, 13);
            this.lblReader4.TabIndex = 10;
            this.lblReader4.Text = "Reader №4:";
            // 
            // lblReader3
            // 
            this.lblReader3.AutoSize = true;
            this.lblReader3.Location = new System.Drawing.Point(12, 129);
            this.lblReader3.Name = "lblReader3";
            this.lblReader3.Size = new System.Drawing.Size(65, 13);
            this.lblReader3.TabIndex = 11;
            this.lblReader3.Text = "Reader №3:";
            // 
            // lblReader2
            // 
            this.lblReader2.AutoSize = true;
            this.lblReader2.Location = new System.Drawing.Point(12, 103);
            this.lblReader2.Name = "lblReader2";
            this.lblReader2.Size = new System.Drawing.Size(65, 13);
            this.lblReader2.TabIndex = 12;
            this.lblReader2.Text = "Reader №2:";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(12, 34);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(38, 13);
            this.lblWriter.TabIndex = 13;
            this.lblWriter.Text = "Writer:";
            // 
            // lblBuffer
            // 
            this.lblBuffer.AutoSize = true;
            this.lblBuffer.Location = new System.Drawing.Point(383, 15);
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(38, 13);
            this.lblBuffer.TabIndex = 14;
            this.lblBuffer.Text = "Buffer:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(244, 275);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 330);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblBuffer);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.lblReader2);
            this.Controls.Add(this.lblReader3);
            this.Controls.Add(this.lblReader4);
            this.Controls.Add(this.lblReader5);
            this.Controls.Add(this.lblReader1);
            this.Controls.Add(this.txtBxReader2);
            this.Controls.Add(this.txtBxReader3);
            this.Controls.Add(this.txtBxReader4);
            this.Controls.Add(this.txtBxReader5);
            this.Controls.Add(this.txtBxReader1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtxWriter);
            this.Controls.Add(this.txtBxBuf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxBuf;
        private System.Windows.Forms.TextBox txtxWriter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBxReader1;
        private System.Windows.Forms.TextBox txtBxReader5;
        private System.Windows.Forms.TextBox txtBxReader4;
        private System.Windows.Forms.TextBox txtBxReader3;
        private System.Windows.Forms.TextBox txtBxReader2;
        private System.Windows.Forms.Label lblReader1;
        private System.Windows.Forms.Label lblReader5;
        private System.Windows.Forms.Label lblReader4;
        private System.Windows.Forms.Label lblReader3;
        private System.Windows.Forms.Label lblReader2;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblBuffer;
        private System.Windows.Forms.Button btnStop;
    }
}

