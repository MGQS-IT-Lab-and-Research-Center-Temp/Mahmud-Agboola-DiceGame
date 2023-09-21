

Console.WriteLine("==========Legacy Dice Game==========\nType 'Start' or 'S' to start game.");

string startGame = Console.ReadLine()!;


while (!(startGame.Equals("start",StringComparison.OrdinalIgnoreCase) || startGame.Equals("S", StringComparison.OrdinalIgnoreCase)))
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Enter 'Start' or 'S' to start the game properly");
    Console.ResetColor();
    Console.WriteLine("Type 'Start' or 'S' to start game: ");

    startGame = Console.ReadLine()!;
}
Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;
const int doublePoint = 2;
const int triplePoint = 6;
int totalPoint = originalScore;

if (diceOne == diceTwo && diceTwo == diceThree)
{
    totalPoint += triplePoint;

    Console.WriteLine($"Dice One: {diceOne} \nDice Two: {diceTwo} \nDice Three: {diceThree}.\nYou rolled a triple! You have a total of {totalPoint} Points");
}
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
        totalPoint += doublePoint;

Console.WriteLine($"Dice One: {diceOne} \nDice Two: {diceTwo} \nDice Three: {diceThree}.\nYou rolled a double! You have a total of {totalPoint} Points");
}
else 
{
    Console.WriteLine($"Dice One: {diceOne} \nDice Two: {diceTwo} \nDice Three: {diceThree}.\nYou rolled a double! You have a total of {totalPoint} Points");
}
if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine("Congratulations, You won a Baloon!");
}
if (totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine("Congratulations, You won a Book!");
}
if (totalPoint == 17)
{
    Console.WriteLine("Congratulations, You won a 5000mAH PowerBank!");
}
if (totalPoint >= 18 && totalPoint <= 20)
{
    Console.WriteLine("Congratulations, You won a SilverBird Ticket!");
}
if (totalPoint == 21)
{
    Console.WriteLine("Congratulations, You won a Samsung A24!");
}
if (totalPoint >= 22 && totalPoint <= 24)
{
    Console.WriteLine("Congratulations, You won All gifts!");
}
if (totalPoint <10)
{
    Console.WriteLine("Sorry keep trying for a better gift Award!");
}

Console.WriteLine("Thanks for Playing Our Game, Stay updated for better versions of the game and updates on new development by developer Agboola Mahmud.");