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

namespace Dest.Math
{
	public class IndexedTrianglesSampler : TrianglesSamplerBase // TypeDefIndex: 8185
	{
		// Fields
		protected int[] _indices; // 0x30
	
		// Constructors
		public IndexedTrianglesSampler() {} // Dummy constructor
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices) {} // 0x00000001872CC360-0x00000001872CC420
		public IndexedTrianglesSampler(Vector3[] vertices, int[] indices, Rand rand) {} // 0x00000001872CC420-0x00000001872CC4B0
		public IndexedTrianglesSampler(Mesh mesh) {} // 0x00000001872CC1C0-0x00000001872CC2A0
		public IndexedTrianglesSampler(Mesh mesh, Rand rand) {} // 0x00000001872CC2A0-0x00000001872CC360
	
		// Methods
		// [XID] // 0x0000000189A97850-0x0000000189A97870
		protected void Init() {} // 0x00000001872CB160-0x00000001872CB750
		// [XID] // 0x00000001897F6B00-0x00000001897F6B20
		public Vector3 Sample() => default; // 0x00000001872CBF80-0x00000001872CC1C0
		// [IDTag] // 0x0000000189AA6540-0x0000000189AA6580
		// [XID] // 0x0000000189AA6540-0x0000000189AA6580
		public Vector3[] SampleArray(int count) => default; // 0x00000001872CBCB0-0x00000001872CBF80
		// [IDTag] // 0x0000000189AB0C20-0x0000000189AB0C60
		// [XID] // 0x0000000189AB0C20-0x0000000189AB0C60
		public Vector3[] SampleArray(int count, Vector2[] uvs, Texture2D sampleMap, float min = 0f /* Metadata: 0x00ADF6C0 */, float max = 1f /* Metadata: 0x00ADF6C4 */) => default; // 0x00000001872CB750-0x00000001872CBCB0
	}
}
