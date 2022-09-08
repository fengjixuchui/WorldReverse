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

public class VCMoveData // TypeDefIndex: 32177
{
	// Fields
	public Vector3 targetSteerDir; // 0x18
	public Vector3 turnDirTargetPos; // 0x24
	public MotionDirection motionDir; // 0x30
	public bool rawIsMoving; // 0x34
	public bool isOnTempCollider; // 0x35
	public Vector3 lastSyncAnimAuthorityPosition; // 0x38
	public Vector3 lastSyncAnimRemotePosition; // 0x44
	public Vector3 lastSyncAnimDiff; // 0x50
	public float compensateDuration; // 0x5C
	public Vector3 lastSyncCompensateVel; // 0x60
	public bool exactMove; // 0x6C
	public int exactMoveArriveCount; // 0x70
	public Vector3 exactMoveTarget; // 0x74
	public Vector3 curGroundNormal; // 0x80
	public Vector3 curGroundPos; // 0x8C
	public MoleMole.SceneSurfaceMaterial curGroundSurfaceType; // 0x98
	public float curGroundHitDistance; // 0x9C
	public float curSlope; // 0xA0
	public float curSmoothedGroundHeight; // 0xA4
	public Vector3 curSmoothedGroundNormal; // 0xA8
	public SceneObjTag curGroundColliderTag; // 0xB4
	public float curWaterHeight; // 0xB8
	public float moveWaterHeight; // 0xBC
	public bool isWaterSlope; // 0xC0
	public float waterSlopeAngle; // 0xC4
	public float curWaterFallHeight; // 0xC8
	public Vector3 waterFallNormal; // 0xCC
	public bool isGroundTempCollider; // 0xD8
	public Collider groundHitCollider; // 0xE0
	public bool isInWetness; // 0xE8
	public bool _frozen; // 0xE9
	public bool _tryFreezeCharacter; // 0xEA
	public bool _tryUnfreezeCharacter; // 0xEB
	public AnimationTypeWhenFreeze _animationTypeWhenFreeze; // 0xEC
	public MoveSyncTask currentSyncTask; // 0xF0
	public bool syncWaiting; // 0x1AC
	public bool isInCutSceneMode; // 0x1AD
	public bool stayInPlace; // 0x1AE

	// Properties
	public MotionFlag curMoveState { /* [XID] */ /* 0x00000001899F7BC0-0x00000001899F7C00 */ get; /* [XID] */ /* 0x0000000189A01F90-0x0000000189A01FD0 */ set; } // 0x000000018384B600-0x000000018384B660 0x000000018384B6C0-0x000000018384B720
	public MotionFlag preMoveState { /* [XID] */ /* 0x0000000189A0C660-0x0000000189A0C6A0 */ get; /* [XID] */ /* 0x0000000189A16A40-0x0000000189A16A80 */ set; } // 0x000000018384B660-0x000000018384B6C0 0x000000018384B5A0-0x000000018384B600
	public MoleMole.SceneSurfaceMaterial curSurfaceTypeIncludeWater { /* [XID] */ /* 0x0000000189A210F0-0x0000000189A21110 */ get => default; } // 0x000000018384B720-0x000000018384B7E0 

	// Nested types
	public enum MotionFlag // TypeDefIndex: 32178
	{
		Idle = 0,
		Walk = 1,
		Run = 2,
		Climb = 3,
		ClimbIdle = 4,
		Sprint = 5,
		SwimIdle = 6,
		SwimMove = 7,
		SwimDash = 8,
		CombatAir = 10,
		CrouchIdle = 11,
		CrouchMove = 12,
		LadderIdle = 20,
		LadderMove = 21,
		FreeStyle = 99
	}

	public enum MotionDirection // TypeDefIndex: 32179
	{
		Idle = 0,
		Forward = 1,
		Backward = 2,
		Left = 3,
		Right = 4
	}

	public enum AnimationTypeWhenFreeze // TypeDefIndex: 32180
	{
		MoveKeep = 0,
		MoveToStandby = 1,
		Slip = 2,
		Air = 3,
		Swim = 4
	}

	// Constructors
	public VCMoveData() {} // 0x000000018384B7E0-0x000000018384B880

	// Methods
	// [XID] // 0x0000000189A28640-0x0000000189A28660
	public virtual void Reset() {} // 0x000000018384B430-0x000000018384B5A0
}

