/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ProBuilder2.Common;

// Image 48: ProBuilderMeshOps-Unity5.dll - Assembly: ProBuilderMeshOps-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5530-5536

namespace ProBuilder2.MeshOperations
{
	public static class pb_Extrude // TypeDefIndex: 5533
	{
		// Methods
		private static bool ExtrudePerFace(pb_Object pb, pb_Face[] faces, float distance) => default; // 0x0000000189533E80-0x00000001895349A0
		private static bool ExtrudeAsGroups(pb_Object pb, pb_Face[] faces, bool compensateAngleVertexDistance, float distance) => default; // 0x00000001895326A0-0x0000000189533E80
		private static List<HashSet<pb_Face>> GetFaceGroups(List<pb_WingedEdge> wings) => default; // 0x0000000189534A60-0x0000000189534D90
		private static Dictionary<pb_EdgeLookup, pb_Face> GetPerimeterEdges(HashSet<pb_Face> faces, Dictionary<int, int> lookup) => default; // 0x0000000189534D90-0x0000000189535090
	
		// Extension methods
		public static bool Extrude(this pb_Object pb, pb_Face[] faces, ExtrudeMethod method, float distance) => default; // 0x00000001895349A0-0x0000000189534A60
	}
}
