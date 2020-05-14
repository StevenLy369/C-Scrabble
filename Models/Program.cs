using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace ScrabbleGame
{
    public class Program
    {
        public static void Main()
        {
            

            Console.WriteLine("Please Enter a word, We shall Tell you the points");
            string input = Console.ReadLine();

            Scrabbles newScrabble = new Scrabbles();
            int point =newScrabble.GetPoints(input);
            Console.WriteLine(input + " is worth " + point);

        }
    }
}
    



