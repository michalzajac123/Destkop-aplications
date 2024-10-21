using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapis_i_odczyt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista obecnosci
            string fileName = "lista.txt";


            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Podaj ucznia");
                    string name = Console.ReadLine();
                    writer.WriteLine(name);
                }
            }
            if(File.Exists(fileName))
            {
                using (StreamReader reader= new StreamReader(fileName))
                {
                    string line;
                    while((line=reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Plik nie istnieje");
            }
        }
    }
}
