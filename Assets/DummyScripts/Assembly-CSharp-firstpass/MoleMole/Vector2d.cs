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
	public struct Vector2d // TypeDefIndex: 10595
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
	
		// Properties
		public double this[int index] { /* [XID] */ /* 0x00000001898AB3A0-0x00000001898AB3C0 */ get => default; /* [XID] */ /* 0x00000001898656B0-0x00000001898656D0 */ set {} } // 0x000000018608E570-0x000000018608E580 0x000000018608FF70-0x000000018608FF80
		public static Vector2d down { /* [XID] */ /* 0x0000000189ABCCE0-0x0000000189ABCD00 */ get => default; } // 0x000000018608E580-0x000000018608E680 
		public static Vector2d left { /* [XID] */ /* 0x00000001896B2260-0x00000001896B2280 */ get => default; } // 0x000000018608E680-0x000000018608E840 
		public static Vector2d one { /* [XID] */ /* 0x0000000189AF9800-0x0000000189AF9820 */ get => default; } // 0x000000018608E9C0-0x000000018608EAC0 
		public static Vector2d right { /* [XID] */ /* 0x0000000189B08230-0x0000000189B08250 */ get => default; } // 0x000000018608EAC0-0x000000018608EC80 
		public static Vector2d up { /* [XID] */ /* 0x00000001896C85A0-0x00000001896C85C0 */ get => default; } // 0x000000018608EC90-0x000000018608ED90 
		public static Vector2d zero { /* [XID] */ /* 0x00000001899243D0-0x00000001899243F0 */ get => default; } // 0x000000018608ED90-0x000000018608EE80 
		public double magnitude { /* [XID] */ /* 0x000000018992B800-0x000000018992B820 */ get => default; } // 0x000000018608E840-0x000000018608E990 
		public Vector2d normalized { /* [XID] */ /* 0x0000000189922790-0x00000001899227B0 */ get => default; } // 0x000000018608E990-0x000000018608E9C0 
		public double sqrMagnitude { /* [XID] */ /* 0x00000001896E5E20-0x00000001896E5E40 */ get => default; } // 0x000000018608EC80-0x000000018608EC90 
	
		// Constructors
		public Vector2d(double p_x, double p_y) : this() {
			x = default;
			y = default;
		} // 0x000000018608E3F0-0x000000018608E570
	
		// Methods
		// [XID] // 0x00000001898FE660-0x00000001898FE680
		public static float Angle(Vector2d from, Vector2d to) => default; // 0x000000018608C0D0-0x000000018608C2E0
		// [XID] // 0x00000001898C1D10-0x00000001898C1D30
		public static Vector2d ClampMagnitude(Vector2d vector, double maxLength) => default; // 0x000000018608C2E0-0x000000018608C420
		// [XID] // 0x00000001896FC530-0x00000001896FC550
		public static double Distance(Vector2d a, Vector2d b) => default; // 0x000000018608C420-0x000000018608C520
		// [XID] // 0x0000000189AE2820-0x0000000189AE2840
		public static double Dot(Vector2d lhs, Vector2d rhs) => default; // 0x000000018608C520-0x000000018608C7E0
		// [XID] // 0x000000018970B250-0x000000018970B270
		public static Vector2d Lerp(Vector2d a, Vector2d b, double t) => default; // 0x000000018608CA40-0x000000018608CBE0
		// [XID] // 0x0000000189ADB110-0x0000000189ADB130
		public static Vector2d LerpUnclamped(Vector2d a, Vector2d b, double t) => default; // 0x000000018608C8D0-0x000000018608CA40
		// [XID] // 0x0000000189AF1E70-0x0000000189AF1E90
		public static Vector2d Max(Vector2d lhs, Vector2d rhs) => default; // 0x000000018608CBE0-0x000000018608CD20
		// [XID] // 0x0000000189B0FA90-0x0000000189B0FAB0
		public static Vector2d Min(Vector2d lhs, Vector2d rhs) => default; // 0x000000018608CD20-0x000000018608CE60
		// [XID] // 0x0000000189728CE0-0x0000000189728D00
		public static Vector2d MoveTowards(Vector2d current, Vector2d target, double maxDistanceDelta) => default; // 0x000000018608CE60-0x000000018608D130
		// [XID] // 0x0000000189730710-0x0000000189730730
		public static Vector2d Reflect(Vector2d inDirection, Vector2d inNormal) => default; // 0x000000018608D140-0x000000018608D380
		// [IDTag] // 0x0000000189737EF0-0x0000000189737F30
		// [XID] // 0x0000000189737EF0-0x0000000189737F30
		public static Vector2d Scale(Vector2d a, Vector2d b) => default; // 0x000000018608D380-0x000000018608D570
		// [XID] // 0x00000001896B8530-0x00000001896B8550
		public static Vector2d SmoothDamp(Vector2d current, Vector2d target, ref Vector2d currentVelocity, double smoothTime, double maxSpeed, double deltaTime) => default; // 0x000000018608D670-0x000000018608DD70
		// [IDTag] // 0x000000018974A070-0x000000018974A0B0
		// [XID] // 0x000000018974A070-0x000000018974A0B0
		public static double SqrMagnitude(Vector2d a) => default; // 0x000000018608DD80-0x000000018608DF60
		// [XID] // 0x0000000189754790-0x00000001897547B0
		public void Normalize() {} // 0x000000018608D130-0x000000018608D140
		// [IDTag] // 0x000000018975BA10-0x000000018975BA50
		// [XID] // 0x000000018975BA10-0x000000018975BA50
		public void Scale(Vector2d scale) {} // 0x000000018608D570-0x000000018608D660
		// [XID] // 0x00000001896EBE10-0x00000001896EBE30
		public void Set(double newX, double newY) {} // 0x000000018608D660-0x000000018608D670
		// [IDTag] // 0x000000018976DA00-0x000000018976DA40
		// [XID] // 0x000000018976DA00-0x000000018976DA40
		public double SqrMagnitude() => default; // 0x000000018608DD70-0x000000018608DD80
		// [IDTag] // 0x00000001897780B0-0x00000001897780F0
		// [XID] // 0x00000001897780B0-0x00000001897780F0
		public override string ToString() => default; // 0x000000018608DF60-0x000000018608E080
		// [XID] // 0x00000001896FAC10-0x00000001896FAC30
		public override bool Equals(object other) => default; // 0x000000018608C7E0-0x000000018608C8C0
		// [IDTag] // 0x0000000189789E10-0x0000000189789E50
		// [XID] // 0x0000000189789E10-0x0000000189789E50
		public string ToString(string format) => default; // 0x000000018608E080-0x000000018608E1D0
		// [XID] // 0x0000000189794260-0x0000000189794280
		public override int GetHashCode() => default; // 0x000000018608C8C0-0x000000018608C8D0
		// [XID] // 0x00000001897113F0-0x0000000189711410
		public Vector2d ToVector2() => default; // 0x000000018608E1D0-0x000000018608E2A0
		// [XID] // 0x0000000189AD3670-0x0000000189AD3690
		public static Vector2d operator +(Vector2d a, Vector2d b) => default; // 0x000000018608EE80-0x000000018608F000
		// [XID] // 0x0000000189718920-0x0000000189718940
		public static Vector2d operator -(Vector2d a) => default; // 0x000000018608FD20-0x000000018608FF70
		// [XID] // 0x00000001897B2C50-0x00000001897B2C70
		public static Vector2d operator -(Vector2d a, Vector2d b) => default; // 0x000000018608FBA0-0x000000018608FD20
		// [IDTag] // 0x00000001897BA760-0x00000001897BA7A0
		// [XID] // 0x00000001897BA760-0x00000001897BA7A0
		public static Vector2d operator *(double d, Vector2d a) => default; // 0x000000018608F8E0-0x000000018608FA40
		// [IDTag] // 0x00000001897C57D0-0x00000001897C5810
		// [XID] // 0x00000001897C57D0-0x00000001897C5810
		public static Vector2d operator *(Vector2d a, double d) => default; // 0x000000018608FA40-0x000000018608FBA0
		// [XID] // 0x0000000189B1E4C0-0x0000000189B1E4E0
		public static Vector2d operator /(Vector2d a, double d) => default; // 0x000000018608F000-0x000000018608F160
		// [XID] // 0x00000001897D76D0-0x00000001897D76F0
		public static bool operator ==(Vector2d lhs, Vector2d rhs) => default; // 0x000000018608F160-0x000000018608F240
		// [XID] // 0x00000001897DEC20-0x00000001897DEC40
		public static bool operator !=(Vector2d lhs, Vector2d rhs) => default; // 0x000000018608F700-0x000000018608F8E0
		// [IDTag] // 0x00000001897E66D0-0x00000001897E6710
		// [XID] // 0x00000001897E66D0-0x00000001897E6710
		public static implicit operator Vector2d(Vector3d v) => default; // 0x000000018608F5B0-0x000000018608F700
		// [IDTag] // 0x00000001897F1320-0x00000001897F1360
		// [XID] // 0x00000001897F1320-0x00000001897F1360
		public static implicit operator Vector3d(Vector2d v) => default; // 0x000000018608F370-0x000000018608F4C0
		// [IDTag] // 0x00000001897FBDE0-0x00000001897FBE20
		// [XID] // 0x00000001897FBDE0-0x00000001897FBE20
		public static implicit operator Vector2d(Vector2 v) => default; // 0x000000018608F240-0x000000018608F370
		// [IDTag] // 0x0000000189805D50-0x0000000189805D90
		// [XID] // 0x0000000189805D50-0x0000000189805D90
		public static implicit operator Vector2(Vector2d v) => default; // 0x000000018608F4C0-0x000000018608F5B0
	}
}
