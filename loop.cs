using System;

namespace Loops
{
    class loop
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\nThis program tests different types of loops.");
            Console.WriteLine("Which loop would you like to perform?\n");

            Console.WriteLine("1. if and else");
            Console.WriteLine("2. for");
            Console.WriteLine("3. switch");
            Console.WriteLine("4. while\n");

            int whichloop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYou picked " + whichloop);

            if(whichloop == 1)
            {
                Console.WriteLine("Let's explore if loops.");
                Console.Write("\nPlease write the word \"hello: ");

                string writeHello = Console.ReadLine();

                Console.WriteLine("\nYou wrote " + writeHello + ".\nNow processing input...");
                bool correct = writeHello.ToLower() == "hello";

                if(correct == true)
                {
                    Console.WriteLine("\nYou have input a CORRECT word! Congrats.");
                }
                else
                {
                    Console.WriteLine("\nYou have input an incorrect word. You failed.");
                }

            }
            else if(whichloop == 2)
            {
                Console.WriteLine("\nLet's explore for loops\n");
                Console.WriteLine("Time to pick a lock! It has a 25% chance to open when picked.\nHowever, it also has a 10% chance to break the key.");
                Console.Write("\nHow many times would you like to try to pick the lock: ");

                int runTimes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nYou will try to pick this lock " + runTimes + " times.");

                Console.WriteLine("Time to try the key!");
                Random rnd = new Random();
                int breakNumber = 0;
                int openChance = 0;

                for(int forloop1 = 0; forloop1 < runTimes; forloop1++)
                {
                    Console.WriteLine("\nThis is Try number " + (forloop1 + 1));
                    breakNumber = rnd.Next(1,21);
                    Console.WriteLine("Generated random Break Number " + breakNumber);
                    openChance = rnd.Next(1,21);
                    Console.WriteLine("Generated random Open Number " + openChance);

                    if(breakNumber < 18)
                    {
                        Console.WriteLine("You have not broken the key.");
                        Console.WriteLine("Did it open the lock?");

                        if(openChance >= 15)
                        {
                            Console.WriteLine("You successfully opened the lock! CONGRATS!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You did not successfully open the lock.");
                            Console.WriteLine("Press Enter to try again");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have broken the key. RIP");
                        break;
                    }
                }
            }
            else if(whichloop == 3)
            {
                Console.WriteLine("\nLet's explore switch loops");
                Console.Write("\nThe table has 4 buttons. 1, 2, 3, and 4.\n1 has snakes\n2 has bears\n3 has beetles\n4 has puppies and kittens\n\nWhich number button do you pick? ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You picked button number " + choice + ".\n");

                switch(choice)
                {
                    case 1: 
                        Console.WriteLine("Ready for some toy snakes? Cool. Here's a cool rainbow one. Take it with you!");
                        break;
                    case 2:
                        Console.WriteLine("Ready for your very own Build-a-Bear stuff bear??? Let's go make one! Screw this place!");
                        break;
                    case 3:
                        Console.WriteLine("Ready too see a really cool beetle? I found some really cool ones in Animal Crossing! I'll show ya!");
                        break;
                    case 4:
                        Console.WriteLine("The puppies and kittens instantly maul you and you die. RIP YOU LOST");
                        break;
                }

                Console.WriteLine("\n\nThis concludes the button program with a switch.");

            }
            else if(whichloop == 4)
            {
                Console.WriteLine("\nLet's explore while loops");

                Console.Write("\nWhat is your favorite number: ");
                int favnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\nYour favorite number is " + favnum);
                int originalfavnum = favnum;
                
                while(favnum == originalfavnum)
                {
                    Console.Write("\nI don't like that number. Choose a different number or stay here forever: ");
                    favnum = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Thank god. " + originalfavnum + " was a stupid number anyways.");
            }
            else
            {
                Console.WriteLine("\nIncorrect selection.");
            }

        }
    }
}