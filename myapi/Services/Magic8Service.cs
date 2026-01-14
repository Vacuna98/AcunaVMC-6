using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class Magic8Service
    {
        private static readonly List<string> Responses = new()
        {
            "Yes",
            "No",
            "Try Again",
            "I Guess",
            "Ask Me Later",
            "Definitely No",
            "Maybe",
            "Sure"
        };

        private readonly Random _random = new();

        public string GetResponse()
        {
            int index = _random.Next(Responses.Count);
            return Responses[index];
        }
    }
}