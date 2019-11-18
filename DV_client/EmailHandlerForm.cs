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
    public partial class EmailHandlerForm : Form
    {
        public EmailHandlerForm(EmailHandlerSettings settings)
        {
            InitializeComponent();
        }

        private void EmailHandlerForm_Load(object sender, EventArgs e)
        {

        }

        private void BT_doEmail_Click(object sender, EventArgs e)
        {
            UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.saveEmail,
                email = new Email() { }
            });
        }        
    }
}
