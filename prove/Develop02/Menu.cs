public class Menu
{
    public string _option1 = "Create Entry";
    public string _option2 = "Display Entries";
    

    public int Display()
    {
        
        string choiceGrab;
        while (true)
        {
            Console.WriteLine("Welcome to the Journal program. Please select an option");
            Console.WriteLine($"1: {_option1}");
            Console.WriteLine($"2: {_option2}");
            choiceGrab = Console.ReadLine();
            //Checks for valid input
            if (float.TryParse(choiceGrab, out float number))
            {
                int choice = int.Parse(choiceGrab);
                return choice;
            }
         else
            {
               Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}