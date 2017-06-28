using System;
using System.Diagnostics;
using Assignment4;
namespace DLL2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The value in TestClass.i in DLL2 Before modifying is {0}", TestClass.i);
            TestClass.i = 30;
            System.Console.WriteLine("The value in TestClass.i in DLL2 after modifying is {0}", TestClass.i);
            Process DLL3Process = Process.Start("C:/Users/shekhar.mittapelly/Desktop/NewAssignments/DLL3/bin/Debug/Net451/DLL3.exe");
            Console.ReadKey();
        }
    }
}