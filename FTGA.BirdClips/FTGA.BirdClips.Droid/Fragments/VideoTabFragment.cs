using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using FTGA.BirdClips.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platform;
using MvvmCross.Binding.Droid.BindingContext;
using Android.Views;
using Android.OS;

namespace FTGA.BirdClips.Droid.Fragments
{
    public class VideoTabFragment : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.fragment_video_tab, null);
        }
    }
}