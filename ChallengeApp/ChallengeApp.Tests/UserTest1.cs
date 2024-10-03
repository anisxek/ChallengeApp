

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void CheckEmployeeResults()
        {
            //arrange
            var employee = new Employee("Dominika", "Kowalska", 31, 0);
            employee.AddScore(-5);
            employee.AddScore(6);
            employee.AddScore(1);
            employee.AddScore(1);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(3, result);


        }
        [Test]
        public void CheckEmployeeResults2()
        {
            //arrange
            var employee = new Employee("Monika", "M³ynarska", 24, 0);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(-6);
            employee.AddScore(-9);

            //act
            var result = employee.Result;
             
            //assert
            Assert.AreEqual(-3, result);


        }
        [Test]
        public void CheckEmployeeResults3()
        {
            //arrange
            var employee = new Employee("Zuzia", "S³owik", 42, 0);
            employee.AddScore(9);
            employee.AddScore(3);
            employee.AddScore(-7);
            employee.AddScore(-2);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(3, result);
        }
    }
}