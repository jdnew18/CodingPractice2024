public static class SumDigits {
    // Calculate sum of an integer's digits.
    public int Calculate(int value) {
        int sum = 0;

        // While value is greater than 0, get right-most digit via value % 10
        // and add it to sum.
        // Then divide value by 10 to move left to next digit.
        while (value > 0) {
            sum += value % 10;
            value /= 10;
        }
        
        return sum;
    }
}