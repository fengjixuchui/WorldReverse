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
	public class AdjustSessionFailure // TypeDefIndex: 6734
	{
		// Properties
		public string Adid { get; set; } // 0x00000001866909F0-0x0000000186690A50 0x0000000186690BD0-0x0000000186690C30
		public string Message { get; set; } // 0x0000000186690AB0-0x0000000186690B10 0x0000000186690C90-0x0000000186690CF0
		public string Timestamp { get; set; } // 0x0000000186690B10-0x0000000186690B70 0x0000000186690CF0-0x0000000186690D50
		public bool WillRetry { get; set; } // 0x0000000186690B70-0x0000000186690BD0 0x0000000186690D50-0x0000000186690DB0
		public Dictionary<string, object> JsonResponse { /* [XID] */ /* 0x0000000189A2E4D0-0x0000000189A2E510 */ get; /* [XID] */ /* 0x0000000189A38E70-0x0000000189A38EB0 */ set; } // 0x0000000186690A50-0x0000000186690AB0 0x0000000186690C30-0x0000000186690C90
	
		// Constructors
		public AdjustSessionFailure() {} // 0x0000000186690640-0x00000001866906A0
		public AdjustSessionFailure(Dictionary<string, string> sessionFailureDataMap) {} // 0x00000001866906A0-0x00000001866909F0
		public AdjustSessionFailure(string jsonString) {} // 0x00000001866902D0-0x0000000186690640
	
		// Methods
		// [XID] // 0x0000000189699850-0x0000000189699870
		public void BuildJsonResponseFromString(string jsonResponseString) {} // 0x0000000186690040-0x00000001866901D0
		// [XID] // 0x0000000189A4AAB0-0x0000000189A4AAD0
		public string GetJsonResponse() => default; // 0x00000001866901D0-0x00000001866902D0
	}
}
