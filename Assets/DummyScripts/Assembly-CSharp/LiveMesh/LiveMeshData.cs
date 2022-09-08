/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace LiveMesh
{
	public class LiveMeshData : ILiveMeshProto // TypeDefIndex: 28394
	{
		// Fields
		public string meshName; // 0x10
		public Vector3[] vertices; // 0x18
		public Vector3[] normals; // 0x20
		public Vector2[][] uv; // 0x28
		public Vector3[] tangents; // 0x30
		public Color32[] colors; // 0x38
		public Dictionary<int, int[]> triangles; // 0x40
		public string[] matNames; // 0x48
	
		// Constructors
		public LiveMeshData() {} // 0x000000018169C360-0x000000018169C3C0
	
		// Methods
		public void Serialize(ReadBuffer reader) {} // 0x000000018169C020-0x000000018169C360
	}
}
