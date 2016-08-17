using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace CameraApp.iOS.Views
{
    public partial class TakePictureView : MvxViewController
    {
        public TakePictureView() : base("TakePictureView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            var set = this.CreateBindingSet<TakePictureView, Core.ViewModels.TakePictureViewModel>();
            //set.Bind(TextField).To(vm => vm.Hello);
            set.Apply();
        }
    }
}