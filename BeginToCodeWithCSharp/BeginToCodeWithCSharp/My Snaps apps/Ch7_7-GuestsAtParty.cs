using SnapsLibrary;

class Ch7_7_GuestsAtParty
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Number of Guests");

        int noOfGuests = SnapsEngine.ReadInteger("How many guests are at the party");
        string[] guests = new string[noOfGuests];
        int count;
        int displayCount;

        for (count = 0; count < guests.Length; count = count + 1)
        {
            displayCount = count + 1;
            guests[count] = SnapsEngine.ReadString("Enter the name of guest number " + displayCount);
        }

        SnapsEngine.ClearTextDisplay();

        for (count = 0; count < guests.Length; count = count + 1)
        {
            displayCount = count + 1;
            SnapsEngine.AddLineToTextDisplay("Guest " + displayCount + ": " + guests[count]);
        }
    }
}

