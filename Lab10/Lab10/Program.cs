using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the movie list app!\n");
            PrintList();
        }

        public static List<Movie> MakeList()
        {
            Movie movie1 = new Movie("The Shawshank Redemption", "Drama");
            Movie movie2 = new Movie("The Godfather", "Drama");
            Movie movie3 = new Movie("The Dark Knight", "Action");
            Movie movie4 = new Movie("12 Angry Men", "Drama");
            Movie movie5 = new Movie("Schindler's List", "Drama");
            Movie movie6 = new Movie("The Lord of the Rings: The Return of the King", "Fantasy");
            Movie movie7 = new Movie("Inception", "Action");
            Movie movie8 = new Movie("Star Wars: Episode V", "Sci-fi");
            Movie movie9 = new Movie("The Matrix", "Action");
            Movie movie10 = new Movie("One Flew Over the Cuckoo's Nest", "Drama");
            Movie movie11 = new Movie("It", "Horror");
            Movie movie12 = new Movie("Halloween", "Horror");
            Movie movie13 = new Movie("Get Out", "Horror");
            Movie movie14 = new Movie("Up", "Animated");
            Movie movie15 = new Movie("Ice Age", "Animated");
            Movie movie16 = new Movie("Toy Story","Animated");
            Movie movie17 = new Movie("Finding Nemo", "Animated");
            Movie movie18 = new Movie("Blade Runner", "Sci-fi");
            Movie movie19 = new Movie("Star Wars", "Sci-fi");
            List<Movie> Movies = new List<Movie> { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10,
            movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19};
            
            return Movies;
        }

        public static string GetCategory()
        {
            string input;
            int inputInt;
            List<string> categories = new List<string>() {"Animated", "Drama", "Horror", "Sci-fi", "Fantasy", "Action" };
            Console.WriteLine("Enter the number of the genre below to see movies of that style:\n1) Animated\n2) Drama\n3) Horror\n4) Sci-fi\n5) Fantasy\n6) Action");
            input = Console.ReadLine();
            if (int.TryParse(input, out inputInt) && int.Parse(input)>0 && int.Parse(input)<=categories.Count)
            {
                Console.WriteLine("\n============================");
                Console.WriteLine(categories[inputInt - 1] + " movies");
                Console.WriteLine("============================");
                return categories[inputInt - 1];
            }
            else
            {
                Console.WriteLine("\nInvalid input.\n");
                return GetCategory();
            }
        }

        public static void PrintList()
        {
            string category = GetCategory();
            List<Movie> movieList = MakeList();
            List<string> movieMatch = new List<string>();
            foreach (Movie m in movieList)
            {
                if (m.GetCategory()==category)
                {
                    movieMatch.Add(m.GetTitle());
                }
            }
            movieMatch.Sort();
            foreach (string movie in movieMatch)
            {
                Console.WriteLine(movie);
            }
            Again();
        }

        public static void Again()
        {
            string input;

            Console.WriteLine("\nWould you like to continue? (Y/N)");
            input = Console.ReadLine().ToLower();

            if (input == 'y'.ToString())
            {
                Console.WriteLine();
                PrintList();
            }
            else if (input == 'n'.ToString())
            {
                Console.WriteLine("\nGoodbye\n");
                return;
            }
            else
            {
                Console.WriteLine("Not a valid input.  Would you like to try again? (Y/N)");
                Again();
            }
        }
    }
}
