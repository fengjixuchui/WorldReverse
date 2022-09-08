/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoCamera
{
	public static class MathUtils // TypeDefIndex: 8990
	{
		// Fields
		public const double Epsilon = 9.999999747378752E-05; // Metadata: 0x00AE5019
	
		// Methods
		// [IDTag] // 0x0000000189896CA0-0x0000000189896CE0
		// [XID] // 0x0000000189896CA0-0x0000000189896CE0
		public static Vector3 Cartesian2Spherial(Vector3 cPos) => default; // 0x0000000187333390-0x0000000187333550
		// [IDTag] // 0x00000001898A1100-0x00000001898A1140
		// [XID] // 0x00000001898A1100-0x00000001898A1140
		public static Vector3d Cartesian2Spherial(Vector3d cPos) => default; // 0x0000000187332D10-0x0000000187332E80
		// [IDTag] // 0x00000001898AB540-0x00000001898AB580
		// [XID] // 0x00000001898AB540-0x00000001898AB580
		public static Vector3d Cartesian2Spherial(Vector3d pos, Vector3d forward, Vector3d lookAt, out double deltaPole, out double deltaElev) {
			deltaPole = default;
			deltaElev = default;
			return default;
		} // 0x0000000187332E80-0x0000000187333390
		// [XID] // 0x00000001898B5E50-0x00000001898B5E70
		public static Vector3d Spherial2Cartesian(Vector3d sPos) => default; // 0x00000001873342A0-0x0000000187334430
		// [XID] // 0x00000001898BD7E0-0x00000001898BD800
		public static double To180Angle(double f) => default; // 0x0000000187334610-0x0000000187334700
		// [XID] // 0x00000001898C50A0-0x00000001898C50C0
		public static double To360Angle(double f) => default; // 0x0000000187334700-0x00000001873347E0
		// [XID] // 0x00000001898CC4E0-0x00000001898CC500
		public static double SignedRadianDiff(double from, double to) => default; // 0x0000000187333BB0-0x0000000187333CB0
		// [XID] // 0x00000001898D3F80-0x00000001898D3FA0
		public static double NormalizedRotateRadian(double from, double to) => default; // 0x0000000187333920-0x00000001873339F0
		// [XID] // 0x00000001898DB750-0x00000001898DB770
		public static double SpringSystem1D_Accurate(double kd, double fromP, double toP, double deltaT, double minChange, double maxChange, ref double curVelocity) => default; // 0x0000000187334430-0x0000000187334610
		// [XID] // 0x00000001898F8970-0x00000001898F8990
		public static Quaterniond SlerpWithReferenceUp(Quaterniond qA, Quaterniond qB, double t, Vector3d up) => default; // 0x0000000187333CB0-0x00000001873342A0
		// [XID] // 0x0000000189900210-0x0000000189900230
		public static double LinearLerpPoleAngle(double fromAngle, double toAngle, double lerpRatio, double deltaT) => default; // 0x0000000187333780-0x0000000187333920
		// [IDTag] // 0x00000001899078C0-0x0000000189907900
		// [XID] // 0x00000001899078C0-0x0000000189907900
		public static Vector2d GetCamHalfSize(double nearClipPlane, double halfFov, double aspect) => default; // 0x0000000187333660-0x0000000187333780
		// [IDTag] // 0x0000000189912050-0x0000000189912090
		// [XID] // 0x0000000189912050-0x0000000189912090
		public static Vector2 GetCamHalfSize(float nearClipPlane, float halfFov, float aspect) => default; // 0x0000000187333550-0x0000000187333660
	
		// Extension methods
		// [XID] // 0x00000001898E33A0-0x00000001898E33E0
		public static bool AlmostZero(this Vector3d v) => default; // 0x0000000187332C40-0x0000000187332D10
		// [XID] // 0x00000001898EDEF0-0x00000001898EDF30
		public static Vector3d ProjectOntoPlane(this Vector3d vector, Vector3d planeNormal) => default; // 0x00000001873339F0-0x0000000187333BB0
	}
}
