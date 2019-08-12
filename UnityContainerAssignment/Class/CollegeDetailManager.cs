using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityContainerAssignment.Interface;

namespace UnityContainerAssignment
{
    class CollegeDetailManager
    {

        private ICollege _college = null;
        private IUniversity _university = null;
        public CollegeDetailManager(ICollege college, IUniversity university)
        {
            _college = college;
            _university = university;
        }

        public void CollegeDetailHandler()
        {

            _college.CollegeDetail();
            _university.UniversityDetail();
        }

    }
}
