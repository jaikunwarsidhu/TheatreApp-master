using System;
namespace TheatreApp
{
    public class Show
    {
       public double Price { get; }
        public MovieDay Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie, MovieDay day, double price, Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }
        public override string ToString()
        {

            return $" The {Movie}start at {Day} {Time} and cost {Price}";
        }
    }
}
