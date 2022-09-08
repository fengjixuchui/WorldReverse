/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class NativeInputDeviceMatcher // TypeDefIndex: 7818
	{
		// Fields
		public ushort? VendorID; // 0x10
		public ushort? ProductID; // 0x14
		public uint? VersionNumber; // 0x18
		public NativeDeviceDriverType? DriverType; // 0x20
		public NativeDeviceTransportType? TransportType; // 0x24
		public string[] NameLiterals; // 0x28
		public string[] NamePatterns; // 0x30
	
		// Constructors
		public NativeInputDeviceMatcher() {} // 0x00000001893BF130-0x00000001893BF190
	
		// Methods
		// [XID] // 0x000000018984EF70-0x000000018984EF90
		internal bool Matches(NativeDeviceInfo deviceInfo) => default; // 0x00000001893BEDF0-0x00000001893BF130
	}
}
