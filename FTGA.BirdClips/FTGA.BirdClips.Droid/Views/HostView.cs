using Android.App;
using Android.OS;
using FTGA.BirdClips.Core.ViewModels;
using FTGA.BirdClips.Droid.Fragments;
using MvvmCross.Droid.FullFragging;
using MvvmCross.Droid.FullFragging.Views;

namespace FTGA.BirdClips.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class HostView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HostView);

            var master = (MasterView)FragmentManager.FindFragmentById(Resource.Id.masterview);
            master.ViewModel = ((HostViewModel)ViewModel).Master;
        }
    }
}
