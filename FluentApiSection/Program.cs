using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FluentApiSection
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();


            // ADDING data

            //var course = new Course
            //{
            //    Name = "New Course",
            //    Description = "New Description",
            //    FullPrice = 19.95f,
            //    Level = 1,
            //    Author = new Author { Id = 1, Name = "Mosh Hamedani" }
            //};
            // The ID will probably not be 1, since there's already a record with ID 1 in the DB
            // ID 1 is already Mosh... to reference that entry instead of creating another... use a foreign key approach.. just use the ID
            //var course = new Course
            //{
            //    Name = "New Course",
            //    Description = "New Description",
            //    FullPrice = 19.95f,
            //    Level = 1,
            //    AuthorId = 1
            //};

            // OR you could even get the author object from the DB, and assign to a variable, and then just reference in that new course object...
            // but this is probably a bad idea for a web app... unless that author object is already in your context

            //context.Courses.Add(course);

            //context.SaveChanges();



            // UPDATE data
            //var course = context.Courses.Find(4);  // .Single(c => c.Id == 4);
            //course.Name = "New name";
            //course.AuthorId = 2;

            //context.SaveChanges();



            // DELETE data
            //var course = context.Courses.Find(6);   // .Single(c => c.Id == 6);
            //context.Courses.Remove(course);
            //context.SaveChanges();
            // cascade delete is on for courses and tags.. but not for authors

            //var author = context.Authors.Include(a => a.Courses).Single(a => a.Id == 2);
            //context.Courses.RemoveRange(author.Courses);
            //context.Authors.Remove(author);
            //context.SaveChanges();



            // Change tracker - can also use watch window to watch the 'entry' variable
            //var entries = context.ChangeTracker.Entries();
            //foreach (var entry in entries)
            //    Console.WriteLine(entry.State);


            // LINQPad is a GREAT tool to test your LINQ expressions!!!
            // Jeremy --> you should probably get it...




        }
    }
}
