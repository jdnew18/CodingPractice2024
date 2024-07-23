namespace TestCodingPractice;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestSumDigits()
    {
        int testParameter = 123;
        int expectedResult = 1 + 2 + 3;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));

        testParameter = 0;
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));

        testParameter = 1;
        expectedResult = 1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));

        testParameter = -1;
        expectedResult = -1;
        Assert.Throws<Exception>(() => CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter));
    }
}