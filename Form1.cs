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
            activationNetwork = new ActivationNetwork(new BipolarSigmoidFunction (0.4), 20, 400,18, 3);
            activationNetwork.Randomize();
            BackPropagationLearning train = new BackPropagationLearning(activationNetwork);
            InpOut training = fx.DaneDoTreningu(Convert.ToInt32(dokadTreningtextBox3.Text), 5, 4, 1000);
            //
            double errorperepoch;
            for (int i = 1; i < 3000; i++)
            {
                errorperepoch = 0;
                for (int j = 0; j < 1000; j++)
                {
                    double error = train.Run(training.Inp[j], training.Ut[j]);
                     errorperepoch += error;
                }
                if (i % 100 == 0)
                    Console.WriteLine("i={0}; {1}", i,errorperepoch /= 1000);
            }
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
