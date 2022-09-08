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
	public struct Circle3 // TypeDefIndex: 8155
	{
		// Fields
		public Vector3 Center; // 0x00
		public Vector3 Axis0; // 0x0C
		public Vector3 Axis1; // 0x18
		public Vector3 Normal; // 0x24
		public float Radius; // 0x30
	
		// Constructors
		public Circle3(ref Vector3 center, ref Vector3 axis0, ref Vector3 axis1, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x0000000187E40030-0x0000000187E40040
		public Circle3(Vector3 center, Vector3 axis0, Vector3 axis1, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x0000000187E40040-0x0000000187E40260
		public Circle3(ref Vector3 center, ref Vector3 normal, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x0000000187E40260-0x0000000187E40270
		public Circle3(Vector3 center, Vector3 normal, float radius) {
			Center = default;
			Axis0 = default;
			Axis1 = default;
			Normal = default;
			Radius = default;
		} // 0x0000000187E40270-0x0000000187E40360
	
		// Methods
		// [XID] // 0x00000001898AB620-0x00000001898AB640
		public static bool CreateCircumscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle) {
			circle = default;
			return default;
		} // 0x0000000187E3E530-0x0000000187E3EB70
		// [XID] // 0x0000000189646920-0x0000000189646940
		public static bool CreateInscribed(Vector3 v0, Vector3 v1, Vector3 v2, out Circle3 circle) {
			circle = default;
			return default;
		} // 0x0000000187E3EB70-0x0000000187E3F3D0
		// [XID] // 0x00000001898BAD10-0x00000001898BAD30
		public float CalcPerimeter() => default; // 0x0000000187E3E520-0x0000000187E3E530
		// [XID] // 0x00000001898C1FE0-0x00000001898C2000
		public float CalcArea() => default; // 0x0000000187E3E450-0x0000000187E3E520
		// [IDTag] // 0x00000001898C9920-0x00000001898C9960
		// [XID] // 0x00000001898C9920-0x00000001898C9960
		public Vector3 Eval(float t) => default; // 0x0000000187E3F920-0x0000000187E3FAA0
		// [IDTag] // 0x00000001898D3FC0-0x00000001898D4000
		// [XID] // 0x00000001898D3FC0-0x00000001898D4000
		public Vector3 Eval(float t, float radius) => default; // 0x0000000187E3F670-0x0000000187E3F920
		// [XID] // 0x0000000189708160-0x0000000189708180
		public float DistanceTo(Vector3 point, bool solid = true /* Metadata: 0x00ADF641 */) => default; // 0x0000000187E3F3D0-0x0000000187E3F670
		// [XID] // 0x000000018970FBD0-0x000000018970FBF0
		public Vector3 Project(Vector3 point, bool solid = true /* Metadata: 0x00ADF642 */) => default; // 0x0000000187E3FAA0-0x0000000187E3FE30
		// [XID] // 0x00000001898EDF70-0x00000001898EDF90
		public override string ToString() => default; // 0x0000000187E3FE30-0x0000000187E3FEF0
	}
}
