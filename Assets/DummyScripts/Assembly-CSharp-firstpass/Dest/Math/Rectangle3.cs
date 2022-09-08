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
	public struct Rectangle3 // TypeDefIndex: 8161
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public Vector2 Extents; // 0x30
	
		// Constructors
		public Rectangle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Extents = default;
		} // 0x00000001874AB660-0x00000001874AB670
		public Rectangle3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Extents = default;
		} // 0x00000001874AB3F0-0x00000001874AB660
	
		// Methods
		// [XID] // 0x0000000189AF80B0-0x0000000189AF80D0
		public static Rectangle3 CreateFromCCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x00000001874AA550-0x00000001874AA930
		// [XID] // 0x00000001897D2CA0-0x00000001897D2CC0
		public static Rectangle3 CreateFromCWPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) => default; // 0x00000001874AA930-0x00000001874AAE00
		// [IDTag] // 0x0000000189B06D70-0x0000000189B06DB0
		// [XID] // 0x0000000189B06D70-0x0000000189B06DB0
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x00000001874A9DF0-0x00000001874AA1A0
		// [IDTag] // 0x0000000189B117E0-0x0000000189B11820
		// [XID] // 0x0000000189B117E0-0x0000000189B11820
		public Vector3[] CalcVertices() => default; // 0x00000001874AA1A0-0x00000001874AA540
		// [IDTag] // 0x0000000189B1BAA0-0x0000000189B1BAE0
		// [XID] // 0x0000000189B1BAA0-0x0000000189B1BAE0
		public void CalcVertices(Vector3[] array) {} // 0x00000001874AA540-0x00000001874AA550
		// [XID] // 0x00000001897F1180-0x00000001897F11A0
		public float CalcArea() => default; // 0x00000001874A9A90-0x00000001874A9DF0
		// [XID] // 0x000000018960AC60-0x000000018960AC80
		public float DistanceTo(Vector3 point) => default; // 0x00000001874AAE00-0x00000001874AAF70
		// [XID] // 0x0000000189B348F0-0x0000000189B34910
		public Vector3 Project(Vector3 point) => default; // 0x00000001874AAF70-0x00000001874AB320
		// [XID] // 0x0000000189B3C1F0-0x0000000189B3C210
		public override string ToString() => default; // 0x00000001874AB320-0x00000001874AB3E0
	}
}
