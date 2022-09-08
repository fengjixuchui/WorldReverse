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
	public class Rand // TypeDefIndex: 8122
	{
		// Fields
		private const int a = 5; // Metadata: 0x00ADF54C
		private const int b = 14; // Metadata: 0x00ADF550
		private const int c = 1; // Metadata: 0x00ADF554
		private const uint DefaultY = 273326509; // Metadata: 0x00ADF558
		private const uint DefaultZ = 3579807591; // Metadata: 0x00ADF55C
		private const uint DefaultW = 842502087; // Metadata: 0x00ADF560
		private const uint PositiveMask = 2147483647; // Metadata: 0x00ADF564
		private const uint BoolModuloMask = 1; // Metadata: 0x00ADF568
		private const uint ByteModuloMask = 255; // Metadata: 0x00ADF56C
		private const double One_div_uintMaxValuePlusOne = 2.3283064365386963E-10; // Metadata: 0x00ADF570
		private const double TwoPi = 6.283185307179586; // Metadata: 0x00ADF578
		private static Rand _seedGenerator; // 0x00
		private uint _x; // 0x10
		private uint _y; // 0x14
		private uint _z; // 0x18
		private uint _w; // 0x1C
		public static Rand Instance; // 0x08
	
		// Constructors
		static Rand() {} // 0x00000001874A8720-0x00000001874A87E0
		public Rand() {} // 0x00000001874A8860-0x00000001874A89E0
		public Rand(int seed) {} // 0x00000001874A87E0-0x00000001874A8860
	
		// Methods
		// [XID] // 0x00000001897E08F0-0x00000001897E0910
		public void ResetSeed(int seed) {} // 0x00000001874A8560-0x00000001874A8630
		// [XID] // 0x0000000189947EF0-0x0000000189947F10
		public void GetState(out uint x, out uint y, out uint z, out uint w) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x00000001874A5B90-0x00000001874A5C90
		// [XID] // 0x0000000189A89D60-0x0000000189A89D80
		public void SetState(uint x, uint y, uint z, uint w) {} // 0x00000001874A8630-0x00000001874A8720
		// [IDTag] // 0x0000000189956A20-0x0000000189956A60
		// [XID] // 0x0000000189956A20-0x0000000189956A60
		public int NextInt() => default; // 0x00000001874A7160-0x00000001874A7230
		// [IDTag] // 0x0000000189961660-0x00000001899616A0
		// [XID] // 0x0000000189961660-0x00000001899616A0
		public int NextInt(int max) => default; // 0x00000001874A7060-0x00000001874A7160
		// [IDTag] // 0x000000018996BCA0-0x000000018996BCE0
		// [XID] // 0x000000018996BCA0-0x000000018996BCE0
		public int NextInt(int min, int max) => default; // 0x00000001874A7230-0x00000001874A73A0
		// [XID] // 0x00000001899764D0-0x00000001899764F0
		public int NextIntInclusive(int min, int max) => default; // 0x00000001874A6F90-0x00000001874A7060
		// [XID] // 0x000000018997D790-0x000000018997D7B0
		public int NextPositiveInt() => default; // 0x00000001874A73A0-0x00000001874A7480
		// [XID] // 0x000000018987C680-0x000000018987C6A0
		public uint NextUInt() => default; // 0x00000001874A7480-0x00000001874A7550
		// [IDTag] // 0x000000018998CE80-0x000000018998CEC0
		// [XID] // 0x000000018998CE80-0x000000018998CEC0
		public double NextDouble() => default; // 0x00000001874A6AE0-0x00000001874A6BD0
		// [IDTag] // 0x0000000189997890-0x00000001899978D0
		// [XID] // 0x0000000189997890-0x00000001899978D0
		public double NextDouble(double min, double max) => default; // 0x00000001874A6BD0-0x00000001874A6D30
		// [IDTag] // 0x00000001899A25B0-0x00000001899A25F0
		// [XID] // 0x00000001899A25B0-0x00000001899A25F0
		public float NextFloat() => default; // 0x00000001874A6EA0-0x00000001874A6F90
		// [IDTag] // 0x00000001899ACFB0-0x00000001899ACFF0
		// [XID] // 0x00000001899ACFB0-0x00000001899ACFF0
		public float NextFloat(float min, float max) => default; // 0x00000001874A6D30-0x00000001874A6EA0
		// [XID] // 0x0000000189BB4730-0x0000000189BB4750
		public bool NextBool() => default; // 0x00000001874A6930-0x00000001874A6A10
		// [XID] // 0x00000001895EA8C0-0x00000001895EA8E0
		public byte NextByte() => default; // 0x00000001874A6A10-0x00000001874A6AE0
		// [XID] // 0x00000001899C6810-0x00000001899C6830
		public Color RandomColorOpaque() => default; // 0x00000001874A80F0-0x00000001874A8220
		// [XID] // 0x0000000189A55050-0x0000000189A55070
		public Color RandomColorTransparent() => default; // 0x00000001874A8220-0x00000001874A8370
		// [XID] // 0x00000001898E7F80-0x00000001898E7FA0
		public Color32 RandomColor32Opaque() => default; // 0x00000001874A7EF0-0x00000001874A7FF0
		// [XID] // 0x0000000189A28120-0x0000000189A28140
		public Color32 RandomColor32Transparent() => default; // 0x00000001874A7FF0-0x00000001874A80F0
		// [XID] // 0x00000001899E42D0-0x00000001899E42F0
		public float RandomAngleRadians() => default; // 0x00000001874A7E30-0x00000001874A7EF0
		// [XID] // 0x00000001899EB6D0-0x00000001899EB6F0
		public float RandomAngleDegrees() => default; // 0x00000001874A7D70-0x00000001874A7E30
		// [XID] // 0x00000001899F3380-0x00000001899F33A0
		public Vector2 InSquare(float side = 1f /* Metadata: 0x00ADF52C */) => default; // 0x00000001874A62D0-0x00000001874A6400
		// [XID] // 0x0000000189A12360-0x0000000189A12380
		public Vector2 OnSquare(float side = 1f /* Metadata: 0x00ADF530 */) => default; // 0x00000001874A7B80-0x00000001874A7D70
		// [XID] // 0x0000000189A01C80-0x0000000189A01CA0
		public Vector3 InCube(float side = 1f /* Metadata: 0x00ADF534 */) => default; // 0x00000001874A5F80-0x00000001874A6110
		// [XID] // 0x0000000189A09620-0x0000000189A09640
		public Vector3 OnCube(float side = 1f /* Metadata: 0x00ADF538 */) => default; // 0x00000001874A7690-0x00000001874A79A0
		// [IDTag] // 0x0000000189A10C90-0x0000000189A10CD0
		// [XID] // 0x0000000189A10C90-0x0000000189A10CD0
		public Vector2 InCircle(float radius = 1f /* Metadata: 0x00ADF53C */) => default; // 0x00000001874A5E20-0x00000001874A5F80
		// [IDTag] // 0x0000000189A1B140-0x0000000189A1B180
		// [XID] // 0x0000000189A1B140-0x0000000189A1B180
		public Vector2 InCircle(float radiusMin, float radiusMax) => default; // 0x00000001874A5C90-0x00000001874A5E20
		// [XID] // 0x0000000189BBA220-0x0000000189BBA240
		public Vector2 OnCircle(float radius = 1f /* Metadata: 0x00ADF540 */) => default; // 0x00000001874A7550-0x00000001874A7690
		// [XID] // 0x0000000189A2CAE0-0x0000000189A2CB00
		public Vector3 InSphere(float radius = 1f /* Metadata: 0x00ADF544 */) => default; // 0x00000001874A6110-0x00000001874A62D0
		// [XID] // 0x0000000189A34250-0x0000000189A34270
		public Vector3 OnSphere(float radius = 1f /* Metadata: 0x00ADF548 */) => default; // 0x00000001874A79A0-0x00000001874A7B80
		// [IDTag] // 0x0000000189A3B960-0x0000000189A3B9A0
		// [XID] // 0x0000000189A3B960-0x0000000189A3B9A0
		public Vector3 InTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2) => default; // 0x00000001874A6400-0x00000001874A6680
		// [IDTag] // 0x0000000189A463C0-0x0000000189A46400
		// [XID] // 0x0000000189A463C0-0x0000000189A46400
		public Vector3 InTriangle(Vector3 v0, Vector3 v1, Vector3 v2) => default; // 0x00000001874A6680-0x00000001874A6930
		// [XID] // 0x0000000189BDFF00-0x0000000189BDFF20
		public Quaternion RandomRotation() => default; // 0x00000001874A8370-0x00000001874A8560
	}
}
