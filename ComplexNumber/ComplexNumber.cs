using System;
namespace ComplexNumber
{
    public class ComplexNumber
    {
        private MyInteger realPart;
        private MyInteger imaginaryPart;

        public ComplexNumber()
        {
        }

        public ComplexNumber(MyInteger realPart, MyInteger imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        public ComplexNumber(MyInteger realPart)
        {
            this.realPart = realPart;
        }

        public MyInteger getRealPart(){
            return this.realPart;
        }

        public void setRealPart(MyInteger realPart){
            this.realPart = realPart;
        }

        public MyInteger getImaginaryPart(){
            return this.imaginaryPart;
        }

        public void setImaginaryPart(MyInteger imaginaryPart){
            this.imaginaryPart = imaginaryPart;
        }

        public static ComplexNumber operator +(ComplexNumber complexNumber1, ComplexNumber complexNumber2){
            return new ComplexNumber(complexNumber1.realPart + complexNumber2.realPart, complexNumber1.imaginaryPart + complexNumber2.imaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber(complexNumber1.realPart - complexNumber2.realPart, complexNumber1.imaginaryPart - complexNumber2.imaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            return new ComplexNumber((complexNumber1.realPart * complexNumber2.realPart) - (complexNumber1.imaginaryPart * complexNumber2.imaginaryPart), 
                                     (complexNumber1.realPart * complexNumber2.imaginaryPart) + (complexNumber1.imaginaryPart * complexNumber2.realPart));
        }

        public static ComplexNumber operator /(ComplexNumber complexNumber1, ComplexNumber complexNumber2)
        {
            MyInteger realPart = (complexNumber1.realPart * complexNumber2.realPart) + (complexNumber1.imaginaryPart * complexNumber2.imaginaryPart) /
                ((complexNumber2.realPart * complexNumber2.realPart) + (complexNumber2.imaginaryPart * complexNumber2.imaginaryPart));
            MyInteger imaginaryPart = (complexNumber1.realPart * complexNumber2.realPart) - (complexNumber1.imaginaryPart * complexNumber2.imaginaryPart) /
                ((complexNumber2.realPart * complexNumber2.realPart) + (complexNumber2.imaginaryPart * complexNumber2.imaginaryPart));
            return new ComplexNumber(realPart, imaginaryPart);
        } 

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", realPart, imaginaryPart));
        }
    }
}