/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace motion4hi
{
	public class ACTCamera : MonoBehaviour // TypeDefIndex: 9350
	{
		// Fields
		private Transform _followTarget; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Camera _camera; // 0x20
		public float _pitch; // 0x28
		public float _yaw; // 0x2C
		public float _focusHeight; // 0x30
		public float _focusDistance; // 0x34
		public float _speedCoeff; // 0x38
		public float _focusMaxOffset; // 0x3C
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float _focusMaxOffsetScale; // 0x40
		public float _yawSpeedOnHorizontalMove; // 0x44
		private Vector3 _focusPos; // 0x48
		private Vector3 _lastTargetPos; // 0x54
		private float _avgSpeed; // 0x60
		private List<Vector4> _movement; // 0x68
		public Vector2 _camViewInputVector; // 0x70
		private float _viewHorRatio; // 0x78
		private float _viewVerRatio; // 0x7C
		public float _viewSpringCoeff; // 0x80
		public float _viewSpeed; // 0x84
	
		// Properties
		public Transform FollowTarget { /* [XID] */ /* 0x00000001898A2A40-0x00000001898A2A60 */ get => default; /* [XID] */ /* 0x00000001898A9F60-0x00000001898A9F80 */ set {} } // 0x0000000186078030-0x00000001860780D0 0x00000001860780D0-0x0000000186078210
	
		// Constructors
		public ACTCamera() {} // 0x0000000186077F20-0x0000000186078030
	
		// Methods
		// [XID] // 0x00000001898B18B0-0x00000001898B18D0
		private void UpdateCameraFocus() {} // 0x0000000186077170-0x0000000186077A00
		// [XID] // 0x00000001898B93D0-0x00000001898B93F0
		private void UpdateCameraPose() {} // 0x0000000186077A00-0x0000000186077D50
		// [XID] // 0x0000000189B28AE0-0x0000000189B28B00
		private void OnDrawGizmos() {} // 0x0000000186076E70-0x0000000186076F10
		// [XID] // 0x00000001898C8020-0x00000001898C8040
		private void Start() {} // 0x00000001860770C0-0x0000000186077170
		// [XID] // 0x00000001898CF870-0x00000001898CF890
		private void OnGUI() {} // 0x0000000186076F10-0x00000001860770C0
		// [XID] // 0x0000000189B88460-0x0000000189B88480
		private void UpdateView() {} // 0x0000000186077D50-0x0000000186077F20
		// [XID] // 0x00000001899B4450-0x00000001899B4470
		private void LateUpdate() {} // 0x0000000186076DB0-0x0000000186076E70
	}
}
