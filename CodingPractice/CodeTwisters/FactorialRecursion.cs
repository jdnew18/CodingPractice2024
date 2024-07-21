namespace CodingPractice.CodeTwisters {
    // Calculate the factorial (n!) of a given integer using recursion.
    public static class FactorialRecursion {
        public static int Do(int factorial) {
            // Throw an exception if factorial requested in less than 0.
            if (factorial < 0) {
                throw new Exception("Factorial must be 0 or greater.");
            }

            return Calculate(factorial);
        }

        // Calculate the product of the factorial,
        // subtracting 1 from the factorial until the factorial is 1.
        private static int Calculate(int factorial) {
            return factorial > 1 ? factorial * Calculate(--factorial) : 1;
        }
    }
}