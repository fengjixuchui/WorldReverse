/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cinemachine.Utility;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x0000000189A255F0-0x0000000189A256A0
	// [DocumentationSorting] // 0x0000000189A255F0-0x0000000189A256A0
	[ExecuteInEditMode] // 0x0000000189A255F0-0x0000000189A256A0
	// [RequireComponent] // 0x0000000189A255F0-0x0000000189A256A0
	[SaveDuringPlay] // 0x0000000189A255F0-0x0000000189A256A0
	public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 6795
	{
		// Fields
		[HideInInspector] // 0x00000001899121B0-0x00000001899121E0
		[NoSaveDuringPlay] // 0x00000001899121B0-0x00000001899121E0
		public Action OnGUICallback; // 0x20
		// [Tooltip] // 0x0000000189A47B60-0x0000000189A47B90
		public Vector3 m_TrackedObjectOffset; // 0x28
		// [Range] // 0x0000000189A50BB0-0x0000000189A50C00
		// [Tooltip] // 0x0000000189A50BB0-0x0000000189A50C00
		public float m_LookaheadTime; // 0x34
		// [Range] // 0x0000000189A5CC20-0x0000000189A5CC70
		// [Tooltip] // 0x0000000189A5CC20-0x0000000189A5CC70
		public float m_LookaheadSmoothing; // 0x38
		// [Range] // 0x0000000189A691A0-0x0000000189A69210
		[Space] // 0x0000000189A691A0-0x0000000189A69210
		// [Tooltip] // 0x0000000189A691A0-0x0000000189A69210
		public float m_HorizontalDamping; // 0x3C
		// [Range] // 0x0000000189A77D00-0x0000000189A77D60
		// [Tooltip] // 0x0000000189A77D00-0x0000000189A77D60
		public float m_VerticalDamping; // 0x40
		// [Range] // 0x0000000189A83FF0-0x0000000189A84060
		[Space] // 0x0000000189A83FF0-0x0000000189A84060
		// [Tooltip] // 0x0000000189A83FF0-0x0000000189A84060
		public float m_ScreenX; // 0x44
		// [Range] // 0x0000000189A92EF0-0x0000000189A92F50
		// [Tooltip] // 0x0000000189A92EF0-0x0000000189A92F50
		public float m_ScreenY; // 0x48
		// [Range] // 0x0000000189A9EBF0-0x0000000189A9EC40
		// [Tooltip] // 0x0000000189A9EBF0-0x0000000189A9EC40
		public float m_DeadZoneWidth; // 0x4C
		// [Range] // 0x0000000189AAA9F0-0x0000000189AAAA50
		// [Tooltip] // 0x0000000189AAA9F0-0x0000000189AAAA50
		public float m_DeadZoneHeight; // 0x50
		// [Range] // 0x0000000189AB6D80-0x0000000189AB6DD0
		// [Tooltip] // 0x0000000189AB6D80-0x0000000189AB6DD0
		public float m_SoftZoneWidth; // 0x54
		// [Range] // 0x0000000189AC30D0-0x0000000189AC3120
		// [Tooltip] // 0x0000000189AC30D0-0x0000000189AC3120
		public float m_SoftZoneHeight; // 0x58
		// [Range] // 0x0000000189ACEFF0-0x0000000189ACF040
		// [Tooltip] // 0x0000000189ACEFF0-0x0000000189ACF040
		public float m_BiasX; // 0x5C
		// [Range] // 0x0000000189ADB500-0x0000000189ADB550
		// [Tooltip] // 0x0000000189ADB500-0x0000000189ADB550
		public float m_BiasY; // 0x60
		private Vector3 m_CameraPosPrevFrame; // 0x70
		private Vector3 m_LookAtPrevFrame; // 0x7C
		private Vector2 m_ScreenOffsetPrevFrame; // 0x88
		private Quaternion m_CameraOrientationPrevFrame; // 0x90
		private PositionPredictor m_Predictor; // 0xA0
	
		// Properties
		public override bool IsValid { /* [XID] */ /* 0x00000001896EBE70-0x00000001896EBE90 */ get => default; } // 0x0000000186EEE730-0x0000000186EEE820 
		public override CinemachineCore.Stage Stage { /* [XID] */ /* 0x0000000189AF9AA0-0x0000000189AF9AC0 */ get => default; } // 0x0000000186EEE940-0x0000000186EEE9E0 
		public Vector3 TrackedPoint { /* [XID] */ /* 0x0000000189B00EC0-0x0000000189B00F00 */ get; /* [XID] */ /* 0x0000000189B0B5F0-0x0000000189B0B630 */ private set; } // 0x0000000186EEE9E0-0x0000000186EEEA50 0x0000000186EEEEE0-0x0000000186EEEF50
		public Rect SoftGuideRect { /* [XID] */ /* 0x0000000189B2BD40-0x0000000189B2BD60 */ get => default; /* [XID] */ /* 0x000000018986AAF0-0x000000018986AB10 */ set {} } // 0x0000000186EEE820-0x0000000186EEE940 0x0000000186EEED40-0x0000000186EEEEE0
		public Rect HardGuideRect { /* [XID] */ /* 0x0000000189B3AD50-0x0000000189B3AD70 */ get => default; /* [XID] */ /* 0x0000000189871E90-0x0000000189871EB0 */ set {} } // 0x0000000186EEE570-0x0000000186EEE730 0x0000000186EEEA50-0x0000000186EEED40
	
		// Constructors
		public CinemachineComposer() {} // 0x0000000186EEE380-0x0000000186EEE570
	
		// Methods
		// [XID] // 0x0000000189B15880-0x0000000189B158A0
		protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt) => default; // 0x0000000186EEC540-0x0000000186EEC860
		// [XID] // 0x00000001898CF700-0x00000001898CF720
		public override void PrePipelineMutateCameraState(ref CameraState curState) {} // 0x0000000186EED5A0-0x0000000186EED750
		// [XID] // 0x0000000189828780-0x00000001898287A0
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186EEC860-0x0000000186EED5A0
		// [XID] // 0x0000000189B49F20-0x0000000189B49F40
		private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect) => default; // 0x0000000186EEDBC0-0x0000000186EEE300
		// [XID] // 0x0000000189B51740-0x0000000189B51760
		private bool RotateToScreenBounds(ref CameraState state, Rect screenRect, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) => default; // 0x0000000186EED750-0x0000000186EEDBC0
		// [XID] // 0x0000000189854550-0x0000000189854570
		private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) => default; // 0x0000000186EEC250-0x0000000186EEC540
	}
}
