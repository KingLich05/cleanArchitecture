using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using ConsoleApp1;

using (ApplicationContext db = new ApplicationContext())
{
    
    User human1 = new User { Name = "Sultan", Age = 33 };
    User human2 = new User { Name = "Tom", Age = 26 };
    User human3 = new User { Name = "Shrek", Age = 13 };
    User human4 = new User { Name = "Sula", Age = 64 };
    User human5 = new User { Name = "Anton", Age = 32 };
    User human6 = new User { Name = "Miras", Age = 25 };
    User human7 = new User { Name = "kto to", Age = 29 };
 /*
    db.Users.AddRange(human1,human2,human3,human4,human5,human6, human7);
    db.SaveChanges();*/
    
    List<Book> books = new List<Book>
    {
        new Book {Name = "Путь Абая", UserId = human1.Id},
        new Book {Name = "Бегущий за ветром", UserId = human2.Id},
        new Book {Name = "Раскол", UserId = human3.Id},
        new Book {Name = "кровью и честью", UserId = human4.Id},
        new Book {Name = "Путешествие к центру Земли", UserId = human7.Id},
        new Book {Name = "Python для чайников", UserId = human7.Id},
        new Book {Name = "По ту сторону портала", UserId = human6.Id },
        new Book {Name = "Преступление и наказание", UserId = human6.Id},
        new Book {Name = "Богатый папа бедный папа", UserId = human5.Id},
        new Book {Name = "Великий Гэтсби", UserId = human3.Id},
        new Book {Name = "7 навыков высокоэффективных людей", UserId = human1.Id },
        new Book {Name = "Тысяча сияющих солнц", UserId = human2.Id}
    };
    /*
    db.Books.AddRange(books);
    db.SaveChanges();*/
    var book = db.Books.Include(book => book.User).ToList();
    
    foreach (Book b in book)
    {
        Console.WriteLine($"Название книги: {b.Name} - Прочитал: {b.User.Name}");
    }
}






