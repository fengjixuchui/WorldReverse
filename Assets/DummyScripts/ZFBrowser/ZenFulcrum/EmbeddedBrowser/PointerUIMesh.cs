/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	// [RequireComponent] // 0x00000001898289B0-0x0000000189828A00
	public class PointerUIMesh : PointerUIBase // TypeDefIndex: 6075
	{
		// Fields
		protected MeshCollider meshCollider; // 0xC8
		protected Dictionary<int, RaycastHit> rayHits; // 0xD0
		// [Tooltip] // 0x0000000189834570-0x00000001898345A0
		public LayerMask layerMask; // 0xD8
	
		// Constructors
		public PointerUIMesh() {} // 0x00000001856B92A0-0x00000001856B9350
	
		// Methods
		public override void Awake() {} // 0x00000001856B8BE0-0x00000001856B8C60
		protected override Vector2 MapPointerToBrowser(Vector2 screenPosition, int pointerId) => default; // 0x00000001856B8EE0-0x00000001856B9050
		protected override Vector2 MapRayToBrowser(Ray worldRay, int pointerId) => default; // 0x00000001856B9050-0x00000001856B92A0
		public override void GetCurrentHitLocation(out Vector3 pos, out Quaternion rot) {
			pos = default;
			rot = default;
		} // 0x00000001856B8C60-0x00000001856B8EE0
	}
}
