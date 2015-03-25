using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TabbarController.iOS
{
	partial class tabbar : UITabBarController
	{

		UIViewController tab3;

		public tabbar (IntPtr handle) : base (handle)
		{

			tab3 = new UIViewController();
			tab3.Title = "Green";
			tab3.View.BackgroundColor = UIColor.Green;
		}
	}
}
