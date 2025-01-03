namespace Calculator.Test;

public class Tests
{
    [Test]
    public void TestLeggSammen()
    {
        var calc = new Calc.Calculator();
        var sum = calc.LeggSammen(1, 2);
        Assert.That(sum, Is.EqualTo(3));
        
    }
    [Test]
    public void TestLeggSammenNetgativ() 
    { 
        var calc = new Calc.Calculator();
        var sum = calc.LeggSammen(-1, 2); 
        Assert.That(sum, Is.EqualTo(1));
    }

    [Test]
    public void TestTrekkFra()
    {
        var calc = new Calc.Calculator();
        var sum = calc.TrekkFra(2, 1);
        Assert.That(sum, Is.EqualTo(1));
    }
    [Test]
    public void TestTrekkFraNetgativ()
    {
        var calc = new Calc.Calculator();
        var sum = calc.TrekkFra(1, -2);
        Assert.That(sum, Is.EqualTo(3));
    }
    [Test]
    public void TestMultipliser()
    {
        var calc = new Calc.Calculator();
        var sum = calc.Multipliser(2, 2);
        Assert.That(sum, Is.EqualTo(4));
    }
    [Test]
    public void TestMultipliserNegativ()
    {
        var calc = new Calc.Calculator();
        var sum = calc.Multipliser(3, -3);
        Assert.That(sum, Is.EqualTo(-9));
    }

    [Test]
    public void TestDivision()
    {
        var calc = new Calc.Calculator();
        var sum = calc.Divider(4, 2);
        Assert.That(sum, Is.EqualTo(2));
    }
    [Test]
    public void TestDivisionNegative()
    {
        var calc = new Calc.Calculator();
        var sum = calc.Divider(4, -2);
        Assert.That(sum, Is.EqualTo(-2));
    }
    [Test]
    public void TestDivisionByZero()
    {
        var calc = new Calc.Calculator();
        Assert.Throws<ArgumentException>(() => calc.Divider(4, 0));
    }
}