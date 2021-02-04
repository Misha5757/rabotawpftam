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
    /// Логика взаимодействия для add.xaml
    /// </summary>
    public partial class add : Page
    {
        public add()
        {
            InitializeComponent();
        }

        private void Vibrat_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog exspor = new OpenFileDialog();
            exspor.Filter = "Image (* jpg; * png; * jpeg;) | * jpg; * png; * jpeg;";
            if (exspor.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(exspor.FileName));
                Imagee.Source = image;
            }
            }

        private void add3_Click(object sender, RoutedEventArgs e)
        {
            Compucter addd = new Compucter();
            addd.CPU = ID1.Text;
            MemoryStream bytes = new MemoryStream();
            JpegBitmapEncoder image = new JpegBitmapEncoder();
            image.Frames.Add(BitmapFrame.Create((BitmapImage) Imagee.Source));
            image.Save(bytes);
            addd.Image = bytes.ToArray();
            Class1.bd.Compucter.Add(addd);
            Class1.bd.SaveChanges();
            
        }
    }
}
