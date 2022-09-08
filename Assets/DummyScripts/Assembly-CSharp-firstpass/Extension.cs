/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using motion4hi;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class Extension // TypeDefIndex: 9389
{
	// Fields
	public static Vector2 _extDisableRRM; // 0x00

	// Constructors
	static Extension() {} // 0x00000001863BB3D0-0x00000001863BB460

	// Methods
	public static string WildcardToRegex(string pattern) => default; // 0x00000001863BAF30-0x00000001863BB0D0
	public static Vector3 AbsVec3(Vector3 vec) => default; // 0x00000001863B84C0-0x00000001863B85B0
	public static T[] GrowArray<T>(T[] inArray, int inAddNum) => default;
	public static T[] FitArray<T>(T[] inArray, int inNewNum) => default;
	public static T[] RemoveFromArray<T>(T[] inArray, int removeIndex) => default;
	public static float FloatField(float value, float width) => default; // 0x00000001863B9540-0x00000001863B96D0

	// Extension methods
	public static Vector4 Elapsed(this AnimatorStateInfo state) => default; // 0x00000001863B8E40-0x00000001863B8FA0
	public static float WrapElapsed(this AnimatorStateInfo state, float dt) => default; // 0x00000001863BB0D0-0x00000001863BB1B0
	public static float WrapNormalizedElapsed(this AnimatorStateInfo state, float dt) => default; // 0x00000001863BB1B0-0x00000001863BB290
	public static float SpeedScale(this AnimatorStateInfo state, Animator anim) => default; // 0x00000001863BA160-0x00000001863BA220
	public static float Elapsed(this AnimatorStateInfo state, float dt) => default; // 0x00000001863B8FA0-0x00000001863B9070
	public static float Elapsed(this AnimatorStateInfo state, float accumElapsed, float normalElapsed) => default; // 0x00000001863B9070-0x00000001863B91A0
	public static float EvaluateAccumlated(this AnimationCurve curve, float t) => default; // 0x00000001863B91A0-0x00000001863B9390
	public static float EvaluateDistance(this AnimationCurve curve) => default; // 0x00000001863B9390-0x00000001863B9480
	public static float EvaluateSpeed(this AnimationCurve curve, float t) => default; // 0x00000001863B9480-0x00000001863B9540
	public static float Duration(this AnimationCurve curve) => default; // 0x00000001863B8D80-0x00000001863B8E40
	public static Vector4 CalcMotionParams(this AnimationCurve curve) => default; // 0x00000001863B8920-0x00000001863B8A40
	public static float CalcMotionV0(this AnimationCurve curve) => default; // 0x00000001863B8A40-0x00000001863B8AE0
	public static Vector4 CalcMotionParamsByMaxDistance(this AnimationCurve curve) => default; // 0x00000001863B86E0-0x00000001863B8920
	public static Vector4 CalcMotionParamsByDuration(this AnimationCurve curve, Vector2 duration) => default; // 0x00000001863B85B0-0x00000001863B86E0
	public static float Stride(this Vector4 p, float stepScale) => default; // 0x00000001863BA220-0x00000001863BA2A0
	public static bool MatchWildcard(this string pattern, string text) => default; // 0x00000001863B9FD0-0x00000001863BA0B0
	public static Vector3 XZ(this Vector3 v) => default; // 0x00000001863BB290-0x00000001863BB330
	public static Vector3 YOnly(this Vector3 v) => default; // 0x00000001863BB330-0x00000001863BB3D0
	public static float Dot(this Vector2 lhs, Vector2 rhs) => default; // 0x00000001863B8BE0-0x00000001863B8CA0
	public static float Dot(this Vector3 lhs, Vector3 rhs) => default; // 0x00000001863B8CA0-0x00000001863B8D80
	public static Vector3 Cross(this Vector3 lhs, Vector3 rhs) => default; // 0x00000001863B8AE0-0x00000001863B8BE0
	public static Vector3 NegtiveX(this Vector3 v) => default; // 0x00000001863BA0B0-0x00000001863BA160
	public static string ToStringWith2DecimalPlace(this Vector3 v) => default; // 0x00000001863BA7F0-0x00000001863BA8E0
	public static string GetCurrentStateName(this Animator animator, int layer, AnimatorController animCont) => default; // 0x00000001863B96D0-0x00000001863B97C0
	public static string GetStateName(this Animator animator, int shortNameHash, AnimatorController animCont) => default; // 0x00000001863B9D20-0x00000001863B9DB0
	public static string GetNextStateName(this Animator animator, int layer, AnimatorController animCont) => default; // 0x00000001863B9B40-0x00000001863B9C30
	public static float GetDisableRRM(this Animator animator) => default; // 0x00000001863B98B0-0x00000001863B99C0
	public static float GetDisableSpeedWarping(this Animator animator) => default; // 0x00000001863B99C0-0x00000001863B9A80
	public static float GetDisableTimeWarping(this Animator animator) => default; // 0x00000001863B9A80-0x00000001863B9B40
	public static AnimationPhaseArray GetCurrentStatePhaseArray(this Animator animator, int layer, AnimatorController animCont) => default; // 0x00000001863B97C0-0x00000001863B98B0
	public static AnimationPhaseArray GetNextStatePhaseArray(this Animator animator, int layer, AnimatorController animCont) => default; // 0x00000001863B9C30-0x00000001863B9D20
	public static Quaternion ToQuaternion(this Matrix4x4 m) => default; // 0x00000001863BA6E0-0x00000001863BA7F0
	public static Quaternion ToQuaternion(this Matrix4x4 m, Vector3 inScale) => default; // 0x00000001863BA2A0-0x00000001863BA6E0
	public static float AbsDeltaAngle(this Quaternion from, Quaternion to) => default; // 0x00000001863B8340-0x00000001863B84C0
	public static bool IsGameplayDirty(this Vector3 from, Vector3 to, float threshold) => default; // 0x00000001863B9DB0-0x00000001863B9EE0
	public static bool IsGameplayDirty(this Quaternion from, Quaternion to, float threshold) => default; // 0x00000001863B9EE0-0x00000001863B9FD0
	public static void ToWorldSpaceCapsule(this CapsuleCollider capsule, Vector3 position, Quaternion rotation, out Vector3 point0, out Vector3 point1, out float radius) {
		point0 = default;
		point1 = default;
		radius = default;
	} // 0x00000001863BA8E0-0x00000001863BAF30
	public static GameObject xChild(this GameObject inRootGo, string inName) => default; // 0x00000001863BB460-0x00000001863BB5B0
}

