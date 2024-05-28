using System;

namespace C_1_Skill_Refresher
{
    class Program
    {
        static void Main(string[] args)
        {
            string stay = "no";
            while (stay == "no")
            {
                Console.WriteLine("Are you ready to play?");
                string answer = Console.ReadLine();
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Okay get ready to play!");
                    stay = "yes";
                }
                else if (answer == "no")
                    Console.WriteLine("Okay, just tell me when you are ready to play.");
                else
                    Console.WriteLine("Sorry that is an invalid input.");
            }

            Console.WriteLine("Hello my name is Ross Lowrance. What is your name?");
            Console.WriteLine("Hello Mr. Lowrance. My name is Jonathan Davis.");
            Math.adding();
            int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };
            Console.WriteLine(evenNums);

            Math.count();
        }
    }

    class Math
    {
        public static string adding()
        {
            int a = 2;
            Console.WriteLine(2 + 2);
            Console.WriteLine(10000 / 4);
            Console.WriteLine((6 + 2) * (18 - 3) * (94 / 7));
            return "";
        }
        public static string count()
        {
            Console.WriteLine("What time do you want to count down from. Please put a number in that is above 0.");
            int result = int.Parse(Console.ReadLine());
            int counter = -1;
            while (counter < result)
            {
                Console.WriteLine("{0}.",
                    result, result - 1);
                result--;
            }

            Console.ReadLine();
            return "";
        }

    }
}