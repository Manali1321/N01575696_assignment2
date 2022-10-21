using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class j2Controller : ApiController
    {

        /// <summary>
        /// Count the probability of sum 10.
        /// </summary>
        /// <param name="m">
        /// number of side in first dice
        /// </param>
        /// <param name="n">
        /// number of side in second dice
        /// </param>
        /// <returns>
        /// count the posibility to get sum 10 and return in to string.
        /// </returns>
        /// <example>GET api/j2/diceGame/6/8 --> There are 5 total ways to get the sum 10.</example>
        /// <example>GET api/j2/diceGame/12/4 --> There are 4 total ways to get the sum 10.</example>
        /// <example>GET api/j2/diceGame/3/3 --> There are 0 total ways to get the sum 10.</example>
        /// <example>GET api/j2/diceGame/5/5 --> There are 1 total ways to get the sum 10.</example>

        [HttpGet]
        [Route("api/j2/diceGame/{m}/{n}")]

        public string diceGame(int m, int n)
        {
        int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
     
                }


            }
            return "There are "+ count+ " total ways to get the sum 10.";
        }
    }
}
