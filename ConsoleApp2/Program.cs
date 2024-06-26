using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1235352, b = 3, c = 7, d = 745;
            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute(@"cd C:\Users\erent\Downloads");
            object res = null;
            matlab.Feval("myfun", 3, out res, a, b, c, d);
            object[] result = res as object[];
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);
            matlab.Quit();
            Console.ReadLine();
        }
    }
}