/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class EnviroMathUtil // TypeDefIndex: 31536
{
	// Methods
	public static float Modulo(float value, float length) => default; // 0x000000018369AFF0-0x000000018369B140
	public static float MapRangeUnclamped(float value, float oldMin, float oldMax, float newMin, float newMax) => default; // 0x000000018369AF40-0x000000018369AFF0
	public static float MapRangeClamped(float value, float oldMin, float oldMax, float newMin, float newMax) => default; // 0x000000018369AE40-0x000000018369AF40
	public static float ClampedValue(float value, float min = 0f /* Metadata: 0x00B128BD */, float max = 1f /* Metadata: 0x00B128C1 */) => default; // 0x000000018369A330-0x000000018369A3F0
	public static Quaternion MakeRotator(float x, float y, float z) => default; // 0x000000018369AD70-0x000000018369AE40
	public static Quaternion MakeRotator(Vector3 rot) => default; // 0x000000018369AC80-0x000000018369AD70
	public static Quaternion GetOrbitRotation(float yaw, float pitch, float inclination) => default; // 0x000000018369A940-0x000000018369AB20
	public static Vector3 GetOrbitDirection(Quaternion rotation) => default; // 0x000000018369A710-0x000000018369A860
	public static Vector3 GetOrbitDirection(float yaw, float pitch, float inclination) => default; // 0x000000018369A860-0x000000018369A940
	public static void GetAxes(Quaternion rot, out Vector3 x, out Vector3 y, out Vector3 z) {
		x = default;
		y = default;
		z = default;
	} // 0x000000018369A3F0-0x000000018369A670
	public static Vector3 OrbitalToCartesian(float radius, float theta, float phi) => default; // 0x000000018369B140-0x000000018369B270
	public static float GetElapsedTimeWithoutMutation(float time, float newSpeed, ref float curSpeed, ref float curOffset) => default; // 0x000000018369A670-0x000000018369A710
	public static Vector2 GetRandomSeedFromFrame(int frame) => default; // 0x000000018369AB20-0x000000018369ABD0
	private static float HaltonSequence(int index, int baseNum) => default; // 0x000000018369ABD0-0x000000018369AC80
}

