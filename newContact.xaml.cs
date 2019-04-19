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
            //removing borders and centering window
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            WindowStyle = WindowStyle.None;
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //getting all values from text boxes
            string firstName = fname_box.Text;
            string lastName = lname_box.Text;
            string phoneNum = phone_box.Text;
            string email1 = email_box.Text;
            string comp = comp_box.Text;
            string job1 = job_box.Text;
            string adress = adrs_box.Text;
            string path = pathLbl.Content.ToString();

            //passing all values to new contact inside list inside contacts class
            contacts.Add_contact(new contacts()
            {
                f_name = firstName,
                l_name = lastName,
                fullname = (firstName + lastName),
                phone = phoneNum,
                photo = path,
                company = comp,
                job = job1,
                email = email1,
                address = adress
            });
            //hiding contact window and showing phonebook
            this.Hide();
            PhoneBook obj = new PhoneBook();
            obj.Show();
        }

        private void Upload_btn_Click(object sender, RoutedEventArgs e)
        {
            //it will open the dialog box for file selection for the contact picture
           OpenFileDialog openFileDialog1 = new OpenFileDialog  
            {  
               //initial directory for selections
                InitialDirectory = @"C:\",  
                Title = "Select an image",  
                //checking if file exists and path
                CheckFileExists = true,  
                CheckPathExists = true,  
                //default extension to choose for
                DefaultExt = "jpeg",  
                //all filters applicable
                Filter = "Images |(*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)",  
                FilterIndex = 2,  
                RestoreDirectory = true,  
                ReadOnlyChecked = true,  
                ShowReadOnly = true  
            };  
            if(openFileDialog1.ShowDialog() == true)
            {
                //save the file path to label for references
                pathLbl.Content = openFileDialog1.FileName;
            }

        }
        //minimizing and cloasing the window
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
