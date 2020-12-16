using avtiruz.Context;
using avtiruz.Views.Pages.Admin;
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
            var currentUser = dbContext.db.SignIn.FirstOrDefault(item => item.Username == Username.Text && item.Password == Password.Password);
            if (currentUser != null)
            {
                switch (currentUser.IDRole)
                {
                    case "A":
                        NavigationService.Navigate(new adm());
                        
                        break;
                    case "U":
                        NavigationService.Navigate(new adm());
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
