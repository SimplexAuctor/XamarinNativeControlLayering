using Xamarin.Forms;

namespace NativeControlLayering
{
    public interface IVideoPlayer
    {
        View GetView();
        void SetFile(string filename);
        void BringToFront();
        void Invalidate();
    }
}