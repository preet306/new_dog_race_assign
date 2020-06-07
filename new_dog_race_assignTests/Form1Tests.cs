using Microsoft.VisualStudio.TestTools.UnitTesting;
using new_dog_race_assign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_dog_race_assign.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Ground obj = new Ground();
            if (obj.finishPoint() == 700) {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);

            }
        }
        [TestMethod()]
        public void RandomTest()
        {
            Ground obj = new Ground();
            if (obj.movePoint()>0 && obj.movePoint()<50)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);

            }
        }


    }
}