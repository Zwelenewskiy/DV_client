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
                        server.saveEmail(new Server.Email());
                        break;
                }

                server.Close();
            }            
        }
    }
}
