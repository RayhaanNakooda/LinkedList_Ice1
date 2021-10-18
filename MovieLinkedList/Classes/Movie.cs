using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLinkedList.Classes
{
    public class Movie
    {

        private int id;
        private string name;
        private int year;
        private int imdb;

        public Movie()
        {

        }

        public Movie(int id, string name, int year, int imdb)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.imdb = imdb;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public int Imdb { get => imdb; set => imdb = value; }
        


    }
}
