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

namespace ProBuilder2.Examples
{
	public class CameraControls : MonoBehaviour // TypeDefIndex: 9690
	{
		// Fields
		private const string INPUT_MOUSE_SCROLLWHEEL = "Mouse ScrollWheel"; // Metadata: 0x00AE5D10
		private const string INPUT_MOUSE_X = "Mouse X"; // Metadata: 0x00AE5D25
		private const string INPUT_MOUSE_Y = "Mouse Y"; // Metadata: 0x00AE5D30
		private const float MIN_CAM_DISTANCE = 10f; // Metadata: 0x00AE5D3B
		private const float MAX_CAM_DISTANCE = 40f; // Metadata: 0x00AE5D3F
		// [Range] // 0x0000000189AFB100-0x0000000189AFB120
		public float orbitSpeed; // 0x18
		// [Range] // 0x0000000189746120-0x0000000189746140
		public float zoomSpeed; // 0x1C
		private float distance; // 0x20
		public float idleRotation; // 0x24
		private Vector2 dir; // 0x28
	
		// Constructors
		public CameraControls() {} // 0x000000018600ACC0-0x000000018600AD70
	
		// Methods
		// [XID] // 0x0000000189B09D70-0x0000000189B09D90
		private void Start() {} // 0x000000018600AB70-0x000000018600ACC0
		// [XID] // 0x0000000189983590-0x00000001899835B0
		private void LateUpdate() {} // 0x000000018600A5B0-0x000000018600AB70
	}
}
