using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow_School_System
{
    class Teacher
    {
        public int ID;
        public string Name;
        public string Class;
        public string Section;

        public Teacher(int ID, string Name, string Class, string Section )
        {
            this.ID = ID;
            this.Name = Name;
            this.Class = Class;
            this.Section = Section;
        }


    }
}
