using System;
using System.Collections.Generic;

namespace GetToKnowClassmatesLab
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>() { "Phillip", "Andy", "Cassly", "Zachary", "Cortez", "Richard", "Erin", "James", "Cullin", "Cordero"};
            List<string> hometown = new List<string>() { "Canton, MI", "Berkley, MI", "Detroit, MI", "Wyandotte, MI", "Detroit, MI", "Canton, MI", "Troy, MI", "Yap, FSM", "Fowlerville, MI", "Berkley, MI" };
            List<string> food = new List<string>() { "Fried Chicken", "French Fries", "Steak", "Sushi", "Chicken Fettuccine Alfredo", "Sushi", "Tacos", "Katsu", "Pad Thai", "BBQ" };

            bool again = true;
            while (again)
            {


                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (Enter a number 1-10");

                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {names[i]}");
                }
                int studentResponse = int.Parse(Console.ReadLine()) - 1;
                bool invalidStudent = true;
                while (invalidStudent)
                {


                    if (studentResponse >= 0 && studentResponse <= names.Count)
                        invalidStudent = false;
                    else
                    {
                        Console.WriteLine("That student does not exist. Please try again (enter a number 1-10)");
                        studentResponse = int.Parse(Console.ReadLine()) - 1;
                        invalidStudent = true;
                    }
                }
                bool more = true;
                while (more)
                {

                    string knowMore = "no";
                    Console.WriteLine($"Student {studentResponse + 1} is {names[studentResponse]}. What would you like to know about {names[studentResponse]} (enter \"hometown\" or \"favorite food\")");
                    string infoResponse = Console.ReadLine().ToLower();

                    bool askAgain = true;
                    while (askAgain)
                    {


                        if (infoResponse == "hometown")
                        {
                            Console.WriteLine($"{names[studentResponse]} is from {hometown[studentResponse]}. Would you like to know more? (enter \"yes\" or \"no\")");
                            knowMore = Console.ReadLine().ToLower();
                            askAgain = false;
                        }
                        else if (infoResponse == "favorite food")
                        {
                            Console.WriteLine($"{food[studentResponse]} is the favorite food of {names[studentResponse]}. Would you like to know more? (enter \"yes\" or \"no\")");
                            knowMore = Console.ReadLine().ToLower();
                            askAgain = false;
                        }
                        else
                        {

                            Console.WriteLine("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\")");
                            infoResponse = Console.ReadLine().ToLower();
                            askAgain = true;
                        }
                    }
                    if (knowMore == "no")
                    {
                        more = false;
                        Console.WriteLine("Thanks!");

                    }
                    else if (knowMore == "yes")
                    {
                        more = true;
                    }
                }
                Console.WriteLine("Would you like to learn about any other class members? (enter \"yes\" or \"no\")");
                string otherMembers = Console.ReadLine().ToLower();
                if (otherMembers == "no")
                {
                    Console.WriteLine("Goodbye");
                    again = false;
                }
                else if (otherMembers == "yes")
                {
                    again = true;
                }
            }


        }
    }
}
