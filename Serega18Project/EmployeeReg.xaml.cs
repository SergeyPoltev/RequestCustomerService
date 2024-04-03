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
using System.Windows.Shapes;

namespace Serega18Project
{
    /// <summary>
    /// Interaction logic for EmployeeReg.xaml
    /// </summary>
    public partial class EmployeeReg : Window
    {
        autorize_dataTableAdapter reg = new autorize_dataTableAdapter();
        public EmployeeReg()
        {
            InitializeComponent();
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
                reg.NewUserDataCreator(2, login.Text, password.Text);
                MessageBox.Show("Вы успешно зарегестрировали сотрудника!");
            }
        }
    }
}