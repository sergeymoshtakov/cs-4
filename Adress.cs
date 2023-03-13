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
      setStreet("Sadovaya");
      setCity("Odessa");
      setStreetN(3);
      setPostalCode(1111);
    }
    public Adress(string street, int streetN, string city, int postalCode)
    {
      setStreet(street);
      setCity(city);
      setStreetN(streetN);
      setPostalCode(postalCode);
    }
    public string getStreet()
    {
      return street;
    }
    public string getCity()
    {
      return city;
    }
    public int getStreetN()
    {
      return streetN;
    }
    public int getPostalCode()
    {
      return postalCode;
    }
    public void setStreet(string street)
    {
      if(street.Length!=0)
      {
        this.street = street;
      }
      else
      {
        this.street = "NONE";
      }
    }
    public void setCity(string city)
    {
      if(city.Length!=0)
      {
        this.city = city;
      }
      else
      {
        this.city = "NONE";
      }
    }
    public void setPostalCode(int postalCode)
    {
      if(postalCode>0)
      {
        this.postalCode = postalCode;
      }
      else
      {
        this.postalCode = 1111;
      }
    }
    public void setStreetN(int streetN)
    {
      if(streetN>0)
      {
        this.streetN = streetN;
      }
      else
      {
        this.streetN = 1;
      }
    }
    public override string ToString()
    {
      return getStreet() + " " + getStreetN() + " " + getCity() + " " + getPostalCode();
    }
  }
}