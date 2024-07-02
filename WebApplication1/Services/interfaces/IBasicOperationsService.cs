using Calc.Models;

namespace Calc.Services.interfaces
{
    public interface IBasicOperationsService
    {
        public double Sum(IncomingValues values);
        public double Subtract(IncomingValues values);
        public double Divide(IncomingValues values);
        public double Multiply(IncomingValues values);
        
    }
}
