using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class contacts
    {
        public string f_name { get; set; }
        public string fullname { get; set; }
        public string l_name { get; set; }
        public string phone { get; set; }
        public string photo { get; set; }
        public string company { get; set; }
        public string job { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public static List<contacts> cList = new List<contacts>();
        public contacts() { }
        public static bool Add_contact(contacts c)
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
        public contacts this[string x]
        {
            get
            {
                return cList.Find(contacts => contacts.fullname.StartsWith(x));
            }
            set
            {
            }
        }
    }
}
