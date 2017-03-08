using FTGA.BirdClips.Core.Models;
using FTGA.BirdClips.Core.Services;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;

namespace FTGA.BirdClips.Core.ViewModels
{
    public class BrowseViewModel : MvxViewModel
    {
        private IBirdDataService _birdService { get; set; }

        public BrowseViewModel(IBirdDataService birdService)
        {
            _birdService = birdService;
            Birds = _birdService.GetAll();
        }

        private List<Bird> _birds;
        public List<Bird> Birds
        {
            get { return _birds; }
            set { _birds = value; RaisePropertyChanged(() => Birds); }
        }

        private MvxCommand<Bird> _showBird;
        public ICommand ShowBirdCommand
        {
            get
            {
                _showBird = _showBird ?? new MvxCommand<Bird>(bird => DoShowBird(bird.Id));
                return _showBird;
            }
            
        }

        private void DoShowBird(int birdId)
        {
            ShowViewModel<BirdViewModel>(birdId);
        }
    }
}