using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class goblini
    {

        private string name;
        private int id;
        private int age;
        private int grade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }


        public goblini(string name, int id, int age, int grade)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.grade = grade;
        }
       

    }
}
