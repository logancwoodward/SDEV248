using System;
using System.Collections.Generic;

namespace NewsAgentApp
{
    //base class for all products
    public abstract class Product
    {
        public int StockID { get; set; }
        public int StockRemaining { get; set; }
        public string Manufacturer { get; set; }

        public Product(int stockID, int stockRemaining, string manufacturer)
        {
            StockID = stockID;
            StockRemaining = stockRemaining;
            Manufacturer = manufacturer;
        }

        //method to subtract from the stock when an item is sold
        public void SellItem(int quantity)
        {
            if (StockRemaining >= quantity)
            {
                StockRemaining -= quantity;
                Console.WriteLine($"{quantity} item(s) sold.");
            }
            else
            {
                Console.WriteLine("Not enough stock available.");
            }
        }

        //abstract method to be overridden in each subclass to show the type of media
        public abstract void ShowType();
    }

    //derived class for Music CD
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Title { get; set; }

        public MusicCD(int stockID, int stockRemaining, string manufacturer, string artist, string title)
            : base(stockID, stockRemaining, manufacturer)
        {
            Artist = artist;
            Title = title;
        }

        //overridden method to display the type of product
        public override void ShowType()
        {
            Console.WriteLine("Product Type: Music CD");
        }
    }

    //derived class for Book
    public class Book : Product
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int stockID, int stockRemaining, string manufacturer, string title, string author)
            : base(stockID, stockRemaining, manufacturer)
        {
            Title = title;
            Author = author;
        }

        //overridden method to display the type of product
        public override void ShowType()
        {
            Console.WriteLine("Product Type: Book");
        }
    }

    //derived class for Magazine
    public class Magazine : Product
    {
        public string Title { get; set; }
        public string MonthOfPublication { get; set; }

        public Magazine(int stockID, int stockRemaining, string manufacturer, string title, string monthOfPublication)
            : base(stockID, stockRemaining, manufacturer)
        {
            Title = title;
            MonthOfPublication = monthOfPublication;
        }

        //overridden method to display the type of product
        public override void ShowType()
        {
            Console.WriteLine("Product Type: Magazine");
        }
    }

    //main Program to test the functionality
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different product types
            MusicCD cd1 = new MusicCD(1, 10, "Sony", "The Beatles", "Abbey Road");
            Book book1 = new Book(2, 15, "Penguin", "1984", "George Orwell");
            Magazine mag1 = new Magazine(3, 25, "Time", "April Edition", "April");

            // Display the type of each product
            cd1.ShowType();
            book1.ShowType();
            mag1.ShowType();

            // Selling some products
            cd1.SellItem(3);
            book1.SellItem(5);
            mag1.SellItem(10);

            // Display remaining stock
            Console.WriteLine($"Remaining stock of {cd1.Title}: {cd1.StockRemaining}");
            Console.WriteLine($"Remaining stock of {book1.Title}: {book1.StockRemaining}");
            Console.WriteLine($"Remaining stock of {mag1.Title}: {mag1.StockRemaining}");
        }
    }
}
