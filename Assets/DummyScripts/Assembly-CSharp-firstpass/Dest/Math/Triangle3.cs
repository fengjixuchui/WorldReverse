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
	public struct Triangle3 // TypeDefIndex: 8164
	{
		// Fields
		public Vector3 V0; // 0x00
		public Vector3 V1; // 0x0C
		public Vector3 V2; // 0x18
	
		// Properties
		public Vector3 this[int index] { /* [XID] */ /* 0x000000018969D030-0x000000018969D050 */ get => default; /* [XID] */ /* 0x000000018961EBA0-0x000000018961EBC0 */ set {} } // 0x00000001874BBDC0-0x00000001874BBF00 0x00000001874BBF00-0x00000001874BBF30
	
		// Constructors
		public Triangle3(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x00000001874BBBA0-0x00000001874BBBB0
		public Triangle3(Vector3 v0, Vector3 v1, Vector3 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x00000001874BBBB0-0x00000001874BBDC0
	
		// Methods
		// [XID] // 0x0000000189AB14D0-0x0000000189AB14F0
		public Vector3 CalcEdge(int edgeIndex) => default; // 0x00000001874BAF20-0x00000001874BB120
		// [XID] // 0x0000000189631A20-0x0000000189631A40
		public Vector3 CalcNormal() => default; // 0x00000001874BB120-0x00000001874BB380
		// [IDTag] // 0x0000000189639590-0x00000001896395D0
		// [XID] // 0x0000000189639590-0x00000001896395D0
		public float CalcArea() => default; // 0x00000001874BA160-0x00000001874BA170
		// [IDTag] // 0x0000000189643B20-0x0000000189643B60
		// [XID] // 0x0000000189643B20-0x0000000189643B60
		public static float CalcArea(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001874B9DC0-0x00000001874BA160
		// [IDTag] // 0x000000018964E380-0x000000018964E3C0
		// [XID] // 0x000000018964E380-0x000000018964E3C0
		public static float CalcArea(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001874BA170-0x00000001874BA390
		// [IDTag] // 0x00000001896589E0-0x0000000189658A20
		// [XID] // 0x00000001896589E0-0x0000000189658A20
		public Vector3 CalcAnglesDeg() => default; // 0x00000001874B9700-0x00000001874B9990
		// [IDTag] // 0x0000000189662F80-0x0000000189662FC0
		// [XID] // 0x0000000189662F80-0x0000000189662FC0
		public static Vector3 CalcAnglesDeg(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001874B9060-0x00000001874B9300
		// [IDTag] // 0x000000018966D7D0-0x000000018966D810
		// [XID] // 0x000000018966D7D0-0x000000018966D810
		public static Vector3 CalcAnglesDeg(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001874B9300-0x00000001874B9700
		// [IDTag] // 0x00000001896785F0-0x0000000189678630
		// [XID] // 0x00000001896785F0-0x0000000189678630
		public Vector3 CalcAnglesRad() => default; // 0x00000001874B9990-0x00000001874B99C0
		// [IDTag] // 0x0000000189682D50-0x0000000189682D90
		// [XID] // 0x0000000189682D50-0x0000000189682D90
		public static Vector3 CalcAnglesRad(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001874B9B40-0x00000001874B9DC0
		// [IDTag] // 0x000000018968D760-0x000000018968D7A0
		// [XID] // 0x000000018968D760-0x000000018968D7A0
		public static Vector3 CalcAnglesRad(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001874B99C0-0x00000001874B9B40
		// [IDTag] // 0x0000000189698610-0x0000000189698650
		// [XID] // 0x0000000189698610-0x0000000189698650
		public Vector3 EvalBarycentric(float c0, float c1) => default; // 0x00000001874BB380-0x00000001874BB5E0
		// [IDTag] // 0x00000001896A29E0-0x00000001896A2A20
		// [XID] // 0x00000001896A29E0-0x00000001896A2A20
		public Vector3 EvalBarycentric(ref Vector3 baryCoords) => default; // 0x00000001874BB5E0-0x00000001874BB840
		// [IDTag] // 0x00000001896ACC40-0x00000001896ACC80
		// [XID] // 0x00000001896ACC40-0x00000001896ACC80
		public Vector3 EvalBarycentric(Vector3 baryCoords) => default; // 0x00000001874BB840-0x00000001874BBA30
		// [IDTag] // 0x00000001896B6FB0-0x00000001896B6FF0
		// [XID] // 0x00000001896B6FB0-0x00000001896B6FF0
		public static void CalcBarycentricCoords(ref Vector3 point, ref Vector3 v0, ref Vector3 v1, ref Vector3 v2, out Vector3 baryCoords) {
			baryCoords = default;
		} // 0x00000001874BA390-0x00000001874BAB40
		// [IDTag] // 0x00000001896C10C0-0x00000001896C1100
		// [XID] // 0x00000001896C10C0-0x00000001896C1100
		public Vector3 CalcBarycentricCoords(ref Vector3 point) => default; // 0x00000001874BAB40-0x00000001874BACC0
		// [IDTag] // 0x00000001896CB5E0-0x00000001896CB620
		// [XID] // 0x00000001896CB5E0-0x00000001896CB620
		public Vector3 CalcBarycentricCoords(Vector3 point) => default; // 0x00000001874BACC0-0x00000001874BAF20
		// [XID] // 0x00000001896D5D00-0x00000001896D5D20
		public override string ToString() => default; // 0x00000001874BBA30-0x00000001874BBAE0
	}
}
