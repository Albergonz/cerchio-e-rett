using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio_e_rett
{
    internal class Rettangolo
    { 
    public double L1 { get; set; }
    public double L2 { get; set; }

    public Rettangolo(int lato1, int lato2)
    {
        L1 = lato1;
        L2 = lato2;
    }

    public double Area()
    {
        return L1 * L2;
    }
    public double Perimetro()
    {
        return 2 * (L1 + L2);
    }

    public override string ToString()
    {
        return string.Format(" lato {0}, lato {1}", L1, L2);
    }

    public static Rettangolo Parse(string rett)
    {
        string[] lati = rett.Split(',');
        Rettangolo rt = new Rettangolo(int.Parse(lati[0]), int.Parse(lati[1]));
        return rt;
    }

}
}
