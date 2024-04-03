using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
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
using Serega18Project.RCSDataSetTableAdapters;
using static Serega18Project.NavMenuUser;

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        private Socket sock; 
        //private Socket serv;
        private List<Socket> clients = new List<Socket>();
        ticketsTableAdapter ticketsTableAdapter = new ticketsTableAdapter();

        public ChatWindow()
        {
            InitializeComponent();
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 8888);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(ip);
            sock.Listen(1000);
            CheckConnection();
            //serv = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //serv.ConnectAsync("127.0.0.1", 8888);
        }
       
        private void exitRequest_Click(object sender, RoutedEventArgs e)
        {
            NavMenuUser navMenuUser = new NavMenuUser();
            navMenuUser.Show();
            Close();
            sock.Close();
        }

        private void closeRequest_Click(object sender, RoutedEventArgs e)
        {
            ticketsTableAdapter.TicketUpdate(Convert.ToString(DateTime.Today), 3, Global_id.id_ticket);
            NavMenuUser navMenuUser = new NavMenuUser();
            navMenuUser.Show();
            Close();
            sock.Close();
        }
        private async Task CheckConnection()
        {
            while (true)
            {
                var client = await sock.AcceptAsync();
                clients.Add(client);
                RecieveMSG(client);
            }
        }

        public async Task RecieveMSG(Socket client)
        {
            while (true)
            {
                byte[] bytes = new byte[1024];
                //await client.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);
                chatL.Items.Add($"Сlient-{client.RemoteEndPoint} сказал: {message}");
                foreach (var item in clients)
                {
                    SendMSG(item, message);
                }
            }
        }
        private async Task SendMSG(Socket client, string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            //await client.SendAsync(bytes, SocketFlags.None);
        }
        private void sendMessege_Click(object sender, RoutedEventArgs e)
        {
            //SendMSG(answer.Text);
        }
    }
}
