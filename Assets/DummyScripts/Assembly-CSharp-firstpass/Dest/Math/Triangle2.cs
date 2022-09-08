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
	public struct Triangle2 // TypeDefIndex: 8151
	{
		// Fields
		public Vector2 V0; // 0x00
		public Vector2 V1; // 0x08
		public Vector2 V2; // 0x10
	
		// Properties
		public Vector2 this[int index] { /* [XID] */ /* 0x0000000189A109C0-0x0000000189A109E0 */ get => default; /* [XID] */ /* 0x0000000189636740-0x0000000189636760 */ set {} } // 0x00000001874B8AE0-0x00000001874B8BE0 0x00000001874B8BE0-0x00000001874B8D90
	
		// Constructors
		public Triangle2(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x00000001874B8910-0x00000001874B89A0
		public Triangle2(Vector2 v0, Vector2 v1, Vector2 v2) : this() {
			V0 = default;
			V1 = default;
			V2 = default;
		} // 0x00000001874B89A0-0x00000001874B8AE0
	
		// Methods
		// [XID] // 0x000000018963DD30-0x000000018963DD50
		public Vector2 CalcEdge(int edgeIndex) => default; // 0x00000001874B73E0-0x00000001874B74D0
		// [XID] // 0x00000001896453D0-0x00000001896453F0
		public float CalcDeterminant() => default; // 0x00000001874B7280-0x00000001874B73E0
		// [XID] // 0x000000018964CE30-0x000000018964CE50
		public Orientations CalcOrientation(float threshold = 1E-05f /* Metadata: 0x00ADF635 */) => default; // 0x00000001874B74D0-0x00000001874B75A0
		// [IDTag] // 0x00000001896541D0-0x0000000189654210
		// [XID] // 0x00000001896541D0-0x0000000189654210
		public float CalcArea() => default; // 0x00000001874B67C0-0x00000001874B67D0
		// [IDTag] // 0x000000018965E970-0x000000018965E9B0
		// [XID] // 0x000000018965E970-0x000000018965E9B0
		public static float CalcArea(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x00000001874B67D0-0x00000001874B6970
		// [IDTag] // 0x0000000189669370-0x00000001896693B0
		// [XID] // 0x0000000189669370-0x00000001896693B0
		public static float CalcArea(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x00000001874B6530-0x00000001874B67C0
		// [IDTag] // 0x0000000189673E00-0x0000000189673E40
		// [XID] // 0x0000000189673E00-0x0000000189673E40
		public Vector3 CalcAnglesDeg() => default; // 0x00000001874B5F30-0x00000001874B6180
		// [IDTag] // 0x000000018967E440-0x000000018967E480
		// [XID] // 0x000000018967E440-0x000000018967E480
		public static Vector3 CalcAnglesDeg(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x00000001874B5A90-0x00000001874B5F30
		// [IDTag] // 0x0000000189689180-0x00000001896891C0
		// [XID] // 0x0000000189689180-0x00000001896891C0
		public static Vector3 CalcAnglesDeg(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x00000001874B5960-0x00000001874B5A90
		// [IDTag] // 0x0000000189693B50-0x0000000189693B90
		// [XID] // 0x0000000189693B50-0x0000000189693B90
		public Vector3 CalcAnglesRad() => default; // 0x00000001874B6180-0x00000001874B61B0
		// [IDTag] // 0x000000018969E380-0x000000018969E3C0
		// [XID] // 0x000000018969E380-0x000000018969E3C0
		public static Vector3 CalcAnglesRad(ref Vector2 v0, ref Vector2 v1, ref Vector2 v2) => default; // 0x00000001874B61B0-0x00000001874B6400
		// [IDTag] // 0x00000001896A8430-0x00000001896A8470
		// [XID] // 0x00000001896A8430-0x00000001896A8470
		public static Vector3 CalcAnglesRad(Vector2 v0, Vector2 v1, Vector2 v2) => default; // 0x00000001874B6400-0x00000001874B6530
		// [IDTag] // 0x00000001896B2510-0x00000001896B2550
		// [XID] // 0x00000001896B2510-0x00000001896B2550
		public Vector2 EvalBarycentric(float c0, float c1) => default; // 0x00000001874B8170-0x00000001874B8260
		// [IDTag] // 0x00000001896BCC00-0x00000001896BCC40
		// [XID] // 0x00000001896BCC00-0x00000001896BCC40
		public Vector2 EvalBarycentric(ref Vector3 baryCoords) => default; // 0x00000001874B7E40-0x00000001874B7FC0
		// [IDTag] // 0x00000001896C7330-0x00000001896C7370
		// [XID] // 0x00000001896C7330-0x00000001896C7370
		public Vector2 EvalBarycentric(Vector3 baryCoords) => default; // 0x00000001874B7FC0-0x00000001874B8170
		// [IDTag] // 0x00000001896D15C0-0x00000001896D1600
		// [XID] // 0x00000001896D15C0-0x00000001896D1600
		public static void CalcBarycentricCoords(ref Vector2 point, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2, out Vector3 baryCoords) {
			baryCoords = default;
		} // 0x00000001874B6970-0x00000001874B6FF0
		// [IDTag] // 0x00000001896DBCE0-0x00000001896DBD20
		// [XID] // 0x00000001896DBCE0-0x00000001896DBD20
		public Vector3 CalcBarycentricCoords(ref Vector2 point) => default; // 0x00000001874B6FF0-0x00000001874B7150
		// [IDTag] // 0x00000001896E6040-0x00000001896E6080
		// [XID] // 0x00000001896E6040-0x00000001896E6080
		public Vector3 CalcBarycentricCoords(Vector2 point) => default; // 0x00000001874B7150-0x00000001874B7280
		// [XID] // 0x00000001896F0420-0x00000001896F0440
		public float DistanceTo(Vector2 point) => default; // 0x00000001874B7CC0-0x00000001874B7E40
		// [XID] // 0x00000001896F7DB0-0x00000001896F7DD0
		public int QuerySideCCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x00ADF639 */) => default; // 0x00000001874B8440-0x00000001874B8630
		// [XID] // 0x00000001896FF750-0x00000001896FF770
		public int QuerySideCW(Vector2 point, float epsilon = 1E-05f /* Metadata: 0x00ADF63D */) => default; // 0x00000001874B8630-0x00000001874B87B0
		// [XID] // 0x0000000189706B40-0x0000000189706B60
		public Vector2 Project(Vector2 point) => default; // 0x00000001874B8260-0x00000001874B8440
		// [IDTag] // 0x000000018970E4B0-0x000000018970E4F0
		// [XID] // 0x000000018970E4B0-0x000000018970E4F0
		public bool Contains(ref Vector2 point) => default; // 0x00000001874B7B10-0x00000001874B7BE0
		// [IDTag] // 0x0000000189718BD0-0x0000000189718C10
		// [XID] // 0x0000000189718BD0-0x0000000189718C10
		public bool Contains(Vector2 point) => default; // 0x00000001874B7BE0-0x00000001874B7CC0
		// [IDTag] // 0x0000000189723050-0x0000000189723090
		// [XID] // 0x0000000189723050-0x0000000189723090
		public bool ContainsCCW(ref Vector2 point) => default; // 0x00000001874B7730-0x00000001874B7800
		// [IDTag] // 0x000000018972D6D0-0x000000018972D710
		// [XID] // 0x000000018972D6D0-0x000000018972D710
		public bool ContainsCCW(Vector2 point) => default; // 0x00000001874B75A0-0x00000001874B7730
		// [IDTag] // 0x00000001897380C0-0x0000000189738100
		// [XID] // 0x00000001897380C0-0x0000000189738100
		public bool ContainsCW(ref Vector2 point) => default; // 0x00000001874B7990-0x00000001874B7B10
		// [IDTag] // 0x0000000189742580-0x00000001897425C0
		// [XID] // 0x0000000189742580-0x00000001897425C0
		public bool ContainsCW(Vector2 point) => default; // 0x00000001874B7800-0x00000001874B7990
		// [XID] // 0x000000018974D330-0x000000018974D350
		public override string ToString() => default; // 0x00000001874B87B0-0x00000001874B8860
	}
}
