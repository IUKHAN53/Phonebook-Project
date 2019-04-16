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
            string email = email_box.Text;
            string job = job_box.Text;
            string adress = adrs_box.Text;


            contacts obj = new contacts();
            obj.Add_contact(new contacts()
            {
                f_name = "Suhaib",
                phone = "031245678"
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
            string rs_path = "C:\\Users\\IUKHAN\\source\\repos\\Visual_Programming\\Resources\\";
            if(openFileDialog1.ShowDialog() == true)
            {
 //           System.IO.File.Copy(openFileDialog1.FileName,rs_path+"asd.jpeg");
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(rs_path+"asd.jpeg", UriKind.Relative);
            bi3.EndInit();
            image_frame.Stretch = Stretch.Fill;            
            image_frame.Source = bi3;
            }

        }
    }
}
