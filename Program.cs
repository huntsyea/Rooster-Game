using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooster_Fighting__Game
{
    class Gameplay
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;




            Console.Write("WELCOME TO EXTREME ROOSTER FIGHTING");
            Console.Write("\n");
            Console.Write("\nYou are walking along a path and find a rooster on the side of the road. \nYou decide to capture the rooster and take him to fight at the local market \n");

            Console.Write("\nEnter Your Rooster's name: ");
            String roosterName = Convert.ToString(Console.ReadLine());
            Rooster A = new Rooster(roosterName);

            Player Bill = new Player();


            Console.Write($"Your prize fighter is named {A.name} and his attack power is {A.attackPower} points");
            while (true)
            {
                Console.Write("\nAre you ready to fight? (Y or N) ");
                string userAns = Console.ReadLine();
                Rooster B = new Rooster();
                if (userAns == "N" || userAns == "n")
                {
                    Console.WriteLine("You get gang beat for backing out of fight");
                    Console.ReadLine();
                    Console.ResetColor();
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
                    Console.Write($"\nYou fight a local rooster named {B.name}");
                    Console.WriteLine("\n...\n");
                    Console.WriteLine("Loud Screeching");
                    Console.WriteLine("\n...\n");
                    if ((A.attackPower) < (B.attackPower))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYour Rooster was killed");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                        Console.Write("\nBuy New Chicken? (Y or N)");
                        string buynew = Console.ReadLine();

                        if (buynew == "N" || buynew == "n")
                        {
                            break;
                        }
                        else if (buynew == "Y" || buynew == "y")
                        {

                            Bill.bank -= 500;
                            Console.WriteLine($"You were charged $250 for the new rooster.\nYour bank balance is now: {Bill.bank:C2}");
                        }

                    }
                    else if ((A.attackPower) > (B.attackPower))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        double b = Bill.winnings();
                        Console.WriteLine($"\nYour Rooster was the clear victor, slaughtering the local champion. \nYou are awarded {b:C2} ");
                        Console.ResetColor();
                        Console.Write("\nAdd Winnings To Bank? (Y or N)");


                        string addToBank = Console.ReadLine();
                        if (addToBank == "Y" || addToBank == "y")
                        {
                            Bill.bank += b;
                            Console.WriteLine($"Your bank is: {Bill.bank:C2}");
                        }


                        Console.Write("\nPlay Again? (Y or N)");
                        string playagain = Console.ReadLine();
                        if (playagain == "N" || playagain == "n")
                        {
                            break;
                        }
                        else
                            continue;



                    }
                    else if (A.attackPower == B.attackPower)

                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nThe roosters suddenly stop fighting each other and turn on their owners. \nYou die in a pool of your own blood.");
                        Console.ReadLine();
                        Console.ResetColor();
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

        class Player
        {
            public double bank;
            public string name;
            public Player()
            {
                name = "Player 1";
                bank = 0;

            }

            public double winnings()
            {
                Random winnings = new Random();
                return winnings.Next(50, 1000);

            }

        }

        class Rooster
        {
            public int attackPower;
            public string name;
            string[] names = new string[] { "Abby", "Uther", "Thomas", "Michelle", "Abraham", "Bendy" };
            string[] surnames = { "The Mighty", "The Clumsy", "The Strong", "The Lightbringer", "The Pyromancer", "The Necromancer" };

            public Rooster(string Name)
            {
                Random randomi = new Random();
                name = Name;
                attackPower = randomi.Next(1, 100);

            }

            public Rooster()
            {

                Random randname = new Random();

                int num = randname.Next(0, names.Length);
                int num2 = randname.Next(0, surnames.Length);
                name = names[num] + " " + surnames[num2];

                Random randomr = new Random();
                attackPower = randomr.Next(1, 99);



            }






        }


    }
}





