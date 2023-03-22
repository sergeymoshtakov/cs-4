using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using adressNamespace;

namespace studentNamespace
{
  public class Student
  {
    private string name;
    private string surname;
    private string patronim;
    private DateTime birth;
    private Adress adress;
    private string phoneNumber;
    private List<int> tests = new List<int>();
    private List<int> homeTasks = new List<int>();
    private List<int> exams = new List<int>();
    public Student() : this("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>(), new List<int>(), new List<int>())
    {
      Console.WriteLine("Default c-tor");
    }
    public Student(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number) : this(name, surname, patronim, year, month, day, street, streetN, city, postalCode, number, new List<int>(),new List<int>(),new List<int>())
    {
      Console.WriteLine("Param c-tor");
    }
    public Student(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number, List<int> tests, List<int> homeTasks, List<int> exams)
    {
      Name = name;
      Surname = surname;
      Patronim = patronim;
      Birth = new DateTime(year, month, day);
      Adress = new Adress(street, streetN, city, postalCode);
      PhoneNumber = number;
      Tests = tests;
      HomeTasks = homeTasks;
      Exams = exams;
      Console.WriteLine("Main c-tor");
    }
    public string Name
    {
      set
      {
        try
        {
          if(value.Length>0)
          {
            name = value;
          }
          else
          {
            throw new Exception("Wrong name");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0}", e.Message);
        }
      }
      get
      {
        return name;
      }
    }
    public string Surname
    {
      set
      {
        try
        {
          if(value.Length>0)
          {
            surname = value;
          }
          else
          {
            throw new Exception("Wrong surname");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0}", e.Message);
        }
      }
      get
      {
        return surname;
      }
    }
    public string Patronim
    {
      set
      {
        try
        {
          if(value.Length>0)
          {
            patronim = value;
          }
          else
          {
            throw new Exception("Wrong patronim");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0}", e.Message);
        }
      }
      get
      {
        return patronim;
      }
    }
    public string PhoneNumber
    {
      set
      {
        try
        {
          if(Regex.IsMatch(value, @"((380|\+380)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}"))
          {
            phoneNumber = value;
          }
          else
          {
            throw new Exception("Wrong number");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0}", e.Message);
        }
        finally
        {
          Console.WriteLine("Number is good");
        }
      }
      get
      {
        return phoneNumber;
      }
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
    public Adress Adress
    {
      get
      {
        return adress;
      }
      set
      {
        adress = new Adress(value.Street, value.StreetN, value.City, value.PostalCode);
      }
    }
    public DateTime Birth
    {
      get
      {
        return birth;
      }
      set
      {
        try
        {
          if((value.Year>0)&&(value.Month>0)&&(value.Month<13)&&(value.Day>0)&&(value.Day<32))
          {
            birth = new DateTime(value.Year, value.Month, value.Day);
          }
          else
          {
            throw new Exception("Wrong date");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0}", e.Message);
        }
      }
    }
    public override string ToString()
    {
      string testStr="\n", taskStr="", examStr="";
      try
      {
        foreach(var test in tests)
        {
          testStr = test + "\n";
        }
      }
      catch(NullReferenceException e)
      {
        Console.WriteLine("No array list {0}", e.Message);
      }
      try
      {
        foreach(var task in homeTasks)
        {
          taskStr = task + "\n";
        }
      }
      catch(NullReferenceException e)
      {
        Console.WriteLine("No array list {0}", e.Message);
      }
      try
      {
        foreach(var exam in exams)
        {
          examStr = exam + "\n";
        }
      }
      catch(NullReferenceException e)
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
        foreach(var test in a.Tests)
        {
          sum1 += test;
          length1++;
        }
        foreach(var task in a.HomeTasks)
        {
          sum1 += task;
          length1++;
        }
        foreach(var exam in a.Exams)
        {
          sum1 += exam;
          length1++;
        }
        foreach(var test in b.Tests)
        {
          sum2 += test;
          length2++;
        }
        foreach(var task in b.HomeTasks)
        {
          sum2 += task;
          length2++;
        }
        foreach(var exam in b.Exams)
        {
          sum2 += exam;
          length2++;
        }
        if((length1 == 0) && (length2==0))
        {
          return true;
        }
        return sum1/length1 == sum2/length2;
      }
      catch(NullReferenceException e)
      {
        Console.WriteLine("{0}", e.Message);
      }
      catch(DivideByZeroException e)
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
        foreach(var test in a.Tests)
        {
          sum1 += test;
          length1++;
        }
        foreach(var task in a.HomeTasks)
        {
          sum1 += task;
          length1++;
        }
        foreach(var exam in a.Exams)
        {
          sum1 += exam;
          length1++;
        }
        foreach(var test in b.Tests)
        {
          sum2 += test;
          length2++;
        }
        foreach(var task in b.HomeTasks)
        {
          sum2 += task;
          length2++;
        }
        foreach(var exam in b.Exams)
        {
          sum2 += exam;
          length2++;
        }
        if((length1 == 0) && (length2==0))
        {
          return false;
        }
        return sum1/length1 != sum2/length2;
      }
      catch(NullReferenceException e)
      {
        Console.WriteLine("{0}", e.Message);
      }
      catch(DivideByZeroException e)
      {
        Console.WriteLine("{0}", e.Message);
      }
      return false;
    }
  }
}
