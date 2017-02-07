using FromTheGroundApp.BirdClips.Core.ViewModels;
using FTGA.BirdClips.Droid.Fragments;
using FTGA.BirdClips.Droid.Resources;

namespace FTGA.BirdClips.Droid.Views
{
    [Activity(Label = "View for MasterViewModel")]
    public class MasterDetailHostView : MvxFragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MasterDetailHostView);

            var master = (MasterView) FragmentManager.FindFragmentById(Resource.Id.master);
            master.ViewModel = ((MasterDetailHostViewModel)ViewModel).Master;
        }
    }
}
