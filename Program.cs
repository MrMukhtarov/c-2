using System;


namespace Homeworkcsharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task - 1
            //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod
            //-3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return edir Eyni sekilde verilmis
            //4 ve 5 ededin en boyuyunu tapan metodlar da yazin(method overloading)

            Num();
        }
       static int Num(int num1 , int num2 , int num3)
        {
            int result = 0;
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
                result = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
                result = num2;
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3);
                result = num3;
            }
            return result;
        }
       
    }
}
