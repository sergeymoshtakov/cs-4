using System;
using System.Collections;
using System.Collections.Generic;
using studentNamespace;

namespace studentEnumeratorNamespace
{
  public class StudentEnumerator : IEnumerator
  {
    private List<Student> students = new List<Student>();
    private int position = -1;
    public StudentEnumerator(List<Student> students) => this.students = students;

    public object Current
    {
      get
      {
        if (position == -1 || position >= students.Count)
          throw new ArgumentException();
        return students[position];
      }
    }
    public bool MoveNext()
    {
      if (position < students.Count - 1)
      {
        position++;
        return true;
      }
      else
        return false;
    }
    public void Reset() => position = -1;
  }
}
