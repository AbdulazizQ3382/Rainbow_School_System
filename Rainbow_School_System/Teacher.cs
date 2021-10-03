using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow_School_System
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Section { get; set; }

        public Teacher(int ID, string Name, string Class, string Section )
        {
            this.ID = ID;
            this.Name = Name;
            this.Class = Class;
            this.Section = Section;
        }

        public override string ToString()
        {
            return $"{this.ID} {this.Name} {this.Class} {this.Section}";
        }

    }
}
