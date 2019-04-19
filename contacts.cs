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
        //all the variables for contact details and their properties
        public string f_name { get; set; }
        public string fullname { get; set; }
        public string l_name { get; set; }
        public string phone { get; set; }
        public string photo { get; set; }
        public string company { get; set; }
        public string job { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        //a list to contain all the objects made of contacts
        public static List<contacts> cList = new List<contacts>();
        public contacts() { }
        //adding a contact to the list
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
        // indexer to show the contacts matching characters passed
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
