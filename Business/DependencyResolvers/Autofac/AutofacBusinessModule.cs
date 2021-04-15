using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.Firebase;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            /*
             * builder.RegisterType<CarManager>().As<ICarService>();
             */
            builder.RegisterType<QueryExampleOneManager>().As<IQueryExampleOneService>();
            builder.RegisterType<QueryExampleTwoManager>().As<IQueryExampleTwoService>();
            builder.RegisterType<QueryExampleThreeManager>().As<IQueryExampleThreeService>();

            builder.RegisterType<FirebaseLocationDal>().As<ILocationDal>();
            builder.RegisterType<FirebaseOperationDal>().As<IOperationDal>();
            
            
            builder.RegisterType<FirebaseOperationTypeOneDal>().As<IOperationTypeOneDal>();
            builder.RegisterType<FirebaseOperationTypeTwoDal>().As<IOperationTypeTwoDal>();
            builder.RegisterType<FirebaseOperationTypeThreeDal>().As<IOperationTypeThreeDal>();


            //Aspects Load
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
