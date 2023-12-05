namespace ordination_test;

using shared.Model;

[TestClass]
public class OrdinationAntalDageTest
{

    [TestMethod]

    public void OrdinationAntlDgeTest()
    {
        var ordination = new DagligFast(new DateTime(2023, 12, 12), new DateTime(2023, 12, 24), new Laegemiddel("TestMed2", 1, 2, 4, "mg"), 1, 2, 3, 4);

        var forventetAntalDage = 12;

        var faktiskAntalDage = ordination.antalDage();

        Assert.AreEqual(forventetAntalDage, faktiskAntalDage);
    }
}
