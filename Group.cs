using System;
using System.Collections.Generic;
using studentNamespace;
using adressNamespace;
using studentEnumeratorNamespace;
using System.Collections;

namespace groupNamespace
{
    class Group : IEnumerable
    {
        private List<Student> students = new List<Student>();
        private string name;
        private string specialisation;
        private int course;
        public Group()
        {
            for (int i = 0; i < 5; i++)
            {
                this.students.Add(new Student());
            }
            Name = "fsd312";
            Specialisation = "OOP - 1";
            Course = 1;
        }
        public Group(List<Student> students)
        {
            Students = students;
            Name = "fsd312";
            Specialisation = "OOP - 1";
            Course = 1;
        }
        public Group(Group group)
        {
            Students = group.Students;
            Name = group.Name;
            Specialisation = group.Specialisation;
            Course = group.Course;
        }
      public string Name
      {
        set
        {
          name = value;
        }
        get
        {
          return name;
        }
      }
      public string Specialisation
      {
        set
        {
          specialisation = value;
        }
        get
        {
          return specialisation;
        }
      }
      public int Course
      {
        set
        {
          course = value;
        }
        get
        {
          return course;
        }
      }
      public List<Student> Students
      {
        get
        {
          return students;
        }
        set
        {
          students = value;
        }
      }

      public Student this[int index]
      {
        get
        {
          try
          {
            if(index <= 0 && index < Students.Count)
            {
              return students[index];
            }
            else
            {
              throw new IndexOutOfRangeException();
            }
          }
          catch(IndexOutOfRangeException e)
          {
            Console.WriteLine(@"{0}", e.Message);
          }
          return null;
        }
        set
        {
          try
          {
            if(index <= 0 && index < students.Count)
            {
              students[index] = value;
            }
            else
            {
              throw new IndexOutOfRangeException();
            }
          }
          catch(IndexOutOfRangeException e)
          {
            Console.WriteLine(@"{0}", e.Message);
          }
        }
      }
        public void showAll()
        {
            int i = 1;
            Console.WriteLine(Name);
            Console.WriteLine(Specialisation);
            students.Sort((left, right) => left.Surname.CompareTo(right.Surname));
            foreach (Student student in students)
            {
                Console.WriteLine(i + " " + student.Surname + " " + student.Name);
            }
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }
      public Student getStudent(ref Group g)
      {
        try
        {
          Console.WriteLine("Enter name: ");
          string name = Console.ReadLine();
          for(int i = 0; i < g.Students.Count; i++)
          {
            if(g.Students[i].Name == name)
            {
              return g.Students[i];
            }
          }
          return null;
        }
        catch (FormatException e)
        {
          Console.WriteLine("Wrong format {0}", e.Message);
          return null;
        }
      }
      public void editStudent(Student student)
      {
        try
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            student.Name = name;
            Console.WriteLine("Enter surname: ");
            string surname = Console.ReadLine();
            student.Surname = surname;
            Console.WriteLine("Enter patronim: ");
            string patronim = Console.ReadLine();
            student.Patronim = patronim;
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            student.PhoneNumber = phoneNumber;
            Console.WriteLine("Enter year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month of birth: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());
            student.Birth = new DateTime(year, month, day);
            Console.WriteLine("Enter you street: ");
            string street = Console.ReadLine();
            Console.WriteLine("Enter number of street: ");
            int streetN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter you city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter postal code: ");
            int postalCode = Convert.ToInt32(Console.ReadLine());
            student.Adress = new Adress(street, streetN, city, postalCode);
          }
          catch(FormatException e)
          {
            Console.WriteLine("Wrong format {0}", e.Message);
          }
          catch(NullReferenceException e)
          {
            Console.WriteLine("No object {0}",e.Message);
          }
        }
        public void editGroup()
        {
          try
          {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Name = name;
            Console.WriteLine("Enter specialisation: ");
            string specialisation = Console.ReadLine();
            Specialisation = specialisation;
            Console.WriteLine("Enter course: ");
            int course = Convert.ToInt32(Console.ReadLine());
            Course = course;
            for (int i = 0; i < students.Count; i++)
            {
                editStudent(students[i]);
            }
          }
          catch(FormatException e)
          {
            Console.WriteLine("Wrong format {0}", e.Message);
          }
          catch(NullReferenceException e)
          {
            Console.WriteLine("No object {0}",e.Message);
          }
        }
      public void transfer(ref Group a, ref Group b)
      {
        b.addStudent(getStudent(ref a));
      }
      public void delAll()
      {
        try
        {
          int res = 0;
          for(int i = 0; i < students.Count; i++)
          {
            for(int j = 0; j < students[i].Exams.Count; i++)
            {
              res += students[i].Exams[j];
            }
            if(res/students[i].Exams.Count != 7)
            {
              students.Remove(students[i]);
            }
          }
        }
        catch(NullReferenceException e)
        {
          Console.WriteLine("No object {0}",e.Message);
        }
        catch(IndexOutOfRangeException e)
        {
          Console.WriteLine("{0}", e.Message);
        }
      }
      public void deleteLeast()
      {
        int res = 0, min = 0;
        for(int i = 0; i < students[0].Exams.Count; i++)
        {
          min += students[0].Exams[i];
        }
        for(int i = 0; i < students.Count; i++)
        {
          for(int j = 0; j < students[i].Exams.Count; i++)
          {
            res += students[i].Exams[j];
          }
          if(min > res)
          {
            min = res;
          }
          res = 0;
        }
        for(int i = 0; i < students.Count; i++)
        {
          for(int j = 0; j < students[i].Exams.Count; i++)
          {
            res += students[i].Exams[j];
          }
          if(res == min)
          {
            students.Remove(students[i]);
          }
        }
      }
      public static bool operator ==(Group a, Group b)
      {
        return a.Students.Count == b.Students.Count;
      }
      public static bool operator !=(Group a, Group b)
      {
        return a.Students.Count != b.Students.Count;
      }

      public IEnumerator GetEnumerator() => new StudentEnumerator(students);
    }
}
