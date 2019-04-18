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
        public PhoneBook()
        {
            InitializeComponent();
            //contacts c = new contacts("IU","Khan","03013441991");


            
            
            this.contacts_list.ItemsSource = contacts.cList;
            
        }
        //add contact button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            newContact nc = new newContact();
            nc.Show();
            this.Hide();

        }
        //search button
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Contacts_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
