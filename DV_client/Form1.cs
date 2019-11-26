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
        public Form1()
        {
            InitializeComponent();
        }

        private static string ToXMLString(Email[] list)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Email[]));
            MemoryStream ms = new MemoryStream();
            xs.Serialize(ms, list);

            return Encoding.UTF8.GetString(ms.ToArray());
        }

        private static string ToXMLString(object obj, Type objType)
        {
            XmlSerializer xs = new XmlSerializer(objType);
            MemoryStream ms = new MemoryStream();
            xs.Serialize(ms, obj);

            return Encoding.UTF8.GetString(ms.ToArray());
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

            UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.changeEmail,
                email = new Email()
                {
                    id = 40,
                    content = "desfvswgaedvfsdfvgfswgwsgswvfsdfg",
                    from = 3,
                    header = "THEMA",
                    to = new int[2] { 0, 4 },
                    date = DateTime.Now
                }
            });

            
            /*List<int> t = new List<int>();
            t.Add(1);
            t.Add(2);

            Console.WriteLine(ToXMLString(t, typeof(List<int>)).IndexOf("xmlns:xsi = \"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema"));

            Console.WriteLine("xmlns:xsi = \"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema");
            Console.WriteLine(ToXMLString(t, typeof(List<int>)));

            //Console.WriteLine(ToXMLString(t, typeof(List<int>)).Replace(@"""xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""", ""));

            return;*/

            List<User> users = new List<User>((User[])UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.getUsers
            }));

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
                foreach(var user in tmp_copy)
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

        private void TSMI_change_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV_emails.ContextMenuStrip = contextMenuStrip1;
        }
    }
}
