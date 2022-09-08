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
	public struct Vector3d // TypeDefIndex: 10596
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
	
		// Properties
		public double this[int index] { /* [XID] */ /* 0x0000000189817E40-0x0000000189817E60 */ get => default; /* [XID] */ /* 0x000000018981F710-0x000000018981F730 */ set {} } // 0x0000000186095150-0x0000000186095160 0x0000000186096F40-0x0000000186096F50
		public static Vector3d back { /* [XID] */ /* 0x0000000189826D30-0x0000000189826D50 */ get => default; } // 0x0000000186095160-0x0000000186095290 
		public static Vector3d down { /* [XID] */ /* 0x000000018982E3E0-0x000000018982E400 */ get => default; } // 0x0000000186095290-0x00000001860953C0 
		public static Vector3d forward { /* [XID] */ /* 0x0000000189763280-0x00000001897632A0 */ get => default; } // 0x00000001860953C0-0x00000001860954F0 
		public static Vector3d fwd { /* [XID] */ /* 0x000000018976AA70-0x000000018976AA90 */ get => default; } // 0x00000001860954F0-0x0000000186095620 
		public static Vector3d left { /* [XID] */ /* 0x0000000189772010-0x0000000189772030 */ get => default; } // 0x0000000186095620-0x0000000186095810 
		public static Vector3d one { /* [XID] */ /* 0x0000000189779840-0x0000000189779860 */ get => default; } // 0x0000000186095980-0x0000000186095AB0 
		public static Vector3d right { /* [XID] */ /* 0x0000000189852C10-0x0000000189852C30 */ get => default; } // 0x0000000186095AB0-0x0000000186095CB0 
		public static Vector3d up { /* [XID] */ /* 0x0000000189918340-0x0000000189918360 */ get => default; } // 0x0000000186095CC0-0x0000000186095DF0 
		public static Vector3d zero { /* [XID] */ /* 0x0000000189861990-0x00000001898619B0 */ get => default; } // 0x0000000186095DF0-0x0000000186095F20 
		public double magnitude { /* [XID] */ /* 0x0000000189B60410-0x0000000189B60430 */ get => default; } // 0x0000000186095810-0x0000000186095950 
		public Vector3d normalized { /* [XID] */ /* 0x00000001896450A0-0x00000001896450C0 */ get => default; } // 0x0000000186095950-0x0000000186095980 
		public double sqrMagnitude { /* [XID] */ /* 0x0000000189B67BD0-0x0000000189B67BF0 */ get => default; } // 0x0000000186095CB0-0x0000000186095CC0 
	
		// Constructors
		public Vector3d(double p_x, double p_y) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186094F90-0x0000000186095030
		public Vector3d(double p_x, double p_y, double p_z) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186095030-0x0000000186095150
		public Vector3d(Vector3 vec) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186094E80-0x0000000186094F90
	
		// Methods
		// [XID] // 0x00000001899844F0-0x0000000189984510
		public static float Angle(Vector3d from, Vector3d to) => default; // 0x00000001860900F0-0x0000000186090270
		// [XID] // 0x00000001897811C0-0x00000001897811E0
		public static float AngleBetween(Vector3d from, Vector3d to) => default; // 0x000000018608FF80-0x00000001860900F0
		// [XID] // 0x0000000189788680-0x00000001897886A0
		public static Vector3d ClampMagnitude(Vector3d vector, double maxLength) => default; // 0x0000000186090270-0x00000001860903E0
		// [XID] // 0x0000000189895340-0x0000000189895360
		public static Vector3d Cross(Vector3d lhs, Vector3d rhs) => default; // 0x00000001860904F0-0x00000001860906D0
		// [XID] // 0x00000001897F41C0-0x00000001897F41E0
		public static double Distance(Vector3d a, Vector3d b) => default; // 0x00000001860906D0-0x0000000186090810
		// [XID] // 0x00000001898A42A0-0x00000001898A42C0
		public static double Dot(Vector3d lhs, Vector3d rhs) => default; // 0x0000000186090810-0x0000000186090A40
		// [XID] // 0x00000001898AB4C0-0x00000001898AB4E0
		public static Vector3d Exclude(Vector3d excludeThis, Vector3d fromThat) => default; // 0x0000000186090A50-0x0000000186090CF0
		// [XID] // 0x00000001898B2D40-0x00000001898B2D60
		public static Vector3d Lerp(Vector3d a, Vector3d b, double t) => default; // 0x0000000186090ED0-0x00000001860910E0
		// [XID] // 0x000000018979F490-0x000000018979F4B0
		public static Vector3d LerpUnclamped(Vector3d a, Vector3d b, double t) => default; // 0x0000000186090D00-0x0000000186090ED0
		// [XID] // 0x00000001898C1E10-0x00000001898C1E30
		public static double Magnitude(Vector3d a) => default; // 0x00000001860910E0-0x00000001860911B0
		// [XID] // 0x00000001897A6A80-0x00000001897A6AA0
		public static Vector3d Max(Vector3d lhs, Vector3d rhs) => default; // 0x00000001860911B0-0x0000000186091330
		// [XID] // 0x00000001897AE1E0-0x00000001897AE200
		public static Vector3d Min(Vector3d lhs, Vector3d rhs) => default; // 0x0000000186091330-0x00000001860914B0
		// [XID] // 0x00000001897B62D0-0x00000001897B62F0
		public static Vector3d MoveTowards(Vector3d current, Vector3d target, double maxDistanceDelta) => default; // 0x00000001860914B0-0x0000000186091820
		// [IDTag] // 0x00000001898E0500-0x00000001898E0540
		// [XID] // 0x00000001898E0500-0x00000001898E0540
		public static Vector3d Normalize(Vector3d value) => default; // 0x0000000186091830-0x00000001860919E0
		// [IDTag] // 0x00000001898EAE50-0x00000001898EAE90
		// [XID] // 0x00000001898EAE50-0x00000001898EAE90
		public static void OrthoNormalize(ref Vector3d normal, ref Vector3d tangent) {} // 0x0000000186092020-0x0000000186092280
		// [IDTag] // 0x00000001898F5770-0x00000001898F57B0
		// [XID] // 0x00000001898F5770-0x00000001898F57B0
		public static void OrthoNormalize(ref Vector3d normal, ref Vector3d tangent, ref Vector3d binormal) {} // 0x0000000186091BC0-0x0000000186092020
		// [XID] // 0x0000000189797590-0x00000001897975B0
		public static Vector3d Project(Vector3d vector, Vector3d onNormal) => default; // 0x0000000186092440-0x0000000186092690
		// [XID] // 0x00000001897CCCE0-0x00000001897CCD00
		public static Vector3d ProjectOnPlane(Vector3d vector, Vector3d planeNormal) => default; // 0x0000000186092280-0x0000000186092440
		// [XID] // 0x00000001897D43E0-0x00000001897D4400
		public static Vector3d Reflect(Vector3d inDirection, Vector3d inNormal) => default; // 0x0000000186092690-0x0000000186092860
		// [XID] // 0x00000001899169A0-0x00000001899169C0
		public static Vector3d RotateTowards(Vector3d current, Vector3d target, double maxRadiansDelta, double maxMagnitudeDelta) => default; // 0x0000000186092860-0x0000000186092E60
		// [IDTag] // 0x000000018991E130-0x000000018991E170
		// [XID] // 0x000000018991E130-0x000000018991E170
		public static Vector3d Scale(Vector3d a, Vector3d b) => default; // 0x0000000186092E90-0x0000000186092FF0
		// [XID] // 0x00000001899289B0-0x00000001899289D0
		public static Vector3d Slerp(Vector3d lhs, Vector3d rhs, double t) => default; // 0x0000000186093AF0-0x0000000186093C80
		// [XID] // 0x000000018992FDD0-0x000000018992FDF0
		public static Vector3d SlerpUnclamped(Vector3d lhs, Vector3d rhs, double t) => default; // 0x00000001860934A0-0x0000000186093AF0
		// [IDTag] // 0x00000001899372F0-0x0000000189937330
		// [XID] // 0x00000001899372F0-0x0000000189937330
		public static Vector3d SmoothDamp(Vector3d current, Vector3d target, ref Vector3d currentVelocity, double smoothTime, double maxSpeed) => default; // 0x0000000186094560-0x0000000186094720
		// [IDTag] // 0x0000000189941A50-0x0000000189941A90
		// [XID] // 0x0000000189941A50-0x0000000189941A90
		public static Vector3d SmoothDamp(Vector3d current, Vector3d target, ref Vector3d currentVelocity, double smoothTime) => default; // 0x00000001860943B0-0x0000000186094560
		// [IDTag] // 0x000000018994C360-0x000000018994C3A0
		// [XID] // 0x000000018994C360-0x000000018994C3A0
		public static Vector3d SmoothDamp(Vector3d current, Vector3d target, ref Vector3d currentVelocity, double smoothTime, [DefaultValue] /* 0x00000001896BB670-0x00000001896BB6A0 */ double maxSpeed, [DefaultValue] /* 0x00000001899630A0-0x00000001899630D0 */ double deltaTime) => default; // 0x0000000186093C80-0x00000001860943B0
		// [XID] // 0x0000000189808D30-0x0000000189808D50
		public static double SqrMagnitude(Vector3d a) => default; // 0x0000000186094720-0x0000000186094940
		// [IDTag] // 0x000000018996D290-0x000000018996D2D0
		// [XID] // 0x000000018996D290-0x000000018996D2D0
		public void Normalize() {} // 0x0000000186091820-0x0000000186091830
		// [IDTag] // 0x0000000189977ED0-0x0000000189977F10
		// [XID] // 0x0000000189977ED0-0x0000000189977F10
		public void Scale(Vector3d scale) {} // 0x0000000186092E60-0x0000000186092E90
		// [XID] // 0x0000000189982720-0x0000000189982740
		public void Set(double new_x, double new_y, double new_z) {} // 0x0000000186093490-0x00000001860934A0
		// [IDTag] // 0x0000000189989E70-0x0000000189989EB0
		// [XID] // 0x0000000189989E70-0x0000000189989EB0
		public override string ToString() => default; // 0x0000000186094940-0x0000000186094A80
		// [XID] // 0x00000001899949A0-0x00000001899949C0
		public override int GetHashCode() => default; // 0x0000000186090CF0-0x0000000186090D00
		// [XID] // 0x000000018999C1F0-0x000000018999C210
		public override bool Equals(object other) => default; // 0x0000000186090A40-0x0000000186090A50
		// [IDTag] // 0x00000001899A3BC0-0x00000001899A3C00
		// [XID] // 0x00000001899A3BC0-0x00000001899A3C00
		public string ToString(string format) => default; // 0x0000000186094A80-0x0000000186094BA0
		// [XID] // 0x000000018983D0E0-0x000000018983D100
		public Vector3 ToVector3() => default; // 0x0000000186094BA0-0x0000000186094C80
		// [XID] // 0x00000001899B5B40-0x00000001899B5B60
		private static Vector3d OrthoNormalVectorFast(Vector3d normal) => default; // 0x00000001860919E0-0x0000000186091BC0
		// [XID] // 0x00000001897E35C0-0x00000001897E35E0
		private static double ClampedMove(double lhs, double rhs, double clampedDelta) => default; // 0x00000001860903E0-0x00000001860904F0
		// [XID] // 0x0000000189B85880-0x0000000189B858A0
		public static Matrix4x4d SetAxisAngle(Vector3d rotationAxis, double radians) => default; // 0x0000000186092FF0-0x0000000186093490
		// [XID] // 0x0000000189B346B0-0x0000000189B346D0
		public static Vector3d operator +(Vector3d a, Vector3d b) => default; // 0x0000000186095F20-0x0000000186096100
		// [XID] // 0x00000001899D3AE0-0x00000001899D3B00
		public static Vector3d operator -(Vector3d a) => default; // 0x0000000186096CA0-0x0000000186096F40
		// [XID] // 0x00000001899DB0C0-0x00000001899DB0E0
		public static Vector3d operator -(Vector3d a, Vector3d b) => default; // 0x0000000186096AC0-0x0000000186096CA0
		// [IDTag] // 0x00000001899E2800-0x00000001899E2840
		// [XID] // 0x00000001899E2800-0x00000001899E2840
		public static Vector3d operator *(double d, Vector3d a) => default; // 0x0000000186096920-0x0000000186096AC0
		// [IDTag] // 0x00000001899ECE20-0x00000001899ECE60
		// [XID] // 0x00000001899ECE20-0x00000001899ECE60
		public static Vector3d operator *(Vector3d a, double d) => default; // 0x0000000186096780-0x0000000186096920
		// [XID] // 0x0000000189B765F0-0x0000000189B76610
		public static Vector3d operator /(Vector3d a, double d) => default; // 0x0000000186096100-0x00000001860962A0
		// [XID] // 0x00000001899FEEE0-0x00000001899FEF00
		public static bool operator ==(Vector3d lhs, Vector3d rhs) => default; // 0x00000001860962A0-0x00000001860963B0
		// [XID] // 0x0000000189810620-0x0000000189810640
		public static bool operator !=(Vector3d lhs, Vector3d rhs) => default; // 0x0000000186096660-0x0000000186096780
		// [IDTag] // 0x0000000189A0DD00-0x0000000189A0DD40
		// [XID] // 0x0000000189A0DD00-0x0000000189A0DD40
		public static implicit operator Vector3d(Vector3 v) => default; // 0x00000001860963B0-0x0000000186096520
		// [IDTag] // 0x0000000189A18030-0x0000000189A18070
		// [XID] // 0x0000000189A18030-0x0000000189A18070
		public static implicit operator Vector3(Vector3d v) => default; // 0x0000000186096520-0x0000000186096660
	}
}
