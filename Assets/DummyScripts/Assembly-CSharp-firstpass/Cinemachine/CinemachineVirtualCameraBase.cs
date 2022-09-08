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
	[SaveDuringPlay] // 0x00000001895E8690-0x00000001895E86A0
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera // TypeDefIndex: 6847
	{
		// Fields
		[HideInInspector] // 0x0000000189B780F0-0x0000000189B78120
		[NoSaveDuringPlay] // 0x0000000189B780F0-0x0000000189B78120
		public Action CinemachineGUIDebuggerCallback; // 0x18
		[HideInInspector] // 0x00000001895FA4E0-0x00000001895FA520
		[NoSaveDuringPlay] // 0x00000001895FA4E0-0x00000001895FA520
		[SerializeField] // 0x00000001895FA4E0-0x00000001895FA520
		public string[] m_ExcludedPropertiesInInspector; // 0x20
		[HideInInspector] // 0x0000000189607A40-0x0000000189607A80
		[NoSaveDuringPlay] // 0x0000000189607A40-0x0000000189607A80
		[SerializeField] // 0x0000000189607A40-0x0000000189607A80
		public CinemachineCore.Stage[] m_LockStageInInspector; // 0x28
		private int m_ValidatingStreamVersion; // 0x30
		private bool m_OnValidateCalled; // 0x34
		[HideInInspector] // 0x0000000189901A10-0x0000000189901A50
		[NoSaveDuringPlay] // 0x0000000189901A10-0x0000000189901A50
		[SerializeField] // 0x0000000189901A10-0x0000000189901A50
		private int m_StreamingVersion; // 0x38
		[NoSaveDuringPlay] // 0x0000000189622B40-0x0000000189622B90
		// [Tooltip] // 0x0000000189622B40-0x0000000189622B90
		public int m_Priority; // 0x3C
		protected OnPostPipelineStageDelegate OnPostPipelineStage; // 0x40
		private bool m_previousStateIsValid; // 0x48
		private Transform m_previousLookAtTarget; // 0x50
		private Transform m_previousFollowTarget; // 0x58
		private bool mSlaveStatusUpdated; // 0x60
		private CinemachineVirtualCameraBase m_parentVcam; // 0x68
		private int m_QueuePriority; // 0x70
	
		// Properties
		public int ValidatingStreamVersion { /* [XID] */ /* 0x00000001897AFC90-0x00000001897AFCB0 */ get; /* [XID] */ /* 0x00000001896367A0-0x00000001896367C0 */ private set; } // 0x0000000186699CA0-0x0000000186699D80 0x0000000186699FC0-0x000000018669A070
		public string Name { /* [XID] */ /* 0x0000000189654210-0x0000000189654230 */ get; } // 0x0000000186699900-0x00000001866999B0 
		public virtual string Description { /* [XID] */ /* 0x000000018965BCB0-0x000000018965BCD0 */ get; } // 0x00000001866997B0-0x0000000186699860 
		public int Priority { /* [XID] */ /* 0x0000000189662FC0-0x0000000189662FE0 */ get; /* [XID] */ /* 0x00000001899ACE30-0x00000001899ACE50 */ set; } // 0x0000000186699C00-0x0000000186699CA0 0x0000000186699F10-0x0000000186699FC0
		public GameObject VirtualCameraGameObject { /* [XID] */ /* 0x0000000189672800-0x0000000189672820 */ get; } // 0x0000000186699D80-0x0000000186699E60 
		public abstract CameraState State { get; }
		public virtual ICinemachineCamera LiveChildOrSelf { /* [XID] */ /* 0x000000018967A080-0x000000018967A0A0 */ get; } // 0x0000000186699860-0x0000000186699900 
		public ICinemachineCamera ParentCamera { /* [XID] */ /* 0x00000001898B91C0-0x00000001898B91E0 */ get; } // 0x00000001866999B0-0x0000000186699A70 
		public abstract Transform LookAt { get; set; }
		public abstract Transform Follow { get; set; }
		public bool PreviousStateIsValid { /* [XID] */ /* 0x0000000189690D20-0x0000000189690D40 */ get; /* [XID] */ /* 0x00000001896986D0-0x00000001896986F0 */ set; } // 0x0000000186699A70-0x0000000186699C00 0x0000000186699E60-0x0000000186699F10
	
		// Nested types
		public delegate void OnPostPipelineStageDelegate(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime); // TypeDefIndex: 6848; 0x00000001866A6900-0x00000001866A6C50
	
		// Constructors
		protected CinemachineVirtualCameraBase() {} // 0x0000000186699690-0x00000001866997B0
	
		// Methods
		// [XID] // 0x000000018998E4F0-0x000000018998E510
		public virtual void AddPostPipelineStageHook(OnPostPipelineStageDelegate d) {} // 0x0000000186698410-0x0000000186698530
		// [XID] // 0x0000000189645470-0x0000000189645490
		public virtual void RemovePostPipelineStageHook(OnPostPipelineStageDelegate d) {} // 0x0000000186698F00-0x0000000186698FE0
		// [XID] // 0x0000000189798C70-0x0000000189798C90
		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime) {} // 0x0000000186698530-0x0000000186698710
		// [XID] // 0x00000001896891E0-0x0000000189689200
		public virtual bool IsLiveChild(ICinemachineCamera vcam) => default; // 0x0000000186698710-0x00000001866987C0
		public abstract void UpdateCameraState(Vector3 worldUp, float deltaTime);
		// [XID] // 0x0000000189B26C00-0x0000000189B26C20
		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) {} // 0x0000000186698D00-0x0000000186698E20
		// [XID] // 0x00000001896A6C30-0x00000001896A6C50
		protected virtual void Start() {} // 0x0000000186699220-0x00000001866992C0
		// [XID] // 0x00000001896AE2D0-0x00000001896AE2F0
		protected virtual void OnDestroy() {} // 0x0000000186698860-0x0000000186698940
		// [XID] // 0x0000000189A86AA0-0x0000000189A86AC0
		protected virtual void OnValidate() {} // 0x0000000186698E20-0x0000000186698F00
		// [XID] // 0x00000001896BCCB0-0x00000001896BCCD0
		protected virtual void OnEnable() {} // 0x00000001866989E0-0x0000000186698C50
		// [XID] // 0x00000001896C41F0-0x00000001896C4210
		protected virtual void OnDisable() {} // 0x0000000186698940-0x00000001866989E0
		// [XID] // 0x00000001896CB680-0x00000001896CB6A0
		protected virtual void Update() {} // 0x00000001866995E0-0x0000000186699690
		// [XID] // 0x00000001896D2C30-0x00000001896D2C50
		protected virtual void OnTransformParentChanged() {} // 0x0000000186698C50-0x0000000186698D00
		// [XID] // 0x000000018961CB60-0x000000018961CB80
		private void UpdateSlaveStatus() {} // 0x00000001866992C0-0x00000001866993F0
		// [XID] // 0x00000001896E1D90-0x00000001896E1DB0
		protected Transform ResolveLookAt(Transform localLookAt) => default; // 0x0000000186699100-0x0000000186699220
		// [XID] // 0x00000001898C0760-0x00000001898C0780
		protected Transform ResolveFollow(Transform localFollow) => default; // 0x0000000186698FE0-0x0000000186699100
		// [XID] // 0x00000001896F0480-0x00000001896F04A0
		private void UpdateVcamPoolStatus() {} // 0x00000001866993F0-0x00000001866995E0
		// [XID] // 0x00000001896F7DD0-0x00000001896F7DF0
		public void MoveToTopOfPrioritySubqueue() {} // 0x00000001866987C0-0x0000000186698860
	}
}
