using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet
{
    public class TimeCard
    {
        public static int WeekAmount = 2;
        public static int DayAmount = 7;
        public float OvertimeHours = 0;
        public float MaxRegularHours = 40;
        public float TotalHoursForWeek = 0;
        public float TotalRegularHours = 0;
        public float TotalSickHours = 0;
        public float TotalVacationHours = 0;
        public DateTime StartDay = new DateTime(2016, 7, 2);
        Day[,] WeekWithDay = new Day[WeekAmount, DayAmount];
        public float Overtime = 0;

        public void FillArray()
        {
            for (int i = 0; i <= WeekAmount; i++)
            {
                    for (int j = 0; j <= DayAmount; j++)
                    {
                    WeekWithDay[i, j] = new Day(StartDay.AddDays(1));
                    }
                }
            }
        
        public float CalculateOvertime(int WeekNum)
        {
           for (int i = 0; i <= DayAmount; i++)
            {
                TotalHoursForWeek += WeekWithDay[WeekNum, i].TotalHours;
                if(TotalHoursForWeek > MaxRegularHours)
                {
                    Overtime = TotalHoursForWeek - MaxRegularHours;
                }
            }
            return Overtime;
        }

        public void GetHoursFromOneTimeType()
        {
            for (int i = 0; i <= WeekAmount; i++)
            {
                for (int j = 0; j <= DayAmount; j++)
                {
                    TotalRegularHours += WeekWithDay[i, j].RegHours;
                    TotalSickHours += WeekWithDay[i, j].SickHours;
                    TotalVacationHours += WeekWithDay[i, j].VacHours;
                }
              } 
           }
       }
   }
