namespace PasswordGenerator.Services
{
    /// <summary>
    /// Represents random number geneartor.
    /// </summary>
    public interface IRandomNumberGenerator
    {
        #region Methods

        /// <summary>
        /// Generates random integer that is within specified range.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of random number returned.</param>
        /// <param name="maxValue">The exclusive upper bound of random number returned.</param>
        /// <returns>Random non-negative integer number.</returns>
        int GenerateRandomNumber(int minValue, int maxValue);

        #endregion Methods
    }
}