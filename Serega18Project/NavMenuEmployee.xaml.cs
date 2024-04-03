using Serega18Project.RCSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
using static Serega18Project.NavMenuUser;

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for NavMenuEmployee.xaml
    /// </summary>
    public partial class NavMenuEmployee : Window
    {
        ticketsTableAdapter ticketsTableAdapter = new ticketsTableAdapter();
        public NavMenuEmployee()
        {
            InitializeComponent();
            TicketList.ItemsSource = ticketsTableAdapter.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow();
            object id = (TicketList.SelectedItem as DataRowView).Row[0];
            Global_id.id_ticket = Convert.ToInt32(id);
            chatWindow.Show();
            Close();
        }

        private void waiting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resolved_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
