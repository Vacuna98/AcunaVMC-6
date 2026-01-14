using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Services
{
    public class GuessItService
    {
        private readonly Random _random = new();

        public object CheckGuess(int guess, int min, int max, string mode)
        {
            int target = _random.Next(min, max +1);

            string result;

        if(guess < target) result = "higher";
        else if (guess > target) result ="lower";
        else result = "correct";

        return new
        {
            mode,
            guess,
            target,
            result
        };

        }
    }
}