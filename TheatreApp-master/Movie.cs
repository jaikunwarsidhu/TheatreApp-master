using System;
using System.Collections.Generic;
namespace TheatreApp
{
    public class Movie
    {
        public int Length { get;}
        public int Year { get;}
        public string Title { get;}
        public Genre Genre { get; private set;}
        public List<string> Cast { get;}

        public Movie(string name, int year, int length)
        {
            Title = name;
            Year = year;
            Length = length;
            Cast = new List<string>() { };
        }
        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }
        public void SetGenre(Genre genre)
        {
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} {Year} \n{string.Join(",", Cast)} \nLength:{Length}min";
        }

     }
}
