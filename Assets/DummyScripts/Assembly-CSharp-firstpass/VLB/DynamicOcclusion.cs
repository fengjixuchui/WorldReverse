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

namespace VLB
{
	[DisallowMultipleComponent] // 0x0000000189BA2EB0-0x0000000189BA2F50
	[ExecuteInEditMode] // 0x0000000189BA2EB0-0x0000000189BA2F50
	// [HelpURL] // 0x0000000189BA2EB0-0x0000000189BA2F50
	// [RequireComponent] // 0x0000000189BA2EB0-0x0000000189BA2F50
	public class DynamicOcclusion : MonoBehaviour // TypeDefIndex: 10197
	{
		// Fields
		public LayerMask layerMask; // 0x18
		public float minOccluderArea; // 0x1C
		public int waitFrameCount; // 0x20
		public PlaneAlignment planeAlignment; // 0x24
		public float planeOffset; // 0x28
		private VolumetricLightBeam m_Master; // 0x30
		private int m_FrameCountToWait; // 0x38
		public EditorDebugData editorDebugData; // 0x40
	
		// Nested types
		public enum PlaneAlignment // TypeDefIndex: 10198
		{
			Surface = 0,
			Beam = 1
		}
	
		public struct EditorDebugData // TypeDefIndex: 10199
		{
			// Fields
			public Collider currentOccluder; // 0x00
			public int lastFrameUpdate; // 0x08
		}
	
		// Constructors
		public DynamicOcclusion() {} // 0x0000000186E96B20-0x0000000186E96BD0
	
		// Methods
		// [XID] // 0x000000018994C240-0x000000018994C260
		private void OnValidate() {} // 0x0000000186E96380-0x0000000186E96480
		// [XID] // 0x0000000189BC0440-0x0000000189BC0460
		private void OnEnable() {} // 0x0000000186E96270-0x0000000186E96380
		// [XID] // 0x0000000189A792B0-0x0000000189A792D0
		private void OnDisable() {} // 0x0000000186E961D0-0x0000000186E96270
		// [XID] // 0x0000000189AECA00-0x0000000189AECA20
		private void LateUpdate() {} // 0x0000000186E96120-0x0000000186E961D0
		// [XID] // 0x0000000189BD6E90-0x0000000189BD6EB0
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff) => default; // 0x0000000186E95F20-0x0000000186E96120
		// [XID] // 0x0000000189BDEB80-0x0000000189BDEBA0
		private RaycastHit GetBestHit() => default; // 0x0000000186E95BB0-0x0000000186E95F20
		// [XID] // 0x00000001895EB5F0-0x00000001895EB610
		private void ProcessRaycasts() {} // 0x0000000186E96480-0x0000000186E96600
		// [XID] // 0x00000001895F2A40-0x00000001895F2A60
		private void SetHit(RaycastHit hit) {} // 0x0000000186E96910-0x0000000186E96B20
		// [XID] // 0x00000001895FA300-0x00000001895FA320
		private void SetHitNull() {} // 0x0000000186E96870-0x0000000186E96910
		// [XID] // 0x000000018990CE90-0x000000018990CEB0
		private void SetClippingPlane(Plane planeWS) {} // 0x0000000186E966B0-0x0000000186E96870
		// [XID] // 0x0000000189ACE470-0x0000000189ACE490
		private void SetClippingPlaneOff() {} // 0x0000000186E96600-0x0000000186E966B0
	}
}
