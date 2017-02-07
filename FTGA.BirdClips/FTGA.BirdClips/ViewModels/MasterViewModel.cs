using MvvmCross.Core.ViewModels;

namespace FTGA.BirdClips.Core.ViewModels
{
    public class MasterViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }
    }
}
