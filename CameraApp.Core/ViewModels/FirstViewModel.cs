using MvvmCross.Core.ViewModels;

namespace CameraApp.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

        public IMvxCommand GoToTakePictureScreenCommand => new MvxCommand(() => ShowViewModel<TakePictureViewModel>());

    }
}
