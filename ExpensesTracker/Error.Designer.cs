namespace ExpensesTracker
{
    partial class Error
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblSourceValue = new System.Windows.Forms.Label();
            this.lblExceptionMsgValue = new System.Windows.Forms.Label();
            this.lblExceptionMsg = new System.Windows.Forms.Label();
            this.lblStackTraceValue = new System.Windows.Forms.Label();
            this.lblStackTrace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSource.Location = new System.Drawing.Point(74, 52);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(79, 22);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Source : ";
            // 
            // lblSourceValue
            // 
            this.lblSourceValue.AutoSize = true;
            this.lblSourceValue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSourceValue.Location = new System.Drawing.Point(174, 52);
            this.lblSourceValue.Name = "lblSourceValue";
            this.lblSourceValue.Size = new System.Drawing.Size(113, 22);
            this.lblSourceValue.TabIndex = 3;
            this.lblSourceValue.Text = "Source Value";
            // 
            // lblExceptionMsgValue
            // 
            this.lblExceptionMsgValue.AutoSize = true;
            this.lblExceptionMsgValue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblExceptionMsgValue.Location = new System.Drawing.Point(174, 91);
            this.lblExceptionMsgValue.Name = "lblExceptionMsgValue";
            this.lblExceptionMsgValue.Size = new System.Drawing.Size(176, 22);
            this.lblExceptionMsgValue.TabIndex = 5;
            this.lblExceptionMsgValue.Text = "Exception Msg Value";
            // 
            // lblExceptionMsg
            // 
            this.lblExceptionMsg.AutoSize = true;
            this.lblExceptionMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblExceptionMsg.Location = new System.Drawing.Point(13, 91);
            this.lblExceptionMsg.Name = "lblExceptionMsg";
            this.lblExceptionMsg.Size = new System.Drawing.Size(142, 22);
            this.lblExceptionMsg.TabIndex = 4;
            this.lblExceptionMsg.Text = "Exception Msg : ";
            // 
            // lblStackTraceValue
            // 
            this.lblStackTraceValue.AutoSize = true;
            this.lblStackTraceValue.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStackTraceValue.Location = new System.Drawing.Point(174, 132);
            this.lblStackTraceValue.Name = "lblStackTraceValue";
            this.lblStackTraceValue.Size = new System.Drawing.Size(166, 22);
            this.lblStackTraceValue.TabIndex = 7;
            this.lblStackTraceValue.Text = "Stack Trace Value : ";
            // 
            // lblStackTrace
            // 
            this.lblStackTrace.AutoSize = true;
            this.lblStackTrace.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStackTrace.Location = new System.Drawing.Point(37, 132);
            this.lblStackTrace.Name = "lblStackTrace";
            this.lblStackTrace.Size = new System.Drawing.Size(117, 22);
            this.lblStackTrace.TabIndex = 6;
            this.lblStackTrace.Text = "Stack Trace : ";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(541, 340);
            this.Controls.Add(this.lblStackTraceValue);
            this.Controls.Add(this.lblStackTrace);
            this.Controls.Add(this.lblExceptionMsgValue);
            this.Controls.Add(this.lblExceptionMsg);
            this.Controls.Add(this.lblSourceValue);
            this.Controls.Add(this.lblSource);
            this.Name = "Error";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblSourceValue;
        private System.Windows.Forms.Label lblExceptionMsgValue;
        private System.Windows.Forms.Label lblExceptionMsg;
        private System.Windows.Forms.Label lblStackTraceValue;
        private System.Windows.Forms.Label lblStackTrace;
    }
}