using System;
using studentNamespace;
using System.Collections.Generic;

namespace NameComparerNamespace
{
    public class NameComparer : IComparer<Student>
    {
        public int Compare(Student left, Student right)
        {
            return String.Compare(left.Name, right.Name);
        }
    }
}
