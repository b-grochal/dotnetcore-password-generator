﻿namespace PasswordGenerator.Services
{
    public interface IRandomNumberGenerator
    {
        int GenerateRandomNumber(int minValue, int maxValue);
    }
}