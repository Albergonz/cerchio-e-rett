using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerchio_e_rett
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo(5, 4);
            r.ToString();
            Console.WriteLine(r);

            Rettangolo r2 = new Rettangolo(7, 5);
            r2.ToString();
            r2 = Rettangolo.Parse(r.ToString());
            Console.WriteLine(r2);


            Cerchio c = new Cerchio(5);
            c.ToString();
            Console.WriteLine(c);

            Cerchio c2 = new Cerchio(7);
            c2.ToString();
            c2 = Cerchio.Parse(c.ToString());
            Console.WriteLine(c2);

            Console.ReadLine();
        }
    }
}
