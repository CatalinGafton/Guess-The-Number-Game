using System;

namespace GuessTheNumberGame
{
    class Program
    {
        public static void Main()
        {
            Random no1 = new Random();
            int numberToGuess = no1.Next(1, 100);

            string number = "";
            int _case;
            int Count = 0;
            string tabs = new String('-', 41);
            Console.WriteLine("\n" + tabs + "\nGuess The Number \n\nPlease enter a number between 1 and 100\n" + tabs + "\n");
            Console.Write("\nYour number is:                  ");

            try
            {
                number = Console.ReadLine();
                do
                {
                    if (!int.TryParse(number, out int Z))
                    {
                        _case = 1;
                    }

                    else if (int.Parse(number) < numberToGuess)
                    {
                        _case = 2;
                    }

                    else
                    {
                        _case = 3;
                    }

                    switch (_case)
                    {
                        case 1:
                            Console.Write("(this is not a number)\n\nPlease enter a number:           ");
                            number = Console.ReadLine();
                            Count++;
                            continue;
                        case 2:
                            Console.Write("(entered number is too small)\n\nPlease try again:                ");
                            number = Console.ReadLine();
                            Count++;
                            break;
                        case 3:
                            Console.Write("(entered number is too big)\n\nPlease try again:                ");
                            number = Console.ReadLine();
                            Count++;
                            break;
                    }

                } while ((number) != Convert.ToString(numberToGuess));

                Console.WriteLine("\n" + tabs + "\nYou are right\nThat's the number   -->          " + number + "\nWhell Done !i \n" + tabs + "\n");
                Console.WriteLine("Number of tries     -->          " + ++Count);
                Console.WriteLine("\npowered by Catalin Gafton");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a number");
                number = Console.ReadLine();
            }
        }
    }
}
