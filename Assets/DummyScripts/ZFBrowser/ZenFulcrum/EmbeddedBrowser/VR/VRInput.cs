/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.XR;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser.VR
{
	public class VRInput // TypeDefIndex: 6600
	{
		// Fields
		private static VRInput impl; // 0x00
		private static Dictionary<ulong, JoyPadType> nodeTypes; // 0x08
	
		// Constructors
		public VRInput() {} // 0x00000001856C3A00-0x00000001856C3A60
		static VRInput() {} // 0x00000001856C3970-0x00000001856C3A00
	
		// Methods
		public static void Init() {} // 0x00000001856C38B0-0x00000001856C3970
		public static float GetAxis(XRNodeState node, InputAxis axis) => default; // 0x00000001856C2FC0-0x00000001856C3140
		public static float GetTouch(XRNodeState node, InputAxis axis) => default; // 0x00000001856C3730-0x00000001856C38B0
		protected virtual float GetAxisValue(XRNodeState node, InputAxis axis) => default; // 0x00000001856C2F70-0x00000001856C2FC0
		protected virtual float GetTouchValue(XRNodeState node, InputAxis axis) => default; // 0x00000001856C36E0-0x00000001856C3730
		public static JoyPadType GetJoypadType(XRNodeState node) => default; // 0x00000001856C3310-0x00000001856C3640
		public virtual string GetNodeName(XRNodeState node) => default; // 0x00000001856C3640-0x00000001856C36E0
		private static VRInput GetImpl() => default; // 0x00000001856C3140-0x00000001856C3310
	}
}
