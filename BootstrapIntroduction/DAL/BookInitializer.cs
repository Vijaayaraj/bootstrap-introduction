using BootstrapIntroduction.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BootstrapIntroduction.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var author = new Author
            {
                Biography = "...",
                FirstName = "Jamie",
                LastName = "Munro"
            };

            var books = new List<Book>
            {
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl= "http://ecx.images-amazon.com/images/I/512IS3Q3ywL._SX403_BO1,204,203,200_.jpg",
                    Isbn = "233452345435",
                    Synopsis = "...",
                    Title = "Getting Started with Knockout.js for .NET Developers"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl= "http://ecx.images-amazon.com/images/I/512IS3Q3ywL._SX403_BO1,204,203,200_.jpg",
                    Isbn = "233452345435",
                    Synopsis = "...",
                    Title = "Getting Started with Knockout.js for .NET Developers"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl= "http://ecx.images-amazon.com/images/I/512IS3Q3ywL._SX403_BO1,204,203,200_.jpg",
                    Isbn = "233452345435",
                    Synopsis = "...",
                    Title = "Getting Started with Knockout.js for .NET Developers"
                },
                new Book
                {
                    Author = author,
                    Description = "...",
                    ImageUrl= "http://ecx.images-amazon.com/images/I/512IS3Q3ywL._SX403_BO1,204,203,200_.jpg",
                    Isbn = "233452345435",
                    Synopsis = "...",
                    Title = "Getting Started with Knockout.js for .NET Developers"
                }
            };

            books.ForEach(b => context.Books.Add(b));

            context.SaveChanges();            
        }
    }
}