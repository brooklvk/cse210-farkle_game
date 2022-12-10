
class Game : Score{

    public static object rollAgain() {
       
        Console.WriteLine("Roll again? y/n");
        string newRoll = Console.ReadLine();

        int gameScore = getGameScore();
        if (newRoll == "y") {
            scoreDice();
            calcGameScore();
        } else if (newRoll == "n") {
            Console.WriteLine($"Game over, you ended with {gameScore} points.");
        }
        }

    public static object isGameOver() {
            int gameScore = getGameScore();
            if (gameScore >= 10000) {
                Console.WriteLine("Game over, you win! 10,000 points!");
            }
        }

}