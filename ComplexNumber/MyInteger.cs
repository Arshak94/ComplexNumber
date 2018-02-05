using System;
namespace ComplexNumber
{
    public struct MyInteger
    {
        private int value;

        public MyInteger(int value)
        {
            this.value = value;
        }

        public override string ToString() => $"{value}";


        public static MyInteger operator +(MyInteger var1, MyInteger var2)
        {
            return new MyInteger(var1.value + var2.value); 
        }
        public static MyInteger operator -(MyInteger var1, MyInteger var2)
        {
            return new MyInteger(var1.value - var2.value);
        }
        public static MyInteger operator *(MyInteger var1, MyInteger var2)
        {
            return new MyInteger(var1.value * var2.value);
        }

        public static MyInteger operator /(MyInteger var1, MyInteger var2)
        {
            return new MyInteger(var1.value / var2.value);
        }
    }
}
