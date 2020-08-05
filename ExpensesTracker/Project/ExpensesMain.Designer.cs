namespace ExpensesTracker.Project
{
    partial class ExpensesMain
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
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.lblUserMain = new System.Windows.Forms.Label();
            this.groupBoxHusbWife = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxHusbWife = new System.Windows.Forms.PictureBox();
            this.groupBoxExpenses = new System.Windows.Forms.GroupBox();
            this.groupBoxShare = new System.Windows.Forms.GroupBox();
            this.groupBoxHusbWife.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHusbWife)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(335, 9);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(187, 25);
            this.lblMainHeading.TabIndex = 1;
            this.lblMainHeading.Text = "Expenses Tracker";
            // 
            // lblUserMain
            // 
            this.lblUserMain.AutoSize = true;
            this.lblUserMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMain.Location = new System.Drawing.Point(776, 10);
            this.lblUserMain.Name = "lblUserMain";
            this.lblUserMain.Size = new System.Drawing.Size(42, 17);
            this.lblUserMain.TabIndex = 2;
            this.lblUserMain.Text = "User";
            // 
            // groupBoxHusbWife
            // 
            this.groupBoxHusbWife.Controls.Add(this.button1);
            this.groupBoxHusbWife.Controls.Add(this.pictureBoxHusbWife);
            this.groupBoxHusbWife.Location = new System.Drawing.Point(12, 64);
            this.groupBoxHusbWife.Name = "groupBoxHusbWife";
            this.groupBoxHusbWife.Size = new System.Drawing.Size(280, 421);
            this.groupBoxHusbWife.TabIndex = 3;
            this.groupBoxHusbWife.TabStop = false;
            this.groupBoxHusbWife.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(0, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "Husband Wife";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxHusbWife
            // 
            this.pictureBoxHusbWife.Image = global::ExpensesTracker.Properties.Resources.Husband_Wife;
            this.pictureBoxHusbWife.Location = new System.Drawing.Point(6, 0);
            this.pictureBoxHusbWife.Name = "pictureBoxHusbWife";
            this.pictureBoxHusbWife.Size = new System.Drawing.Size(268, 308);
            this.pictureBoxHusbWife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHusbWife.TabIndex = 0;
            this.pictureBoxHusbWife.TabStop = false;
            // 
            // groupBoxExpenses
            // 
            this.groupBoxExpenses.Location = new System.Drawing.Point(323, 64);
            this.groupBoxExpenses.Name = "groupBoxExpenses";
            this.groupBoxExpenses.Size = new System.Drawing.Size(280, 421);
            this.groupBoxExpenses.TabIndex = 4;
            this.groupBoxExpenses.TabStop = false;
            this.groupBoxExpenses.Text = "groupBox2";
            // 
            // groupBoxShare
            // 
            this.groupBoxShare.Location = new System.Drawing.Point(631, 64);
            this.groupBoxShare.Name = "groupBoxShare";
            this.groupBoxShare.Size = new System.Drawing.Size(280, 421);
            this.groupBoxShare.TabIndex = 4;
            this.groupBoxShare.TabStop = false;
            this.groupBoxShare.Text = "groupBox3";
            // 
            // ExpensesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(926, 497);
            this.Controls.Add(this.groupBoxShare);
            this.Controls.Add(this.groupBoxExpenses);
            this.Controls.Add(this.groupBoxHusbWife);
            this.Controls.Add(this.lblUserMain);
            this.Controls.Add(this.lblMainHeading);
            this.Name = "ExpensesMain";
            this.Text = "Expenses Tracker";
            this.groupBoxHusbWife.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHusbWife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Label lblUserMain;
        private System.Windows.Forms.GroupBox groupBoxHusbWife;
        private System.Windows.Forms.GroupBox groupBoxExpenses;
        private System.Windows.Forms.GroupBox groupBoxShare;
        private System.Windows.Forms.PictureBox pictureBoxHusbWife;
        private System.Windows.Forms.Button button1;
    }
}