
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
using Serega18Project.RCSDataSetTableAdapters;

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        MainWindow main = new MainWindow();
        autorize_dataTableAdapter reg = new autorize_dataTableAdapter();
        public Registration()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            Close();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Length < 4 || password.Text.Length < 4)
            {
                MessageBox.Show("Пароль или логин слишком короткие.");

            }
            else if (login.Text.Length > 20 || password.Text.Length > 25)
            {
                MessageBox.Show("Пароль или логин слишком длинные.");
            }
            else
            {
                reg.NewUserDataCreator(1, login.Text, password.Text);
                MessageBox.Show("Вы успешно зарегестрировались!");
                main.Show();
                Close();
            }
            }
        }
}
