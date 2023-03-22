using System;

namespace adressNamespace
{
  public class Adress
  {
    private string street;
    private int streetN;
    private string city;
    private int postalCode;
    public Adress()
    {
      Street = "Sadovaya";
      StreetN = 3;
      City = "Odessa";
      PostalCode = 1111;
    }
    public Adress(string street, int streetN, string city, int postalCode)
    {
      Street = street;
      StreetN = streetN;
      City = city;
      PostalCode = postalCode;
    }
    public string Street
    {
      get
      {
        return street;
      }
      set
      {
        if(value.Length!=0)
        {
          street = value;
        }
        else
        {
          street = "NONE";
        }
      }
    }
    public string City
    {
      get
      {
        return city;
      }
      set
      {
        if(value.Length!=0)
        {
          city = value;
        }
        else
        {
          city = "NONE";
        }
      }
    }
    public int PostalCode
    {
      set
      {
        if(value>0)
        {
          postalCode = value;
        }
        else
        {
          postalCode = 1111;
        }
      }
      get
      {
        return postalCode;
      }
    }
    public int StreetN
    {
      set
      {
        if(value>0)
        {
          streetN = value;
        }
        else
        {
          streetN = 1;
        }
      }
      get
      {
        return streetN;
      }
    }
    public override string ToString()
    {
      return Street + " " + StreetN + " " + City + " " + PostalCode;
    }
  }
}
