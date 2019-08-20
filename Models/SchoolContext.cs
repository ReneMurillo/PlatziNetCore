using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace platziNetCore.Models
{
    public class SchoolContext: DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses {get; set; }
        public DbSet<Student> Students {get; set; }
        public DbSet<Evaluation> Evaluations {get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var school = new School();
            school.FundationYear = 2005;
            school.Id = Guid.NewGuid().ToString();
            school.Name = "PlatziSchool";
            school.City = "Bogota";
            school.Address = "Avenue always leave";
            school.Country = "Colombia";
            school.SchoolType = SchoolType.HighSchool;

            modelBuilder.Entity<School>().HasData(school);
            modelBuilder.Entity<Subject>().HasData(
                    new Subject { Name = "Mathematics", Id = Guid.NewGuid().ToString()},
                    new Subject { Name = "Sports", Id = Guid.NewGuid().ToString()},
                    new Subject { Name = "Spanish", Id = Guid.NewGuid().ToString()},
                    new Subject { Name = "Science", Id = Guid.NewGuid().ToString()},
                    new Subject { Name = "Programming", Id = Guid.NewGuid().ToString()}
            );
            modelBuilder.Entity<Student>().HasData(GenerateStudentsRandom().ToArray());
        }

        private List<Student> GenerateStudentsRandom()
        {
            string[] name1 = {"Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolas"};
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes"};
            string[] surname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"};

            var studentsList = from n1 in name1 
                                from n2 in name2
                                from s1 in surname
                                select new Student {Name = $"{n1} {n2} {s1}", Id = Guid.NewGuid().ToString() };

            return studentsList.OrderBy( al => al.Id).ToList();
        }
    }
}