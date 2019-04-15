using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeboonk
{
    class Section
    {
        //properties -> actually probably not needed
       private string sectionName;
        //list/array of studetns
        List<Student> Students;
       
        //cosntructor
        public Section(string SectionName )
        {
            sectionName = SectionName;
            Students = new List<Student>();
        }
       
    }
}
