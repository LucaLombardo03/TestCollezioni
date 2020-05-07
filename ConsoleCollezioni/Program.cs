using System;
using MetodiCollezioni;

namespace ConsoleCollezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la prima stringa: ");
            string s1 = Console.ReadLine();
            Console.Write("Inserisci la seconda stringa: ");
            string s2 = Console.ReadLine();
            bool uguaglianza = Metodi.StringheUguali(s1, s2);
            Console.Write("Le stringhe sono uguali? " + uguaglianza);
            
            Console.WriteLine();
            
            Console.Write("Inserisci una stringa: ");
            string s3 = Console.ReadLine();
            bool maiuscole = Metodi.ContainsDoubleChar(s3);
            Console.Write("La stringa contiene lettere maiuscole? " + maiuscole);  
        }
    }
}
