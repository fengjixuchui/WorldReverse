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
	internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 6758
	{
		// Properties
		public string Name { get; private set; } // 0x00000001866AA250-0x00000001866AA2B0 0x00000001866AA600-0x00000001866AA660
		public string Description { /* [XID] */ /* 0x00000001899527A0-0x00000001899527C0 */ get => default; } // 0x00000001866AA040-0x00000001866AA0F0 
		public int Priority { get; set; } // 0x00000001866AA350-0x00000001866AA3B0 0x00000001866AA660-0x00000001866AA6C0
		public Transform LookAt { get; set; } // 0x00000001866AA1F0-0x00000001866AA250 0x00000001866AA5A0-0x00000001866AA600
		public Transform Follow { get; set; } // 0x00000001866AA0F0-0x00000001866AA150 0x00000001866AA540-0x00000001866AA5A0
		public CameraState State { get; /* [XID] */ /* 0x000000018998E750-0x000000018998E790 */ private set; } // 0x00000001866AA3B0-0x00000001866AA4A0 0x00000001866AA6C0-0x00000001866AA7A0
		public GameObject VirtualCameraGameObject { /* [XID] */ /* 0x00000001897F58A0-0x00000001897F58C0 */ get => default; } // 0x00000001866AA4A0-0x00000001866AA540 
		public ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x00000001899A0DB0-0x00000001899A0DD0 */ get => default; } // 0x00000001866AA150-0x00000001866AA1F0 
		public ICinemachineCamera ParentCamera { /* [XID] */ /* 0x00000001899A87E0-0x00000001899A8800 */ get => default; } // 0x00000001866AA2B0-0x00000001866AA350 
	
		// Constructors
		public StaticPointVirtualCamera() {} // Dummy constructor
		public StaticPointVirtualCamera(CameraState state, string name) {} // 0x00000001866A9EF0-0x00000001866AA040
	
		// Methods
		// [XID] // 0x000000018993C2D0-0x000000018993C2F0
		public void SetState(CameraState state) {} // 0x00000001866A9C30-0x00000001866A9E10
		// [XID] // 0x00000001899B0040-0x00000001899B0060
		public bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x00000001866A9AA0-0x00000001866A9B50
		// [XID] // 0x00000001899B73D0-0x00000001899B73F0
		public void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x00000001866A9E10-0x00000001866A9EF0
		// [XID] // 0x00000001899BEE50-0x00000001899BEE70
		public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x00000001866A9B50-0x00000001866A9C30
	}
}
