using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data
{
    internal class DayofWeek
    {


        public static string GetDayCZName(int day_num)
        {
            if (day_num == 1)
                return "Pondělí";
            else if (day_num == 2)
                return "Úterý";
            else if (day_num == 3)
                return "Středa";
            else if (day_num == 4)
                return "Čtvrtek";
            else if (day_num == 5)
                return "Pátek";
            else if (day_num == 6)
                return "Sobota";
            else if (day_num == 7)
                return "Neděle";
            return "Chyba";
        }
        public static string GetDayNameCZIndex(int day_num)
        {
                switch (day_num)
                {
                    case 1: return "Pondělí";
                    case 2: return "Úterý";
                    case 3: return "Středa";
                    case 4: return "Čtvrtek";
                    case 5: return "Pátek";
                    case 6: return "Sobota";
                    case 7: return "Nedělě";
                    default: return "";
                } 
        }
 
        public static string GetDayNameCZarray(int day_num)
        {
/*
            //var sarray = new string[10];

            string[] days = new string[] {
            "Pondělí",
            "Úterý",
            "Středa",
            "Čtvrtek",
            "Pátek",
            "Sobota",
            "Nedělě",

        };
            return days[day_num -1];
*/
         
        List<string> days_list = new List<string> {
          "Pondělí",
          "Úterý",
          "Středa",
          "Čtvrtek",
          "Pátek",
          "Sobota",
          "Nedělě"
         };

        return days_list.ElementAt(day_num); 
        
        }
/// <summary>
/// Vrácení čísla dne dle jména
/// </summary>
/// <param name="day_name"></param>
/// <returns></returns>
        public static int GetDayNumArray(string day_name)
        {
            string[] days = new string[] {
            "pondělí",
            "úterý",
            "středa",
            "čtvrtek",
            "pátek",
            "sobota",
            "nedělě",
            };
            for (int i = 0; i < 7; i++)
            {
             if(days[i] == day_name.ToLower())
                return i+1;

            }
            return -1;
        }

        public static int GetDayNumList(string day_name)
        {
            List<string> days_list = new List<string> {
          "Pondělí",
          "Úterý",
          "Středa",
          "Čtvrtek",
          "Pátek",
          "Sobota",
          "Nedělě"
         };

            return days_list.IndexOf(day_name) + 1;

        }

    }
}
