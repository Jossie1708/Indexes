using indexes;

namespace TestingIndexes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStudentID()
        {
            Students st = new Students("st0111@gmail.come", "ST0111", "BCAD", "Reece", "Smith");
            Assert.AreEqual(st[0], "ST0111");
        }
        [TestMethod]
        public void TestUpdateName()
        {
            Students st = new Students("st0111@gmail.come", "ST0111", "BCAD", "Reece", "Smith");
            Assert.AreEqual(st[2], "Reece");
        }

        [TestMethod]
        public void TestUpdateSurname()
        {
            Students st = new Students("st0111@gmail.come", "ST0111", "BCAD", "Reece", "Smith");
            Assert.AreEqual(st[3], "Smith");
        }

        [TestMethod]
        public void TestUpdateDegree()
        {
            Students st = new Students("st0111@gmail.come", "ST0111", "BCAD", "Reece", "Smith");
            Assert.AreEqual(st[1], "BCAD");
        }
        [TestMethod]
        public void TestUpdateSalary()
        {
            Students st = new Students("st0111@gmail.come", "ST0111", "BCAD", "Reece", "Smith");
            Assert.AreEqual(st[4], "st0111@gmail.come");
        }
    }
}