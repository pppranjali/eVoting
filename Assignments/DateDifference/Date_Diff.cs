using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    public class Date_Diff
    {
        public void get_diff(DateTime start_date, DateTime end_date)
        {
#pragma warning disable CS0219 // The variable 'leap_year' is assigned but its value is never used
            int leap_year = 0;
#pragma warning restore CS0219 // The variable 'leap_year' is assigned but its value is never used
            int startmonth = start_date.Month;
            int startday = start_date.Day;
            int startyear = start_date.Year;
            int starthour = start_date.Hour;

            int endmonth = end_date.Month;
            int endday = end_date.Day;
            int endyear = end_date.Year;
            int endhour = end_date.Hour;

            int month = endmonth - startmonth;
            int day = endday - startday;
            int year = endyear - startyear;
            int hour = endhour - starthour;

            if((endyear%4==0 && endyear%100!=0) || (endyear%400==0))
            {
                leap_year = 1;
            }
            if (hour<=24 && day<1 && year<1 && month<1)
            {
                Console.WriteLine($"Time Difference is:: {hour} hour");
            }
            else if(day>=1 && year<1)
            {
                if(day==1)
                    Console.WriteLine($"Time Difference is:: {day} day");
                else
                    Console.WriteLine($"Time Difference is:: {day} days");
            }
            else if(year>=1 && month<1)
            {
                if(year==1)
                    Console.WriteLine($"Time Difference is:: {year} year");
                else
                    Console.WriteLine($"Time Difference is:: {year} years");
            }
            else if( year<1 && month>=1)
            {
                if(month==1)
                    Console.WriteLine($"Time Difference is:: {month} month");
                else
                    Console.WriteLine($"Time Difference is:: {month} months");
            }
            else if (year > 1 && month >= 1 && day>=1)
            {
                    Console.WriteLine($"Time Difference is:: {year} years  {month} months and {day} days");
            }
            else
            {
                Console.WriteLine($"Time Difference is:: {year} years {month} months {day} days and {hour} hours");
            }
        }

        
    }
}
