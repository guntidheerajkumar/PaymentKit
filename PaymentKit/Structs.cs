using System;
using ObjCRuntime;

namespace PaymentKit
{
	[Native]
	public enum PTKCardType : long
	{
		Visa,
		MasterCard,
		Amex,
		Discover,
		Jcb,
		DinersClub,
		Unknown
	}
}
