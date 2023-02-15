using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Ali
{
    class Nurses : CollectionBase
    {
        public void add(Nurse nur)
        {
            List.Add(nur);
        }

        public Nurse this[int index]
        {
            get { return (Nurse)List[index]; }
            set { List[index] = value; }
        }
    }
}
