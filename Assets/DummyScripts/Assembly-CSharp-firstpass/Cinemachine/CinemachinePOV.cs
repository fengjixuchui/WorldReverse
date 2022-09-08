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

namespace Cinemachine
{
	// [AddComponentMenu] // 0x0000000189A329F0-0x0000000189A32A90
	// [DocumentationSorting] // 0x0000000189A329F0-0x0000000189A32A90
	// [RequireComponent] // 0x0000000189A329F0-0x0000000189A32A90
	[SaveDuringPlay] // 0x0000000189A329F0-0x0000000189A32A90
	public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 6811
	{
		// Fields
		// [Tooltip] // 0x0000000189A47B30-0x0000000189A47B60
		public AxisState m_VerticalAxis; // 0x20
		// [Tooltip] // 0x0000000189A50B80-0x0000000189A50BB0
		public AxisState m_HorizontalAxis; // 0x50
	
		// Properties
		public override bool IsValid { /* [XID] */ /* 0x000000018982DCA0-0x000000018982DCC0 */ get => default; } // 0x0000000186CC5210-0x0000000186CC52C0 
		public override CinemachineCore.Stage Stage { /* [XID] */ /* 0x0000000189A611F0-0x0000000189A61210 */ get => default; } // 0x0000000186CC52C0-0x0000000186CC5360 
	
		// Constructors
		public CinemachinePOV() {} // 0x0000000186CC50B0-0x0000000186CC5210
	
		// Methods
		// [XID] // 0x0000000189A69180-0x0000000189A691A0
		private void OnValidate() {} // 0x0000000186CC5000-0x0000000186CC50B0
		// [XID] // 0x0000000189A703F0-0x0000000189A70410
		private void OnEnable() {} // 0x0000000186CC4F20-0x0000000186CC5000
		// [XID] // 0x0000000189603340-0x0000000189603360
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186CC4C70-0x0000000186CC4F20
	}
}
