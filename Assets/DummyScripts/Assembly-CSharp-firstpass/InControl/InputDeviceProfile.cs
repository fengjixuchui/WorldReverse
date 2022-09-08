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

namespace InControl
{
	public abstract class InputDeviceProfile // TypeDefIndex: 7638
	{
		// Fields
		private static HashSet<System.Type> hideList; // 0x00
		private float sensitivity; // 0x50
		private float lowerDeadZone; // 0x54
		private float upperDeadZone; // 0x58
	
		// Properties
		public string Name { /* [XID] */ /* 0x0000000189627B50-0x0000000189627B90 */ get; protected set; } // 0x00000001870CBF90-0x00000001870CBFF0 0x00000001870CC670-0x00000001870CC6D0
		public string Meta { /* [XID] */ /* 0x0000000189BAFEC0-0x0000000189BAFF00 */ get; protected set; } // 0x00000001870CBED0-0x00000001870CBF30 0x00000001870CC5B0-0x00000001870CC610
		public InputControlMapping[] AnalogMappings { /* [XID] */ /* 0x0000000189BC25A0-0x0000000189BC25E0 */ get; protected set; } // 0x00000001870CB580-0x00000001870CB5E0 0x00000001870CC230-0x00000001870CC290
		public InputControlMapping[] ButtonMappings { /* [XID] */ /* 0x0000000189BD43C0-0x0000000189BD4400 */ get; protected set; } // 0x00000001870CB6C0-0x00000001870CB720 0x00000001870CC290-0x00000001870CC2F0
		public string[] IncludePlatforms { /* [XID] */ /* 0x00000001895EB7D0-0x00000001895EB810 */ get; /* [XID] */ /* 0x00000001895F5FF0-0x00000001895F6030 */ protected set; } // 0x00000001870CB840-0x00000001870CB8A0 0x00000001870CC410-0x00000001870CC470
		public string[] ExcludePlatforms { /* [XID] */ /* 0x0000000189600350-0x0000000189600390 */ get; protected set; } // 0x00000001870CB7E0-0x00000001870CB840 0x00000001870CC3B0-0x00000001870CC410
		public int MaxSystemBuildNumber { /* [XID] */ /* 0x00000001896124A0-0x00000001896124E0 */ get; protected set; } // 0x00000001870CBE70-0x00000001870CBED0 0x00000001870CC550-0x00000001870CC5B0
		public int MinSystemBuildNumber { /* [XID] */ /* 0x0000000189624220-0x0000000189624260 */ get; protected set; } // 0x00000001870CBF30-0x00000001870CBF90 0x00000001870CC610-0x00000001870CC670
		public InputDeviceClass DeviceClass { /* [XID] */ /* 0x0000000189636760-0x00000001896367A0 */ get; protected set; } // 0x00000001870CB720-0x00000001870CB780 0x00000001870CC2F0-0x00000001870CC350
		public InputDeviceStyle DeviceStyle { /* [XID] */ /* 0x0000000189648400-0x0000000189648440 */ get; protected set; } // 0x00000001870CB780-0x00000001870CB7E0 0x00000001870CC350-0x00000001870CC3B0
		public float Sensitivity { /* [XID] */ /* 0x000000018965A170-0x000000018965A190 */ get; /* [XID] */ /* 0x0000000189661860-0x0000000189661880 */ protected set; } // 0x00000001870CBFF0-0x00000001870CC0A0 0x00000001870CC6D0-0x00000001870CC7B0
		public float LowerDeadZone { /* [XID] */ /* 0x00000001897114D0-0x00000001897114F0 */ get; /* [XID] */ /* 0x0000000189670F30-0x0000000189670F50 */ protected set; } // 0x00000001870CBDC0-0x00000001870CBE70 0x00000001870CC470-0x00000001870CC550
		public float UpperDeadZone { /* [XID] */ /* 0x0000000189678630-0x0000000189678650 */ get; /* [XID] */ /* 0x000000018967FE70-0x000000018967FE90 */ protected set; } // 0x00000001870CC180-0x00000001870CC230 0x00000001870CC890-0x00000001870CC970
		[Obsolete] // 0x00000001896BB590-0x00000001896BB5C0
		public string[] SupportedPlatforms { /* [XID] */ /* 0x0000000189687540-0x0000000189687560 */ get; /* [XID] */ /* 0x000000018968F360-0x000000018968F380 */ protected set; } // 0x00000001870CC0A0-0x00000001870CC180 0x00000001870CC7B0-0x00000001870CC890
		public virtual bool IsSupportedOnThisPlatform { /* [XID] */ /* 0x0000000189696DD0-0x0000000189696DF0 */ get; } // 0x00000001870CB9A0-0x00000001870CBDC0 
		internal bool IsHidden { /* [XID] */ /* 0x00000001896A53E0-0x00000001896A5400 */ get; } // 0x00000001870CB8A0-0x00000001870CB9A0 
		public int AnalogCount { /* [XID] */ /* 0x00000001895F3750-0x00000001895F3770 */ get; } // 0x00000001870CB4A0-0x00000001870CB580 
		public int ButtonCount { /* [XID] */ /* 0x00000001896B4080-0x00000001896B40A0 */ get; } // 0x00000001870CB5E0-0x00000001870CB6C0 
	
		// Constructors
		public InputDeviceProfile() {} // 0x00000001870CB160-0x00000001870CB4A0
		static InputDeviceProfile() {} // 0x00000001870CB0D0-0x00000001870CB160
	
		// Methods
		// [XID] // 0x00000001899259E0-0x0000000189925A00
		internal static void Hide(System.Type type) {} // 0x00000001870CAFE0-0x00000001870CB0D0
	}
}
