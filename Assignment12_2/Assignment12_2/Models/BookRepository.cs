using System.Collections.Generic;
namespace Assignment12_2.Models
{
    public class BookRepository : IBookRepository
    {
        public List<Book> Books { get; set; }

        public Book GetBook(int? id)
        {
            if (id == null)
            {
                return null;
            }

            else
            {
                return Books.Find(x => x.Id == id);
            }
        }

        public List<Book> InitializeData() //dummy data
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 001,
                    Title = "The Invisible Man",
                    Author = "Ralph Ellison",
                    Description = "The narrator of Invisible Man is a nameless young black man who moves in a 20th-century United States where reality is surreal and who can survive only through pretense. Because the people he encounters \"see only my surroundings themselves,or figments of their imagination\" he is effectively invisible.",
                    ImgName ="The Invisible Man.jpg"
                    
                },
                new Book()
                {
                    Id = 002,
                    Title="Half of a Yellow Sun",
                    Author="Chimamanda Ngozi Adichie",
                    Description="Epic, ambitious, and triumphantly realized, Half of a Yellow Sun is a remarkable novel about moral responsibility, the end of colonialism, ethnic allegiances, class and race–and the ways in which love can complicate them all.",
                    ImgName="Half of a yellow Sun.jpg"
                },
                new Book()
                {
                    Id=003,
                    Title="Helium",
                    Author="Rudy Francisco",
                    Description="Helium is filled with work that is simultaneously personal and political, blending love poems, self-reflection, and biting cultural critique on class, race and gender into an unforgettable whole. Ultimately, Rudy's work rises above the chaos to offer a fresh and positive perspective of shared humanity and beauty.",
                    ImgName="Helium.jpg"
                },
                new Book()
                {
                    Id=004,
                    Title="Where the Sidewalk Ends",
                    Author="Shel Silverstein",
                    Description="'Where the Sidewalk Ends' is a three-stanza poem that depicts the adult world as something harsh and demanding, in contrast to a more childlike mentality that can provide a break from the responsibilities and pressures of being an adult.",
                    ImgName="Where the Sidewalk Ends.jpg"
                },
                new Book()
                {
                    Id=005,
                    Title="C Sharp For Dummies",
                    Author="Deepali K. =D",
                    Description="I wouldn't exactly call myself a dummy, but it wouldn't cause me any harm if I took some time to read this book =D",
                    ImgName="C Sharp for Dummies.jpg"
                },
                new Book()
                {
                    Id=006,
                    Title="X-Men",
                    Author="Kim Lee",
                    Description="My favorite comic series of all time. I always try to include it in my assignments.",
                    ImgName="X-Men.jpg"
                }
            };
            return Books;
        } 
    }
}
