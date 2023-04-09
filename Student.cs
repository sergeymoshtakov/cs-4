using System;
using System.Collections.Generic;
using adressNamespace;
using personNamespace;
using System.Linq;
using markEnumNamespace;

namespace studentNamespace
{
    public class Student : Person, IComparable
    {
        private List<int> tests = new List<int>();
        private List<int> homeTasks = new List<int>();
        private List<int> exams = new List<int>();
        public Student(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number, List<int> tests, List<int> homeTasks, List<int> exams) : base(name, surname, patronim, year, month, day, street, streetN, city, postalCode, number)
        {
            this.SetTests(tests);
            this.SetTasks(homeTasks);
            this.SetExams(exams);
            Console.WriteLine("Main c-tor");
        }
        public Student(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number) : this(name, surname, patronim, year, month, day, street, streetN, city, postalCode, number, new List<int>(), new List<int>(), new List<int>())
        {
            Console.WriteLine("Param c-tor");
        }
        public Student() : this("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>(), new List<int>(), new List<int>())
        {
            Console.WriteLine("Default c-tor");
        }
        public void SetTasks(List<int> tasks)
        {
            this.homeTasks = tasks;
        }
        public void SetTests(List<int> tests)
        {
            this.tests = tests;
        }
        public void SetExams(List<int> exams)
        {
            this.exams = exams;
        }
        public List<int> Tests
        {
            get
            {
                return tests;
            }
            set
            {
                tests = value;
            }
        }
        public List<int> HomeTasks
        {
            get
            {
                return homeTasks;
            }
            set
            {
                exams = value;
            }
        }
        public List<int> Exams
        {
            get
            {
                return exams;
            }
            set
            {
                exams = value;
            }
        }
        public override string ToString()
        {
            string testStr = "\n", taskStr = "", examStr = "";
            try
            {
                foreach (var test in tests)
                {
                  testStr = test + " ";
                  if(test >= (int) MarkEnum.Good)
                  {
                    testStr += "Good\n";
                  }
                  else if(test <= (int) MarkEnum.Satisfactory)
                  {
                    testStr += "Satisfactory\n";
                  }
                  else if(test >= (int) MarkEnum.Bad)
                  {
                    testStr += "Bad\n";
                  }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("No array list {0}", e.Message);
            }
            try
            {
                foreach (var task in homeTasks)
                {
                  taskStr = task + " ";
                  if(task >= (int) MarkEnum.Good)
                  {
                    taskStr += "Good\n";
                  }
                  else if(task <= (int) MarkEnum.Satisfactory)
                  {
                    taskStr += "Satisfactory\n";
                  }
                  else if(task >= (int) MarkEnum.Bad)
                  {
                    taskStr += "Bad\n";
                  }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("No array list {0}", e.Message);
            }
            try
            {
                foreach (var exam in exams)
                {
                  examStr = exam + " ";
                  if(exam >= (int) MarkEnum.Good)
                  {
                    examStr += "Good\n";
                  }
                  else if(exam <= (int) MarkEnum.Satisfactory)
                  {
                    examStr += "Satisfactory\n";
                  }
                  else if(exam >= (int) MarkEnum.Bad)
                  {
                    examStr += "Bad\n";
                  }
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("No array list {0}", e.Message);
            }
            return Name + "\n" + Surname + "\n" + Patronim + "\n" + Birth + "\n" + Adress + "\n" + PhoneNumber + testStr + taskStr + examStr;
        }
        public static bool operator ==(Student a, Student b)
        {
            int sum1 = 0, sum2 = 0, length1 = 0, length2 = 0;
            try
            {
                foreach (var test in a.Tests)
                {
                    sum1 += test;
                    length1++;
                }
                foreach (var task in a.HomeTasks)
                {
                    sum1 += task;
                    length1++;
                }
                foreach (var exam in a.Exams)
                {
                    sum1 += exam;
                    length1++;
                }
                foreach (var test in b.Tests)
                {
                    sum2 += test;
                    length2++;
                }
                foreach (var task in b.HomeTasks)
                {
                    sum2 += task;
                    length2++;
                }
                foreach (var exam in b.Exams)
                {
                    sum2 += exam;
                    length2++;
                }
                if ((length1 == 0) && (length2 == 0))
                {
                    return true;
                }
                return sum1 / length1 == sum2 / length2;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            return false;
        }
        public static bool operator !=(Student a, Student b)
        {
            int sum1 = 0, sum2 = 0, length1 = 0, length2 = 0;
            try
            {
                foreach (var test in a.Tests)
                {
                    sum1 += test;
                    length1++;
                }
                foreach (var task in a.HomeTasks)
                {
                    sum1 += task;
                    length1++;
                }
                foreach (var exam in a.Exams)
                {
                    sum1 += exam;
                    length1++;
                }
                foreach (var test in b.Tests)
                {
                    sum2 += test;
                    length2++;
                }
                foreach (var task in b.HomeTasks)
                {
                    sum2 += task;
                    length2++;
                }
                foreach (var exam in b.Exams)
                {
                    sum2 += exam;
                    length2++;
                }
                if ((length1 == 0) && (length2 == 0))
                {
                    return false;
                }
                return sum1 / length1 != sum2 / length2;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            return false;
        }
        public int CompareTo(object o)
        {
            Student temp = o as Student;
            int sum1 = this.HomeTasks.ToArray().Sum(), sum2 = temp.HomeTasks.ToArray().Sum(), length1 = this.HomeTasks.Count, length2 = temp.HomeTasks.Count;
            if ((sum1 / length1) > (sum2 / length2)) return 1;
            if ((sum1 / length1) < (sum2 / length2)) return -1;
            return 0;
        }
    }
}
