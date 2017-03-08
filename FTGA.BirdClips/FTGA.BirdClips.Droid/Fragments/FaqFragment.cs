using Android.Views;

using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using FTGA.BirdClips.Core.ViewModels;
//using MvvmCross.Droid.FullFragging.Fragments;
using MvvmCross.Droid.Support.V4;

namespace FTGA.BirdClips.Droid.Fragments
{
    [MvxFragment(typeof(HomeViewModel), Resource.Id.content_frame)]
    [Register("ftga.birdclips.droid.fragments.FaqFragment")]
    public class FaqFragment : MvxFragment<FaqViewModel>
    {
        public FaqFragment()
        {
            RetainInstance = true;
        }

        public override View OnCreateView(LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.fragment_faq, null);

            return view;
        }
    }
}