// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CoffeeHit.iOS.Views
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CupButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel OutputLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TapLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CupButton != null) {
				CupButton.Dispose ();
				CupButton = null;
			}
			if (OutputLabel != null) {
				OutputLabel.Dispose ();
				OutputLabel = null;
			}
			if (TapLabel != null) {
				TapLabel.Dispose ();
				TapLabel = null;
			}
		}
	}
}
