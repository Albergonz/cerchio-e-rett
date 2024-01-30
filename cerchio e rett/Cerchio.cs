using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio_e_rett
{
    internal class Cerchio
    {
        public double Raggio { get; set; }
        public Cerchio(int r)
        {
            Raggio = r;
        }
        public double Area()
        {
            return Raggio * Raggio * 2 * Math.PI;
        }
        public double Perimetro()
        {
            return Raggio * 2 * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("Cerchio di raggio R = {0}", Raggio);
        }
        public static Cerchio Parse(string cerc)
        {
            string[] raggio = cerc.Split('=');
            Cerchio ct = new Cerchio(int.Parse(raggio[1]));
            return ct;
        }
    }
}
