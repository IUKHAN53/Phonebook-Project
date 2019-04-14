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
        FileStream photo { get; set; }
        string company { get; set; }
        string job { get; set; }
        string email { get; set; }
        string address { get; set; }
        public List<contacts> cList = new List<contacts>();
        public contacts(string fname,string lname,string phone,string company,string job,string email,string address,FileStream image)
        {

        }
        public contacts(string fname, string lname, string phone)
        {
            this.f_name = fname;
            this.l_name = lname;
            this.phone = phone;
        }
        public contacts() { }
    }
}
