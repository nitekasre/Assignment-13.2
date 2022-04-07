using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Assignment12_2.Models
{
    public class IndexViewModel:Controller
    {
        public List<Book> Books { get; set; }
    }
}
