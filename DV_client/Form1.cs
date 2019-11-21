using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DV_client.Server;

namespace DV_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TSMI_saveEmail_Click(object sender, EventArgs e)
        {
            using (var form = new EmailHandlerForm(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.saveEmail
            }))
            {
                form.ShowDialog();
            }
        }

        private void TSMI_getEmails_Click(object sender, EventArgs e)
        {
            List<Email> emails = (List<Email>)UserControlManager.ActionHandler(new UserControlSettings() {
                condition = UserControlManager.UserConditions.getEmails
            });

            foreach(Email email in emails)
            {
                DGV_emails.Rows.Add();
            }
        }
    }
}
