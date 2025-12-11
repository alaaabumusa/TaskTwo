namespace TaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int movieChoice, dayChoice, age, memberChoice;
            double price = 0;

            Console.WriteLine("Choose movie type:");
            Console.WriteLine("1- Action");
            Console.WriteLine("2- Comedy");
            Console.WriteLine("3- Drama");
            movieChoice = int.Parse(Console.ReadLine());

            string movieName = "";

            if (movieChoice == 1)
                movieName = "Action";

            else if (movieChoice == 2)
                movieName = "Comedy";

            else
                movieName = "Drama";


            if (movieChoice == 1) price = 10;
            else if (movieChoice == 2) price = 8;
            else if (movieChoice == 3) price = 7;

            Console.WriteLine("Choose day:");
            Console.WriteLine("1- Weekday");
            Console.WriteLine("2- Weekend");
            dayChoice = int.Parse(Console.ReadLine());

            if (dayChoice == 2) price += 2;

            string dayName = "";

            if (dayChoice == 1)
                dayName = "Weekday";

            else
                dayName = "Weekend";


            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());

            if (age < 10) price = price * 0.5;

            Console.WriteLine("Do you have membership?");
            Console.WriteLine("1- Yes");
            Console.WriteLine("2- No");
            memberChoice = int.Parse(Console.ReadLine());

            if (memberChoice == 1) price = price * 0.8;

            if (price < 3) price = 3;


            string memberStatus = "";

            if (memberChoice == 1)
                memberStatus = "Yes";

            else
                memberStatus = "No";


            Console.WriteLine("\n===== Ticket Summary =====");
            Console.WriteLine("Movie Type: " + movieName);
            Console.WriteLine("Day: " + dayName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Membership: " + memberStatus);

            Console.WriteLine("\nFinal Ticket Price = " + price);
        }
    }
    }