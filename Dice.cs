// Dice (3 methods) will create the dice (create 6 new objects with a random value 1-6) (used by Score); have a method to display the dice 
// to the user (used by Program); then reset.

class Dice {

    //private - used by Round 
    method CreateDice() {
        Random random = new Random();
        // create 6 random ints 1-6 and return in list 
        return dice;
    }

    // method DisplayDice is in Score class 

    method ResetDice() {
        //use in program? 
    }

}

// Encapsulation - used in Dice class to keep other classes from accessing the new dice Dice objects (except Score). 

// Inheritance - used by Score class when it inherits the dice created by Dice and uses it to score the dice. 

// Poly- Also used by Score because it uses interface to inherit objects from both Dice and Player. 
