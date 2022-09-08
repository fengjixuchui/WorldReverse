/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class ExplosionController : MonoBehaviour // TypeDefIndex: 26652
	{
		// Fields
		public float zGap; // 0x18
		private float step; // 0x1C
		private GameObject _mainCamera; // 0x20
		private const int _vertexCount = 30; // Metadata: 0x00B0C84D
		public static float scopeRadius; // 0x00
		public static float force; // 0x04
		public static bool active; // 0x08
		public static bool explosionSignal; // 0x09
		private float deltaAng; // 0x28
	
		// Constructors
		public ExplosionController() {} // 0x0000000181F6F800-0x0000000181F6F880
		static ExplosionController() {} // 0x0000000181F6F780-0x0000000181F6F800
	
		// Methods
		// [XID] // 0x0000000189BB3660-0x0000000189BB3680
		private void Start() {} // 0x0000000181F6EFF0-0x0000000181F6F1B0
		// [XID] // 0x0000000189BBACA0-0x0000000189BBACC0
		public static Vector3 RotateRound(Vector3 position, Vector3 center, Vector3 axis, float angle) => default; // 0x0000000181F6ED80-0x0000000181F6EFF0
		// [XID] // 0x0000000189BC2C90-0x0000000189BC2CB0
		private void DrawLongitude(Vector3 beginPoint, Vector3 endPoint, Vector3 core, Vector3 axis) {} // 0x0000000181F6E870-0x0000000181F6ED80
		// [XID] // 0x0000000189BCA360-0x0000000189BCA380
		private void SelectNFocus() {} // 0x0000000181F6E730-0x0000000181F6E7D0
		// [XID] // 0x0000000189BD1A10-0x0000000189BD1A30
		private void OnDrawGizmos() {} // 0x0000000181F6E7D0-0x0000000181F6E870
		// [XID] // 0x0000000189BD9000-0x0000000189BD9020
		private void MoveSlef() {} // 0x0000000181F6E470-0x0000000181F6E730
		// [XID] // 0x00000001895E5BD0-0x00000001895E5BF0
		private void Update() {} // 0x0000000181F6F1B0-0x0000000181F6F780
	}
}
