using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Evoting_Application.Service;
namespace Evoting_Application
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<AdminServiceData>();
            container.RegisterType<CandidateDataAccess>();
            container.RegisterType<ResultServiceAcces>();
            container.RegisterType<DocumentDataAccess>();
            container.RegisterType<RegisterDataAccess>();
            container.RegisterType<VoterDataAccess>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}