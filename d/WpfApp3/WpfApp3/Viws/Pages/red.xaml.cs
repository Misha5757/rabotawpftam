using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для red.xaml
    /// </summary>
    public partial class red : Page
    {
        private Compucter selectedItem;
        public red(Compucter selectedItem)
        {
            InitializeComponent();

            this.selectedItem = selectedItem;

            if (selectedItem.Image != null)
            {
                BitmapImage image = new BitmapImage();
                MemoryStream stream = new MemoryStream (selectedItem.Image);
                {
                    image.BeginInit();
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.StreamSource = stream;
                    image.EndInit();

                }
                Imagee.Source = image;
                ID1.Text = selectedItem.GPU; 
            }
        
        }

        private void Vibrat_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog vibor = new OpenFileDialog();
            vibor.Filter = ("Image(* jpg; * png; * jpeg;) |* jpg; * png; * jpeg; ");
            if (vibor.ShowDialog() == true)
            {
                BitmapImage image2 = new BitmapImage(new Uri(vibor.FileName));
                Imagee.Source = image2;
            }

        }

        private void add3_Click(object sender, RoutedEventArgs e)
        {
            Compucter save = Class1.bd.Compucter.FirstOrDefault(Item => Item.ID == selectedItem.ID);
            save.CPU = ID1.Text;
            MemoryStream bytes = new MemoryStream();
            JpegBitmapEncoder image4 = new JpegBitmapEncoder();
            image4.Frames.Add(BitmapFrame.Create((BitmapImage)Imagee.Source));
            image4.Save(bytes);
            save.Image = bytes.ToArray();

            Class1.bd.SaveChanges();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CPYy.ItemsSource = Class1.bd.Compucter.Select(item => item.GPU).ToList();
        }
    }
}
