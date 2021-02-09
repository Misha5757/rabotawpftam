using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var vhod = Class1.db2.SignIn.FirstOrDefault(item => item.Username == Login.Text && item.Password == Password.Text);
            if(vhod != null)
            {
                switch(vhod.IDRole)
                {
                    case "A":
                        MessageBox.Show("Привет Администратор!");
                        NavigationService.Navigate(new Admin());
                        break;


                    case "U":
                        MessageBox.Show("В разработке");
                        break;


                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
