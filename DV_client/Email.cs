﻿using System;
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
        public List<int> to;
        public List<int> copy;
        public List<int> hidden_copy;
        public List<int> tags;
    }
}
