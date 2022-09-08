/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using MoleMole;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class CameraUtils // TypeDefIndex: 6823
{
	// Fields
	public const float Epsilon = 0.001f; // Metadata: 0x00ADDEE6

	// Constructors
	public CameraUtils() {} // 0x00000001864D61A0-0x00000001864D6200

	// Methods
	public static bool Approximately(float a, float b) => default; // 0x00000001864D37C0-0x00000001864D3880
	public static bool Approximately(Vector3 a, Vector3 b) => default; // 0x00000001864D3700-0x00000001864D37C0
	public static bool IsAlmostZero(float f, float EPSILON) => default; // 0x00000001864D4870-0x00000001864D48F0
	public static bool IsVectorZero(Vector3 vec) => default; // 0x00000001864D4AA0-0x00000001864D4F00
	public static bool IsNaN(float a) => default; // 0x00000001864D4980-0x00000001864D4A00
	public static bool IsNaN(Vector2 vec) => default; // 0x00000001864D48F0-0x00000001864D4980
	public static bool IsNaN(Vector3 vec) => default; // 0x00000001864D4A00-0x00000001864D4AA0
	public static void PrintValue(string title, float value) {} // 0x00000001864D5280-0x00000001864D5370
	public static void PrintValue(string title, Vector2 value) {} // 0x00000001864D51A0-0x00000001864D5280
	public static void PrintValue(string title, Vector3 value) {} // 0x00000001864D5370-0x00000001864D5450
	public static Vector3 Cartesian2Spherial(Vector3 cPos) => default; // 0x00000001864D44D0-0x00000001864D4620
	public static Vector3 Spherial2Cartesian(Vector3 sPos) => default; // 0x00000001864D5CD0-0x00000001864D5E30
	public static Vector3d Cartesian2Spherial(Vector3d cPos) => default; // 0x00000001864D3F90-0x00000001864D4070
	public static Vector3d Spherial2Cartesian(Vector3d sPos) => default; // 0x00000001864D5E30-0x00000001864D5F40
	public static Vector3 Cartesian2Spherial(Vector3 cameraPos, Vector3 cameraForward, Vector3 cameraLookAt, out float deltaPole, out float deltaElve) {
		deltaPole = default;
		deltaElve = default;
		return default;
	} // 0x00000001864D4070-0x00000001864D44D0
	public static Vector3d Cartesian2Spherial(Vector3d cameraPos, Vector3d cameraForward, Vector3d cameraLookAt, out double deltaPole, out double deltaElve) {
		deltaPole = default;
		deltaElve = default;
		return default;
	} // 0x00000001864D3A90-0x00000001864D3F90
	public static Vector3 Spherial2Cartesian(Vector3 cameraSph, Vector3 cameraLookAt) => default; // 0x00000001864D5BB0-0x00000001864D5CD0
	public static void ReduceAnchorAngularVelocity(ref Vector2 refAnchorAngularVelocity, float reduceLerpRatio, float reduceLerpAccuracy) {} // 0x00000001864D59D0-0x00000001864D5BB0
	public static float To180Angle(float f) => default; // 0x00000001864D5F40-0x00000001864D5FE0
	public static float To360Angle(float f) => default; // 0x00000001864D5FE0-0x00000001864D6070
	public static float LinearLerp(float src, float tar, float lerpRatio, float dt) => default; // 0x00000001864D50E0-0x00000001864D51A0
	public static bool RatioLerp(ref float src, float tar, float lerpRatio, float dt) => default; // 0x00000001864D5840-0x00000001864D59D0
	public static bool RatioLerpZWithFov(ref float srcZ, float tarZ, ref float srcFov, float tarFov, float lerpRatio, float dt) => default; // 0x00000001864D5670-0x00000001864D5840
	public static bool RatioLerpAngle(ref float src, float tar, float lerpRatio, float dt) => default; // 0x00000001864D5450-0x00000001864D5670
	public static float LinearLerpPoleAngle(float fromAngle, float toAngle, float lerpRatio, float deltaT) => default; // 0x00000001864D4F00-0x00000001864D50E0
	public static void InitVec3Trace(ref Vector3[] dirTrace, Vector3 dirVec) {} // 0x00000001864D47A0-0x00000001864D4870
	public static void UpdateVec3Trace(ref Vector3[] dirTrace, Vector3 dirVec) {} // 0x00000001864D6070-0x00000001864D61A0
	public static Vector3 AverageVec3Trace(ref Vector3[] dirTrace, int K) => default; // 0x00000001864D3880-0x00000001864D3A90
	public static Vector3 GenFocusTarget(Vector3 interPos, Vector3 inteePos, float height) => default; // 0x00000001864D4620-0x00000001864D47A0
}

