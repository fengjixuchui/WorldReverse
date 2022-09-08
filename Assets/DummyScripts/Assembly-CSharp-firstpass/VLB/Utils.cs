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

namespace VLB
{
	public static class Utils // TypeDefIndex: 10205
	{
		// Fields
		private static FloatPackingPrecision ms_FloatPackingPrecision; // 0x00
		private const int kFloatPackingHighMinShaderLevel = 35; // Metadata: 0x00AE7219
	
		// Nested types
		public enum FloatPackingPrecision // TypeDefIndex: 10206
		{
			Undef = 0,
			Low = 8,
			High = 64
		}
	
		// Constructors
		static Utils() {} // 0x0000000186EA92F0-0x0000000186EA9350
	
		// Methods
		public static T NewWithComponent<T>(string name)
			where T : Component => default;
		// [XID] // 0x00000001896CB3F0-0x00000001896CB410
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f /* Metadata: 0x00AE7215 */) {} // 0x0000000186EA8120-0x0000000186EA8710
		// [XID] // 0x00000001896F7A50-0x00000001896F7A70
		private static Vector4 Vector4_Floor(Vector4 vec) => default; // 0x0000000186EA9170-0x0000000186EA92F0
		// [XID] // 0x00000001896E8F70-0x00000001896E8F90
		public static FloatPackingPrecision GetFloatPackingPrecision() => default; // 0x0000000186EA7CF0-0x0000000186EA7E30
	
		// Extension methods
		public static T GetOrAddComponent<T>(this GameObject self)
			where T : Component => default;
		public static T GetOrAddComponent<T>(this MonoBehaviour self)
			where T : Component => default;
		// [XID] // 0x0000000189662E00-0x0000000189662E40
		public static bool HasFlag(this System.Enum mask, System.Enum flags) => default; // 0x0000000186EA8710-0x0000000186EA8910
		// [XID] // 0x000000018966D700-0x000000018966D740
		public static Vector2 xy(this Vector3 aVector) => default; // 0x0000000186EA9350-0x0000000186EA9440
		// [XID] // 0x00000001896784D0-0x0000000189678510
		public static Vector2 xz(this Vector3 aVector) => default; // 0x0000000186EA9440-0x0000000186EA9530
		// [XID] // 0x0000000189682BC0-0x0000000189682C00
		public static Vector2 yz(this Vector3 aVector) => default; // 0x0000000186EA9620-0x0000000186EA9710
		// [XID] // 0x000000018968D530-0x000000018968D570
		public static Vector2 yx(this Vector3 aVector) => default; // 0x0000000186EA9530-0x0000000186EA9620
		// [XID] // 0x00000001896984D0-0x0000000189698510
		public static Vector2 zx(this Vector3 aVector) => default; // 0x0000000186EA9710-0x0000000186EA9800
		// [XID] // 0x00000001896A2940-0x00000001896A2980
		public static Vector2 zy(this Vector3 aVector) => default; // 0x0000000186EA9800-0x0000000186EA98F0
		// [XID] // 0x00000001896ACBA0-0x00000001896ACBE0
		public static float GetVolumeCubic(this Bounds self) => default; // 0x0000000186EA7FF0-0x0000000186EA8120
		// [XID] // 0x00000001896B6E30-0x00000001896B6E70
		public static float GetMaxArea2D(this Bounds self) => default; // 0x0000000186EA7E30-0x0000000186EA7FF0
		// [XID] // 0x00000001896C1040-0x00000001896C1080
		public static Color Opaque(this Color self) => default; // 0x0000000186EA8910-0x0000000186EA8A30
		// [XID] // 0x00000001896D29F0-0x00000001896D2A30
		public static Plane TranslateCustom(this Plane plane, Vector3 translation) => default; // 0x0000000186EA8FB0-0x0000000186EA9170
		// [XID] // 0x00000001896DD070-0x00000001896DD0B0
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision) => default; // 0x0000000186EA8D60-0x0000000186EA8FB0
		// [XID] // 0x00000001896E7680-0x00000001896E76C0
		public static Color[] SampleInArray(this Gradient self, int samplesCount) => default; // 0x0000000186EA8BD0-0x0000000186EA8D60
		// [XID] // 0x00000001896F9210-0x00000001896F9250
		public static float PackToFloat(this Color color, int floatPackingPrecision) => default; // 0x0000000186EA8A30-0x0000000186EA8BD0
	}
}
