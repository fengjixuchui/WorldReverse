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
	public struct Box3 // TypeDefIndex: 8153
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Axis2; // 0x24
		public Vector3 Extents; // 0x30
	
		// Constructors
		public Box3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, ref Vector3 axis2, ref Vector3 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000187E3AA30-0x0000000187E3AB30
		public Box3(Vector3 center, Vector3 axis0, Vector3 axis1, Vector3 axis2, Vector3 extents) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000187E3A840-0x0000000187E3AA30
		public Box3(ref AAB3 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000187E3AB30-0x0000000187E3AC30
		public Box3(AAB3 box) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Axis2 = default;
			Extents = default;
		} // 0x0000000187E3AC30-0x0000000187E3ACF0
	
		// Methods
		// [XID] // 0x0000000189837490-0x00000001898374B0
		public static Box3 CreateFromPoints(IList<Vector3> points) => default; // 0x0000000187E38B30-0x0000000187E393D0
		// [XID] // 0x000000018983E9D0-0x000000018983E9F0
		public Vector3 GetAxis(int index) => default; // 0x0000000187E39550-0x0000000187E3A080
		// [IDTag] // 0x0000000189846020-0x0000000189846060
		// [XID] // 0x0000000189846020-0x0000000189846060
		public void CalcVertices(out Vector3 vertex0, out Vector3 vertex1, out Vector3 vertex2, out Vector3 vertex3, out Vector3 vertex4, out Vector3 vertex5, out Vector3 vertex6, out Vector3 vertex7) {
			vertex0 = default;
			vertex1 = default;
			vertex2 = default;
			vertex3 = default;
			vertex4 = default;
			vertex5 = default;
			vertex6 = default;
			vertex7 = default;
		} // 0x0000000187E37F60-0x0000000187E386F0
		// [IDTag] // 0x00000001898504C0-0x0000000189850500
		// [XID] // 0x00000001898504C0-0x0000000189850500
		public Vector3[] CalcVertices() => default; // 0x0000000187E386F0-0x0000000187E387C0
		// [IDTag] // 0x000000018985AA70-0x000000018985AAB0
		// [XID] // 0x000000018985AA70-0x000000018985AAB0
		public void CalcVertices(Vector3[] array) {} // 0x0000000187E37850-0x0000000187E37F60
		// [XID] // 0x0000000189864C90-0x0000000189864CB0
		public float CalcVolume() => default; // 0x0000000187E387C0-0x0000000187E38A20
		// [XID] // 0x000000018986C220-0x000000018986C240
		public float DistanceTo(Vector3 point) => default; // 0x0000000187E393D0-0x0000000187E39550
		// [XID] // 0x0000000189604B50-0x0000000189604B70
		public Vector3 Project(Vector3 point) => default; // 0x0000000187E3A310-0x0000000187E3A690
		// [IDTag] // 0x000000018987B230-0x000000018987B270
		// [XID] // 0x000000018987B230-0x000000018987B270
		public bool Contains(ref Vector3 point) => default; // 0x0000000187E38A20-0x0000000187E38B00
		// [IDTag] // 0x0000000189885450-0x0000000189885490
		// [XID] // 0x0000000189885450-0x0000000189885490
		public bool Contains(Vector3 point) => default; // 0x0000000187E38B00-0x0000000187E38B30
		// [IDTag] // 0x000000018988F7A0-0x000000018988F7E0
		// [XID] // 0x000000018988F7A0-0x000000018988F7E0
		public void Include(ref Box3 box) {} // 0x0000000187E3A080-0x0000000187E3A180
		// [IDTag] // 0x0000000189899ED0-0x0000000189899F10
		// [XID] // 0x0000000189899ED0-0x0000000189899F10
		public void Include(Box3 box) {} // 0x0000000187E3A180-0x0000000187E3A310
		// [XID] // 0x0000000189637DC0-0x0000000189637DE0
		public override string ToString() => default; // 0x0000000187E3A690-0x0000000187E3A760
	}
}
