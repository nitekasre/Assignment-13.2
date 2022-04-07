using System.Collections.Generic;
namespace Assignment12_2.Models
{
    public interface IBookRepository
    {
        List<Book> Books { get; set; }
        List<Book> InitializeData();
        Book GetBook (int? id);
    }
}
