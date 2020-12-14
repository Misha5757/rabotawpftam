using avtiruz.Context;
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

namespace avtiruz.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для aut.xaml
    /// </summary>
    public partial class aut : Page
    {
        public aut()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void vhotdClick_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = dbContex.db.SignIn.FirstOrDefault(item => item.Username == Username.Text && item.Password == Password.Password);
            if (currentUser != null)
            {
                switch (currentUser.IDRole)
                {
                    case "A":
                        MessageBox.Show("Привет, админчик");
                        break;
                    case "U":
                        MessageBox.Show("Привет, user");
                        break;


                }
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
