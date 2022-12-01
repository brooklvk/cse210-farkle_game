using System;
 
namespace farkleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            StartRound(); // Round. runs CreateDice from Dice 
            ScoreDice(); //Score. takes dice from CreateDice from Dice and calc score 
            DisplayDice(); //Score. 

            //get conf from user to set those aside.... OR have user calc score from dice and validate?? 

            //confirm Roll score and add to Turn and add to Game 

            // view remaining dice and choose to roll again 

            //test EndGame() 
            
            //if roll again, start new Roll (not round!) 

            

            EndGame(); // Round. this sees whether the game is ended and if it isn't, nothing, but if it is, ends game 
        }
    }
 
}


// - start Round by rolling 6 dice 
// - determine Roll score by finding valid combos (worth most points) 
// - choose to set them aside 
// - add that Roll score to Turn score 
// - view remaining dice 
// - choose whether to roll again 
// - when (1) chooses not to roll: Round is over, add Turn score to Game score 
// - when (2) no valid combos: Round is over, Turn score = 0 
// - when (3) Game score >= 10,000: 
// - (add code here if competing with another Player) 
// - start new Turn 


// make Turn(score) and Round(run) same class? 

