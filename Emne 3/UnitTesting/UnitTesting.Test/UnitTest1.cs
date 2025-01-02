namespace UnitTesting.Test;

public class StatsTest
{
    [Test]
    public void TestWith3And4()
    {
        // arrange
        var stats = new Stats();
        
        //act
        stats.Add(3);
        stats.Add(4);
        
        // assert
        Assert.AreEqual(2, stats.Count);
        Assert.AreEqual(7, stats.Sum);
        Assert.AreEqual(4, stats.Max);
        Assert.AreEqual(3, stats.Min);
        Assert.AreEqual(3.5, stats.Mean, 0.0001);
    }

    [Test]
    public void TestEmptyStats()
    {
        var stats = new Stats();
        
        Assert.AreEqual(0, stats.Count);
        Assert.AreEqual(0, stats.Sum);
        Assert.IsNull(stats.Max);
        Assert.IsNull(stats.Min);
        Assert.AreEqual(float.NaN, stats.Mean);
    }
}