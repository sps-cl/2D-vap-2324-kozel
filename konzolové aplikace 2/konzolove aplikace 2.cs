using System;
using System.Linq;

namespace ConsoleApp1
{
    public class ComplexNumber
    {
        public double Real;
        public double Imaginary;
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            if (other != null)
            {
                return new ComplexNumber(this.Real + other.Real, this.Imaginary + other.Imaginary);
            }
            else
            {
                Console.WriteLine("string je prázdný.");
                return null;
            }
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            if (other != null)
            {
                return new ComplexNumber(this.Real - other.Real, this.Imaginary - other.Imaginary);
            }
            else
            {
                Console.WriteLine("string je prázdný.");
                return null;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prvni komplexni cislo:");
            Console.Write("prvni realne cislo: ");
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("prvni imaginarni cislo: ");
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\ndruhe komplexni cislo:");
            Console.Write("druhe realne cislo: ");
            double real2 = double.Parse(Console.ReadLine());
            Console.Write("druhe imaginarni cislo: ");
            double imaginary2 = double.Parse(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber soucet = complex1.Add(complex2);
            ComplexNumber rozdil = complex1.Subtract(complex2);

            Console.WriteLine($"\nSoucet: {soucet.Real} + {soucet.Imaginary}i");
            Console.WriteLine($"Rozdil: {rozdil.Real} + {rozdil.Imaginary}i");
            Console.ReadLine();
        }
    }
}