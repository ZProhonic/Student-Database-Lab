

using System.Threading.Channels;

string[] studentNames = new string[] {"Jim", "Tom", "Michael", "Zack", "Jeremy"};
string[] studentTowns = new string[] { "Charlotte", "Detroit", "Pittsburgh", "New York City", "Charleston" };
string[] studentFoods = new string[] { "Pizza", "Steak", "Tacos", "Lasagna", "Lobster" };

int userNumber = 0;

Console.WriteLine("Welcome! Would you like to see a list of our students? Y or N");
string userAnswer = Console.ReadLine().ToUpper().Trim();
if (userAnswer == "Y")
{
    Console.WriteLine("Here is a list of our students: \n 1. Jim \n 2. Tom \n 3. Michael \n 4. Zack \n 5. Jeremy");
}
else if (userAnswer == "N")
{

}
else
{
    Console.Write("This isnt a valid option but i will accept it. :) ");
}

bool playAgain = true;

do
{

    bool loopAgain = true;
    
    while (loopAgain == true)
    {
        while (userNumber < 1 || userNumber > studentNames.Length)
        {
            Console.WriteLine("Which student would you like to learn about? Please enter a number between 1 and 5: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber < 1 || userNumber > studentNames.Length)
            {
                Console.WriteLine("That number is out of range. Please try again");
            }
            else
            {
                
            }
        }

            Console.WriteLine($"You selected {studentNames[userNumber - 1]}. What would you like to know about this student? Enter 'hometown' or 'favorite food'.");
            string userInput = Console.ReadLine();
            switch (userInput.ToUpper().Trim())
            {
                case "HOMETOWN":
                case "HOME":
                case "TOWN":
                    Console.WriteLine($"{studentNames[userNumber - 1]} is from {studentTowns[userNumber - 1]}");
                loopAgain = false;
                break;
                case "FOOD":
                case "FAVORITE FOOD":
                    Console.WriteLine($"{studentNames[userNumber - 1]} likes {studentFoods[userNumber - 1]}.");
                    loopAgain = false;
                break;
                default:
                    Console.WriteLine("Sorry, that isnt a valid option. Please try again.");
                continue;
            }
        
        Console.WriteLine("Would you like to learn about another student? Enter y or n");
        playAgain = Console.ReadLine().ToUpper().Trim() == "Y" ? true : false;
        if (playAgain == false)
        {
            Console.WriteLine("Thank you!");
        }

    }
} while (playAgain == true);


