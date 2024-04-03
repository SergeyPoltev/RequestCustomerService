
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
    /// Interaction logic for Autorize.xaml
    /// </summary>
    public partial class Autorize : Window
    {
        MainWindow main = new MainWindow();
        EmployeeReg adminpage = new EmployeeReg();
        NavMenuEmployee employeemenu = new NavMenuEmployee();
        NavMenuUser usermenu = new NavMenuUser();
        autorize_dataTableAdapter enter_system = new autorize_dataTableAdapter();
        public Autorize()
        {
            InitializeComponent();

        }
        public static class Global
        {
            public static int id_user { get; set; }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            Close();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            var logins = enter_system.GetData().Rows;
            if (login.Text.Length < 4 || password.Password.Length < 4)
            {
                MessageBox.Show("Пароль или логин слишком короткий");
            }
            else if (login.Text.Length > 20 || password.Password.Length > 25)
            {
                MessageBox.Show("Пароль или логин слишком длинный");
            }
                for (int i = 0; i < logins.Count; i++)
                {
                    if (logins[i][2].ToString() == login.Text && logins[i][3].ToString() == password.Password)
                    {
                    Global.id_user = i;
                    int role = (int)logins[i][1];
                        switch (role)
                        {
                            case 3:
                                adminpage.Show();
                                Close();
                                break;
                            case 2:
                                employeemenu.Show();
                                Close();
                                break;
                            case 1:
                                usermenu.Show();
                                Close();
                                break;
                            default:
                                MessageBox.Show("Такой учётной записи не существует.");
                                break;
                        }
                    }
                }
            }
        }
    }
