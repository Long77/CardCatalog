using System;

namespace CardCatalog
    /* Deliverables Expected
     * ------------------------*
     * Create objects to take inputs of book title, author, publishing co.(if known), year, genre, etc. X
     * Search functionality to find works by author, genre, year, etc.
     * Solidify getters and setters
     * 
     * Build something awesome for TMG and have fun.
     * 
     * Optionals
     * ------------------------*
     * Create forms logic in webpage w/ viewable and editable fields in local machine or webpage
     * Create GUI with fault-tolerant dependencies
     * Create intuitive DB or pseudoDB
     * 
     */
{
    class CardTest
    {
        public static string choice { get; private set; }

        static void Data() // I could not get this to work, no matter how I tried. I need to revisit drawing from arrays.
            // Also I will branch out more with Collections & Generics (KV Pairs, Dictionary, IEnumerable and the like).
        {
            var cards = new[] {
                new Card("Lord of the Rings", "Tolkien, J.R.R.", 1954, "George Allen & Unwin", "Fantasy"),
                new Card("Being and Time", "Heidegger, Martin", 1927, "Harper Perrenial (new issue)", "Philosophy"),
                new Card("Pride and Prejudice", "Austen, Jane", 1813, "Penguin Books (reissue)", "Fiction"),
                new Card("Plato: Complete Works", "Cooper, John M.", 1997, "Hackett Publishing Co.", "Philosophy"),
                // new Card("")
            };
            // Console.WriteLine("Options: \nAdd new book: A\nSearch books by keyword or number : S");

            foreach (var element in cards)
            {
                Console.WriteLine(element);
            }
        }
        static void Choice(string choice)
        {
            string input = Console.ReadLine();
            choice = input;

            /*if (input != "1")
            {
                Console.WriteLine("Invalid entry. Try again!");
                Console.WriteLine("Please use a number 1-5 to select your choice.");
            }
            */
            if (input == "1")
            {
               Data();
            }
            if (input == "2")
            {
               Choice2();
            }
        }
        static void Choice2()
        {
            Card newCard = new Card(); // Create Card object, assign it to newCard
            Console.WriteLine("Begin with the book title:\n");

            string title = Console.ReadLine(); // read title to save
            newCard.GetName(title); //put title in newCard object
            Console.WriteLine($"Adding New Book to Catalog: {newCard.GetName(title)}");

            Console.WriteLine($"Added \"{newCard.GetName(title)}\" to Catalog. Enter book information below:"); // display title stored in newCard object
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Card newCard = new Card(); // Create Card object, assign it to newCard
 
            Console.Write("Welcome to the Card Catalog! \nChoose a number from the options below.\n\n"); // prompt
            Console.WriteLine("View Entire Directory: '1'");
            Console.WriteLine("Enter New Book or Media: '2'");
            Console.WriteLine("Search Catalog by Keyword: '3'");
            Console.WriteLine("Search Catalog by Number: '4'");
            Console.WriteLine("Additional Information: '5'");
            
            string input = Console.ReadLine();

            while (input != null)
            {
                if (input == "1")
                {
                    Data();
                    Console.ReadLine();
                }
                if (input == "2")
                {
                    Choice2();
                    Console.ReadLine();
                }
                
                // choice = input;
            }
            //if (input == "1")
            //{
            //    Data();
            //}
            //if (input == "2")
            //{
            //    Choice2();
            //}
        }

    }
    /*What we know:
     * Need to Combat Infinite Loop when code is run! :-/
     * Main method and all related code is reachable.
     * String interpolation rocks. Keep doing that the right way.
     * Objects created are working.
     */
}
