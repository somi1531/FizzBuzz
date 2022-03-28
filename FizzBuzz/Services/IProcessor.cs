using FizzBuzz.Models;
using System.Collections.Generic;

namespace FizzBuzz.Services
{
    public interface IProcessor
    {
        string ValidateData(int input, List<DivisorModel> divisors);
    }
}
