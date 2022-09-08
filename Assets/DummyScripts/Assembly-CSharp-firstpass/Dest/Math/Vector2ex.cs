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
	public static class Vector2ex // TypeDefIndex: 8123
	{
		// Fields
		public static readonly Vector2 Zero; // 0x00
		public static readonly Vector2 One; // 0x08
		public static readonly Vector2 UnitX; // 0x10
		public static readonly Vector2 UnitY; // 0x18
		public static readonly Vector2 PositiveInfinity; // 0x20
		public static readonly Vector2 NegativeInfinity; // 0x28
	
		// Nested types
		internal class Information // TypeDefIndex: 8124
		{
			// Fields
			public int Dimension; // 0x10
			public Vector2 Min; // 0x14
			public Vector2 Max; // 0x1C
			public float MaxRange; // 0x24
			public Vector2 Origin; // 0x28
			public Vector2[] Direction; // 0x30
			public int[] Extreme; // 0x38
			public bool ExtremeCCW; // 0x40
	
			// Constructors
			public Information() {} // 0x000000018749E380-0x000000018749E430
		}
	
		// Constructors
		static Vector2ex() {} // 0x00000001874BDD20-0x00000001874BDED0
	
		// Methods
		// [XID] // 0x0000000189A5FC60-0x0000000189A5FC80
		internal static Information GetInformation(IList<Vector2> points, float epsilon) => default; // 0x00000001874BC910-0x00000001874BD180
		// [IDTag] // 0x0000000189A97870-0x0000000189A978B0
		// [XID] // 0x0000000189A97870-0x0000000189A978B0
		public static float DotPerp(ref Vector2 vector, ref Vector2 value) => default; // 0x00000001874BC430-0x00000001874BC500
		// [IDTag] // 0x0000000189ABCF30-0x0000000189ABCF70
		// [XID] // 0x0000000189ABCF30-0x0000000189ABCF70
		public static float Dot(ref Vector2 vector, ref Vector2 value) => default; // 0x00000001874BC840-0x00000001874BC910
		// [XID] // 0x0000000189AE7790-0x0000000189AE77B0
		public static float Normalize(ref Vector2 vector, float epsilon = 1E-05f /* Metadata: 0x00ADF580 */) => default; // 0x00000001874BD4A0-0x00000001874BD5E0
		// [XID] // 0x0000000189620FF0-0x0000000189621010
		public static float SetLength(ref Vector2 vector, float lengthValue, float epsilon = 1E-05f /* Metadata: 0x00ADF584 */) => default; // 0x00000001874BD790-0x00000001874BD8E0
		// [XID] // 0x0000000189AF67F0-0x0000000189AF6810
		public static float GrowLength(ref Vector2 vector, float lengthDelta, float epsilon = 1E-05f /* Metadata: 0x00ADF588 */) => default; // 0x00000001874BD180-0x00000001874BD2E0
		// [XID] // 0x000000018976C360-0x000000018976C380
		public static Vector2 Replicate(float value) => default; // 0x00000001874BD6C0-0x00000001874BD790
	
		// Extension methods
		// [XID] // 0x0000000189A67680-0x0000000189A676C0
		public static float Length(this Vector2 vector) => default; // 0x00000001874BD3A0-0x00000001874BD4A0
		// [XID] // 0x0000000189A71BB0-0x0000000189A71BF0
		public static float LengthSqr(this Vector2 vector) => default; // 0x00000001874BD2E0-0x00000001874BD3A0
		// [IDTag] // 0x0000000189A7C670-0x0000000189A7C6C0
		// [XID] // 0x0000000189A7C670-0x0000000189A7C6C0
		public static float DotPerp(this Vector2 vector, Vector2 value) => default; // 0x00000001874BC500-0x00000001874BC5D0
		// [IDTag] // 0x0000000189A89EB0-0x0000000189A89F00
		// [XID] // 0x0000000189A89EB0-0x0000000189A89F00
		public static float DotPerp(this Vector2 vector, ref Vector2 value) => default; // 0x00000001874BC5D0-0x00000001874BC6A0
		// [IDTag] // 0x0000000189AA1A70-0x0000000189AA1AC0
		// [XID] // 0x0000000189AA1A70-0x0000000189AA1AC0
		public static float Dot(this Vector2 vector, Vector2 value) => default; // 0x00000001874BC770-0x00000001874BC840
		// [IDTag] // 0x0000000189AAF4A0-0x0000000189AAF4F0
		// [XID] // 0x0000000189AAF4A0-0x0000000189AAF4F0
		public static float Dot(this Vector2 vector, ref Vector2 value) => default; // 0x00000001874BC6A0-0x00000001874BC770
		// [XID] // 0x0000000189AC79A0-0x0000000189AC79E0
		public static Vector2 Perp(this Vector2 vector) => default; // 0x00000001874BD5E0-0x00000001874BD6C0
		// [XID] // 0x0000000189AD2250-0x0000000189AD2290
		public static float AngleDeg(this Vector2 vector, Vector2 target) => default; // 0x00000001874BC150-0x00000001874BC2C0
		// [XID] // 0x0000000189ADD110-0x0000000189ADD150
		public static float AngleRad(this Vector2 vector, Vector2 target) => default; // 0x00000001874BC2C0-0x00000001874BC430
		// [XID] // 0x0000000189B05590-0x0000000189B055D0
		public static Vector3 ToVector3XY(this Vector2 vector) => default; // 0x00000001874BD9F0-0x00000001874BDB00
		// [XID] // 0x0000000189B0FDE0-0x0000000189B0FE20
		public static Vector3 ToVector3XZ(this Vector2 vector) => default; // 0x00000001874BDB00-0x00000001874BDC10
		// [XID] // 0x0000000189B1A130-0x0000000189B1A170
		public static Vector3 ToVector3YZ(this Vector2 vector) => default; // 0x00000001874BDC10-0x00000001874BDD20
		// [XID] // 0x0000000189B247D0-0x0000000189B24810
		public static string ToStringEx(this Vector2 vector) => default; // 0x00000001874BD8E0-0x00000001874BD9F0
	}
}
