/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct VREvent_t_Packed // TypeDefIndex: 6572
	{
		// Fields
		public uint eventType; // 0x00
		public uint trackedDeviceIndex; // 0x04
		public float eventAgeSeconds; // 0x08
		public VREvent_Data_t data; // 0x0C
	
		// Constructors
		public VREvent_t_Packed(VREvent_t unpacked) {
			eventType = default;
			trackedDeviceIndex = default;
			eventAgeSeconds = default;
			data = default;
		} // 0x0000000188324100-0x00000001883241B0
	
		// Methods
		public void Unpack(ref VREvent_t unpacked) {} // 0x00000001883240F0-0x0000000188324100
	}
}
