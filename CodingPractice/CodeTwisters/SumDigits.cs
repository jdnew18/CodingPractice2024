namespace CodingPractice.CodeTwisters {
    public static class SumDigits {
        // Calculate sum of an integer digits.
        public static int Calculate(int value) {
            int sum = 0;

            // Calculate sum of an integer's digits by
            // getting each right-most digit via integer % 10
            // and adding it to the sum.
            // Then divide integer by 10 to move left to the next digit.
            while (value != 0) {
                sum += value % 10;
                value /= 10;
            }
            
            return sum;
        }
    }
}