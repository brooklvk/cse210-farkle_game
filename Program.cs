namespace Namespace {
    
    using static Random;
    
    using System.Collections.Generic;
    
    public static class Program {
        
        public static object Main() {
            Score.scoreDice();
            Score.calcGameScore();
            Game.rollAgain();
            Game.isGameOver();
        }
        
         
        static Program() {
            Main();
        }
    }
}
