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

public class VCSimpleMove : VCNonHumanoidMoveBase // TypeDefIndex: 11958
{
	// Fields
	public float walkMoveSpeed; // 0x310
	public float runMoveSpeed; // 0x314
	private float _lastGravitySpeed; // 0x318
	protected bool _lastIsMoving; // 0x31C
	protected Vector3 _lastFrameFinalPos; // 0x320
	protected Vector3 _lastSyncPos; // 0x32C
	protected Vector3 _lastFindGroundPos; // 0x338
	protected float _lastSyncTime; // 0x344
	protected const float SYNC_INTERVAL = 10f; // Metadata: 0x00AEAF86
	protected const float FORCE_SYNC_INTERVAL = 20f; // Metadata: 0x00AEAF8A
	private MotionInfo _motionInfo; // 0x348
	protected LevelMoveScenePropPlugin _scenePropPlugin; // 0x350
	protected Collider _groundHitCollider; // 0x358
	private bool _followReferenceSys; // 0x360

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018989C950-0x000000018989C970 */ get => default; } // 0x0000000182565520-0x00000001825655C0 
	public LevelMoveScenePropPlugin scenePropPlugin { /* [XID] */ /* 0x00000001896E5E20-0x00000001896E5E40 */ get => default; } // 0x0000000182562520-0x00000001825626B0 

	// Constructors
	public VCSimpleMove() {} // 0x00000001825654A0-0x0000000182565520

	// Methods
	// [XID] // 0x00000001898AB3A0-0x00000001898AB3C0
	public override void Init() {} // 0x0000000182563E50-0x0000000182564270
	// [XID] // 0x000000018999C1F0-0x000000018999C210
	protected override void InitMoveComponent() {} // 0x00000001825647A0-0x0000000182564890
	// [XID] // 0x00000001896FC530-0x00000001896FC550
	protected override void LateTick(float inDeltaTime) {} // 0x0000000182564890-0x0000000182564E20
	// [XID] // 0x00000001898C1D10-0x00000001898C1D30
	protected virtual void SendSimpleMovePacket() {} // 0x00000001825626B0-0x0000000182562CA0
	// [XID] // 0x0000000189B22EB0-0x0000000189B22ED0
	protected override void CloseToGround(float deltaTime) {} // 0x0000000182565200-0x00000001825654A0
	// [XID] // 0x00000001898D0FE0-0x00000001898D1000
	public override void Destroy() {} // 0x0000000182562410-0x00000001825624C0
	// [XID] // 0x00000001898D85A0-0x00000001898D85C0
	protected override void CheckIsInAir() {} // 0x0000000182563AF0-0x0000000182563C30
	// [XID] // 0x0000000189A748E0-0x0000000189A74900
	protected override void CalcCurrentGroundHeight() {} // 0x0000000182563430-0x0000000182563AF0
	// [XID] // 0x0000000189A7C3A0-0x0000000189A7C3C0
	protected override void CheckIsFallOnGround(float deltaTime) {} // 0x0000000182563C30-0x0000000182563D70
	// [XID] // 0x00000001897DEC20-0x00000001897DEC40
	protected bool HasMoveInput() => default; // 0x0000000182563D70-0x0000000182563E50
	// [XID] // 0x00000001897D76D0-0x00000001897D76F0
	protected Vector3 GetMoveInputDir() => default; // 0x0000000182564550-0x0000000182564720
	// [XID] // 0x00000001898FE660-0x00000001898FE680
	protected float GetMoveSpeed() => default; // 0x0000000182564460-0x0000000182564550
	// [XID] // 0x0000000189905D80-0x0000000189905DA0
	public override Vector3 GetMoveVelocity() => default; // 0x0000000182563220-0x0000000182563430
	// [XID] // 0x0000000189A8B7A0-0x0000000189A8B7C0
	public override void AddVelocity(VelocityForceType velocityType, Vector3 velocity, float time = 0f /* Metadata: 0x00AEAF82 */) {} // 0x0000000182562EF0-0x0000000182563220
	// [XID] // 0x000000018970B250-0x000000018970B270
	public virtual void OnAnimatorMove(float deltaTime) {} // 0x0000000182562100-0x0000000182562410
	// [XID] // 0x0000000189A92D60-0x0000000189A92D80
	public override void OnDisable() {} // 0x0000000182565160-0x0000000182565200
	// [XID] // 0x00000001899243D0-0x00000001899243F0
	protected Vector3 MoveFollowReferenceSystem() => default; // 0x0000000182562D00-0x0000000182562EF0
	// [XID] // 0x000000018992B800-0x000000018992B820
	protected void CheckGroundReferenceSystem() {} // 0x0000000182564E90-0x00000001825650D0
}

