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
	public static class Vector3ex // TypeDefIndex: 8126
	{
		// Fields
		public static readonly Vector3 Zero; // 0x00
		public static readonly Vector3 One; // 0x0C
		public static readonly Vector3 UnitX; // 0x18
		public static readonly Vector3 UnitY; // 0x24
		public static readonly Vector3 UnitZ; // 0x30
		public static readonly Vector3 PositiveInfinity; // 0x3C
		public static readonly Vector3 NegativeInfinity; // 0x48
	
		// Nested types
		internal class Information // TypeDefIndex: 8127
		{
			// Fields
			public int Dimension; // 0x10
			public Vector3 Min; // 0x14
			public Vector3 Max; // 0x20
			public float MaxRange; // 0x2C
			public Vector3 Origin; // 0x30
			public Vector3[] Direction; // 0x40
			public int[] Extreme; // 0x48
			public bool ExtremeCCW; // 0x50
	
			// Constructors
			public Information() {} // 0x000000018749E430-0x000000018749E4E0
		}
	
		// Constructors
		static Vector3ex() {} // 0x00000001874C1860-0x00000001874C1AA0
	
		// Methods
		// [XID] // 0x0000000189B36260-0x0000000189B36280
		internal static Information GetInformation(IList<Vector3> points, float epsilon) => default; // 0x00000001874BEB40-0x00000001874BFCB0
		// [IDTag] // 0x0000000189B6DA10-0x0000000189B6DA50
		// [XID] // 0x0000000189B6DA10-0x0000000189B6DA50
		public static float Dot(ref Vector3 vector, ref Vector3 value) => default; // 0x00000001874BE860-0x00000001874BE940
		// [IDTag] // 0x0000000189BBBEF0-0x0000000189BBBF30
		// [XID] // 0x0000000189BBBEF0-0x0000000189BBBF30
		public static Vector3 Cross(ref Vector3 vector, ref Vector3 value) => default; // 0x00000001874BE420-0x00000001874BE570
		// [IDTag] // 0x00000001895E6C10-0x00000001895E6C50
		// [XID] // 0x00000001895E6C10-0x00000001895E6C50
		public static Vector3 UnitCross(ref Vector3 vector, ref Vector3 value) => default; // 0x00000001874C1380-0x00000001874C1510
		// [XID] // 0x00000001895F14C0-0x00000001895F14E0
		public static float Normalize(ref Vector3 vector, float epsilon = 1E-05f /* Metadata: 0x00ADF598 */) => default; // 0x00000001874C01B0-0x00000001874C0320
		// [XID] // 0x00000001895F9060-0x00000001895F9080
		public static float SetLength(ref Vector3 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x00ADF59C */) => default; // 0x00000001874C0570-0x00000001874C06F0
		// [XID] // 0x00000001897914F0-0x0000000189791510
		public static float GrowLength(ref Vector3 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x00ADF5A0 */) => default; // 0x00000001874BFE20-0x00000001874BFFB0
		// [XID] // 0x00000001897B7970-0x00000001897B7990
		public static Vector3 Replicate(float value) => default; // 0x00000001874C0320-0x00000001874C0420
		// [XID] // 0x00000001897A3AB0-0x00000001897A3AD0
		public static void CreateOrthonormalBasis(out Vector3 u, out Vector3 v, ref Vector3 w) {
			u = default;
			v = default;
		} // 0x00000001874BE210-0x00000001874BE420
		// [XID] // 0x0000000189746F80-0x0000000189746FA0
		public static bool SameDirection(Vector3 value0, Vector3 value1) => default; // 0x00000001874C0420-0x00000001874C0570
	
		// Extension methods
		// [XID] // 0x0000000189B3D7B0-0x0000000189B3D7F0
		public static float Length(this Vector3 vector) => default; // 0x00000001874C0090-0x00000001874C01B0
		// [XID] // 0x0000000189B484D0-0x0000000189B48510
		public static float LengthSqr(this Vector3 vector) => default; // 0x00000001874BFFB0-0x00000001874C0090
		// [IDTag] // 0x0000000189B52B80-0x0000000189B52BD0
		// [XID] // 0x0000000189B52B80-0x0000000189B52BD0
		public static float Dot(this Vector3 vector, Vector3 value) => default; // 0x00000001874BE940-0x00000001874BEA50
		// [IDTag] // 0x0000000189B60620-0x0000000189B60670
		// [XID] // 0x0000000189B60620-0x0000000189B60670
		public static float Dot(this Vector3 vector, ref Vector3 value) => default; // 0x00000001874BEA50-0x00000001874BEB40
		// [XID] // 0x0000000189B78070-0x0000000189B780B0
		public static float AngleDeg(this Vector3 vector, Vector3 target) => default; // 0x00000001874BDED0-0x00000001874BE070
		// [XID] // 0x0000000189B82860-0x0000000189B828A0
		public static float AngleRad(this Vector3 vector, Vector3 target) => default; // 0x00000001874BE070-0x00000001874BE210
		// [XID] // 0x0000000189B8C8F0-0x0000000189B8C930
		public static float SignedAngleDeg(this Vector3 vector, Vector3 target, Vector3 normal) => default; // 0x00000001874C06F0-0x00000001874C0AB0
		// [XID] // 0x0000000189B96F90-0x0000000189B96FD0
		public static float SignedAngleRad(this Vector3 vector, Vector3 target, Vector3 normal) => default; // 0x00000001874C0AB0-0x00000001874C0E70
		// [IDTag] // 0x0000000189BA1400-0x0000000189BA1450
		// [XID] // 0x0000000189BA1400-0x0000000189BA1450
		public static Vector3 Cross(this Vector3 vector, Vector3 value) => default; // 0x00000001874BE570-0x00000001874BE6F0
		// [IDTag] // 0x0000000189BAE790-0x0000000189BAE7E0
		// [XID] // 0x0000000189BAE790-0x0000000189BAE7E0
		public static Vector3 Cross(this Vector3 vector, ref Vector3 value) => default; // 0x00000001874BE6F0-0x00000001874BE860
		// [IDTag] // 0x0000000189BC67C0-0x0000000189BC6810
		// [XID] // 0x0000000189BC67C0-0x0000000189BC6810
		public static Vector3 UnitCross(this Vector3 vector, Vector3 value) => default; // 0x00000001874C1510-0x00000001874C16C0
		// [IDTag] // 0x0000000189BD4370-0x0000000189BD43C0
		// [XID] // 0x0000000189BD4370-0x0000000189BD43C0
		public static Vector3 UnitCross(this Vector3 vector, ref Vector3 value) => default; // 0x00000001874C16C0-0x00000001874C1860
		// [XID] // 0x000000018961E4C0-0x000000018961E500
		public static Vector2 ToVector2XY(this Vector3 vector) => default; // 0x00000001874C0FA0-0x00000001874C1090
		// [XID] // 0x0000000189628AE0-0x0000000189628B20
		public static Vector2 ToVector2XZ(this Vector3 vector) => default; // 0x00000001874C1090-0x00000001874C1180
		// [XID] // 0x0000000189633400-0x0000000189633440
		public static Vector2 ToVector2YZ(this Vector3 vector) => default; // 0x00000001874C1180-0x00000001874C1270
		// [XID] // 0x000000018963DD50-0x000000018963DD90
		public static Vector2 ToVector2(this Vector3 vector, ProjectionPlanes projectionPlane) => default; // 0x00000001874C1270-0x00000001874C1380
		// [XID] // 0x00000001896483C0-0x0000000189648400
		public static ProjectionPlanes GetProjectionPlane(this Vector3 vector) => default; // 0x00000001874BFCB0-0x00000001874BFE20
		// [XID] // 0x0000000189652A80-0x0000000189652AC0
		public static string ToStringEx(this Vector3 vector) => default; // 0x00000001874C0E70-0x00000001874C0FA0
	}
}
