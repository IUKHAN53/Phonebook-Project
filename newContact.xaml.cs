using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for newContact.xaml
    /// </summary>
    public partial class newContact : Window
    {
        public newContact()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string firstName = fname_box.Text;
            string lastName = lname_box.Text;
            string phoneNum = phone_box.Text;
            string email1 = email_box.Text;
            string comp = comp_box.Text;
            string job1 = job_box.Text;
            string adress = adrs_box.Text;


            contacts obj = new contacts();
            obj.Add_contact(new contacts()
            {
                f_name = firstName,
                l_name = lastName,
                phone = phoneNum,
                photo = null,
                company = comp,
                job = job1,
                email = email1,
                address = adress
            });
        }

        private void Upload_btn_Click(object sender, RoutedEventArgs e)
        {
           OpenFileDialog openFileDialog1 = new OpenFileDialog  
            {  
                InitialDirectory = @"C:\",  
                Title = "Select an image",  
  
                CheckFileExists = true,  
                CheckPathExists = true,  
  
                DefaultExt = "jpeg",  
                Filter = "Images |(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)",  
                FilterIndex = 2,  
                RestoreDirectory = true,  
  
                ReadOnlyChecked = true,  
                ShowReadOnly = true  
            };  
            if(openFileDialog1.ShowDialog() == true)
            {
                
            }

        }
    }
}
