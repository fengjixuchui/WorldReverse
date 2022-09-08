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

namespace InControl
{
	public class UnityGyroAxisSource : InputControlSource // TypeDefIndex: 7847
	{
		// Fields
		private static Quaternion zeroAttitude; // 0x00
		public int Axis; // 0x10
	
		// Nested types
		public enum GyroAxis // TypeDefIndex: 7848
		{
			X = 0,
			Y = 1
		}
	
		// Constructors
		public UnityGyroAxisSource() {} // 0x0000000187AF80E0-0x0000000187AF8150
		public UnityGyroAxisSource(GyroAxis axis) {} // 0x0000000187AF8060-0x0000000187AF80E0
	
		// Methods
		// [XID] // 0x0000000189847520-0x0000000189847540
		public float GetValue(InputDevice inputDevice) => default; // 0x0000000187AF7F60-0x0000000187AF8060
		// [XID] // 0x0000000189A7C6C0-0x0000000189A7C6E0
		public bool GetState(InputDevice inputDevice) => default; // 0x0000000187AF7E70-0x0000000187AF7F60
		// [XID] // 0x0000000189A83F90-0x0000000189A83FB0
		private static Quaternion GetAttitude() => default; // 0x0000000187AF7AD0-0x0000000187AF7C50
		// [XID] // 0x0000000189A8B950-0x0000000189A8B970
		private static Vector3 GetAxis() => default; // 0x0000000187AF7C50-0x0000000187AF7E70
		// [XID] // 0x0000000189A92ED0-0x0000000189A92EF0
		private static float ApplyDeadZone(float value) => default; // 0x0000000187AF78A0-0x0000000187AF79E0
		// [XID] // 0x0000000189A9A9C0-0x0000000189A9A9E0
		public static void Calibrate() {} // 0x0000000187AF79E0-0x0000000187AF7AD0
	}
}
