using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.FullFragging;
using FTGA.BirdClips.Core.ViewModels;
using FTGA.BirdClips.Droid.Fragments;

namespace FTGA.BirdClips.Droid.Activities
{
    [Activity]
    public class BirdTabActivity : MvxTabsFragmentActivity
    {
        public BirdViewModel BirdViewModel
        {
            get { return (BirdViewModel)base.ViewModel; }
        }

        public BirdTabActivity() : base(Resource.Layout.page_bird_tab_view, Resource.Id.actualtabcontent) { }

        protected override void AddTabs(Bundle args)
        {
            AddTab<InfoTabFragment>("InfoTab", "Information", args, BirdViewModel);
            AddTab<VideoTabFragment>("VideoTab", "Videos", args, BirdViewModel);
            AddTab<NotesTabFragment>("NotesTab", "Notes & Sightings", args, BirdViewModel);
        }


    }
}