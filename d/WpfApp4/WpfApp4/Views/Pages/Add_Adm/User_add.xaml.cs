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
using WpfApp4.Views.DataBase.Model;

namespace WpfApp4.Views.Pages.Add_Adm
{
    /// <summary>
    /// Логика взаимодействия для User_add.xaml
    /// </summary>
    public partial class User_add : Page
    {
        public User_add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignIn add2 = new SignIn();
            add2.Username = Login1.Text;
            add2.Password = Password1.Text;
            var cmbx = Class1.db2.Role.FirstOrDefault(Item => Item.Title  == Admins.Text );
            add2.IDRole = cmbx.RoleID;
            Class1.db2.SignIn.Add(add2);
            Class1.db2.SaveChanges();
            MessageBox.Show("Готово");
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           Admins.ItemsSource = Class1.db2.Role.Select(item => item.Title).ToList();


        }
    }
}
