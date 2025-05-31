// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Identity.Client;

namespace MauiAppBasic.Platforms.Android.Resources
{
	/*
		MsalActivity primarily serves as an Android entry point that intercepts and processes the authentication 
		responses from the MSAL library. It is configured with intent filter attributes to handle the specific 
		URI (matching the custom scheme and host) that MSAL expects to receive from the authorization server. 
		Because its base class, BrowserTabActivity, already implements the necessary logic for handling these responses, 
		MsalActivity simply acts as a marker or stub. This setup ensures that the authentication flow completes correctly 
		by allowing the embedded behavior in BrowserTabActivity to manage the response processing.

		The reason MsalActivity doesn't implement additional functionality is that it's leveraging the 
		behavior provided by its base class, BrowserTabActivity. The MSAL library expects an activity with 
		specific configuration (as defined by the intent filter attributes) to handle the authentication responses. 
		Since BrowserTabActivity already contains the complete implementation for handling these responses, 
		MsalActivity only needs to exist as a marker to fulfill the Android manifest requirements and delegate 
		calls to the base class via overrides like OnCreate and OnActivityResult.
	*/
	[Activity(Exported = true)]
	[IntentFilter(new[] { Intent.ActionView },
		Categories = new[] { Intent.CategoryBrowsable, Intent.CategoryDefault },
		DataHost = "auth",
		DataScheme = "msal44d84416-03ea-4c42-8e3a-75a5a4439e5b")]
	public class MsalActivity : BrowserTabActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
		}

		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
		}
	}
}
