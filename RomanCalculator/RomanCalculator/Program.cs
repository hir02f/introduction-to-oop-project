using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RomanCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Roman Numeral:");
            string romanNumeral = Console.ReadLine();

            while (!new Calculate().validRomanNumbers().Contains(romanNumeral))
            {
                Console.WriteLine("Try again, please enter a Roman Numeral up to X:");
                romanNumeral = Console.ReadLine();
            }
            int outputNumber = new Calculate().getNumber(romanNumeral);
            Console.WriteLine($"You converted the Roman Numeral {romanNumeral} to the number {outputNumber}");
        }
    }
}
