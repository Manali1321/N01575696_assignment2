using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class j3Controller : ApiController
    {/// <summary>
     /// Count the minimal number of second time to type a word.
     /// </summary>
     /// <param name="input">the word which you want to calculate time to type in cell phone</param>
     /// <returns> Seconds to type the word. </returns>
     /// <example> a ---> 1</example>
     /// <example> dada ---> 4</example>
     /// <example> bob ---> 7</example>
     /// <example> abba ---> 12</example>
     /// <example> cell ---> 13</example>
     /// <example> www ---> 7</example>
     /// <example> halt ---> 0</example>

        [HttpGet]
        [Route("api/j3/cellMessage/{input}")]

        public int cellMessage(string input)
        {

            int totalSec = 0;
            if (input == "halt")
            {
                return totalSec;
            }
         ///refer from https://www.geeksforgeeks.org/convert-string-to-character-array-in-c-sharp/
            ///Convert input into char to find from array
            char[] inputArray=input.ToCharArray();

            ///make a firstLetter array for one click letter
            char[] firstLetter ="adgjmptw".ToCharArray();

            ///make a secondLetter array for two click letter
            char[] secondLetter = "behknqux".ToCharArray();

            ///make a thirdLetter array for three click letter
            char[] thirdLetter = "cfilorvy".ToCharArray();

            ///make a fourthLetter array for four click letter
            char[] fourthLetter = "_____s_z".ToCharArray();


            int currentIndex = 0;
            int newIndex = 0;
            ///refer from https://learn.microsoft.com/en-us/dotnet/api/system.array.indexof?view=net-6.0

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (firstLetter.Contains(inputArray[i]))
                {
                    totalSec+=1;
                    newIndex= Array.IndexOf(firstLetter, inputArray[i]);
                }
                else if (secondLetter.Contains(inputArray[i]))
                {
                    totalSec += 2;
                    newIndex=Array.IndexOf(secondLetter, inputArray[i]);
                }
                else if (thirdLetter.Contains(inputArray[i]))
                {
                    totalSec += 3;
                    newIndex=Array.IndexOf(thirdLetter, inputArray[i]);
                }
                else if (fourthLetter.Contains(inputArray[i]))
                {
                    totalSec += 4;
                    newIndex=Array.IndexOf(fourthLetter, inputArray[i]);
                }
                if
                (currentIndex == newIndex && i!=0)
                {
                    totalSec += 2;
                }
                currentIndex = newIndex;



            }
            return totalSec;



        }



    }
}
