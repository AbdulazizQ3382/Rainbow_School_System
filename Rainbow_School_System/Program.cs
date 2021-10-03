using System;
using System.IO;

namespace Rainbow_School_System
{
    class Program
    {
        static void Main(string[] args)
        {
        

            AllTeachers at = new AllTeachers();
            at.ReadDataFromFile();
            at.Display();

            Teacher t1 = new Teacher(32, "Mohammad", "English", "9796");
            at.AddTeacher(t1);

        }
    }
}
