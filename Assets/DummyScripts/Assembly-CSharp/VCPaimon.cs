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

public sealed class VCPaimon : VCBase // TypeDefIndex: 11925
{
	// Fields
	public ConfigPaimon config; // 0x108
	private VCAnimatorMove _vcMove; // 0x110
	private MoveSmoothedSpeedPlugin _smoothedSpeed; // 0x118
	private VCPaimonAudio _audio; // 0x120
	private float _keepIdleTime; // 0x128
	private float _randomShwovalue; // 0x12C
	private Vector3 _lastAvatarFwd; // 0x130
	private VCBaseSetDitherValue _setDither; // 0x140
	private Transform _rootNode; // 0x148
	private const float XZ_YAW_MIN_RATIO = 1f; // Metadata: 0x00AEAF51
	private const float XZ_YAW_MAX_RATIO = 4f; // Metadata: 0x00AEAF55
	private float _xzByAvatarYawRatio; // 0x150
	private bool _isInAniMove; // 0x154
	private float _randomActionWhenTurnToCamera; // 0x158
	private LCPaimon _lcPaimon; // 0x160
	private CameraEntity _mainCamera; // 0x168
	private EntityTimer _lookAtCameraTimer; // 0x170
	private EntityTimer _freeLookAtTimer; // 0x178
	private EntityTimer _lookAtAvatarTimer; // 0x180
	private EntityTimer _tempOffsetTimer; // 0x188
	private Vector3 _tempOffset; // 0x190
	public const float USINGDITHER_MIN_THRESHOLD = 0.45f; // Metadata: 0x00AEAF59
	public const float USINGDITHER_MAX_THRESHOLD = 0.65f; // Metadata: 0x00AEAF5D

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018978CDF0-0x000000018978CE10 */ get => default; } // 0x0000000184C33960-0x0000000184C33A60 

	// Constructors
	public VCPaimon() {} // 0x0000000184C33880-0x0000000184C33960

	// Methods
	// [XID] // 0x00000001897942C0-0x00000001897942E0
	public override void Init() {} // 0x0000000184C31DD0-0x0000000184C321E0
	// [XID] // 0x00000001897BA7A0-0x00000001897BA7C0
	public override void Destroy() {} // 0x0000000184C318D0-0x0000000184C319E0
	// [XID] // 0x0000000189B83E80-0x0000000189B83EA0
	public override void OnEntityReady() {} // 0x0000000184C33020-0x0000000184C331B0
	// [XID] // 0x00000001897C9D80-0x00000001897C9DA0
	protected override void Tick(float inDeltaTime) {} // 0x0000000184C333E0-0x0000000184C33880
	// [XID] // 0x0000000189B92620-0x0000000189B92640
	private void UpdateSetSpeed(Vector3 tarPoint, float inDeltaTime) {} // 0x0000000184C31360-0x0000000184C318D0
	// [XID] // 0x00000001897EF980-0x00000001897EF9A0
	private void UpdateFwd(AvatarEntity avatar, float inDeltaTime) {} // 0x0000000184C323C0-0x0000000184C32AD0
	// [XID] // 0x000000018981C720-0x000000018981C740
	private void UpdateShow(float inDeltaTime) {} // 0x0000000184C31AE0-0x0000000184C31CB0
	// [XID] // 0x0000000189BA8860-0x0000000189BA8880
	private bool CheckCamera() => default; // 0x0000000184C319E0-0x0000000184C31AE0
	// [XID] // 0x0000000189BAFB60-0x0000000189BAFB80
	private void UpdateSetDitherValue() {} // 0x0000000184C331B0-0x0000000184C333E0
	// [XID] // 0x00000001897B2C70-0x00000001897B2C90
	private void OnAnimatorStateChanged(EvtAnimatorStateChanged evt) {} // 0x0000000184C321E0-0x0000000184C32360
	// [XID] // 0x0000000189BBE8B0-0x0000000189BBE8D0
	public void SetLookAtCamera(bool setLookAt, float time) {} // 0x0000000184C32EB0-0x0000000184C33020
	// [XID] // 0x0000000189832A40-0x0000000189832A60
	public void SetLookAtAvatar(bool setLookAt, float time) {} // 0x0000000184C32D40-0x0000000184C32EB0
	// [XID] // 0x0000000189BCE240-0x0000000189BCE260
	public void SetTempOffset(Vector3 tempOffset, float time) {} // 0x0000000184C30E70-0x0000000184C30FB0
	// [XID] // 0x0000000189BD5570-0x0000000189BD5590
	public void TriggerDisappear() {} // 0x0000000184C32AD0-0x0000000184C32BD0
	// [XID] // 0x00000001896E9190-0x00000001896E91B0
	public void ResetKeepIdleTime() {} // 0x0000000184C32C40-0x0000000184C32CE0
	// [XID] // 0x00000001895E9B60-0x00000001895E9B80
	public Vector3 GetToCameraFwd() => default; // 0x0000000184C31120-0x0000000184C31360
	// [XID] // 0x00000001895F1240-0x00000001895F1260
	public Vector3 GetCurrentOffset() => default; // 0x0000000184C30FB0-0x0000000184C31120
	// [XID] // 0x00000001895F8D60-0x00000001895F8D80
	public void OnDisappearEnd() {} // 0x0000000184C31D30-0x0000000184C31DD0
}

