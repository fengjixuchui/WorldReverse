/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.VR.OpenVRBinding
{
	public struct Compositor_FrameTiming // TypeDefIndex: 6580
	{
		// Fields
		public uint m_nSize; // 0x00
		public uint m_nFrameIndex; // 0x04
		public uint m_nNumFramePresents; // 0x08
		public uint m_nNumMisPresented; // 0x0C
		public uint m_nNumDroppedFrames; // 0x10
		public uint m_nReprojectionFlags; // 0x14
		public double m_flSystemTimeInSeconds; // 0x18
		public float m_flPreSubmitGpuMs; // 0x20
		public float m_flPostSubmitGpuMs; // 0x24
		public float m_flTotalRenderGpuMs; // 0x28
		public float m_flCompositorRenderGpuMs; // 0x2C
		public float m_flCompositorRenderCpuMs; // 0x30
		public float m_flCompositorIdleCpuMs; // 0x34
		public float m_flClientFrameIntervalMs; // 0x38
		public float m_flPresentCallCpuMs; // 0x3C
		public float m_flWaitForPresentCpuMs; // 0x40
		public float m_flSubmitFrameMs; // 0x44
		public float m_flWaitGetPosesCalledMs; // 0x48
		public float m_flNewPosesReadyMs; // 0x4C
		public float m_flNewFrameReadyMs; // 0x50
		public float m_flCompositorUpdateStartMs; // 0x54
		public float m_flCompositorUpdateEndMs; // 0x58
		public float m_flCompositorRenderStartMs; // 0x5C
		public TrackedDevicePose_t m_HmdPose; // 0x60
	}
}
