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
	// [AddComponentMenu] // 0x00000001898D7150-0x00000001898D71B0
	// [HelpURL] // 0x00000001898D7150-0x00000001898D71B0
	public class RotationLimitAngle : RotationLimit // TypeDefIndex: 9848
	{
		// Fields
		// [Range] // 0x0000000189994A40-0x0000000189994A60
		public float limit; // 0x50
		// [Range] // 0x0000000189994A40-0x0000000189994A60
		public float twistLimit; // 0x54
		// [Range] // 0x0000000189994A40-0x0000000189994A60
		public float twistLimitWorld; // 0x58
	
		// Constructors
		public RotationLimitAngle() {} // 0x00000001868DB990-0x00000001868DBA10
	
		// Methods
		// [ContextMenu] // 0x00000001898FB3B0-0x00000001898FB400
		// [XID] // 0x00000001898FB3B0-0x00000001898FB400
		private void OpenUserManual() {} // 0x00000001868DB830-0x00000001868DB8E0
		// [ContextMenu] // 0x0000000189905F10-0x0000000189905F60
		// [XID] // 0x0000000189905F10-0x0000000189905F60
		private void OpenScriptReference() {} // 0x00000001868DB780-0x00000001868DB830
		// [ContextMenu] // 0x0000000189910510-0x0000000189910560
		// [XID] // 0x0000000189910510-0x0000000189910560
		private void SupportGroup() {} // 0x00000001868DB8E0-0x00000001868DB990
		// [ContextMenu] // 0x000000018991B3B0-0x000000018991B400
		// [XID] // 0x000000018991B3B0-0x000000018991B400
		private void ASThread() {} // 0x00000001868DB120-0x00000001868DB1D0
		// [XID] // 0x0000000189925AC0-0x0000000189925AE0
		protected override Quaternion LimitRotation(Quaternion rotation) => default; // 0x00000001868DB1D0-0x00000001868DB460
		// [XID] // 0x000000018992CF60-0x000000018992CF80
		private Quaternion LimitSwing(Quaternion rotation) => default; // 0x00000001868DB460-0x00000001868DB780
	}
}
