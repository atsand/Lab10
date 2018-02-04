using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lab10
{   [TestFixture]
    class Tests
    {
        [Test]
        public void TestMovieGetTitle()
        {
            string title = "Best Movie", category = "B Movies";
            string expected = "Best Movie", actual;
            Movie testMovie = new Movie(title, category);
            actual = testMovie.GetTitle();
            Assert.AreEqual(expected, actual, "GetTitle isn't working.");
        }

        [Test]
        public void TestMovieGetCategory()
        {
            string title = "Best Movie", category = "B Movies";
            string expected = "B Movies", actual;
            Movie testMovie = new Movie(title, category);
            actual = testMovie.GetCategory();
            Assert.AreEqual(expected, actual, "GetCategory isn't working.");
        }

        [Test]
        public void TestListContents()
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
            Movie movie16 = new Movie("Toy Story", "Animated");
            Movie movie17 = new Movie("Finding Nemo", "Animated");
            Movie movie18 = new Movie("Blade Runner", "Sci-fi");
            Movie movie19 = new Movie("Star Wars", "Sci-fi");

            List<Movie> movies = Program.MakeList();

            Assert.Contains(movie1, movies, "List does not contain movie1");

            Assert.Contains(movie2, movies, "List does not contain movie2");

            Assert.Contains(movie3, movies, "List does not contain movie3");

            Assert.Contains(movie4, movies, "List does not contain movie4");

            Assert.Contains(movie5, movies, "List does not contain movie5");

            Assert.Contains(movie6, movies, "List does not contain movie6");

            Assert.Contains(movie7, movies, "List does not contain movie7");

            Assert.Contains(movie8, movies, "List does not contain movie8");

            Assert.Contains(movie9, movies, "List does not contain movie9");

            Assert.Contains(movie10, movies, "List does not contain movie10");

            Assert.Contains(movie11, movies, "List does not contain movie11");

            Assert.Contains(movie12, movies, "List does not contain movie12");

            Assert.Contains(movie13, movies, "List does not contain movie13");

            Assert.Contains(movie14, movies, "List does not contain movie14");

            Assert.Contains(movie15, movies, "List does not contain movie15");

            Assert.Contains(movie16, movies, "List does not contain movie16");

            Assert.Contains(movie17, movies, "List does not contain movie17");

            Assert.Contains(movie18, movies, "List does not contain movie18");

            Assert.Contains(movie19, movies, "List does not contain movie19");
        }
    }
}
