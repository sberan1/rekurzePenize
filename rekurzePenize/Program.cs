using System;
using System.Collections.Generic;

namespace rekurzePenize
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int zaplaceno = rnd.Next(10, 20000);
            int cena = rnd.Next(1, zaplaceno);
            int rozdilCen = zaplaceno - cena;
            localPocet = new int[Mince.Length];
            int[] localPocitacka = Pocitacka(rozdilCen, Mince);
            Console.WriteLine("Zaplaceno : " + zaplaceno + " , " + "Cena : " + cena + " , " + "Rozdil : " + rozdilCen);
            for (int i = 0; i < localPocitacka.Length; i++)
            {
                Console.WriteLine(Mince[i] + " : " + localPocitacka[i]);
            }

            
        }

        public static int counterMinci;
        public static int counter;
        public static int[] localPocet;
        public static int[] Mince = { 50, 20, 10, 5, 2, 1 };

        public static int[] Pocitacka(int zbyvaDoplatit, int[] mince)
        {

            

                if (zbyvaDoplatit < mince[counter] && zbyvaDoplatit != 0)
                {
                    localPocet[counter] = counterMinci;
                    counter++;
                    counterMinci = 0;
                    return Pocitacka(zbyvaDoplatit, mince);
                    
                }
                else if (zbyvaDoplatit == 0)
                {
                    localPocet[counter] = counterMinci;
                    return localPocet;
                }
                else
                {
                    counterMinci++;
                    return Pocitacka(zbyvaDoplatit - mince[counter], mince);
                }
        }
    }
}
