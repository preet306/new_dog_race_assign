using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_dog_race_assign
{
   public class Ground
    {

        Random rd = new Random();

        //this code is used to return the finish line point 
        public int finishPoint() {
            return 700; 
        }

        //this code is used to return the step to the dog 
        public int movePoint()
        {
            return rd.Next(1,60);
        }


    }
}
