using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string title;
        private string category;

        public Movie(string t, string c)
        {
            title = t;
            category = c;
        }

        public string GetTitle()
        {
            return this.title;
        }
        public string GetCategory()
        {
            return this.category;
        }

    }
}
