﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor() : base()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
            hiredStudents = 0;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("who represents {0}\nand hired {1} students so far.", company, hiredStudents);
        }

        public void Hire()
        {
            ++hiredStudents;
        }

        public override void GetGoal()
        {
            Console.WriteLine("{0} Hire brilliant junior software develeopers.\n", text);
        }
    }
}
