namespace CodingPractice.CodeTwisters {
    // Calculate the factorial (n!) of a given integer using recursion.
    public static class FactorialRecursion {
        public static int Calculate(int factorial) {
            // Throw an exception if factorial requested in less than 0.
            if (factorial < 0) {
                throw new Exception("Factorial must be 0 or greater.");
            }

            return Calculate(factorial, 1);
        }

        // Calculate product of the factorial, subtracting 1 from the requested factorial
        // until the requested factorial is 0.
        private static int Calculate(int factorial, int product) {
            product *= factorial;
            return --factorial > 0 ? Calculate(factorial, product) : product; 
        }
    }
}