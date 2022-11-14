using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreprostRaziskovalec
{
    enum Tip { Mapa=1,Datoteka}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NaložiDrevo();
        }

        private void NaložiDrevo()
        {
            trvDrevo.Nodes.Clear();
            string[] vseEnote = Directory.GetLogicalDrives();
            foreach(string enota in vseEnote)
            {
               TreeNode vozel= trvDrevo.Nodes.Add(enota);
                vozel.Nodes.Add("Brez veze");
            }
        }

        private void trvDrevo_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear();
                DodajMape(e.Node);
                DodajDatoteke(e.Node);
            }
            catch (IOException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void DodajMape(TreeNode node)
        {
            string pot = node.FullPath; //pot po hiererhiji v treeViewu
            foreach (string imeMape in Directory.GetDirectories(pot))
            {
                TreeNode vozel=  node.Nodes.Add(Path.GetFileName( imeMape));
                vozel.Tag = Tip.Mapa;
                vozel.Nodes.Add("Brez veze");
            }
        }

        private void DodajDatoteke(TreeNode node)
        {
            string pot = node.FullPath; //pot po hiererhiji v treeViewu
            foreach (string imeDatoteke in Directory.GetFiles(pot))
            {
              TreeNode vozel=  node.Nodes.Add(Path.GetFileName(imeDatoteke));
              vozel.Tag = Tip.Datoteka;
            }
        }

        private void trvDrevo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Tip)
            {
                switch ((Tip)e.Node.Tag)
                {

                    case Tip.Mapa:
                        //izpiši lastnosti mape
                        DirectoryInfo d = new DirectoryInfo(e.Node.FullPath);

                        break;
                    case Tip.Datoteka:
                        //izpiši lastnosti datoteke
                        FileInfo f = new FileInfo(e.Node.FullPath);

                        break;
                }
            }
        }
    }
}
