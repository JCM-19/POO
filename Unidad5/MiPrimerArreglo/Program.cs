using System;

namespace MiPrimerArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int[] valores = new int[11];
            int Num = 0;
            string Dato = "";
            int n = 0;
            int mayor = 0;

            for (n=0; n <10; n++)

            {
                Console.WriteLine("Dame un numero del 1 al 10");
                Dato = Console.ReadLine();
                Num = Convert.ToInt32(Dato);

                valores[Num]++;

            }
            for(n=0; n<11;n++)
                {
                Console.WriteLine("El numero {0} aparecio {1} veces", n, valores[n]);
            }
            for (n=0; n<11; n++)
            {
                if (valores[n] > mayor)
                    mayor = n;
            }
            Console.WriteLine("El numero que se repitió mas veces es {0}", mayor);
            Console.ReadLine();


        }
    }
}
