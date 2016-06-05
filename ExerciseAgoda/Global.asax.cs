using ExerciseAgoda.Repository;
using SimpleInjector;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleInjector.Integration.Web.Mvc;


namespace ExerciseAgoda
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            var container = new Container();
            container.Register<IHotelRepository, HotelRepository>(Lifestyle.Transient);
            container.Verify();
            
            DependencyResolver.SetResolver(
            new SimpleInjectorDependencyResolver(container));
        }
    }
}
