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
	public struct Vector4d // TypeDefIndex: 10597
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public double w; // 0x18
	
		// Properties
		public double this[int index] { /* [XID] */ /* 0x0000000189A29AC0-0x0000000189A29AE0 */ get => default; /* [XID] */ /* 0x000000018984BD10-0x000000018984BD30 */ set {} } // 0x0000000186099460-0x0000000186099530 0x000000018609B030-0x000000018609B040
		public static Vector4d one { /* [XID] */ /* 0x0000000189852BF0-0x0000000189852C10 */ get => default; } // 0x00000001860996E0-0x00000001860998E0 
		public static Vector4d zero { /* [XID] */ /* 0x000000018985A820-0x000000018985A840 */ get => default; } // 0x00000001860998F0-0x0000000186099A10 
		public double magnitude { /* [XID] */ /* 0x0000000189A47840-0x0000000189A47860 */ get => default; } // 0x0000000186099530-0x00000001860996B0 
		public Vector4d normalized { /* [XID] */ /* 0x0000000189A4F0D0-0x0000000189A4F0F0 */ get => default; } // 0x00000001860996B0-0x00000001860996E0 
		public double sqrMagnitude { /* [XID] */ /* 0x0000000189A56680-0x0000000189A566A0 */ get => default; } // 0x00000001860998E0-0x00000001860998F0 
	
		// Constructors
		public Vector4d(double p_x, double p_y) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186099280-0x0000000186099330
		public Vector4d(double p_x, double p_y, double p_z) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x00000001860991F0-0x0000000186099280
		public Vector4d(double p_x, double p_y, double p_z, double p_w) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186099330-0x0000000186099460
	
		// Methods
		// [XID] // 0x0000000189A5E2B0-0x0000000189A5E2D0
		public static double Distance(Vector4d a, Vector4d b) => default; // 0x0000000186096F50-0x00000001860970B0
		// [XID] // 0x0000000189895260-0x0000000189895280
		public static double Dot(Vector4d lhs, Vector4d rhs) => default; // 0x00000001860970B0-0x00000001860972F0
		// [XID] // 0x000000018989C950-0x000000018989C970
		public static Vector4d Lerp(Vector4d a, Vector4d b, float t) => default; // 0x00000001860975C0-0x00000001860977C0
		// [XID] // 0x0000000189A748E0-0x0000000189A74900
		public static Vector4d LerpUnclamped(Vector4d a, Vector4d b, double t) => default; // 0x0000000186097400-0x00000001860975C0
		// [XID] // 0x0000000189A7C3A0-0x0000000189A7C3C0
		public static double Magnitude(Vector4d a) => default; // 0x00000001860977C0-0x0000000186097890
		// [XID] // 0x0000000189905D80-0x0000000189905DA0
		public static Vector4d Max(Vector4d lhs, Vector4d rhs) => default; // 0x0000000186097890-0x0000000186097A40
		// [XID] // 0x0000000189A8B7A0-0x0000000189A8B7C0
		public static Vector4d Min(Vector4d lhs, Vector4d rhs) => default; // 0x0000000186097A40-0x0000000186097BF0
		// [XID] // 0x0000000189A92D60-0x0000000189A92D80
		public static Vector4d MoveTowards(Vector4d current, Vector4d target, double maxDistanceDelta) => default; // 0x0000000186097BF0-0x0000000186097E40
		// [IDTag] // 0x0000000189A9A7C0-0x0000000189A9A800
		// [XID] // 0x0000000189A9A7C0-0x0000000189A9A800
		public static Vector4d Normalize(Vector4d value) => default; // 0x0000000186097E40-0x0000000186098120
		// [XID] // 0x0000000189941930-0x0000000189941950
		public static Vector4d Project(Vector4d vector, Vector4d onNormal) => default; // 0x0000000186098130-0x0000000186098360
		// [IDTag] // 0x0000000189AAC190-0x0000000189AAC1D0
		// [XID] // 0x0000000189AAC190-0x0000000189AAC1D0
		public static Vector4d Scale(Vector4d a, Vector4d b) => default; // 0x0000000186098360-0x00000001860985E0
		// [IDTag] // 0x0000000189AB6B70-0x0000000189AB6BB0
		// [XID] // 0x0000000189AB6B70-0x0000000189AB6BB0
		public static double SqrMagnitude(Vector4d a) => default; // 0x00000001860987F0-0x0000000186098B40
		// [IDTag] // 0x0000000189AC14D0-0x0000000189AC1510
		// [XID] // 0x0000000189AC14D0-0x0000000189AC1510
		public void Normalize() {} // 0x0000000186098120-0x0000000186098130
		// [IDTag] // 0x0000000189ACBD30-0x0000000189ACBD70
		// [XID] // 0x0000000189ACBD30-0x0000000189ACBD70
		public void Scale(Vector4d scale) {} // 0x00000001860985E0-0x0000000186098720
		// [XID] // 0x0000000189AD6C50-0x0000000189AD6C70
		public void Set(double new_x, double new_y, double new_z, double new_w) {} // 0x0000000186098720-0x00000001860987E0
		// [IDTag] // 0x0000000189ADE4E0-0x0000000189ADE520
		// [XID] // 0x0000000189ADE4E0-0x0000000189ADE520
		public double SqrMagnitude() => default; // 0x00000001860987E0-0x00000001860987F0
		// [IDTag] // 0x0000000189AE8AF0-0x0000000189AE8B30
		// [XID] // 0x0000000189AE8AF0-0x0000000189AE8B30
		public override string ToString() => default; // 0x0000000186098DF0-0x0000000186098F10
		// [XID] // 0x0000000189A17F50-0x0000000189A17F70
		public override int GetHashCode() => default; // 0x00000001860973F0-0x0000000186097400
		// [XID] // 0x0000000189985000-0x0000000189985020
		public override bool Equals(object other) => default; // 0x00000001860972F0-0x00000001860973F0
		// [IDTag] // 0x0000000189B026E0-0x0000000189B02720
		// [XID] // 0x0000000189B026E0-0x0000000189B02720
		public string ToString(string format) => default; // 0x0000000186098B40-0x0000000186098DF0
		// [XID] // 0x0000000189B0CBA0-0x0000000189B0CBC0
		public Vector4 ToVector4() => default; // 0x0000000186098F10-0x0000000186098FF0
		// [XID] // 0x00000001898D85A0-0x00000001898D85C0
		public static Vector4d operator +(Vector4d a, Vector4d b) => default; // 0x0000000186099A10-0x0000000186099C10
		// [XID] // 0x00000001899584D0-0x00000001899584F0
		public static Vector4d operator -(Vector4d a) => default; // 0x000000018609AD80-0x000000018609B030
		// [XID] // 0x0000000189B22EB0-0x0000000189B22ED0
		public static Vector4d operator -(Vector4d a, Vector4d b) => default; // 0x000000018609AB80-0x000000018609AD80
		// [IDTag] // 0x0000000189B2A540-0x0000000189B2A580
		// [XID] // 0x0000000189B2A540-0x0000000189B2A580
		public static Vector4d operator *(double d, Vector4d a) => default; // 0x000000018609A9E0-0x000000018609AB80
		// [IDTag] // 0x0000000189B34750-0x0000000189B34790
		// [XID] // 0x0000000189B34750-0x0000000189B34790
		public static Vector4d operator *(Vector4d a, double d) => default; // 0x000000018609A840-0x000000018609A9E0
		// [XID] // 0x0000000189932FC0-0x0000000189932FE0
		public static Vector4d operator /(Vector4d a, double d) => default; // 0x0000000186099C10-0x0000000186099DB0
		// [XID] // 0x0000000189B46BC0-0x0000000189B46BE0
		public static bool operator ==(Vector4d lhs, Vector4d rhs) => default; // 0x0000000186099DB0-0x0000000186099ED0
		// [XID] // 0x00000001896BC060-0x00000001896BC080
		public static bool operator !=(Vector4d lhs, Vector4d rhs) => default; // 0x000000018609A720-0x000000018609A840
		// [IDTag] // 0x0000000189B55960-0x0000000189B559A0
		// [XID] // 0x0000000189B55960-0x0000000189B559A0
		public static implicit operator Vector4d(Vector2d v) => default; // 0x000000018609A450-0x000000018609A5B0
		// [IDTag] // 0x0000000189B60450-0x0000000189B60490
		// [XID] // 0x0000000189B60450-0x0000000189B60490
		public static implicit operator Vector4d(Vector3d v) => default; // 0x000000018609A1A0-0x000000018609A310
		// [IDTag] // 0x0000000189B6AB50-0x0000000189B6AB90
		// [XID] // 0x0000000189B6AB50-0x0000000189B6AB90
		public static implicit operator Vector2d(Vector4d v) => default; // 0x000000018609A310-0x000000018609A450
		// [IDTag] // 0x0000000189B74EF0-0x0000000189B74F30
		// [XID] // 0x0000000189B74EF0-0x0000000189B74F30
		public static implicit operator Vector3d(Vector4d v) => default; // 0x000000018609A5B0-0x000000018609A720
		// [IDTag] // 0x0000000189B7F400-0x0000000189B7F440
		// [XID] // 0x0000000189B7F400-0x0000000189B7F440
		public static implicit operator Vector4d(Vector4 v) => default; // 0x0000000186099ED0-0x000000018609A060
		// [IDTag] // 0x0000000189B89D90-0x0000000189B89DD0
		// [XID] // 0x0000000189B89D90-0x0000000189B89DD0
		public static implicit operator Vector4(Vector4d v) => default; // 0x000000018609A060-0x000000018609A1A0
	}
}
