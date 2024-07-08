namespace CodingPractice {
    public static class ClosestToZero
    {
        // Return number in array whose absolute value is closest to zero.
        public static double Find(double[] ts) {
            // If empty, return 0.
            if (ts == null || ts.Length == 0) {
                return 0;
            }

            double closest = ts.First();
            double absClosest = System.Math.Abs(closest);

            // Iterate through array to find number closest to 0.
            foreach (double currTemp in ts) {
                double absCurrTemp = System.Math.Abs(currTemp);

                // Compare, ensure positive number wins.
                if (absCurrTemp <= absClosest) {
                    // Positive current temperature wins.
                    if (currTemp >= 0) {
                        closest = currTemp;
                    }
                    // Negative current temperature only wins
                    // if its absolute value is less than closest's absolute value.
                    else if (absCurrTemp != absClosest) {
                        closest = currTemp;
                    }
                    
                   // Update.
                    absClosest = System.Math.Abs(closest);
                }
            }

            return closest;
        }

        static double GetAbsoluteValue(double temp) {
            return temp >= 0 ? temp : temp * (-1);
        }
    }
}