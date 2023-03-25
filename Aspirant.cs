using System;
using studentNamespace;
using System.Collections.Generic;

namespace aspirantNamespace
{
  class Aspirant : Student
  {
    private string theme;
    public Aspirant(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number, List<int> tests, List<int> homeTasks, List<int> exams, string theme) : base(name, surname, patronim, year, month, day, street, streetN, city, postalCode, number, tests, homeTasks, exams)
    {
      Theme = theme;
    }
    public Aspirant() : this("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>(), new List<int>(), new List<int>(), "qrqqwfqw")
    {
      
    }
    public string Theme
    {
      set
      {
        try
        {
          if(value.Length != 0)
          {
            this.theme = value;
          }
          else
          {
            throw new Exception("Wrong theme");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine(@"{e.Message}");
        }
      }
      get
      {
        return theme;
      }
    }
    public override string ToString()
    {
      return base.ToString() + "\nTheme: " + Theme;
    }
  }
}
