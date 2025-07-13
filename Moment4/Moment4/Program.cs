using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moment4
{
    public class Lager<T>
    {
        private List<T> list = new List<T>();
        public string titel;

        public void Addera(T t) { list.Add(t); }

        public void Visa() 
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}: {titel} {list[i]}");

            }
        }
        
       
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Lager<string> lager1 = new Lager<string>();
            lager1.titel = "Detta är";
            lager1.Addera("Gollum");
            lager1.Addera("Bilbo");
            lager1.Addera("Gandalf");
            Lager<int> lager2 = new Lager<int>();
            lager2.titel = "Ålder";
            lager2.Addera(500);
            lager2.Addera(111);
            lager2.Addera(3000);
            Console.WriteLine("Detta är en lista av Sagan om ringen karaktärer samt deras ålder");
            lager1.Visa();
            lager2.Visa();
            bool run = true;
            while (run)
            {
                Console.WriteLine("Vill du lägga till en karaktär? 1 för ja 2 för att avsluta");
                string svar = Console.ReadLine();
                if (svar == "1")
                {
                    Console.WriteLine("Namn på karaktär");
                    string svar2 = Console.ReadLine();
                    Console.WriteLine("Ålder på karaktären");
                    try
                    {
                        int svar3 = Convert.ToInt32(Console.ReadLine());
                        lager2.Addera(svar3);
                        lager1.Addera(svar2);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Felaktigt tal, karaktär har ej lagts till");
                    }
                    finally
                    {
                        Console.WriteLine("input attempt complete");
                    }
                    lager1.Visa();
                    lager2.Visa();
                }
                else
                {
                    run = false;
                }
            }
        }
    }
}
