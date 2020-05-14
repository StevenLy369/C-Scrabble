using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.TestTools
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]

        public void Scrabble_GetPoints_Points()
        {
            Scrabbles newScrabble = new Scrabbles();
            int score = newScrabble.GetPoints("zzz");
            
            Assert.AreEqual(30,score);
        }
          [TestMethod]
        public void Scrabble_GetPoints_Points2()
        {
            Scrabbles newScrabble = new Scrabbles();
            int score = newScrabble.GetPoints("zzzf");
            
            Assert.AreEqual(34,score);
        }
        
    }
}