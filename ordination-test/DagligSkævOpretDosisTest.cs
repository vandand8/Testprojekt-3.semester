namespace ordination_test;

using shared.Model;

[TestClass]
public class DagligSkævOpretDosisTest
{

    [TestMethod]
    public void DagligSkævOprtDsisTst()
    {
        var dagligSkæv = new DagligSkæv(new DateTime(2023, 12, 4), new DateTime(2023, 12, 12), new Laegemiddel("TestMed1", 1, 2, 3, "mg"));
        var tid = new DateTime(2023, 12, 8);
        var antal = 2;

        dagligSkæv.opretDosis(tid, antal);

        Assert.IsTrue(dagligSkæv.doser.Any(d=>d.tid == tid && d.antal == antal));
    }
}
