﻿namespace Pilli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilli sorsapilli = new Pilli("Kvaak");
            Pilli kukkopilli = new Pilli("Peef");
            sorsapilli.Soi();
            kukkopilli.Soi();
            sorsapilli.Soi();
            
            Console.ReadLine();
        }
    }
}