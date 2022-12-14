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
using System.Windows.Shapes;

namespace NepovezanDostop
{
    /// <summary>
    /// Interaction logic for Prodaja.xaml
    /// </summary>
    public partial class Prodaja : Window
    {
        public Prodaja()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            NepovezanDostop.adw adw = ((NepovezanDostop.adw)(this.FindResource("adw")));
            // Load data into the table SalesOrderHeader. You can modify this code as needed.
            NepovezanDostop.adwTableAdapters.SalesOrderHeaderTableAdapter adwSalesOrderHeaderTableAdapter = new NepovezanDostop.adwTableAdapters.SalesOrderHeaderTableAdapter();
            adwSalesOrderHeaderTableAdapter.Fill(adw.SalesOrderHeader);
            System.Windows.Data.CollectionViewSource salesOrderHeaderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("salesOrderHeaderViewSource")));
            salesOrderHeaderViewSource.View.MoveCurrentToFirst();
            // Load data into the table SalesOrderDetail. You can modify this code as needed.
            NepovezanDostop.adwTableAdapters.SalesOrderDetailTableAdapter adwSalesOrderDetailTableAdapter = new NepovezanDostop.adwTableAdapters.SalesOrderDetailTableAdapter();
            adwSalesOrderDetailTableAdapter.Fill(adw.SalesOrderDetail);
            System.Windows.Data.CollectionViewSource salesOrderHeaderSalesOrderDetailViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("salesOrderHeaderSalesOrderDetailViewSource")));
            salesOrderHeaderSalesOrderDetailViewSource.View.MoveCurrentToFirst();
        }
    }
}
