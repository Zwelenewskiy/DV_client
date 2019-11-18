namespace DV_client
{
    partial class EmailHandlerForm
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
            this.BT_doEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_doEmail
            // 
            this.BT_doEmail.Location = new System.Drawing.Point(266, 338);
            this.BT_doEmail.Name = "BT_doEmail";
            this.BT_doEmail.Size = new System.Drawing.Size(75, 23);
            this.BT_doEmail.TabIndex = 0;
            this.BT_doEmail.Text = "Сохранить";
            this.BT_doEmail.UseVisualStyleBackColor = true;
            this.BT_doEmail.Click += new System.EventHandler(this.BT_doEmail_Click);
            // 
            // EmailHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 373);
            this.Controls.Add(this.BT_doEmail);
            this.MaximizeBox = false;
            this.Name = "EmailHandlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailHandler";
            this.Load += new System.EventHandler(this.EmailHandlerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_doEmail;
    }
}