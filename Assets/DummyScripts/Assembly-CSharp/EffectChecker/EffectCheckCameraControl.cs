/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace EffectChecker
{
	public class EffectCheckCameraControl : MonoBehaviour // TypeDefIndex: 19778
	{
		// Fields
		private const string INPUT_MOUSE_SCROLLWHEEL = "Mouse ScrollWheel"; // Metadata: 0x00AFCD0C
		private const string INPUT_MOUSE_X = "Mouse X"; // Metadata: 0x00AFCD21
		private const string INPUT_MOUSE_Y = "Mouse Y"; // Metadata: 0x00AFCD2C
		private const float MIN_CAM_DISTANCE = 2f; // Metadata: 0x00AFCD37
		private const float MAX_CAM_DISTANCE = 30f; // Metadata: 0x00AFCD3B
		// [Range] // 0x0000000189AFB100-0x0000000189AFB120
		public float orbitSpeed; // 0x18
		// [Range] // 0x0000000189746120-0x0000000189746140
		public float zoomSpeed; // 0x1C
		public float transSpeed; // 0x20
		public Bounds targetBounds; // 0x24
		private float distance; // 0x3C
		private float _lastTime; // 0x40
		private Vector3 _originPosition; // 0x44
		private Vector3 _offset; // 0x50
		private Quaternion _originRotation; // 0x5C
	
		// Constructors
		public EffectCheckCameraControl() {} // 0x0000000182BDB8C0-0x0000000182BDB9E0
	
		// Methods
		private void Start() {} // 0x0000000182BDB750-0x0000000182BDB8C0
		public void Reset() {} // 0x0000000182BDB560-0x0000000182BDB750
		private void LateUpdate() {} // 0x0000000182BDAF30-0x0000000182BDB560
	}
}
