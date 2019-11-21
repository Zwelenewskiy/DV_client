namespace DV_client
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
            this.DGV_emails = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.письмоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_saveEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_getEmails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_emails)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_emails
            // 
            this.DGV_emails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_emails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_emails.Location = new System.Drawing.Point(12, 27);
            this.DGV_emails.Name = "DGV_emails";
            this.DGV_emails.Size = new System.Drawing.Size(946, 435);
            this.DGV_emails.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.письмоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // письмоToolStripMenuItem
            // 
            this.письмоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_saveEmail,
            this.TSMI_getEmails});
            this.письмоToolStripMenuItem.Name = "письмоToolStripMenuItem";
            this.письмоToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.письмоToolStripMenuItem.Text = "Письма";
            // 
            // TSMI_saveEmail
            // 
            this.TSMI_saveEmail.Name = "TSMI_saveEmail";
            this.TSMI_saveEmail.Size = new System.Drawing.Size(180, 22);
            this.TSMI_saveEmail.Text = "Сохранить";
            this.TSMI_saveEmail.Click += new System.EventHandler(this.TSMI_saveEmail_Click);
            // 
            // TSMI_getEmails
            // 
            this.TSMI_getEmails.Name = "TSMI_getEmails";
            this.TSMI_getEmails.Size = new System.Drawing.Size(180, 22);
            this.TSMI_getEmails.Text = "Получить";
            this.TSMI_getEmails.Click += new System.EventHandler(this.TSMI_getEmails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 498);
            this.Controls.Add(this.DGV_emails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почтовый клиент";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_emails)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_emails;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem письмоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_saveEmail;
        private System.Windows.Forms.ToolStripMenuItem TSMI_getEmails;
    }
}

