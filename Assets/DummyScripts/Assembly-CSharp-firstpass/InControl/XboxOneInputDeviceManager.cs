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
	public class XboxOneInputDeviceManager : InputDeviceManager // TypeDefIndex: 8008
	{
		// Fields
		private const int maxDevices = 8; // Metadata: 0x00ADF3D9
		private bool[] deviceConnected; // 0x18
	
		// Constructors
		public XboxOneInputDeviceManager() {} // 0x0000000187B14650-0x0000000187B14740
	
		// Methods
		// [XID] // 0x0000000189809070-0x0000000189809090
		private void UpdateInternal(ulong updateTick, float deltaTime) {} // 0x0000000187B14340-0x0000000187B14580
		// [XID] // 0x0000000189B3A090-0x0000000189B3A0B0
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000187B14580-0x0000000187B14650
		// [XID] // 0x0000000189818020-0x0000000189818040
		public override void Destroy() {} // 0x0000000187B14050-0x0000000187B140F0
		// [XID] // 0x0000000189B58300-0x0000000189B58320
		public static bool CheckPlatformSupport(ICollection<string> errors) => default; // 0x0000000187B13FA0-0x0000000187B14050
		// [XID] // 0x0000000189B672A0-0x0000000189B672C0
		internal static bool Enable() => default; // 0x0000000187B140F0-0x0000000187B142E0
	}
}
