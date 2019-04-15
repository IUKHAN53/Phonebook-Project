﻿using System;
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
            string UserNam = Properties.Settings.Default.UserName;
            string Password = Properties.Settings.Default.Password;
            if (!(UserNam.Equals("") && Password.Equals("")))
            {
                MessageBox.Show(Password, UserNam, MessageBoxButton.OK, MessageBoxImage.Error);
                signup_lbl.Content = "login";
                rpass_lbl.Visibility = Visibility.Hidden;
                rpass.Visibility = Visibility.Hidden;
                signup_btn1.Content = "Login";
                act_lbl.Visibility = Visibility.Hidden;
                lgin_btn.Visibility = Visibility.Hidden;
            }
        }
            
        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (signup_btn1.Content.Equals("Login")) {
                string UserNam = Properties.Settings.Default.UserName;
                string Password = Properties.Settings.Default.Password;
                string u_name = UserName.Text;
                string password = pass.Password;
                if(UserNam.Equals(u_name) && Password.Equals(password))   {
                    PhoneBook pb = new PhoneBook();
                    pb.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Enter valid username and password", "Wrong Password", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else {
                string u_name = UserName.Text;
                string password = pass.Password;
                if (password.Equals(rpass.Password))
                {
                    Properties.Settings.Default.UserName = u_name;
                    Properties.Settings.Default.Password = password;
                    Properties.Settings.Default.Save();
                    Console.WriteLine(Properties.Settings.Default.UserName);
                    Console.WriteLine(Properties.Settings.Default.Password);
                }
                else
                {
                    MessageBox.Show("Password MisMatch ", "Password Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
           
        }

        private void UserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
