namespace DesignKata_CodeWars_Maximum_Time;
using System;

public class MaxHourMinute
{
    public static string Max(int[] inputArray)
    {
        //Simple Solution
        if (inputArray.Length>=2 & inputArray.All(v => v == 0)) return "00:00";
        var hour=0;
        var minute=0;
        string temp;
        
        for (var i = 0; i < inputArray.Length; i++)
        {
            for (var j = 0; j < inputArray.Length; j++)
            {
                if (i == j) continue;
                temp = inputArray[i] + inputArray[j].ToString();
                if (24 > Convert.ToInt32(temp) & Convert.ToInt32(temp) > hour)
                    hour = Convert.ToInt32(temp);
            }
        }
        
        if(hour==0) return "-1";
        
        for (var i = 0; i < inputArray.Length; i++)
        {
            for (var j = 0; j < inputArray.Length; j++)
            {
                if(i==j) continue;
                temp = inputArray[i] + inputArray[j].ToString();
                if (60 > Convert.ToInt32(temp) & Convert.ToInt32(temp) > minute) 
                    minute = Convert.ToInt32(temp);
            }
        }
        
        return minute==0 ? "-1" : $"{hour:D2}:{minute:D2}";
    }
}  