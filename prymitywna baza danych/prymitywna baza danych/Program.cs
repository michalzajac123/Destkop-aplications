using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Tepersont;
using System.Threading.Tasks;

namespace prymitywna_baza_danych
{
    internal class Program
    {
        public class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            string filePath = "dane.tpersont";

            List<Person>list = new List<Person>();

            if(File.Exists(filePath))
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        Person person= new Person();
                        person.firstName = data[0];
                        person.lastName = data[1];
                        person.Age = int.Parse(data[2]);
                        list.Add(person);
                    }
                }
            }
            Console.WriteLine("Lista osob w bazie: ");
            list.ForEach(person => Console.WriteLine(person.firstName+" "+person.lastName+" "+person.Age+" lat"));

        }
    }
}
