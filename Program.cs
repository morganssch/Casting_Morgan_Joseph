namespace Casting_Morgan_Joseph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("How many pets do you have?"); //I'm asking the user a question to get input from them. I will then store that input in a variable.
            string numberOfUserPets = Console.ReadLine(); //I'm actually getting their input in this line
            Console.WriteLine($"You have {numberOfUserPets} pets! That's great!"); //Here I'm gtiving the user an output to let them know I got their input

            Console.WriteLine("You like dogs? (true/false)"); //Here I'm asking the user a yes or no question. I will then store that input in a variable.
            bool userLikesDogs = Convert.ToBoolean(Console.ReadLine()); //Here I'm getting the user's input and converting it to a boolean value. If they type "true", it will be stored as true. If they type "false", it will be stored as false. If they type anything else, it will throw an error.
            Console.WriteLine($"You like dogs? {userLikesDogs}"); //Here I'm giving the user an output to let them know I got their input. It will display "You like dogs? True" or "You like dogs? False" depending on what they typed in.


        }
    }
}
