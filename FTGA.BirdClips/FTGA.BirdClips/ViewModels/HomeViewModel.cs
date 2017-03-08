using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTGA.BirdClips.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public HomeViewModel()
        {

        }

        public void ShowBrowse()
        {
            
            ShowViewModel<BrowseViewModel>();
        }

        public void ShowMyLists()
        {
            ShowViewModel<MyListsViewModel>();
        }

        public void ShowInfo()
        {
            ShowViewModel<InfoViewModel>();
        }

        public void ShowResources()
        {
            ShowViewModel<ResourcesViewModel>();
        }

        public void ShowFaq()
        {
            ShowViewModel<FaqViewModel>();
        }
    }
}
