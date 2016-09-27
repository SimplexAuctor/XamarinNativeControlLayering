using Android.Widget;
using NativeControlLayering;
using NativeControlLayering.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(VideoPlayer), typeof(VideoPlayerRenderer))]
namespace NativeControlLayering.Droid
{
    class VideoPlayerRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            var videoView = new VideoView(Forms.Context);
            var uri = Android.Net.Uri.Parse("/storage/extSdCard/video1.mpg");
            videoView.SetVideoURI(uri);
            videoView.Start();
            SetNativeControl(videoView);
        }
    }
}