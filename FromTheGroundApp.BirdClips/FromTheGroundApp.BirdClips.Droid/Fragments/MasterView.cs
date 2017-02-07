using FTGA.BirdClips.Droid.Resources;
using MvvmCross.Droid.FullFragging.Fragment;

namespace FTGA.BirdClips.Droid.Fragments
{
    public class MasterView : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.MasterView, null);
        }
    }
}