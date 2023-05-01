using System;
using studentNamespace;
using System.Collections.Generic;
using NameComparerNamespace;
using AgeComparerNamespace;
using groupNamespace;
using System.IO;


class Program {
  public delegate bool Comparer(object obj1, object obj2);

  public static class Sorter
  {
    public static void Sort(List<object> st, Comparer del)
    {
      for(int i=0; i < st.Count; i++)
      {
        for(int j = i + 1; j < st.Count; j++)
        {
          if (del(st[j], st[i]))
          {
            object temporary = st[i];
            st[i] = st[j];
            st[j] = temporary;
          }
        }
      }
    }
  }
  
  public static void Main (string[] args) {
    Student s1 = new Student("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>() {12,12,12}, new List<int>() {10,9,10}, new List<int>() {10,9,10});
    Student s2 = new Student("Petr", "Petrov", "Petrovich", 1823, 5, 7, "Gogola", 28, "Nikolaev", 2141, "+380-800-333-35-35", new List<int>() {12,12,12}, new List<int>() {12,12,12}, new List<int>() {10,9,10});
    Student s3 = new Student("Sergey", "Sergeev", "Sergeevich", 1793, 4, 3, "Shevchenko", 28, "Kyiv", 2141, "+380-333-735-35-35", new List<int>() {12,12,12}, new List<int>() {10,3,6,2}, new List<int>() {10,9,10});
    Student s4 = new Student("Anton", "Antonov", "Antonovich", 2020, 5, 7, "Franka", 28, "Sumy", 2432, "+380-800-735-21-21", new List<int>() {12,12,12}, new List<int>() {10,7,2,1,10}, new List<int>() {10,9,10});
    Student s5 = new Student("Dmitri", "Dmitriev", "Dmitrievich", 2020, 5, 3, "Solnechnaya", 28, "Lvov", 2234, "+380-323-735-35-35", new List<int>() {12,12,12}, new List<int>() {8,3,5,10}, new List<int>() {10,9,10});
    List<Student> myList = new List<Student>() {s1, s2, s3, s4, s5};
    // List<object> myList1 = new List<object>() {s1, s2, s3, s4, s5};
    
    // foreach(var stud in myList)
    // {
    //   Console.WriteLine(stud);
    // }

    // Console.WriteLine("Sorted version: \n");
    
    // myList.Sort();
    // foreach(var stud in myList)
    // {
    //   Console.WriteLine(stud);
    // }
    
    // Group gr = new Group();
    // gr.addStudent(s1);
    // gr.addStudent(s2);
    // gr.addStudent(s3);
    // gr.addStudent(s4);
    // gr.addStudent(s5);
    // Console.WriteLine("Foreach test:");
    // foreach (Student st in gr)
    // {
    //   Console.WriteLine(st);
    // }
    // Student s = new Student();
    // gr.addStudent(s);
    // Console.WriteLine(gr[0]);
    // Aspirant a = new Aspirant();
    // Console.WriteLine(a);
    // gr.showAll();
    // Student st = gr.getStudent(ref gr);
    // Console.WriteLine(st);
    // gr.editStudent(st);
    // gr.editGroup();
    // Student st1 = new Student();
    // // Console.WriteLine(st1);
    // // st1.setBirth(2432,2442,4242);
    // // st1.setName("");
    // // st1.setSurname("");
    // // st1.setNumber("325423525523523");
    // Student st2 = new Student();
    // if(st1 == st2)
    // {
    //   Console.WriteLine("Yes students are equal");
    // }
    // else
    // {
    //   Console.WriteLine("No students are not equal");
    // }
    // Group gr1 = new Group();
    // if(gr == gr1)
    // {
    //   Console.WriteLine("Yes groups are equal");
    // }
    // else
    // {
    //   Console.WriteLine("No groups are not equal");
    // }
    // gr1.addStudent(st2);
    // if(gr == gr1)
    // {
    //   Console.WriteLine("Yes groups are equal");
    // }
    // else
    // {
    //   Console.WriteLine("No groups are not equal");
    // }
  //   myList.Sort(new NameComparer());
  //   Console.WriteLine("Name sort: ");
  //   foreach(var stud in myList)
  //   {
  //     Console.WriteLine(stud);
  //   }

  //   myList.Sort(new AgeComparer());
  //   Console.WriteLine("Age sort: ");
  //   foreach(var stud in myList)
  //   {
  //     Console.WriteLine(stud);
  //   }

  //   Sorter.Sort(myList1, delegate(object o1, object o2)
  //   {
  //     Student left = o1 as Student;
  //     Student right = o2 as Student;
  //     if (left == null || right == null)
  //     {
  //       throw new Exception("The value is null");
  //     }
  //     return ((Student)o1).CompareTo(((Student)o2)) > 0;
  //   });
  //   Console.WriteLine("Mark sort: ");
  //   foreach(var stud in myList1)
  //   {
  //     Console.WriteLine(stud);
  //   }
    SortedDictionary<string, Student> dict1 = new SortedDictionary<string, Student>();
    dict1.Add("od001",s1);
    dict1.Add("od002",s2);
    dict1.Add("ki001",s3);
    dict1.Add("ki002",s4);
    dict1.Add("od003",s5);
    foreach (KeyValuePair<string, Student> item in dict1)
    {
      Console.WriteLine("{0}: {1}", item.Key, item.Value.Name);
    }
    string path = "note1.txt";
    using (StreamWriter writer = new StreamWriter(path, true))
    {
      foreach(var stud in myList)
      {
        writer.WriteLine(stud);
      }
    }
  }
}
