using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Firebase;
using DataAccess.Concrete.GoogleMap;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            /*
             * builder.RegisterType<CarManager>().As<ICarService>();
             */
            builder.RegisterType<QueryExampleOneManager>().As<IQueryExampleOneService>();
            builder.RegisterType<QueryExampleTwoManager>().As<IQueryExampleTwoService>();
            builder.RegisterType<QueryExampleThreeManager>().As<IQueryExampleThreeService>();
            builder.RegisterType<QueryExampleLocationManager>().As<IQueryExampleLocationService>();
            builder.RegisterType<GoogleCoordinateDal>().As<ICoordinateDal>();


            builder.RegisterType<FirebaseOperationLocationDal>().As<IOperationLocationDal>();
            builder.RegisterType<FirebaseOperationTypeOneDal>().As<IOperationTypeOneDal>();
            builder.RegisterType<FirebaseOperationTypeTwoDal>().As<IOperationTypeTwoDal>();
            builder.RegisterType<FirebaseOperationTypeThreeDal>().As<IOperationTypeThreeDal>();

        }
    }
}