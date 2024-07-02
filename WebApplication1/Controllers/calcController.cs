using Calc.Models;
using Calc.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalcWebApi.Controllers
{
    [ApiController]
    public class calcController : ControllerBase
    {
        private readonly IBasicOperationsService _basicOperations;

        public calcController(IBasicOperationsService basicOperations)
        {
            _basicOperations = basicOperations;
        }
        [HttpGet]
        public IActionResult Addition(IncomingValues values)
        {
            return Ok(_basicOperations.Sum(values));
        }

        [HttpGet]
        public IActionResult Subtraction(IncomingValues values)
        {
            return Ok(_basicOperations.Subtract(values));
        }

        [HttpGet]
        public IActionResult Multiplication(IncomingValues values)
        {
            return Ok(_basicOperations.Multiply(values));
        }
        [HttpGet]
        public IActionResult Division(IncomingValues values)
        {
            return Ok(_basicOperations.Divide(values));
        }   
    }
}