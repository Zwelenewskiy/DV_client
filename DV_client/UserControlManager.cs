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
            saveEmail,
            getUsers
        }

        public static object ActionHandler(UserControlSettings settings)
        {
            using(var server = new DV_serverClient())
            {
                switch (settings.condition)
                {                 
                    case UserConditions.saveEmail:

                        int[] to_tmp = new int[settings.email.to.Count];
                        int[] copy_tmp = new int[settings.email.copy.Count];
                        int[] hidden_copy_tmp = new int[settings.email.hidden_copy.Count];
                        int[] tags_tmp = new int[settings.email.tags.Count];

                        for(int i = 0; i < settings.email.to.Count; i++)
                        {
                            to_tmp[i] = settings.email.to[i];
                        }

                        for (int i = 0; i < settings.email.copy.Count; i++)
                        {
                            copy_tmp[i] = settings.email.copy[i];
                        }

                        for (int i = 0; i < settings.email.hidden_copy.Count; i++)
                        {
                            hidden_copy_tmp[i] = settings.email.hidden_copy[i];
                        }

                        for (int i = 0; i < settings.email.tags.Count; i++)
                        {
                            tags_tmp[i] = settings.email.tags[i];
                        }

                        return server.saveEmail(new Server.Email()
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

                    case UserConditions.getUsers:
                        return server.GetUsers();
                }

                server.Close();
                return null;
            }            
        }
    }
}
