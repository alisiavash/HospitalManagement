using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Ali
{
    public class Person
    {
        string firstname;
        string lastname;
        int DepartmentCode;


        public Person(string firstname, string lastname, int departmentCode)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            DepartmentCode = departmentCode;
        }
        public string Firstname { 
            get { return firstname; } 
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int departmentCode
        {
            get { return DepartmentCode;}
            set { DepartmentCode = value;}
        }

        public virtual string toString()
        {
            return this.firstname + " " + this.lastname + " " + this.departmentCode;
        }


    }
}
