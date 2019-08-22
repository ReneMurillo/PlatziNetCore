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

            //load School Courses
            var courses = LoadCourses(school);

            //For each course load subjects
            var subjects = LoadSubjects(courses);

            //For each course load students
            var students = LoadStudents(courses);

            modelBuilder.Entity<School>().HasData(school);
            modelBuilder.Entity<Course>().HasData(courses.ToArray());
            modelBuilder.Entity<Subject>().HasData(subjects.ToArray());
            modelBuilder.Entity<Student>().HasData(students.ToArray());
        }

        private static List<Subject> LoadSubjects(List<Course> courses)
        {
            var fullList = new List<Subject>();
            foreach (var course in courses)
            {
                var tmpSubjectList = new List<Subject> {
                    new Subject { Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Mathematics" },
                    new Subject { Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Sports" },
                    new Subject { Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Spanish" },
                    new Subject { Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Science" },
                    new Subject { Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Programming" }
                };
                fullList.AddRange(tmpSubjectList);
            }

            return fullList;
        }

        private static List<Course> LoadCourses(School school)
        {
            return new List<Course>(){
                new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "101", Journey = JourneyType.Morning, Address = "Pepito Avenue"},
                new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "201", Journey = JourneyType.Morning, Address = "Pepito Avenue"},
                new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "301", Journey = JourneyType.Afternoon, Address = "Pepito Avenue"},
                new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "401", Journey = JourneyType.Afternoon, Address = "Pepito Avenue"},
                new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "501", Journey = JourneyType.Night, Address = "Pepito Avenue"},
            };
        }

        private List<Student> LoadStudents(List<Course> courses)
        {
            var studentList = new List<Student>();
            Random rnd = new Random();
            foreach (var course in courses)
            {
                int quantRandom = rnd.Next(5,20);
                var tmpList = GenerateStudentsRandom(course, quantRandom);
                studentList.AddRange(tmpList);
            }
            return studentList;
        }
        private List<Student> GenerateStudentsRandom(Course course, int quantity)
        {
            string[] name1 = {"Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolas"};
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes"};
            string[] surname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"};

            var studentsList = from n1 in name1 
                                from n2 in name2
                                from s1 in surname
                                select new Student {Name = $"{n1} {n2} {s1}", 
                                                    CourseId = course.Id,
                                                    Id = Guid.NewGuid().ToString() };

            return studentsList.OrderBy( al => al.Id).Take(quantity).ToList();
        }
    }
}