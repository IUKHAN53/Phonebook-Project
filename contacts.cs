using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class contacts
    {
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string phone { get; set; }
        public FileStream photo { get; set; }
        public string company { get; set; }
        public string job { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public List<contacts> cList = new List<contacts>();
        public contacts() { }
        public bool Add_contact(contacts c)
        {
            try
            {
                cList.Add(c);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
