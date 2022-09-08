/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine
{
	// [AddComponentMenu] // 0x00000001896CB6A0-0x00000001896CB720
	[DisallowMultipleComponent] // 0x00000001896CB6A0-0x00000001896CB720
	// [DocumentationSorting] // 0x00000001896CB6A0-0x00000001896CB720
	[ExecuteInEditMode] // 0x00000001896CB6A0-0x00000001896CB720
	[SaveDuringPlay] // 0x00000001896CB6A0-0x00000001896CB720
	public class CinemachineBrain : MonoBehaviour // TypeDefIndex: 6751
	{
		// Fields
		// [Tooltip] // 0x00000001896E9320-0x00000001896E9350
		public bool m_SelfUpdate; // 0x18
		// [Tooltip] // 0x00000001896E9320-0x00000001896E9350
		public bool m_ShowDebugText; // 0x19
		// [Tooltip] // 0x00000001896F04D0-0x00000001896F0500
		public bool m_ShowCameraFrustum; // 0x1A
		// [Tooltip] // 0x00000001896F93E0-0x00000001896F9410
		public bool m_IgnoreTimeScale; // 0x1B
		// [Tooltip] // 0x00000001897025C0-0x00000001897025F0
		public Transform m_WorldUpOverride; // 0x20
		// [Tooltip] // 0x000000018970B560-0x000000018970B590
		public UpdateMethod m_UpdateMethod; // 0x28
		[CinemachineBlendDefinitionProperty] // 0x00000001897142F0-0x0000000189714340
		// [Tooltip] // 0x00000001897142F0-0x0000000189714340
		public CinemachineBlendDefinition m_DefaultBlend; // 0x30
		// [Tooltip] // 0x00000001897204C0-0x00000001897204F0
		public CinemachineBlenderSettings m_CustomBlends; // 0x40
		private Camera m_OutputCamera; // 0x48
		private float mFieldOfView; // 0x50
		private float mNearClipPlane; // 0x54
		private float mDutch; // 0x58
		private float mOrthographicSize; // 0x5C
		private Vector3 mFinalPosition; // 0x60
		private Quaternion mOrientationWithoutDutch; // 0x6C
		private Quaternion mFinalOrientation; // 0x7C
		// [Tooltip] // 0x0000000189728F20-0x0000000189728F50
		public BrainEvent m_CameraCutEvent; // 0x90
		// [Tooltip] // 0x0000000189731FC0-0x0000000189731FF0
		public VcamEvent m_CameraActivatedEvent; // 0x98
		public BlendEvent m_CameraBlendCompeleteEvent; // 0xA0
		internal static BrainEvent sPostProcessingHandler; // 0x00
		private ICinemachineCamera mActiveCameraPreviousFrame; // 0xB0
		private ICinemachineCamera mOutgoingCameraPreviousFrame; // 0xB8
		private CinemachineBlend mActiveBlend; // 0xC0
		private bool mPreviousFrameWasOverride; // 0xC8
		private List<OverrideStackFrame> mOverrideStack; // 0xD0
		private int mNextOverrideId; // 0xD8
		private OverrideStackFrame mOverrideBlendFromNothing; // 0xE0
		private WaitForFixedUpdate mWaitForFixedUpdate; // 0xE8
		private static int msCurrentFrame; // 0x10
		private static int msFirstBrainObjectId; // 0x14
		private static int msSubframes; // 0x18
	
		// Properties
		public Camera OutputCamera { /* [XID] */ /* 0x000000018968D470-0x000000018968D490 */ get => default; } // 0x0000000186EE44C0-0x0000000186EE45C0 
		public float FieldOfView { /* [XID] */ /* 0x000000018961CB40-0x000000018961CB60 */ get => default; } // 0x0000000186EE3F90-0x0000000186EE4040 
		public float NearClipPlane { /* [XID] */ /* 0x00000001897693F0-0x0000000189769410 */ get => default; } // 0x0000000186EE4360-0x0000000186EE4410 
		public float Dutch { /* [XID] */ /* 0x0000000189770AE0-0x0000000189770B00 */ get => default; } // 0x0000000186EE3EE0-0x0000000186EE3F90 
		public float OrithographicSize { /* [XID] */ /* 0x0000000189BD6DA0-0x0000000189BD6DC0 */ get => default; } // 0x0000000186EE4410-0x0000000186EE44C0 
		public Vector3 FinalPosition { /* [XID] */ /* 0x00000001899954B0-0x00000001899954D0 */ get => default; } // 0x0000000186EE4110-0x0000000186EE41F0 
		public Quaternion FinalOrientation { /* [XID] */ /* 0x00000001899A4850-0x00000001899A4870 */ get => default; } // 0x0000000186EE4040-0x0000000186EE4110 
		internal Component PostProcessingComponent { /* [XID] */ /* 0x0000000189795F70-0x0000000189795FB0 */ get; /* [XID] */ /* 0x00000001897A0D70-0x00000001897A0DB0 */ set; } // 0x0000000186EE45C0-0x0000000186EE4620 0x0000000186EE4790-0x0000000186EE4800
		public static ICinemachineCamera SoloCamera { /* [XID] */ /* 0x00000001897AB140-0x00000001897AB180 */ get; set; } // 0x0000000186EE4620-0x0000000186EE46B0 0x0000000186EE4800-0x0000000186EE4890
		public Vector3 DefaultWorldUp { /* [XID] */ /* 0x00000001899BAE60-0x00000001899BAE80 */ get => default; } // 0x0000000186EE3D60-0x0000000186EE3EE0 
		private bool IsSelfUpdate { /* [XID] */ /* 0x00000001898136E0-0x0000000189813700 */ get => default; } // 0x0000000186EE42C0-0x0000000186EE4360 
		public bool IsBlending { /* [XID] */ /* 0x00000001898477C0-0x00000001898477E0 */ get => default; } // 0x0000000186EE41F0-0x0000000186EE42C0 
		public CinemachineBlend ActiveBlend { /* [XID] */ /* 0x000000018984EFD0-0x000000018984EFF0 */ get => default; } // 0x0000000186EE3A50-0x0000000186EE3B50 
		public ICinemachineCamera ActiveVirtualCamera { /* [XID] */ /* 0x0000000189A38130-0x0000000189A38150 */ get => default; } // 0x0000000186EE3B50-0x0000000186EE3C70 
		public CameraState CurrentCameraState { /* [XID] */ /* 0x000000018986C2E0-0x000000018986C320 */ get; /* [XID] */ /* 0x0000000189876790-0x00000001898767D0 */ private set; } // 0x0000000186EE3C70-0x0000000186EE3D60 0x0000000186EE46B0-0x0000000186EE4790
	
		// Nested types
		// [DocumentationSorting] // 0x00000001898AD0A0-0x00000001898AD0C0
		public enum UpdateMethod // TypeDefIndex: 6752
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2
		}
	
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 6753
		{
			// Constructors
			public BrainEvent() {} // 0x0000000186ED4EC0-0x0000000186ED4F30
		}
	
		[Serializable]
		public class VcamEvent : UnityEvent<ICinemachineCamera> // TypeDefIndex: 6754
		{
			// Constructors
			public VcamEvent() {} // 0x0000000186EF8EB0-0x0000000186EF8F20
		}
	
		[Serializable]
		public class BlendEvent : UnityEvent<CinemachineBlend> // TypeDefIndex: 6755
		{
			// Constructors
			public BlendEvent() {} // 0x0000000186ED3BE0-0x0000000186ED3C50
		}
	
		private class OverrideStackFrame // TypeDefIndex: 6756
		{
			// Fields
			public int id; // 0x10
			public ICinemachineCamera camera; // 0x18
			public CinemachineBlend blend; // 0x20
			public float deltaTime; // 0x28
			public float timeOfOverride; // 0x2C
	
			// Properties
			public bool Active { /* [XID] */ /* 0x00000001898B46C0-0x00000001898B46E0 */ get => default; } // 0x0000000186EF0D30-0x0000000186EF0DE0 
			public bool Expired { /* [XID] */ /* 0x00000001898BC4C0-0x00000001898BC4E0 */ get => default; } // 0x0000000186EF0DE0-0x0000000186EF0ED0 
	
			// Constructors
			public OverrideStackFrame() {} // 0x0000000186EF0CD0-0x0000000186EF0D30
		}
	
		// Constructors
		public CinemachineBrain() {} // 0x0000000186EE3740-0x0000000186EE3A50
		static CinemachineBrain() {} // 0x0000000186EE3680-0x0000000186EE3740
	
		// Methods
		// [XID] // 0x000000018978E900-0x000000018978E920
		private void FlushToOutpuCamera() {} // 0x0000000186EE0E00-0x0000000186EE0FA0
		// [XID] // 0x00000001897BE3B0-0x00000001897BE3D0
		public static Color GetSoloGUIColor() => default; // 0x0000000186EE15E0-0x0000000186EE1700
		// [XID] // 0x00000001897CD200-0x00000001897CD220
		private OverrideStackFrame GetOverrideFrame(int id) => default; // 0x0000000186EE1440-0x0000000186EE15E0
		// [XID] // 0x00000001897D47D0-0x00000001897D47F0
		private OverrideStackFrame GetNextActiveFrame(int overrideId) => default; // 0x0000000186EE1260-0x0000000186EE1440
		// [XID] // 0x00000001897DBEC0-0x00000001897DBEE0
		private OverrideStackFrame GetActiveOverride() => default; // 0x0000000186EE0FA0-0x0000000186EE10E0
		// [XID] // 0x00000001897E3830-0x00000001897E3850
		internal int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) => default; // 0x0000000186EE2DD0-0x0000000186EE3110
		// [XID] // 0x00000001897EB0B0-0x00000001897EB0D0
		internal void ReleaseCameraOverride(int overrideId) {} // 0x0000000186EE2C80-0x0000000186EE2DD0
		// [XID] // 0x00000001897F2E20-0x00000001897F2E40
		private void OnEnable() {} // 0x0000000186EE2060-0x0000000186EE2160
		// [XID] // 0x000000018996C5D0-0x000000018996C5F0
		private void OnDisable() {} // 0x0000000186EE1F50-0x0000000186EE2060
		// [XID] // 0x000000018998DA20-0x000000018998DA40
		private void Start() {} // 0x0000000186EE3110-0x0000000186EE31E0
		[DebuggerHidden] // 0x00000001898090D0-0x0000000189809110
		// [XID] // 0x00000001898090D0-0x0000000189809110
		private IEnumerator AfterPhysics() => default; // 0x0000000186EE0800-0x0000000186EE0910
		// [XID] // 0x000000018981B160-0x000000018981B180
		private void LateUpdateInternal(bool flush = true /* Metadata: 0x00ADDDFB */) {} // 0x0000000186EE1B10-0x0000000186EE1C10
		// [XID] // 0x00000001898227A0-0x00000001898227C0
		private void LateUpdate() {} // 0x0000000186EE1C10-0x0000000186EE1CC0
		// [XID] // 0x0000000189829FB0-0x0000000189829FD0
		public void LateTick(bool flush = true /* Metadata: 0x00ADDDFC */) {} // 0x0000000186EE1A40-0x0000000186EE1B10
		// [XID] // 0x0000000189831490-0x00000001898314B0
		private float GetEffectiveDeltaTime(bool fixedDelta) => default; // 0x0000000186EE10E0-0x0000000186EE1260
		// [XID] // 0x0000000189AD81B0-0x0000000189AD81D0
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime) {} // 0x0000000186EE3410-0x0000000186EE3680
		// [XID] // 0x0000000189840140-0x0000000189840160
		private void ProcessActiveCamera(float deltaTime, bool flush = true /* Metadata: 0x00ADDDFD */) {} // 0x0000000186EE2160-0x0000000186EE2870
		// [XID] // 0x00000001895F7650-0x00000001895F7670
		public bool IsLive(ICinemachineCamera vcam) => default; // 0x0000000186EE18E0-0x0000000186EE1A40
		// [XID] // 0x000000018985D320-0x000000018985D340
		private bool IsLiveItself(ICinemachineCamera vcam) => default; // 0x0000000186EE17E0-0x0000000186EE18E0
		// [XID] // 0x0000000189AE3C10-0x0000000189AE3C30
		private ICinemachineCamera TopCameraFromPriorityQueue() => default; // 0x0000000186EE31E0-0x0000000186EE3410
		// [XID] // 0x00000001898882B0-0x00000001898882D0
		private AnimationCurve LookupBlendCurve(ICinemachineCamera fromKey, ICinemachineCamera toKey, out float duration, out CinemachineBlendDefinition blendDef) {
			duration = default;
			blendDef = default;
			return default;
		} // 0x0000000186EE1CC0-0x0000000186EE1F50
		// [XID] // 0x000000018988F860-0x000000018988F880
		private CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, AnimationCurve blendCurve, float duration, CinemachineBlend activeBlend, CinemachineBlendDefinition def) => default; // 0x0000000186EE0910-0x0000000186EE0E00
		// [XID] // 0x0000000189896E30-0x0000000189896E50
		private void PushStateToUnityCamera(CameraState state, ICinemachineCamera vcam, bool flush = true /* Metadata: 0x00ADDDFE */) {} // 0x0000000186EE2870-0x0000000186EE2C80
		// [XID] // 0x000000018989E2F0-0x000000018989E310
		private void AddSubframe() {} // 0x0000000186EE0650-0x0000000186EE0800
		// [XID] // 0x00000001898A5D30-0x00000001898A5D50
		internal static int GetSubframeCount() => default; // 0x0000000186EE1700-0x0000000186EE17E0
	}
}
