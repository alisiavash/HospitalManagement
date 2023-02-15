using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Ali
{
    class Nurse : Person
    {
        string nurseID;
        int yearsOfPractice;
        double shiftHours;
        int numberOfPatients;

        public Nurse(string firstname, string lastname, int departmentCode, string nurseID, int yearsOfPractice,
            double shiftHours, int numberOfPatients) : base(firstname, lastname, departmentCode)
        {
            this.nurseID = nurseID;
            this.yearsOfPractice = yearsOfPractice;
            this.shiftHours = shiftHours;
            this.numberOfPatients = numberOfPatients;
        }

        public string NurseID { get { return nurseID; } set { nurseID = value; } }
        public int YearsOfPractice { get { return yearsOfPractice; } set { yearsOfPractice = value; } }

        public double ShiftHours { get { return shiftHours; } set { shiftHours = value; } }

        public int NumberOfPatients { get { return numberOfPatients; } set { numberOfPatients = value; } }

        public string getNurseID()
        {
            return nurseID;
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
            return this.nurseID + " " + this.yearsOfPractice + " " + this.shiftHours + " " + this.numberOfPatients + " " + base.toString();
        }
    }
}
