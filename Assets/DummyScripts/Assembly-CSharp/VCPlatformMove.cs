/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCPlatformMove : VCScenePropAccurateMoveBase // TypeDefIndex: 11934
{
	// Fields
	private PlatformRoutePlugin _routePlugin; // 0x228
	private uint initTempRouteTime; // 0x230
	private PlatformInitInfo _platformInfo; // 0x238
	private float _avatarTriggerEventDist; // 0x2A8
	private bool _isMovingWater; // 0x2AC
	private bool _lastFrameAvatarInTriggerRange; // 0x2AD
	private Vector3 _oldRenderPos; // 0x2B0
	private Vector3 _oldPairPos; // 0x2BC
	private float _smoothLerpRatio; // 0x2C8
	private float _smoothLerpThreshold; // 0x2CC
	private float _smoothLerpThresholdMax; // 0x2D0
	private Vector3 _smoothLerpVector; // 0x2D4
	private bool _isLerping; // 0x2E0
	private Rigidbody _rigidbody; // 0x2E8
	private bool _isInitPlatformInfo; // 0x2F0
	private bool _isInitPlatformInfoNull; // 0x2F1
	private PlatformRoute _customRoute; // 0x2F8
	public Queue<PlatformChangeStateEntry> platformChangeStateArray; // 0x300
	public List<PlatformChangeStateEntry> platformChangeStateListFinished; // 0x308
	public uint currentStateChangeTimeStamp; // 0x310
	private LCAbility _ability; // 0x318
	private bool _alreadyLogNoRoute; // 0x320
	private Quaternion quaternion330; // 0x324
	private Quaternion quaternion240; // 0x334
	private Quaternion quaternion150; // 0x344
	private Quaternion quaternion60; // 0x354
	private uint _simulateTime; // 0x364
	private bool _useSimulatedTime; // 0x368
	private int _lastUpdateTime; // 0x36C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189794140-0x0000000189794160 */ get => default; } // 0x0000000184994840-0x00000001849948E0 

	// Constructors
	public VCPlatformMove() {} // 0x0000000184994680-0x0000000184994840

	// Methods
	// [XID] // 0x0000000189693AB0-0x0000000189693AD0
	protected override bool IsTickableForEntityTickManager() => default; // 0x0000000184991200-0x00000001849912B0
	// [XID] // 0x000000018969AED0-0x000000018969AEF0
	public override int GetTickInterval() => default; // 0x0000000184990490-0x0000000184990550
	// [XID] // 0x00000001897AADE0-0x00000001897AAE00
	public override void Init() {} // 0x0000000184990960-0x0000000184991200
	// [XID] // 0x0000000189703B20-0x0000000189703B40
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001849943C0-0x00000001849945C0
	// [XID] // 0x000000018971A420-0x000000018971A440
	private void InitGadgetState() {} // 0x0000000184993460-0x0000000184993590
	// [XID] // 0x00000001896ED4A0-0x00000001896ED4C0
	public void UpdateCustomRoute() {} // 0x00000001849925A0-0x0000000184992870
	// [XID] // 0x00000001897C9BE0-0x00000001897C9C00
	public override void Destroy() {} // 0x000000018498F3E0-0x000000018498F4C0
	// [XID] // 0x00000001897D1250-0x00000001897D1270
	public override void OnEntityReady() {} // 0x0000000184993CA0-0x0000000184993DE0
	// [XID] // 0x00000001897D9290-0x00000001897D92B0
	protected override void Tick(float inDeltaTime) {} // 0x00000001849945C0-0x0000000184994680
	// [XID] // 0x00000001897E0560-0x00000001897E0580
	public void InitPlatformInfo(PlatformInfo platformInfo) {} // 0x000000018498F100-0x000000018498F3E0
	// [XID] // 0x00000001897E7C30-0x00000001897E7C50
	public void ReInitPlatformInfo(PlatformInfo platformInfo) {} // 0x000000018498FFE0-0x0000000184990210
	// [XID] // 0x00000001897EF800-0x00000001897EF820
	public void ReInitPlatformInfoCallback(PlatformInfo platformInfo) {} // 0x00000001849937D0-0x0000000184993B30
	// [XID] // 0x00000001897F6F00-0x00000001897F6F20
	public void ChangePlatformInfo(PlatformInitInfo platformInfo) {} // 0x000000018498ECB0-0x000000018498EED0
	// [XID] // 0x00000001897FE520-0x00000001897FE540
	public void StartPlatformMove(uint sceneTime, PlatformInitInfo platformInfo) {} // 0x0000000184990290-0x0000000184990490
	// [XID] // 0x0000000189805C30-0x0000000189805C50
	public void StopPlatformMove(uint sceneTime, PlatformInitInfo platformInfo) {} // 0x000000018498D890-0x000000018498DA90
	// [XID] // 0x0000000189634CA0-0x0000000189634CC0
	public void DoChangePlatformInfo(PlatformChangeStateEntry entry) {} // 0x0000000184993DE0-0x0000000184994210
	// [XID] // 0x0000000189769290-0x00000001897692B0
	public void DoStartPlatformMove(PlatformChangeStateEntry entry) {} // 0x000000018498F6D0-0x000000018498FF80
	// [XID] // 0x000000018981C620-0x000000018981C640
	public void DoStopPlatformMove(PlatformChangeStateEntry entry) {} // 0x000000018498DB60-0x000000018498E1F0
	// [XID] // 0x0000000189823B60-0x0000000189823B80
	private void FireMovingWaterChangeStateEvent(int routeIndex, bool isStart) {} // 0x00000001849912B0-0x00000001849914D0
	// [XID] // 0x000000018982B4F0-0x000000018982B510
	private uint GetTime(float deltaTime) => default; // 0x000000018498EAD0-0x000000018498EC20
	// [XID] // 0x000000018962D140-0x000000018962D160
	public void HandleItem(PlatformChangeStateEntry item) {} // 0x000000018498F4C0-0x000000018498F6D0
	// [XID] // 0x0000000189839F30-0x0000000189839F50
	public void TickQueue(float deltaTime) {} // 0x00000001849905B0-0x00000001849908E0
	// [XID] // 0x0000000189841460-0x0000000189841480
	public override void CalcMoveState(float inDeltaTime) {} // 0x00000001849928D0-0x0000000184993460
	// [XID] // 0x0000000189832A20-0x0000000189832A40
	public override void MoveColliderToPredictedPositionRotation() {} // 0x000000018498E250-0x000000018498EAD0
	// [XID] // 0x0000000189850200-0x0000000189850220
	public override void MoveColliderImmediately() {} // 0x0000000184992140-0x0000000184992400
	// [XID] // 0x0000000189857440-0x0000000189857460
	public override void OnDisable() {} // 0x0000000184993C00-0x0000000184993CA0
	// [XID] // 0x000000018985E660-0x000000018985E680
	private void CheckAvatarTriggerEvent(bool isStopped) {} // 0x00000001849919D0-0x0000000184992090
	// [XID] // 0x00000001898502C0-0x00000001898502E0
	public override void OnComponentInitFinish(object compData) {} // 0x0000000184993B30-0x0000000184993C00
	// [XID] // 0x000000018986D570-0x000000018986D590
	public void DebugApplyRoute(ConfigRoute currentRoute) {} // 0x0000000184993700-0x00000001849937D0
	// [XID] // 0x00000001898749F0-0x0000000189874A10
	public override bool GetPosAtTime(uint timeStamp, ref Vector3 pos) => default; // 0x00000001849935F0-0x0000000184993700
	// [XID] // 0x0000000189865FD0-0x0000000189865FF0
	public bool TryCalcStateFromQueue(uint timeStamp) => default; // 0x00000001849915B0-0x00000001849918D0
	// [XID] // 0x0000000189883690-0x00000001898836B0
	public override void MonsterOrNPCDetected() {} // 0x0000000184991930-0x00000001849919D0
	// [XID] // 0x00000001898837B0-0x00000001898837D0
	public void RequestStartMove() {} // 0x000000018498D760-0x000000018498D890
	// [XID] // 0x0000000189892280-0x00000001898922A0
	public void RequestReset() {} // 0x0000000184992400-0x0000000184992530
	// [XID] // 0x0000000189ADE5C0-0x0000000189ADE5E0
	public bool IsCurrentActive() => default; // 0x000000018498EED0-0x000000018498EF80
	// [XID] // 0x00000001898A0ED0-0x00000001898A0EF0
	public void DetachAvatarMoveRefSys() {} // 0x000000018498EF80-0x000000018498F100
	// [XID] // 0x0000000189899DF0-0x0000000189899E10
	public bool IsOccupiedByAvatar() => default; // 0x0000000184994210-0x00000001849943C0
	// [XID] // 0x00000001898B00F0-0x00000001898B0110
	public void NewRoute(Route route) {} // 0x0000000184992090-0x0000000184992140
}

