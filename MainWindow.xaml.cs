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
        //this.showWindow = 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            UserName.Text = Properties.Settings.Default.UserName;
            string u_name = UserName.Text;
            string password = pass.Password;
            if (password.Equals(rpass.Password))
            {
                Properties.Settings.Default.UserName = u_name;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Password MisMatch ", "Password Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
