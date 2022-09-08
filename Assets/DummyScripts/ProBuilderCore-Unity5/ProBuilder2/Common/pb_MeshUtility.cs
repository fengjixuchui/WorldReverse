/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_MeshUtility // TypeDefIndex: 3411
	{
		// Constructors
		public pb_MeshUtility() {} // 0x0000000186BB37C0-0x0000000186BB3820
	
		// Methods
		public static pb_Vertex[] GeneratePerTriangleMesh(Mesh m) => default; // 0x0000000186BB09C0-0x0000000186BB0D60
		public static void CollapseSharedVertices(Mesh m, pb_Vertex[] vertices = null) {} // 0x0000000186BAF950-0x0000000186BAFDD0
		public static void GenerateTangent(ref Mesh InMesh) {} // 0x0000000186BB0D60-0x0000000186BB1840
		public static Mesh DeepCopy(Mesh mesh) => default; // 0x0000000186BB0270-0x0000000186BB0300
		public static void CopyTo(Mesh source, Mesh destination) {} // 0x0000000186BAFDD0-0x0000000186BB0270
		public static Vector3[] GenerateNormals(pb_Object pb) => default; // 0x0000000186BB0300-0x0000000186BB09C0
		public static void SmoothNormals(pb_Object pb, ref Vector3[] normals) {} // 0x0000000186BB2F30-0x0000000186BB3740
		public static T GetMeshAttribute<T>(GameObject go, Func<Mesh, T> attributeGetter)
			where T : IList => default;
		public static string Print(Mesh m) => default; // 0x0000000186BB1840-0x0000000186BB2F30
	}
}
