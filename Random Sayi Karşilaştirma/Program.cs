using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Sayi_Karşilaştirma
{  
    public class Tahmin
    {       
        public int RandomSayi()
        {
            int x = new Random().Next(1,11);

            int y = Convert.ToInt32(Console.ReadLine());

            while (y != x)
            {                               
                Console.WriteLine(y + " yanlış tahmin ");
                y = Convert.ToInt32(Console.ReadLine());
            }

            if(y == x)
            {
                Console.WriteLine(y + " doğru tahmin " + x);
            }              
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            Tahmin deneme = new Tahmin();
            deneme.RandomSayi();
            //Console.ReadKey();
        }
    }
}
