using SnapsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginToCodeWithCSharp.My_Snaps_apps
{
    class EggTimer
    {
        public void StartProgram()
        {
            SnapsEngine.SetTitleString("Egg Timer");
            SnapsEngine.DisplayString("There are five minutes left");
            SnapsEngine.Delay(300);
            SnapsEngine.DisplayString("Your egg is done!");
        }
    }
}


