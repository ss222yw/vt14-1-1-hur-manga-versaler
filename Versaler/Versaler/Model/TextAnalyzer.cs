using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versaler.Model
{
    // En statik klass.
    public static class TextAnalyzer
    {
        // En statik metod.
        public static int GetNumberOfCapitals(string text)
        {
            // Räknare.
            int counter = 0;

            foreach (char i in text)
            {
                if(Char.IsUpper(i))
                {
                    counter++;
                }
            }
            // Retunera counter .
            return counter;
        }
    }
}