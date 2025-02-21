using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Book
    {
        public string Title { get; set; }
        public string[] Authors { get; set; } = new string[4];
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int Year { get; set; }

        public Book(string title, string[] authors, string publisher, string isbn, double price, int stock, int year)
        {
            Title = title;
            Authors = authors;
            Publisher = publisher;
            ISBN = isbn;
            Price = price;
            Stock = stock;
            Year = year;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"Title: {Title}\nAuthors: {string.Join(", ", Authors)}\nPublisher: {Publisher}\nISBN: {ISBN}\nPrice: {Price:C}\nStock: {Stock}\nYear: {Year}\n");
        }
    }
}
