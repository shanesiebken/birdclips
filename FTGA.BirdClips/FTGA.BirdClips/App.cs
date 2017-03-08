using Akavache;
using MvvmCross.Platform.IoC;

namespace FTGA.BirdClips.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();


            //BlobCache.ApplicationName = "BirdClips";

            //Console.WriteLine("App starting");
            RegisterAppStart<ViewModels.HomeViewModel>();
        }
    }
}
