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
        private Users users;

        public EmailHandlerForm(UserControlSettings settings)
        {
            InitializeComponent();
            input_settings = settings;
        }

        private void EmailHandlerForm_Load(object sender, EventArgs e)
        {
            users = ((Users)UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.getUsers
            }));

            ((DataGridViewComboBoxColumn)DGV_to.Columns[0]).DataSource = users.data;
            ((DataGridViewComboBoxColumn)DGV_copy.Columns[0]).DataSource = users.data;
            ((DataGridViewComboBoxColumn)DGV_hidden_copy.Columns[0]).DataSource = users.data;

            /*((DataGridViewComboBoxColumn)DGV_to.Columns[0]).DataSource = new List<string>() { "1", "2", "3" };
            ((DataGridViewComboBoxColumn)DGV_copy.Columns[0]).DataSource = new List<string>() { "1", "2", "3" };
            ((DataGridViewComboBoxColumn)DGV_hidden_copy.Columns[0]).DataSource = new List<string>() { "1", "2", "3" };*/

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
            int selected_index = (sender as ComboBox).SelectedIndex;

            if (selected_index != -1)
            {
                switch (type)
                {
                    case "to":
                        if (index <= to.Count - 1)
                            to[index] = users.IDs[selected_index];
                        else
                            to.Add(users.IDs[selected_index]);
                        break;

                    case "copy":
                        if (index <= copy.Count - 1)
                            copy[index] = users.IDs[selected_index];
                        else
                            copy.Add(users.IDs[selected_index]);
                        break;

                    case "hidden_copy":
                        if (index <= hidden_copy.Count - 1)
                            hidden_copy[index] = users.IDs[selected_index];
                        else
                            hidden_copy.Add(users.IDs[selected_index]);
                        break;

                    case "tag":
                        if (index <= tag.Count - 1)
                            tag[index] = users.IDs[selected_index];
                        else
                            tag.Add(users.IDs[selected_index]);
                        break;
                }
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
