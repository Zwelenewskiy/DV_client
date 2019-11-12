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

        private void Form1_Load(object sender, EventArgs e)
        {
            var server = new DV_serverClient();
            Console.WriteLine(server.GetEmails());


            /*List<Email> records = server.GetAllRecords();

            foreach(Email email in records)
            {
                DGV_emails.Rows.Add();
            }*/

            server.Close();
        }
    }
}
