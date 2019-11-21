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
            Email[] emails = (Email[])UserControlManager.ActionHandler(new UserControlSettings() {
                condition = UserControlManager.UserConditions.getEmails
            });

            List<User> users = new List<User>((User[])UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.getUsers
            }));

            foreach (Email email in emails)
            {
                string to = null;
                string copy = null;
                string hidden_copy = null;
                string tags = null;

                List<User> tmp_users = new List<User>(users.Where(user => email.to.Contains(user.id)));
                foreach (var user in tmp_users)
                    to += user.lastname + " " + user.name + " " + user.patronymic + " " + Environment.NewLine;

                //Console.WriteLine("ID = " + email.id);
                //foreach (int id in email.copy)
                    //Console.WriteLine("     " + id);

                List<User> tmp_copy = new List<User>(users.Where(user => email.copy.Contains(user.id)));
                foreach(var user in tmp_copy)
                    copy += user.lastname + " " + user.name + " " + user.patronymic + " " + Environment.NewLine;

                List<User> tmp_hidden_copy = new List<User>(users.Where(user => email.hidden_copy.Contains(user.id)));
                foreach (var user in tmp_hidden_copy)
                    hidden_copy += user.lastname + " " + user.name + " " + user.patronymic + " " + Environment.NewLine;

                DGV_emails.Rows.Add(email.header, email.date, email.from, email.content, to, copy, hidden_copy, tags);
            }
        }
    }
}
