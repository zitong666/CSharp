using System;

namespace Zitong
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Sam";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";

            Console.WriteLine("He really liked the " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            //Console.WriteLine("/___|");
            //Console.WriteLine("I am Zitong!");

            Console.ReadLine();
        }
    }
}
