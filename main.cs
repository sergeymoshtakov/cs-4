using System;
using groupNamespace;
using studentNamespace;

class Program {
  public static void Main (string[] args) {
    Group gr = new Group();
    gr.showAll();
    Student st = gr.getStudent(ref gr);
    Console.WriteLine(st);
    gr.editStudent(st);
    gr.editGroup();
    Student st1 = new Student();
    Console.WriteLine(st1);
  }
}
