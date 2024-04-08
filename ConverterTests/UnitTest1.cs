using Converter;

namespace ConverterTests;

[TestFixture]
public class Tests
{
    private IConverter? _converter;

    [SetUp]
    public void Setup()
    {
        _converter = new Converter.Converter();
    }

    [Test]
    public void Test0()
    {
        Assert.That(_converter!.ConvertFeetInMeters(0.0), Is.EqualTo(0.0));
    }

    [TestCase(1.0)]
    public void Test1(double d)
    {
        Assert.That(_converter!.ConvertFeetInMeters(_converter.ConvertMetersInFeet(d)),
            Is.EqualTo(d).Within(1.0e-10));
    }
}
