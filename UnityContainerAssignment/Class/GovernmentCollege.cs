using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerAssignment.Interface;

namespace UnityContainerAssignment.Class
{
    class GovernmentCollege : ICollege, IUniversity
    {
        public void CollegeDetail()
        {
            Console.WriteLine("Government College");
        }
        public void UniversityDetail()
        {
            Console.WriteLine("Government College University");
        }

    }
}
