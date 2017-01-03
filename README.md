# Payment Kit
Easy way of integrating card text field with nice animations and validations. 

###Usage
Before using this control we need to include all the card resources(images) in to our iOS project. We can update the card view UI based on the default images currently the project has. 

```
var paymentView = new PTKView();
this.EdgesForExtendedLayout = UIRectEdge.None;
paymentView.Frame = new CGRect(30, 20, 300, 45);
paymentView.Delegate = new TextDelegate();
this.View.AddSubview(paymentView);
paymentView.BecomeFirstResponder();
```

For performing any validation logic we can use delegate for this. For example if we want to enable process based on valid card details we can use the below delegate to perform that. (This process won't validate whether the entered card number is genuine or not). This is just to validate the card number based on some regular expressions.


```
public class TextDelegate : PTKViewDelegate
{
	public override void WithCard(PTKView paymentView, PTKCard card, bool valid)
	{

	}
}
```

###Output 
![](https://github.com/guntidheerajkumar/PaymentKit/blob/master/paymentkit-output.gif)
