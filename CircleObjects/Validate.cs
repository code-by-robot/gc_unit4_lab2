using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Validate
    {
        private bool IsValid;


        //Methods
        public double Radius(string _number)
        {
            while (true)
            {
                IsValid = double.TryParse(_number, out double valid_number);
                double output = (IsValid && valid_number > 0) ? valid_number : -1;
                return output;
            }
        }
    }
}
