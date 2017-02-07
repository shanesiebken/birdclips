using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTheGroundApp.BirdClips.Core.ViewModels
{
    public class MasterDetailHostViewModel
        : MvxViewModel
    {
        private MasterViewModel _master = new MasterViewModel();
        public MasterViewModel Master
        {
            get { return _master; }
            set { _master = value; RaisePropertyChanged(() => Master); }
        }
    }
}
