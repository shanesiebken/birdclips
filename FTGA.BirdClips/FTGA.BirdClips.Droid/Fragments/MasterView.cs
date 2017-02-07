using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.FullFragging.Fragments;
using MvvmCross.Binding.Droid.BindingContext;

namespace FTGA.BirdClips.Droid.Fragments
{
    [Activity(Label = "Master Fragment")]
    public class MasterView : MvxFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.MasterView, null);
        }
    }
}