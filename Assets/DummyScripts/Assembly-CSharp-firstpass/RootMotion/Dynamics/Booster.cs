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
	[Serializable]
	public class Booster // TypeDefIndex: 9886
	{
		// Fields
		// [Tooltip] // 0x0000000189ACBE00-0x0000000189ACBE30
		public bool fullBody; // 0x10
		// [Tooltip] // 0x0000000189AD55D0-0x0000000189AD5600
		public ConfigurableJoint[] muscles; // 0x18
		// [Tooltip] // 0x0000000189ADE5E0-0x0000000189ADE610
		public Muscle.Group[] groups; // 0x20
		// [Range] // 0x0000000189AE7600-0x0000000189AE7650
		// [Tooltip] // 0x0000000189AE7600-0x0000000189AE7650
		public float immunity; // 0x28
		// [Tooltip] // 0x0000000189AF38A0-0x0000000189AF38D0
		public float impulseMlp; // 0x2C
		// [Tooltip] // 0x0000000189AFC420-0x0000000189AFC450
		public float boostParents; // 0x30
		// [Tooltip] // 0x0000000189B054C0-0x0000000189B054F0
		public float boostChildren; // 0x34
		// [Tooltip] // 0x0000000189B0E540-0x0000000189B0E570
		public float delay; // 0x38
	
		// Constructors
		public Booster() {} // 0x00000001876D5C30-0x00000001876D5CE0
	
		// Methods
		// [XID] // 0x0000000189735170-0x0000000189735190
		public void Boost(BehaviourPuppet puppet) {} // 0x00000001876D58C0-0x00000001876D5C30
	}
}
