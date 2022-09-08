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
	public static class pb_Smoothing // TypeDefIndex: 3426
	{
		// Fields
		public const int SMOOTHING_GROUP_NONE = 0; // Metadata: 0x00AC3D08
		public const int SMOOTH_RANGE_MIN = 1; // Metadata: 0x00AC3D0C
		public const int SMOOTH_RANGE_MAX = 24; // Metadata: 0x00AC3D10
		public const int HARD_RANGE_MIN = 25; // Metadata: 0x00AC3D14
		public const int HARD_RANGE_MAX = 42; // Metadata: 0x00AC3D18
	
		// Methods
		public static int GetUnusedSmoothingGroup(pb_Object pb) => default; // 0x00000001894CC620-0x00000001894CC760
		private static int GetNextUnusedSmoothingGroup(int start, HashSet<int> used) => default; // 0x00000001894CC570-0x00000001894CC620
		public static bool IsSmooth(int index) => default; // 0x00000001894CC760-0x00000001894CC7D0
		public static void ApplySmoothingGroups(pb_Object pb, IEnumerable<pb_Face> faces, float angleThreshold, Vector3[] normals = null) {} // 0x00000001894CBC70-0x00000001894CC290
		private static bool FindSoftEdgesRecursive(Vector3[] normals, pb_WingedEdge wing, float angleThreshold, HashSet<pb_Face> processed) => default; // 0x00000001894CC290-0x00000001894CC570
		private static bool IsSoftEdge(Vector3[] normals, pb_EdgeLookup left, pb_EdgeLookup right, float threshold) => default; // 0x00000001894CC7D0-0x00000001894CCAF0
	}
}
