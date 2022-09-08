/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBulletMove : VCBaseMove // TypeDefIndex: 11832
{
	// Fields
	protected Rigidbody _rigidBody; // 0x1D8
	protected float _moveDistance; // 0x1E0
	protected Vector3 _lastPosition; // 0x1E4
	protected Vector3 _velocity; // 0x1F0
	protected float _angularVelocity; // 0x1FC
	protected float _delay; // 0x200
	protected float _maxSpeed; // 0x204
	protected float _minSpeed; // 0x208
	protected bool _checkBornInWater; // 0x20C
	protected bool _canBornInWater; // 0x20D
	protected float _acceleration; // 0x210
	protected float _accelerationTime; // 0x214
	protected bool _bornWithChesed; // 0x218
	protected BaseEntityHandle _chasedEntity; // 0x228
	protected Transform _chasedTrans; // 0x238
	protected bool _traceOnYAxis; // 0x240
	protected bool _destroyWhenTargetDie; // 0x241
	protected bool _isSafeDestroied; // 0x242
	protected bool _isSyncToRemote; // 0x243
	protected const float SYNC_INTERVAL = 0.1f; // Metadata: 0x00AEACD5
	protected float _lastSyncToRemoteTime; // 0x244
	protected UpdateAngleType _updateAngleType; // 0x248
	protected float _traceLerpCoef; // 0x24C
	protected Vector3 _transRotateAngluarVelocity; // 0x250
	protected Vector3 _localAngle; // 0x25C
	protected MoveStickToGroundPlugin _stickToGroundPlugin; // 0x268
	protected LCAbilityState _lcAblityState; // 0x270
	protected LCAbility _lcAbility; // 0x278
	private float _moveSpeedRatio; // 0x280
	private float _angularVelocityAddRatio; // 0x284
	protected float _surroundRadiusAddRatio; // 0x288
	public Vector3 remoteTargetPos; // 0x28C

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189AE5EE0-0x0000000189AE5F00 */ get => default; } // 0x0000000181C52330-0x0000000181C523D0 
	public float angularVelocity { /* [XID] */ /* 0x0000000189AED310-0x0000000189AED330 */ get => default; /* [XID] */ /* 0x0000000189B87070-0x0000000189B87090 */ set {} } // 0x0000000181C4ED60-0x0000000181C4EE20 0x0000000181C4F1A0-0x0000000181C4F250
	public uint chasedTargetRuntimeID { /* [XID] */ /* 0x0000000189AFC300-0x0000000189AFC340 */ get; /* [XID] */ /* 0x0000000189B06BB0-0x0000000189B06BF0 */ set; } // 0x0000000181C50920-0x0000000181C50980 0x0000000181C50150-0x0000000181C501C0
	public uint chasedTargetLockPointIndex { /* [XID] */ /* 0x0000000189B11600-0x0000000189B11640 */ get; /* [XID] */ /* 0x0000000189B1B810-0x0000000189B1B850 */ set; } // 0x0000000181C51EB0-0x0000000181C51F10 0x0000000181C51F10-0x0000000181C51F80

	// Nested types
	public enum UpdateAngleType // TypeDefIndex: 11833
	{
		None = 0,
		ByVelocity = 1,
		Rotating = 2
	}

	// Constructors
	public VCBulletMove() {} // 0x0000000181C521F0-0x0000000181C52330

	// Methods
	// [XID] // 0x0000000189B25E40-0x0000000189B25E60
	public override void Init() {} // 0x0000000181C50B70-0x0000000181C50D20
	// [XID] // 0x0000000189BAB9B0-0x0000000189BAB9D0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000181C51F80-0x0000000181C52130
	// [XID] // 0x0000000189BB2E70-0x0000000189BB2E90
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000181C4EFF0-0x0000000181C4F140
	// [XID] // 0x0000000189BBA400-0x0000000189BBA420
	public override void Destroy() {} // 0x0000000181C4FC00-0x0000000181C4FD40
	// [XID] // 0x0000000189BC23E0-0x0000000189BC2400
	protected override void Tick(float inDeltaTime) {} // 0x0000000181C52130-0x0000000181C521F0
	// [XID] // 0x0000000189B4B060-0x0000000189B4B080
	private void InitAbilityPropertyCallback() {} // 0x0000000181C4F250-0x0000000181C4F4E0
	// [XID] // 0x0000000189B528E0-0x0000000189B52900
	protected override void SyncAnimatorMoveSpeed() {} // 0x0000000181C4E720-0x0000000181C4EB90
	// [XID] // 0x0000000189B9CC30-0x0000000189B9CC50
	protected void SyncAngularVelocity() {} // 0x0000000181C50A60-0x0000000181C50B70
	// [XID] // 0x0000000189BA43A0-0x0000000189BA43C0
	protected void SyncSurroundRadius() {} // 0x0000000181C4DF60-0x0000000181C4E070
	// [XID] // 0x0000000189B69350-0x0000000189B69370
	protected virtual void InitBulletData() {} // 0x0000000181C50EB0-0x0000000181C51460
	// [XID] // 0x000000018960ADE0-0x000000018960AE00
	protected void InitUpdateAngle(ConfigBulletMoveAngle angleConfig) {} // 0x0000000181C51CA0-0x0000000181C51EB0
	// [XID] // 0x0000000189BC99F0-0x0000000189BC9A10
	private void UpdateBulletMove(float deltaTime) {} // 0x0000000181C4FA00-0x0000000181C4FC00
	// [XID] // 0x0000000189BD1130-0x0000000189BD1150
	private void AuthorityUpdateBulletMove(float deltaTime) {} // 0x0000000181C4FD40-0x0000000181C500D0
	// [XID] // 0x0000000189B86EB0-0x0000000189B86ED0
	private void RemoteUpdateBulletMove(float deltaTime) {} // 0x0000000181C51560-0x0000000181C519E0
	// [XID] // 0x0000000189A83DA0-0x0000000189A83DC0
	private void UpdateBulletVelocity() {} // 0x0000000181C4F4E0-0x0000000181C4FA00
	// [XID] // 0x0000000189B954C0-0x0000000189B954E0
	private void UpdateBulletAngle(float deltaTime) {} // 0x0000000181C50480-0x0000000181C50920
	// [XID] // 0x0000000189B9CB50-0x0000000189B9CB70
	protected virtual void CalculateVelocity(BaseEntityHandle targetHandle, Transform tarTrans, Vector3 curPos, float moveDist, float acceleration, float accelerationTime, float deltaTime, ref Vector3 velocity) {} // 0x0000000181C4E140-0x0000000181C4E720
	// [XID] // 0x0000000189BA4200-0x0000000189BA4220
	public override Vector3 GetMoveVelocity() => default; // 0x0000000181C50980-0x0000000181C50A60
	// [XID] // 0x0000000189BAB810-0x0000000189BAB830
	public override void AddVelocity(VelocityForceType velocityType, Vector3 velocity, float time = 0f /* Metadata: 0x00AEACD1 */) {} // 0x0000000181C50320-0x0000000181C50480
	// [XID] // 0x0000000189BD87F0-0x0000000189BD8810
	private bool IsUnderWater() => default; // 0x0000000181C4DD10-0x0000000181C4DF60
	// [XID] // 0x0000000189BBA140-0x0000000189BBA160
	private void SafeDestroy() {} // 0x0000000181C4EE20-0x0000000181C4EFF0
	// [XID] // 0x0000000189A74920-0x0000000189A74940
	protected static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000181C50240-0x0000000181C50320
	// [XID] // 0x0000000189BC9810-0x0000000189BC9830
	protected override bool ListenEvent(BaseEvent e) => default; // 0x0000000181C51460-0x0000000181C51560
	// [XID] // 0x0000000189BD0FD0-0x0000000189BD0FF0
	protected bool OnEvtAvatarChanged(EvtAvatarChanged evt) => default; // 0x0000000181C4EB90-0x0000000181C4ED60
	// [XID] // 0x0000000189BD8600-0x0000000189BD8620
	public override void ResetTarget(uint targetRuntimeID, uint targetLockPointIndex) {} // 0x0000000181C51B50-0x0000000181C51CA0
}

