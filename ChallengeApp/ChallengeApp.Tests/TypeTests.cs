
namespace ChallengeApp.Tests
{
    internal class TypeTests
    {
        [Test]
        public void FloatSholdReturnEqual()
        {
            //arrange
            float weight1 = 8;
            float weight2 = 8;


            //assert
            Assert.AreEqual(weight1, weight2);
        }


        [Test]
        public void IntigerSholdReturnDifferent()
        {
            //arrange
            int number1 = 20;
            int number2 = 30;

            //assert
            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void ClassStringSholdReturnEqual()
        {
            //arrange
            string number1 = "Adam";
            string number2 = "Adam";

            //assert
            Assert.AreEqual(number1, number2);
        }

       
    }
}
