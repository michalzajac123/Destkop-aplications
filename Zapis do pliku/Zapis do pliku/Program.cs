using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapis_do_pliku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ścieżka do pliku
            string filePath = "example.txt";

            //Tworzenie pliku i zapisanie danych

            //using (StreamWriter writer = new StreamWriter(filePath,true))
            //{
            //    writer.WriteLine("Linia 1: CSGO-skins.com");
            //    writer.WriteLine("Linia 2: Coś tam");
            //    writer.WriteLine("Linia 3: nie mam pomysłu");
            //}
            //Console.WriteLine("Dane zostały zapisanie do pliku.");

            //Sprawdzenie cyz plik istneieje
            if(File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while((line=reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                File.Delete(filePath);
                Console.WriteLine("Plik został usunięty!");
            }
            else
            {
                Console.WriteLine("Plik nie istnieje");
            }

        }
    }
}
