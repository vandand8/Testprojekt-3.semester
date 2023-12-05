using shared.Model;

namespace UnitTestModel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DagligFastDøgnDosisBeregner()
        {
        // The 3 As:
            //Arrange
            var laegemiddel = new Laegemiddel("Testmed", 1, 2, 3, "mg");
            var dagligFast = new DagligFast(DateTime.Today, DateTime.Today.AddDays(1), laegemiddel, 1, 2, 3, 4);

            //Act
            var result = dagligFast.doegnDosis();

            //Assert
            Assert.AreEqual(10, result);
        }
    }
}