
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

        [Test]
        public void GetEmployeeShouldRetunrnDifferent()
        {
            //arrange
            var employee1 = GetEmployee("Dominika", "Kowalska", 31, 0);
            var employee2 = GetEmployee("Monika", "Młynarska", 24, 0);

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string lastname, int age, int result)
        {
            return new Employee(name, lastname, age, result);
        }
    }
}
