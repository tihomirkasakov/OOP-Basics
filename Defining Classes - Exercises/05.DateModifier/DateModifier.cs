using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public class DateModifier
{
    public int DaysDifference(string firstDate, string secondDate)
    {
        var firstDateParse = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var secondDateParse = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs((firstDateParse - secondDateParse).Days);
    }
}
