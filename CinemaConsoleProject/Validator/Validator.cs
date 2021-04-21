namespace CinemaConsoleProject.Validator
{
    using System;
    public class Validator
    {
        public static void ThrowAnExceptionIfObjectIsNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentException($"{paramName} doesn't exist!");
            }
        }
        public static void ThrowAnExceptionIfIntIsLessThanZero(string objectName, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{objectName} cannot be less than zero!");
            }
        }
    }
}
