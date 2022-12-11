using System;

namespace Counter_Countdown
{
    public class Class1
    {
         if(timer && totaltime > 0)
        {
            totaltime -= Time.deltaTime;

            minute = Mathf.FloorToInt(totaltime / 60);
            second = Mathf.FloorToInt(totaltime % 60);
            counter.text = string.Format("{0:00}  :  {1:00}", minute, second);
    }
        else
        {
            timer = false;
        }
    }
}
