using Xamarin.Forms;

namespace NativeControlLayering
{
    class NCHVideoPlayer : ContentView
    {
        IVideoPlayer videoPlayer;

        public NCHVideoPlayer()
        {
            videoPlayer = DependencyService.Get<IVideoPlayer>(DependencyFetchTarget.NewInstance);
            Content = videoPlayer.GetView();
            videoPlayer.SetFile("/storage/extSdCard/video1.mpg");
        }

        public void BringToFront()
        {
            videoPlayer.BringToFront();
        }

        public void Invalidate()
        {
            videoPlayer.Invalidate();
        }
    }
}
