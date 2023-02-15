using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Ali
{
    public class Hospital
    {
        public Hospital() { }
        static Patients patientsList = new Patients();
        static Doctors doctorsList = new Doctors();
        static Nurses nursesList = new Nurses();

        public bool patientVerifier(string patienID)
        {
            bool flag = false;
            foreach (Patient pat in patientsList)
            {
                if (pat.getPatientID() == patienID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool doctorVerifier(string doctorID)
        {
            bool flag = false;

            foreach (Doctor doc in doctorsList)
            {
                if (doc.getDoctorID() == doctorID)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public bool nurseVerifier(string nurseID)
        {
            bool flag = false;

            foreach (Nurse nur in nursesList)
            {
                if (nur.getNurseID() == nurseID)
                {
                    flag = true;
                }
            }
            return (flag);
        }
    }

}
