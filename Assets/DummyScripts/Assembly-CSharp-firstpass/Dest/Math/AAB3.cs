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
	public struct AAB3 // TypeDefIndex: 8152
	{
		// Fields
		public Vector3 Min; // 0x00
		public Vector3 Max; // 0x0C
	
		// Constructors
		public AAB3(ref Vector3 min, ref Vector3 max) {
			Min = default;
			Max = default;
		} // 0x0000000187566B50-0x0000000187566C20
		public AAB3(Vector3 min, Vector3 max) {
			Min = default;
			Max = default;
		} // 0x0000000187566CC0-0x0000000187566D60
		public AAB3(float xMin, float xMax, float yMin, float yMax, float zMin, float zMax) {
			Min = default;
			Max = default;
		} // 0x0000000187566C20-0x0000000187566CC0
	
		// Methods
		// [IDTag] // 0x00000001897548F0-0x0000000189754930
		// [XID] // 0x00000001897548F0-0x0000000189754930
		public static implicit operator Bounds(AAB3 value) => default; // 0x0000000187566D60-0x0000000187566EF0
		// [IDTag] // 0x000000018975EED0-0x000000018975EF10
		// [XID] // 0x000000018975EED0-0x000000018975EF10
		public static implicit operator AAB3(Bounds value) => default; // 0x0000000187566EF0-0x0000000187567040
		// [IDTag] // 0x0000000189769310-0x0000000189769350
		// [XID] // 0x0000000189769310-0x0000000189769350
		public static AAB3 CreateFromPoint(ref Vector3 point) => default; // 0x0000000187565500-0x0000000187565610
		// [IDTag] // 0x0000000189773A20-0x0000000189773A60
		// [XID] // 0x0000000189773A20-0x0000000189773A60
		public static AAB3 CreateFromPoint(Vector3 point) => default; // 0x0000000187565610-0x0000000187565750
		// [IDTag] // 0x000000018977E060-0x000000018977E0A0
		// [XID] // 0x000000018977E060-0x000000018977E0A0
		public static AAB3 CreateFromTwoPoints(ref Vector3 point0, ref Vector3 point1) => default; // 0x0000000187565EC0-0x0000000187566050
		// [IDTag] // 0x00000001897889A0-0x00000001897889E0
		// [XID] // 0x00000001897889A0-0x00000001897889E0
		public static AAB3 CreateFromTwoPoints(Vector3 point0, Vector3 point1) => default; // 0x0000000187566050-0x0000000187566290
		// [IDTag] // 0x0000000189792E90-0x0000000189792ED0
		// [XID] // 0x0000000189792E90-0x0000000189792ED0
		public static AAB3 CreateFromPoints(IEnumerable<Vector3> points) => default; // 0x0000000187565BD0-0x0000000187565EC0
		// [IDTag] // 0x000000018979E190-0x000000018979E1D0
		// [XID] // 0x000000018979E190-0x000000018979E1D0
		public static AAB3 CreateFromPoints(IList<Vector3> points) => default; // 0x0000000187565750-0x0000000187565A20
		// [IDTag] // 0x00000001897A8430-0x00000001897A8470
		// [XID] // 0x00000001897A8430-0x00000001897A8470
		public static AAB3 CreateFromPoints(Vector3[] points) => default; // 0x0000000187565A20-0x0000000187565BD0
		// [XID] // 0x00000001897B2EF0-0x00000001897B2F10
		public void CalcCenterExtents(out Vector3 center, out Vector3 extents) {
			center = default;
			extents = default;
		} // 0x00000001875649C0-0x0000000187564CC0
		// [IDTag] // 0x00000001897BAA90-0x00000001897BAAD0
		// [XID] // 0x00000001897BAA90-0x00000001897BAAD0
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
			vertex4 = default;
			vertex5 = default;
			vertex6 = default;
			vertex7 = default;
		} // 0x0000000187564ED0-0x00000001875651E0
		// [IDTag] // 0x00000001897C5A90-0x00000001897C5AD0
		// [XID] // 0x00000001897C5A90-0x00000001897C5AD0
		public Vector3[] CalcVertices() => default; // 0x00000001875651E0-0x00000001875652C0
		// [IDTag] // 0x00000001897D0090-0x00000001897D00D0
		// [XID] // 0x00000001897D0090-0x00000001897D00D0
		public void CalcVertices(Vector3[] array) {} // 0x0000000187564CC0-0x0000000187564ED0
		// [XID] // 0x0000000189B96D60-0x0000000189B96D80
		public float CalcVolume() => default; // 0x00000001875652C0-0x00000001875653C0
		// [XID] // 0x00000001897E20A0-0x00000001897E20C0
		public float DistanceTo(Vector3 point) => default; // 0x0000000187566290-0x00000001875663E0
		// [XID] // 0x0000000189BA5AD0-0x0000000189BA5AF0
		public Vector3 Project(Vector3 point) => default; // 0x0000000187566850-0x0000000187566A00
		// [IDTag] // 0x00000001897F14C0-0x00000001897F1500
		// [XID] // 0x00000001897F14C0-0x00000001897F1500
		public bool Contains(ref Vector3 point) => default; // 0x00000001875653C0-0x00000001875654D0
		// [IDTag] // 0x00000001897FBEE0-0x00000001897FBF20
		// [XID] // 0x00000001897FBEE0-0x00000001897FBF20
		public bool Contains(Vector3 point) => default; // 0x00000001875654D0-0x0000000187565500
		// [IDTag] // 0x0000000189805F20-0x0000000189805F60
		// [XID] // 0x0000000189805F20-0x0000000189805F60
		public void Include(ref Vector3 point) {} // 0x0000000187566700-0x0000000187566850
		// [IDTag] // 0x00000001898108B0-0x00000001898108F0
		// [XID] // 0x00000001898108B0-0x00000001898108F0
		public void Include(Vector3 point) {} // 0x00000001875663E0-0x00000001875664D0
		// [IDTag] // 0x000000018981B100-0x000000018981B140
		// [XID] // 0x000000018981B100-0x000000018981B140
		public void Include(ref AAB3 box) {} // 0x00000001875664D0-0x00000001875665C0
		// [IDTag] // 0x00000001898255E0-0x0000000189825620
		// [XID] // 0x00000001898255E0-0x0000000189825620
		public void Include(AAB3 box) {} // 0x00000001875665C0-0x0000000187566700
		// [XID] // 0x0000000189BCB380-0x0000000189BCB3A0
		public override string ToString() => default; // 0x0000000187566A00-0x0000000187566AB0
	}
}
