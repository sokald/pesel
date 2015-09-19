using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesel p = new Pesel("44051401359");
            Console.WriteLine("start");
            p.check(p.Pesel1);
            
            Console.WriteLine("pesel: "+p.Pesel1+" wynik: "+p.Result);
            Console.ReadLine();
        }
    }
}
