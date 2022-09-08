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

namespace RootMotion
{
	public static class QuaTools // TypeDefIndex: 9950
	{
		// Methods
		// [XID] // 0x000000018972E8D0-0x000000018972E8F0
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x00000001868D9A20-0x00000001868D9BC0
		// [XID] // 0x000000018973DCF0-0x000000018973DD10
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight) => default; // 0x00000001868DA160-0x00000001868DA300
		// [XID] // 0x00000001896B6E70-0x00000001896B6E90
		public static Quaternion LinearBlend(Quaternion q, float weight) => default; // 0x00000001868D9BC0-0x00000001868D9D60
		// [XID] // 0x00000001896BDFC0-0x00000001896BDFE0
		public static Quaternion SphericalBlend(Quaternion q, float weight) => default; // 0x00000001868DA300-0x00000001868DA4A0
		// [XID] // 0x00000001896C5890-0x00000001896C58B0
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis) => default; // 0x00000001868D91E0-0x00000001868D9470
		// [XID] // 0x00000001896CCF40-0x00000001896CCF60
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation) => default; // 0x00000001868D9FE0-0x00000001868DA160
		// [XID] // 0x00000001899FC0A0-0x00000001899FC0C0
		public static Quaternion FromToRotation(Quaternion from, Quaternion to) => default; // 0x00000001868D9470-0x00000001868D9650
		// [XID] // 0x00000001896DBB40-0x00000001896DBB60
		public static Vector3 ToAngularDelta(Quaternion delta) => default; // 0x00000001868DA4A0-0x00000001868DA630
		// [XID] // 0x00000001896E32A0-0x00000001896E32C0
		public static Vector3 GetAxis(Vector3 v) => default; // 0x00000001868D9650-0x00000001868D9A20
		// [XID] // 0x00000001897E1960-0x00000001897E1980
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing) => default; // 0x00000001868D8EC0-0x00000001868D91E0
		// [XID] // 0x00000001896F17F0-0x00000001896F1810
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing) => default; // 0x00000001868D8C50-0x00000001868D8EC0
		// [XID] // 0x00000001896F9250-0x00000001896F9270
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis) => default; // 0x00000001868D9D60-0x00000001868D9FE0
	}
}
