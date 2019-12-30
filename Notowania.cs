using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
    public class Notowania
    {
        public double[] Godziny { get; set; }
        public double[] Open { get; set; }
        public double[] Close { get; set; }
        public double[] Low { get; set; }
        public double[] High { get; set; }
        public double Pipval { get; set; }
        public double[] PrzygotujWejscie(int k, int dl) 
            // Od k włącznie do k-dl+1 włącznie
        {
            if (k - dl <= 0 || k > Godziny.Length)
                return null;
            double[] w = new double[dl * 4];
            int m = 0;
            for (int i = k - dl+1; i <= k; i++)

            {
               // w[m++] = Godziny[i] / 100;
                w[m++] = Math.Round((Open[i] - Close[i - 1]) / Pipval,1);
                w[m++] = Math.Round((High[i] - Open[i]) / Pipval,1);
                w[m++] = Math.Round((Low[i] - Open[i]) / Pipval,1);
                w[m++] = Math.Round((Close[i] - Open[i]) / Pipval,1);
            }
            return w;

        }
        public double[] PrzygotujOdpowiedz(int p, int dl, out double H, out double L)
        {
            // powinno byc p= k
            double[] w = new double[2]; // WYNIK
            double pocz = Close[p]; //Ostatnia swieczka w ciagu wejściowym
            double max = 0; double min = 10000;

            for (int i = p + 1; i < p + dl + 1; i++) //p+1 - pierwsza swieczka w ciagu wyjsciowym
            {

                if (min > Open[i]) min = Open[i];
                if (min > Low[i]) min = Low[i];
                if (min > Close[i]) min = Close[i];
                if (max < Open[i]) max = Open[i];
                if (max < High[i]) max = High[i];
                if (max < Close[i]) max = Close[i];
            }
            double ymin = Math.Round((min - pocz) / Pipval, 1);
            double ymax = Math.Round((max - pocz) / Pipval, 1);
            w[0] = w[1] = 0;
            if (max > -min && max > 20 && min > -10)
            {
                w[0] = 0;
                w[1] = 1;
            }
            if (max < -min && max < 10 && min < -20)
            {
                w[0] = 1;
                w[1] = 0;
            }
            H = ymax;
            L = ymin;
            return w;
        }
      
        public InpOut DaneDoTreningu(int p, int dlinp, int dlut, int ilwektorow)
        {
            
            InpOut w = new InpOut(ilwektorow);
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < ilwektorow; i++)
            {
                int m=r.Next(dlinp,p-dlut);
                w.Inp[i] = PrzygotujWejscie(m, dlinp);
                double h, l;
                w.Ut[i] = PrzygotujOdpowiedz(m, dlut,out h, out l);

            }
            return w;
        }
      
        
    }
    public class InpOut
    {
        public double[][] Inp;
        public double[][] Ut;
        public InpOut(int il)
        {
            Inp = new double[il][];
            Ut = new double[il][];
        }

    }
}

