/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public class pb_UVUtility // TypeDefIndex: 3433
	{
		// Fields
		private static Vector2 tvec2; // 0x00
	
		// Constructors
		public pb_UVUtility() {} // 0x00000001894D04A0-0x00000001894D0500
		static pb_UVUtility() {} // 0x00000001894D0410-0x00000001894D04A0
	
		// Methods
		public static void PlanarMap2(Vector3[] verts, Vector2[] uvs, int[] indices, pb_UV uvSettings, Vector3 normal) {} // 0x00000001894D00E0-0x00000001894D0230
		private static void ApplyUVSettings(Vector2[] uvs, int[] indices, pb_UV uvSettings) {} // 0x00000001894CF730-0x00000001894CFC90
		private static Vector2[] StretchUVs(Vector2[] uvs, int[] indices) => default; // 0x00000001894D0230-0x00000001894D0410
		private static Vector2[] NormalizeUVs(Vector2[] uvs, int[] indices) => default; // 0x00000001894CFEC0-0x00000001894D00E0
		[Obsolete] // 0x0000000189AAC3D0-0x0000000189AAC400
		private static Vector2[] JustifyUVs(Vector2[] uvs, pb_UV.Justify j) => default; // 0x00000001894CFC90-0x00000001894CFEC0
		private static void ApplyUVAnchor(Vector2[] uvs, int[] indices, pb_UV.Anchor anchor) {} // 0x00000001894CF360-0x00000001894CF730
	}
}
