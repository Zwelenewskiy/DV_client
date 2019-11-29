using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using DV_client.Server;

namespace DV_client
{
    public partial class Form1 : Form
    {
        private void FillTable(Email[] emails)
        {
            Console.WriteLine(emails.Length);

            List<User> users = new List<User>((User[])UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.getUsers
            }));

            DGV_emails.Rows.Clear();
            foreach (Email email in emails)
            {
                string to = null;
                string from = null;
                string copy = null;
                string hidden_copy = null;
                string tags = null;

                List<User> tmp_users = new List<User>(users.Where(user => email.to.Contains(user.id)));
                foreach (var user in tmp_users)
                    to += user.lastname + " " + user.name + " " + user.patronymic + " " + user.email + " " + Environment.NewLine;

                List<User> tmp_copy = new List<User>(users.Where(user => email.copy.Contains(user.id)));
                foreach (var user in tmp_copy)
                    copy += user.lastname + " " + user.name + " " + user.patronymic + " " + user.email + " " + Environment.NewLine;

                List<User> tmp_hidden_copy = new List<User>(users.Where(user => email.hidden_copy.Contains(user.id)));
                foreach (var user in tmp_hidden_copy)
                    hidden_copy += user.lastname + " " + user.name + " " + user.patronymic + " " + user.email + " " + Environment.NewLine;

                List<User> tmp_from = new List<User>(users.Where(user => user.id == email.from));
                foreach (var user in tmp_from)
                    from += user.lastname + " " + user.name + " " + user.patronymic + " " + user.email + " " + Environment.NewLine;

                foreach (var name in email.tags)
                {
                    tags += name.Value + Environment.NewLine;
                }

                DGV_emails.Rows.Add(email.header, email.date, from, email.content, to, copy, hidden_copy, tags);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        Email[] emails;

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
            emails = (Email[])UserControlManager.ActionHandler(new UserControlSettings() {
                condition = UserControlManager.UserConditions.getEmails
            });           

            FillTable(emails);
        }

        private void TSMI_change_Click(object sender, EventArgs e)
        {
            using (var form = new EmailHandlerForm(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.changeEmail,
                email = emails[DGV_emails.CurrentRow.Index]
            }))
            {
                form.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV_emails.ContextMenuStrip = contextMenuStrip1;
        }

        private void BT_search_Click(object sender, EventArgs e)
        {
            FillTable((Email[])UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.searchByDate,
                dateFrom = DTP_from.Value,
                dateTo = DTP_to.Value,
            }));
        }
    }    
}
