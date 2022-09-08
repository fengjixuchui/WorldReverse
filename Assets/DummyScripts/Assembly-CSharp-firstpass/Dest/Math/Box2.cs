/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Dest.Math
{
	public struct Box2 // TypeDefIndex: 8144
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Axis0; // 0x08
		public Vector2 Axis1; // 0x10
		public Vector2 Extents; // 0x18
	
		// Constructors
		public Box2(ref Vector2 center, ref Vector2 axis0, ref Vector2 axis1, ref Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x000000018756C060-0x000000018756C100
		public Box2(Vector2 center, Vector2 axis0, Vector2 axis1, Vector2 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x000000018756C100-0x000000018756C210
		public Box2(ref AAB2 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x000000018756C210-0x000000018756C2F0
		public Box2(AAB2 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Extents = default;
		} // 0x000000018756C2F0-0x000000018756C310
	
		// Methods
		// [XID] // 0x00000001896646F0-0x0000000189664710
		public static Box2 CreateFromPoints(IList<Vector2> points) => default; // 0x000000018756AD30-0x000000018756B2A0
		// [XID] // 0x00000001898DA1B0-0x00000001898DA1D0
		public Vector2 GetAxis(int index) => default; // 0x000000018756B3D0-0x000000018756BA60
		// [IDTag] // 0x00000001898E1DF0-0x00000001898E1E30
		// [XID] // 0x00000001898E1DF0-0x00000001898E1E30
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x000000018756A9B0-0x000000018756AB60
		// [IDTag] // 0x00000001898EC6E0-0x00000001898EC720
		// [XID] // 0x00000001898EC6E0-0x00000001898EC720
		public Vector2[] CalcVertices() => default; // 0x000000018756A7A0-0x000000018756A9B0
		// [IDTag] // 0x00000001898F71A0-0x00000001898F71E0
		// [XID] // 0x00000001898F71A0-0x00000001898F71E0
		public void CalcVertices(Vector2[] array) {} // 0x000000018756A550-0x000000018756A7A0
		// [XID] // 0x00000001899019D0-0x00000001899019F0
		public float CalcArea() => default; // 0x000000018756A320-0x000000018756A550
		// [XID] // 0x0000000189909000-0x0000000189909020
		public float DistanceTo(Vector2 point) => default; // 0x000000018756B2A0-0x000000018756B3D0
		// [XID] // 0x000000018968A700-0x000000018968A720
		public Vector2 Project(Vector2 point) => default; // 0x000000018756BC50-0x000000018756BF00
		// [IDTag] // 0x0000000189918190-0x00000001899181D0
		// [XID] // 0x0000000189918190-0x00000001899181D0
		public bool Contains(ref Vector2 point) => default; // 0x000000018756AD20-0x000000018756AD30
		// [IDTag] // 0x00000001899229F0-0x0000000189922A30
		// [XID] // 0x00000001899229F0-0x0000000189922A30
		public bool Contains(Vector2 point) => default; // 0x000000018756AB60-0x000000018756AD20
		// [IDTag] // 0x000000018992CFE0-0x000000018992D020
		// [XID] // 0x000000018992CFE0-0x000000018992D020
		public void Include(ref Box2 box) {} // 0x000000018756BA60-0x000000018756BB40
		// [IDTag] // 0x0000000189937550-0x0000000189937590
		// [XID] // 0x0000000189937550-0x0000000189937590
		public void Include(Box2 box) {} // 0x000000018756BB40-0x000000018756BC50
		// [XID] // 0x0000000189941B70-0x0000000189941B90
		public override string ToString() => default; // 0x000000018756BF00-0x000000018756BFB0
	}
}
