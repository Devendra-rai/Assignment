using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerAssignment.Interface;

namespace UnityContainerAssignment.Class
{
    class SemiGovernmentCollege : ICollege, IUniversity
    {

        public void CollegeDetail()
        {
            Console.WriteLine("Semi Government College");
        }

        public void UniversityDetail()
        {
            Console.WriteLine("RDVV University");
        }

    }
}
