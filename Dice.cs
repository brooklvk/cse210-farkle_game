
class Dice {

    public static object createDice() {
        Random rnd = new Random();
        int die1  = rnd.Next(1, 6);
        int die2  = rnd.Next(1, 6);
        int die3  = rnd.Next(1, 6);
        int die4  = rnd.Next(1, 6);
        int die5  = rnd.Next(1, 6);
        int die6  = rnd.Next(1, 6);

        List dice = new List<int> {
        die1, die2, die3, die4, die5, die6};

        return dice;
        }


}
