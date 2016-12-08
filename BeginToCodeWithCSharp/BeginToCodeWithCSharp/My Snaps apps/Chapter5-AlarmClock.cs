using SnapsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Chapter5_AlarmClock
{
    // this will test to see if the time is 9:15 or 6:15 by converting the hour to minutes
    public void StartProgram()
    {
        if (SnapsEngine.GetDayOfWeekName() == "Saturday")
        {
            if (SnapsEngine.GetHourValue() > 8 * 60 + 15)
                SnapsEngine.DisplayString("It is time to get up");
        }
        else
        {
            if (SnapsEngine.GetHourValue() > 6 * 60 + 15)
                SnapsEngine.DisplayString("It is time to get up");
        }
    }
}
