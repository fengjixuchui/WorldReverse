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
	public struct NativeDeviceInfo // TypeDefIndex: 7813
	{
		// Fields
		public string name; // 0x00
		public string location; // 0x08
		public string serialNumber; // 0x10
		public ushort vendorID; // 0x18
		public ushort productID; // 0x1A
		public uint versionNumber; // 0x1C
		public NativeDeviceDriverType driverType; // 0x20
		public NativeDeviceTransportType transportType; // 0x22
		public uint numButtons; // 0x24
		public uint numAnalogs; // 0x28
	
		// Methods
		// [XID] // 0x00000001896D0090-0x00000001896D00B0
		public bool HasSameVendorID(NativeDeviceInfo deviceInfo) => default; // 0x000000018886DE90-0x000000018886DFB0
		// [XID] // 0x000000018964ED60-0x000000018964ED80
		public bool HasSameProductID(NativeDeviceInfo deviceInfo) => default; // 0x000000018886DBE0-0x000000018886DD70
		// [XID] // 0x00000001896DEE80-0x00000001896DEEA0
		public bool HasSameVersionNumber(NativeDeviceInfo deviceInfo) => default; // 0x000000018886DFB0-0x000000018886E120
		// [XID] // 0x000000018965DD50-0x000000018965DD70
		public bool HasSameLocation(NativeDeviceInfo deviceInfo) => default; // 0x000000018886DAC0-0x000000018886DBE0
		// [XID] // 0x00000001896ED6D0-0x00000001896ED6F0
		public bool HasSameSerialNumber(NativeDeviceInfo deviceInfo) => default; // 0x000000018886DD70-0x000000018886DE90
	}
}
