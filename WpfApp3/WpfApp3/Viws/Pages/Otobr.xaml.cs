using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using WpfApp3.Context;
using WpfApp3.Model;

namespace WpfApp3.Viws.Pages
{
    /// <summary>
    /// Логика взаимодействия для Otobr.xaml
    /// </summary>
    public partial class Otobr : Page
    {
        public Otobr()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            list.ItemsSource = Class1.bd.Compucter.ToList();
            DataViews.ItemsSource = Class1.bd.Compucter.ToList();
        }

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new add());
        }

        private void Suka_Click(object sender, RoutedEventArgs e)
        {

            if (list.Visibility == Visibility.Visible)
            {
                list.Visibility = Visibility.Hidden;
                DataViews.Visibility = Visibility.Visible;
            }
            else if (DataViews.Visibility == Visibility.Visible)
            {
                list.Visibility = Visibility.Visible;
                DataViews.Visibility = Visibility.Hidden;

            }

            
                     
            
        }

        private void list_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            Compucter dell = (Compucter)list.SelectedItem;
            Compucter dell2 = (Compucter) DataViews.SelectedItem;
            if (MessageBox.Show("Вы уверены?", "Все удалиться!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                if (dell != null)
                {
                    Class1.bd.Compucter.Remove(dell);
                    Class1.bd.SaveChanges();
                    Page_Loaded(null, null);
                }
                else if (dell2 != null)
                {
                    Class1.bd.Compucter.Remove(dell2);
                    Class1.bd.SaveChanges();
                    Page_Loaded(null, null);
                }
            }
            }

        private void red2_Click(object sender, RoutedEventArgs e)
        {
            Compucter sel = (Compucter)list.SelectedItem;
            if (sel != null)
            {
                NavigationService.Navigate(new red(sel));
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали");
            }

        }
    }
    }

