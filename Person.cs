using System;
using adressNamespace;
using System.Text.RegularExpressions;

namespace personNamespace
{
  public class Person
  {
    private string name;
    private string surname;
    private string patronim;
    private DateTime birth;
    private Adress adress;
    private string phoneNumber;
    private int age;
    private double height;
    private double weight;
    private string eyeColor;
    public Person(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number, int age, double height, double weight, string eyeColor)
    {
      Name = name;
      Surname = surname;
      Patronim = patronim;
      Birth = new DateTime(year, month, day);
      Adress = new Adress(street, streetN, city, postalCode);
      PhoneNumber = phoneNumber;
      Age = age;
      Height = height;
      Weight = weight;
      EyeColor = eyeColor;
    }
    public Person(string name, string surname, string patronim, int year, int month, int day, string street, int streetN, string city, int postalCode, string number) : this(name, surname, patronim, year, month, day, street, streetN, city, postalCode, number, 1, 1, 1, "") {}
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
    public int Age
    {
      set
      {
        age = value;
      }
      get
      {
        return age;
      }
    }
    public double Weight
    {
      set
      {
        weight = value;
      }
      get
      {
        return weight;
      }
    }
    public double Height
    {
      set
      {
        height = value;
      }
      get
      {
        return height;
      }
    }
    public string EyeColor
    {
      set
      {
        eyeColor = value;
      }
      get
      {
        return eyeColor;
      }
    }
  }
}
