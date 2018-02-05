using System;

namespace ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            MyInteger m1 = new MyInteger(3);
            MyInteger m2 = new MyInteger(4);
            MyInteger m3 = new MyInteger(5);
            MyInteger m4 = new MyInteger(6);
            ComplexNumber complexNumber1 = new ComplexNumber(m1,m2);
            ComplexNumber complexNumber2 = new ComplexNumber(m3, m4);
            ComplexNumber complexNumber3 = complexNumber1 + complexNumber2;
            ComplexNumber complexNumber4 = complexNumber2 - complexNumber1;
            ComplexNumber complexNumber5 = complexNumber1 * complexNumber2;
            ComplexNumber complexNumber6 = complexNumber2 / complexNumber1;
            Console.WriteLine(complexNumber6);
            Console.WriteLine(complexNumber5);
            Console.WriteLine(complexNumber4);
            Console.WriteLine(complexNumber3.ToString());
            Console.WriteLine("Hello World!");
        }
    }
}
