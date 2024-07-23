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
        // Typical cases.
        int testParameter = 123;
        int expectedResult = 1 + 2 + 3;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));
        
        testParameter = 4567890;
        expectedResult = 4 + 5 + 6 + 7 + 8 + 9 + 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));

        testParameter = -123;
        expectedResult = -1 - 2 - 3;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));
        
        testParameter = -4567890;
        expectedResult = -4 - 5 - 6 - 0 - 7 - 8 - 9 - 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));

        // Edge cases.
        testParameter = 0;
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));

        testParameter = 1;
        expectedResult = 1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));

        testParameter = -1;
        expectedResult = -1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.SumDigits.Calculate(testParameter)));
    }
}