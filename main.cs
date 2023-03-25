using System;
using groupNamespace;
using studentNamespace;
using aspirantNamespace;

class Program {
  public static void Main (string[] args) {
    Group gr = new Group();
    Student s = new Student();
    gr.addStudent(s);
    Console.WriteLine(gr[0]);
    Aspirant a = new Aspirant();
    Console.WriteLine(a);
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
