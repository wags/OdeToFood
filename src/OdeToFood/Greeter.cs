﻿using Microsoft.Extensions.Configuration;

namespace OdeToFood
{
    public interface IGreeter
    {
        string GetGreeting();
    }

    public class Greeter : IGreeter
    {
        private string _greeting;

        public Greeter(IConfiguration configuration)
        {
            _greeting = configuration["Greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
