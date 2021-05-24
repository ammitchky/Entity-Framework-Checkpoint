using System.Collections.Generic;

namespace App.Models
{
    public class Student
    {

        public enum SchoolYear
        {
            Freshman, Sophomore, Junior, Senior
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public SchoolYear Classification { get; set; }
        public List<Grade> GradeList { get; set; }
    }
}
