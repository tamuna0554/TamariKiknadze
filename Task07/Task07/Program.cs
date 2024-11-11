// See https://aka.ms/new-console-template for more information
using Task07;



//უნდა შექმნათ ბიბლიოთეკა, სადაც გექნებათ კლასი Library და კლასი Book, 
//    ბიბლიოთეკის კლასი მოიცავს წიგნებს და აქვს მეთოდები წიგნების დამატებაზე, 
//    წაშლასა და მოძებნაზე. ასევე ამ კლასს უნდა შეეძლოს ყველა მასში შემავალი წიგნის დაბეჭდვა და უნდა ინახავდეს რაოდენობაზე მონაცემს, 
//    უფრო დეტალურად წერია დაბლა

//1) შექმენით კონსოლური აპლიკაცია

//2)დაამატეთ კლასი Book, რომელსაც ექნება property ები:
//Title
//Author
//Year 
//(სურვილისამებრ დაამატეთ სხვა ველებიც)
//3)შექმენით კლასი Library.  კლასში უნდა გვქონდეს private ველი რომელიც იქნება Book ობიექტების მასივი
//3.1)Library-ს უნდა ქონდეს მეთოდი წიგნების სიმრავლის დაბეჭდვა (სახელი : ავტორი)
//3.2)უნდა გვქონდეს Count property რომელიც დაგვიბრუნებს წიგნების რაოდენობას ბიბლიოთეკაში
//3.3)უნდა გვქონდეს AddBook მეთოდი, რომელიც დაამატებს ბიბლიოთეკაში წიგნებს
//3.4)RemoveBook მეთოდი რომელიც წაშლის ბიბლიოთეკიდან წიგნებს
//3.5)FindBook მეთოდი რომელიც მოძებნის ბიბლიოთეკაში წიგნებს (წიგნის სახელის მიხედვით  და დაბრუნებს სიას)
//რადგანაც ერთი და იგივე სახელი შეიძლება ბევრ წიგნს ერქვას.
//4)თქვენი შექმნილი კლასები დააინიციალიზირეთ(შექმენით) და გატესტეთ ბიბლიოთეკის ფუნქციონალი.

class Program
{
    static void Main()
    {
  
        Library library = new Library();

    
        Book book1 = new Book("book1", "title1", 2001);
        Book book2 = new Book("book2", "title2", 2018);
        Book book3 = new Book("book3", "title3", 2005);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);


        Console.WriteLine("\nbibliotekashi arsebuli wignebi:");
        library.PrintBooks();

  
        Console.WriteLine("\nmodzebnialia wigni");
        var foundBooks = library.FindBook("book1");
        foreach (var book in foundBooks)
        {
            Console.WriteLine($"- {book.Title} by {book.Author} ({book.Year})");
        }

       
        Console.WriteLine("\nwignis washla:");
        library.RemoveBook("book1");

        
        Console.WriteLine("\ndarchenili wignebi:");
        library.PrintBooks();

  
        Console.WriteLine($"\nwignebis raodenoba: {library.Count}");
    }


}