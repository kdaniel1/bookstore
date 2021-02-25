using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineBookstore.Models
{
    //this ensures that the DB is populated and loads any pending migrations.
    public class SeedData
    {
    public static void EnsurePopulated (IApplicationBuilder application)
        {
        OnlineBookContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<OnlineBookContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        //this if loop loads the seed data into the website if there isn't already any context.books data loaded
        if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                       Title = "Les Miserables",
                       AuthorFirst = "Victor",
                       AuthorLast = "Hugo",
                       Publisher = "Signet",
                       ISBN = "978-0451419439",
                       Classification = "Fiction",
                       Category = "Classic",
                       Price = "$9.95",
                       Page = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = "$14.58",
                        Page = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = "$21.54",
                        Page = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = "$11.61",
                        Page = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = "$13.33",
                        Page = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Non-Fiction",
                        Category = "Historical Fiction",
                        Price = "$15.95",
                        Page = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = "$14.99",
                        Page = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = "$21.66",
                        Page = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = "$29.16",
                        Page = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = "$15.03",
                        Page = 624
                    }
                    ,

                      new Book
                      {
                          Title = "Poor Economics",
                          AuthorFirst = "Abhihit",
                          AuthorMiddle = "V.",
                          AuthorLast = "Banerjee",
                          Publisher = "PublicAffairs",
                          ISBN = "978-055332345",
                          Classification = "Non-Fiction",
                          Category = "Economics",
                          Price = "$14.99",
                          Page = 320
                      },
                        new Book
                        {
                            Title = "Politics is for Power",
                            AuthorFirst = "Eitan",
                            AuthorLast = "Hersh",
                            Publisher = "Schribner",
                            ISBN = "978-055332345",
                            Classification = "Non-Fiction",
                            Category = "Political Science",
                            Price = "$16.72",
                            Page = 275
                        },
                          new Book
                          {
                              Title = "A Stolen Life",
                              AuthorFirst = "Jacyee",
                              AuthorLast = "Dugard",
                              Publisher = "Simon&Schuster Paperbacks",
                              ISBN = "978-055339572",
                              Classification = "Non-Fiction",
                              Category = "True Crime",
                              Price = "$16.97",
                              Page = 314
                          }
                    );

                context.SaveChanges(); 

            }
        }
    }
}


