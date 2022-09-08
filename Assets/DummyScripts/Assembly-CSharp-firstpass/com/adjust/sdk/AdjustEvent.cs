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
	public class AdjustEvent // TypeDefIndex: 6728
	{
		// Fields
		internal string currency; // 0x10
		internal string eventToken; // 0x18
		internal string callbackId; // 0x20
		internal string transactionId; // 0x28
		internal double? revenue; // 0x30
		internal List<string> partnerList; // 0x40
		internal List<string> callbackList; // 0x48
		internal string receipt; // 0x50
		internal bool isReceiptSet; // 0x58
	
		// Constructors
		public AdjustEvent() {} // Dummy constructor
		public AdjustEvent(string eventToken) {} // 0x000000018668F450-0x000000018668F4D0
	
		// Methods
		// [XID] // 0x0000000189AA79F0-0x0000000189AA7A10
		public void setRevenue(double amount, string currency) {} // 0x000000018668F8B0-0x000000018668F9A0
		// [XID] // 0x0000000189639380-0x00000001896393A0
		public void addCallbackParameter(string key, string value) {} // 0x000000018668F4D0-0x000000018668F600
		// [XID] // 0x0000000189AB9860-0x0000000189AB9880
		public void addPartnerParameter(string key, string value) {} // 0x000000018668F600-0x000000018668F730
		// [XID] // 0x00000001897FD310-0x00000001897FD330
		public void setTransactionId(string transactionId) {} // 0x000000018668F9A0-0x000000018668FA50
		// [XID] // 0x0000000189603300-0x0000000189603320
		public void setCallbackId(string callbackId) {} // 0x000000018668F730-0x000000018668F7E0
		[Obsolete] // 0x000000018980BEB0-0x000000018980BF00
		// [XID] // 0x000000018980BEB0-0x000000018980BF00
		public void setReceipt(string receipt, string transactionId) {} // 0x000000018668F7E0-0x000000018668F8B0
	}
}
