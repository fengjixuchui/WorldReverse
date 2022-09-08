/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x00000001897B2F70-0x00000001897B3020
	[DisallowMultipleComponent] // 0x00000001897B2F70-0x00000001897B3020
	// [DocumentationSorting] // 0x00000001897B2F70-0x00000001897B3020
	[ExecuteInEditMode] // 0x00000001897B2F70-0x00000001897B3020
	// [RequireComponent] // 0x00000001897B2F70-0x00000001897B3020
	public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 6770
	{
		// Fields
		[NoSaveDuringPlay] // 0x00000001897CD1B0-0x00000001897CD200
		// [Tooltip] // 0x00000001897CD1B0-0x00000001897CD200
		public Transform m_LookAt; // 0x78
		private Camera m_Camera; // 0x80
		private CameraState m_State; // 0x88
	
		// Properties
		public override CameraState State { /* [XID] */ /* 0x0000000189B63160-0x0000000189B63180 */ get => default; } // 0x0000000186CB59D0-0x0000000186CB5C30 
		public override Transform LookAt { /* [XID] */ /* 0x0000000189A779C0-0x0000000189A779E0 */ get => default; /* [XID] */ /* 0x00000001897F2E00-0x00000001897F2E20 */ set {} } // 0x0000000186CB5930-0x0000000186CB59D0 0x0000000186CB5CA0-0x0000000186CB5D50
		public override Transform Follow { get; set; } // 0x0000000186CB58D0-0x0000000186CB5930 0x0000000186CB5C30-0x0000000186CB5CA0
	
		// Constructors
		public CinemachineExternalCamera() {} // 0x0000000186CB57A0-0x0000000186CB58D0
	
		// Methods
		// [XID] // 0x0000000189B5BD60-0x0000000189B5BD80
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186CB4FF0-0x0000000186CB57A0
	}
}
