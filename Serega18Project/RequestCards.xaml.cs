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

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for RequestCards.xaml
    /// </summary>
    public partial class RequestCards : UserControl
    {
        public string name { get; set; }
        public RequestCards()
        {
            InitializeComponent();
            DataContext = this;
        }

    }
}
