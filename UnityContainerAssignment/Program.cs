using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityContainerAssignment.Class;
using UnityContainerAssignment.Interface;
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
      
       
    }
}
