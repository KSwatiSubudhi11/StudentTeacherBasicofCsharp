using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class DataTypes
    {
        // Instance method - InstanceOfClass.MethodName(); => new DataTypes().Do();
        public void Do()
        {
            // Numerical
            // 4byte
            // struct, not a class.
            int num1 = 100;
            Console.WriteLine(num1);

            // 8byte
            long num2 = 67943875;
            Console.WriteLine(num2);

            // precision based values - 4 byte
            float num3 = 100.01F;
            Console.WriteLine(num3);

            // 8 byte
            double num4 = 3456784567.56;
            Console.WriteLine(num4);

            // 16 byte
            // declaring a variable
            // datatype nameOfVariable = valueOfvariable;

            decimal num5 = 34567834345.78M;
            
            // Calling a static method
            // Classname.Methodname(<params>);
            Console.WriteLine(num5);

            // Alphanumeric

            char ch = 'C';
            Console.WriteLine(ch);

            // string is a class/reference type. String is immutable.
            string str = "My name";
            Console.WriteLine(str);

            // boolean values (true, false)
            bool isTrue = true;
            Console.WriteLine(isTrue);
        }
    }
}
