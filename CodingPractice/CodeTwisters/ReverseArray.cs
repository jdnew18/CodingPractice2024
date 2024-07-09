namespace CodingPractice.CodeTwisters {
    // Reverse any array.
    public static class ReverseArray<T> {
        public static T[]? Do(T[]? value) {
            // Return if array is null or empty.
            if (value == null || value.Length == 0) {
                return value;
            }

            // Get index of last index in array.
            int lastIndex = value.Length - 1;
            T temp = value[0];

            // Starting from the rightmost index,
            // switch rightmost index with the leftmost index.
            // Then, move to next rightmost and next leftmost indices
            // until halfway through array,
            // at which point the entire array has been reversed.
            for (int i = lastIndex; i >= value.Length / 2; i--) {
                temp = value[lastIndex - i];
                value[lastIndex - i] = value[i];
                value[i] = temp;
            }

            return value;
        }
    }
}