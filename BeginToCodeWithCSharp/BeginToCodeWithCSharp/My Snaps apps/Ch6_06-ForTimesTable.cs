using SnapsLibrary;

class Ch6_06_ForTimesTable
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Talking Times Tables");

        while (true)
        {
            int timesValue = 2;

            SnapsEngine.ClearScreenTappedFlag();

            for (int count = 1; count < 13; count = count + 1)
            {
                if (count == 4)
                {
                    continue;
                }

                int result = count * timesValue;

                string message = count.ToString() +
                    " times " + timesValue.ToString() +
                    " is " + result.ToString();

                SnapsEngine.DisplayString(message);
                SnapsEngine.SpeakString(message);

                if (SnapsEngine.ScreenHasBeenTapped())
                    break;
            }
            SnapsEngine.WaitForButton("Press to continue");
        }
    }
}
