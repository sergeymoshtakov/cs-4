using System;
using System.Collections.Generic;
using studentNamespace;

namespace groupNamespace
{
    class Group
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
            setName("fsd312");
            setSpecialisation("OOP - 1");
            setCourse(1);
        }
        public Group(List<Student> students)
        {
            setStudents(students);
            setName("fsd312");
            setSpecialisation("OOP - 1");
            setCourse(1);
        }
        public Group(Group group)
        {
            setStudents(group.getStudents());
            setName(group.getName());
            setSpecialisation(group.getSpecialisation());
            setCourse(group.getCourse());
        }
        public void setStudents(List<Student> students)
        {
            this.students = students;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSpecialisation(string specialisation)
        {
            this.specialisation = specialisation;
        }
        public void setCourse(int course)
        {
            this.course = course;
        }
        public int getCourse()
        {
            return course;
        }
        public string getSpecialisation()
        {
            return specialisation;
        }
        public string getName()
        {
            return name;
        }
        public List<Student> getStudents()
        {
            return students;
        }
        public void showAll()
        {
            int i = 1;
            Console.WriteLine(getName());
            Console.WriteLine(getSpecialisation());
            students.Sort((left, right) => left.getSurname().CompareTo(right.getSurname()));
            foreach (Student student in students)
            {
                Console.WriteLine(i + " " + student.getSurname() + " " + student.getName());
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
          for(int i = 0; i < g.getStudents().Count; i++)
          {
            if(g.getStudents()[i].getName() == name)
            {
              return g.getStudents()[i];
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
            student.setName(name);
            Console.WriteLine("Enter surname: ");
            string surname = Console.ReadLine();
            student.setSurname(surname);
            Console.WriteLine("Enter patronim: ");
            string patronim = Console.ReadLine();
            student.setPatronim(patronim);
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            student.setNumber(phoneNumber);
            Console.WriteLine("Enter year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month of birth: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());
            student.setBirth(year, month, day);
            Console.WriteLine("Enter you street: ");
            string street = Console.ReadLine();
            Console.WriteLine("Enter number of street: ");
            int streetN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter you city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter postal code: ");
            int postalCode = Convert.ToInt32(Console.ReadLine());
            student.setAdress(street, streetN, city, postalCode);
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
            setName(name);
            Console.WriteLine("Enter specialisation: ");
            string specialisation = Console.ReadLine();
            setSpecialisation(specialisation);
            Console.WriteLine("Enter course: ");
            int course = Convert.ToInt32(Console.ReadLine());
            setCourse(course);
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
            for(int j = 0; j < students[i].getExams().Count; i++)
            {
              res += students[i].getExams()[j];
            }
            if(res/students[i].getExams().Count != 7)
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
        for(int i = 0; i < students[0].getExams().Count; i++)
        {
          min += students[0].getExams()[i];
        }
        for(int i = 0; i < students.Count; i++)
        {
          for(int j = 0; j < students[i].getExams().Count; i++)
          {
            res += students[i].getExams()[j];
          }
          if(min > res)
          {
            min = res;
          }
          res = 0;
        }
        for(int i = 0; i < students.Count; i++)
        {
          for(int j = 0; j < students[i].getExams().Count; i++)
          {
            res += students[i].getExams()[j];
          }
          if(res == min)
          {
            students.Remove(students[i]);
          }
        }
      }
      public static bool operator ==(Group a, Group b)
      {
        return a.getStudents().Count == b.getStudents().Count;
      }
      public static bool operator !=(Group a, Group b)
      {
        return a.getStudents().Count != b.getStudents().Count;
      }
    }
}
