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
	// [AddComponentMenu] // 0x000000018977B110-0x000000018977B1C0
	// [DocumentationSorting] // 0x000000018977B110-0x000000018977B1C0
	[ExecuteInEditMode] // 0x000000018977B110-0x000000018977B1C0
	// [RequireComponent] // 0x000000018977B110-0x000000018977B1C0
	[SaveDuringPlay] // 0x000000018977B110-0x000000018977B1C0
	public class CinemachineGroupComposer : CinemachineComposer // TypeDefIndex: 6799
	{
		// Fields
		[Space] // 0x0000000189792FB0-0x0000000189793000
		// [Tooltip] // 0x0000000189792FB0-0x0000000189793000
		public float m_GroupFramingSize; // 0xA8
		// [Tooltip] // 0x000000018979E2F0-0x000000018979E320
		public FramingMode m_FramingMode; // 0xAC
		// [Range] // 0x00000001897A5760-0x00000001897A57C0
		// [Tooltip] // 0x00000001897A5760-0x00000001897A57C0
		public float m_FrameDamping; // 0xB0
		// [Tooltip] // 0x00000001897B1450-0x00000001897B1480
		public AdjustmentMode m_AdjustmentMode; // 0xB4
		// [Tooltip] // 0x0000000189667B90-0x0000000189667BC0
		public float m_MaxDollyIn; // 0xB8
		// [Tooltip] // 0x0000000189670F70-0x0000000189670FA0
		public float m_MaxDollyOut; // 0xBC
		// [Tooltip] // 0x00000001897C8B60-0x00000001897C8B90
		public float m_MinimumDistance; // 0xC0
		// [Tooltip] // 0x0000000189682E10-0x0000000189682E40
		public float m_MaximumDistance; // 0xC4
		// [Range] // 0x00000001897D7A60-0x00000001897D7AB0
		// [Tooltip] // 0x00000001897D7A60-0x00000001897D7AB0
		public float m_MinimumFOV; // 0xC8
		// [Range] // 0x00000001897E2120-0x00000001897E2170
		// [Tooltip] // 0x00000001897E2120-0x00000001897E2170
		public float m_MaximumFOV; // 0xCC
		// [Tooltip] // 0x00000001897ECC50-0x00000001897ECC80
		public float m_MinimumOrthoSize; // 0xD0
		// [Tooltip] // 0x00000001897F4520-0x00000001897F4550
		public float m_MaximumOrthoSize; // 0xD4
		private float m_prevTargetHeight; // 0xD8
	
		// Properties
		public CinemachineTargetGroup TargetGroup { /* [XID] */ /* 0x0000000189818060-0x0000000189818080 */ get => default; } // 0x0000000186CC01B0-0x0000000186CC02B0 
		public Bounds m_LastBounds { /* [XID] */ /* 0x00000001898270E0-0x0000000189827120 */ get; /* [XID] */ /* 0x0000000189831450-0x0000000189831490 */ private set; } // 0x0000000186CC02B0-0x0000000186CC0330 0x0000000186CC03C0-0x0000000186CC0440
		public Matrix4x4 m_lastBoundsMatrix { /* [XID] */ /* 0x000000018983B990-0x000000018983B9D0 */ get; /* [XID] */ /* 0x0000000189846180-0x00000001898461C0 */ private set; } // 0x0000000186CC0330-0x0000000186CC03C0 0x0000000186CC0440-0x0000000186CC04D0
	
		// Nested types
		// [DocumentationSorting] // 0x0000000189857810-0x0000000189857830
		public enum FramingMode // TypeDefIndex: 6800
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2
		}
	
		public enum AdjustmentMode // TypeDefIndex: 6801
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineGroupComposer() {} // 0x0000000186CC00D0-0x0000000186CC01B0
	
		// Methods
		// [XID] // 0x00000001898F87E0-0x00000001898F8800
		private void OnValidate() {} // 0x0000000186CBFE50-0x0000000186CC0040
		// [XID] // 0x0000000189907700-0x0000000189907720
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186CBF1B0-0x0000000186CBFE50
		// [XID] // 0x0000000189850540-0x0000000189850560
		private float GetTargetHeight(Bounds b) => default; // 0x0000000186CBED30-0x0000000186CBF1B0
	}
}
