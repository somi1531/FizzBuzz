using System.Collections.Generic;

namespace FizzBuzz.Models
{
    public class validateModel
    {
        public validateModel()
        {
            FizzBuzz = new List<FizzBuzzModel>();
        }

        public validateModel(List<FizzBuzzModel> fizzBuzz)
        {
            FizzBuzz = fizzBuzz;
        }

        public List<FizzBuzzModel> FizzBuzz { get; set; }
    }
}
