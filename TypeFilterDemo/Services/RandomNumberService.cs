using System;

namespace TypeFilterDemo.Services
{
    public class RandomNumberService : IRandomNumberService
    {
        public int GetRandomInteger()
        {
            var random = new Random();
            return random.Next(1000);
        }
    }
}
