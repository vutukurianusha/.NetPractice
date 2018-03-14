
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Name Spaces
namespace ConsoleApplication1
{

    class Program //class
    {
        static void Main(string[] args) //Main Method
        {
            //Variable declaration and datatypes
            int a = 68; 
            float b = 20.434f;
            double c = 13.09876;
            char d = 'a';
            byte[] val = { 0x01, 0xAA, 0xB1, 0xDC, 0x10, 0xDD };
            String str = BitConverter.ToString(val);
            Console.WriteLine(str);//Byte to String conversion
            int e;
            float y,x;
            double g;
           //Type converstion implicit and explicit
            y = (float)a; //int to float
            Console.WriteLine(y);
            e=(int)b;
            Console.WriteLine(e);//float to int
            Console.WriteLine("{0:X}", Convert.ToUInt32(d));//char to hexadecimal
            x=(float)c;
            Console.WriteLine(x);//double to float
            Console.ReadKey();


            //above i covered variables,datatypes,namespaces,class and type converstion
        }
    }
}
