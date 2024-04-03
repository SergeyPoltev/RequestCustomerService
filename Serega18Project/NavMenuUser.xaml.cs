using Serega18Project.RCSDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
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

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for NavMenuUser.xaml
    /// </summary>
    
    public partial class NavMenuUser : Window
    {
        Request request_page = new Request();
        ticketsTableAdapter ticketsTableAdapter = new ticketsTableAdapter();

        public static class Global_id
        {
            public static int id_ticket { get; set; }
        }
        public NavMenuUser()
        {
            InitializeComponent();
            TicketList.ItemsSource = ticketsTableAdapter.GetData();
        }

        private void create_request_Click(object sender, RoutedEventArgs e)
        {
            request_page.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow();
            object id = (TicketList.SelectedItem as DataRowView).Row[0];
            Global_id.id_ticket = Convert.ToInt32(id);
            chatWindow.Show();
            Close();
        }
    }
}
