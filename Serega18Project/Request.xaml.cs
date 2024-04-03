using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Serega18Project.RCSDataSetTableAdapters;
using static Serega18Project.Autorize;

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for Request.xaml
    /// </summary>
    public partial class Request : Window
    {
        
        ticketsTableAdapter ticket = new ticketsTableAdapter();
        int i = 200;
        public Request()
        {
            InitializeComponent();
            TextBlock();
        }

        private void sendRequest_Click(object sender, RoutedEventArgs e)
        {
            if (textRequest.Text.Length > 200 ) {
                MessageBox.Show("Запрос слишком длинный");
            }
            else if (textRequest.Text.Length < 30)
            {
                MessageBox.Show("Запрос слишком короткий");
            }
            else{
                NavMenuUser userMenu_page = new NavMenuUser();
                ticket.TicketDataCreator(Global.id_user,userName.Text,textRequest.Text,Convert.ToString(DateTime.Today), Convert.ToString(DateTime.Today),1);
                userMenu_page.Show();
                Close();
            }
            
        }
        private async Task TextBlock()
        {
            while (true) {
                await Task.Delay(500);
            count.Text = Convert.ToString(i);
            i = 200 - textRequest.Text.Length;
            if (textRequest.Text.Length > 200)
            {
                count.Text = "Запрос слишком длинный";
            }
            if (textRequest.Text.Length < 30)
            {
                count.Text = "Запрос слишком короткий";
            }
        }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavMenuUser userMenu_page = new NavMenuUser();
            userMenu_page.Show();
            Close();
        }
    }
}
