using Calc.Models;
using Calc.Services.interfaces;

namespace Calc.Services
{
    public class BasicOperationsService : IBasicOperationsService
    {
        public double Sum(IncomingValues values)
        {
            double result = values.firstValue + values.secondValue;
            ValidateResult(result);
            return result;
        }

        public double Subtract(IncomingValues values)
        {
            double result = values.firstValue - values.secondValue;
            ValidateResult(result);
            return result;
        }

        public double Multiply(IncomingValues values)
        {
            double result = values.firstValue * values.secondValue;
            ValidateResult(result);
            return result;
        }

        public double Divide(IncomingValues values)
        {
            if (values.secondValue == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            double result = values.firstValue / values.secondValue;
            ValidateResult(result);
            return result;
        }

        private void ValidateResult(double result)
        {
            if (Double.IsNaN(result))
            {
                throw new ArgumentException("Invalid result. Result cannot be NaN.");
            }

            if (Double.IsInfinity(result))
            {
                throw new ArgumentException("Invalid result. Result cannot be infinity.");
            }
        }
    }
}
