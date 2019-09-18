using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCollection
{
    public static class ListClass
    {
        public static void RunProgram()
        {
            //var studentsArray = new string[]
            //{
            //    "Ariel",
            //    "Agata",
            //    "Tomek",
            //    "Michał"
            //};

            //var students = new List<string>(studentsArray);

            //Console.WriteLine("List of students: ");
            //WriteEveryone(students);

            //students.AddRange(studentsArray);
            //Console.WriteLine("List of students after AddRange: ");
            //WriteEveryone(students);

            //students.Sort();

            //Console.WriteLine("Sorted List of students: ");
            //WriteEveryone(students);

            //students.InsertRange(students.Count() / 2, studentsArray);
            //Console.WriteLine("Insert List of students: ");
            //WriteEveryone(students);

            var students = new List<Student>()
            {
                new Student("Ariel"),
                new Student("Agata"),
                new Student("Ariel"),
                new Student("Agata"),
                new Student("Tomek")
            };

            Console.WriteLine("List of students: ");
            WriteEveryone(students);

            var ariel = new Student("Ariel");

            HashSet<Student> setOfStudents = new HashSet<Student>();
            setOfStudents.Add(new Student("Ariel"));
            setOfStudents.Add(new Student("Ariel"));
            setOfStudents.Add(ariel);
            setOfStudents.Add(ariel);
            setOfStudents.Add(ariel);
            setOfStudents.Add(ariel);
            setOfStudents.Add(ariel);
            setOfStudents.Add(ariel);

            setOfStudents.UnionWith(students);

            Console.WriteLine("Set of students: ");
            WriteEveryone(setOfStudents);

            var newStudent = new Student[] { new Student("Ariel") };

            setOfStudents.UnionWith(newStudent);
            setOfStudents.UnionWith(newStudent);
            setOfStudents.UnionWith(newStudent);


            var newList = setOfStudents.ToList<Student>();


        }

        public static void WriteEveryone(IEnumerable<object> arraysToWrite)
        {
            foreach (var item in arraysToWrite)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\n");
        }

    }

    public class Student
    {
        public string Name { get; }

        public Student(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if (obj is Student)
            {
                return this.GetHashCode() == obj.GetHashCode() ? true : false;
            }

            return false;
        }

    }
}
