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
	public static class Mathfex // TypeDefIndex: 8119
	{
		// Fields
		public const float ZeroTolerance = 1E-05f; // Metadata: 0x00ADF50C
		public const float NegativeZeroTolerance = -1E-05f; // Metadata: 0x00ADF510
		public const float ZeroToleranceSqr = 9.9999994E-11f; // Metadata: 0x00ADF514
		public const float Pi = 3.1415927f; // Metadata: 0x00ADF518
		public const float HalfPi = 1.5707964f; // Metadata: 0x00ADF51C
		public const float TwoPi = 6.2831855f; // Metadata: 0x00ADF520
	
		// Methods
		// [XID] // 0x0000000189AFB020-0x0000000189AFB040
		public static float EvalSquared(float x) => default; // 0x0000000188D26500-0x0000000188D265B0
		// [XID] // 0x0000000189655C40-0x0000000189655C60
		public static float EvalInvSquared(float x) => default; // 0x0000000188D25FF0-0x0000000188D260C0
		// [XID] // 0x0000000189B09C20-0x0000000189B09C40
		public static float EvalCubic(float x) => default; // 0x0000000188D25B70-0x0000000188D25C30
		// [XID] // 0x00000001899C0390-0x00000001899C03B0
		public static float EvalInvCubic(float x) => default; // 0x0000000188D25F20-0x0000000188D25FF0
		// [XID] // 0x00000001899C7C10-0x00000001899C7C30
		public static float EvalQuadratic(float x, float a, float b, float c) => default; // 0x0000000188D261E0-0x0000000188D262F0
		// [XID] // 0x00000001899CF3D0-0x00000001899CF3F0
		public static float EvalSigmoid(float x) => default; // 0x0000000188D262F0-0x0000000188D263C0
		// [XID] // 0x00000001899DDEF0-0x00000001899DDF10
		public static float EvalOverlappedStep(float x, float overlap, int objectIndex, int objectCount) => default; // 0x0000000188D260C0-0x0000000188D261E0
		// [XID] // 0x0000000189682DB0-0x0000000189682DD0
		public static float EvalSmoothOverlappedStep(float x, float overlap, int objectIndex, int objectCount) => default; // 0x0000000188D263C0-0x0000000188D26500
		// [XID] // 0x000000018968A960-0x000000018968A980
		public static float EvalGaussian(float x, float a, float b, float c) => default; // 0x0000000188D25DE0-0x0000000188D25F20
		// [XID] // 0x0000000189692740-0x0000000189692760
		public static float EvalGaussian2D(float x, float y, float x0, float y0, float A, float a, float b, float c) => default; // 0x0000000188D25C30-0x0000000188D25DE0
		// [XID] // 0x0000000189699970-0x0000000189699990
		public static float Lerp(float value0, float value1, float factor) => default; // 0x0000000188D268C0-0x0000000188D269C0
		// [XID] // 0x0000000189A03530-0x0000000189A03550
		public static float LerpUnclamped(float value0, float value1, float factor) => default; // 0x0000000188D267E0-0x0000000188D268C0
		// [XID] // 0x0000000189A0AB90-0x0000000189A0ABB0
		public static float SigmoidInterp(float value0, float value1, float factor) => default; // 0x0000000188D26D00-0x0000000188D26E20
		// [XID] // 0x00000001896AF750-0x00000001896AF770
		public static float SinInterp(float value0, float value1, float factor) => default; // 0x0000000188D26E20-0x0000000188D26F50
		// [XID] // 0x0000000189A197F0-0x0000000189A19810
		public static float CosInterp(float value0, float value1, float factor) => default; // 0x0000000188D257A0-0x0000000188D258E0
		// [XID] // 0x00000001896BE0C0-0x00000001896BE0E0
		public static float WobbleInterp(float value0, float value1, float factor) => default; // 0x0000000188D27100-0x0000000188D272C0
		// [XID] // 0x00000001896C59B0-0x00000001896C59D0
		public static float CurveInterp(float value0, float value1, float factor, AnimationCurve curve) => default; // 0x0000000188D258E0-0x0000000188D25A10
		// [XID] // 0x0000000189AD53E0-0x0000000189AD5400
		public static float FuncInterp(float value0, float value1, float factor, Func<float, float> func) => default; // 0x0000000188D265B0-0x0000000188D266F0
		// [XID] // 0x00000001896D44C0-0x00000001896D44E0
		public static float InvSqrt(float value) => default; // 0x0000000188D266F0-0x0000000188D267E0
		// [XID] // 0x0000000189A2F930-0x0000000189A2F950
		public static bool Near(float value0, float value1, float epsilon = 1E-05f /* Metadata: 0x00ADF504 */) => default; // 0x0000000188D26AB0-0x0000000188D26BC0
		// [XID] // 0x0000000189A37300-0x0000000189A37320
		public static bool NearZero(float value, float epsilon = 1E-05f /* Metadata: 0x00ADF508 */) => default; // 0x0000000188D269C0-0x0000000188D26AB0
		// [XID] // 0x00000001896EA8C0-0x00000001896EA8E0
		public static Vector2 CartesianToPolar(Vector2 cartesianCoordinates) => default; // 0x0000000188D252E0-0x0000000188D254E0
		// [XID] // 0x0000000189A460C0-0x0000000189A460E0
		public static Vector2 PolarToCartesian(Vector2 polarCoordinates) => default; // 0x0000000188D26BC0-0x0000000188D26D00
		// [XID] // 0x0000000189A4D810-0x0000000189A4D830
		public static Vector3 CartesianToSpherical(Vector3 cartesianCoordinates) => default; // 0x0000000188D254E0-0x0000000188D257A0
		// [XID] // 0x0000000189700D90-0x0000000189700DB0
		public static Vector3 SphericalToCartesian(Vector3 sphericalCoordinates) => default; // 0x0000000188D26F50-0x0000000188D27100
		// [XID] // 0x0000000189A5C980-0x0000000189A5C9A0
		public static Vector3 CartesianToCylindrical(Vector3 cartesianCoordinates) => default; // 0x0000000188D25080-0x0000000188D252E0
		// [XID] // 0x0000000189A64270-0x0000000189A64290
		public static Vector3 CylindricalToCartesian(Vector3 cylindricalCoordinates) => default; // 0x0000000188D25A10-0x0000000188D25B70
	}
}
