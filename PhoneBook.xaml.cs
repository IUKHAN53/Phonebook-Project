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

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for PhoneBook.xaml
    /// </summary>
    public partial class PhoneBook : Window
    {
        public List<contacts> p = new List<contacts>(); 
        public PhoneBook()
        {
            //making window center and borderless
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            WindowStyle = WindowStyle.None;
            InitializeComponent();
            this.contacts_list.ItemsSource = contacts.cList;
        }
        //add contact button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //switchig to window of adding contact
            newContact nc = new newContact();
            nc.Show();
            this.Hide();

        }
        //button to edit the details and save changes
        private void edit_btn(object sender, RoutedEventArgs e)
        {
            //If button is not pressed before the textboxes will be enables for editing
            if (editbtn.Content.Equals("Edit Details"))
            {
                fNameBox.IsEnabled = true;
                lNameBox.IsEnabled = true;
                adrsBox1.IsEnabled = true;
                compBox.IsEnabled = true;
                JobBox.IsEnabled = true;
                PhoneBox.IsEnabled = true;
                EmailBox.IsEnabled = true;
                editbtn.Content = "Confirm";
            }
            //If button is pressed before the textboxes will be disabled for editing
            else if (editbtn.Content.Equals("Confirm"))
            {
                fNameBox.IsEnabled = false;
                lNameBox.IsEnabled = false;
                adrsBox1.IsEnabled = false;
                compBox.IsEnabled = false;
                JobBox.IsEnabled = false;
                PhoneBox.IsEnabled = false;
                EmailBox.IsEnabled = false;
                editbtn.Content = "Edit Details";
            }

        }

        private void do_search(object sender, TextChangedEventArgs e)
        {
            //when text changes in the textbox the listbox updates itself to select the contact with entered name
            contacts c = new contacts();
            string inp = search.Text;
            contacts cn = c[inp];
            contacts_list.SelectedItem = cn;
        }

        //closing and minimizing window
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
