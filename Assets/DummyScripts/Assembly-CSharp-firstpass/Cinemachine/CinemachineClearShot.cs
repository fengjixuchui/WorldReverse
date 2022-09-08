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
	// [AddComponentMenu] // 0x0000000189A91800-0x0000000189A91880
	[DisallowMultipleComponent] // 0x0000000189A91800-0x0000000189A91880
	// [DocumentationSorting] // 0x0000000189A91800-0x0000000189A91880
	[ExecuteInEditMode] // 0x0000000189A91800-0x0000000189A91880
	public class CinemachineClearShot : CinemachineVirtualCameraBase // TypeDefIndex: 6760
	{
		// Fields
		[NoSaveDuringPlay] // 0x0000000189AA3440-0x0000000189AA3490
		// [Tooltip] // 0x0000000189AA3440-0x0000000189AA3490
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000189AAF570-0x0000000189AAF5C0
		// [Tooltip] // 0x0000000189AAF570-0x0000000189AAF5C0
		public Transform m_Follow; // 0x80
		[NoSaveDuringPlay] // 0x0000000189ABB910-0x0000000189ABB950
		// [Tooltip] // 0x0000000189ABB910-0x0000000189ABB950
		public bool m_ShowDebugText; // 0x88
		[HideInInspector] // 0x0000000189AC62F0-0x0000000189AC6330
		[NoSaveDuringPlay] // 0x0000000189AC62F0-0x0000000189AC6330
		[SerializeField] // 0x0000000189AC62F0-0x0000000189AC6330
		public CinemachineVirtualCameraBase[] m_ChildCameras; // 0x90
		// [Tooltip] // 0x0000000189AD3950-0x0000000189AD3980
		public float m_ActivateAfter; // 0x98
		// [Tooltip] // 0x0000000189ADD170-0x0000000189ADD1A0
		public float m_MinDuration; // 0x9C
		// [Tooltip] // 0x0000000189AE6100-0x0000000189AE6130
		public bool m_RandomizeChoice; // 0xA0
		[CinemachineBlendDefinitionProperty] // 0x0000000189AEF450-0x0000000189AEF4A0
		// [Tooltip] // 0x0000000189AEF450-0x0000000189AEF4A0
		public CinemachineBlendDefinition m_DefaultBlend; // 0xA8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public CinemachineBlenderSettings m_CustomBlends; // 0xB8
		private CameraState m_State; // 0xC8
		private float mActivationTime; // 0x198
		private float mPendingActivationTime; // 0x19C
		private ICinemachineCamera mPendingCamera; // 0x1A0
		private CinemachineBlend mActiveBlend; // 0x1A8
		private bool mRandomizeNow; // 0x1B0
		private CinemachineVirtualCameraBase[] m_RandomizedChilden; // 0x1B8
	
		// Properties
		public override string Description { /* [XID] */ /* 0x0000000189B142F0-0x0000000189B14310 */ get => default; } // 0x0000000186EE6F80-0x0000000186EE70E0 
		public ICinemachineCamera LiveChild { /* [XID] */ /* 0x0000000189B261A0-0x0000000189B261E0 */ get; /* [XID] */ /* 0x0000000189B1BB40-0x0000000189B1BB80 */ set; } // 0x0000000186EE7320-0x0000000186EE7380 0x0000000186EE7740-0x0000000186EE77B0
		public override CameraState State { /* [XID] */ /* 0x0000000189B30310-0x0000000189B30330 */ get => default; } // 0x0000000186EE7430-0x0000000186EE7690 
		public override ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x0000000189B37AC0-0x0000000189B37AE0 */ get => default; } // 0x0000000186EE7240-0x0000000186EE7320 
		public override Transform LookAt { /* [XID] */ /* 0x0000000189B46E00-0x0000000189B46E20 */ get => default; /* [XID] */ /* 0x0000000189AC1470-0x0000000189AC1490 */ set {} } // 0x0000000186EE7380-0x0000000186EE7430 0x0000000186EE77B0-0x0000000186EE7860
		public override Transform Follow { /* [XID] */ /* 0x0000000189B55C00-0x0000000189B55C20 */ get => default; /* [XID] */ /* 0x0000000189B5D640-0x0000000189B5D660 */ set {} } // 0x0000000186EE70E0-0x0000000186EE7190 0x0000000186EE7690-0x0000000186EE7740
		public bool IsBlending { /* [XID] */ /* 0x0000000189B829B0-0x0000000189B829D0 */ get => default; } // 0x0000000186EE7190-0x0000000186EE7240 
		public CinemachineVirtualCameraBase[] ChildCameras { /* [XID] */ /* 0x0000000189B8A000-0x0000000189B8A020 */ get => default; } // 0x0000000186EE6ED0-0x0000000186EE6F80 
	
		// Nested types
		private struct Pair // TypeDefIndex: 6761
		{
			// Fields
			public int a; // 0x00
			public float b; // 0x04
		}
	
		// Constructors
		public CinemachineClearShot() {} // 0x0000000186EE6CC0-0x0000000186EE6ED0
	
		// Methods
		// [XID] // 0x0000000189B3F440-0x0000000189B3F460
		public override bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x0000000186EE5640-0x0000000186EE5780
		// [XID] // 0x000000018990BF40-0x000000018990BF60
		public override void RemovePostPipelineStageHook(OnPostPipelineStageDelegate d) {} // 0x0000000186EE5FB0-0x0000000186EE60D0
		// [XID] // 0x0000000189B6C300-0x0000000189B6C320
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186EE64E0-0x0000000186EE6A90
		// [XID] // 0x0000000189B739C0-0x0000000189B739E0
		protected override void OnEnable() {} // 0x0000000186EE5A10-0x0000000186EE5AD0
		// [XID] // 0x00000001899551E0-0x0000000189955200
		public void OnTransformChildrenChanged() {} // 0x0000000186EE5AD0-0x0000000186EE5B70
		// [XID] // 0x0000000189B91630-0x0000000189B91650
		private void InvalidateListOfChildren() {} // 0x0000000186EE5550-0x0000000186EE5640
		// [XID] // 0x0000000189B98970-0x0000000189B98990
		public void ResetRandomization() {} // 0x0000000186EE60D0-0x0000000186EE6180
		// [XID] // 0x0000000189B9FDC0-0x0000000189B9FDE0
		private void UpdateListOfChildren() {} // 0x0000000186EE6A90-0x0000000186EE6CC0
		// [XID] // 0x0000000189A1DCC0-0x0000000189A1DCE0
		private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp, float deltaTime) => default; // 0x0000000186EE4890-0x0000000186EE5200
		// [XID] // 0x0000000189BAE8E0-0x0000000189BAE900
		private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src) => default; // 0x0000000186EE5CF0-0x0000000186EE5FB0
		// [XID] // 0x0000000189BB6020-0x0000000189BB6040
		private AnimationCurve LookupBlendCurve(ICinemachineCamera fromKey, ICinemachineCamera toKey, out float duration, out CinemachineBlendDefinition blendDef) {
			duration = default;
			blendDef = default;
			return default;
		} // 0x0000000186EE5780-0x0000000186EE5A10
		// [XID] // 0x00000001898FCDC0-0x00000001898FCDE0
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend, float deltaTime, CinemachineBlendDefinition def) => default; // 0x0000000186EE5200-0x0000000186EE5550
		// [XID] // 0x0000000189BC53B0-0x0000000189BC53D0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000186EE5B70-0x0000000186EE5CF0
	}
}
