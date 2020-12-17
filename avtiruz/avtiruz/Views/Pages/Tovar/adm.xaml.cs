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

namespace avtiruz.Views.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для adm.xaml
    /// </summary>
    public partial class adm : Page
    {
       
        public adm()
        {
            InitializeComponent();
            dataView.ItemsSource = dbContext.db.Pokunka.ToList();
            //dataView2.ItemsSource = dbContext.db.Tovar.ToList();
            //dataView1.ItemsSource = dbContext.db.Postavchik2.ToList();
        }

       
    }
}
