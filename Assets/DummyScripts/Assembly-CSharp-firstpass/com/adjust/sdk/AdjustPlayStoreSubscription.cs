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
	public class AdjustPlayStoreSubscription // TypeDefIndex: 6733
	{
		// Fields
		internal string price; // 0x10
		internal string currency; // 0x18
		internal string sku; // 0x20
		internal string orderId; // 0x28
		internal string signature; // 0x30
		internal string purchaseToken; // 0x38
		internal string billingStore; // 0x40
		internal string purchaseTime; // 0x48
		internal List<string> partnerList; // 0x50
		internal List<string> callbackList; // 0x58
	
		// Constructors
		public AdjustPlayStoreSubscription() {} // Dummy constructor
		public AdjustPlayStoreSubscription(string price, string currency, string sku, string orderId, string signature, string purchaseToken) {} // 0x000000018668FC90-0x000000018668FD30
	
		// Methods
		// [XID] // 0x00000001899A8800-0x00000001899A8820
		public void setPurchaseTime(string purchaseTime) {} // 0x000000018668FF90-0x0000000186690040
		// [XID] // 0x0000000189692430-0x0000000189692450
		public void addCallbackParameter(string key, string value) {} // 0x000000018668FD30-0x000000018668FE60
		// [XID] // 0x00000001899B73F0-0x00000001899B7410
		public void addPartnerParameter(string key, string value) {} // 0x000000018668FE60-0x000000018668FF90
	}
}
