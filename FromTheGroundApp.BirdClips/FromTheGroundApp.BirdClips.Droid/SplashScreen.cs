using Android.App;
using Android.Content.PM;
using FTGA.BirdClips.Droid.Resources;
using MvvmCross.Droid.Views;

namespace FromTheGroundApp.BirdClips.Droid
{
    [Activity(
        Label = "Bird Clips"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
