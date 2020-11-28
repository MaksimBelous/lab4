using System;
using lab4.library;

namespace lab4.application
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString capitalizeLetter = new CapitalizeLetter(new char[] { 'A', 'B', 'C', 'B'});

            Console.WriteLine("CapitalizeLetter value: " + new string(capitalizeLetter.GetValue()));
            Console.WriteLine("CapitalizeLetter length: " + capitalizeLetter.GetLength().ToString());
            Console.WriteLine("CapitalizeLetter count symbols 'B': " + capitalizeLetter.CountSymbols().ToString());

            MyString symbols = new Symbols(new char[] { '!', '@', '*', '*' });

            Console.WriteLine("Symbols value: " + new string(symbols.GetValue()));
            Console.WriteLine("Symbols length: " + symbols.GetLength().ToString());
            Console.WriteLine("Symbols count symbols '*': " + symbols.CountSymbols().ToString());
        }
    }
}
