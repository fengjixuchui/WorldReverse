/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using ProBuilder2.Common;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ProBuilder2.Examples
{
	public class RuntimeEdit : MonoBehaviour // TypeDefIndex: 9696
	{
		// Fields
		private pb_Selection currentSelection; // 0x18
		private pb_Selection previousSelection; // 0x20
		private pb_Object preview; // 0x28
		public UnityEngine.Material previewMaterial; // 0x30
		private Vector2 mousePosition_initial; // 0x38
		private bool dragging; // 0x40
		public float rotateSpeed; // 0x44
	
		// Nested types
		private class pb_Selection // TypeDefIndex: 9697
		{
			// Fields
			public pb_Object pb; // 0x10
			public pb_Face face; // 0x18
	
			// Constructors
			public pb_Selection() {} // Dummy constructor
			public pb_Selection(pb_Object _pb, pb_Face _face) {} // 0x0000000186028F40-0x0000000186028FD0
	
			// Methods
			// [XID] // 0x0000000189831DE0-0x0000000189831E00
			public bool HasObject() => default; // 0x0000000186028B90-0x0000000186028C60
			// [XID] // 0x00000001898D1950-0x00000001898D1970
			public bool IsValid() => default; // 0x0000000186028C60-0x0000000186028D50
			// [XID] // 0x0000000189AC6D80-0x0000000189AC6DA0
			public bool Equals(pb_Selection sel) => default; // 0x0000000186028A70-0x0000000186028B90
			// [XID] // 0x00000001895EB6D0-0x00000001895EB6F0
			public void Destroy() {} // 0x0000000186028950-0x0000000186028A70
			// [XID] // 0x00000001899F1CC0-0x00000001899F1CE0
			public override string ToString() => default; // 0x0000000186028D50-0x0000000186028ED0
		}
	
		// Constructors
		public RuntimeEdit() {} // 0x000000018601D880-0x000000018601D920
	
		// Methods
		// [XID] // 0x0000000189B9B800-0x0000000189B9B820
		private void Awake() {} // 0x000000018601C3F0-0x000000018601C490
		// [XID] // 0x0000000189BA3010-0x0000000189BA3030
		private void OnGUI() {} // 0x000000018601CCE0-0x000000018601CE90
		// [XID] // 0x0000000189BAA2C0-0x0000000189BAA2E0
		private void SpawnCube() {} // 0x000000018601D2B0-0x000000018601D450
		// [XID] // 0x0000000189A7CE90-0x0000000189A7CEB0
		public void LateUpdate() {} // 0x000000018601C890-0x000000018601CCE0
		// [XID] // 0x0000000189BB8B40-0x0000000189BB8B60
		public void Update() {} // 0x000000018601D450-0x000000018601D880
		// [XID] // 0x0000000189BC04F0-0x0000000189BC0510
		public bool FaceCheck(Vector3 pos) => default; // 0x000000018601C490-0x000000018601C890
		// [XID] // 0x0000000189BC7DE0-0x0000000189BC7E00
		private void RefreshSelectedFacePreview() {} // 0x000000018601CE90-0x000000018601D2B0
	}
}
