using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DV_client
{
    public class Email
    {
        public int id;
        public string from;
        public string header;
        public DateTime date;
        public string content;
        public DataGridView to;
        public DataGridView copy;
        public DataGridView hidden_copy;
        public DataGridView tags;
    }
}
