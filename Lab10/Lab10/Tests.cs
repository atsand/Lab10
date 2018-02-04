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



    }
}
