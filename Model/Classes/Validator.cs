using System;
namespace Programming.Model.Classes
{
    static public class Validator
    {
        static public void AssertOnPositiveValue(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        static public void AssertOnPositiveValue(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        static public void AssertValueInRange(int value, int min, int max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        static public void AssertValueInRange(double value, double min, double max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        static public void AssertMoreValue(double value, double other, string valueName, string otherName)
        {
            if (value <= other)
            {
                throw new ArgumentException($"{valueName} must be more than {otherName}");
            }
        }

        static public void AssertLessValue(double value, double other, string valueName, string otherName)
        {
            if (value >= other)
            {
                throw new ArgumentException($"{valueName} must be less than {otherName}");
            }
        }
    }
}
