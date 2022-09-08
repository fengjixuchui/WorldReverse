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
	public struct Line3 // TypeDefIndex: 8156
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Direction; // 0x0C
	
		// Constructors
		public Line3(ref Vector3 center, ref Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000188D21F90-0x0000000188D21FA0
		public Line3(Vector3 center, Vector3 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000188D21E60-0x0000000188D21F90
	
		// Methods
		// [IDTag] // 0x00000001898F5830-0x00000001898F5870
		// [XID] // 0x00000001898F5830-0x00000001898F5870
		public static Line3 CreateFromTwoPoints(ref Vector3 p0, ref Vector3 p1) => default; // 0x0000000188D215A0-0x0000000188D21830
		// [IDTag] // 0x00000001899002B0-0x00000001899002F0
		// [XID] // 0x00000001899002B0-0x00000001899002F0
		public static Line3 CreateFromTwoPoints(Vector3 p0, Vector3 p1) => default; // 0x0000000188D213B0-0x0000000188D215A0
		// [XID] // 0x000000018990A7A0-0x000000018990A7C0
		public Vector3 Eval(float t) => default; // 0x0000000188D219F0-0x0000000188D21B60
		// [XID] // 0x000000018973C800-0x000000018973C820
		public float DistanceTo(Vector3 point) => default; // 0x0000000188D21830-0x0000000188D219F0
		// [XID] // 0x0000000189919C70-0x0000000189919C90
		public Vector3 Project(Vector3 point) => default; // 0x0000000188D21B60-0x0000000188D21D10
		// [XID] // 0x000000018974B850-0x000000018974B870
		public float AngleBetweenTwoLines(Line3 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x00ADF643 */) => default; // 0x0000000188D21380-0x0000000188D213B0
		// [XID] // 0x0000000189752C90-0x0000000189752CB0
		public override string ToString() => default; // 0x0000000188D21D10-0x0000000188D21DC0
	}
}
