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
	// [AddComponentMenu] // 0x0000000189A6BCA0-0x0000000189A6BD00
	// [HelpURL] // 0x0000000189A6BCA0-0x0000000189A6BD00
	public class RotationLimitSpline : RotationLimit // TypeDefIndex: 9853
	{
		// Fields
		// [Range] // 0x0000000189994A40-0x0000000189994A60
		public float twistLimit; // 0x50
		// [Range] // 0x0000000189994A40-0x0000000189994A60
		public float twistLimitWorld; // 0x54
		[HideInInspector] // 0x00000001898EE050-0x00000001898EE080
		[SerializeField] // 0x00000001898EE050-0x00000001898EE080
		public AnimationCurve spline; // 0x58
	
		// Constructors
		public RotationLimitSpline() {} // 0x00000001868DF730-0x00000001868DF7A0
	
		// Methods
		// [ContextMenu] // 0x0000000189A915F0-0x0000000189A91640
		// [XID] // 0x0000000189A915F0-0x0000000189A91640
		private void OpenUserManual() {} // 0x00000001868DF510-0x00000001868DF5C0
		// [ContextMenu] // 0x0000000189A9BC80-0x0000000189A9BCD0
		// [XID] // 0x0000000189A9BC80-0x0000000189A9BCD0
		private void OpenScriptReference() {} // 0x00000001868DF460-0x00000001868DF510
		// [ContextMenu] // 0x0000000189AA6390-0x0000000189AA63E0
		// [XID] // 0x0000000189AA6390-0x0000000189AA63E0
		private void SupportGroup() {} // 0x00000001868DF680-0x00000001868DF730
		// [ContextMenu] // 0x0000000189AB0B10-0x0000000189AB0B60
		// [XID] // 0x0000000189AB0B10-0x0000000189AB0B60
		private void ASThread() {} // 0x00000001868DED00-0x00000001868DEDB0
		// [XID] // 0x0000000189ABB7D0-0x0000000189ABB7F0
		public void SetSpline(Keyframe[] keyframes) {} // 0x00000001868DF5C0-0x00000001868DF680
		// [XID] // 0x000000018969FCF0-0x000000018969FD10
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001868DEDB0-0x00000001868DF040
		// [XID] // 0x0000000189698860-0x0000000189698880
		public Quaternion LimitSwing(Quaternion rotation) => default; // 0x00000001868DF040-0x00000001868DF460
	}
}
