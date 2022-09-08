/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCAvatarFocus : VCBase // TypeDefIndex: 11794
{
	// Fields
	private LCAvatarShoot _lcShoot; // 0x108
	private VCBaseInputController _vcInputController; // 0x110
	private VCHumanoidMove _vcMove; // 0x118
	private CameraEntity _cameraEntity; // 0x120
	private VCStackCamera _vcStackCamera; // 0x128
	public bool changeMainSkillID; // 0x131
	private AimWalkPlugin _aimWalkPlugin; // 0x138
	private const string FOCUS_ANCHOR_NAME = "FocusAnchor"; // Metadata: 0x00AEAB8F
	private Transform _focusAnchor; // 0x140
	private float _focusAnchorHorAngle; // 0x148
	private float _focusAnchorVerAngle; // 0x14C
	private Animator _animator; // 0x150
	private const string AIM_LAYER_NAME = "AimLayer"; // Metadata: 0x00AEAB9E
	private int _aimLayerIndex; // 0x158
	private const float AIM_LAYER_WEIGHT_SPD = 10f; // Metadata: 0x00AEABAA
	private Vector3 _focusForwardNorm; // 0x15C
	private bool _useFocusSticky; // 0x168
	private bool _disableAnim; // 0x169
	private bool _gyroSupported; // 0x16A
	private bool _useGyro; // 0x16B
	private Quaternion _lastGyroAttitude; // 0x16C
	private string _dragBtnName; // 0x180
	private bool _enableFocusAcceleration; // 0x188
	private float _focusAccelerationScale; // 0x18C
	private float _lastVelocityX; // 0x190
	private float _lastVelocityY; // 0x194
	private TouchpadFocusAccelerationSigmoidPara _sigmoidPara; // 0x198
	private const float SYNC_INTERVAL = 0.1f; // Metadata: 0x00AEABAE
	private float _lastSendToRemoteTime; // 0x1A0
	private Vector3 _remoteTargetFocusForward; // 0x1A4
	private bool _remoteStartLerp; // 0x1B0
	private float _remoteStartLerpTime; // 0x1B4
	private const float REMOTE_LERP_FORWARD_TOTAL_TIME = 0.1f; // Metadata: 0x00AEABB2

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B2E840-0x0000000189B2E860 */ get => default; } // 0x0000000181308160-0x0000000181308200 
	public bool isFocusing { /* [XID] */ /* 0x0000000189B35EF0-0x0000000189B35F30 */ get; /* [XID] */ /* 0x0000000189B40970-0x0000000189B409B0 */ private set; } // 0x00000001813076D0-0x0000000181307730 0x0000000181307660-0x00000001813076D0

	// Constructors
	public VCAvatarFocus() {} // 0x0000000181308050-0x0000000181308160

	// Methods
	// [XID] // 0x0000000189B72340-0x0000000189B72360
	public override void Init() {} // 0x00000001813065D0-0x00000001813068E0
	// [XID] // 0x0000000189950E30-0x0000000189950E50
	protected override void Tick(float inDeltaTime) {} // 0x0000000181307EC0-0x0000000181308050
	// [XID] // 0x0000000189B5A300-0x0000000189B5A320
	public override void OnDisable() {} // 0x0000000181307C90-0x0000000181307D40
	// [XID] // 0x0000000189B617A0-0x0000000189B617C0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000181306500-0x00000001813065D0
	// [XID] // 0x0000000189B69390-0x0000000189B693B0
	protected override bool OnEvent(BaseEvent evt) => default; // 0x0000000181307D40-0x0000000181307EC0
	// [XID] // 0x0000000189B70830-0x0000000189B70850
	private void CommonEnterFocus(bool useFocusSticky, bool useAutoFocus, bool useGyro, Vector3 focusForward, bool disableAnim) {} // 0x00000001813040D0-0x00000001813043B0
	// [XID] // 0x0000000189B3D6E0-0x0000000189B3D700
	private void AuthEnterFocus(EvtAvatarEnterFocus evtEnterFocus) {} // 0x0000000181304AD0-0x0000000181305540
	// [XID] // 0x0000000189664870-0x0000000189664890
	public void RemoteEnterFocus(bool useFocusSticky, bool useAutoFocus, bool useGyro, Vector3 focusForwardNorm, bool disableAnim) {} // 0x0000000181306320-0x0000000181306500
	// [XID] // 0x0000000189B86EF0-0x0000000189B86F10
	private void CommonExitFocus(Vector3 finishForward) {} // 0x0000000181307A20-0x0000000181307BA0
	// [XID] // 0x0000000189B8E080-0x0000000189B8E0A0
	private void AuthExitFocus(EvtAvatarExitFocus evt = null) {} // 0x0000000181304570-0x0000000181304AD0
	// [XID] // 0x00000001897410C0-0x00000001897410E0
	public void RemoteExitFocus(Vector3 finishForward) {} // 0x0000000181304410-0x0000000181304570
	// [XID] // 0x0000000189B9CB70-0x0000000189B9CB90
	private void CommonUpdateFocus() {} // 0x0000000181307730-0x0000000181307930
	// [XID] // 0x0000000189BA4220-0x0000000189BA4240
	private void AuthUpdateFocusForward(float deltaTime) {} // 0x00000001813068E0-0x0000000181307660
	// [XID] // 0x0000000189BAB830-0x0000000189BAB850
	private void RemoteUpdateFocusForward(float deltaTime) {} // 0x0000000181306010-0x0000000181306240
	// [XID] // 0x0000000189BB2DB0-0x0000000189BB2DD0
	private void UpdateState(float deltaTime) {} // 0x0000000181305540-0x0000000181305BE0
	// [XID] // 0x00000001896559F0-0x0000000189655A10
	public void UpdateStateWhenShoot() {} // 0x0000000181305BE0-0x0000000181306010
	// [XID] // 0x0000000189BAFD40-0x0000000189BAFD60
	public void RemoteSetTargetFocusForward(Vector3 focusForward) {} // 0x0000000181307BA0-0x0000000181307C90
}

