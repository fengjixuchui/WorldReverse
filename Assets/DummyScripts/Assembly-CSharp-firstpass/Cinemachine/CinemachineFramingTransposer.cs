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
using UnityEngine.Serialization;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x0000000189B606F0-0x0000000189B607A0
	// [DocumentationSorting] // 0x0000000189B606F0-0x0000000189B607A0
	[ExecuteInEditMode] // 0x0000000189B606F0-0x0000000189B607A0
	// [RequireComponent] // 0x0000000189B606F0-0x0000000189B607A0
	[SaveDuringPlay] // 0x0000000189B606F0-0x0000000189B607A0
	public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 6796
	{
		// Fields
		[HideInInspector] // 0x0000000189B780F0-0x0000000189B78120
		[NoSaveDuringPlay] // 0x0000000189B780F0-0x0000000189B78120
		public Action OnGUICallback; // 0x20
		// [Range] // 0x0000000189B82950-0x0000000189B829B0
		// [Tooltip] // 0x0000000189B82950-0x0000000189B829B0
		public float m_LookaheadTime; // 0x28
		// [Range] // 0x0000000189B8C9B0-0x0000000189B8CA10
		// [Tooltip] // 0x0000000189B8C9B0-0x0000000189B8CA10
		public float m_LookaheadSmoothing; // 0x2C
		// [Range] // 0x0000000189BC6850-0x0000000189BC68A0
		// [Tooltip] // 0x0000000189BC6850-0x0000000189BC68A0
		public float m_XDamping; // 0x30
		// [Range] // 0x0000000189BD12F0-0x0000000189BD1340
		// [Tooltip] // 0x0000000189BD12F0-0x0000000189BD1340
		public float m_YDamping; // 0x34
		// [Range] // 0x0000000189BAE880-0x0000000189BAE8E0
		// [Tooltip] // 0x0000000189BAE880-0x0000000189BAE8E0
		public float m_ZDamping; // 0x38
		// [Range] // 0x0000000189BBA5C0-0x0000000189BBA630
		[Space] // 0x0000000189BBA5C0-0x0000000189BBA630
		// [Tooltip] // 0x0000000189BBA5C0-0x0000000189BBA630
		public float m_ScreenX; // 0x3C
		// [Range] // 0x0000000189BC9B60-0x0000000189BC9BB0
		// [Tooltip] // 0x0000000189BC9B60-0x0000000189BC9BB0
		public float m_ScreenY; // 0x40
		// [Tooltip] // 0x0000000189BD5860-0x0000000189BD5890
		public float m_CameraDistance; // 0x44
		// [Range] // 0x0000000189BDECE0-0x0000000189BDED50
		[Space] // 0x0000000189BDECE0-0x0000000189BDED50
		// [Tooltip] // 0x0000000189BDECE0-0x0000000189BDED50
		public float m_DeadZoneWidth; // 0x48
		// [Range] // 0x00000001895F2C10-0x00000001895F2C60
		// [Tooltip] // 0x00000001895F2C10-0x00000001895F2C60
		public float m_DeadZoneHeight; // 0x4C
		// [FormerlySerializedAs] // 0x00000001895FEB90-0x00000001895FEBF0
		// [Tooltip] // 0x00000001895FEB90-0x00000001895FEBF0
		public float m_DeadZoneDepth; // 0x50
		[Space] // 0x000000018960C5A0-0x000000018960C5E0
		// [Tooltip] // 0x000000018960C5A0-0x000000018960C5E0
		public bool m_UnlimitedSoftZone; // 0x54
		// [Range] // 0x0000000189618390-0x00000001896183E0
		// [Tooltip] // 0x0000000189618390-0x00000001896183E0
		public float m_SoftZoneWidth; // 0x58
		// [Range] // 0x0000000189624260-0x00000001896242B0
		// [Tooltip] // 0x0000000189624260-0x00000001896242B0
		public float m_SoftZoneHeight; // 0x5C
		// [Range] // 0x0000000189630450-0x00000001896304B0
		// [Tooltip] // 0x0000000189630450-0x00000001896304B0
		public float m_BiasX; // 0x60
		// [Range] // 0x000000018963AD70-0x000000018963ADD0
		// [Tooltip] // 0x000000018963AD70-0x000000018963ADD0
		public float m_BiasY; // 0x64
		// [FormerlySerializedAs] // 0x0000000189645490-0x0000000189645500
		[Space] // 0x0000000189645490-0x0000000189645500
		// [Tooltip] // 0x0000000189645490-0x0000000189645500
		public FramingMode m_GroupFramingMode; // 0x68
		// [Tooltip] // 0x00000001897B1450-0x00000001897B1480
		public AdjustmentMode m_AdjustmentMode; // 0x6C
		// [Tooltip] // 0x000000018965EA10-0x000000018965EA40
		public float m_GroupFramingSize; // 0x70
		// [Tooltip] // 0x0000000189667B90-0x0000000189667BC0
		public float m_MaxDollyIn; // 0x74
		// [Tooltip] // 0x0000000189670F70-0x0000000189670FA0
		public float m_MaxDollyOut; // 0x78
		// [Tooltip] // 0x00000001897C8B60-0x00000001897C8B90
		public float m_MinimumDistance; // 0x7C
		// [Tooltip] // 0x0000000189682E10-0x0000000189682E40
		public float m_MaximumDistance; // 0x80
		// [Range] // 0x000000018968C100-0x000000018968C160
		// [Tooltip] // 0x000000018968C100-0x000000018968C160
		public float m_MinimumFOV; // 0x84
		// [Range] // 0x00000001896986F0-0x0000000189698750
		// [Tooltip] // 0x00000001896986F0-0x0000000189698750
		public float m_MaximumFOV; // 0x88
		// [Tooltip] // 0x00000001897ECC50-0x00000001897ECC80
		public float m_MinimumOrthoSize; // 0x8C
		// [Tooltip] // 0x00000001897F4520-0x00000001897F4550
		public float m_MaximumOrthoSize; // 0x90
		private const float kMinimumCameraDistance = 0.01f; // Metadata: 0x00ADDE55
		private Vector3 m_PreviousCameraPosition; // 0x94
		private PositionPredictor m_Predictor; // 0xA0
		private float m_prevTargetHeight; // 0xB4
	
		// Properties
		public Rect SoftGuideRect { /* [XID] */ /* 0x00000001896D4530-0x00000001896D4550 */ get => default; /* [XID] */ /* 0x00000001896DBD60-0x00000001896DBD80 */ set {} } // 0x0000000186CB88D0-0x0000000186CB89F0 0x0000000186CB9010-0x0000000186CB91B0
		public Rect HardGuideRect { /* [XID] */ /* 0x00000001898880C0-0x00000001898880E0 */ get => default; /* [XID] */ /* 0x000000018988F660-0x000000018988F680 */ set {} } // 0x0000000186CB85D0-0x0000000186CB8790 0x0000000186CB8D20-0x0000000186CB9010
		public override bool IsValid { /* [XID] */ /* 0x000000018989DFF0-0x000000018989E010 */ get => default; } // 0x0000000186CB8790-0x0000000186CB88D0 
		public override CinemachineCore.Stage Stage { /* [XID] */ /* 0x00000001898A5A70-0x00000001898A5A90 */ get => default; } // 0x0000000186CB89F0-0x0000000186CB8A90 
		public Vector3 TrackedPoint { /* [XID] */ /* 0x0000000189708410-0x0000000189708450 */ get; /* [XID] */ /* 0x0000000189712C50-0x0000000189712C90 */ private set; } // 0x0000000186CB8B90-0x0000000186CB8C10 0x0000000186CB91B0-0x0000000186CB9230
		public Bounds m_LastBounds { /* [XID] */ /* 0x00000001897336E0-0x0000000189733720 */ get; /* [XID] */ /* 0x000000018973E620-0x000000018973E660 */ private set; } // 0x0000000186CB8C10-0x0000000186CB8C90 0x0000000186CB9230-0x0000000186CB92B0
		public Matrix4x4 m_lastBoundsMatrix { /* [XID] */ /* 0x0000000189748B40-0x0000000189748B80 */ get; /* [XID] */ /* 0x0000000189752F90-0x0000000189752FD0 */ private set; } // 0x0000000186CB8C90-0x0000000186CB8D20 0x0000000186CB92B0-0x0000000186CB9340
		public CinemachineTargetGroup TargetGroup { /* [XID] */ /* 0x000000018975D420-0x000000018975D440 */ get => default; } // 0x0000000186CB8A90-0x0000000186CB8B90 
	
		// Nested types
		// [DocumentationSorting] // 0x0000000189857810-0x0000000189857830
		public enum FramingMode // TypeDefIndex: 6797
		{
			Horizontal = 0,
			Vertical = 1,
			HorizontalAndVertical = 2,
			None = 3
		}
	
		public enum AdjustmentMode // TypeDefIndex: 6798
		{
			ZoomOnly = 0,
			DollyOnly = 1,
			DollyThenZoom = 2
		}
	
		// Constructors
		public CinemachineFramingTransposer() {} // 0x0000000186CB8440-0x0000000186CB85D0
	
		// Methods
		// [XID] // 0x0000000189896BC0-0x0000000189896BE0
		private void OnValidate() {} // 0x0000000186CB7E10-0x0000000186CB8020
		// [XID] // 0x000000018971D430-0x000000018971D450
		public override void MutateCameraState(ref CameraState curState, float deltaTime) {} // 0x0000000186CB7020-0x0000000186CB7E10
		// [XID] // 0x00000001898E1C60-0x00000001898E1C80
		private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) => default; // 0x0000000186CB8250-0x0000000186CB8440
		// [XID] // 0x000000018972C010-0x000000018972C030
		private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) => default; // 0x0000000186CB8020-0x0000000186CB8250
		// [XID] // 0x0000000189764A70-0x0000000189764A90
		private float AdjustCameraDepthAndLensForGroupFraming(CinemachineTargetGroup group, float targetZ, ref CameraState curState, float deltaTime) => default; // 0x0000000186CB63A0-0x0000000186CB6C40
		// [XID] // 0x00000001898D9F90-0x00000001898D9FB0
		private float GetTargetHeight(Bounds b) => default; // 0x0000000186CB6C40-0x0000000186CB7020
	}
}
