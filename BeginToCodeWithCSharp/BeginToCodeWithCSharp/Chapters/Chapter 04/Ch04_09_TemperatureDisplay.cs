using SnapsLibrary;

class Ch04_09_TemperatureDisplay
{
    public void StartProgram()
    {
int temperature =
    SnapsEngine.GetTodayTemperatureInFahrenheit(latitude: 34.03, longitude: -84.62);
        string fullMessage;
        fullMessage = "The current temperature is " + temperature + " degrees.";
        SnapsEngine.DisplayString(fullMessage);
    }
}
