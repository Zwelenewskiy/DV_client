using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DV_client
{
    public partial class EmailHandlerForm : Form
    {
        private UserControlSettings input_settings;

        public EmailHandlerForm(UserControlSettings settings)
        {
            InitializeComponent();
            input_settings = settings;
        }

        private void EmailHandlerForm_Load(object sender, EventArgs e)
        {
            switch (input_settings.condition)
            {
                case UserControlManager.UserConditions.saveEmail:
                    Text = "Сохранение письма";
                    BT_doEmail.Text = "Сохранить";
                    break;
            }
        }

        private void BT_doEmail_Click(object sender, EventArgs e)
        {
            UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.saveEmail,
                email = new Email()
                {
                    content = RTB_content.Text,
                    date = DTP_date.Value,
                    from = TB_from.Text,
                    header = TB_header.Text,
                    to = DGV_to,
                    copy = DGV_copy,
                    hidden_copy = DGV_hidden_copy,
                    tags = DGV_tags
                }
            });
        }        
    }
}
