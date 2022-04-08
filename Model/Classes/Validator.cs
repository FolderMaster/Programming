using System;
namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        public static void AssertOnPositiveValue(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        public static void AssertMoreValue(double value, double other, string valueName, string otherName)
        {
            if (value <= other)
            {
                throw new ArgumentException($"{valueName} must be more than {otherName}");
            }
        }

        public static void AssertLessValue(double value, double other, string valueName, string otherName)
        {
            if (value >= other)
            {
                throw new ArgumentException($"{valueName} must be less than {otherName}");
            }
        }
    }
}
