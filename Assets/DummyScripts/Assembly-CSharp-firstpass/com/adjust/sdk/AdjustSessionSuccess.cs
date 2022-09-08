/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace com.adjust.sdk
{
	public class AdjustSessionSuccess // TypeDefIndex: 6735
	{
		// Properties
		public string Adid { get; set; } // 0x0000000186691640-0x00000001866916A0 0x00000001866917C0-0x0000000186691820
		public string Message { get; set; } // 0x0000000186691700-0x0000000186691760 0x0000000186691880-0x00000001866918E0
		public string Timestamp { get; set; } // 0x0000000186691760-0x00000001866917C0 0x00000001866918E0-0x0000000186691940
		public Dictionary<string, object> JsonResponse { /* [XID] */ /* 0x0000000189AA9070-0x0000000189AA90B0 */ get; /* [XID] */ /* 0x0000000189AB3CC0-0x0000000189AB3D00 */ set; } // 0x00000001866916A0-0x0000000186691700 0x0000000186691820-0x0000000186691880
	
		// Constructors
		public AdjustSessionSuccess() {} // 0x0000000186691320-0x0000000186691380
		public AdjustSessionSuccess(Dictionary<string, string> sessionSuccessDataMap) {} // 0x0000000186691380-0x0000000186691640
		public AdjustSessionSuccess(string jsonString) {} // 0x0000000186691040-0x0000000186691320
	
		// Methods
		// [XID] // 0x000000018977C660-0x000000018977C680
		public void BuildJsonResponseFromString(string jsonResponseString) {} // 0x0000000186690DB0-0x0000000186690F40
		// [XID] // 0x00000001895ECD20-0x00000001895ECD40
		public string GetJsonResponse() => default; // 0x0000000186690F40-0x0000000186691040
	}
}
