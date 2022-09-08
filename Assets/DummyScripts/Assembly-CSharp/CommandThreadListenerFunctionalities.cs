/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadListenerFunctionalities : CommandThreadFunctionalities<SharedListenerFunctionalities> // TypeDefIndex: 11317
{
	// Fields
	private const string GUI_LISTENER_NAME = "GuiListener"; // Metadata: 0x00AE9727
	private const string FP_LISTENER_NAME = "FirstPersonListener"; // Metadata: 0x00AE9736
	private const string TP_LISTENER_NAME = "ThirdPersonListener"; // Metadata: 0x00AE974D
	private const string DEFAULT_LISTENER_NAME = "DefaultListener"; // Metadata: 0x00AE9764
	private readonly OutreachRaycaster _outreachRaycaster; // 0x20
	private SyncId _idGuiLisenter; // 0x28
	private SyncId _idFirstPersonListener; // 0x40
	private SyncId _idThirdPersonListener; // 0x58
	private SyncId _idDefaultListener; // 0x70
	private TailingTarget _tailingTarget; // 0x88
	private bool _hasSetFirstPersonListenerVolumeOffset; // 0x8C
	private bool _hasSetThirdPersonListenerVolumeOffset; // 0x8D
	private Vector3 _defaultListenerPosition; // 0x90
	private Quaternion _defaultListenerRotation; // 0x9C
	private ListenerAlignmentReason _alignmentReasonMask; // 0xAC

	// Properties
	public Vector3 listenerPosition { /* [XID] */ /* 0x0000000189AAF210-0x0000000189AAF230 */ get => default; } // 0x00000001825E9C80-0x00000001825E9D60 
	public Quaternion listenerRotation { /* [XID] */ /* 0x0000000189AB6AF0-0x0000000189AB6B10 */ get => default; } // 0x00000001825E9BB0-0x00000001825E9C80 

	// Nested types
	private class OutreachRaycaster // TypeDefIndex: 11318
	{
		// Fields
		private const float MIN_RANGE = 1f; // Metadata: 0x00AE9777
		private const float MAX_RANGE = 30f; // Metadata: 0x00AE977B
		private const float THRESHOLD = 0.3f; // Metadata: 0x00AE977F
		private readonly CommandThreadListenerFunctionalities _listeners; // 0x10
		private readonly List<Caster> _casters; // 0x18
		private Vector3 _offset; // 0x20
		private float _range; // 0x2C
		private Vector3 _currentSampleSpot; // 0x30
		private Quaternion _currentSampleAngle; // 0x3C
		private int _currentSampleIndex; // 0x4C

		// Nested types
		private class Caster // TypeDefIndex: 11319
		{
			// Fields
			private readonly uint _rtpcId; // 0x10
			private readonly Quaternion _rotation; // 0x14

			// Properties
			public uint rtpcId { /* [XID] */ /* 0x0000000189BA5B50-0x0000000189BA5B70 */ get => default; } // 0x00000001825CD980-0x00000001825CDA20 

			// Constructors
			public Caster() {} // Dummy constructor
			public Caster(float angle, uint rtpcId) {} // 0x00000001825CDA20-0x00000001825CDAF0

			// Methods
			// [XID] // 0x0000000189BACE80-0x0000000189BACEA0
			public float Detect(Vector3 position, Vector3 forward, float range) => default; // 0x00000001825CD740-0x00000001825CD980
		}

		// Constructors
		public OutreachRaycaster() {} // Dummy constructor
		public OutreachRaycaster(CommandThreadListenerFunctionalities listeners) {} // 0x00000001825CD6A0-0x00000001825CD740

		// Methods
		// [XID] // 0x0000000189622AA0-0x0000000189622AC0
		public void Init() {} // 0x00000001825CD030-0x00000001825CD310
		// [XID] // 0x0000000189673EA0-0x0000000189673EC0
		public void Tick() {} // 0x00000001825CD310-0x00000001825CD5A0
		// [XID] // 0x0000000189B96DE0-0x0000000189B96E00
		private uint GetRtpcIdAt(int index, ConfigWwiseString[] rtpcs) => default; // 0x00000001825CD5A0-0x00000001825CD6A0
		// [XID] // 0x000000018967B640-0x000000018967B660
		private void CastRay(int index) {} // 0x00000001825CCDA0-0x00000001825CD030
	}

	// Constructors
	public CommandThreadListenerFunctionalities() {} // Dummy constructor
	public CommandThreadListenerFunctionalities(CommandThreadContext context, SharedListenerFunctionalities shared) {} // 0x00000001825EC140-0x00000001825EC290

	// Methods
	// [XID] // 0x0000000189ABE5C0-0x0000000189ABE5E0
	public override void Init() {} // 0x00000001825EA4A0-0x00000001825EA690
	// [XID] // 0x0000000189AC6130-0x0000000189AC6150
	public override void Tick(float deltaTime) {} // 0x00000001825EA690-0x00000001825EA760
	// [XID] // 0x0000000189ACD680-0x0000000189ACD6A0
	public override void EnterHomeWorld(bool firstTime) {} // 0x00000001825EB220-0x00000001825EB2D0
	// [XID] // 0x0000000189AD5420-0x0000000189AD5440
	public override void ExitHomeWorld() {} // 0x00000001825EB660-0x00000001825EB700
	// [XID] // 0x0000000189ADCDF0-0x0000000189ADCE10
	public override void ExitGameWorld() {} // 0x00000001825EB3E0-0x00000001825EB480
	// [XID] // 0x0000000189AE4620-0x0000000189AE4640
	public override void CreateLevel() {} // 0x00000001825E99C0-0x00000001825E9A60
	// [XID] // 0x000000018960C500-0x000000018960C520
	public override void EnterLevel() {} // 0x00000001825EAD50-0x00000001825EB220
	// [XID] // 0x00000001897230D0-0x00000001897230F0
	public override void ExitLevel() {} // 0x00000001825EA0F0-0x00000001825EA4A0
	// [XID] // 0x0000000189AFB080-0x0000000189AFB0A0
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x00000001825EBF80-0x00000001825EC030
	// [XID] // 0x0000000189B02620-0x0000000189B02640
	public override void Destroy() {} // 0x00000001825E9A60-0x00000001825E9BB0
	// [XID] // 0x0000000189B09C60-0x0000000189B09C80
	public ListenerPersonality DeductPersonalityFromEntity(BaseEntity entity) => default; // 0x00000001825EB850-0x00000001825EB960
	// [XID] // 0x000000018975D3A0-0x000000018975D3C0
	public void SetPersonalityByAvatarEntity(AvatarEntity avatarEntity, SyncId emitterSyncId) {} // 0x00000001825EB2D0-0x00000001825EB3E0
	// [XID] // 0x0000000189B187F0-0x0000000189B18810
	public bool IsFirstPersonAvatar(AvatarEntity avatarEntity) => default; // 0x00000001825EBE50-0x00000001825EBF80
	// [XID] // 0x00000001897872D0-0x00000001897872F0
	public void SetToUseGuiListener(SyncId syncId) {} // 0x00000001825E9D60-0x00000001825E9E70
	// [XID] // 0x0000000189B276A0-0x0000000189B276C0
	public void SetToUseFirstPersonListener(SyncId syncId) {} // 0x00000001825EC030-0x00000001825EC140
	// [XID] // 0x0000000189B2E8E0-0x0000000189B2E900
	public void SetToUseThirdPersonListener(SyncId syncId) {} // 0x00000001825EB480-0x00000001825EB590
	// [XID] // 0x0000000189B35FF0-0x0000000189B36010
	public void ResetToUseDefaultListener(SyncId syncId) {} // 0x00000001825EB960-0x00000001825EBA70
	// [XID] // 0x0000000189B3D660-0x0000000189B3D680
	public void AddAlignmentReason(ListenerAlignmentReason reason) {} // 0x00000001825EB590-0x00000001825EB660
	// [XID] // 0x0000000189B455C0-0x0000000189B455E0
	public void RemoveAlignmentReason(ListenerAlignmentReason reason) {} // 0x00000001825EBD70-0x00000001825EBE50
	// [XID] // 0x0000000189B4CB10-0x0000000189B4CB30
	private void TickListenerPosition() {} // 0x00000001825EAB10-0x00000001825EAD50
	// [XID] // 0x0000000189B54220-0x0000000189B54240
	private void TailToAvatar(EntityManager entityManager, Transform cameraTransform) {} // 0x00000001825EBA70-0x00000001825EBD70
	// [XID] // 0x0000000189B5BD00-0x0000000189B5BD20
	private void TailToCamera(EntityManager entityManager, Transform cameraTransform) {} // 0x00000001825EA9C0-0x00000001825EAB10
	// [XID] // 0x00000001895E6C50-0x00000001895E6C70
	private void AlignListenerToTransform(Vector3 position, Quaternion rotation) {} // 0x00000001825EA760-0x00000001825EA9C0
	// [XID] // 0x0000000189BC5340-0x0000000189BC5360
	private void SetFirstPersonListenerVolumeOffset() {} // 0x00000001825E9FB0-0x00000001825EA0F0
	// [XID] // 0x0000000189B72260-0x0000000189B72280
	private void SetThirdPersonListenerVolumeOffset() {} // 0x00000001825E9E70-0x00000001825E9FB0
	// [XID] // 0x0000000189B79670-0x0000000189B79690
	private void SetDefaultListenerVolumeOffset() {} // 0x00000001825E9890-0x00000001825E99C0
	// [XID] // 0x0000000189B80A10-0x0000000189B80A30
	private void MakeUpForEarlyBirds() {} // 0x00000001825EB700-0x00000001825EB850
}

