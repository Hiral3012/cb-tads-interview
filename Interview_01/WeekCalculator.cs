using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_01
{
    public class WeekCalculator
    {
        public static string DescribeDays(DaySelections days)
        {
            if(days.Mon == false && days.Tue == false && days.Wed == false && days.Thu == false && days.Fri == false && days.Sat == false && days.Sun == false)
            {
                return "None";
            }
            else if(days.Mon == true && days.Tue == true && days.Wed == true && days.Thu == true && days.Fri == true && days.Sat == true && days.Sun == true)
            {
                return "Every Day";
            }
            else if(days.Mon == false && days.Tue == false && days.Wed == false && days.Thu == false && days.Fri == false && days.Sat == true && days.Sun == true)
            {
                return "Weekends";
            }
            else if(days.Mon == true && days.Tue == true && days.Wed == true && days.Thu == true && days.Fri == true && days.Sat == false && days.Sun == false)
            {
                return "Week Days";
            }
            else if(days.Mon == true && days.Tue == false && days.Wed == false && days.Thu == false && days.Fri == false && days.Sat == false && days.Sun == false)
            {
                return "Every Monday";
            }
            else if(days.Mon == false && days.Tue == true && days.Wed == false && days.Thu == false && days.Fri == false && days.Sat == false && days.Sun == false)
            {
                return "Every Tuesday";
            }
            else if(days.Mon == false && days.Tue == false && days.Wed == true && days.Thu == false && days.Fri == false && days.Sat == false && days.Sun == false)
            {
                return "Every Wednesday";
            }
            else if(days.Mon == false && days.Tue == false && days.Wed == false && days.Thu == true && days.Fri == false && days.Sat == false && days.Sun == false)
            {
                return "Every Thursday";
            }
            else if(days.Mon == false && days.Tue == false && days.Wed == false && days.Thu == false && days.Fri == true && days.Sat == false && days.Sun == false)
            {
                return "Every Friday";
            }
            else if(days.Mon == false && days.Tue == false && days.Wed == false && days.Thu == false && days.Fri == false && days.Sat == true && days.Sun == false)
            {
                return "Every Saturday";
            }
            else if(days.Mon == false && days.Tue == false && days.Wed == false && days.Thu == false && days.Fri == false && days.Sat == false && days.Sun == true)
            {
                return "Every Sunday";
            }            
            else if(days.Mon == true || days.Tue == true || days.Wed == true || days.Thu == true || days.Fri == true || days.Sat == true || days.Sun == true)
            {
                var s = "";
                if(days.Mon == true)
                {
                    s+="Mon ";
                }
                else if(days.Tue == true)
                {
                    s+="Tue ";
                }
                else if(days.Wed == true)
                {
                    s+="Wed ";
                }
                else if(days.Thu == true)
                {
                    s+="Thu ";
                }
                else if(days.Fri == true)
                {
                    s+="Fri ";
                }
                else if(days.Sat == true)
                {
                    s+="Sat ";
                }
                else if(days.Sun == true)
                {
                    s+="Sun";
                }
                return s;               
            }
            
        }

    }
}
