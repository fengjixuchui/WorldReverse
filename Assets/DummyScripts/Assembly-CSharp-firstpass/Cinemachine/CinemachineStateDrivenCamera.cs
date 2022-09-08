/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x000000018963C3E0-0x000000018963C460
	[DisallowMultipleComponent] // 0x000000018963C3E0-0x000000018963C460
	// [DocumentationSorting] // 0x000000018963C3E0-0x000000018963C460
	[ExecuteInEditMode] // 0x000000018963C3E0-0x000000018963C460
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase // TypeDefIndex: 6783
	{
		// Fields
		[NoSaveDuringPlay] // 0x000000018964E420-0x000000018964E460
		// [Tooltip] // 0x000000018964E420-0x000000018964E460
		public Transform m_LookAt; // 0x78
		[NoSaveDuringPlay] // 0x0000000189658A50-0x0000000189658AA0
		// [Tooltip] // 0x0000000189658A50-0x0000000189658AA0
		public Transform m_Follow; // 0x80
		[Space] // 0x0000000189662FE0-0x0000000189663030
		// [Tooltip] // 0x0000000189662FE0-0x0000000189663030
		public Animator m_AnimatedTarget; // 0x88
		// [Tooltip] // 0x000000018966F380-0x000000018966F3B0
		public int m_LayerIndex; // 0x90
		// [Tooltip] // 0x0000000189BCB5A0-0x0000000189BCB5D0
		public bool m_ShowDebugText; // 0x94
		// [Tooltip] // 0x0000000189BD44A0-0x0000000189BD44D0
		public bool m_EnableAllChildCameras; // 0x95
		[HideInInspector] // 0x00000001896875E0-0x0000000189687620
		[NoSaveDuringPlay] // 0x00000001896875E0-0x0000000189687620
		[SerializeField] // 0x00000001896875E0-0x0000000189687620
		public CinemachineVirtualCameraBase[] m_ChildCameras; // 0x98
		// [Tooltip] // 0x00000001896953F0-0x0000000189695420
		public Instruction[] m_Instructions; // 0xA0
		[CinemachineBlendDefinitionProperty] // 0x000000018969E410-0x000000018969E450
		// [Tooltip] // 0x000000018969E410-0x000000018969E450
		public CinemachineBlendDefinition m_DefaultBlend; // 0xA8
		// [Tooltip] // 0x00000001896A9DD0-0x00000001896A9E00
		public CinemachineBlenderSettings m_CustomBlends; // 0xB8
		[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
		[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
		public ParentHash[] m_ParentHash; // 0xC0
		private CameraState m_State; // 0xD0
		private float mActivationTime; // 0x1A0
		private Instruction mActiveInstruction; // 0x1A8
		private float mPendingActivationTime; // 0x1C0
		private Instruction mPendingInstruction; // 0x1C8
		private CinemachineBlend mActiveBlend; // 0x1E0
		private Dictionary<int, int> mInstructionDictionary; // 0x1E8
		private Dictionary<int, int> mStateParentLookup; // 0x1F0
		private List<AnimatorClipInfo> m_clipInfoList; // 0x1F8
	
		// Properties
		public override string Description { /* [XID] */ /* 0x00000001896C73B0-0x00000001896C73D0 */ get => default; } // 0x0000000186CCC3B0-0x0000000186CCC510 
		public ICinemachineCamera LiveChild { /* [XID] */ /* 0x00000001896D8D70-0x00000001896D8DB0 */ get; /* [XID] */ /* 0x00000001896CE9C0-0x00000001896CEA00 */ set; } // 0x0000000186CCC750-0x0000000186CCC7B0 0x0000000186CCCB70-0x0000000186CCCBE0
		public override ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x00000001896E3440-0x00000001896E3460 */ get => default; } // 0x0000000186CCC670-0x0000000186CCC750 
		public override CameraState State { /* [XID] */ /* 0x00000001896F1A30-0x00000001896F1A50 */ get => default; } // 0x0000000186CCC860-0x0000000186CCCAC0 
		public override Transform LookAt { /* [XID] */ /* 0x00000001896F9390-0x00000001896F93B0 */ get => default; /* [XID] */ /* 0x0000000189A432E0-0x0000000189A43300 */ set {} } // 0x0000000186CCC7B0-0x0000000186CCC860 0x0000000186CCCBE0-0x0000000186CCCC90
		public override Transform Follow { /* [XID] */ /* 0x0000000189708450-0x0000000189708470 */ get => default; /* [XID] */ /* 0x000000018970FED0-0x000000018970FEF0 */ set {} } // 0x0000000186CCC510-0x0000000186CCC5C0 0x0000000186CCCAC0-0x0000000186CCCB70
		public CinemachineVirtualCameraBase[] ChildCameras { /* [XID] */ /* 0x0000000189734F70-0x0000000189734F90 */ get => default; } // 0x0000000186CCC300-0x0000000186CCC3B0 
		public bool IsBlending { /* [XID] */ /* 0x000000018990CE30-0x000000018990CE50 */ get => default; } // 0x0000000186CCC5C0-0x0000000186CCC670 
	
		// Nested types
		[Serializable]
		public struct Instruction // TypeDefIndex: 6784
		{
			// Fields
			// [Tooltip] // 0x000000018977F890-0x000000018977F8C0
			public int m_FullHash; // 0x00
			// [Tooltip] // 0x0000000189788AB0-0x0000000189788AE0
			public CinemachineVirtualCameraBase m_VirtualCamera; // 0x08
			// [Tooltip] // 0x00000001897918A0-0x00000001897918D0
			public float m_ActivateAfter; // 0x10
			// [Tooltip] // 0x000000018979A630-0x000000018979A660
			public float m_MinDuration; // 0x14
		}
	
		[Serializable]
		// [DocumentationSorting] // 0x00000001897A3CF0-0x00000001897A3D10
		public struct ParentHash // TypeDefIndex: 6785
		{
			// Fields
			public int m_Hash; // 0x00
			public int m_ParentHash; // 0x04
	
			// Constructors
			public ParentHash(int h, int p) {
				m_Hash = default;
				m_ParentHash = default;
			} // 0x0000000186CD75C0-0x0000000186CD7720
		}
	
		// Constructors
		public CinemachineStateDrivenCamera() {} // 0x0000000186CCC110-0x0000000186CCC300
	
		// Methods
		// [XID] // 0x00000001896EA960-0x00000001896EA980
		public override bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x0000000186CCAC10-0x0000000186CCAD50
		// [XID] // 0x00000001896A3D90-0x00000001896A3DB0
		public override void RemovePostPipelineStageHook(OnPostPipelineStageDelegate d) {} // 0x0000000186CCB140-0x0000000186CCB260
		// [XID] // 0x000000018971EAE0-0x000000018971EB00
		public override void UpdateCameraState(Vector3 worldUp, float deltaTime) {} // 0x0000000186CCB4A0-0x0000000186CCBBA0
		// [XID] // 0x00000001897261A0-0x00000001897261C0
		protected override void OnEnable() {} // 0x0000000186CCAFE0-0x0000000186CCB0A0
		// [XID] // 0x000000018972D7B0-0x000000018972D7D0
		public void OnTransformChildrenChanged() {} // 0x0000000186CCB0A0-0x0000000186CCB140
		// [XID] // 0x0000000189AFC3A0-0x0000000189AFC3C0
		public static string CreateFakeHashName(int parentHash, string stateName) => default; // 0x0000000186CCA800-0x0000000186CCA900
		// [XID] // 0x00000001896D73A0-0x00000001896D73C0
		private void InvalidateListOfChildren() {} // 0x0000000186CCAB20-0x0000000186CCAC10
		// [XID] // 0x00000001896AB0C0-0x00000001896AB0E0
		private void UpdateListOfChildren() {} // 0x0000000186CCBBA0-0x0000000186CCBDB0
		// [XID] // 0x000000018975A220-0x000000018975A240
		public void ValidateInstructions() {} // 0x0000000186CCBDB0-0x0000000186CCC110
		// [XID] // 0x0000000189761FA0-0x0000000189761FC0
		private CinemachineVirtualCameraBase ChooseCurrentCamera(float deltaTime) => default; // 0x0000000186CC9D70-0x0000000186CCA4B0
		// [XID] // 0x00000001897693D0-0x00000001897693F0
		private int GetClipHash(int hash, List<AnimatorClipInfo> clips) => default; // 0x0000000186CCA900-0x0000000186CCAB20
		// [XID] // 0x0000000189770AC0-0x0000000189770AE0
		private AnimationCurve LookupBlendCurve(ICinemachineCamera fromKey, ICinemachineCamera toKey, out float duration, out CinemachineBlendDefinition blendDef) {
			duration = default;
			blendDef = default;
			return default;
		} // 0x0000000186CCAD50-0x0000000186CCAFE0
		// [XID] // 0x00000001896C8540-0x00000001896C8560
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend, float deltaTime, CinemachineBlendDefinition def) => default; // 0x0000000186CCA4B0-0x0000000186CCA800
	}
}
