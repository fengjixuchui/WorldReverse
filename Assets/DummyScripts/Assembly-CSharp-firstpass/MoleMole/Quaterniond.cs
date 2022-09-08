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

namespace MoleMole
{
	public struct Quaterniond // TypeDefIndex: 10594
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public double w; // 0x18
	
		// Properties
		public double this[int index] { /* [XID] */ /* 0x0000000189B45600-0x0000000189B45620 */ get => default; /* [XID] */ /* 0x0000000189688FC0-0x0000000189688FE0 */ set {} } // 0x0000000186C3A560-0x0000000186C3A750 0x0000000186C3B320-0x0000000186C3B430
		public static Quaterniond identity { /* [XID] */ /* 0x0000000189B54260-0x0000000189B54280 */ get => default; } // 0x0000000186C3A780-0x0000000186C3A8A0 
		public Vector3d eulerAngles { /* [XID] */ /* 0x0000000189808140-0x0000000189808160 */ get => default; /* [XID] */ /* 0x0000000189A9E790-0x0000000189A9E7B0 */ set {} } // 0x0000000186C3A750-0x0000000186C3A780 0x0000000186C3B430-0x0000000186C3B460
	
		// Constructors
		public Quaterniond(double p_x, double p_y, double p_z, double p_w) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186C3A430-0x0000000186C3A560
	
		// Methods
		// [XID] // 0x0000000189957580-0x00000001899575A0
		public Quaternion ToQuaternion() => default; // 0x0000000186C39C00-0x0000000186C39ED0
		// [XID] // 0x0000000189B72320-0x0000000189B72340
		public static implicit operator Quaterniond(Quaternion q) => default; // 0x0000000186C3A9C0-0x0000000186C3AB50
		// [XID] // 0x0000000189B79750-0x0000000189B79770
		public static double Angle(Quaterniond a, Quaterniond b) => default; // 0x0000000186C35AD0-0x0000000186C35C20
		// [XID] // 0x0000000189609460-0x0000000189609480
		public static Quaterniond AngleAxis(double angle, Vector3d axis) => default; // 0x0000000186C35920-0x0000000186C35AD0
		// [XID] // 0x0000000189B886A0-0x0000000189B886C0
		public static double Dot(Quaterniond a, Quaterniond b) => default; // 0x0000000186C35C20-0x0000000186C35E60
		// [IDTag] // 0x0000000189B8F8C0-0x0000000189B8F900
		// [XID] // 0x0000000189B8F8C0-0x0000000189B8F900
		public static Quaterniond Euler(Vector3d euler) => default; // 0x0000000186C35E70-0x0000000186C35FA0
		// [IDTag] // 0x0000000189B99C20-0x0000000189B99C60
		// [XID] // 0x0000000189B99C20-0x0000000189B99C60
		public static Quaterniond Euler(double x, double y, double z) => default; // 0x0000000186C35FA0-0x0000000186C362F0
		// [XID] // 0x0000000189BA4380-0x0000000189BA43A0
		public static Quaterniond FromToRotation(Vector3d fromDirection, Vector3d toDirection) => default; // 0x0000000186C362F0-0x0000000186C36520
		// [XID] // 0x0000000189BAB990-0x0000000189BAB9B0
		public static Quaterniond Inverse(Quaterniond rotation) => default; // 0x0000000186C36530-0x0000000186C366B0
		// [XID] // 0x000000018994FDD0-0x000000018994FDF0
		public static Quaterniond Lerp(Quaterniond a, Quaterniond b, double t) => default; // 0x0000000186C36AC0-0x0000000186C36C40
		// [XID] // 0x0000000189957380-0x00000001899573A0
		public static Quaterniond LerpUnclamped(Quaterniond a, Quaterniond b, double t) => default; // 0x0000000186C366B0-0x0000000186C36AC0
		// [IDTag] // 0x0000000189BC23A0-0x0000000189BC23E0
		// [XID] // 0x0000000189BC23A0-0x0000000189BC23E0
		public static Quaterniond LookRotation(Vector3d forward) => default; // 0x0000000186C371C0-0x0000000186C37330
		// [IDTag] // 0x0000000189BCCB60-0x0000000189BCCBA0
		// [XID] // 0x0000000189BCCB60-0x0000000189BCCBA0
		public static Quaterniond LookRotation(Vector3d forward, [DefaultValue] /* 0x0000000189BD6E40-0x0000000189BD6E70 */ Vector3d upwards) => default; // 0x0000000186C37330-0x0000000186C37870
		// [XID] // 0x0000000189BDFF40-0x0000000189BDFF60
		public static Quaterniond RotateTowards(Quaterniond from, Quaterniond to, double maxDegreesDelta) => default; // 0x0000000186C38C00-0x0000000186C38FE0
		// [XID] // 0x00000001895ECD60-0x00000001895ECD80
		public static Quaterniond Slerp(Quaterniond a, Quaterniond b, double t) => default; // 0x0000000186C397E0-0x0000000186C39AE0
		// [XID] // 0x00000001895F43F0-0x00000001895F4410
		public static Quaterniond SlerpUnclamped(Quaterniond q1, Quaterniond q2, double t) => default; // 0x0000000186C39420-0x0000000186C397E0
		// [XID] // 0x0000000189948640-0x0000000189948660
		public void Set(double new_x, double new_y, double new_z, double new_w) {} // 0x0000000186C39410-0x0000000186C39420
		// [XID] // 0x0000000189603480-0x00000001896034A0
		public void SetFromToRotation(Vector3d fromDirection, Vector3d toDirection) {} // 0x0000000186C38FE0-0x0000000186C39130
		// [IDTag] // 0x000000018960ADA0-0x000000018960ADE0
		// [XID] // 0x000000018960ADA0-0x000000018960ADE0
		public void SetLookRotation(Vector3d view) {} // 0x0000000186C39130-0x0000000186C392B0
		// [IDTag] // 0x0000000189615430-0x0000000189615470
		// [XID] // 0x0000000189615430-0x0000000189615470
		public void SetLookRotation(Vector3d view, [DefaultValue] /* 0x0000000189BD6E40-0x0000000189BD6E70 */ Vector3d up) {} // 0x0000000186C392B0-0x0000000186C39410
		// [XID] // 0x0000000189626F50-0x0000000189626F70
		public void ToAngleAxis(out double angle, out Vector3d axis) {
			angle = default;
			axis = default;
		} // 0x0000000186C39AE0-0x0000000186C39C00
		// [IDTag] // 0x000000018962E860-0x000000018962E8A0
		// [XID] // 0x000000018962E860-0x000000018962E8A0
		public override string ToString() => default; // 0x0000000186C39ED0-0x0000000186C3A160
		// [XID] // 0x0000000189A88420-0x0000000189A88440
		public override int GetHashCode() => default; // 0x0000000186C36520-0x0000000186C36530
		// [XID] // 0x00000001896408D0-0x00000001896408F0
		public override bool Equals(object other) => default; // 0x0000000186C35E60-0x0000000186C35E70
		// [IDTag] // 0x0000000189648100-0x0000000189648140
		// [XID] // 0x0000000189648100-0x0000000189648140
		public string ToString(string format) => default; // 0x0000000186C3A160-0x0000000186C3A220
		// [XID] // 0x000000018980FB50-0x000000018980FB70
		private Vector3d MatrixToEuler(Matrix4x4d m) => default; // 0x0000000186C37870-0x0000000186C37900
		// [XID] // 0x0000000189659FB0-0x0000000189659FD0
		public static Matrix4x4d QuaternionToMatrix(Quaterniond quat) => default; // 0x0000000186C37FB0-0x0000000186C38C00
		// [XID] // 0x000000018966A890-0x000000018966A8B0
		private static Quaterniond MatrixToQuaternion(Matrix4x4d m) => default; // 0x0000000186C37900-0x0000000186C37FB0
		// [XID] // 0x000000018965B970-0x000000018965B990
		private static Matrix4x4d LookRotationToMatrix(Vector3d viewVec, Vector3d upVec) => default; // 0x0000000186C36C40-0x0000000186C371C0
		// [IDTag] // 0x0000000189670C00-0x0000000189670C40
		// [XID] // 0x0000000189670C00-0x0000000189670C40
		public static Quaterniond operator *(Quaterniond lhs, Quaterniond rhs) => default; // 0x0000000186C3AF40-0x0000000186C3B320
		// [IDTag] // 0x000000018967B2A0-0x000000018967B2E0
		// [XID] // 0x000000018967B2A0-0x000000018967B2E0
		public static Vector3d operator *(Quaterniond rotation, Vector3d point) => default; // 0x0000000186C3AC70-0x0000000186C3AF40
		// [XID] // 0x0000000189685B10-0x0000000189685B30
		public static bool operator ==(Quaterniond lhs, Quaterniond rhs) => default; // 0x0000000186C3A8A0-0x0000000186C3A9C0
		// [XID] // 0x0000000189873FC0-0x0000000189873FE0
		public static bool operator !=(Quaterniond lhs, Quaterniond rhs) => default; // 0x0000000186C3AB50-0x0000000186C3AC70
	}
}
