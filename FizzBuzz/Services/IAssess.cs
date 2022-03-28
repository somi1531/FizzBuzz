using FizzBuzz.Models;
using System.Collections.Generic;

namespace FizzBuzz.Services
{
    public interface IAssess
    {
        validateModel validateData(List<string> inputs);
    }
}
