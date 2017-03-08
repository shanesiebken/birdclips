using Android.Views;

using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using FTGA.BirdClips.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platform;
using MvvmCross.Binding.Droid.BindingContext;

namespace FTGA.BirdClips.Droid.Fragments
{
    [MvxFragment(typeof(HomeViewModel), Resource.Id.content_frame)]
    [Register("ftga.birdclips.droid.fragments.BrowseFragment")]
    public class BrowseFragment : MvxFragment<BrowseViewModel>
    {
        /*public BrowseFragment()
        {
            this.ViewModel = Mvx.IocConstruct<BrowseViewModel>();
            if(this.ViewModel == null)
            {
                System.Console.WriteLine("BrowseFragment ViewModel = NULL");
            }
            RetainInstance = true;
            //System.Console.WriteLine("Birds: "+ViewModel.Birds.Count);
        }*/

        public override View OnCreateView(LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.fragment_browse, null);

            return view;
        }
    }
}