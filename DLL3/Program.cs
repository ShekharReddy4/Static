using System;
using Assignment4;
namespace DLL3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The value in TestClass.i before in DLL3 is :{0}", TestClass.i);
            TestClass.i = TestClass.i + 23;
            System.Console.WriteLine("The value in TestClass.i after modifying in DLL3 is :{0}", TestClass.i);
            Console.ReadKey();
        }
    }
}