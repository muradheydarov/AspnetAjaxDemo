using AspnetAjaxDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspnetAjaxDemo.Contexts
{
    public class SchoolDbInitialiser<T> : DropCreateDatabaseAlways<SchoolDb>
    {
        protected override void Seed(SchoolDb context)
        {
            Group group = new Group()
            {
                Name = "P407",
            };

            Group group1 = new Group()
            {
                Name = "P408",
            };

            Student student = new Student()
            {
                Name = "Student1",
                Email = "email@mail.com",
                Surname = "Surname1",
                Group = group
            };
            Student student2 = new Student()
            {
                Name = "Student2",
                Email = "email2@mail.com",
                Surname = "Surname2",
                Group = group
            };
            Student student3 = new Student()
            {
                Name = "Student3",
                Email = "email@mail.com",
                Surname = "Surname3",
                Group = group
            };
            Student student4 = new Student()
            {
                Name = "Student4",
                Email = "email@mail.com",
                Surname = "Surname4",
                Group = group1
            };
            Student student5 = new Student()
            {
                Name = "Student5",
                Email = "email@mail.com",
                Surname = "Surname5",
                Group = group1
            };
            Student student6 = new Student()
            {
                Name = "Student6",
                Email = "email@mail.com",
                Surname = "Surname6",
                Group = group1
            };

            context.Groups.Add(group);
            context.Groups.Add(group1);

            context.Students.Add(student);
            context.Students.Add(student2);
            context.Students.Add(student3);
            context.Students.Add(student4);
            context.Students.Add(student5);
            context.Students.Add(student6);

            base.Seed(context);
        }
    }
}