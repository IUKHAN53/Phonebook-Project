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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //window centering and making borderless
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            WindowStyle = WindowStyle.None;
            InitializeComponent();
            //getting the username and password from the settings of appliaction
            string UserNam = Properties.Settings.Default.UserName;
            string Password = Properties.Settings.Default.Password;
            //if login details exists in the settings 
            if (!(UserNam.Equals("") && Password.Equals("")))
            {
                //change properties of labels and textboxes so that it becomes login page by hiding certain elements
                signup_lbl.Content = "Login";
                rpass_lbl.Visibility = Visibility.Hidden;
                rpass.Visibility = Visibility.Hidden;
                signup_btn1.Content = "Login";
            }
            else
                //make the reset button invisible for signup page
                rst_btn.Visibility = Visibility.Hidden;
        }
            
        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            //if its login page validate the username and password
            if (signup_btn1.Content.Equals("Login")) {
                string UserNam = Properties.Settings.Default.UserName;
                string Password = Properties.Settings.Default.Password;
                string u_name = UserName.Text;
                string password = pass.Password;
                //show the phonebook page if valid details
                if(UserNam.Equals(u_name) && Password.Equals(password))   {
                    PhoneBook pb = new PhoneBook();
                    pb.Show();
                    this.Hide();
                }
                else
                {
                    //throw error if invalid details
                    MessageBox.Show("Please Enter valid username and password", "Wrong Password", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            //if its signup page set the setting of app to save the details of signup information
            else {
                string u_name = UserName.Text;
                string password = pass.Password;
                //if the passwords match save the details
                if (password.Equals(rpass.Password))
                {
                    Properties.Settings.Default.UserName = u_name;
                    Properties.Settings.Default.Password = password;
                    Properties.Settings.Default.Save();
                    this.Hide();
                    MainWindow mw = new MainWindow();
                    mw.Show();
                }
                else
                {
                    //if password do not match in two fields throw error
                    MessageBox.Show("Password MisMatch ", "Password Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
           
        }
        //a reset button to reset the details saved inside settings
        private void rst_clicked(object sender, RoutedEventArgs e)
        {
            //reset the properties and apply
            Properties.Settings.Default.UserName = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();
            this.Hide();
            //show signup page after resetting
            MainWindow mw = new MainWindow();
            mw.Show();

        }
        //closing and minimizing the window
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
