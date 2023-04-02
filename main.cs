using System;
using studentNamespace;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Student s1 = new Student("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>() {12,12,12}, new List<int>() {10,9,10}, new List<int>() {10,9,10});
    Student s2 = new Student("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>() {12,12,12}, new List<int>() {12,12,12}, new List<int>() {10,9,10});
    Student s3 = new Student("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>() {12,12,12}, new List<int>() {10,3,6,2}, new List<int>() {10,9,10});
    Student s4 = new Student("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>() {12,12,12}, new List<int>() {10,7,2,1,10}, new List<int>() {10,9,10});
    Student s5 = new Student("Ivan", "Ivanov", "Ivanovich", 2000, 5, 7, "Pushkina", 28, "Odessa", 2141, "+380-800-735-35-35", new List<int>() {12,12,12}, new List<int>() {8,3,5,10}, new List<int>() {10,9,10});
    List<Student> myList = new List<Student>() {s1, s2, s3, s4, s5};
    // myList.Sort();
    foreach(var stud in myList)
    {
      Console.WriteLine(stud);
    }
    // Group gr = new Group();
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
  }
}
