using System;

namespace LibreriaArray
{
    public class Gestione
    {
        public static void RiempimentoRandom(int[] array)
        {
            Random r = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(101);
            }
        }
        public static void BubbleSort(int[] n, int tanti)
        {
            int x, y;
            int temp;
            for (x = 0; x < tanti - 1; x++)
            {
                for (y = 0; y < tanti - 1 - x; y++)
                {
                    if (n[y] > n[y + 1])
                    {
                        temp = n[y];
                        n[y] = n[y + 1];
                        n[y + 1] = temp;
                    }
                }
            }
        }
        public static void StampaArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
