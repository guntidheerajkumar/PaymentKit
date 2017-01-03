using System;
using PaymentKit;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Sample
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

			this.Title = "Payment";
			var paymentView = new PTKView();
			this.EdgesForExtendedLayout = UIRectEdge.None;
			paymentView.Frame = new CGRect(30, 20, 300, 45);
			paymentView.Delegate = new TextDelegate();
			this.View.AddSubview(paymentView);
			paymentView.BecomeFirstResponder();
		}
	}

	public class TextDelegate : PTKViewDelegate
	{
		public override void WithCard(PTKView paymentView, PTKCard card, bool valid)
		{

		}
	}
}
