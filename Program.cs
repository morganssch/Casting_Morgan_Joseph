namespace Casting_Morgan_Joseph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("How many pets do you have?");
            string numberOfUserPets = Console.ReadLine();
            Console.WriteLine($"You have {numberOfUserPets} pets! That's great!");

            Console.WriteLine("You like dogs? (true/false)");
            bool userLikesDogs = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"You like dogs? {userLikesDogs}");


        }
    }
}
