// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello User! What is your name? ");
string userName = Console.ReadLine();
Console.WriteLine("Hello " + userName + "! Where are you from? ");
string userFrom = Console.ReadLine();
Console.WriteLine("Ah! I have never been to " + userFrom + ". I bet it is very nice there!");
Console.WriteLine("Please, press any key to continue to the next section " + userName + "...");
Console.ReadKey(true);
var currentDTG = DateTime.Now;
Console.WriteLine("Today's date is: " + currentDTG.ToShortDateString());
var christmas = new DateTime(DateTime.Now.Year, 12, 25);
static int daysTilChristmas(DateTime christmas, DateTime currentDTG)
{
    TimeSpan daysTil = christmas - currentDTG;
    return daysTil.Days;
}
Console.WriteLine(userName + " there are " + daysTilChristmas(christmas, currentDTG) + " days until Christmas!");
Console.WriteLine("Please, press any key to continue to the next section " + userName + "...");
Console.ReadKey(true);
Console.WriteLine("I would like to provide you a conversion of Meters to Feet for the length of a piece of wood. Please provide me a Width in Meters: ");
string width = Console.ReadLine();
Console.WriteLine("And now a Height in Meters: ");
string height = Console.ReadLine();
double wood = 2 * (double.Parse(width) + double.Parse(height)) * 3.28084;
Console.WriteLine("Given your parameters, " + userName + ", this fictional piece of wood would be equal to " + wood + "ft long!");
double glass = (double.Parse(width) * double.Parse(height)) * 2;
Console.WriteLine("Additionally, " + userName + ", if I was to apply these values to determine the square footage of an object, such as a Pane of Glass, it would be: " + glass + "m^2!");
Console.WriteLine("And that is all, thank you " + userName + " for participating in this exercise!\nPlease, press any key to continue and close this window...");
Console.ReadKey();