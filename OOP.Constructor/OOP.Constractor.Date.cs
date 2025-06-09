using System.Data;

namespace OOP.Constructor;

public class Date
{
    private int year;
    private int month;
    private int day;
    
    public Date(int year, int month, int day)
    {   
                                 //    1    2   3   4    5   6   7   8   9  10  11  12
        int[] DayOfMonth = new int[] { 31,  28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
        int[] _DayOfMonth = new int[] { 31,  29, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
        int[]days=((year % 4 == 0)&&(year % 100 != 0||year%400==0))?_DayOfMonth:DayOfMonth;
        if ((year >= 17 && year <= 9999) && (month >= 1 && month <= 12))
        {
            if (day >= 1 && day <= days[month - 1])
            {
                this.year = year;
                this.month = month;
                this.day = day;
                
            }
            else
            {
                this.year = 00;
                this.month = 00;
                this.day = 00;
            }
        }
        else
        {
            this.year = 00;
            this.month = 00;
            this.day = 00;
        }

        
    }

    public Date(int year) : this(year, 12, 30)
    {
        
    }

    // public static void Dateset(int year, int month, int day)
    // {
    //     //    1    2   3   4    5   6   7   8   9  10  11  12
    //     int[] DayOfMonth = new int[] { 31,  28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
    //     int[] _DayOfMonth = new int[] { 31,  29, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
    //     int[]days=((year % 4 == 0)&&(year % 100 != 0||year%400==0))?_DayOfMonth:DayOfMonth;
    //     if ((year >= 17 && year <= 9999) && (month >= 1 && month <= 12))
    //     {
    //         if (day >= 1 && day <= days[month - 1])
    //         {
    //             this.year = year;
    //             this.month = month;
    //             this.day = day;
    //             
    //         }
    //         else
    //         {
    //             this.year = 00;
    //             this.month = 00;
    //             this.day = 00;
    //         }
    //     }
    //     else
    //     {
    //         this.year = 00;
    //         this.month = 00;
    //         this.day = 00;
    //     }
    //
    // }

    public String PrintDate()
    {
        return $"{year.ToString().PadLeft(2, '0')} {month.ToString().PadLeft(2, '0')} {day.ToString().PadLeft(2, '0')}";
    }
}