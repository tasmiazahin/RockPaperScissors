namespace RockPaperScissors;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to my game Rock,paper,Scissors");

        int userRockCounts = 0;
        int userPaperCounts = 0;
        int userScissorCounts = 0;
        int ComputerRockCounts = 0;
        int ComputerPaperCounts = 0;
        int ComputerScissorCounts = 0;

        bool isNewRound = true;
        while (isNewRound)
        {
            
            Console.WriteLine("1.New round");
            Console.WriteLine("2.Exit & show statistics");

            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                int userPoints = 0;
                int computerPoints = 0;
                bool isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("Please choose a number below and press enter");
                    Console.WriteLine("1.Rock");
                    Console.WriteLine("2.Paper");
                    Console.WriteLine("3.Scissors");
                    int userChoice = Convert.ToInt32(Console.ReadLine());

                    Random random = new Random();
                    int computerChoice = random.Next(1, 4);

                    if (computerChoice == 1)
                    {
                        ComputerRockCounts++;
                        Console.WriteLine("Computer chose Rock");
                        if (userChoice == 1)
                        {
                            userRockCounts++;
                            Console.WriteLine("It is a draw ");
                        }
                        else if (userChoice == 2)
                        {
                            userPaperCounts++;
                            Console.WriteLine("You Won ");
                            userPoints++;

                        }
                        else if (userChoice == 3)
                        {
                            userScissorCounts++;
                            Console.WriteLine("Computer Won");
                            computerPoints++;
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock,paper or scissors!");
                        }

                    }
                    if (computerChoice == 2)
                    {
                        ComputerPaperCounts++;
                        Console.WriteLine("Computer chose Paper");
                        if (userChoice == 1)
                        {
                            userRockCounts++;
                            Console.WriteLine("Computer Won ");
                            computerPoints++;
                        }
                        else if (userChoice == 2)
                        {
                            userPaperCounts++;
                            Console.WriteLine("It is a draw");

                        }
                        else if (userChoice == 3)
                        {
                            userScissorCounts++;
                            Console.WriteLine("You Won");
                            userPoints++;
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock,paper or scissors!");
                        }

                    }
                    if (computerChoice == 3)
                    {
                        ComputerScissorCounts++;
                        Console.WriteLine("Computer chose Scissors");
                        if (userChoice == 1)
                        {
                            userRockCounts++;
                            Console.WriteLine("You Won ");
                            userPoints++;
                        }
                        else if (userChoice == 2)
                        {
                            userPaperCounts++;
                            Console.WriteLine("Computer won ");
                            computerPoints++;

                        }
                        else if (userChoice == 3)
                        {
                            userScissorCounts++;
                            Console.WriteLine("It is a draw");
                        }
                        else
                        {
                            Console.WriteLine("You must choose rock,paper or scissors!");
                        }

                    }

                    Console.WriteLine("Your points = " + userPoints);
                    Console.WriteLine("Computer points = " + computerPoints);

                    if (userPoints == 5 || computerPoints == 5)
                    {
                        if (userPoints == 5)
                        {
                            Console.WriteLine("You won the game");
                        }
                        else if (computerPoints == 5)
                        {
                            Console.WriteLine("You have lost the game to Computer");
                        }
                        isRunning = false;

                        Console.WriteLine("Do you want to play again?");
                    }
                }

            }
            else if (userInput == 2)
            {
                Console.WriteLine("Computer stats");
                Console.WriteLine("----------------");
                Console.WriteLine($"Rock: {ComputerRockCounts}");
                Console.WriteLine($"Paper: {ComputerPaperCounts}");
                Console.WriteLine($"Scissor: {ComputerScissorCounts}");
                Console.WriteLine("----------------");
                Console.WriteLine("Your stats");
                Console.WriteLine("----------------");
                Console.WriteLine($"Rock: {userRockCounts}");
                Console.WriteLine($"Paper: {userPaperCounts}");
                Console.WriteLine($"Scissor: {userScissorCounts}");
                Console.WriteLine("Game exited!!!");
                isNewRound = false;   

            }
        }

        
    }
}
