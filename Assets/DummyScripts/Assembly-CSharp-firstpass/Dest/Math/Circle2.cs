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
	public struct Circle2 // TypeDefIndex: 8145
	{
		// Fields
		public Vector2 Center; // 0x00
		public float Radius; // 0x08
	
		// Constructors
		public Circle2(ref Vector2 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000187E3E380-0x0000000187E3E450
		public Circle2(Vector2 center, float radius) {
			Center = default;
			Radius = default;
		} // 0x0000000187E3E280-0x0000000187E3E380
	
		// Methods
		// [IDTag] // 0x0000000189949730-0x0000000189949770
		// [XID] // 0x0000000189949730-0x0000000189949770
		public static Circle2 CreateFromPointsAAB(IEnumerable<Vector2> points) => default; // 0x0000000187E3CBE0-0x0000000187E3CD90
		// [IDTag] // 0x0000000189953B90-0x0000000189953BD0
		// [XID] // 0x0000000189953B90-0x0000000189953BD0
		public static Circle2 CreateFromPointsAAB(IList<Vector2> points) => default; // 0x0000000187E3CD90-0x0000000187E3CEF0
		// [IDTag] // 0x000000018995E550-0x000000018995E590
		// [XID] // 0x000000018995E550-0x000000018995E590
		public static Circle2 CreateFromPointsAverage(IEnumerable<Vector2> points) => default; // 0x0000000187E3D1B0-0x0000000187E3D540
		// [IDTag] // 0x0000000189968BD0-0x0000000189968C10
		// [XID] // 0x0000000189968BD0-0x0000000189968C10
		public static Circle2 CreateFromPointsAverage(IList<Vector2> points) => default; // 0x0000000187E3CEF0-0x0000000187E3D1B0
		// [XID] // 0x0000000189874A70-0x0000000189874A90
		public static bool CreateCircumscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle) {
			circle = default;
			return default;
		} // 0x0000000187E3C830-0x0000000187E3CBE0
		// [XID] // 0x000000018987C6A0-0x000000018987C6C0
		public static bool CreateInscribed(Vector2 v0, Vector2 v1, Vector2 v2, out Circle2 circle) {
			circle = default;
			return default;
		} // 0x0000000187E3D540-0x0000000187E3D900
		// [XID] // 0x000000018982F9F0-0x000000018982FA10
		public float CalcPerimeter() => default; // 0x0000000187E3C5B0-0x0000000187E3C6F0
		// [XID] // 0x000000018998A090-0x000000018998A0B0
		public float CalcArea() => default; // 0x0000000187E3C4E0-0x0000000187E3C5B0
		// [IDTag] // 0x0000000189991A10-0x0000000189991A50
		// [XID] // 0x0000000189991A10-0x0000000189991A50
		public Vector2 Eval(float t) => default; // 0x0000000187E3DBD0-0x0000000187E3DCB0
		// [IDTag] // 0x000000018999C400-0x000000018999C440
		// [XID] // 0x000000018999C400-0x000000018999C440
		public Vector2 Eval(float t, float radius) => default; // 0x0000000187E3DA70-0x0000000187E3DBD0
		// [XID] // 0x00000001899A6DB0-0x00000001899A6DD0
		public float DistanceTo(Vector2 point) => default; // 0x0000000187E3D900-0x0000000187E3DA70
		// [XID] // 0x000000018988AF30-0x000000018988AF50
		public Vector2 Project(Vector2 point) => default; // 0x0000000187E3E000-0x0000000187E3E150
		// [IDTag] // 0x00000001899B5C40-0x00000001899B5C80
		// [XID] // 0x00000001899B5C40-0x00000001899B5C80
		public bool Contains(ref Vector2 point) => default; // 0x0000000187E3C820-0x0000000187E3C830
		// [IDTag] // 0x00000001899C0500-0x00000001899C0540
		// [XID] // 0x00000001899C0500-0x00000001899C0540
		public bool Contains(Vector2 point) => default; // 0x0000000187E3C6F0-0x0000000187E3C820
		// [IDTag] // 0x00000001899CAD50-0x00000001899CAD90
		// [XID] // 0x00000001899CAD50-0x00000001899CAD90
		public void Include(ref Circle2 circle) {} // 0x0000000187E3DF10-0x0000000187E3E000
		// [IDTag] // 0x00000001899D52E0-0x00000001899D5320
		// [XID] // 0x00000001899D52E0-0x00000001899D5320
		public void Include(Circle2 circle) {} // 0x0000000187E3DCB0-0x0000000187E3DF10
		// [XID] // 0x00000001899DF920-0x00000001899DF940
		public override string ToString() => default; // 0x0000000187E3E150-0x0000000187E3E200
	}
}
