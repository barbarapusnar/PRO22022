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

namespace GuiElektrika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ElektrikaEntities en = new ElektrikaEntities();
            DateTime izbraniDatum = DateTime.Parse("18.8.2013");
            var x6 = (from a in en.Meritve
                     where DbFunctions.TruncateTime(a.ZapisČas.Value) == izbraniDatum
                     group a by a.ZapisČas.Value.Hour into z
                     select new { Ura = z.Key, Moč = z.Average(b => b.kW1 + b.kW2 + b.kW3) }).ToList();
            CollectionViewSource cvs = (CollectionViewSource)this.FindResource("cvs");
            cvs.Source = x6;

        }
    }
}
