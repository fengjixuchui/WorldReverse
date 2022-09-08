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
	public struct AAB2 // TypeDefIndex: 8143
	{
		// Fields
		public Vector2 Min; // 0x00
		public Vector2 Max; // 0x08
	
		// Constructors
		public AAB2(ref Vector2 min, ref Vector2 max) {
			Min = default;
			Max = default;
		} // 0x00000001875645E0-0x00000001875645F0
		public AAB2(Vector2 min, Vector2 max) {
			Min = default;
			Max = default;
		} // 0x0000000187564440-0x0000000187564550
		public AAB2(float xMin, float xMax, float yMin, float yMax) {
			Min = default;
			Max = default;
		} // 0x0000000187564550-0x00000001875645E0
	
		// Methods
		// [IDTag] // 0x00000001897F2D40-0x00000001897F2D80
		// [XID] // 0x00000001897F2D40-0x00000001897F2D80
		public static implicit operator Rect(AAB2 value) => default; // 0x0000000187564760-0x00000001875649C0
		// [IDTag] // 0x00000001897FD260-0x00000001897FD2A0
		// [XID] // 0x00000001897FD260-0x00000001897FD2A0
		public static implicit operator AAB2(Rect value) => default; // 0x00000001875645F0-0x0000000187564760
		// [IDTag] // 0x0000000189807980-0x00000001898079C0
		// [XID] // 0x0000000189807980-0x00000001898079C0
		public static AAB2 CreateFromPoint(ref Vector2 point) => default; // 0x0000000187563340-0x0000000187563430
		// [IDTag] // 0x0000000189811E70-0x0000000189811EB0
		// [XID] // 0x0000000189811E70-0x0000000189811EB0
		public static AAB2 CreateFromPoint(Vector2 point) => default; // 0x0000000187563430-0x0000000187563520
		// [IDTag] // 0x000000018981C8A0-0x000000018981C8E0
		// [XID] // 0x000000018981C8A0-0x000000018981C8E0
		public static AAB2 CreateFromTwoPoints(ref Vector2 point0, ref Vector2 point1) => default; // 0x0000000187563B60-0x0000000187563D60
		// [IDTag] // 0x0000000189826FE0-0x0000000189827020
		// [XID] // 0x0000000189826FE0-0x0000000189827020
		public static AAB2 CreateFromTwoPoints(Vector2 point0, Vector2 point1) => default; // 0x0000000187563A60-0x0000000187563B60
		// [IDTag] // 0x0000000189831350-0x0000000189831390
		// [XID] // 0x0000000189831350-0x0000000189831390
		public static AAB2 CreateFromPoints(IEnumerable<Vector2> points) => default; // 0x0000000187563520-0x00000001875636E0
		// [IDTag] // 0x000000018983B8B0-0x000000018983B8F0
		// [XID] // 0x000000018983B8B0-0x000000018983B8F0
		public static AAB2 CreateFromPoints(IList<Vector2> points) => default; // 0x00000001875636E0-0x00000001875638E0
		// [IDTag] // 0x0000000189846060-0x00000001898460A0
		// [XID] // 0x0000000189846060-0x00000001898460A0
		public static AAB2 CreateFromPoints(Vector2[] points) => default; // 0x00000001875638E0-0x0000000187563A60
		// [XID] // 0x0000000189933060-0x0000000189933080
		public void CalcCenterExtents(out Vector2 center, out Vector2 extents) {
			center = default;
			extents = default;
		} // 0x0000000187562CD0-0x0000000187562E80
		// [IDTag] // 0x0000000189857710-0x0000000189857750
		// [XID] // 0x0000000189857710-0x0000000189857750
		public void CalcVertices(out Vector2 vertex0, out Vector2 vertex1, out Vector2 vertex2, out Vector2 vertex3) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
		} // 0x0000000187562FB0-0x0000000187563140
		// [IDTag] // 0x0000000189861B30-0x0000000189861B70
		// [XID] // 0x0000000189861B30-0x0000000189861B70
		public Vector2[] CalcVertices() => default; // 0x0000000187562E80-0x0000000187562FB0
		// [IDTag] // 0x000000018986C240-0x000000018986C280
		// [XID] // 0x000000018986C240-0x000000018986C280
		public void CalcVertices(Vector2[] array) {} // 0x0000000187563140-0x0000000187563230
		// [XID] // 0x00000001898766D0-0x00000001898766F0
		public float CalcArea() => default; // 0x0000000187562BB0-0x0000000187562CD0
		// [XID] // 0x000000018987E3D0-0x000000018987E3F0
		public float DistanceTo(Vector2 point) => default; // 0x0000000187563D60-0x0000000187563E70
		// [XID] // 0x0000000189885490-0x00000001898854B0
		public Vector2 Project(Vector2 point) => default; // 0x0000000187564230-0x0000000187564390
		// [IDTag] // 0x000000018988C9D0-0x000000018988CA10
		// [XID] // 0x000000018988C9D0-0x000000018988CA10
		public bool Contains(ref Vector2 point) => default; // 0x0000000187563230-0x0000000187563320
		// [IDTag] // 0x0000000189896D90-0x0000000189896DD0
		// [XID] // 0x0000000189896D90-0x0000000189896DD0
		public bool Contains(Vector2 point) => default; // 0x0000000187563320-0x0000000187563340
		// [IDTag] // 0x00000001898A11E0-0x00000001898A1220
		// [XID] // 0x00000001898A11E0-0x00000001898A1220
		public void Include(ref Vector2 point) {} // 0x0000000187563E70-0x0000000187563F70
		// [IDTag] // 0x00000001898AB640-0x00000001898AB680
		// [XID] // 0x00000001898AB640-0x00000001898AB680
		public void Include(Vector2 point) {} // 0x0000000187563F70-0x0000000187564050
		// [IDTag] // 0x00000001898B5F50-0x00000001898B5F90
		// [XID] // 0x00000001898B5F50-0x00000001898B5F90
		public void Include(ref AAB2 box) {} // 0x0000000187564050-0x0000000187564130
		// [IDTag] // 0x00000001898C0960-0x00000001898C09A0
		// [XID] // 0x00000001898C0960-0x00000001898C09A0
		public void Include(AAB2 box) {} // 0x0000000187564130-0x0000000187564230
		// [XID] // 0x00000001898CB100-0x00000001898CB120
		public override string ToString() => default; // 0x0000000187564390-0x0000000187564430
	}
}
