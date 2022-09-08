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
	public class AdjustEventFailure // TypeDefIndex: 6729
	{
		// Properties
		public string Adid { get; set; } // 0x000000018668E080-0x000000018668E0E0 0x000000018668E320-0x000000018668E380
		public string Message { get; set; } // 0x000000018668E200-0x000000018668E260 0x000000018668E4A0-0x000000018668E500
		public string Timestamp { get; set; } // 0x000000018668E260-0x000000018668E2C0 0x000000018668E500-0x000000018668E560
		public string EventToken { get; set; } // 0x000000018668E140-0x000000018668E1A0 0x000000018668E3E0-0x000000018668E440
		public string CallbackId { get; set; } // 0x000000018668E0E0-0x000000018668E140 0x000000018668E380-0x000000018668E3E0
		public bool WillRetry { get; set; } // 0x000000018668E2C0-0x000000018668E320 0x000000018668E560-0x000000018668E5C0
		public Dictionary<string, object> JsonResponse { /* [XID] */ /* 0x00000001898B9570-0x00000001898B95B0 */ get; /* [XID] */ /* 0x00000001898C3830-0x00000001898C3870 */ set; } // 0x000000018668E1A0-0x000000018668E200 0x000000018668E440-0x000000018668E4A0
	
		// Constructors
		public AdjustEventFailure() {} // 0x000000018668D7F0-0x000000018668D850
		public AdjustEventFailure(Dictionary<string, string> eventFailureDataMap) {} // 0x000000018668DC80-0x000000018668E080
		public AdjustEventFailure(string jsonString) {} // 0x000000018668D850-0x000000018668DC80
	
		// Methods
		// [XID] // 0x0000000189B35440-0x0000000189B35460
		public void BuildJsonResponseFromString(string jsonResponseString) {} // 0x000000018668D560-0x000000018668D6F0
		// [XID] // 0x0000000189A0B9F0-0x0000000189A0BA10
		public string GetJsonResponse() => default; // 0x000000018668D6F0-0x000000018668D7F0
	}
}
