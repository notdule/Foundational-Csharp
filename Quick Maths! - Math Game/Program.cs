Console.WriteLine("Welcome To Quick Maths!");
Console.WriteLine("Today you'll play an interesting game");
Console.WriteLine("Are you ready?");
string? playerReady = Console.ReadLine();
string? playerInput = Console.ReadLine();
string? questionAnswer = Console.ReadLine();
string gameBegins = "Choose a Number (beetween 1 and 2 duhh)";
int correctGuessesCount = 0;
int wrongGuessesCount = 0;

// Add random Categories Like (Numbers To 100, Numbers To 1000, Specific Operation Like just Multiplying etc. Begginer, Intermediate, Expert)
Random rb = new Random();
int randomNumbers100 = rb.Next(1, 101);
int firstRandom100Number = rb.Next(1, 101);
int secondRandomNumber = rb.Next(1, 12);
Random random = new Random();
int randomNumbers1000 = random.Next(1, 1001);
int result = 0;

if (playerReady != null)
{
    if (playerReady.ToLower() == "yes")
    {
        Console.WriteLine("AWESOME! Let's Begin");
    }
    else if (playerReady.ToLower() == "no")
    {
        Console.WriteLine("Are You Sure You Don't Wanna Play This Greatest Game in The Whole Universe?");
        playerReady = Console.ReadLine();
        if (playerReady != null)
        {
            if (playerReady.ToLower() == "yes")
            {
                Console.WriteLine("oh......ARE YOU SURE!? *points gun at you*");
                playerReady = Console.ReadLine();
                if (playerReady != null)
                {
                    if (playerReady.ToLower() == "yes")
                    {
                        Console.WriteLine("You'll play anyway lol");
                    }

                }
            }
        }
    }
}

Console.WriteLine(gameBegins);
playerInput = Console.ReadLine();
if (playerInput == "1")
{

    Console.WriteLine($"{firstRandom100Number} + {secondRandomNumber} = ");
    result = firstRandom100Number + secondRandomNumber;
    questionAnswer = Console.ReadLine();
    if (questionAnswer == result.ToString())
    {
        Console.WriteLine("Wow, I'm impressed..i bet you know to count to 1000...");
    }
}
else if (playerInput == "2")
{
    Console.WriteLine($"{randomNumbers1000} + {randomNumbers100}");
    result = randomNumbers1000 + randomNumbers100;
    Console.ReadLine();
    questionAnswer = Console.ReadLine();
    if (questionAnswer == result.ToString())
    {
        Console.WriteLine("Wow, I'm impressed..i bet you know to count to 1000...");
        correctGuessesCount += 1;
        Console.WriteLine(correctGuessesCount);
    }
    else 
    {
        wrongGuessesCount++;
    }
    Console.WriteLine(correctGuessesCount);
}

Console.WriteLine("Level 2!");
DisplayQuestion(randomNumbers100, secondRandomNumber);


 void DisplayQuestion (int firstNumber, int secondNumber)
{
 
    Console.WriteLine($"{firstNumber} + {secondNumber} = ");
    Console.ReadLine();
    string? finalResult = Console.ReadLine();
}
