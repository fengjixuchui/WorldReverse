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
	public struct Line2 // TypeDefIndex: 8146
	{
		// Fields
		public Vector2 Center; // 0x00
		public Vector2 Direction; // 0x08
	
		// Constructors
		public Line2(ref Vector2 center, ref Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000188D211E0-0x0000000188D21380
		public Line2(Vector2 center, Vector2 direction) {
			Center = default;
			Direction = default;
		} // 0x0000000188D210F0-0x0000000188D211E0
	
		// Methods
		// [IDTag] // 0x00000001899E7430-0x00000001899E7470
		// [XID] // 0x00000001899E7430-0x00000001899E7470
		public static Line2 CreateFromTwoPoints(ref Vector2 p0, ref Vector2 p1) => default; // 0x0000000188D1EF70-0x0000000188D1F0C0
		// [IDTag] // 0x00000001899F1750-0x00000001899F1790
		// [XID] // 0x00000001899F1750-0x00000001899F1790
		public static Line2 CreateFromTwoPoints(Vector2 p0, Vector2 p1) => default; // 0x0000000188D1F0C0-0x0000000188D1F220
		// [XID] // 0x00000001898C6580-0x00000001898C65A0
		public static Line2 CreatePerpToLineTrhoughPoint(Line2 line, Vector2 point) => default; // 0x0000000188D1F3B0-0x0000000188D1F5B0
		// [XID] // 0x0000000189A03850-0x0000000189A03870
		public static Line2 CreateBetweenAndEquidistantToPoints(Vector2 point0, Vector2 point1) => default; // 0x0000000188D1EE30-0x0000000188D1EF70
		// [XID] // 0x0000000189A0AD90-0x0000000189A0ADB0
		public static Line2 CreateParallelToGivenLineAtGivenDistance(Line2 line, float distance) => default; // 0x0000000188D1F220-0x0000000188D1F3B0
		// [XID] // 0x0000000189A0AB70-0x0000000189A0AB90
		public Vector2 Eval(float t) => default; // 0x0000000188D1F6F0-0x0000000188D1F7E0
		// [XID] // 0x000000018975E590-0x000000018975E5B0
		public float SignedDistanceTo(Vector2 point) => default; // 0x0000000188D20EE0-0x0000000188D21040
		// [XID] // 0x0000000189A21040-0x0000000189A21060
		public float DistanceTo(Vector2 point) => default; // 0x0000000188D1F5B0-0x0000000188D1F6F0
		// [IDTag] // 0x0000000189A283D0-0x0000000189A28410
		// [XID] // 0x0000000189A283D0-0x0000000189A28410
		public int QuerySide(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x00ADF5F8 */) => default; // 0x0000000188D20B00-0x0000000188D20D90
		// [IDTag] // 0x0000000189A32970-0x0000000189A329B0
		// [XID] // 0x0000000189A32970-0x0000000189A329B0
		public bool QuerySideNegative(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x00ADF5FC */) => default; // 0x0000000188D1FB70-0x0000000188D1FD40
		// [IDTag] // 0x0000000189A3D2B0-0x0000000189A3D2F0
		// [XID] // 0x0000000189A3D2B0-0x0000000189A3D2F0
		public bool QuerySidePositive(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x00ADF600 */) => default; // 0x0000000188D20590-0x0000000188D20740
		// [IDTag] // 0x0000000189A47A70-0x0000000189A47AB0
		// [XID] // 0x0000000189A47A70-0x0000000189A47AB0
		public int QuerySide(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x00ADF604 */) => default; // 0x0000000188D20970-0x0000000188D20B00
		// [IDTag] // 0x0000000189A51FE0-0x0000000189A52020
		// [XID] // 0x0000000189A51FE0-0x0000000189A52020
		public bool QuerySideNegative(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x00ADF608 */) => default; // 0x0000000188D1FA00-0x0000000188D1FB70
		// [IDTag] // 0x0000000189A5CBA0-0x0000000189A5CBE0
		// [XID] // 0x0000000189A5CBA0-0x0000000189A5CBE0
		public bool QuerySidePositive(ref Box2 box, float epsilon = 1E-05f /* Metadata: 0x00ADF60C */) => default; // 0x0000000188D20290-0x0000000188D20410
		// [IDTag] // 0x0000000189A67640-0x0000000189A67680
		// [XID] // 0x0000000189A67640-0x0000000189A67680
		public int QuerySide(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x00ADF610 */) => default; // 0x0000000188D20D90-0x0000000188D20EE0
		// [IDTag] // 0x0000000189A71B70-0x0000000189A71BB0
		// [XID] // 0x0000000189A71B70-0x0000000189A71BB0
		public bool QuerySideNegative(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x00ADF614 */) => default; // 0x0000000188D1FD40-0x0000000188D1FEC0
		// [IDTag] // 0x0000000189A7C630-0x0000000189A7C670
		// [XID] // 0x0000000189A7C630-0x0000000189A7C670
		public bool QuerySidePositive(ref AAB2 box, float epsilon = 1E-05f /* Metadata: 0x00ADF618 */) => default; // 0x0000000188D20080-0x0000000188D20290
		// [IDTag] // 0x0000000189A86D00-0x0000000189A86D40
		// [XID] // 0x0000000189A86D00-0x0000000189A86D40
		public int QuerySide(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x00ADF61C */) => default; // 0x0000000188D20740-0x0000000188D20970
		// [IDTag] // 0x0000000189A91760-0x0000000189A917A0
		// [XID] // 0x0000000189A91760-0x0000000189A917A0
		public bool QuerySideNegative(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x00ADF620 */) => default; // 0x0000000188D1FEC0-0x0000000188D20080
		// [IDTag] // 0x0000000189A9BDF0-0x0000000189A9BE30
		// [XID] // 0x0000000189A9BDF0-0x0000000189A9BE30
		public bool QuerySidePositive(ref Circle2 circle, float epsilon = 1E-05f /* Metadata: 0x00ADF624 */) => default; // 0x0000000188D20410-0x0000000188D20590
		// [XID] // 0x00000001898F3DE0-0x00000001898F3E00
		public Vector2 Project(Vector2 point) => default; // 0x0000000188D1F7E0-0x0000000188D1FA00
		// [XID] // 0x00000001898FB2F0-0x00000001898FB310
		public float AngleBetweenTwoLines(Line2 anotherLine, bool acuteAngleDesired = false /* Metadata: 0x00ADF628 */) => default; // 0x0000000188D1EE10-0x0000000188D1EE30
		// [XID] // 0x0000000189AB53A0-0x0000000189AB53C0
		public override string ToString() => default; // 0x0000000188D21040-0x0000000188D210E0
	}
}
