namespace PasswordGenerator.Helpers
{
    public interface IRandomNumberGenerator
    {
        int GenerateRandomNumber(int minValue, int maxValue);
    }
}