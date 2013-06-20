//
// testflight.cs: API definition for the TestFlight SDK
//
// Authors:
//  Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2011 Xamarin Inc.
//

using System;
using MonoTouch.Foundation;
using MonoTouch.CoreLocation;

namespace NewRelic {

	[BaseType (typeof (NSObject))]
	public interface NewRelicAgent {
		[Static, Export ("startWithApplicationToken:")]
		void Start (string appToken);

		[Static, Export ("startWithApplicationToken:withoutSecurity:")]
		void Start (string appToken, bool disableSSL);

		[Static, Export ("setDeviceLocation:")]
		void SetDeviceLocation (CLLocation location);
	}
}