namespace ordination_test;

using shared.Model;

[TestClass]
public class DagligFastSamletDosisTest
{

    [TestMethod]
    public void DagligFastSmletDsisTst()
    {
        var laegemiddel = new Laegemiddel("Testmed", 1, 2, 3, "mg");
        var startdato = new DateTime(2023, 1, 1);
        var slutdato = new DateTime(2023, 1, 8);

        var dagligFast = new DagligFast(startdato, slutdato, laegemiddel, 1, 2, 3, 4);
        var forventetSmletDosis = 7 * (1 + 2 + 3 + 4);

        var faktiskSmletDosis = dagligFast.samletDosis();

        Assert.AreEqual(forventetSmletDosis, faktiskSmletDosis);
    }
}