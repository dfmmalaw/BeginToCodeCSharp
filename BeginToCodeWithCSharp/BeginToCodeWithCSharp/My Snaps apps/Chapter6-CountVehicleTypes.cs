using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapsLibrary;

public class Chapter6_CountVehicleTypes
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Select Vehicle Type");

        int carsCount = 0;
        int vansCount = 0;
        int trucksCount = 0;
        int bikesCount = 0;

        // repeatedly ask for pizza selections
        while (true)
        {
            string vehicleType = SnapsEngine.SelectFrom5Buttons(
                "Cars",
                "Vans",
                "Trucks",
                "Bikes",
                "Show Totals");

            if (vehicleType == "Cars")
                carsCount = carsCount + 1;

            if (vehicleType == "Vans")
                vansCount = vansCount + 1;

            if (vehicleType == "Trucks")
                trucksCount = trucksCount + 1;

            if (vehicleType == "Bikes")
                bikesCount = bikesCount + 1;

            if (vehicleType == "Show Totals")
            {
                SnapsEngine.ClearTextDisplay();

                SnapsEngine.AddLineToTextDisplay("Vehicle Totals");
                SnapsEngine.AddLineToTextDisplay(carsCount.ToString() +
                    " Cars");
                SnapsEngine.AddLineToTextDisplay(vansCount.ToString() +
                    " Vans");
                SnapsEngine.AddLineToTextDisplay(trucksCount.ToString() +
                    " Trucks");
                SnapsEngine.AddLineToTextDisplay(bikesCount.ToString() +
                    " Bikes");

                string reply = SnapsEngine.SelectFrom2Buttons(item1: "Done",
                    item2: "Reset");

                if (reply == "Reset")
                {
                    carsCount = 0;
                    vansCount = 0;
                    trucksCount = 0;
                    bikesCount = 0;
                }
                // clear the total display from the screen ready for more choices
                SnapsEngine.ClearTextDisplay();
            }
        }
    }
}