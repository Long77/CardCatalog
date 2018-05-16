using System;

namespace CardCatalog
{
    public class Card // declares Card as an object
    {
        private string title; // instance variables below
        private string author;
        public int year;
        public string pubCo;
        public string genre;

        public Card() // default constructor
        {
            title = "N/A";
        }

        // constructor
        public Card(string title, string author, int year, string pubCo, string genre)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pubCo = pubCo;
            this.genre = genre;
        }

        // wondering why I cannot use this (public string Title { get; set; }) for my declarations.
        public string Title // { get; set; } has no references, why?
        {
            get
            {
                return title;
            }
            set
            {
                title = Title;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = Author;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = Year;
            }
        }
        public string Company
        {
            get
            {
                return pubCo;
            }
            set
            {
                pubCo = Company;
            }
        }
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = Genre;
            }
        }
        
        /*public Choice CreateChoice()
        {
            int input = new Choice(new int[] { 1, 2, 3, 4, 5 });
        }
        */
        public class Choice {};

        public string GetName(string title) // retrieves stored title from Card class
        {
            return title; // returns title
        }

        /*static void Choice1()
        {
            foreach (var element in Card)
            {
                Console.WriteLine(element);
            }
        }
        */
        static void Search()
        {

        }
    }
}