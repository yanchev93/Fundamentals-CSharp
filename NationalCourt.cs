using System;

namespace MidExam_29._02._2020_G2
{
    class NationalCourt
    {
        static void Main()
        {
            int employeOne = int.Parse(Console.ReadLine());
            int employeTwo = int.Parse(Console.ReadLine());
            int employeThree = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int answerQuestionsPerHour = employeOne + employeTwo + employeThree;
            int hours = 0;
            while (totalPeople > 0)
            {
                hours += 1;

                if (hours % 4 == 0)
                {
                    continue;
                }

                totalPeople -= answerQuestionsPerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
