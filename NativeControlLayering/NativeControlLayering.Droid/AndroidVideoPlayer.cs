using System;
using Android.Widget;
using NativeControlLayering;
using NativeControlLayering.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(AndroidVideoPlayer))]
namespace NativeControlLayering.Droid
{
    class AndroidVideoPlayer : IVideoPlayer
    {
        VideoView videoView;

        public AndroidVideoPlayer()
        {
            videoView = new VideoView(Forms.Context);
        }

        public View GetView()
        {
            return videoView.ToView();
        }

        public void BringToFront()
        {
            videoView.BringToFront();
            videoView.RequestLayout();
        }

        public void Invalidate()
        {
            videoView.Invalidate();
            videoView.RequestLayout();
        }

        public void SetFile(String filename)
        {
            var uri = Android.Net.Uri.Parse(filename);
            videoView.SetVideoURI(uri);
            videoView.Start();
        }
    }
}