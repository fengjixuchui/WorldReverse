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

namespace RootMotion.Dynamics
{
	public static class JointConverter // TypeDefIndex: 9923
	{
		// Methods
		// [XID] // 0x00000001897C5910-0x00000001897C5930
		public static void ToConfigurable(GameObject root) {} // 0x00000001876D8510-0x00000001876D8820
		// [XID] // 0x00000001897CCF60-0x00000001897CCF80
		public static void HingeToConfigurable(HingeJoint src) {} // 0x00000001876D7DF0-0x00000001876D8270
		// [XID] // 0x00000001897D4610-0x00000001897D4630
		public static void FixedToConfigurable(FixedJoint src) {} // 0x00000001876D7BA0-0x00000001876D7DF0
		// [XID] // 0x00000001897DBD30-0x00000001897DBD50
		public static void SpringToConfigurable(SpringJoint src) {} // 0x00000001876D8270-0x00000001876D8510
		// [XID] // 0x00000001897E3790-0x00000001897E37B0
		public static void CharacterToConfigurable(CharacterJoint src) {} // 0x00000001876D6DF0-0x00000001876D72C0
		// [XID] // 0x00000001897EAF40-0x00000001897EAF60
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src) {} // 0x00000001876D72C0-0x00000001876D7520
		// [XID] // 0x00000001897080C0-0x00000001897080E0
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring) => default; // 0x00000001876D7520-0x00000001876D7690
		// [XID] // 0x0000000189780640-0x0000000189780660
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring) => default; // 0x00000001876D7690-0x00000001876D7800
		// [XID] // 0x000000018972D470-0x000000018972D490
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring) => default; // 0x00000001876D7800-0x00000001876D7960
		// [XID] // 0x0000000189956820-0x0000000189956840
		private static SoftJointLimit CopyLimit(SoftJointLimit src) => default; // 0x00000001876D7A60-0x00000001876D7BA0
		// [XID] // 0x000000018995E290-0x000000018995E2B0
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src) => default; // 0x00000001876D7960-0x00000001876D7A60
	}
}
