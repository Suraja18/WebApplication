using eLearning.Data.Enums;
using eLearning.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eLearning.Data
{
    public class Adddbinitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Database names
                //Books
                if(!context.Books.Any())
                {
                    context.Books.AddRange(new List<Books>()
                    {
                        new Books()
                        {
                            Name = "ASP.Net",
                            Picture = "https://dotnethow.net/wp-content/uploads/2023/02/visual-studio-v1705-dnh-blog.jpg",
                            Description = "The first step to test the performance feature would be to update Visual Studio to the latest version, which currently is V 17.5.0",
                            Price = "$25.57",
                            Publishdate = DateTime.Now.AddDays(-10)
                },
                        new Books()
                        {
                            Name = "C Sharp",
                            Picture = "https://dotnethow.net/wp-content/uploads/2023/03/efcore-filter-dnh-blog.png",
                            Description = "The first step to test the performance feature would be to update Visual Studio to the latest version, which currently is V 17.5.0",
                            Price = "$28.90",
                            Publishdate = DateTime.Now.AddDays(-15)
                        }
                    }); 
                    context.SaveChanges();
                }
                //Writer
                if (!context.Writers.Any())
                {
                    context.Writers.AddRange(new List<Writer>()
                    { 
                        new Writer()
                        {
                            Profilepic = "https://tse2.mm.bing.net/th?id=OIP._LFsWQepN7j9k0N2Bn_32gHaH_&pid=Api&P=0",
                            FullName = "Samir Shrestha",
                            Bio = "A Professional At C sharp and Asp dot net",
                            Gender = Gender.Male
                        }
                    });
                    context.SaveChanges();


                }
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            Profilepic = "https://tse2.mm.bing.net/th?id=OIP._LFsWQepN7j9k0N2Bn_32gHaH_&pid=Api&P=0",
                            FullName = "Samir Shrestha",
                            Password = "Password",
                            Bio = "A Professional At C sharp and Asp dot net",
                            Gender = Gender.Male
                        }
                    });
                    context.SaveChanges();


                }
                //Books and Writer
                if (!context.Book_Writers.Any())
                {
                    context.Book_Writers.AddRange(new List<Book_Writer>()
                    {
                        new Book_Writer()
                        {
                            books_Id = 1,
                            writer_Id= 1
                        },
                        new Book_Writer()
                        {
                            books_Id = 2,
                            writer_Id= 1
                        }
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
