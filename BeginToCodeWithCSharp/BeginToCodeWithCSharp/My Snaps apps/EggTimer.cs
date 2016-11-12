using SnapsLibrary;

class EggTimer
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Egg Timer");
        SnapsEngine.DisplayString("There are five minutes left");
        SnapsEngine.Delay(300);
        SnapsEngine.DisplayString("There are four minutes left");
    }
}