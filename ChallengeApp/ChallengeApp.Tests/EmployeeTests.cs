namespace ChallengeApp.Tests
{
    internal class EmployeeTests
    {
        [Test]
        public void StatisticsMin()
        {
            var employee1 = new Employee("Krysia", "Kowalska");

            employee1.AddGrade(2);
            employee1.AddGrade(5);
            employee1.AddGrade(6);
            employee1.AddGrade(9);

            var statistics = employee1.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void StatisticsMax()
        {
            var employee2 = new Employee("Marysia", "Janicka");

            employee2.AddGrade(2);
            employee2.AddGrade(1);
            employee2.AddGrade(1);
            employee2.AddGrade(8);

            var statistics = employee2.GetStatistics();

            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void StatisticsAvarage()
        {
            var employee3 = new Employee("Monika", "Gołąbek");

            employee3.AddGrade(6);
            employee3.AddGrade(9);
            employee3.AddGrade(8);
            employee3.AddGrade(9);

            var statistics = employee3.GetStatistics();

            Assert.AreEqual(8, statistics.Avarage);
        }


    }
}
