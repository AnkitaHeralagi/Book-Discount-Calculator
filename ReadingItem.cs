using System;
using System.Collections.Generic;
using System.Text;

namespace Book_Discount_Calculator
{
    internal class ReadingItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBestseller { get; set; }
        public ReadingItem(string title, string author, double price, bool bestseller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestseller = bestseller;
        }
        public double GetDiscountedPrice()
        {
            double finalPrice = Price;
            if (IsBestseller)
            {
                Console.WriteLine($"{Title} is a bestseller. Applying 10% discount.");
                finalPrice = finalPrice - (finalPrice * 0.10);
            }
            if (Price > 500)
            {
                Console.WriteLine($"{Title} is priced over 500. Applying additional 5% discount.");
                finalPrice = finalPrice - (finalPrice * 0.05);
            }
            return finalPrice;
        }
        public void ShowBookDetails()
        {
            Console.WriteLine("\nTitle: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine($"Original Price: ${Price:F2}");
            double discounted = GetDiscountedPrice();
            Console.WriteLine($"Final Discounted Price: ${discounted:F2}");
        }
    }
}
