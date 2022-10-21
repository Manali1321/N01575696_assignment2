using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class j1Controller : ApiController
    {/// <summary>
     /// To return total calories as per the order. Calories as per different product, its saved in array.
     /// </summary>
     /// <param name="burger">
     /// bugerCal array's index as respecitive cheese burger, fish burger, veggie burger and no burger
     /// </param>
     /// <param name="drink">
     /// drinkCal array's index as respective soft drink, orange juice, milk and no drink.
     /// </param>
     /// <param name="side">
     /// sideCal array's index as respective fries, baked potato, chef salad and no side order.
     /// </param>
     /// <param name="dessert">
     /// dessertCal's index array as respective apple pie, sunday, fruit cup and no dess
     /// </param>
     /// <returns>
     /// after the pick up each one iteam from the array calculate total calories of order and return the srting message at the end.
     /// </returns>
     /// <example> GET api/j1/menu/4/4/4/4 ---> Your total calorie count is 0 </example>
     /// <example>GET api/j1/menu/1/2/3/4 ---> Your total calorie count is 691</example>
     

        /// GET/api/j1/menu/{burger}/{drink}/{side}/{dessert}

        [HttpGet]
        [Route("api/j1/menu/{burger}/{drink}/{side}/{dessert}")]
        public string menu(int burger, int drink, int side, int dessert)
        {

            List<int> burgerCal = new List<int> { 461, 431, 420, 0 };
            List<int> drinkCal = new List<int> { 130, 160, 118, 0 };
            List<int> sideCal = new List<int> { 100, 57, 70, 0 };
            List<int> dessertCal = new List<int> { 167, 266, 75, 0 };

            int calories = burgerCal[burger - 1] + drinkCal[drink- 1] + sideCal[side - 1] + dessertCal[dessert - 1];

            return "Your total calorie count is " + calories;

        }


    }
}
