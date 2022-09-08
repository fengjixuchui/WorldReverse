/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using miHoYoCamera;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCStackCamera : VCBase // TypeDefIndex: 11961
{
	// Fields
	private List<CameraCmd> _cmdList; // 0x108
	private List<int> _handledCmdList; // 0x110
	public const float ROTATION_FACTOR = 0.2f; // Metadata: 0x00AEAFAC
	private const string POINT_CAMERA_LOOK = "CameraLook"; // Metadata: 0x00AEAFB0
	private const string POINT_MOVE_HEAD = "MoveHead"; // Metadata: 0x00AEAFBE
	private bool _hasAuthority; // 0x118
	private Camera _camera; // 0x120
	private CinemachineBrain _brain; // 0x128
	private CameraStateMgr _stateMgr; // 0x130
	private CameraSchedulerBeforeTask _beforeTask; // 0x138
	private CameraSchedulerAfterTask _afterTask; // 0x140
	private CameraProfile _profile; // 0x148
	private CameraOutputData _outputData; // 0x150
	private SCameraBaseState _topState; // 0x198
	private SCameraNormalState _defaultState; // 0x1A0
	private SCameraLockingState _lockingState; // 0x1A8
	private SCameraGiantBossAdjustState _giantBossAdjustState; // 0x1B0
	private SCameraPhotographState _photographState; // 0x1B8
	private SCameraCineState _cine2State; // 0x1C0
	private SCameraCineState _cine3State; // 0x1C8
	private SCameraStoryState _storyState; // 0x1D0
	private SCameraFocusState _focusState; // 0x1D8
	private SCameraHomeWorldState _homeworldState; // 0x1E0
	private SCameraFirstPersonState _firstPersonState; // 0x1E8
	private bool _enterDither; // 0x1F0
	private bool _enableDither; // 0x1F1
	private float _protectDither; // 0x1F4
	private bool _isFollowTargetStand; // 0x1F8
	private bool _isFollowTargetMove; // 0x1F9
	private bool _isCameraControl; // 0x1FA
	private bool _enableCameraDitherExceptLeaves; // 0x1FB
	private bool _shareDataInited; // 0x1FC
	private CameraShareData _shareData; // 0x200
	private CameraAvatarInfoData _avatarInfoData; // 0x5A8
	private bool _avatarDirty; // 0x6E8
	private BaseEntity _avatarEntity; // 0x6F0
	private BaseEntity _heroEntity; // 0x6F8
	private CameraAvatarPrepareData _avatarPrepareData; // 0x700
	private VCSCameraAimingCtrlPlugin _aimingCtrlPlugin; // 0x708
	private VCSCameraSceneLookPlugin _sceneLookPlugin; // 0x710
	private bool _reconnected; // 0x718
	private SCameraCmd _resetToBackCmd; // 0x720
	private SCameraCmd _initToBackCmd; // 0x740
	private SCameraCmd _lerpToBackCmd; // 0x760
	private SCameraCmd _clearFilterCmd; // 0x780
	private SCameraCmd _setfovCMD; // 0x7A0
	private SCameraCmd _setShiftCMD; // 0x7C0
	private SCameraCmd _rotateCmd; // 0x7E0
	private bool _isManuallyRotating; // 0x800
	private SCameraCmd _zoomCmd; // 0x808
	private SCameraCmd _moveCmd; // 0x828
	private SCameraCmd _refAnchorPositionCmd; // 0x848
	private SCameraCmd _cameraPositionCmd; // 0x868
	private SCameraCmd _clampPitchCmd; // 0x888
	private SCameraCmd _clampZoomCmd; // 0x8A8
	private SCameraCmd _moveRotateVerticallyCmd; // 0x8C8
	private SCameraCmd _keepRotation; // 0x8E8
	private CameraStateData _spData; // 0x908
	private bool _qaSetPosFlag; // 0x9E0
	private Vector3 _qaPos; // 0x9E4
	private bool _qaSetFovFlag; // 0x9F0
	private float _fov; // 0x9F4
	private bool _qaSetForwardFlag; // 0x9F8
	private Vector3 _qaForward; // 0x9FC

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899948E0-0x0000000189994900 */ get => default; } // 0x0000000182D03170-0x0000000182D03210 
	public bool hasAuthority { /* [XID] */ /* 0x00000001895EB5D0-0x00000001895EB5F0 */ get => default; } // 0x0000000182D01BD0-0x0000000182D01C80 
	public Camera curCamera { /* [XID] */ /* 0x00000001899C1CA0-0x00000001899C1CC0 */ get => default; } // 0x0000000182CFB7C0-0x0000000182CFB870 
	public CinemachineBrain brain { /* [XID] */ /* 0x00000001899C90C0-0x00000001899C90E0 */ get => default; } // 0x0000000182CFB300-0x0000000182CFB3B0 
	public CameraProfile profile { /* [XID] */ /* 0x00000001898880E0-0x0000000189888100 */ get => default; } // 0x0000000182CF9220-0x0000000182CF92D0 
	public CameraOutputData OutputData { /* [XID] */ /* 0x0000000189885310-0x0000000189885330 */ get => default; } // 0x0000000182CFF340-0x0000000182CFF4D0 
	public bool enableCameraDitherExceptLeaves { /* [XID] */ /* 0x0000000189918040-0x0000000189918060 */ get => default; } // 0x0000000182CFD690-0x0000000182CFD740 
	public VCSCameraAimingCtrlPlugin aimingCtrlPlugin { /* [XID] */ /* 0x000000018984EDC0-0x000000018984EDE0 */ get => default; } // 0x0000000182CFC4C0-0x0000000182CFC570 
	public VCSCameraSceneLookPlugin sceneLookPlugin { /* [XID] */ /* 0x0000000189A92BC0-0x0000000189A92BE0 */ get => default; } // 0x0000000182CFBC30-0x0000000182CFBCE0 
	public float zoomVelocity { /* [XID] */ /* 0x0000000189BAE3E0-0x0000000189BAE400 */ get => default; } // 0x0000000182D01930-0x0000000182D01A00 
	public bool isManuallyRotating { /* [XID] */ /* 0x00000001895FE930-0x00000001895FE950 */ get => default; } // 0x0000000182CFC060-0x0000000182CFC110 

	// Nested types
	public enum CmdType // TypeDefIndex: 11962
	{
		CINE_ENTER = 0,
		CINE_CLEAR = 1,
		STORY_ENTER = 2,
		STORY_EXIT = 3,
		FOCUS_ENTER = 4,
		FOCUS_EXIT = 5,
		BOSSADJUST_ENTER = 6,
		BOSSADJUST_EXIT = 7,
		PHOTOGRAPH_ENTER = 8,
		PHOTOGRAPH_EXIT = 9,
		HOMEWORLD_ENTER = 10,
		HOMEWORLD_EXIT = 11,
		FIRSTPERSON_ENTER = 12,
		FIRSTPERSON_EXIT = 13
	}

	public struct CameraCmd // TypeDefIndex: 11963
	{
		// Fields
		public CmdType cmdType; // 0x00
		public int frameDelay; // 0x04
		public int subType; // 0x08
		public SCameraShotTask shot; // 0x10
		public bool currentFrame; // 0x18
		public SCameraStoryData story; // 0x20
		public SCameraFocusData focus; // 0x128
		public SCameraGiantBossAdjustData bossAdjust; // 0x188

		// Methods
		// [XID] // 0x00000001897914B0-0x00000001897914D0
		public static CameraCmd Create(CmdType cmdType) => default; // 0x0000000182D17BC0-0x0000000182D17E90
	}

	// Constructors
	public VCStackCamera() {} // 0x0000000182D02B30-0x0000000182D03170

	// Methods
	// [XID] // 0x000000018999C130-0x000000018999C150
	private void AddCameraCmd(CameraCmd cmd) {} // 0x0000000182CFDBE0-0x0000000182CFDDB0
	// [XID] // 0x00000001899A3A20-0x00000001899A3A40
	private void CollectHandleCameraCmd() {} // 0x0000000182D01E40-0x0000000182D021F0
	// [XID] // 0x0000000189BAA240-0x0000000189BAA260
	private void HandleCameraCmdInternal(CameraCmd cmd) {} // 0x0000000182CFEB30-0x0000000182CFF200
	// [XID] // 0x00000001899BA130-0x00000001899BA150
	public void UpdateAuthority(bool hasAuthority) {} // 0x0000000182CF9690-0x0000000182CF9740
	// [XID] // 0x00000001899D7FB0-0x00000001899D7FD0
	private void SetProfile(CameraProfile profile) {} // 0x0000000182CFC1E0-0x0000000182CFC2A0
	// [XID] // 0x00000001899DF5E0-0x00000001899DF600
	public string DumpStackInfo() => default; // 0x0000000182CF8730-0x0000000182CF8A10
	// [XID] // 0x00000001899E7110-0x00000001899E7130
	private void ModifyProfileValues() {} // 0x0000000182D01660-0x0000000182D01870
	// [XID] // 0x00000001899F5E40-0x00000001899F5E60
	public void GetOutputData(CameraOutputData data) {} // 0x0000000182D013E0-0x0000000182D01500
	// [XID] // 0x00000001899FD4D0-0x00000001899FD4F0
	public bool IsStateSpawned(SCameraStateType stateType) => default; // 0x0000000182D01C80-0x0000000182D01D70
	// [XID] // 0x0000000189A04BC0-0x0000000189A04BE0
	public void SetEnableCameraDitherExceptLeaves(bool enable) {} // 0x0000000182CF6310-0x0000000182CF63C0
	// [XID] // 0x0000000189A13C10-0x0000000189A13C30
	public override void PreInit() {} // 0x0000000182D02500-0x0000000182D02A40
	// [XID] // 0x000000018998FDA0-0x000000018998FDC0
	private void ClearStatesOnConnect() {} // 0x0000000182D01310-0x0000000182D013E0
	// [XID] // 0x00000001899BD3C0-0x00000001899BD3E0
	private void ClearStatesOnDisconnect() {} // 0x0000000182D01020-0x0000000182D01180
	// [XID] // 0x000000018999F210-0x000000018999F230
	private void ClearStateOnDisconnect(SCameraBaseState state) {} // 0x0000000182CFDE60-0x0000000182CFDF20
	// [XID] // 0x0000000189A30EA0-0x0000000189A30EC0
	private void DisposeStates() {} // 0x0000000182CF9BE0-0x0000000182CF9D20
	// [XID] // 0x0000000189A38AD0-0x0000000189A38AF0
	private void DisposeState(SCameraBaseState state) {} // 0x0000000182CF9490-0x0000000182CF9550
	// [XID] // 0x0000000189AB3A70-0x0000000189AB3A90
	public void SetTargetAvatar(BaseEntity avatarEntity, BaseEntity heroEntity) {} // 0x0000000182D00E30-0x0000000182D01020
	// [XID] // 0x0000000189AED470-0x0000000189AED490
	private void PrepareOnSetTargetAvatar() {} // 0x0000000182CFB9B0-0x0000000182CFBA90
	// [XID] // 0x0000000189AF4EA0-0x0000000189AF4EC0
	private bool IsAvatarActive() => default; // 0x0000000182CFE6C0-0x0000000182CFE7C0
	// [XID] // 0x0000000189A565C0-0x0000000189A565E0
	public override bool IsActive() => default; // 0x0000000182CFD500-0x0000000182CFD5D0
	// [XID] // 0x0000000189A5E1D0-0x0000000189A5E1F0
	public override void Init() {} // 0x0000000182CFD420-0x0000000182CFD500
	// [XID] // 0x0000000189A65980-0x0000000189A659A0
	private void InitCameraSetting() {} // 0x0000000182CFF5C0-0x0000000182CFF7B0
	// [XID] // 0x0000000189B72300-0x0000000189B72320
	private void InitCamera() {} // 0x0000000182CF7850-0x0000000182CF7970
	// [XID] // 0x0000000189B88680-0x0000000189B886A0
	private void InitBrain() {} // 0x0000000182CF7D70-0x0000000182CF7EB0
	// [XID] // 0x0000000189A7C2C0-0x0000000189A7C2E0
	private void InitEvent() {} // 0x0000000182CF7C20-0x0000000182CF7D70
	// [XID] // 0x0000000189A83C80-0x0000000189A83CA0
	private void InitTasks() {} // 0x0000000182CFA0E0-0x0000000182CFA800
	// [XID] // 0x0000000189A9A680-0x0000000189A9A6A0
	private void InitPlugins() {} // 0x0000000182CFA8E0-0x0000000182CFA9E0
	// [XID] // 0x00000001895EE5D0-0x00000001895EE5F0
	private void RefreshShareData() {} // 0x0000000182D02350-0x0000000182D02440
	// [XID] // 0x00000001895F5D80-0x00000001895F5DA0
	private void RefreshShareDataInternal() {} // 0x0000000182CF6E20-0x0000000182CF74F0
	// [XID] // 0x000000018960C420-0x000000018960C440
	public void RefreshTargetAvatar() {} // 0x0000000182CFC2A0-0x0000000182CFC380
	// [XID] // 0x0000000189613A20-0x0000000189613A40
	private void RefreshAvatarPrepareData() {} // 0x0000000182CFAD20-0x0000000182CFB1F0
	// [XID] // 0x000000018961B310-0x000000018961B330
	private void InitAvatarInfo() {} // 0x0000000182CFD1A0-0x0000000182CFD420
	// [XID] // 0x000000018962A180-0x000000018962A1A0
	private void RefreshStateData() {} // 0x0000000182CF67D0-0x0000000182CF6910
	// [XID] // 0x0000000189ACEBF0-0x0000000189ACEC10
	private void PrepareState(ICameraState state) {} // 0x0000000182CF9550-0x0000000182CF9690
	// [XID] // 0x0000000189AD6B70-0x0000000189AD6B90
	private void PreparePostProcesser(CameraStatePostProcesser postProcesser) {} // 0x0000000182CF8640-0x0000000182CF8730
	// [XID] // 0x0000000189ADE3E0-0x0000000189ADE400
	private void RefreshState() {} // 0x0000000182CFCB00-0x0000000182CFCC00
	// [XID] // 0x0000000189AE5E60-0x0000000189AE5E80
	private void RefreshCombatSetting() {} // 0x0000000182D01D70-0x0000000182D01E40
	// [XID] // 0x0000000189AED290-0x0000000189AED2B0
	private void RefreshCameraMoveState() {} // 0x0000000182CFCC00-0x0000000182CFCDC0
	// [XID] // 0x0000000189AF4D40-0x0000000189AF4D60
	public void UpdateIsControl(bool isCtrl) {} // 0x0000000182CFDDB0-0x0000000182CFDE60
	// [XID] // 0x0000000189AFC280-0x0000000189AFC2A0
	private void PreCollect() {} // 0x0000000182D01870-0x0000000182D01930
	// [XID] // 0x0000000189B03BD0-0x0000000189B03BF0
	private void PostCollect() {} // 0x0000000182CFBFC0-0x0000000182CFC060
	// [XID] // 0x0000000189B0B240-0x0000000189B0B260
	public void Collect(float deltaTime) {} // 0x0000000182CF74F0-0x0000000182CF75F0
	// [XID] // 0x0000000189B12AD0-0x0000000189B12AF0
	public void Execute(float deltaTime) {} // 0x0000000182CF6D50-0x0000000182CF6E20
	// [XID] // 0x0000000189B19D60-0x0000000189B19D80
	public void Flush(float deltaTime) {} // 0x0000000182CFD810-0x0000000182CFDB20
	// [XID] // 0x0000000189B21350-0x0000000189B21370
	public void PostFlush(float deltaTime) {} // 0x0000000182D02440-0x0000000182D02500
	// [XID] // 0x0000000189ACBDE0-0x0000000189ACBE00
	private void AddCmd(ref SCameraCmd cmd) {} // 0x0000000182CFFF00-0x0000000182D00140
	// [XID] // 0x0000000189B30050-0x0000000189B30070
	private void HandleCmd(ref SCameraCmd cmd) {} // 0x0000000182CFE160-0x0000000182CFE260
	// [XID] // 0x0000000189ABCDC0-0x0000000189ABCDE0
	public void SpawnState(int stateId) {} // 0x0000000182CF9DA0-0x0000000182CF9E60
	// [XID] // 0x0000000189AB5150-0x0000000189AB5170
	public void UnSpawnState(int stateId) {} // 0x0000000182CFDFE0-0x0000000182CFE0A0
	// [XID] // 0x0000000189B46A40-0x0000000189B46A60
	public void SpawnStateImmdiately(int stateId) {} // 0x0000000182CFDF20-0x0000000182CFDFE0
	// [XID] // 0x000000018982B630-0x000000018982B650
	public void UnSpawnStateImmdiately(int stateId) {} // 0x0000000182CF63C0-0x0000000182CF6480
	// [XID] // 0x0000000189B6AAF0-0x0000000189B6AB10
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182CFBB60-0x0000000182CFBC30
	// [XID] // 0x0000000189B5D2B0-0x0000000189B5D2D0
	protected override bool OnEvent(BaseEvent evt) => default; // 0x0000000182D01A00-0x0000000182D01BD0
	// [XID] // 0x0000000189BA5BF0-0x0000000189BA5C10
	private bool OnEvtCameraMove(EvtCameraMove evt) => default; // 0x0000000182CFCDC0-0x0000000182CFCF30
	// [XID] // 0x0000000189B6BE80-0x0000000189B6BEA0
	private bool OnEvtCameraMoveClear(EvtCameraMoveClear evt) => default; // 0x0000000182CF80B0-0x0000000182CF8190
	// [XID] // 0x0000000189B73790-0x0000000189B737B0
	private bool OnEvtForceQuitStoryCamera(EvtForceQuitStoryCamera evt) => default; // 0x0000000182CF8B10-0x0000000182CF8E20
	// [XID] // 0x0000000189BBBD70-0x0000000189BBBD90
	private bool OnEvtCameraSceneLook(EvtCameraSceneLook evt) => default; // 0x0000000182CF8190-0x0000000182CF84A0
	// [XID] // 0x0000000189B82490-0x0000000189B824B0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182CFBA90-0x0000000182CFBB60
	// [XID] // 0x0000000189B89CF0-0x0000000189B89D10
	protected override bool ListenEvent(BaseEvent e) => default; // 0x0000000182CFF890-0x0000000182CFFAB0
	// [XID] // 0x0000000189B91280-0x0000000189B912A0
	private bool IsLevelReady() => default; // 0x0000000182CFE7C0-0x0000000182CFE8B0
	// [XID] // 0x0000000189B98510-0x0000000189B98530
	public Vector3 GetCameraStableForward() => default; // 0x0000000182CFA9E0-0x0000000182CFAAF0
	// [XID] // 0x0000000189B9FA20-0x0000000189B9FA40
	public Vector3 GetLookAtPos() => default; // 0x0000000182CFB1F0-0x0000000182CFB300
	// [XID] // 0x0000000189BA72B0-0x0000000189BA72D0
	public float GetDefaultLocateRatioNormal() => default; // 0x0000000182CF6CA0-0x0000000182CF6D50
	// [XID] // 0x0000000189AC4730-0x0000000189AC4750
	public void TryResetCameraToAvatarBackward(float poleOffsetDeg = 0f /* Metadata: 0x00AEAF92 */) {} // 0x0000000182CFD5D0-0x0000000182CFD690
	// [XID] // 0x0000000189BBD2F0-0x0000000189BBD310
	public void TryInitCameraToAvatarBackward(float poleOffsetDeg = 0f /* Metadata: 0x00AEAF96 */) {} // 0x0000000182CF7F50-0x0000000182CF8010
	// [XID] // 0x0000000189BC4EC0-0x0000000189BC4EE0
	public void TryLerpCameraToAvatarBackward(float poleOffsetDeg = 0f /* Metadata: 0x00AEAF9A */, float lerp = 1f /* Metadata: 0x00AEAF9E */) {} // 0x0000000182CFF4D0-0x0000000182CFF5C0
	// [XID] // 0x0000000189BCCA40-0x0000000189BCCA60
	public void TryClearFilter() {} // 0x0000000182CF77A0-0x0000000182CF7850
	// [XID] // 0x0000000189A8FED0-0x0000000189A8FEF0
	public void TryResetCameraToNormal() {} // 0x0000000182CF6480-0x0000000182CF6590
	// [XID] // 0x0000000189AA6320-0x0000000189AA6340
	private void UnSpawnOthers() {} // 0x0000000182CF9F00-0x0000000182CFA000
	// [XID] // 0x00000001895E82F0-0x00000001895E8310
	private void UnSpawnOtherState(ICameraState state) {} // 0x0000000182CFA000-0x0000000182CFA0E0
	// [XID] // 0x00000001895EFBC0-0x00000001895EFBE0
	public void TrySetFov(float fov) {} // 0x0000000182CF7AB0-0x0000000182CF7B70
	// [XID] // 0x00000001895F75D0-0x00000001895F75F0
	public void TrySetShift(float leftRight, float upDown) {} // 0x0000000182CF8550-0x0000000182CF8640
	// [XID] // 0x00000001896062D0-0x00000001896062F0
	public void TryRotateCamera(Vector2 deltaDrag) {} // 0x0000000182D00230-0x0000000182D00500
	// [XID] // 0x000000018960DB30-0x000000018960DB50
	public void TryZoomCamera(float zoomDelta) {} // 0x0000000182D021F0-0x0000000182D02350
	// [XID] // 0x0000000189615310-0x0000000189615330
	public void TryMoveCamera(Vector2 moveDelta) {} // 0x0000000182CFC570-0x0000000182CFC640
	// [XID] // 0x000000018961CA40-0x000000018961CA60
	public void TrySetRefAnchorPosition(Vector3 pos) {} // 0x0000000182CF8A10-0x0000000182CF8B10
	// [XID] // 0x0000000189623F60-0x0000000189623F80
	public void TrySetCameraPosition(Vector3 pos) {} // 0x0000000182CF6B40-0x0000000182CF6C40
	// [XID] // 0x000000018962B6D0-0x000000018962B6F0
	public void TrySetClampRotatePitch(Vector2 clampVal) {} // 0x0000000182CFD740-0x0000000182CFD810
	// [XID] // 0x0000000189632EF0-0x0000000189632F10
	public void TrySetClampZoomScale(Vector2 clampVal) {} // 0x0000000182CF8E90-0x0000000182CF8F60
	// [XID] // 0x000000018963AA30-0x000000018963AA50
	public void TryMoveRotateVertically(double anchorPosX, double anchorPosZ, double sphericalY) {} // 0x0000000182CF8F60-0x0000000182CF9060
	// [XID] // 0x0000000189642110-0x0000000189642130
	public void EnterStory(SCameraStoryData data) {} // 0x0000000182CFE410-0x0000000182CFE6C0
	// [XID] // 0x0000000189649900-0x0000000189649920
	public void ExitStory(SCameraStoryData data) {} // 0x0000000182D00B80-0x0000000182D00E30
	// [XID] // 0x0000000189651040-0x0000000189651060
	public void EnterDialogFocus(SCameraFocusData data) {} // 0x0000000182CF6590-0x0000000182CF67D0
	// [XID] // 0x0000000189658790-0x00000001896587B0
	public void ExitDialogFocus(SCameraFocusData data) {} // 0x0000000182CF99A0-0x0000000182CF9BE0
	// [XID] // 0x0000000189AD6C50-0x0000000189AD6C70
	public void EnterBossAdjust(ConfigSpecialCamera config, BaseEntity entity) {} // 0x0000000182D00500-0x0000000182D00730
	// [XID] // 0x0000000189B0CBA0-0x0000000189B0CBC0
	public void ExitBossAdjust(ConfigSpecialCamera config) {} // 0x0000000182CFBDD0-0x0000000182CFBFC0
	// [XID] // 0x000000018966F080-0x000000018966F0A0
	public void EnterPhotograph() {} // 0x0000000182CFB870-0x0000000182CFB9B0
	// [XID] // 0x00000001896769D0-0x00000001896769F0
	public void ExitPhotograph() {} // 0x0000000182CF7970-0x0000000182CF7AB0
	// [XID] // 0x000000018967E2A0-0x000000018967E2C0
	public void EnterHomeWorld() {} // 0x0000000182CFC380-0x0000000182CFC4C0
	// [XID] // 0x0000000189685A30-0x0000000189685A50
	public void ExitHomeWorld() {} // 0x0000000182CFF200-0x0000000182CFF340
	// [XID] // 0x000000018968D3D0-0x000000018968D3F0
	public void EnterCine(SCameraShotTask shot, int shotType = 0 /* Metadata: 0x00AEAFA2 */) {} // 0x0000000182CFFD10-0x0000000182CFFF00
	// [XID] // 0x0000000189694F80-0x0000000189694FA0
	private void OnTeamChange() {} // 0x0000000182CFA800-0x0000000182CFA8E0
	// [XID] // 0x000000018969C710-0x000000018969C730
	private void OnLocalAvatarChange(int subType, bool currentFrame) {} // 0x0000000182CF9060-0x0000000182CF9170
	// [XID] // 0x00000001896A3CB0-0x00000001896A3CD0
	private void ClearPluginLock() {} // 0x0000000182CF7B70-0x0000000182CF7C20
	// [XID] // 0x0000000189A97650-0x0000000189A97670
	public void ClearCine(int subType = 0 /* Metadata: 0x00AEAFA6 */, bool currentFrame = false /* Metadata: 0x00AEAFAA */) {} // 0x0000000182CFB5D0-0x0000000182CFB7C0
	// [XID] // 0x00000001896B2110-0x00000001896B2130
	public void EnterFirstPerson() {} // 0x0000000182CFE8B0-0x0000000182CFE9F0
	// [XID] // 0x00000001896B9B60-0x00000001896B9B80
	public void ExitFirstPerson() {} // 0x0000000182CFE9F0-0x0000000182CFEB30
	// [XID] // 0x0000000189B276C0-0x0000000189B276E0
	public void EnterAimFocus(bool isFast, Vector3 cameraFollowLowerPos, Vector3 cameraFollowUpperPos, float cameraFollowMinDegree, float cameraFollowMaxDegree) {} // 0x0000000182CFB3B0-0x0000000182CFB5D0
	// [XID] // 0x0000000189737FB0-0x0000000189737FD0
	public void ExitAimFocus() {} // 0x0000000182D01500-0x0000000182D015C0
	// [XID] // 0x00000001896CFE90-0x00000001896CFEB0
	public void SetShotExitKeepRotate(bool keep = false /* Metadata: 0x00AEAFAB */) {} // 0x0000000182CF9740-0x0000000182CF98E0
	// [XID] // 0x00000001896D7220-0x00000001896D7240
	public void EnterAttack(EvtCameraLock evt) {} // 0x0000000182CF9390-0x0000000182CF9490
	// [XID] // 0x00000001896DEB10-0x00000001896DEB30
	public void EnterLocking(SCameraLockingData locking) {} // 0x0000000182CFE260-0x0000000182CFE410
	// [XID] // 0x00000001896E5DC0-0x00000001896E5DE0
	public void ExitLocking(SCameraLockingData locking) {} // 0x0000000182CFAAF0-0x0000000182CFABE0
	// [XID] // 0x00000001896ED3B0-0x00000001896ED3D0
	public void EnterDither() {} // 0x0000000182CF8010-0x0000000182CF80B0
	// [XID] // 0x00000001896F4CE0-0x00000001896F4D00
	public void ExitDither() {} // 0x0000000182CF9170-0x0000000182CF9220
	// [XID] // 0x00000001896FC410-0x00000001896FC430
	public void UpdateProtectDither(float value) {} // 0x0000000182CFC110-0x0000000182CFC1E0
	// [XID] // 0x00000001897039C0-0x00000001897039E0
	private void UpdateDither(float deltaTime) {} // 0x0000000182D00730-0x0000000182D00B80
	// [XID] // 0x000000018970B190-0x000000018970B1B0
	private void ResetFrameState() {} // 0x0000000182CF7EB0-0x0000000182CF7F50
	// [XID] // 0x00000001897129D0-0x00000001897129F0
	public void ResetPostParam() {} // 0x0000000182CFBCE0-0x0000000182CFBDD0
	// [XID] // 0x000000018971A2D0-0x000000018971A2F0
	public void ResetCinemachineBrain() {} // 0x0000000182CFABE0-0x0000000182CFAD20
	// [XID] // 0x00000001897215C0-0x00000001897215E0
	public bool IsInAvatarShot() => default; // 0x0000000182CF98E0-0x0000000182CF99A0
	// [XID] // 0x0000000189728C00-0x0000000189728C20
	public void UpdateSpCam() {} // 0x0000000182CFC640-0x0000000182CFCB00
	// [XID] // 0x0000000189730630-0x0000000189730650
	public void EnterKeepSpCamera() {} // 0x0000000182CFCF30-0x0000000182CFD1A0
	// [XID] // 0x0000000189737E10-0x0000000189737E30
	public override void Destroy() {} // 0x0000000182CF92D0-0x0000000182CF9390
	// [XID] // 0x000000018973F980-0x000000018973F9A0
	private void ClearEvent() {} // 0x0000000182CFFAB0-0x0000000182CFFC00
	// [XID] // 0x0000000189746EA0-0x0000000189746EC0
	public void ClearOnConnect() {} // 0x0000000182CF9E60-0x0000000182CF9F00
	// [XID] // 0x000000018974E6F0-0x000000018974E710
	public void ClearOnDisconnect() {} // 0x0000000182D015C0-0x0000000182D01660
	// [XID] // 0x0000000189755D80-0x0000000189755DA0
	public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x0000000182D02A40-0x0000000182D02B30
	// [XID] // 0x000000018975D060-0x000000018975D080
	private bool ShiftWorldOnState(SCameraBaseState state, Vector3 newShift, Vector3 oldShift) => default; // 0x0000000182CF75F0-0x0000000182CF77A0
	// [XID] // 0x0000000189764860-0x0000000189764880
	public void SetQAPos(Vector3 pos) {} // 0x0000000182D01230-0x0000000182D01310
	// [XID] // 0x000000018976C300-0x000000018976C320
	public void SetQAFov(float fov) {} // 0x0000000182CFE0A0-0x0000000182CFE160
	// [XID] // 0x00000001897736A0-0x00000001897736C0
	public float GetFov() => default; // 0x0000000182CFFC00-0x0000000182CFFD10
	// [XID] // 0x000000018977AED0-0x000000018977AEF0
	public void SetQAFoward(Vector3 forward) {} // 0x0000000182CFF7B0-0x0000000182CFF890
	// [XID] // 0x0000000189782AA0-0x0000000189782AC0
	public void ClearQASet() {} // 0x0000000182D01180-0x0000000182D01230
	// [XID] // 0x0000000189789CB0-0x0000000189789CD0
	public void RefreshQA() {} // 0x0000000182CF6910-0x0000000182CF6B40
}

