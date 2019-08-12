using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerAssignment.Interface;

namespace UnityContainerAssignment.Class
{
    class PrivateCollege : ICollege, IUniversity
    {
        public void CollegeDetail()
        {
            Console.WriteLine("Private college");

        }
        public void UniversityDetail()
        {
            Console.WriteLine("RGPV Bhopal");
        }

    }
}
