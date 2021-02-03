using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifierProblem
{
    public class DateModifier
    {
        public static int DiffrenceBetweenDates(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);

            TimeSpan diffrence = dateOne - dateTwo;

            return Math.Abs(diffrence.Days);
        }
    }
}
