using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8._6._4
{
    [Serializable]
    class Student
    {
        internal string Name { get; set; }
        internal string Group { get; set; }
        internal DateTime BirthDate { get; set; }

        internal Student(string name, string group, DateTime birthDate)
        {
            Name = name;
            Group = group;
            BirthDate = birthDate;
        }

    }
}
