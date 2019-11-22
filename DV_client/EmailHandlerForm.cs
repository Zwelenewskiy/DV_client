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
        private int[] to = new int[1];
        private int[] copy = new int[1];
        private int[] hidden_copy = new int[1];
        private KeyValuePair<int, string>[] tag = new KeyValuePair<int, string>[1];
        private int index;
        private string type;
        private List<User> users;
        private List<KeyValuePair<int, string>> tags;
        
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

            tags = new List<KeyValuePair<int, string>>((KeyValuePair<int, string>[])UserControlManager.ActionHandler(new UserControlSettings()
            {
                condition = UserControlManager.UserConditions.getTags
            }));

            List<string> user_data = new List<string>();
            foreach(User user in users)
            {
                user_data.Add(user.lastname + " " + user.name + " " + user.patronymic + " " + user.email);
            }

            List<string> tmp_tags = new List<string>();
            foreach(var tag in tags)
            {
                tmp_tags.Add(tag.Value);
            }

            ((DataGridViewComboBoxColumn)DGV_to.Columns[0]).DataSource = user_data;
            ((DataGridViewComboBoxColumn)DGV_copy.Columns[0]).DataSource = user_data;
            ((DataGridViewComboBoxColumn)DGV_hidden_copy.Columns[0]).DataSource = user_data;
            ((DataGridViewComboBoxColumn)DGV_tag.Columns[0]).DataSource = tmp_tags;

            

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
                        if (index <= to.Length - 1)
                        {
                            to[index] = users[selected_index].id;
                        }                            
                        else
                        {
                            Array.Resize(ref to, to.Length + 1);
                            to[to.Length - 1] = users[selected_index].id;
                        }
                        break;

                    case "copy":
                        if (index <= copy.Length - 1)
                        {
                            copy[index] = users[selected_index].id;
                        }                            
                        else
                        {
                            Array.Resize(ref copy, copy.Length + 1);
                            copy[copy.Length - 1] = users[selected_index].id;
                        }
                        break;

                    case "hidden_copy":
                        if (index <= hidden_copy.Length - 1)
                        {
                            hidden_copy[index] = users[selected_index].id;
                        }
                        else
                        {
                            Array.Resize(ref hidden_copy, hidden_copy.Length + 1);
                            hidden_copy[hidden_copy.Length - 1] = users[selected_index].id;
                        }
                        break;

                    case "tag":
                        if (index <= tag.Length - 1)
                        {
                            tag[index] = new KeyValuePair<int, string>(tags[selected_index].Key, tags[selected_index].Value);
                        }
                        else
                        {
                            Array.Resize(ref tag, tag.Length + 1);
                            tag[tag.Length - 1] = new KeyValuePair<int, string>(tags[selected_index].Key, tags[selected_index].Value);
                        }

                        Console.WriteLine(tag.Length);
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