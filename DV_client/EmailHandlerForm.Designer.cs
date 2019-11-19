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
            this.RTB_content = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_header = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_from = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_to = new System.Windows.Forms.DataGridView();
            this.DGV_copy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_hidden_copy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_hidden_copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_doEmail
            // 
            this.BT_doEmail.Location = new System.Drawing.Point(439, 479);
            this.BT_doEmail.Name = "BT_doEmail";
            this.BT_doEmail.Size = new System.Drawing.Size(75, 23);
            this.BT_doEmail.TabIndex = 0;
            this.BT_doEmail.Text = "Сохранить";
            this.BT_doEmail.UseVisualStyleBackColor = true;
            this.BT_doEmail.Click += new System.EventHandler(this.BT_doEmail_Click);
            // 
            // RTB_content
            // 
            this.RTB_content.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_content.Location = new System.Drawing.Point(12, 117);
            this.RTB_content.Name = "RTB_content";
            this.RTB_content.Size = new System.Drawing.Size(446, 333);
            this.RTB_content.TabIndex = 1;
            this.RTB_content.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Содержание:";
            // 
            // TB_header
            // 
            this.TB_header.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_header.Location = new System.Drawing.Point(12, 25);
            this.TB_header.Name = "TB_header";
            this.TB_header.Size = new System.Drawing.Size(255, 26);
            this.TB_header.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тема:";
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(298, 26);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(160, 20);
            this.DTP_date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "От:";
            // 
            // TB_from
            // 
            this.TB_from.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_from.Location = new System.Drawing.Point(12, 69);
            this.TB_from.Name = "TB_from";
            this.TB_from.Size = new System.Drawing.Size(339, 26);
            this.TB_from.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кому:";
            // 
            // DGV_to
            // 
            this.DGV_to.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_to.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_to.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.DGV_to.EnableHeadersVisualStyles = false;
            this.DGV_to.Location = new System.Drawing.Point(481, 117);
            this.DGV_to.Name = "DGV_to";
            this.DGV_to.RowHeadersVisible = false;
            this.DGV_to.Size = new System.Drawing.Size(218, 150);
            this.DGV_to.TabIndex = 9;
            // 
            // DGV_copy
            // 
            this.DGV_copy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_copy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_copy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.DGV_copy.EnableHeadersVisualStyles = false;
            this.DGV_copy.Location = new System.Drawing.Point(730, 117);
            this.DGV_copy.Name = "DGV_copy";
            this.DGV_copy.RowHeadersVisible = false;
            this.DGV_copy.Size = new System.Drawing.Size(218, 150);
            this.DGV_copy.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Копия:";
            // 
            // DGV_hidden_copy
            // 
            this.DGV_hidden_copy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV_hidden_copy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_hidden_copy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.DGV_hidden_copy.EnableHeadersVisualStyles = false;
            this.DGV_hidden_copy.Location = new System.Drawing.Point(481, 300);
            this.DGV_hidden_copy.Name = "DGV_hidden_copy";
            this.DGV_hidden_copy.RowHeadersVisible = false;
            this.DGV_hidden_copy.Size = new System.Drawing.Size(218, 150);
            this.DGV_hidden_copy.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Скрытая копия:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(730, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(218, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Теги:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Адрес";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // EmailHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(963, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGV_hidden_copy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV_copy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_from);
            this.Controls.Add(this.DTP_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_header);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTB_content);
            this.Controls.Add(this.BT_doEmail);
            this.MaximizeBox = false;
            this.Name = "EmailHandlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailHandler";
            this.Load += new System.EventHandler(this.EmailHandlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_hidden_copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_doEmail;
        private System.Windows.Forms.RichTextBox RTB_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_to;
        private System.Windows.Forms.DataGridView DGV_copy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_hidden_copy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}