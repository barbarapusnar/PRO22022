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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tiskanje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FlowDocument c;
        public MainWindow()
        {
            InitializeComponent();
            FileStream fs = new FileStream("D:\\PRO22022\\Tiskanje\\Tiskanje\\FlowDocument1.xaml",
                FileMode.Open);
            c = XamlReader.Load(fs) as FlowDocument;
            fdr.Document = c;
            fs.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            IDocumentPaginatorSource idp = c;
            bool? print= pd.ShowDialog();
            if (print == true)
                pd.PrintDocument(idp.DocumentPaginator, "");
        }
    }
}
