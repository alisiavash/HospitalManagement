using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_Ali
{
    class Doctors : CollectionBase
    {
        public void add(Doctor doc)
        {
            List.Add(doc);
        }
      
        public Doctor this[int index]
        {
            get { return (Doctor)List[index]; }
            set { List[index] = value; }
        }
    }
}
