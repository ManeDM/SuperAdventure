using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();
        public static int NumberBetween(int minimunValue, int maximunValue)
        {
            return _generator.Next(minimunValue, maximunValue + 1);
        }
    }
}
