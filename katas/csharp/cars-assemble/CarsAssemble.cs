static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0.0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return 1.0;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Speed must be between 0 and 10.");
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        return speed * 221 * successRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double productionRatePerHour = ProductionRatePerHour(speed);
        return (int)(productionRatePerHour / 60);
    }
}
