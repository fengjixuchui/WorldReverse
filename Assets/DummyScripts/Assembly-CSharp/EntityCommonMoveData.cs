/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityCommonMoveData : TaskDataWithLOD, ITaskData, ITaskDataTickable // TypeDefIndex: 26600
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 1; // Metadata: 0x00B0C60C
	private int _uid; // 0x2C
	public float dropGravityAcceleration; // 0x30
	public float maxMoveUphillSlope; // 0x34
	public float maxSlipSpeed; // 0x38
	public float avatarHeight; // 0x3C
	public float avatarRadius; // 0x40
	public float airDistance; // 0x44
	public bool moveOnGround; // 0x48
	public bool moveOnWater; // 0x49
	public float moveOnWaterDepth; // 0x4C
	public FacingMoveType facingMoveType; // 0x50
	public bool canSwim; // 0x54
	public uint entityRuntimeID; // 0x58
	public float npcMoveVelocityRatio; // 0x5C
	public bool isAuthority; // 0x60
	public EntityMoveType moveType; // 0x64
	public float timeScale; // 0x6C
	public bool needSetPos; // 0x70
	public bool needSetRot; // 0x71
	public bool needSetVelocity; // 0x72
	public bool isUsingAnimatorDeltaMode; // 0x73
	public bool isNonAnimatorMode; // 0x74
	public bool isInAir; // 0x75
	public bool isInAirMove; // 0x76
	public bool hasTargetY; // 0x77
	public float targetYCoordinate; // 0x78
	public float currentGroundHeight; // 0x7C
	public float currentCloseToGroundCount; // 0x80
	public float closeToGroundFrequency; // 0x84
	public bool airMoveFollowAnimation; // 0x88
	public bool disableAnimatorTranslation; // 0x89
	public Vector3 extraCloseToGroundVelocity; // 0x8C
	public Vector3 velocityForce; // 0x98
	public uint moveLodValue; // 0xA4
	public Vector3 dampVelocity; // 0xA8
	public int groundHitCnt; // 0xB4
	public bool groundHit; // 0xB8
	public float yawSpeedRatio; // 0xBC
	public bool groundFollowAnimRotation; // 0xC0
	public float groundRotationScale; // 0xC4
	public bool remoteForceUseAnimatorVel; // 0xC8
	public bool canSteerInCurrentState; // 0xC9
	public bool applyGravityInAir; // 0xCA
	public bool enableAirTilt; // 0xCB
	public Vector3 targetPointForTilt; // 0xCC
	public int curStateShortNameHash; // 0xD8
	public int nextStateShortNameHash; // 0xDC
	public int curStateTagHash; // 0xE0
	public bool isAlive; // 0xE4
	public Vector3 smoothSpeed; // 0xE8
	public bool hasStruggle; // 0xF4
	public float gravityScale; // 0xF8
	public bool isHasNegitiveForce; // 0xFC
	public bool isHasFixedRushForceInAir; // 0xFD
	public bool isHasFixedRushForce; // 0xFE
	public bool stopFixedRushForce; // 0xFF
	public Vector3 authorityFixedRushMoveOnGroundSafePos; // 0x100
	public Quaternion bipLocalRotation; // 0x10C
	public TickState interleavedTickState; // 0x11C
	public bool exactMove; // 0x120
	public Vector3 exactMoveTarget; // 0x124
	public int exactMoveArriveCount; // 0x130
	public VCMoveData.MotionFlag exactMoveFlag; // 0x134
	public VCMoveData.MotionFlag curMoveFlag; // 0x138
	public bool isActive; // 0x13C
	public Collider referenceCol; // 0x140
	public VCScenePropAccurateMoveBase referenceSystem; // 0x148
	public bool referenceSystemNewAttached; // 0x150
	public Vector3 referenceDiff; // 0x154
	public int checkRefSysNearCount; // 0x160
	public int checkRefSysNearInterval; // 0x164
	public Vector3 refSysNearPos; // 0x168
	public bool raycastIgnoreDynamic; // 0x174
	public bool canSyncMove; // 0x175
	public Quaternion lastBipRotation; // 0x178
	public bool rotateBip; // 0x188
	public bool setLastBipRotation; // 0x189
	public Vector3 startPosition; // 0x18C
	public Vector3 lastPosition; // 0x198
	public Vector3 lastFramePosition; // 0x1A4
	public Vector3 lastFrameRigidBodyVelocity; // 0x1B0
	public Vector3 position; // 0x1BC
	public Quaternion rotation; // 0x1C8
	public Vector3 rigidBodyVelocity; // 0x1D8
	public Vector3 rigidBodyPosition; // 0x1E4
	public Vector3 animatorVelocity; // 0x1F0
	public Quaternion animatorDeltaRotation; // 0x1FC
	public Vector3 animatorDeltaPosition; // 0x20C
	public Vector3 targetSteerDir; // 0x218
	public Vector3 lastDetectGroundPos; // 0x224
	public Vector3 lastWaterRayRootPosition; // 0x230
	public float lastWaterRayExtraUpDist; // 0x23C
	public Vector3 velClearedByCliff; // 0x240
	public float currTilt; // 0x24C
	public float lastTimeTilt; // 0x250
	public float currentWaterHeight; // 0x254
	public bool waterHit; // 0x258
	public bool isInSlip; // 0x259
	public WaterResult isInWater; // 0x25C
	public bool targetWater; // 0x260
	public float predictWaterHeight; // 0x264
	public float predictGroundHeight; // 0x268
	public bool predictWaterHit; // 0x26C
	public bool predictGroundHit; // 0x26D
	public Vector3 predictWaterPos; // 0x270
	public Vector3 predictGroundPos; // 0x27C
	public Vector3 predictGroundNormal; // 0x288
	public Vector3 predictTargetNormal; // 0x294
	public int returnDirectlyCount; // 0x2A0
	public bool lastFrameStayInPlace; // 0x2A4
	public bool hasPredictTargetY; // 0x2A5
	public float predictTargetYCoordinate; // 0x2A8
	public bool predictTargetWater; // 0x2AC
	public bool syncFirstEnter; // 0x2AD
	public bool syncFirstEnterNeedMove; // 0x2AE
	public bool lastCanSyncMove; // 0x2AF
	public float cannotSyncMoveTime; // 0x2B0
	public Vector3 syncAirMoveVelocity; // 0x2B4
	public Vector3 syncVelocity; // 0x2C0
	public MotionState lastNonStandbyMotion; // 0x2CC
	public PositionModifyState defaultPositionModifyState; // 0x2D0
	public Dictionary<uint, PositionModifyState> positionModifyStateMap; // 0x2D8
	public float currentPoseID; // 0x2E0
	public bool lastIsInAirState; // 0x2E4
	public bool syncWaiting; // 0x2E5
	public MoveSyncTask currentSyncTask; // 0x2E8
	public int colliderInstanceId; // 0x3A4
	public int triangleIndex; // 0x3A8
	public Vector3 groundHitPoint; // 0x3AC
	public bool setHitAir2Drop; // 0x3B8
	public bool setAirDieFlag; // 0x3B9
	public bool setSwimDieFlag; // 0x3BA
	public bool stopRetreatAirTypeVelocityForce; // 0x3BB
	public bool setMotionFlag; // 0x3BC
	public bool setExactMotionFlag; // 0x3BD
	public VCMoveData.MotionFlag curMoveState; // 0x3C0
	public bool SetFaceWithSteerDir; // 0x3C4
	public VCMoveData.MotionDirection motionDir; // 0x3C8
	public bool createCanSyncMoveFirstEnterSyncTask; // 0x3CC
	public bool drownWater; // 0x3CD
	public bool flushGroundHitInfo; // 0x3CE
	public ulong lastSendDrownTime; // 0x3D0
	public bool remoteNeedForceSetPosByCliff; // 0x3D8
	public bool remoteNeedForceSetPosByWater; // 0x3D9
	public Vector3 remoteLastSafePos; // 0x3DC
	public bool remoteForceSetEnable; // 0x3E8
	public Vector3 compensateVel; // 0x3EC
	public float detectVelocitySpeedThreshold; // 0x3F8
	public bool enableDetectRigidbodyVelocity; // 0x3FC
	public bool detectVelocityCalcCapsuleCollder; // 0x3FD
	public float detectVelocityDetectPointLength; // 0x400
	public EntityType entityType; // 0x404
	public Vector3 pushColCenterOffset; // 0x408
	public float pushColCenterHalfHeight; // 0x414
	public float pushColRadius; // 0x418
	public float detectVelocityChange; // 0x41C
	public Vector3 detectVelocityHitPos; // 0x420
	public bool detectVelocitySendEvt; // 0x42C
	public Vector3 detectVelocityLastVelocity; // 0x430
	public float detectVelocityCheckTime; // 0x43C
	public Vector3 detectVelocityVectorScale; // 0x440
	public bool resetIsHitAirFlag; // 0x44C
	public Vector3 detectVelocityRootNodePosition; // 0x450
	public EntityCommonMoveCache cache; // 0x460

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189903830-0x0000000189903850 */ get => default; } // 0x0000000181BF0BE0-0x0000000181BF0D10 
	public int nodeIndex { /* [XID] */ /* 0x000000018990ADA0-0x000000018990ADE0 */ get; /* [XID] */ /* 0x0000000189915750-0x0000000189915790 */ set; } // 0x0000000181BF0E80-0x0000000181BF0EE0 0x0000000181BF1020-0x0000000181BF1080
	public int typeId { /* [XID] */ /* 0x0000000189920000-0x0000000189920020 */ get => default; } // 0x0000000181BF0EE0-0x0000000181BF0F80 
	public int uid { /* [XID] */ /* 0x0000000189B85980-0x0000000189B859A0 */ get => default; } // 0x0000000181BF0F80-0x0000000181BF1020 
	public bool tickable { /* [XID] */ /* 0x0000000189945510-0x0000000189945550 */ get; /* [XID] */ /* 0x000000018994FB70-0x000000018994FBB0 */ set; } // 0x0000000181BF09A0-0x0000000181BF0A00 0x0000000181BF0830-0x0000000181BF0890

	// Constructors
	public EntityCommonMoveData() {} // 0x0000000181BF0E10-0x0000000181BF0E80
	static EntityCommonMoveData() {} // 0x0000000181BF0DB0-0x0000000181BF0E10

	// Methods
	// [XID] // 0x0000000189BDEBA0-0x0000000189BDEBC0
	public void Init() {} // 0x0000000181BF0AC0-0x0000000181BF0B80
	// [XID] // 0x000000018992EFE0-0x000000018992F000
	public void Write() {} // 0x0000000181BF0D10-0x0000000181BF0DB0
	// [XID] // 0x0000000189936410-0x0000000189936430
	public void Free() {} // 0x0000000181BF0A00-0x0000000181BF0AC0
	// [XID] // 0x000000018995A350-0x000000018995A370
	protected override void Clear() {} // 0x0000000181BF0890-0x0000000181BF09A0
}

