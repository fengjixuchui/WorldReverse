/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pb_Object_Utility // TypeDefIndex: 3417
	{
		// Extension methods
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb) => default; // 0x0000000186BB4740-0x0000000186BB48D0
		public static Vector3[] VerticesInWorldSpace(this pb_Object pb, int[] indices) => default; // 0x0000000186BB48D0-0x0000000186BB4A50
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset) {} // 0x0000000186BB3DA0-0x0000000186BB3E60
		public static void TranslateVertices_World(this pb_Object pb, int[] selectedTriangles, Vector3 offset, float snapValue, bool snapAxisOnly, Dictionary<int, int> lookup) {} // 0x0000000186BB3E60-0x0000000186BB4530
		public static void TranslateVertices(this pb_Object pb, int[] selectedTriangles, Vector3 offset) {} // 0x0000000186BB4530-0x0000000186BB4740
		public static void SetSharedVertexPosition(this pb_Object pb, int sharedIndex, Vector3 position) {} // 0x0000000186BB3A80-0x0000000186BB3C10
		public static void SetSharedVertexValues(this pb_Object pb, int sharedIndex, pb_Vertex vertex) {} // 0x0000000186BB3C10-0x0000000186BB3DA0
		public static bool FaceWithTriangle(this pb_Object pb, int[] tri, out pb_Face face) {
			face = default;
			return default;
		} // 0x0000000186BB3820-0x0000000186BB3970
		public static bool FaceWithTriangle(this pb_Object pb, int[] tri, out int face) {
			face = default;
			return default;
		} // 0x0000000186BB3970-0x0000000186BB3A80
	}
}
