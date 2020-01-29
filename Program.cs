using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_27
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            double bank = 0;

            Console.Write("Welcome To Extreme Rooster Fighting");
            Console.Write("\n");
            Console.Write("\nYou found a rooster on the side of the road. \nYou decide to capture the rooster and take him to fight at the local market \n");



            Console.Write("\nEnter Your Rooster's name: ");
            String roosterName = Convert.ToString(Console.ReadLine());

            Console.Write("\nChoose a number between 1 and 20: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nChoose another number between 80 and 100: ");
            int max = Convert.ToInt32(Console.ReadLine());

           
                Console.Write($"Your prize fighter is named {roosterName} and his attack power is {attack(min, max)} points");
                while (true)
            {
                Console.Write("\nAre you ready to fight? (Y or N) ");
                string userAns = Console.ReadLine();

                if (userAns == "N" || userAns == "n")
                {
                    Console.WriteLine("You get gang beat for backing out of fight");
                    Console.ReadLine();
                    Console.Write("Play Again?");
                    string playagain = Console.ReadLine();
                    if (playagain == "N" || playagain == "n")
                    {
                        break;
                    }
                    else
                        continue;
                }

                else if (userAns == "Y" || userAns == "y")
                {
                    Console.Write("\nYou fight a local hero named Duke");
                    Console.WriteLine("\n...\n");
                    Console.WriteLine("Loud Screeching");
                    Console.WriteLine("\n...\n");
                    if (attack(min, max) < compAttack())
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYour Rooster was killed");
                        Console.ReadLine();
                        Console.Write("\nPlay Again? (Y or N)");
                        string playagain = Console.ReadLine();
                        if (playagain == "N" || playagain == "n")
                        {
                            break;
                        }
                        else
                            continue;
                    }
                    else if (attack(min, max) > compAttack())
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        double earnings = winnings();
                        Console.WriteLine($"\nYour Rooster was the clear victor, slaughtering the local champion. \nYou are awarded {earnings:C2} ");
                        Console.Write("\nAdd Winnings To Bank? (Y or N)");
                        string addToBank = Console.ReadLine();
                        if (addToBank == "Y" || addToBank == "y")
                        {
                            bank += (earnings);
                            Console.WriteLine($"Your bank is: {bank:C2}");
                        }


                        Console.Write("\nPlay Again? (Y or N)");
                        string playagain = Console.ReadLine();
                        if (playagain == "N" || playagain == "n")
                        {
                            break;
                        }
                        else
                            continue;


                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nThe roosters suddenly stop fighting each other and turn on their owners. \nYou die in a pool of your own blood.");
                        Console.ReadLine();
                        Console.Write("\nPlay Again? (Y or N)");
                        string playagain = Console.ReadLine();
                        if (playagain == "N" || playagain == "n")
                        {
                            break;
                        }
                        else
                            continue;
                    }
                }

                else
                {
                    Console.WriteLine("\nWrong Value");
                    Console.ReadLine();
                }

            }
        }
        static int attack(int min, int max)
        {
            Random attack = new Random();
            return attack.Next(min, max);
        }

        static int compAttack()
        {
            Random compAttack = new Random();
            return compAttack.Next(0, 100);
        }

        static double winnings()
        {
            Random winnings = new Random();
            return winnings.Next(50, 1000);
        }

    }




}
