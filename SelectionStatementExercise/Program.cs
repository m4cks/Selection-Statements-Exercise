namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SECTION: 1
            var r = new Random();
            var favNumber = r.Next(1, 5692);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            if(userInput < favNumber)
            {
                Console.WriteLine("too low");
            } else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            } else
            {
                Console.WriteLine("Nevermind");
            }

            //SECTION: 2
            Console.WriteLine("What is your favorite school subject?");
            var userFavSubject = Console.ReadLine();
            switch(userFavSubject)
            {
                case "Math":
                    Console.WriteLine($"{userFavSubject}? I love Math!");
                    break;
                case "English":
                    Console.WriteLine($"{userFavSubject}? Ew.");
                    break;
                case "Spanish":
                    Console.WriteLine($"{userFavSubject}? Genial!");
                    break;
                case "History":
                    Console.WriteLine($"{userFavSubject}? That was years ago.");
                    break;
                case "Computer Science":
                    Console.WriteLine($"{userFavSubject}? Smart choice ;)");
                    break;
                default:
                    Console.WriteLine($"{userFavSubject}? Oh, well this is a default response soo...");
                    break;
            }

        }
    }
}