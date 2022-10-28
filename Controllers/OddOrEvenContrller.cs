// Fernando Aguilar
// 10-26-22
// Odd Or Even Endpoints
// This program takes mini challenge 6 and converts it into an API program. 
// The program will take the users input of a number and output onto Postman
// whether the number is odd or even.
// Peer Reviewed By: Jasmine Leek- code runs as expected, I really like how straightforward it reads.
// good work!


using Microsoft.AspNetCore.Mvc;

namespace AguilarFOddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("tryNumbers/{number1}")]

    public string tryNumbers(string number1)
    {
        long validNum = 0;
        bool isNumber;
        int convertNum1 = Convert.ToInt32(number1);

        isNumber = Int64.TryParse(number1, out validNum);

        if (validNum % 2 == 0)
        {
            return convertNum1 + " is even. ";
        }
        else
        {
            return convertNum1 + " is odd. ";
        }

    }
}
