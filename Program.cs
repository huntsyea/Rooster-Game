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
            


            Console.Write("WELCOME TO ROOSTER FIGHTING");
            Console.Write("\n");
            Console.Write("\nYou are walking along a path and find a rooster on the side of the road. \nYou decide to capture the rooster and take him to fight at the local market \n");
            Console.Write("\nEnter Your Rooster's name: ");
            String roosterName = Convert.ToString(Console.ReadLine());
            Rooster A = new Rooster(roosterName);
            Console.Write($"Your prize fighter is named {A.name} and his attack power is {A.attackPower} points");
            Console.Write("\n ");
            Console.Write("\nPress Enter To Proceed To Match");
            Console.ReadLine();
            Player User = new Player();
           


            while (true)
            {
                Rooster B = new Rooster();
                Sounds Sound = new Sounds();
                Console.Write($"\nYou fight a local rooster named {B.name}");
                Console.WriteLine("\n...\n");
                Console.WriteLine(Sound.texting);
                Console.WriteLine("\n...\n");

                if ((A.attackPower) < (B.attackPower))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    double z = User.losings();
                    Console.WriteLine($"\nYour Rooster was killed! Your competitor takes {z:C2}");
                    User.bank -= z;
                    Console.WriteLine($"Your bank is: {User.bank:C2}");
                    
                    Console.ResetColor();
                    Console.Write("\nWant To Buy New Chicken? (Y or N): ");
                    string buynew = Console.ReadLine();

                    if (buynew == "N" || buynew == "n")
                    {
                        break;
                    }
                    else if (buynew == "Y" || buynew == "y")
                    {

                        User.bank -= 250;
                        Console.WriteLine($"You were charged $250 for the new rooster.\nYour bank balance is now: {User.bank:C2}");
                        Console.Write("\nEnter Your Rooster's name: ");
                        String roosterNew = Convert.ToString(Console.ReadLine());
                        Rooster C = new Rooster(roosterNew);
                        Console.Write($"Your prize fighter is named {C.name} and his attack power is {C.attackPower} points");
                        Console.Write("\n ");
                        Console.Write("\nPress Enter To Proceed To Match");
                        Console.ReadLine();


                    }

                    else
                    {
                        Console.WriteLine("Wrong Value");
                        break;
                    }
                }
                else if ((A.attackPower) > (B.attackPower))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    double b = User.winnings();
                    Console.WriteLine($"\nYour Rooster was the clear victor, slaughtering the local champion. \nYou are awarded {b:C2} ");
                    Console.ResetColor();
                    Console.Write("\nAdd Winnings To Bank? (Y or N): ");


                    string addToBank = Console.ReadLine();
                    if (addToBank == "Y" || addToBank == "y")
                    {
                        User.bank += b;
                        Console.WriteLine($"Your bank is: {User.bank:C2}");
                    }

                    Console.Write("\n ");
                    Console.Write("\nNext Match? (Y or N): ");
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
                    break;
                   
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

            public double losings()
            {
                Random losings = new Random();
                return losings.Next(50, 1000);

            }

            

        }
        class Sounds
        {
            public string texting;
            string[] fightsounds = new string[] { "Screeching Intensifies", "The roosters fight relentlessly as you gaze at the local maid.", "Clawing and Nashing Noises", "Bloodlust Intensifies" };

            public Sounds()
            {
                Random randnam = new Random();
                int num = randnam.Next(0, fightsounds.Length);
                texting = fightsounds[num];
                
                
                
            }


        }
        class Rooster
        {
            public int attackPower;
            public string name;
            string[] names = new string[] { "Tonto", "Flinn", "Red", "Junior", "Abraham", "Bendy" };
            string[] surnames = { "The Mighty", "The Clumsy", "The Strong", "Silverclaw", "Peckerneck", "The Feathered Destroyer" };
            
            public Rooster(string Name)
            {
                Random randomi = new Random();
                name = Name;
                attackPower = randomi.Next(1, 50);

            }

            public Rooster()
            {

                Random randname = new Random();

                int num = randname.Next(0, names.Length);
                int num2 = randname.Next(0, surnames.Length);
                name = names[num] + " " + surnames[num2];

                Random randomr = new Random();
                attackPower = randomr.Next(1, 50);



            }






        }


    }
}





