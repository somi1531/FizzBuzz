using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Services
{
    public class Assess : IAssess
    {
        private readonly IValidator _validator;
        private readonly IProcessor _assessrProcessor;

        public Assess(IValidator validator, IProcessor assessProcessor)
        {
            _validator = validator;
            _assessrProcessor = assessProcessor;
        }
        public validateModel validateData(List<string> inputs)
        {
            var response = new List<FizzBuzzModel>();
            var divisors = GetDivisors();
            foreach (var input in inputs)
            {
                if (_validator.IsValid(input))
                {
                    string output = _assessrProcessor.ValidateData(Convert.ToInt32(input), divisors);
                    response.Add(new FizzBuzzModel(input, output));
                }
                else
                {
                    response.Add(new FizzBuzzModel(input, "Invalid Item"));
                }
            }
            return new validateModel(response);
        }

        private List<DivisorModel> GetDivisors()
        {
            var divisors = new List<string>() { "3:Fizz", "5:Buzz" };

            return divisors.Select(_ =>
            {
                DivisorModel divisorModel = new DivisorModel(Convert.ToInt32(_.Split(":")[0]), _.Split(":")[1]);
                return divisorModel;
            }).ToList();
        }
    }
}
