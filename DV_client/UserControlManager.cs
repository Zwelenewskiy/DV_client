using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_client.Server;

namespace DV_client
{
    public class UserControlManager
    {
        public enum UserConditions
        {
            saveEmail
        }

        public static void ActionHandler(UserControlSettings settings)
        {
            using(var server = new DV_serverClient())
            {
                switch (settings.condition)
                {                 
                    case UserConditions.saveEmail:

                        string[] to_tmp = new string[settings.email.to.RowCount - 1];
                        string[] copy_tmp = new string[settings.email.copy.RowCount - 1];
                        string[] hidden_copy_tmp = new string[settings.email.hidden_copy.RowCount - 1];
                        string[] tags_tmp = new string[settings.email.tags.RowCount - 1];

                        for(int i = 0; i < settings.email.to.RowCount - 1; i++)
                        {
                            to_tmp[i] = settings.email.to.Rows[0].Cells[0].Value.ToString();
                        }

                        for (int i = 0; i < settings.email.copy.RowCount - 1; i++)
                        {
                            copy_tmp[i] = settings.email.copy.Rows[0].Cells[0].Value.ToString();
                        }

                        for (int i = 0; i < settings.email.hidden_copy.RowCount - 1; i++)
                        {
                            hidden_copy_tmp[i] = settings.email.hidden_copy.Rows[0].Cells[0].Value.ToString();
                        }

                        for (int i = 0; i < settings.email.tags.RowCount - 1; i++)
                        {
                            tags_tmp[i] = settings.email.tags.Rows[0].Cells[0].Value.ToString();
                        }

                        server.saveEmail(new Server.Email()
                        {
                            from = settings.email.from,
                            header = settings.email.header,
                            date = settings.email.date,
                            content = settings.email.content,
                            to = to_tmp,
                            copy = copy_tmp,
                            hidden_copy = hidden_copy_tmp,
                            tags = tags_tmp,        
                        });
                        break;
                }

                server.Close();
            }            
        }
    }
}
