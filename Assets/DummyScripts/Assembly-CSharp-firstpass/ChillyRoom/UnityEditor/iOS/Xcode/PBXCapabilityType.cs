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

namespace ChillyRoom.UnityEditor.iOS.Xcode
{
	public sealed class PBXCapabilityType // TypeDefIndex: 10413
	{
		// Fields
		public static readonly PBXCapabilityType ApplePay; // 0x00
		public static readonly PBXCapabilityType AppGroups; // 0x08
		public static readonly PBXCapabilityType AssociatedDomains; // 0x10
		public static readonly PBXCapabilityType BackgroundModes; // 0x18
		public static readonly PBXCapabilityType DataProtection; // 0x20
		public static readonly PBXCapabilityType GameCenter; // 0x28
		public static readonly PBXCapabilityType HealthKit; // 0x30
		public static readonly PBXCapabilityType HomeKit; // 0x38
		public static readonly PBXCapabilityType iCloud; // 0x40
		public static readonly PBXCapabilityType InAppPurchase; // 0x48
		public static readonly PBXCapabilityType InterAppAudio; // 0x50
		public static readonly PBXCapabilityType KeychainSharing; // 0x58
		public static readonly PBXCapabilityType Maps; // 0x60
		public static readonly PBXCapabilityType PersonalVPN; // 0x68
		public static readonly PBXCapabilityType PushNotifications; // 0x70
		public static readonly PBXCapabilityType Siri; // 0x78
		public static readonly PBXCapabilityType Wallet; // 0x80
		public static readonly PBXCapabilityType WirelessAccessoryConfiguration; // 0x88
		private readonly string m_ID; // 0x10
		private readonly bool m_RequiresEntitlements; // 0x18
		private readonly string m_Framework; // 0x20
		private readonly bool m_OptionalFramework; // 0x28
	
		// Properties
		public bool optionalFramework { /* [XID] */ /* 0x00000001896439A0-0x00000001896439C0 */ get => default; } // 0x0000000186D24430-0x0000000186D244D0 
		public string framework { /* [XID] */ /* 0x0000000189623E80-0x0000000189623EA0 */ get => default; } // 0x0000000186D242F0-0x0000000186D24390 
		public string id { /* [XID] */ /* 0x00000001896527E0-0x0000000189652800 */ get => default; } // 0x0000000186D24390-0x0000000186D24430 
		public bool requiresEntitlements { /* [XID] */ /* 0x0000000189AE5EA0-0x0000000189AE5EC0 */ get => default; } // 0x0000000186D244D0-0x0000000186D24570 
	
		// Nested types
		public struct TargetCapabilityPair // TypeDefIndex: 10414
		{
			// Fields
			public string targetGuid; // 0x00
			public PBXCapabilityType capability; // 0x08
	
			// Constructors
			public TargetCapabilityPair(string guid, PBXCapabilityType type) {
				targetGuid = default;
				capability = default;
			} // 0x0000000186D44580-0x0000000186D44620
		}
	
		// Constructors
		public PBXCapabilityType() {} // Dummy constructor
		private PBXCapabilityType(string _id, bool _requiresEntitlements, string _framework = "" /* Metadata: 0x00AE7590 */, bool _optionalFramework = false /* Metadata: 0x00AE7594 */) {} // 0x0000000186D24260-0x0000000186D242F0
		static PBXCapabilityType() {} // 0x0000000186D238C0-0x0000000186D24260
	
		// Methods
		// [XID] // 0x00000001896616A0-0x00000001896616C0
		public static PBXCapabilityType StringToPBXCapabilityType(string cap) => default; // 0x0000000186D230C0-0x0000000186D238C0
	}
}
