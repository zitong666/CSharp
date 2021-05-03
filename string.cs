using System;

namespace Zitong
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "C# Study";
            Console.WriteLine(phrase.Length);
            //Console.WriteLine("\n");
            Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine("\n");
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("C"));
            Console.WriteLine(phrase[1]);
            Console.WriteLine(phrase.IndexOf("Study"));
            Console.WriteLine(phrase.IndexOf('Z'));
            Console.WriteLine(phrase.Substring(3));
            Console.WriteLine(phrase.Substring(3, 3));
            Console.ReadLine();
        }
    }
}
