// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace CameraApp.iOS.Views
{
    [Register ("TakePictureView")]
    partial class TakePictureView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView PictureView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TakePictureButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (PictureView != null) {
                PictureView.Dispose ();
                PictureView = null;
            }

            if (TakePictureButton != null) {
                TakePictureButton.Dispose ();
                TakePictureButton = null;
            }
        }
    }
}