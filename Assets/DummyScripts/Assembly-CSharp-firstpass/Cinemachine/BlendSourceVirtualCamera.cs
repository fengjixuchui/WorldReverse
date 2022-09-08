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
	internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 6759
	{
		// Properties
		public CinemachineBlend Blend { /* [XID] */ /* 0x0000000189A64290-0x0000000189A642D0 */ get; private set; } // 0x0000000186ED45F0-0x0000000186ED4650 0x0000000186ED4C60-0x0000000186ED4CC0
		public string Name { /* [XID] */ /* 0x000000018999CF10-0x000000018999CF30 */ get => default; } // 0x0000000186ED4920-0x0000000186ED49D0 
		public string Description { /* [XID] */ /* 0x0000000189A13F90-0x0000000189A13FB0 */ get => default; } // 0x0000000186ED4650-0x0000000186ED4740 
		public int Priority { get; set; } // 0x0000000186ED4A70-0x0000000186ED4AD0 0x0000000186ED4D80-0x0000000186ED4DE0
		public Transform LookAt { get; set; } // 0x0000000186ED48C0-0x0000000186ED4920 0x0000000186ED4D20-0x0000000186ED4D80
		public Transform Follow { get; set; } // 0x0000000186ED4740-0x0000000186ED47A0 0x0000000186ED4CC0-0x0000000186ED4D20
		public CameraState State { /* [XID] */ /* 0x0000000189A47B90-0x0000000189A47BD0 */ get; /* [XID] */ /* 0x0000000189A52080-0x0000000189A520C0 */ private set; } // 0x0000000186ED4AD0-0x0000000186ED4BC0 0x0000000186ED4DE0-0x0000000186ED4EC0
		public GameObject VirtualCameraGameObject { /* [XID] */ /* 0x0000000189A5CCB0-0x0000000189A5CCD0 */ get => default; } // 0x0000000186ED4BC0-0x0000000186ED4C60 
		public ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x0000000189A644B0-0x0000000189A644D0 */ get => default; } // 0x0000000186ED47A0-0x0000000186ED48C0 
		public ICinemachineCamera ParentCamera { /* [XID] */ /* 0x0000000189A6BDE0-0x0000000189A6BE00 */ get => default; } // 0x0000000186ED49D0-0x0000000186ED4A70 
	
		// Constructors
		public BlendSourceVirtualCamera() {} // Dummy constructor
		public BlendSourceVirtualCamera(CinemachineBlend blend, float deltaTime) {} // 0x0000000186ED43C0-0x0000000186ED45F0
	
		// Methods
		// [XID] // 0x0000000189B809F0-0x0000000189B80A10
		public bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x0000000186ED3ED0-0x0000000186ED40A0
		// [XID] // 0x0000000189A7B0B0-0x0000000189A7B0D0
		public CameraState CalculateNewState(float deltaTime) => default; // 0x0000000186ED3C50-0x0000000186ED3ED0
		// [XID] // 0x0000000189A56640-0x0000000189A56660
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186ED4180-0x0000000186ED43C0
		// [XID] // 0x0000000189A0DC40-0x0000000189A0DC60
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000186ED40A0-0x0000000186ED4180
	}
}
