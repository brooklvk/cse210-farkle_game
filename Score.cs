
class Score : Dice{

    public static object scoreDice() {

            List dice = createDice();

            Console.WriteLine("Here are the dice");
            Console.WriteLine(dice[0], dice[1], dice[2], dice[3], dice[4], dice[5]);

            dice = dice.OrderByDescending(_p_1 => _p_1).ToList();

            string youRolled = "";
            bool isAScore = false;

            if (dice[0] == dice[1] == dice[2] == dice[3] || dice[1] == dice[2] == dice[3] == dice[4] || dice[2] == dice[3] == dice[4] == dice[5]) {
                //4 same is 1000 
                int rollScore = 1000;
                youRolled = "4 of the same";
                isAScore = true;
            } else if (dice[0] == dice[1] == dice[2] == dice[3] == dice[4] || dice[1] == dice[2] == dice[3] == dice[4] == dice[5]) {
                //5 same is 2000
                rollScore = 2000;
                youRolled = "5 of the same";
                isAScore = true;
            } else if (dice[0] == dice[1] == dice[2] == dice[3] == dice[4] == dice[5]) {
                //6 same is 3000
                rollScore = 3000;
                youRolled = "6 of the same";
                isAScore = true;
            } else if (dice[0] == 6 && dice[1] == 5 && dice[2] == 4 && dice[3] == 3 && dice[4] == 2 && dice[5] == 1) {
                //a straight 1-6 is 1500 
                rollScore = 1500;
                youRolled = "Straight 1-6";
                isAScore = true;
            } else if (dice[0] == dice[1] && dice[2] == dice[3] && dice[4] == dice[5]) {
                //three pairs is 1500
                rollScore = 1500;
                youRolled = "Three pairs";
                isAScore = true;
            } else if (dice[0] == dice[1] == dice[2] && dice[3] == dice[4] == dice[5]) {
                //two triplets is 2500 
                rollScore = 2500;
                youRolled = "Two triplets";
                isAScore = true;
            } else if (dice[0] == 6 && dice[1] == 6 && dice[2] == 6 || dice[1] == 6 && dice[2] == 6 && dice[3] == 6 || dice[2] == 6 && dice[3] == 6 && dice[4] == 6 || dice[3] == 6 && dice[4] == 6 && dice[5] == 6) {
                //3 6s is 600 
                rollScore = 600;
                youRolled = "3 6s";
                isAScore = true;
            } else if (dice[0] == 5 && dice[1] == 5 && dice[2] == 5 || dice[1] == 5 && dice[2] == 5 && dice[3] == 5 || dice[2] == 5 && dice[3] == 5 && dice[4] == 5 || dice[3] == 5 && dice[4] == 5 && dice[5] == 5) {
                //3 5s is 500 
                rollScore = 500;
                youRolled = "3 5s";
                isAScore = true;
            } else if (dice[0] == 4 && dice[1] == 4 && dice[2] == 4 || dice[1] == 4 && dice[2] == 4 && dice[3] == 4 || dice[2] == 4 && dice[3] == 4 && dice[4] == 4 || dice[3] == 4 && dice[4] == 4 && dice[5] == 4) {
                //3 4s is 400 
                rollScore = 400;
                youRolled = "3 4s";
                isAScore = true;
            } else if (dice[0] == 3 && dice[1] == 3 && dice[2] == 3 || dice[1] == 3 && dice[2] == 3 && dice[3] == 3 || dice[2] == 3 && dice[3] == 3 && dice[4] == 3 || dice[3] == 3 && dice[4] == 3 && dice[5] == 3) {
                //3 3s is 300 
                rollScore = 300;
                youRolled = "3 3s";
                isAScore = true;
            } else if (dice[0] == 1 && dice[1] == 1 && dice[2] == 1 || dice[1] == 1 && dice[2] == 1 && dice[3] == 1 || dice[2] == 1 && dice[3] == 1 && dice[4] == 1 || dice[3] == 1 && dice[4] == 1 && dice[5] == 1) {
                //3 1s is 300
                rollScore = 300;
                youRolled = "3 1s";
                isAScore = true;
            } else if (dice[0] == 2 && dice[1] == 2 && dice[2] == 2 || dice[1] == 2 && dice[2] == 2 && dice[3] == 2 || dice[2] == 2 && dice[3] == 2 && dice[4] == 2 || dice[3] == 2 && dice[4] == 2 && dice[5] == 2) {
                //3 2s is 200
                rollScore = 200;
                youRolled = "3 2s";
                isAScore = true;
            } else {
                // score is 0 
                rollScore = 0;
                youRolled = "None";
                isAScore = false;
            }
            Console.WriteLine($"You have a score: {isAScore}");
            Console.WriteLine($"Score: {rollScore}");
            Console.WriteLine($"You rolled: {youRolled}");
            return rollScore;
        }



    public static object calcGameScore() {
            int gameScore = new List<object>();
            int rollScore = scoreDice();
            gameScore = gameScore.insert(rollScore);
            Console.WriteLine($"Your total score is: {gameScore}");
            return gameScore;
        }

    public static object getGameScore() {
        return (calcGameScore());
    }
}