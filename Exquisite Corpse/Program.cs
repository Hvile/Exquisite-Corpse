using System;
using System.Linq;

namespace Exquisite_Corpse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose what mode you want to play.\n1. Random mode.\n2. Non random mode.");

                string userInput = Console.ReadLine();

                if (!userInput.All(char.IsDigit))
                {
                    Console.WriteLine("\nYou need to choose a number. Please try again.\n");
                }
                else if (Convert.ToInt32(userInput) == 1)
                {
                    RandomGameplay();
                }

                else if (Convert.ToInt32(userInput) == 2)
                {
                    NonRandomGameplay();
                }

                else
                {
                    Console.WriteLine("\nYou need to choose a number, 1 or 2.\n");
                }
            }

        }

        static void RandomGameplay()
        {
            Random randomcheck = new Random();
            while (true)
            {
                string headSelect = Convert.ToString (randomcheck.Next(1, 4));
                string bodySelect = Convert.ToString (randomcheck.Next(1, 4));
                string feetSelect = Convert.ToString (randomcheck.Next(1, 4));

                BuildACreature(headSelect, bodySelect, feetSelect);

                Console.WriteLine("To play again press Y, otherwise N.");

                string userInput = Console.ReadLine().ToUpper();
                
                if (userInput == "N")
                {
                    break;
                }
            }





        }
        static void NonRandomGameplay()

        {
            while (true)
            {
                bool check1 = true;
                bool check2 = true;
                bool check3 = true;

                string headSelect = "";
                string bodySelect = "";
                string feetSelect = "";

                while (check1)
                {
                    Console.WriteLine("Choose a head!\n1. Ghost head.\n2. Bug head.\n3. Monster head.");
                    headSelect = Console.ReadLine();
                    check1 = CheckNumber(headSelect, check1);

                }


                while (check2)
                {
                    Console.WriteLine("Choose a body!\n1. Ghost body.\n2. Bug body.\n3. Monster body.");
                    bodySelect = Console.ReadLine();
                    check2 = CheckNumber(bodySelect, check2);

                }

                while (check3)
                {
                    Console.WriteLine("Choose feet!\n1. Ghost feet.\n2. Bug feet.\n3. Monster feet.");
                    feetSelect = Console.ReadLine();
                    check3 = CheckNumber(feetSelect, check3);

                }


                BuildACreature(headSelect, bodySelect, feetSelect);

                Console.WriteLine("To play again press Y, otherwise N.");

                string userInput = Console.ReadLine().ToUpper();

                if (userInput == "N")
                {
                    break;
                }
            }
        }

            static bool CheckNumber(string numbercheck,bool check)
            {
                if (!numbercheck.All(char.IsDigit))
                {
                    Console.WriteLine("\nYou need to choose a number. Please try again.\n");
                }
                else if (Convert.ToInt32(numbercheck) > 0 && Convert.ToInt32(numbercheck) <= 3)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("\nYou need to choose a number between 1 and 3.\n");
                }
                return check;
            }

            static void BuildACreature(string head, string body, string feet)
            {


                switch (Convert.ToInt32(head))
                {
                    case 1:
                        GhostHead();
                        break;

                    case 2:
                        BugHead();
                        break;

                    case 3:
                        MonsterHead();
                        break;

                    default:
                        break;
                }



                switch (Convert.ToInt32(body))
                {
                    case 1:
                        GhostBody();
                        break;

                    case 2:
                        BugBody();
                        break;

                    case 3:
                        MonsterBody();
                        break;

                    default:
                        Console.WriteLine("You need to choose a number");
                        break;
                }



                switch (Convert.ToInt32(feet))
                {
                    case 1:
                        GhostFeet();
                        break;

                    case 2:
                        BugFeet();
                        break;

                    case 3:
                        MonsterFeet();
                        break;

                    default:
                        Console.WriteLine("You need to choose a number");
                        break;
                }


            }

            static void GhostHead()
            {
                Console.WriteLine("     -----");
                Console.WriteLine("    | o O |");
                Console.WriteLine("    |  O  |");
            }

            static void GhostBody()
            {
                Console.WriteLine("    |     |");
                Console.WriteLine("    |     |");
                Console.WriteLine("    |     |");
            }

            static void GhostFeet()
            {
                Console.WriteLine("    |     |");
                Console.WriteLine("    |     |");
                Console.WriteLine("    '~~~~~'");
            }

            static void BugHead()
            {
                Console.WriteLine("     /   \\");
                Console.WriteLine("     \\. ./");
                Console.WriteLine("    (o + o)");
            }

            static void BugBody()
            {
                Console.WriteLine("  --|  |  |--");
                Console.WriteLine("  --|  |  |--");
                Console.WriteLine("  --|  |  |--");
            }

            static void BugFeet()
            {
                Console.WriteLine("     v   v");
                Console.WriteLine("     *****");
            }

            static void MonsterHead()
            {
                Console.WriteLine("     _____");
                Console.WriteLine(" .-,;='';_),-.");
                Console.WriteLine("  \\_\\(),()/_/");
                Console.WriteLine("　  (,___,)");
            }

            static void MonsterBody()
            {
                Console.WriteLine("   ,-/`~`\\-,___");
                Console.WriteLine("  / /).:.('--._)");
                Console.WriteLine(" {_[ (_,_)");
            }

            static void MonsterFeet()
            {
                Console.WriteLine("    |  Y  |");
                Console.WriteLine("   /   |   \\");
                Console.WriteLine("   \"\"\"\" \"\"\"\"");
            }
        }
    }


    

