using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie_babelkowe
{
    internal class Program
    {
        public static void bubble_sort(int[]tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] < tab[j + 1])
                    {
                        int bufor = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = bufor;
                    }
                }
            }
            for(int i=0; i<tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] tab = { 2, 1, 5, 2 ,3,-5,9};
            bubble_sort(tab);
        }
    }
}
