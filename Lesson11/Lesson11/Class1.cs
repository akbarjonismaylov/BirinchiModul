using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class School
    {
        public string NameSchool { get; set; }
        public int NUmberSchool { get; set; }
        public string AdressSchool { get; set; }
        public int Capacity { get; set; }
        public int CurrentStudentCount { get; set; }

        public override string ToString()
        {
            return $"Name: {NameSchool}, Number: {NUmberSchool}, Address: {AdressSchool}, Capacity: {Capacity}, Current: {CurrentStudentCount}";
        }
    }
}
