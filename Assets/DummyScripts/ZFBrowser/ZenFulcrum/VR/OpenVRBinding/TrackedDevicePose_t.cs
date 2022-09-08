/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct TrackedDevicePose_t // TypeDefIndex: 6546
	{
		// Fields
		public HmdMatrix34_t mDeviceToAbsoluteTracking; // 0x00
		public HmdVector3_t vVelocity; // 0x30
		public HmdVector3_t vAngularVelocity; // 0x3C
		public ETrackingResult eTrackingResult; // 0x48
		public bool bPoseIsValid; // 0x4C
		public bool bDeviceIsConnected; // 0x4D
	}
}
