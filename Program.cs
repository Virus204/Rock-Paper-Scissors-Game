string player = "";
string computer = "";
string response = "";
bool PlayAgain = true;

string [] options = {"rock", "paper", "scissors"};
string [] UpperOptions = Array.ConvertAll(options, option => option.ToUpper());


while (PlayAgain)
{
    player = "";
    computer = "";

    int randomIndex = Random.Shared.Next(UpperOptions.Length);
    computer = UpperOptions[randomIndex];
    
    System.Console.WriteLine("Enter Rock, paper, Scissors : ");
    player = Console.ReadLine();
    player = player.ToUpper();

    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
    {    
        System.Console.WriteLine("Wrong Answer: " + player);
        System.Console.WriteLine("Enter Rock, paper, Scissors : ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }
    System.Console.WriteLine("Player : " + player);
    System.Console.WriteLine("Computer : " + computer);
  switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                System.Console.WriteLine("Draw");
            }
            else if (computer == "PAPER")
            {
                System.Console.WriteLine("Lose");
            }
            else if (computer == "SCISSORS")
            {
                System.Console.WriteLine("Win");
            }
            break;
        case "PAPER":
            if (computer == "ROCK")
            {
                System.Console.WriteLine("Win");
            }
            else if (computer == "PAPER")
            {
                System.Console.WriteLine("Draw");
            }
            else if (computer == "SCISSORS")
            {
                System.Console.WriteLine("Lose");
            }
            break;
        case "SCISSORS":
            if (computer == "ROCK")
            {
                System.Console.WriteLine("Lose");
            }
            else if (computer == "PAPER")
            {
                System.Console.WriteLine("Win");
            }
            else if (computer == "SCISSORS")
            {
                System.Console.WriteLine("Draw");
            }
            break;
    }  
    Console.Write("Would you like to play again (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();
    if (response == "Y")
    {
        PlayAgain = true;
    }
    else
    {
        PlayAgain = false;
    }

}
