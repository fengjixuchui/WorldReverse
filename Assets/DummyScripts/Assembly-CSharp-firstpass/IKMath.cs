/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class IKMath // TypeDefIndex: 8544
{
	// Methods
	public static Vector3 AngularVelocity(Quaternion quat, Quaternion prevQuat, float deltaTime) => default; // 0x0000000187DC0010-0x0000000187DC0200
	public static Vector3 ClampPosInAxis(Vector3 targetPos, Vector3 prevPos, Vector3 prevVel, Vector3 normailzedAxis, float maxSpeed, float maxAcc, float deltatime) => default; // 0x0000000187DC0350-0x0000000187DC07C0
	public static Quaternion ClampQuanternion(Quaternion targetQuat, Quaternion prevQuat, Vector3 prevVel, float maxAngularVel, float maxAngularAcc, float deltatime) => default; // 0x0000000187DC07C0-0x0000000187DC0BA0
	public static Vector3 ClampDirection(Vector3 targetDir, Vector3 prevDir, float damping, float deltatime) => default; // 0x0000000187DC0200-0x0000000187DC0350
	public static Vector3 ProjectVectorOnPlane(Vector3 planePoint, Vector3 planeNormal, Vector3 inPoint) => default; // 0x0000000187DC1070-0x0000000187DC11E0

	// Extension methods
	public static Quaternion GetRotation(this Matrix4x4 matrix) => default; // 0x0000000187DC0BA0-0x0000000187DC0D10
	public static Vector3 GetUp(this Matrix4x4 matrix) => default; // 0x0000000187DC0D10-0x0000000187DC0DE0
	public static Matrix4x4 ToMatrix44(this Quaternion quat) => default; // 0x0000000187DC11E0-0x0000000187DC1430
	public static Vector3 Log(this Quaternion quat) => default; // 0x0000000187DC0DE0-0x0000000187DC0F00
	public static void Negate(this Quaternion lhs) {} // 0x0000000187DC0F00-0x0000000187DC0F60
	public static void Normalize(this Quaternion lhs) {} // 0x0000000187DC0F60-0x0000000187DC1070
}

