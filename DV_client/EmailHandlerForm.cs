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
        private UserControlSettings input_settings;
        private List<int> to = new List<int>();
        private List<int> copy = new List<int>();
        private List<int> hidden_copy = new List<int>();
        private List<int> tag = new List<int>();
        private int index;
        private string type;

        public EmailHandlerForm(UserControlSettings settings)
        {
            InitializeComponent();
            input_settings = settings;
        }

        private void EmailHandlerForm_Load(object sender, EventArgs e)
        {
            /*((DataGridViewComboBoxColumn)DGV_to.Columns[0]).DataSource = new List<User>((User[])UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.getUsers
            }));*/

            ((DataGridViewComboBoxColumn)DGV_to.Columns[0]).DataSource = new List<string>() { "1", "2", "3" };
            ((DataGridViewComboBoxColumn)DGV_copy.Columns[0]).DataSource = new List<string>() { "1", "2", "3" };
            ((DataGridViewComboBoxColumn)DGV_hidden_copy.Columns[0]).DataSource = new List<string>() { "1", "2", "3" };
            ((DataGridViewComboBoxColumn)DGV_tag.Columns[0]).DataSource = new List<string>() { "1", "2", "3" };

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
                    to = to,
                    copy = copy,
                    hidden_copy = hidden_copy,
                    tags = tag
                }
            });
        }

        //Добавление в массивы
        private void ChangeCell(object sender, EventArgs e)
        {
            switch (type)
            {
                case "to":
                    if(index <= to.Count - 1)
                        to[index] = (sender as ComboBox).SelectedIndex;
                    else
                        to.Add((sender as ComboBox).SelectedIndex);
                    break;

                case "copy":
                    if (index <= copy.Count - 1)
                        copy[index] = (sender as ComboBox).SelectedIndex;
                    else
                        copy.Add((sender as ComboBox).SelectedIndex);
                    break;

                case "hidden_copy":
                    if (index <= hidden_copy.Count - 1)
                        hidden_copy[index] = (sender as ComboBox).SelectedIndex;
                    else
                        hidden_copy.Add((sender as ComboBox).SelectedIndex);
                    break;

                case "tag":
                    if (index <= tag.Count - 1)
                        tag[index] = (sender as ComboBox).SelectedIndex;
                    else
                        tag.Add((sender as ComboBox).SelectedIndex);
                    break;
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = (sender as DataGridView).CurrentRow.Index;
        }

        //Обработка при выборе из combobox
        private void EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch((sender as DataGridView).Tag)
            {
                case "to":
                    type = "to";
                    break;

                case "copy":
                    type = "copy";
                    break;

                case "hidden_copy":
                    type = "hidden_copy";
                    break;

                case "tag":
                    type = "tag";
                    break;
            }

            (e.Control as ComboBox).SelectedIndexChanged -= new EventHandler(ChangeCell);
            (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ChangeCell);
        }
    }
}
