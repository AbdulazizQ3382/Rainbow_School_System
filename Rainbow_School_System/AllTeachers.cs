using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rainbow_School_System
{
    class AllTeachers
    {
        public List<Teacher> Teachers;
        // You need here to specify the path of the file you gonna read from it.
        public string projectDirectory = Directory.GetParent("Rainbow_School_System").Parent.Parent.Parent.FullName;

        public AllTeachers()
        {
            Teachers = new List<Teacher>();
        }

        public void ReadDataFromFile()
        {
            String line;
            try
            {
                // to get the absolute path of the project in os
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(projectDirectory+"/teachers.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    Teachers.Add(ToTeacherType(line));
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The file will be created in the current directory");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("There is somthing wrong with the format of the data, make sure the format should be in the file:");
                Console.WriteLine("[teacher id] [teacher name] [teacher class] [teacher section]");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
        }
        public async void WriteDataToFile()
        {
            string[] teachersStr = new string[Teachers.Count()];
            int counter = 0;
            foreach(Teacher i in Teachers)
            {
                teachersStr[counter++] = i.ToString();
            }
            using (StreamWriter writer = new StreamWriter(projectDirectory+"/teachers.txt"))
            {
                
               foreach(string i in teachersStr)
                {
                    writer.WriteLine(i);
                }
            }

        }

        // the data we get from the text file are string so we need to conver it to a Teacher object
        public Teacher ToTeacherType(string rawData)
        {
            string[] splited = rawData.Split(' ');
            int id = Convert.ToInt32(splited[0]);
            return new Teacher(id, splited[1], splited[2], splited[3]);
        }
        public void AddTeacher(Teacher data)
        {
            if(data == null)
            {
                Console.WriteLine("Data should be not null");
                return;
            }

            Teacher dataRetrived = GetTeacher(data.ID);
            
            // to check if data exists or not
            if (dataRetrived == null)
            {

                Teachers.Add(data);
                WriteDataToFile();
            }
            else
            {
                Console.WriteLine("Data already exists");
                return;
            }
            

        }

        public Teacher GetTeacher(int ID)
        {
            return Teachers.Find((x) => x.ID == ID);
        }

        public void UpdateTeacher(int ID)
        {
            Teacher data = GetTeacher(ID);
            // int index = Teachers.FindIndex(data);
        }

        public void Display()
        {
            foreach(Teacher t in Teachers)
            {
                Console.WriteLine($"teacher id: {t.ID}, teacher name: {t.Name}, teacher class: {t.Class}, teacher section: {t.Section}");
            }
        }

    }
}
