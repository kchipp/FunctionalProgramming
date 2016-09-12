using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Functions
    {
        public Functions()//constructor
        {

        }

        public void AverageGrades()
        {
            string scores = "90, 65, 100, 82, 89, 55, 69";

            List<double> list = new List<double>();

            double score;

            var scoreNumbers = scores.Split(new[] { ',' })
                .Select(scoreToString => double.TryParse(scoreToString, out score) ? score : 0)
                .ToList()
                .OrderBy(scoresValue => scoresValue).Skip(3);

            double averageGrade = scoreNumbers.Average();

            Console.WriteLine($"Average {averageGrade}");


        }

        public void CountLetters()
        {
            string word = "GoPackGo";
            word = string.Concat(word.ToUpper().OrderBy(a => a));
            var sortString = word.GroupBy(b => b)
                .Select(collect => new { Char = collect.Key, Count = collect.Count() });

            foreach (var letter in sortString)
            {
                Console.Write($"{letter.Char}{letter.Count}");
            };

        }


    }//class
}//namespace
