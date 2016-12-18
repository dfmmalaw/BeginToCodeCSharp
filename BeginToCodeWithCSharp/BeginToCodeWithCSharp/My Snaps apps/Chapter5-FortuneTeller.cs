using SnapsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Chapter5_FortuneTeller
{
    public void StartProgram()
    {
        if (SnapsEngine.ThrowDice() < 4 || SnapsEngine.ThrowDice() > 8)
        {
            SnapsEngine.SpeakString("You are going to meet a tall, attractive stranger");
        }        
        else
            SnapsEngine.SpeakString("You are not going to meet anyone at all");
    }
}
