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
	public class AdjustAppStoreSubscription // TypeDefIndex: 6722
	{
		// Fields
		internal string price; // 0x10
		internal string currency; // 0x18
		internal string transactionId; // 0x20
		internal string receipt; // 0x28
		internal string billingStore; // 0x30
		internal string transactionDate; // 0x38
		internal string salesRegion; // 0x40
		internal List<string> partnerList; // 0x48
		internal List<string> callbackList; // 0x50
	
		// Constructors
		public AdjustAppStoreSubscription() {} // Dummy constructor
		public AdjustAppStoreSubscription(string price, string currency, string transactionId, string receipt) {} // 0x000000018668AA80-0x000000018668AB10
	
		// Methods
		// [XID] // 0x000000018960DF80-0x000000018960DFA0
		public void setTransactionDate(string transactionDate) {} // 0x000000018668AE20-0x000000018668AED0
		// [XID] // 0x00000001896DB9C0-0x00000001896DB9E0
		public void setSalesRegion(string salesRegion) {} // 0x000000018668AD70-0x000000018668AE20
		// [XID] // 0x000000018961CD20-0x000000018961CD40
		public void addCallbackParameter(string key, string value) {} // 0x000000018668AB10-0x000000018668AC40
		// [XID] // 0x00000001898E31C0-0x00000001898E31E0
		public void addPartnerParameter(string key, string value) {} // 0x000000018668AC40-0x000000018668AD70
	}
}
