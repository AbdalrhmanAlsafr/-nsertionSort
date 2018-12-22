using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
    
        public static void diziyedegerat()
        {
            Random uretec = new Random();
           
            for(int i=0;i<dizi.Length;i++)
            {
                dizi[i] = uretec.Next(20,50);
            }
        }
        public static int[] dizi = new int[100];
        public static void dizisirala()
        {
            int a, elmean;

            for(int i=1;i<dizi.Length;i++)
            {
              
                a = dizi[i];
                elmean = i;
                while (elmean > 0 && dizi[elmean - 1] >= a)
                {
                    dizi[elmean] = dizi[elmean - 1];
                    elmean -= 1;
                }
                dizi[elmean] = a;
            }


        }


        static void Main(string[] args)
        {
           
            diziyedegerat();
            Console.WriteLine("işlem biti");
            dizisirala();








            for (int i=0;i<dizi.Length;i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }








    }
}
