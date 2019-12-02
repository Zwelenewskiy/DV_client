using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DV_client.Server;

namespace DV_client
{
    public class UserControlSettings
    {
        public UserControlManager.UserConditions condition;
        public Email email = null;
        public DateTime dateFrom;
        public DateTime dateTo;
    }
}
