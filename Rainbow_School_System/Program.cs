using System;
using System.IO;

namespace Rainbow_School_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rainbow school system where you can manage the teachers data.");

            Console.WriteLine("Choose what you want to do (from 1 to 4).");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("| 1) Display all teachers Data                |");
            Console.WriteLine("| 2) Search for a teacher depending on the ID |");
            Console.WriteLine("| 3) Add a Teacher Data                       |");
            Console.WriteLine("| 4) Updata a teacher data.                   |");
            Console.WriteLine("-----------------------------------------------");
            try
            {
                char choice = Convert.ToChar(Console.ReadLine());
                AllTeachers teachers = new AllTeachers();
            
                switch (choice)
                {
                    case '1':
                        Console.WriteLine("1) Display all teachers Data ");
                        teachers.Display();
                        break;

                    case '2':
                        Console.WriteLine("2) Search for a teacher depending on the ID");
                        Console.WriteLine("Enter the ID for the teacher you want.");
                        string teacherID = Console.ReadLine();
                        Teacher teacherData = teachers.GetTeacher(teacherID);
                        if (teacherData == null)
                        {
                            Console.WriteLine("There is no teacher with the current ID");
                        }
                        else
                        {
                            Console.WriteLine($" Teacher ID: {teacherData.ID}, Teacher Name: {teacherData.Name}, Teacher class: {teacherData.Class}, Teacher section: {teacherData.Section}.");
                        }
                        break;
                    case '3':
                        Console.WriteLine("3) Add a Teacher Data ");
                        Console.WriteLine("Please Enter the required information for the teacher:");
                        Console.WriteLine("* Teacher ID.");
                        Console.WriteLine("* Teacher Name.");
                        Console.WriteLine("* Teacher class.");
                        Console.WriteLine("* Teacher Section.");
                        string dataID = Console.ReadLine();
                        string dataName = Console.ReadLine();
                        string dataClass = Console.ReadLine();
                        string dataSection = Console.ReadLine();
                        teachers.AddTeacher(new Teacher(dataID, dataName, dataClass, dataSection));
                        break;
                    case '4':

                        Console.WriteLine("4) Updata a teacher data. ");
                        Console.WriteLine("Please Enter the Updated information for the teacher:");
                        Console.WriteLine("* Teacher ID to seacrch for the teacher you want to update his data.");
                        Console.WriteLine("* Teacher Name.");
                        Console.WriteLine("* Teacher class.");
                        Console.WriteLine("* Teacher Section.");
                        string IDsearch = Console.ReadLine();
                        string updatedName = Console.ReadLine();
                        string updatedClass = Console.ReadLine();
                        string updatedSection = Console.ReadLine();
                        teachers.UpdateTeacher(IDsearch, new Teacher(IDsearch, updatedName, updatedClass, updatedSection));
                        break;

                    default:
                        Console.WriteLine("This choice is not available at this moment");
                        break;
                }
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter only a valid format input");
            }
            catch(Exception e)
            {
                Console.WriteLine("Somthing went wrong: "+e.Message);
            }
            
        }
    }
}
