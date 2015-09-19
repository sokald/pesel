using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pesel
{
    class Pesel
    {
        public Pesel() {
            pesel = "00000000000";
            result = false;
        }

        public Pesel(string p)
        {
            pesel = p;
            result = false;
        }

        //varibles
        string pesel;
        bool result;

        public string Pesel1
        {
            get { return pesel; }
            set { pesel = value; }
        }
        
        public bool Result
        {
            get { return result; }
            set { result = value; }
        }

        //check pesel
        public bool check() {

            return false;
        }

        public void check(string pesel)
        {
            byte[] tab = new byte[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sumControl = 0;
            if(pesel.Length==11){    
                for(int i= 0; i<pesel.Length-1; i++)
                {
                    sumControl += tab[i] * int.Parse(pesel[i].ToString());
                }
            }

            int numControl = sumControl % 10;
            if (numControl != 0)
            {
                numControl = 10 - numControl;
            }
            Console.WriteLine("suma kontrolna="+numControl);
            Console.WriteLine("ostatni cyfra peselu=" + pesel[10]);
            if (numControl == int.Parse(pesel[10].ToString()))
            {
                Console.WriteLine("poprawny pesel------------------------------------------");
                result = true;
            }else{
                Console.WriteLine("NIE poprawny pesel------------------------------------------");
                result = false;
            }
        }
    }
}
