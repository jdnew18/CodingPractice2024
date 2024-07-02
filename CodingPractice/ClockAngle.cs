namespace CodingPractice;

public static class ClockAngle
{
    // Given 12-hour clock time in intervals as small as 5 minutes,
    // determine angle between hour hand and minute hand.
    public int Calculate(int hour, int minute) {
        // Validate input.
        if (hour < 1 || hour > 12 || minute < 0 || minute > 59) {
            throw new Exception("Invalid input: Hours must be between 1 and 12 and minutes must be between 0 and 59.");
        }

        // Get positive angle of hour hand.
        int hourAngle = hour * 30;

        // Get positive angle of minute hand.
        int minuteAngle = minute * 6;

        // Get absolute value of difference between angles.
        int difference = Math.Abs(hourAngle - minuteAngle);

        // If difference greater than 180, calculate difference from 360.
        if (difference > 180) {
            difference = 360 - difference;
        }

        // Return result.
        return difference;
    }
}
