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
	public struct Plane3 // TypeDefIndex: 8157
	{
		// Fields
		public Vector3 Normal; // 0x00
		public float Constant; // 0x0C
	
		// Constructors
		public Plane3(ref Vector3 normal, float constant) {
			Normal = default;
			Constant = default;
		} // 0x0000000188D338B0-0x0000000188D338C0
		public Plane3(Vector3 normal, float constant) {
			Normal = default;
			Constant = default;
		} // 0x0000000188D334E0-0x0000000188D33730
		public Plane3(ref Vector3 normal, ref Vector3 point) {
			Normal = default;
			Constant = default;
		} // 0x0000000188D33820-0x0000000188D338B0
		public Plane3(Vector3 normal, Vector3 point) {
			Normal = default;
			Constant = default;
		} // 0x0000000188D338C0-0x0000000188D339B0
		public Plane3(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2) {
			Normal = default;
			Constant = default;
		} // 0x0000000188D33730-0x0000000188D33820
		public Plane3(Vector3 p0, Vector3 p1, Vector3 p2) {
			Normal = default;
			Constant = default;
		} // 0x0000000188D33470-0x0000000188D334E0
	
		// Methods
		// [IDTag] // 0x0000000189930030-0x0000000189930070
		// [XID] // 0x0000000189930030-0x0000000189930070
		public static implicit operator Plane(Plane3 value) => default; // 0x0000000188D33AE0-0x0000000188D33BF0
		// [IDTag] // 0x000000018993AB70-0x000000018993ABB0
		// [XID] // 0x000000018993AB70-0x000000018993ABB0
		public static implicit operator Plane3(Plane value) => default; // 0x0000000188D339B0-0x0000000188D33AE0
		// [XID] // 0x0000000189769110-0x0000000189769130
		public Vector3 CalcOrigin() => default; // 0x0000000188D30F60-0x0000000188D311C0
		// [XID] // 0x00000001897707F0-0x0000000189770810
		public void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, out Vector3 n) {
			u = default;
			v = default;
			n = default;
		} // 0x0000000188D311C0-0x0000000188D31350
		// [IDTag] // 0x0000000189953B50-0x0000000189953B90
		// [XID] // 0x0000000189953B50-0x0000000189953B90
		internal float SignedDistanceTo(ref Vector3 point) => default; // 0x0000000188D330B0-0x0000000188D33200
		// [IDTag] // 0x000000018995E510-0x000000018995E550
		// [XID] // 0x000000018995E510-0x000000018995E550
		public float SignedDistanceTo(Vector3 point) => default; // 0x0000000188D32F60-0x0000000188D330B0
		// [XID] // 0x0000000189968BB0-0x0000000189968BD0
		public float DistanceTo(Vector3 point) => default; // 0x0000000188D31350-0x0000000188D31570
		// [IDTag] // 0x0000000189970300-0x0000000189970340
		// [XID] // 0x0000000189970300-0x0000000189970340
		public int QuerySide(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x00ADF644 */) => default; // 0x0000000188D32760-0x0000000188D32A30
		// [IDTag] // 0x000000018997AE30-0x000000018997AE70
		// [XID] // 0x000000018997AE30-0x000000018997AE70
		public bool QuerySideNegative(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x00ADF648 */) => default; // 0x0000000188D31D00-0x0000000188D31E90
		// [IDTag] // 0x00000001899853B0-0x00000001899853F0
		// [XID] // 0x00000001899853B0-0x00000001899853F0
		public bool QuerySidePositive(Vector3 point, float epsilon = 1E-05f /* Metadata: 0x00ADF64C */) => default; // 0x0000000188D32320-0x0000000188D325E0
		// [IDTag] // 0x000000018998FF10-0x000000018998FF50
		// [XID] // 0x000000018998FF10-0x000000018998FF50
		public int QuerySide(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x00ADF650 */) => default; // 0x0000000188D32A30-0x0000000188D32C80
		// [IDTag] // 0x000000018999AD90-0x000000018999ADD0
		// [XID] // 0x000000018999AD90-0x000000018999ADD0
		public bool QuerySideNegative(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x00ADF654 */) => default; // 0x0000000188D319E0-0x0000000188D31B90
		// [IDTag] // 0x00000001899A55D0-0x00000001899A5610
		// [XID] // 0x00000001899A55D0-0x00000001899A5610
		public bool QuerySidePositive(ref Box3 box, float epsilon = 1E-05f /* Metadata: 0x00ADF658 */) => default; // 0x0000000188D325E0-0x0000000188D32760
		// [IDTag] // 0x00000001899AFF70-0x00000001899AFFB0
		// [XID] // 0x00000001899AFF70-0x00000001899AFFB0
		public int QuerySide(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x00ADF65C */) => default; // 0x0000000188D32C80-0x0000000188D32E10
		// [IDTag] // 0x00000001899BA4C0-0x00000001899BA500
		// [XID] // 0x00000001899BA4C0-0x00000001899BA500
		public bool QuerySideNegative(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x00ADF660 */) => default; // 0x0000000188D31B90-0x0000000188D31D00
		// [IDTag] // 0x00000001899C4FB0-0x00000001899C4FF0
		// [XID] // 0x00000001899C4FB0-0x00000001899C4FF0
		public bool QuerySidePositive(ref AAB3 box, float epsilon = 1E-05f /* Metadata: 0x00ADF664 */) => default; // 0x0000000188D32040-0x0000000188D321B0
		// [IDTag] // 0x00000001899CF6E0-0x00000001899CF720
		// [XID] // 0x00000001899CF6E0-0x00000001899CF720
		public int QuerySide(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x00ADF668 */) => default; // 0x0000000188D32E10-0x0000000188D32F60
		// [IDTag] // 0x00000001899D9B20-0x00000001899D9B60
		// [XID] // 0x00000001899D9B20-0x00000001899D9B60
		public bool QuerySideNegative(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x00ADF66C */) => default; // 0x0000000188D31E90-0x0000000188D32040
		// [IDTag] // 0x00000001899E4290-0x00000001899E42D0
		// [XID] // 0x00000001899E4290-0x00000001899E42D0
		public bool QuerySidePositive(ref Sphere3 sphere, float epsilon = 1E-05f /* Metadata: 0x00ADF670 */) => default; // 0x0000000188D321B0-0x0000000188D32320
		// [XID] // 0x00000001897ACAC0-0x00000001897ACAE0
		public Vector3 Project(Vector3 point) => default; // 0x0000000188D31700-0x0000000188D319E0
		// [XID] // 0x0000000189640C60-0x0000000189640C80
		public Vector3 ProjectVector(Vector3 vector) => default; // 0x0000000188D31570-0x0000000188D31700
		// [IDTag] // 0x00000001899FD830-0x00000001899FD870
		// [XID] // 0x00000001899FD830-0x00000001899FD870
		public float AngleBetweenPlaneNormalAndLine(Line3 line) => default; // 0x0000000188D30C50-0x0000000188D30DF0
		// [IDTag] // 0x0000000189A07E30-0x0000000189A07E70
		// [XID] // 0x0000000189A07E30-0x0000000189A07E70
		public float AngleBetweenPlaneNormalAndLine(Vector3 direction) => default; // 0x0000000188D30AA0-0x0000000188D30C50
		// [IDTag] // 0x0000000189A126B0-0x0000000189A126F0
		// [XID] // 0x0000000189A126B0-0x0000000189A126F0
		public float AngleBetweenPlaneAndLine(Line3 line) => default; // 0x0000000188D30730-0x0000000188D308F0
		// [IDTag] // 0x0000000189A1C780-0x0000000189A1C7C0
		// [XID] // 0x0000000189A1C780-0x0000000189A1C7C0
		public float AngleBetweenPlaneAndLine(Vector3 direction) => default; // 0x0000000188D308F0-0x0000000188D30AA0
		// [XID] // 0x0000000189A26CA0-0x0000000189A26CC0
		public float AngleBetweenTwoPlanes(Plane3 anotherPlane) => default; // 0x0000000188D30DF0-0x0000000188D30F60
		// [XID] // 0x0000000189997D90-0x0000000189997DB0
		public override string ToString() => default; // 0x0000000188D33200-0x0000000188D332A0
	}
}
