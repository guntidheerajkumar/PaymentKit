using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace PaymentKit
{
	// @interface PTKComponent : NSObject
	[BaseType(typeof(NSObject))]
	interface PTKComponent
	{
		// -(id)initWithString:(NSString *)string;
		[Export("initWithString:")]
		IntPtr Constructor(string @string);

		// -(NSString *)string;
		[Export("string")]
		string String { get; }

		// -(NSString *)formattedString;
		[Export("formattedString")]
		string FormattedString { get; }

		// -(BOOL)isValid;
		[Export("isValid")]
		bool IsValid { get; }

		// -(BOOL)isPartiallyValid;
		[Export("isPartiallyValid")]
		bool IsPartiallyValid { get; }

		// -(NSString *)formattedStringWithTrail;
		[Export("formattedStringWithTrail")]
		string FormattedStringWithTrail { get; }
	}

	// @interface PTKAddressZip : PTKComponent
	[BaseType(typeof(PTKComponent))]
	interface PTKAddressZip
	{
		// @property (readonly, nonatomic) NSString * string;
		[Export("string")]
		string String { get; }

		// +(instancetype)addressZipWithString:(NSString *)string;
		[Static]
		[Export("addressZipWithString:")]
		PTKAddressZip AddressZipWithString(string @string);

		// -(instancetype)initWithString:(NSString *)string;
		[Export("initWithString:")]
		IntPtr Constructor(string @string);
	}

	// @interface PTKCard : NSObject
	[BaseType(typeof(NSObject))]
	interface PTKCard
	{
		// @property (copy, nonatomic) NSString * number;
		[Export("number")]
		string Number { get; set; }

		// @property (copy, nonatomic) NSString * cvc;
		[Export("cvc")]
		string Cvc { get; set; }

		// @property (copy, nonatomic) NSString * addressZip;
		[Export("addressZip")]
		string AddressZip { get; set; }

		// @property (assign, nonatomic) NSUInteger expMonth;
		[Export("expMonth")]
		nuint ExpMonth { get; set; }

		// @property (assign, nonatomic) NSUInteger expYear;
		[Export("expYear")]
		nuint ExpYear { get; set; }

		// @property (readonly, nonatomic) NSString * last4;
		[Export("last4")]
		string Last4 { get; }
	}

	// @interface PTKCardCVC : PTKComponent
	[BaseType(typeof(PTKComponent))]
	interface PTKCardCVC
	{
		// @property (readonly, nonatomic) NSString * string;
		[Export("string")]
		string String { get; }

		// +(instancetype)cardCVCWithString:(NSString *)string;
		[Static]
		[Export("cardCVCWithString:")]
		PTKCardCVC CardCVCWithString(string @string);

		// -(BOOL)isValidWithType:(PTKCardType)type;
		[Export("isValidWithType:")]
		bool IsValidWithType(PTKCardType type);

		// -(BOOL)isPartiallyValidWithType:(PTKCardType)type;
		[Export("isPartiallyValidWithType:")]
		bool IsPartiallyValidWithType(PTKCardType type);
	}

	// @interface PTKCardExpiry : PTKComponent
	[BaseType(typeof(PTKComponent))]
	interface PTKCardExpiry
	{
		// @property (readonly, nonatomic) NSUInteger month;
		[Export("month")]
		nuint Month { get; }

		// @property (readonly, nonatomic) NSUInteger year;
		[Export("year")]
		nuint Year { get; }

		// @property (readonly, nonatomic) NSString * formattedString;
		[Export("formattedString")]
		string FormattedString { get; }

		// @property (readonly, nonatomic) NSString * formattedStringWithTrail;
		[Export("formattedStringWithTrail")]
		string FormattedStringWithTrail { get; }

		// +(instancetype)cardExpiryWithString:(NSString *)string;
		[Static]
		[Export("cardExpiryWithString:")]
		PTKCardExpiry CardExpiryWithString(string @string);

		// -(instancetype)initWithString:(NSString *)string;
		[Export("initWithString:")]
		IntPtr Constructor(string @string);

		// -(BOOL)isValidLength;
		[Export("isValidLength")]
		bool IsValidLength { get; }

		// -(BOOL)isValidDate;
		[Export("isValidDate")]
		bool IsValidDate { get; }
	}

	// @interface PTKCardNumber : PTKComponent
	[BaseType(typeof(PTKComponent))]
	interface PTKCardNumber
	{
		// @property (readonly, nonatomic) PTKCardType cardType;
		[Export("cardType")]
		PTKCardType CardType { get; }

		// @property (readonly, nonatomic) NSString * last4;
		[Export("last4")]
		string Last4 { get; }

		// @property (readonly, nonatomic) NSString * lastGroup;
		[Export("lastGroup")]
		string LastGroup { get; }

		// @property (readonly, nonatomic) NSString * string;
		[Export("string")]
		string String { get; }

		// @property (readonly, nonatomic) NSString * formattedString;
		[Export("formattedString")]
		string FormattedString { get; }

		// @property (readonly, nonatomic) NSString * formattedStringWithTrail;
		[Export("formattedStringWithTrail")]
		string FormattedStringWithTrail { get; }

		// @property (readonly, getter = isValid, nonatomic) BOOL valid;
		[Export("valid")]
		bool Valid { [Bind("isValid")] get; }

		// @property (readonly, getter = isValidLength, nonatomic) BOOL validLength;
		[Export("validLength")]
		bool ValidLength { [Bind("isValidLength")] get; }

		// @property (readonly, getter = isValidLuhn, nonatomic) BOOL validLuhn;
		[Export("validLuhn")]
		bool ValidLuhn { [Bind("isValidLuhn")] get; }

		// @property (readonly, getter = isPartiallyValid, nonatomic) BOOL partiallyValid;
		[Export("partiallyValid")]
		bool PartiallyValid { [Bind("isPartiallyValid")] get; }

		// +(instancetype)cardNumberWithString:(NSString *)string;
		[Static]
		[Export("cardNumberWithString:")]
		PTKCardNumber CardNumberWithString(string @string);

		// -(instancetype)initWithString:(NSString *)string;
		[Export("initWithString:")]
		IntPtr Constructor(string @string);
	}

	// @protocol PTKTextFieldDelegate <UITextFieldDelegate>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface PTKTextFieldDelegate : IUITextFieldDelegate
	{
		// @optional -(void)pkTextFieldDidBackSpaceWhileTextIsEmpty:(PTKTextField *)textField;
		[Export("pkTextFieldDidBackSpaceWhileTextIsEmpty:")]
		void PkTextFieldDidBackSpaceWhileTextIsEmpty(PTKTextField textField);
	}

	// @interface PTKTextField : UITextField
	[BaseType(typeof(UITextField))]
	interface PTKTextField
	{
		// +(NSString *)textByRemovingUselessSpacesFromString:(NSString *)string;
		[Static]
		[Export("textByRemovingUselessSpacesFromString:")]
		string TextByRemovingUselessSpacesFromString(string @string);

		[Wrap("WeakDelegate")]
		PTKTextFieldDelegate TextDelegate { get; set; }

		// @property (nonatomic, weak) id<PTKTextFieldDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface PTKUSAddressZip : PTKAddressZip
	[BaseType(typeof(PTKAddressZip))]
	interface PTKUSAddressZip
	{
	}

	// @protocol PTKViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface PTKViewDelegate
	{
		// @optional -(void)paymentView:(PTKView *)paymentView withCard:(PTKCard *)card isValid:(BOOL)valid;
		[Export("paymentView:withCard:isValid:")]
		void WithCard(PTKView paymentView, PTKCard card, bool valid);
	}

	// @interface PTKView : UIView
	[BaseType(typeof(UIView))]
	interface PTKView
	{
		// -(BOOL)isValid;
		[Export("isValid")]
		bool IsValid { get; }

		// @property (readonly, nonatomic) UIView * opaqueOverGradientView;
		[Export("opaqueOverGradientView")]
		UIView OpaqueOverGradientView { get; }

		// @property (readonly, nonatomic) PTKCardNumber * cardNumber;
		[Export("cardNumber")]
		PTKCardNumber CardNumber { get; }

		// @property (readonly, nonatomic) PTKCardExpiry * cardExpiry;
		[Export("cardExpiry")]
		PTKCardExpiry CardExpiry { get; }

		// @property (readonly, nonatomic) PTKCardCVC * cardCVC;
		[Export("cardCVC")]
		PTKCardCVC CardCVC { get; }

		// @property (readonly, nonatomic) PTKAddressZip * addressZip;
		[Export("addressZip")]
		PTKAddressZip AddressZip { get; }

		// @property UIView * innerView __attribute__((iboutlet));
		[Export("innerView", ArgumentSemantic.Assign)]
		UIView InnerView { get; set; }

		// @property UIView * clipView __attribute__((iboutlet));
		[Export("clipView", ArgumentSemantic.Assign)]
		UIView ClipView { get; set; }

		// @property PTKTextField * cardNumberField __attribute__((iboutlet));
		[Export("cardNumberField", ArgumentSemantic.Assign)]
		PTKTextField CardNumberField { get; set; }

		// @property PTKTextField * cardExpiryField __attribute__((iboutlet));
		[Export("cardExpiryField", ArgumentSemantic.Assign)]
		PTKTextField CardExpiryField { get; set; }

		// @property PTKTextField * cardCVCField __attribute__((iboutlet));
		[Export("cardCVCField", ArgumentSemantic.Assign)]
		PTKTextField CardCVCField { get; set; }

		// @property UIImageView * placeholderView __attribute__((iboutlet));
		[Export("placeholderView", ArgumentSemantic.Assign)]
		UIImageView PlaceholderView { get; set; }

		[Wrap("WeakDelegate")]
		PTKViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<PTKViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly) PTKCard * card;
		[Export("card")]
		PTKCard Card { get; }
	}
}
