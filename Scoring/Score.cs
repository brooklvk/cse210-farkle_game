
class Score {

    method ScoreDice {
        //take dice created by StartRound and go thru to find valid point combos 
        dice = Dice.CreateDice();

        // point system:
        //
        
        // return dice in display 
        //..... and score also 
    }

    method DisplayDice {
        //display dice set aside, and remaining to roll with (used by Program) 
    }

    method GetRollScore {
        //return available scores from above method and send to Roll Turn Game 
        
    }

}

// Polymorphism - used in Roll, Turn and Game which will all inherit from Score a method that will add the new score to the current score. 
// Also used by Score because it uses interface to inherit objects from both Dice and Player. 


// - combos only made within the Roll 
// - can count multiple combos within a Roll but no overlapping dice 
// - search for valid combos in order of most points first, set aside points dice 
// - goal is to reach 10,000 points 
// - have to get 500 in one turn to get on board (add in at end) 
// - (use one of 2 pics for scoring combos) 

