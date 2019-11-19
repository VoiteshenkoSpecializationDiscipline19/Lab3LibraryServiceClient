using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class DateRange
{
    public DateRange(DateTime from, DateTime to)
    {
        DateFrom = from.ToString();
        DateTo = to.ToString();
    }

    public string DateFrom { get; set; }
    public string DateTo { get; set; }
}
