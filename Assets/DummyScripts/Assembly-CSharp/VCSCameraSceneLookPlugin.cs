/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCSCameraSceneLookPlugin : BaseComponentPlugin // TypeDefIndex: 12169
{
	// Fields
	private const string DEFAULT_LOOK_SHOT_NAME = "CameraSceneLookGroup"; // Metadata: 0x00AEB6E9
	private CinemachineBrain _brain; // 0x58
	private MonoCameraSceneLookHelper _cameraSceneLookSet; // 0x60
	private Transform _targetAnchor; // 0x68
	private Transform _followTrans; // 0x70
	private Vector3 _targetPos; // 0x78
	private Transform _targetTrans; // 0x88
	private float _duration; // 0x90
	private bool _forceLook; // 0x94
	private Vector3 _offset; // 0x98
	private bool _setFollow; // 0xA4
	private Vector3 _initFollowPos; // 0xA8
	private bool _forceWalk; // 0xB4
	private bool _changePlayMode; // 0xB5
	private bool _setScreen; // 0xB6
	private float _initScreenX; // 0xB8
	private float _initScreenY; // 0xBC
	private float _screenX; // 0xC0
	private float _screenY; // 0xC4
	private bool _lockOnAvatarChange; // 0xC8
	private bool _lockOnTeamChange; // 0xC9
	private bool _isRunning; // 0xCA
	private float _timeCnt; // 0xCC
	private VCStackCamera _vcStackCamera; // 0xD0
	private SCameraShotTask _shotTask; // 0xD8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189AE8990-0x0000000189AE89B0 */ get => default; } // 0x00000001845DDA30-0x00000001845DDAD0 
	private Vector3 targetPos { /* [XID] */ /* 0x0000000189AF0820-0x0000000189AF0840 */ get => default; } // 0x00000001845DCFF0-0x00000001845DD190 
	public bool IsLockOnAvatarChange { /* [XID] */ /* 0x0000000189AF7D50-0x0000000189AF7D70 */ get => default; } // 0x00000001845DC3D0-0x00000001845DC480 
	public bool IsLockOnTeamChange { /* [XID] */ /* 0x0000000189AFF390-0x0000000189AFF3B0 */ get => default; } // 0x00000001845DCF40-0x00000001845DCFF0 
	public bool IsRunning { /* [XID] */ /* 0x0000000189B06B10-0x0000000189B06B30 */ get => default; } // 0x00000001845DBBC0-0x00000001845DBC70 
	private bool IsSceneLookValid { /* [XID] */ /* 0x0000000189B3A8E0-0x0000000189B3A900 */ get => default; } // 0x00000001845DCCA0-0x00000001845DCD70 

	// Constructors
	public VCSCameraSceneLookPlugin() {} // 0x00000001845DD8D0-0x00000001845DDA30

	// Methods
	// [XID] // 0x0000000189B0E3B0-0x0000000189B0E3D0
	public override void Init() {} // 0x00000001845DCB90-0x00000001845DCCA0
	// [XID] // 0x0000000189B15550-0x0000000189B15570
	private void InitCameraSet() {} // 0x00000001845DD200-0x00000001845DD380
	// [XID] // 0x0000000189B1CFF0-0x0000000189B1D010
	private void InitCameraSetInternal(GameObject shotInst) {} // 0x00000001845DD4E0-0x00000001845DD7F0
	// [XID] // 0x0000000189B24540-0x0000000189B24560
	public void EnterSceneLook(Vector3 targetPos, Transform targetTrans, float offsetY, float duration, bool forceLook, bool recoverKeepCurrent, bool setFollow, Vector3 followPos, bool forceWalk, bool changePlayMode, bool setScreenXY, float screenX, float screenY) {} // 0x00000001845DC480-0x00000001845DC9A0
	// [XID] // 0x0000000189B2BA20-0x0000000189B2BA40
	public void InterruptSceneLook() {} // 0x00000001845DC2A0-0x00000001845DC350
	// [XID] // 0x0000000189B32E90-0x0000000189B32EB0
	public void ExitSceneLook() {} // 0x00000001845DD380-0x00000001845DD4E0
	// [XID] // 0x0000000189B421D0-0x0000000189B421F0
	public override void Tick(float deltaTime) {} // 0x00000001845DD7F0-0x00000001845DD8D0
	// [XID] // 0x0000000189B49BF0-0x0000000189B49C10
	private void SetSceneLookPos() {} // 0x00000001845DC9A0-0x00000001845DCB90
	// [XID] // 0x0000000189B512F0-0x0000000189B51310
	private void TickTask(float deltaTime) {} // 0x00000001845DBE40-0x00000001845DC0F0
	// [XID] // 0x0000000189B58C80-0x0000000189B58CA0
	private void ChangeWalkMode(bool on) {} // 0x00000001845DC0F0-0x00000001845DC2A0
	// [XID] // 0x0000000189B79730-0x0000000189B79750
	private void ChangePlayMode(bool on) {} // 0x00000001845DCD70-0x00000001845DCF40
	// [XID] // 0x0000000189A9D380-0x0000000189A9D3A0
	private void ChangeScreenXY(bool on) {} // 0x00000001845DBC70-0x00000001845DBE40
}

