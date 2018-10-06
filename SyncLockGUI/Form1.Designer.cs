namespace SyncLockGUI
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
            this.txtBxBuf = new System.Windows.Forms.TextBox();
            this.txtxWriter = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxBuf
            // 
            this.txtBxBuf.Location = new System.Drawing.Point(383, 12);
            this.txtBxBuf.Multiline = true;
            this.txtBxBuf.Name = "txtBxBuf";
            this.txtBxBuf.Size = new System.Drawing.Size(273, 306);
            this.txtBxBuf.TabIndex = 0;
            // 
            // txtxWriter
            // 
            this.txtxWriter.Location = new System.Drawing.Point(45, 75);
            this.txtxWriter.Name = "txtxWriter";
            this.txtxWriter.Size = new System.Drawing.Size(168, 20);
            this.txtxWriter.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(87, 275);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 330);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtxWriter);
            this.Controls.Add(this.txtBxBuf);
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxBuf;
        private System.Windows.Forms.TextBox txtxWriter;
        private System.Windows.Forms.Button btnStart;
    }
}

