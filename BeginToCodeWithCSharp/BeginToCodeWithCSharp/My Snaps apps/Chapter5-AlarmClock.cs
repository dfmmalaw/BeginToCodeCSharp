using SnapsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Chapter5_AlarmClock
{
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
