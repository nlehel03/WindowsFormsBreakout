using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using breakout;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace TestProject1
{
    [TestClass]
    public class GameModelTests
    {
        
        private Ball ball=new Ball();
        private Board board=new();
        private Jatek jatek=new();
        private GameModel gameModel = new GameModel();

        [TestInitialize]
        public void Setup()
        {
            gameModel = new GameModel(ball, board);
            var labda = new Ball(); 
            var deszka = new Board(); 
            gameModel = new GameModel(labda, deszka);
            
        }
        [TestMethod]
        public void TestInitialLives()
        {
            Assert.AreEqual(3, gameModel.lives);
        }

        [TestMethod]
        public void TestAddPoints()
        {
            gameModel.addPoints();
            Assert.AreEqual(1, gameModel.points);
        }

        [TestMethod]
        public void TestBallBounceHorizontal()
        {
            gameModel.Labda.X = 5;
            gameModel.ballBounceHorizontal();
            Assert.AreEqual(-5, gameModel.Labda.X);
        }

        [TestMethod]
        public void TestBallBounceVertical()
        {
            gameModel.Labda.Y= 5;
            gameModel.ballBounceVertical();
            Assert.AreEqual(-5, gameModel.Labda.Y);
        }

        [TestMethod]
        public void TestBallFall()
        {
            gameModel.lives = 3;
            gameModel.liveChanged += (sender, lives) =>{};
            gameModel.ballFall();
            Assert.AreEqual(2, gameModel.lives, "Az életek számának csökkennie kell, amikor a labda leesik.");
        }

        

    }
}