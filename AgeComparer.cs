using System;
using studentNamespace;
using System.Collections.Generic;

namespace AgeComparerNamespace
{
  public class AgeComparer : IComparer<Student>
  {
    public int Compare(Student left, Student right)
    {
      DateTime currentDate = DateTime.Now;
      TimeSpan difference1 = currentDate.Subtract(left.Birth);
      TimeSpan difference2 = currentDate.Subtract(right.Birth);
      int age1 = (int)(difference1.TotalDays / 365.25);
      int age2 = (int)(difference1.TotalDays / 365.25);
      if(age1 > age2)
      {
        return 1;
      }
      else if(age1 < age2)
      {
        return -1;
      }
      return 1;
    }
  }
}
