using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class contact
    {
        string f_name { get; set; }
        string l_name { get; set; }
        string phone { get; set; }
        FileStream photo { get; set; }
        string company { get; set; }
        string job { get; set; }
        string email { get; set; }
        string address { get; set; }
        public contact(string fname,string lname,string phone,string company,string job,string email,string address,FileStream image)
        {

        }
    }
}
