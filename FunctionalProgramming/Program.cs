using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions functions = new Functions();
            Console.WriteLine("Grades to Average(minus lowest 3): 90, 65, 100, 82, 89, 55, 69");
            functions.AverageGrades();
            Console.WriteLine("To be counted: Go Pack Go");
            functions.CountLetters();
            Console.ReadLine();
        }
    }
}
