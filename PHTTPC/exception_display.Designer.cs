namespace PHTTPC
{
    partial class exception_display
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
            this.stacktrace = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exception = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stacktrace
            // 
            this.stacktrace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stacktrace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stacktrace.DetectUrls = false;
            this.stacktrace.Location = new System.Drawing.Point(2, 45);
            this.stacktrace.Name = "stacktrace";
            this.stacktrace.ReadOnly = true;
            this.stacktrace.Size = new System.Drawing.Size(515, 172);
            this.stacktrace.TabIndex = 0;
            this.stacktrace.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exception Encountered";
            // 
            // exception
            // 
            this.exception.AutoSize = true;
            this.exception.Location = new System.Drawing.Point(4, 29);
            this.exception.Name = "exception";
            this.exception.Size = new System.Drawing.Size(53, 13);
            this.exception.TabIndex = 2;
            this.exception.Text = "exception";
            // 
            // exception_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(520, 220);
            this.Controls.Add(this.exception);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stacktrace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1093, 589);
            this.Name = "exception_display";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exception Encountered";
            this.Load += new System.EventHandler(this.exception_display_getexception);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox stacktrace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exception;
    }
}