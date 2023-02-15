using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Ali
{
    class Doctor : Person
    {
        string doctorID;
        int yearsOfPractice;
        double shiftHours;

        public Doctor(string firstname, string lastname, int departmentCode, string doctorID, 
            int yearsOfPractice, double shiftHours) : base(firstname, lastname, departmentCode)
        {
            this.doctorID = doctorID;
            this.yearsOfPractice = yearsOfPractice;
            this.shiftHours = shiftHours;
        }

        public string DoctorID { get { return doctorID; } set { doctorID = value; } }
        public int YearsOfPractice { get { return yearsOfPractice; } set { yearsOfPractice = value; } }

        public double ShiftHours { get { return shiftHours; } set { shiftHours = value; } }

        public string getDoctorID()
        {
            return doctorID;
        }

        public int getYearsOfPractice()
        {
            return yearsOfPractice;
        }

        public double getShiftHours()
        {
            return shiftHours;
        }

        public override string toString()
        {
            return this.doctorID + " " + this.yearsOfPractice + " " + this.shiftHours + " "+ base.toString();
        }
    }
}
