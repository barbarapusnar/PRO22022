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

namespace NepovezanDostop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        adw adw;
        adwTableAdapters.ProductTableAdapter ta;
        CollectionViewSource productViewSource;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            adw = ((NepovezanDostop.adw)(this.FindResource("adw")));
            // Load data into the table Product. You can modify this code as needed.
            ta = new adwTableAdapters.ProductTableAdapter();
            ta.Fill(adw.Product);
            productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }
        private void Naprej(object sender, RoutedEventArgs e)
        {
            int število = ((CollectionView)productViewSource.View).Count;
            if (productViewSource.View.CurrentPosition<število-1)
                 productViewSource.View.MoveCurrentToNext();
        }
        private void Nazaj(object sender, RoutedEventArgs e)
        {
           
            if (productViewSource.View.CurrentPosition >0)
                productViewSource.View.MoveCurrentToPrevious();
        }

        private void btnShrani_Click(object sender, RoutedEventArgs e)
        {
            ta.Update(adw.Product);
        }
    }
}
