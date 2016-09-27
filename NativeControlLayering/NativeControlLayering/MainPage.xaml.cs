using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NativeControlLayering
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        bool v1OnTop = false;
        public void SwapLowerChild(object sender, EventArgs args)
        {
            if(v1OnTop)
            {
                layout.LowerChild(v1);
            }
            else
            {
                layout.LowerChild(v2);
            }

            v1OnTop = !v1OnTop;
        }

        bool v1OnTopNCH = false;
        public void SwapNCHLowerChild(object sender, EventArgs args)
        {
            if (v1OnTopNCH)
            {
                l2.LowerChild(v3);
            }
            else
            {
                l2.LowerChild(v4);
            }

            v1OnTopNCH = !v1OnTopNCH;
        }

        public void SwapNCHAndroidStuff(object sender, EventArgs args)
        {
            if (v1OnTopNCH)
            {
                v3.BringToFront();
                v3.Invalidate();
                v4.Invalidate();
                l2.ForceInvalidate();
            }
            else
            {
                v4.BringToFront();
                v3.Invalidate();
                v4.Invalidate();
                l2.ForceInvalidate();
            }

            v1OnTopNCH = !v1OnTopNCH;
        }
    }
}
