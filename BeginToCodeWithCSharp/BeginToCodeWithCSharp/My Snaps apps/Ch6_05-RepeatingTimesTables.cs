﻿using SnapsLibrary;

class Ch6_05_RepeatingTimesTables
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Talking Times Tables");

        while (true)
        {
            int count = 1;
            int timesValue = SnapsEngine.ReadInteger("Enter your times value.");

            while (count < 13 && timesValue < 25)
            {
                int result = count * timesValue;

                string message = count.ToString() +
                    " times " + timesValue.ToString() +
                    " is " + result.ToString();

                SnapsEngine.DisplayString(message);
                SnapsEngine.SpeakString(message);
                count = count + 1;
            }
            SnapsEngine.WaitForButton("Enter a value less than 25");
        }
    }
}