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
using WpfApp4.Views.DataBase.Class;

namespace WpfApp4.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Views_Grid.xaml
    /// </summary>
    public partial class Views_Grid : Page
    {
        public Views_Grid()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List.ItemsSource = Class1.db2.SignIn.ToList();
        }
    }
}
