// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmCrossTest.Tst.Views
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		UIKit.UIButton clickButton { get; set; }

		[Outlet]
		UIKit.UILabel Label { get; set; }

		[Outlet]
		UIKit.UITextField TextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Label != null) {
				Label.Dispose ();
				Label = null;
			}

			if (TextField != null) {
				TextField.Dispose ();
				TextField = null;
			}

			if (clickButton != null) {
				clickButton.Dispose ();
				clickButton = null;
			}
		}
	}
}
