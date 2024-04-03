using Serega18Project.RCSDataSetTableAdapters;
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
using static Serega18Project.Autorize;
using static Serega18Project.NavMenuUser;

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for ClientTickents.xaml
    /// </summary>
    public partial class ClientTickents : Page
    {
        ticketsTableAdapter ticketsTableAdapter = new ticketsTableAdapter();
        
        public ClientTickents()
        {
            InitializeComponent();
            List<RequestCards> names_ = new List<RequestCards>() {  };
            var names = ticketsTableAdapter.GetData().Rows;
            RequestCards cards = new RequestCards();
            TicketList.ItemsSource=ticketsTableAdapter.GetData();
            //id();
           /* for(int i = 0; i < names.Count; i++)
            {
                cards.userName.Text = Convert.ToString(names[i][2]);
                names_.Add(cards);
                cards.code.Text = Convert.ToString(names[i][6]);
                names_.Add(cards);
                cards.ticketID.Text= Convert.ToString(names[i][0]);
                names_.Add(cards);
                string myString = Convert.ToString(names[i][3]);
                char[] mystr = myString.ToCharArray();
                string Output = "";
                for (int a = 0; a < 45; a++)
                {
                    Output += mystr[a];
                }
                cards.requestText.Text = Output;
                if (Convert.ToInt32(names[i][1]) == Global.id_user)
                {
                    names_.Add(cards);
                } 
            }
            RequestCards cards1 = new RequestCards();
            cards1.userName.Text = Convert.ToString(names[0][2]);
            names_.Add(cards1);*/

            //TicketList.ItemsSource= names_;
        }
/*        private async Task id()
        {
            while (true)
            {
                await Task.Delay(200);
                Global_id.id_ticket = Convert.ToInt32(TicketList.SelectedItem);
            }
        }*/

            private void TicketList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }
    }
}
