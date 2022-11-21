using KaritasWPF.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace KaritasWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Darovi d = new Darovi();
            try
            {
                d.ZapŠt = int.Parse(txtZapŠt.Text);
            }
            catch (FormatException)
            {
                d.ZapŠt = 0;
            }
            d.Datum = dtpDatum.SelectedDate.Value;
            d.Namen = txtNamen.Text;
            try
            {
                d.Znesek = double.Parse(txtZnesek.Text);
            }
            catch (FormatException)
            {
                d.Znesek = 0;
            }
            d.Opombe = txtOpombe.Text;
            FileStream fs = new FileStream(Resource1.pot, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
            //tsStatus.Text = "Zapisano";
            txtZapŠt.Text = "";
            txtZnesek.Text = "";
            txtOpombe.Text = "";
            txtNamen.Text = "";
            //txtZapŠt.Focus();
        }
    }
}
