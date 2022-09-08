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
	// [AddComponentMenu] // 0x0000000189BA1560-0x0000000189BA15D0
	[DisallowMultipleComponent] // 0x0000000189BA1560-0x0000000189BA15D0
	// [DocumentationSorting] // 0x0000000189BA1560-0x0000000189BA15D0
	[ExecuteInEditMode] // 0x0000000189BA1560-0x0000000189BA15D0
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase // TypeDefIndex: 6749
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018964E420-0x000000018964E460
		// [Tooltip] // 0x000000018964E420-0x000000018964E460
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000189658A50-0x0000000189658AA0
		// [Tooltip] // 0x0000000189658A50-0x0000000189658AA0
		public Transform m_Follow; // 0x80
		// [Tooltip] // 0x0000000189BCB5A0-0x0000000189BCB5D0
		public bool m_ShowDebugText; // 0x88
		// [Tooltip] // 0x0000000189BD44A0-0x0000000189BD44D0
		public bool m_EnableAllChildCameras; // 0x89
		[HideInInspector] // 0x0000000189901A10-0x0000000189901A50
		[NoSaveDuringPlay] // 0x0000000189901A10-0x0000000189901A50
		[SerializeField] // 0x0000000189901A10-0x0000000189901A50
		public CinemachineVirtualCameraBase[] m_ChildCameras; // 0x90
		// [Tooltip] // 0x00000001895EFF10-0x00000001895EFF40
		public Instruction[] m_Instructions; // 0x98
		private CameraState m_State; // 0xA8
		private float mActivationTime; // 0x178
		private int mCurrentInstruction; // 0x17C
		private CinemachineBlend mActiveBlend; // 0x180
	
		// Properties
		public override string Description { /* [XID] */ /* 0x0000000189603660-0x0000000189603680 */ get => default; } // 0x0000000186EDDE30-0x0000000186EDDF90 
		public ICinemachineCamera LiveChild { /* [XID] */ /* 0x00000001896155A0-0x00000001896155E0 */ get; /* [XID] */ /* 0x000000018960B0E0-0x000000018960B120 */ set; } // 0x0000000186EDE1D0-0x0000000186EDE230 0x0000000186EDE5F0-0x0000000186EDE660
		public override ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x000000018961FE10-0x000000018961FE30 */ get => default; } // 0x0000000186EDE0F0-0x0000000186EDE1D0 
		public override CameraState State { /* [XID] */ /* 0x0000000189613A00-0x0000000189613A20 */ get => default; } // 0x0000000186EDE2E0-0x0000000186EDE540 
		public override Transform LookAt { /* [XID] */ /* 0x00000001896367F0-0x0000000189636810 */ get => default; /* [XID] */ /* 0x000000018963DDB0-0x000000018963DDD0 */ set {} } // 0x0000000186EDE230-0x0000000186EDE2E0 0x0000000186EDE660-0x0000000186EDE710
		public override Transform Follow { /* [XID] */ /* 0x0000000189645500-0x0000000189645520 */ get => default; /* [XID] */ /* 0x0000000189632FF0-0x0000000189633010 */ set {} } // 0x0000000186EDDF90-0x0000000186EDE040 0x0000000186EDE540-0x0000000186EDE5F0
		public CinemachineVirtualCameraBase[] ChildCameras { /* [XID] */ /* 0x000000018967A0A0-0x000000018967A0C0 */ get => default; } // 0x0000000186EDDD80-0x0000000186EDDE30 
		public bool IsBlending { /* [XID] */ /* 0x0000000189624000-0x0000000189624020 */ get => default; } // 0x0000000186EDE040-0x0000000186EDE0F0 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 6750
		{
			// Fields
			// [Tooltip] // 0x00000001896AE2F0-0x00000001896AE320
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x00
			// [Tooltip] // 0x00000001896B7070-0x00000001896B70A0
			public float m_Hold; // 0x08
			[CinemachineBlendDefinitionProperty] // 0x00000001896BF910-0x00000001896BF960
			// [Tooltip] // 0x00000001896BF910-0x00000001896BF960
			public CinemachineBlendDefinition m_Blend; // 0x10
		}
	
		// Constructors
		public CinemachineBlendListCamera() {} // 0x0000000186EDDC20-0x0000000186EDDD80
	
		// Methods
		// [XID] // 0x00000001896271B0-0x00000001896271D0
		public override bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x0000000186EDC7D0-0x0000000186EDC910
		// [XID] // 0x0000000189654230-0x0000000189654250
		public override void RemovePostPipelineStageHook(OnPostPipelineStageDelegate d) {} // 0x0000000186EDCC20-0x0000000186EDCD40
		// [XID] // 0x00000001896CDAB0-0x00000001896CDAD0
		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000186EDCA70-0x0000000186EDCC20
		// [XID] // 0x0000000189663030-0x0000000189663050
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186EDD030-0x0000000186EDD7B0
		// [XID] // 0x000000018966AB60-0x000000018966AB80
		protected override void OnEnable() {} // 0x0000000186EDC910-0x0000000186EDC9D0
		// [XID] // 0x0000000189672820-0x0000000189672840
		public void OnTransformChildrenChanged() {} // 0x0000000186EDC9D0-0x0000000186EDCA70
		// [XID] // 0x0000000189689200-0x0000000189689220
		private void InvalidateListOfChildren() {} // 0x0000000186EDC6E0-0x0000000186EDC7D0
		// [XID] // 0x0000000189690D40-0x0000000189690D60
		private void UpdateListOfChildren() {} // 0x0000000186EDD7B0-0x0000000186EDD9B0
		// [XID] // 0x0000000189698750-0x0000000189698770
		public void ValidateInstructions() {} // 0x0000000186EDD9B0-0x0000000186EDDC20
		// [XID] // 0x000000018969FA50-0x000000018969FA70
		private void AdvanceCurrentInstruction() {} // 0x0000000186EDC170-0x0000000186EDC390
		// [XID] // 0x00000001896A6C80-0x00000001896A6CA0
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend, float deltaTime, CinemachineBlendDefinition def) => default; // 0x0000000186EDC390-0x0000000186EDC6E0
	}
}
