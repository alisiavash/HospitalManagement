using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Ali
{
    class Patient : Person
    {
        string patientID;
        string sectionNumber;
        double balance;
        string disChargeStatus;

        public Patient(string firstname, string lastname, int departmentCode,string patientID, string sectionNumber, double balance, string disChargeStatus) : base(firstname, lastname, departmentCode)
        {
            this.patientID = patientID;
            this.sectionNumber = sectionNumber;
            this.balance = balance;
            this.disChargeStatus = disChargeStatus;
        }

        public string PatientID { get { return patientID; } set { patientID = value; } }
        public string SectionNumber { get { return sectionNumber; } set { sectionNumber = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public string DisChargeStatus { get { return disChargeStatus; } set { disChargeStatus = value; } }

        public string getPatientID()
        {
            return patientID;
        }
        public string getSectionNumber()
        {
            return sectionNumber;
        }
        public double getBalance()
        {
            return balance;
        }
        public override string toString()
        {
            return this.patientID + " " + this.sectionNumber + " " + this.balance + " " + this.disChargeStatus + " " + base.toString();
        }

    }
}
