using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_study
{
    internal class MelatAsefaKiros
    {
        //field 
        int x;
        //autho property 
        int y { get; set; }
        int z;

        //prppety 
       public int Z {
            get { return z; }
            set { z = value;  }
        }

        public void Mele(int x) {
            this.x = x;
        }
    }
}
