using System;
using LibreriaArray;
namespace ArrayOrdinato_piuArrayParieDispari
{
    class Program
    {
        static void Main(string[] args)
        {
            int c_pari = 0, c_disp = 0;
            Console.WriteLine("Inserisci dimensione array: ");
            int x = int.Parse(Console.ReadLine());
            int[] array_random = new int[x];
            Gestione.RiempimentoRandom(array_random);
            Gestione.BubbleSort(array_random, x);
            for (int i = 0; i < array_random.Length; i++)
            {
                if (array_random[i] % 2 == 0)
                    c_pari++;
                else
                    c_disp++;
            }
            int[] array_pari = new int[c_pari];
            int[] array_dispari = new int[c_disp];
            for (int i = 0, j = 0, k = 0; i < x; i++)
            {
                if (array_random[i] % 2 == 0)
                {
                    array_pari[j] = array_random[i];
                    j++;
                }
                else
                {
                    array_dispari[k] = array_random[i];
                    k++;
                }
            }
            Console.WriteLine("Array pari: ");
            Gestione.StampaArray(array_pari);
            Console.WriteLine("Array dispari: ");
            Gestione.StampaArray(array_dispari);
            Console.WriteLine("Array ordinato: ");
            Gestione.StampaArray(array_random);
        }
    }
}
