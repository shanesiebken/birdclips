using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Views;

using Android.Support.Design.Widget;
using FTGA.BirdClips.Core.ViewModels;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace FTGA.BirdClips.Droid.Activities
{
    [Activity(Label = "View for FirstViewModel", LaunchMode = LaunchMode.SingleTop, Icon = "@drawable/Icon", Theme ="@style/MyTheme")]
    public class HomeActivity : BaseActivity<HomeViewModel>
    {
        DrawerLayout drawerLayout;
        NavigationView navigationView;

        protected override int LayoutResource
        {
            get
            {
                return Resource.Layout.page_home_view;
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            System.Console.WriteLine("HomeActivity.OnCreate started");
            base.OnCreate(savedInstanceState);

            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.Icon);

            navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.NavigationItemSelected += (sender, e) => {
                e.MenuItem.SetChecked(true);

                switch (e.MenuItem.ItemId)
                {
                    case Resource.Id.nav_home:
                        ViewModel.ShowBrowse();
                        break;
                    case Resource.Id.nav_my_lists:
                        ViewModel.ShowMyLists();
                        break;
                    case Resource.Id.nav_info:
                        ViewModel.ShowInfo();
                        break;
                    case Resource.Id.nav_resources:
                        ViewModel.ShowResources();
                        break;
                    case Resource.Id.nav_faq:
                        ViewModel.ShowFaq();
                        break;
                }

                drawerLayout.CloseDrawers();
            };

            if (savedInstanceState == null)
            {
                ViewModel.ShowBrowse();
            }

            System.Console.WriteLine("HomeActivity.OnCreate finished");
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}
