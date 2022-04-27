// See https://aka.ms/new-console-template for more information
using Library;

Console.WriteLine("Hello, World!");

var bookRepository = new BooksRepository();

var harryPotter = new Book();
harryPotter.Name = "Harry Potter";


for (int i = 1; i < 200; i++)
{
    harryPotter.Pages.Add(new Page { Content = $"Page nr {i}" }); 
}

//bookRepository.AddBook(harryPotter);

bookRepository.DeleteBook(harryPotter.Name);



