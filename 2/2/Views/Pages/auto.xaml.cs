using _2.Views.Context;
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

namespace _2.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для auto.xaml
    /// </summary>
    public partial class auto : Page
    {
        public auto()
        {
            InitializeComponent();
        }



        private void vhotdClick_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = dbContext2.db.SignIn.FirstOrDefault(item => item.Username == Username.Text && item.Password == Password.Password);
            if (currentUser != null)
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
    

}


