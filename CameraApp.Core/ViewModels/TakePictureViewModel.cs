using System.IO;
using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.PictureChooser;

namespace CameraApp.Core.ViewModels
{
    public class TakePictureViewModel : MvxViewModel
    {
        private readonly IMvxPictureChooserTask _pictureChooserTask;

        public TakePictureViewModel(IMvxPictureChooserTask pictureChooserTask)
        {
            _pictureChooserTask = pictureChooserTask;
        }

        private byte[] _pictureBytes;
        public byte[] PictureBytes
        {
            get { return _pictureBytes; }
            set { SetProperty(ref _pictureBytes, value); }
        }

        public IMvxCommand TakePictureCommand => new MvxCommand(TakePicture);

        private async void TakePicture()
        {
            var result = await _pictureChooserTask.TakePicture(1080, 100);
            var ms = new MemoryStream();
            await result.CopyToAsync(ms);
            PictureBytes = ms.ToArray();
        }

    }
}