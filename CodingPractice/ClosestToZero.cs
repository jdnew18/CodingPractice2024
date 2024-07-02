namespace CodingPractice;

public static class ClosestToZero
{
    // Return number in array whose absolute value is closest to zero.
    public double Find(double[] ts) {
        // If empty, return 0.
        if (ts.Length == 0) {
            return 0;
        }

        double closest = ts.First();
        double absClosest = GetAbsoluteValue(closest);

        // Iterate through array to find number closest to 0.
        foreach (double currTemp in ts) {
            double absCurrTemp = GetAbsoluteValue(currTemp);

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
                
ß               // Update.
                absClosest = GetAbsoluteValue(closest);
            }
        }

        return closest;
    }

    double GetAbsoluteValue(double temp) {
        return temp >= 0 ? temp : temp * (-1);
    }
}
