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

namespace RootMotion.FinalIK
{
	public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 9847
	{
		// Fields
		public Vector3 axis; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Vector3 fwdAxialFix; // 0x24
		// [Range] // 0x0000000189850340-0x00000001898503A0
		// [Tooltip] // 0x0000000189850340-0x00000001898503A0
		public float RotationLimitWeight; // 0x30
		// [Range] // 0x000000018985BFA0-0x000000018985BFF0
		// [Tooltip] // 0x000000018985BFA0-0x000000018985BFF0
		public float useWeightForLimitSwing; // 0x34
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public Quaternion defaultLocalRotation; // 0x38
		private bool initiated; // 0x48
		private bool applicationQuit; // 0x49
		private bool defaultLocalRotationSet; // 0x4A
	
		// Properties
		public Vector3 secondaryAxis { /* [XID] */ /* 0x00000001896EB380-0x00000001896EB3A0 */ get; } // 0x00000001868E0DA0-0x00000001868E0EB0 
		public Vector3 crossAxis { /* [XID] */ /* 0x0000000189893DC0-0x0000000189893DE0 */ get; } // 0x00000001868E0C20-0x00000001868E0DA0 
	
		// Constructors
		protected RotationLimit() {} // 0x00000001868E0B70-0x00000001868E0C20
	
		// Methods
		// [XID] // 0x000000018986F140-0x000000018986F160
		public void SetDefaultLocalRotation() {} // 0x00000001868E0AA0-0x00000001868E0B70
		// [XID] // 0x0000000189AA80A0-0x0000000189AA80C0
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) {
			changed = default;
			return default;
		} // 0x00000001868DFB10-0x00000001868DFD20
		// [XID] // 0x0000000189AA0A20-0x0000000189AA0A40
		public bool Apply() => default; // 0x00000001868DF7A0-0x00000001868DF8F0
		// [XID] // 0x000000018999FB30-0x000000018999FB50
		public void Disable() {} // 0x00000001868DFA50-0x00000001868DFB10
		protected abstract Quaternion LimitRotation(Quaternion rotation);
		// [XID] // 0x000000018989B4D0-0x000000018989B4F0
		private void Awake() {} // 0x00000001868DF8F0-0x00000001868DFA50
		// [XID] // 0x0000000189B6E2C0-0x0000000189B6E2E0
		private void LateUpdate() {} // 0x00000001868DFEA0-0x00000001868DFF40
		// [XID] // 0x00000001898EED00-0x00000001898EED20
		public void LogWarning(string message) {} // 0x00000001868E09D0-0x00000001868E0AA0
		// [XID] // 0x00000001896279B0-0x00000001896279D0
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) => default; // 0x00000001868DFF40-0x00000001868E0100
		// [XID] // 0x00000001898DF9A0-0x00000001898DF9C0
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) => default; // 0x00000001868E0660-0x00000001868E09D0
		// [XID] // 0x00000001898FDCA0-0x00000001898FDCC0
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) => default; // 0x00000001868DFD20-0x00000001868DFEA0
		// [XID] // 0x00000001898C7FE0-0x00000001898C8000
		protected static Quaternion LimitTwistWorld(Quaternion rotation, float twistLimitWorld, Quaternion defaultLocalRotation, Quaternion transformLocalRotation, Quaternion transformRotation, float weight) => default; // 0x00000001868E02C0-0x00000001868E0660
		// [XID] // 0x00000001898CF7D0-0x00000001898CF7F0
		protected static Quaternion LimitSwingByWeight(Quaternion rotation, Quaternion rawRotation, float useWeightForLimitSwing, float weight) => default; // 0x00000001868E0100-0x00000001868E02C0
	}
}
