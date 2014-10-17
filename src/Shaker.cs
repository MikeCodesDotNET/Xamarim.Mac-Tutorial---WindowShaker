using System;
using MonoMac.CoreAnimation;
using System.Drawing;
using MonoMac.AppKit;
using MonoMac.Foundation;
using MonoMac.CoreGraphics;

namespace WindowShaker
{
    public static class Shaker
    {

        public static void Shake(this NSWindow window)
        {
            window.Animations = NSDictionary.FromObjectAndKey(ShakeAnimation(window.Frame), new NSString(@"frameOrigin"));
            ((NSWindow)window.Animator).SetFrameOrigin(window.Frame.Location);
        }

        static CAKeyFrameAnimation ShakeAnimation(RectangleF frame)
        {
            var numberOfShakes = 3;
            var durationOfShakes = 0.5f;
            var vigourOfShake = 0.02f;
            CAKeyFrameAnimation shakeAnimation = new CAKeyFrameAnimation();

            var shakePath = new CGPath();
            shakePath.MoveToPoint(frame.GetMinX(), frame.GetMinY());
            int index;
            for (index = 0; index < numberOfShakes; index++)
            {
                shakePath.CGPathAddLineToPoint(frame.GetMinX() - frame.Size.Width * vigourOfShake, frame.GetMinY());
                shakePath.CGPathAddLineToPoint(frame.GetMinX() + frame.Size.Width * vigourOfShake, frame.GetMinY());
            }
            shakePath.CloseSubpath();
            shakeAnimation.Path = shakePath;
            shakeAnimation.Duration = durationOfShakes;
            return shakeAnimation;
        }
    }
}

