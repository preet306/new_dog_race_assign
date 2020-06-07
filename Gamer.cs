using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_dog_race_assign
{
    //here we inherit the class of the ground to perform the all task in the main method by the reference of single one class
    public class Gamer:Ground
    {
        public int resetBudget(int winner,int bet,int dog,int cash) {
            //if the player loss the game 
            if (winner != dog)
            {
                return cash -= bet;
            }
            else {
                //if the player win  the game 
                return cash += bet;
            }
        }
    }
}
