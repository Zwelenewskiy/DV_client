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
            getUsers,
            getEmails,
            getTags,
            changeEmail,
            searchByDate
        }

        public static object ActionHandler(UserControlSettings settings)
        {
            using(var server = new DV_serverClient())
            {
                switch (settings.condition)
                {                 
                    case UserConditions.saveEmail:

                        /*return server.saveEmail(new Email()
                        {
                            from = settings.email.from,
                            header = settings.email.header,
                            date = settings.email.date,
                            content = settings.email.content,
                            to = settings.email.to,
                            copy = settings.email.copy,
                            hidden_copy = settings.email.hidden_copy,
                            tags = settings.email.tags,        
                        });*/

                        return server.saveEmail(settings.email);

                    case UserConditions.getUsers:
                        return server.GetUsers();

                    case UserConditions.getEmails:
                        return server.GetEmails();

                    case UserConditions.getTags:
                        return server.GetTags();

                    case UserConditions.changeEmail:
                        return server.ChangeEmail(settings.email);

                    case UserConditions.searchByDate:
                        return server.SearchByDate(settings.dateFrom, settings.dateTo);
                }

                server.Close();
                return null;
            }            
        }
    }
}
