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
      setName(name);
      setSurname(surname);
      setPatronim(patronim);
      setBirth(year, month, day);
      setAdress(street, streetN, city, postalCode);
      setNumber(number);
      setTests(tests);
      setHomeTasks(homeTasks);
      setExams(exams);
      Console.WriteLine("Main c-tor");
    }
    public string getName()
    {
      return name;
    }
    public string getSurname()
    {
      return surname;
    }
    public string getPatronim()
    {
      return patronim;
    }
    public DateTime getBirth()
    {
      return birth;
    }
    public Adress getAdress()
    {
      return adress;
    }
    public string getPhone()
    {
      return phoneNumber;
    }
    public List<int> getTests()
    {
      return tests;
    }
    public List<int> getHometasks()
    {
      return homeTasks;
    }
    public List<int> getExams()
    {
      return exams;
    }
    public void setName(string name)
    {
      try
      {
        if(name.Length>0)
        {
          this.name = name;
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
    public void setSurname(string surname)
    {
      try
      {
        if(surname.Length>0)
        {
          this.surname = surname;
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
    public void setPatronim(string patronim)
    {
      try
      {
        if(patronim.Length>0)
        {
          this.patronim = patronim;
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
    public void setBirth(int year, int month, int day)
    {
      try
      {
        if((year>0)&&(month>0)&&(month<13)&&(day>0)&&(day<32))
        {
          this.birth = new DateTime(year,month,day);
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
    public void setNumber(string phoneNumber)
    {
      try
      {
        if(Regex.IsMatch(phoneNumber, @"((380|\+380)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}"))
        {
          this.phoneNumber = phoneNumber;
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
    public void setAdress(string street, int streetN, string city, int postalCode)
    {
      adress = new Adress(street, streetN, city, postalCode);
    }
    public void setTests(List<int> tests)
    {
      this.tests = tests;
    }
    public void setHomeTasks(List<int> homeTasks)
    {
      this.homeTasks = homeTasks;
    }
    public void setExams(List<int> exams)
    {
      this.exams = exams;
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
      return getName() + "\n" + getSurname() + "\n" + getPatronim() + "\n" + getBirth() + "\n" + getAdress() + "\n" + getPhone() + testStr + taskStr + examStr;
    }
  }
}
