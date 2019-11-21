using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Neuro;
using Accord.Neuro.Learning;
using Deedle;
namespace Neural
{
    public partial class Form1 : Form
    {
        Notowania fx;
        ActivationNetwork activationNetwork;
        public Form1()
        {
            InitializeComponent();
            

           
        }
        public Notowania WczytajNotowania(string sc)
        {
            var f = Frame.ReadCsv(sc);

            Notowania n = new Notowania() { Pipval = 0.0001 };
            n.Godziny = f["Time"].Values.Select(x => Convert.ToDouble(x)).ToArray();
            n.Open = f["O"].Values.Select(x => Convert.ToDouble(x)).ToArray();
            n.Close = f["C"].Values.Select(x => Convert.ToDouble(x)).ToArray();
            n.Low = f["L"].Values.Select(x => Convert.ToDouble(x)).ToArray();
            n.High = f["H"].Values.Select(x => Convert.ToDouble(x)).ToArray();
       

            return n;

        }

        private void wczytajKursyBut_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog f = new OpenFileDialog())
                if (f.ShowDialog() == DialogResult.OK)
                {
                    fx = WczytajNotowania(f.FileName);
                    fx.Pipval = Convert.ToDouble(piptextBox2.Text);
                }

        }

        private void uczbutton1_Click(object sender, EventArgs e)
        {
            var net = new DistanceNetwork(20, 400);

            var tester = new SOMLearning(net, 5, 4);
            tester.RunEpoch();

            
        }

        private void testbutton1_Click(object sender, EventArgs e)
        {
            double h, l;
            int p = Convert.ToInt32(dokadTreningtextBox3.Text);
            double[] inp = fx.PrzygotujWejscie(p, 5);
            double[] ut = fx.PrzygotujOdpowiedz(p, 4,out h,out l);
            double[] odp=activationNetwork.Compute(inp);
            Hlabel4.Text = ut[0].ToString() + " " + ut[1].ToString() + " " + ut[2].ToString();
            Llabel5.Text = h.ToString("0.0") + " " + l.ToString("0.0");
            HPredicted.Text = odp[0].ToString() + " " + odp[1].ToString() + " " + odp[2].ToString();
           

        }
    }
}
