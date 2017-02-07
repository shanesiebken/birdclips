using MvvmCross.Platform.IoC;

namespace FromTheGroundApp.BirdClips.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.MasterViewModel>();
        }
    }
}
