/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using miHoYoCamera;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SCameraStateBaseRunner<CameraStateType> : BaseCameraStateRunner<CameraStateType>, ISCameraRunner // TypeDefIndex: 32061
	where CameraStateType : SCameraBaseState
{
	// Fields
	protected List<SCameraCmd> _cmdList;
	private const string POINT_CAMERA_LOOK = "CameraLook"; // Metadata: 0x00B13C10
	private const string POINT_MOVE_HEAD = "MoveHead"; // Metadata: 0x00B13C1E
	protected bool _avatarFrameDirty;
	protected bool _avatarHeightDirty;
	protected PipelineCameraGlobalConfig _globalConfig;
	protected List<SCameraModuleBase> _modules;
	protected CameraShareData _data;
	protected CameraAvatarInfoData _avatarInfoData;
	protected CameraOutputData _outputData;
	[ReadOnly] // 0x0000000189727BD0-0x0000000189727BE0
	protected CameraAvatarPrepareData _avatarPrepareData;
	protected LCAIManager _aiMgr;

	// Properties
	public CameraShareData shareData { get => default; }
	public CameraAvatarInfoData avatarInfoData { get => default; }
	public double zoomVelocity { get => default; }

	// Constructors
	public SCameraStateBaseRunner() {}

	// Methods
	public void AddCmd(SCameraCmd cmd) {}
	public void HandleCmd() {}
	public void HandleSingleCmd(ref SCameraCmd cmd) {}
	protected void HandleCmdInternal(ref SCameraCmd cmd) {}
	protected virtual void HandleRotateCmd(ref SCameraCmd cmd) {}
	protected virtual void HandleZoomCmd(ref SCameraCmd cmd) {}
	protected virtual void HandleResetBackward(ref SCameraCmd cmd) {}
	protected virtual void HandleLerpBackward(ref SCameraCmd cmd) {}
	protected virtual void HandleInitBackward(ref SCameraCmd cmd) {}
	protected virtual void HandleSetKeepRotation(ref SCameraCmd cmd) {}
	protected virtual void HandleClearFilter(ref SCameraCmd cmd) {}
	protected virtual void HandleSetFov(ref SCameraCmd cmd) {}
	protected virtual void HandleShiftCmd(ref SCameraCmd cmd) {}
	protected virtual void HandleMoveCmd(ref SCameraCmd cmd) {}
	protected virtual void HandleSetRefAnchorPosition(ref SCameraCmd cmd) {}
	protected virtual void HandleSetCameraPosition(ref SCameraCmd cmd) {}
	protected virtual void HandleSetClampRotatePitch(ref SCameraCmd cmd) {}
	protected virtual void HandleSetClampZoomScale(ref SCameraCmd cmd) {}
	protected virtual void HandleSetCanFreeMove(ref SCameraCmd cmd) {}
	protected virtual void HandleMoveRotateVertically(ref SCameraCmd cmd) {}
	public void SetCameraShareData(ref CameraShareData shareData) {}
	public void SetCameraAvatarInfoData(ref CameraAvatarInfoData avatarInfoData) {}
	public void SetCameraAvatarPrepareData(CameraAvatarPrepareData avatarPrepareData) {}
	public void RefreshCameraAvatarInfo() {}
	public void UpdateCameraShareDataByPostData(ref SCameraPostData postData) {}
	public void SwitchBackground(bool value) {}
	public virtual void OnSpawn() {}
	public virtual void OnUnSpawn() {}
	public virtual void OnBlendToStart() {}
	public virtual void OnBlendFromStart() {}
	public virtual void OnBlendToFinished() {}
	public virtual void OnBlendFromFinished() {}
	protected override void InitInternal() {}
	protected virtual void InitModules() {}
	protected ModuleType AddModule<ModuleType>(CameraProfile profile)
		where ModuleType : SCameraModuleBase, new() => default;
	private bool IsAvatarActive() => default;
	protected void RefreshAvatarInfoData() {}
	protected void InitAvatarInfoData() {}
	protected void RefreshAvatarPos() {}
	protected void RefreshAvatarHeight() {}
	protected void RefreshCameraLookHeight() {}
	protected void RefreshEnemyInfo() {}
	protected override void StartInternal() {}
	protected override void CollectPreInternal() {}
	protected override void CollectInternal(float deltaTime) {}
	public override void Tick(float deltaTime) {}
	protected override void TickInternal(float deltaTime) {}
	protected override void FlushInternal(float deltaTime) {}
	protected override void PostFlushTopInternal() {}
	public override void Dispose() {}
	public virtual void ClearOnDisconnect() {}
	public virtual bool ShiftWorld(Vector3d newShift, Vector3d oldShift) => default;
}

