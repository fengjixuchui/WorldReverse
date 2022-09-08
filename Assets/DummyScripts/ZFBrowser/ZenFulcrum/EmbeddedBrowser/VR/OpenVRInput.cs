/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.XR;
using ZenFulcrum.VR.OpenVRBinding;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser.VR
{
	internal class OpenVRInput : VRInput // TypeDefIndex: 6601
	{
		// Fields
		protected VRControllerState_t lastState; // 0x10
	
		// Constructors
		public OpenVRInput() {} // 0x00000001856B5AE0-0x00000001856B5C20
	
		// Methods
		public static string GetStringProperty(uint deviceId, ETrackedDeviceProperty prop) => default; // 0x00000001856B53D0-0x00000001856B57A0
		public override string GetNodeName(XRNodeState node) => default; // 0x00000001856B5110-0x00000001856B53D0
		protected void ReadState(XRNodeState node) {} // 0x00000001856B5890-0x00000001856B5AE0
		protected override float GetAxisValue(XRNodeState node, InputAxis axis) => default; // 0x00000001856B4E90-0x00000001856B5030
		protected override float GetTouchValue(XRNodeState node, InputAxis axis) => default; // 0x00000001856B57A0-0x00000001856B5890
		private int GetDeviceId(XRNodeState node) => default; // 0x00000001856B5030-0x00000001856B5110
	}
}
