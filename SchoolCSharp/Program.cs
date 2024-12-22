using System;

namespace SchoolCSharp
{
    class Program{
        public static void Main()
        {
            Teacher teacher = new Teacher();
            teacher.Print();
            
            Teacher teacher1 = new Teacher("john","Chemistry",50,"Male","+962793113911","zaid@simplify9.com","amman");
            teacher1.Print();
            
            
            Student student1 = new Student();
            student1.Print();
            
            Teacher teacher2 = new Teacher("zoe","English",35,"Female","+962793113511","zoe@simplify9.com","amman");
            teacher2.Print();
            
            //Human human = new Human();
            //human.Name = "John";
            
            
        }
    }    
}

