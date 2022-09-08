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
	public class AdjustEventSuccess // TypeDefIndex: 6730
	{
		// Properties
		public string Adid { get; set; } // 0x000000018668EFD0-0x000000018668F030 0x000000018668F210-0x000000018668F270
		public string Message { get; set; } // 0x000000018668F150-0x000000018668F1B0 0x000000018668F390-0x000000018668F3F0
		public string Timestamp { get; set; } // 0x000000018668F1B0-0x000000018668F210 0x000000018668F3F0-0x000000018668F450
		public string EventToken { get; set; } // 0x000000018668F090-0x000000018668F0F0 0x000000018668F2D0-0x000000018668F330
		public string CallbackId { get; set; } // 0x000000018668F030-0x000000018668F090 0x000000018668F270-0x000000018668F2D0
		public Dictionary<string, object> JsonResponse { /* [XID] */ /* 0x0000000189967720-0x0000000189967760 */ get; /* [XID] */ /* 0x0000000189971FF0-0x0000000189972030 */ set; } // 0x000000018668F0F0-0x000000018668F150 0x000000018668F330-0x000000018668F390
	
		// Constructors
		public AdjustEventSuccess() {} // 0x000000018668EBF0-0x000000018668EC50
		public AdjustEventSuccess(Dictionary<string, string> eventSuccessDataMap) {} // 0x000000018668EC50-0x000000018668EFD0
		public AdjustEventSuccess(string jsonString) {} // 0x000000018668E850-0x000000018668EBF0
	
		// Methods
		// [XID] // 0x000000018997C1D0-0x000000018997C1F0
		public void BuildJsonResponseFromString(string jsonResponseString) {} // 0x000000018668E5C0-0x000000018668E750
		// [XID] // 0x0000000189983E50-0x0000000189983E70
		public string GetJsonResponse() => default; // 0x000000018668E750-0x000000018668E850
	}
}
