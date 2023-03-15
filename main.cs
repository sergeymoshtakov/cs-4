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
    st1.setBirth(2432,2442,4242);
    st1.setName("");
    st1.setSurname("");
    st1.setNumber("325423525523523");
  }
}
