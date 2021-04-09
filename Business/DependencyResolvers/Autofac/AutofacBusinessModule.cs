using Autofac;
using Business.Abstract;
using Business.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Business
            builder.RegisterType<QueryService>().As<IQueryService>();

        }
    }
}