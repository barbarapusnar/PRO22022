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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace KaritasWPF
{
    /// <summary>
    /// Interaction logic for Pregled.xaml
    /// </summary>
    public partial class Pregled : Window
    {
        string pot = Resource1.pot;
        List<Darovi> spremembe = new List<Darovi>();
        int štSpremeb = 0;
        public Pregled()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //preberi podatke
            FileStream fs = new FileStream(pot, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
               
                while (true)
                {
                    Darovi d = (Darovi)bf.Deserialize(fs);
                    spremembe.Add(d);
                }
            }
            catch (SerializationException) { }
            fs.Close();

            //prikaži podatke
            //samo lastnost ItemSource nastavi na datagrid
            dgPodatki.ItemsSource = spremembe;
        }
    }
}
