using System;
using CoreGraphics;
using SpotlightXamarin.IOS;
using UIKit;

namespace SpotlightXamarin.IOS_App
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Orange;

            UILabel FirstView = new UILabel(new CGRect(59, 250, 80,45))
            {
                Text = "First",
                TextColor = UIColor.White,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(25f)
            };
            Add(FirstView);

            UILabel SecondView = new UILabel(new CGRect(250, 190, 70, 45))
            {
                Text = "Second",
                TextColor = UIColor.White,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(19f)
            };
            Add(SecondView);

            UILabel ThirdView = new UILabel(new CGRect(150, 450, 120, 45))
            {
                Text = "Third",
                TextColor = UIColor.White,
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.SystemFontOfSize(35f)
            };
            Add(ThirdView);


            UIButton button = new UIButton(new CGRect(View.Bounds.Width - 55, View.Bounds.Height - 45, 50, 40));
            button.SetTitle("Show",UIControlState.Normal);
            Add(button);

            button.TouchUpInside += (sender, e) => 
            {
                SimpleTarget firstTarget = new SimpleTargetBuilder(this).SetPoint(FirstView)
                                                                    .SetRadius(50f)
                                                                    .SetTitle("First title")
                                                                    .SetDescription("This description is for first view.")
                                                                    .Build();

                SimpleTarget secondTarget = new SimpleTargetBuilder(this).SetPoint(SecondView)
                                                                    .SetRadius(40f)
                                                                    .SetTitle("First title")
                                                                    .SetDescription("This description is for first view.")
                                                                    .Build();

                SimpleTarget thirdTarget = new SimpleTargetBuilder(this).SetPoint(ThirdView)
                                                                    .SetRadius(60f)
                                                                    .SetTitle("First title")
                                                                    .SetDescription("This description is for first view.")
                                                                    .Build();


                Spotlight spotlight = new SpotlightBuilder(this).SetTargets(firstTarget, secondTarget, thirdTarget)
                                                            .SetDuration(1000)
                                                                .Start();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
