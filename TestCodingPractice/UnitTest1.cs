namespace TestCodingPractice;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestClockAngle()
    {
        // Typical cases.
        int testParameterHour = 12;
        int testParameterMinute = 15;
        int expectedResult = 90;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 1;
        testParameterMinute = 15;
        expectedResult = 60;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 1;
        testParameterMinute = 55;
        expectedResult = 60;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));

        testParameterHour = 10;
        testParameterMinute = 40;
        expectedResult = 60;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 1;
        testParameterMinute = 5;
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 1;
        testParameterMinute = 1;
        expectedResult = 24;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 12;
        testParameterMinute = 0;
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 12;
        testParameterMinute = 30;
        expectedResult = 180;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 6;
        testParameterMinute = 0;
        expectedResult = 180;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 6;
        testParameterMinute = 30;
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
        
        testParameterHour = 12;
        testParameterMinute = 29;
        expectedResult = 174;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
    
        testParameterHour = 12;
        testParameterMinute = 31;
        expectedResult = 174;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, testParameterMinute)));
    
        // Edge Cases.
        testParameterHour = 0;
        Assert.Throws<Exception>(() => CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, 1));

        testParameterHour = 13;
        Assert.Throws<Exception>(() => CodingPractice.CodeTwisters.ClockAngle.Calculate(testParameterHour, 1));

        testParameterMinute = -1;
        Assert.Throws<Exception>(() => CodingPractice.CodeTwisters.ClockAngle.Calculate(1, testParameterMinute));

        testParameterMinute = 60;
        Assert.Throws<Exception>(() => CodingPractice.CodeTwisters.ClockAngle.Calculate(1, testParameterMinute));
    }

    [Test]
    public void TestClosestToZero()
    {
        // Typical cases.
        double[] testParameter = [3.7, 2.1, 8.9, 400.7, 0.1, 2, 0.000001, 28392837, 82.0];
        double expectedResult = 0.000001;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClosestToZero.Find(testParameter)));
        
        testParameter = [1, 0, 0.000001];
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClosestToZero.Find(testParameter)));

        // Edge cases.
        testParameter = [1];
        expectedResult = 1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClosestToZero.Find(testParameter)));
        
        testParameter = [0];
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClosestToZero.Find(testParameter)));
        
        testParameter = [1, 1, 1, 1];
        expectedResult = 1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClosestToZero.Find(testParameter)));
        
        testParameter = [1, 2, 1, 3];
        expectedResult = 1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClosestToZero.Find(testParameter)));
        
        testParameter = [];
        expectedResult = 0;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ClosestToZero.Find(testParameter)));
    }

    [Test]
    public void TestFactorialRecursion()
    {
        // Typical cases.
        int testParameter = 4;
        int expectedResult = 4 * 3 * 2;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.FactorialRecursion.Do(testParameter)));

        // Edge cases.
        testParameter = 10;
        expectedResult = 10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.FactorialRecursion.Do(testParameter)));

        // Edge cases.
        testParameter = 1;
        expectedResult = 1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.FactorialRecursion.Do(testParameter)));

        testParameter = 0;
        expectedResult = 1;
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.FactorialRecursion.Do(testParameter)));

        testParameter = -1;
        Assert.Throws<Exception>(() => CodingPractice.CodeTwisters.FactorialRecursion.Do(testParameter));
    }

    [Test]
    public void TestReverseArrayIntArray()
    {
        // Typical cases.
        int[] testParameter = [1, 2, 3];
        int[] expectedResult = [3, 2, 1];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int>.Do(testParameter)));

        testParameter = [-1, -2, -3];
        expectedResult = [-3, -2, -1];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int>.Do(testParameter)));

        testParameter = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
        expectedResult = [0, 9, 8, 7, 6, 5, 4, 3, 2, 1];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int>.Do(testParameter)));

        testParameter = [1, 1, 1];
        expectedResult = [1, 1, 1];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int>.Do(testParameter)));

        // Edge cases.
        testParameter = [1];
        expectedResult = [1];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int>.Do(testParameter)));

        testParameter = [];
        expectedResult = [];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int>.Do(testParameter)));

        Assert.That(CodingPractice.CodeTwisters.ReverseArray<int>.Do(null), Is.Null);
    }

    [Test]
    public void TestReverseArrayCharArray()
    {
        // Typical cases.
        char[] testParameter = ['a', 'b', 'c'];
        char[] expectedResult = ['c', 'b', 'a'];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<char>.Do(testParameter)));

        testParameter = ['A', 'B', 'C'];
        expectedResult = ['C', 'B', 'A'];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<char>.Do(testParameter)));

        testParameter = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'];
        expectedResult = ['j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a'];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<char>.Do(testParameter)));

        testParameter = ['1', '1', '1'];
        expectedResult = ['1', '1', '1'];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<char>.Do(testParameter)));

        // Edge cases.
        testParameter = ['a'];
        expectedResult = ['a'];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<char>.Do(testParameter)));

        testParameter = [];
        expectedResult = [];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<char>.Do(testParameter)));

        Assert.That(CodingPractice.CodeTwisters.ReverseArray<char>.Do(null), Is.Null);
    }

    [Test]
    public void TestReverseArrayIntArrayMultiDimensional()
    {
        // Typical cases.
        int[][] testParameter = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
        int[][] expectedResult = [[7, 8, 9], [4, 5, 6], [1, 2, 3]];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int[]>.Do(testParameter)));

        // Edge cases.
        testParameter = [[1]];
        expectedResult = [[1]];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int[]>.Do(testParameter)));

        testParameter = [];
        expectedResult = [];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int[]>.Do(testParameter)));

        testParameter = [[], []];
        expectedResult = [[] ,[]];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int[]>.Do(testParameter)));

        testParameter = [[], [1]];
        expectedResult = [[1], []];
        Assert.That(expectedResult, Is.EqualTo(CodingPractice.CodeTwisters.ReverseArray<int[]>.Do(testParameter)));

        Assert.That(CodingPractice.CodeTwisters.ReverseArray<int[]>.Do(null), Is.Null);
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