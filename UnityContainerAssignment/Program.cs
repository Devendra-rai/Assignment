using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
namespace UnityContainerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //CollegeDetailManager collegeDetailManager = new CollegeDetailManager(new GovernmentCollege());
            //collegeDetailManager.CollegeDetailHandler();

            var container = new UnityContainer();
            container.RegisterType<ICollege , PrivateCollege>();

            container.RegisterType<IUniversity, PrivateCollege>();

            CollegeDetailManager collegeDetailManager = container.Resolve<CollegeDetailManager>();
            collegeDetailManager.CollegeDetailHandler();


            Console.ReadKey();


        }
        interface ICollege
        {

            void CollegeDetail();
        }

        interface IUniversity
        {
            void UniversityDetail();
        }

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


        class GovernmentCollege : ICollege , IUniversity
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
}
