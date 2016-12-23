using System.Web.Http;
using Microsoft.Practices.Unity;
using Shop.Repository;
using Shop.Services;
using Unity.WebApi;

namespace Shop
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IProductRepository, ProductRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}