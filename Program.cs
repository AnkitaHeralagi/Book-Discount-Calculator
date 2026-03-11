using System;

class Program
{
    static void Main()
    {
        ReadingItem[] books =
        {
            new ReadingItem("Atomic Habits", "James Clear", 600, true),
            new ReadingItem("Clean Code", "Robert C. Martin", 450, false),
            new ReadingItem("Deep Learning", "Ian Goodfellow", 520, false),
            new ReadingItem("Rich Dad Poor Dad", "Robert Kiyosaki", 300, true)
        };

        foreach (ReadingItem book in books)
        {
            book.ShowBookDetails();
        }
    }
}