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
        private List<string> tag = new List<string>();
        private int index;
        private string type;
        private List<User> users;

        public EmailHandlerForm(UserControlSettings settings)
        {
            InitializeComponent();
            input_settings = settings;
        }

        private void EmailHandlerForm_Load(object sender, EventArgs e)
        {
            users = new List<User>((User[])UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.getUsers
            }));

            List<string> user_data = new List<string>();
            foreach(User user in users)
            {;
                user_data.Add(user.lastname + " " + user.name + " " + user.patronymic + " " + user.email);
            }

            ((DataGridViewComboBoxColumn)DGV_to.Columns[0]).DataSource = user_data;
            ((DataGridViewComboBoxColumn)DGV_copy.Columns[0]).DataSource = user_data;
            ((DataGridViewComboBoxColumn)DGV_hidden_copy.Columns[0]).DataSource = user_data;
            CB_from.DataSource = user_data;

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
            for (int i = 0; i < DGV_tag.RowCount - 1; i++)
                tag.Add(DGV_tag.Rows[DGV_tag.CurrentRow.Index].Cells[0].Value.ToString());

            if((bool)UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.saveEmail,
                email = new Email()
                {
                    content = RTB_content.Text,
                    date = DTP_date.Value,
                    from = users[CB_from.SelectedIndex].id,
                    header = TB_header.Text,
                    to = to,
                    copy = copy,
                    hidden_copy = hidden_copy,
                    tags = tag
                }
            }))
            {
                MessageBox.Show("Письмо отправлено");
            }
            else
                MessageBox.Show("Ошибка при отправке письма");
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
                            to[index] = users[selected_index].id;
                        else
                            to.Add(users[selected_index].id);
                        break;

                    case "copy":
                        if (index <= copy.Count - 1)
                            copy[index] = users[selected_index].id;
                        else
                            copy.Add(users[selected_index].id);
                        break;

                    case "hidden_copy":
                        if (index <= hidden_copy.Count - 1)
                            hidden_copy[index] = users[selected_index].id;
                        else
                            hidden_copy.Add(users[selected_index].id);
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
            }

            (e.Control as ComboBox).SelectedIndexChanged -= new EventHandler(ChangeCell);
            (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ChangeCell);
        }
    }
}
