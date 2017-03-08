using FTGA.BirdClips.Core.Models;
using FTGA.BirdClips.Core.Services;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTGA.BirdClips.Core.ViewModels
{
    public class BirdViewModel : MvxViewModel
    {
        public Bird Bird { get; set; }

        private IBirdDataService _birdDataService { get; set; }

        public BirdViewModel(IBirdDataService birdDataService)
        {
            _birdDataService = birdDataService;
        }

        public void Init(int birdId)
        {
            Bird = _birdDataService.Get(birdId); ;
        }
    }
}
