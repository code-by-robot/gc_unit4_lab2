// Loop over program
using CircleObjects;

//Initialize variables
bool runProgram = true;
int counter = 0;

while(runProgram == true)
{
    //Initialize the validate class
    Validate check = new Validate();
    double rad = -1;

    //Loop until the validate class gets a valid input
    while (true)
    {
        Console.WriteLine("Please enter a radius. ");
        rad = check.Radius(Console.ReadLine());
        if (rad == -1)
        {
            Console.WriteLine("Please enter a positive double.");
        }
        else
        { 
            break;
        }
    }
    
    //Initiate circle class
    Circle cir1 = new Circle(rad);

    //Display area and circumfrence
    Console.WriteLine($"The area of the circle is {cir1.CalculateFormattedArea()}");
    Console.WriteLine($"The circumfrence of the circle is {cir1.CalculateFormattedCircumfrence()}");

    //Check to loop over program again
    counter++;
    runProgram = checkLoop("Continue? y/n", counter);

}


//Methods for program
static bool checkLoop(string message, int counter1)
{
    while (true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        if (input.ToLower().Trim() == "y")
        {
            return true;
            break;
        }
        else if (input.ToLower().Trim() == "n")
        {
            Console.WriteLine($"Goodbye. You created {counter1} circle objects.");
            return false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter y or n.");
        }
    }
}
