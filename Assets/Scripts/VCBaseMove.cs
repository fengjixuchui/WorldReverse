/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VCBaseMove : VCBase // TypeDefIndex: 11823
{
	// Fields
	protected VCMoveData _moveData; // 0x108
	public VCScenePropAccurateMoveBase referenceSystem; // 0x118
	public uint referenceSystemId; // 0x120
	public Vector3 curLocalPositionRS; // 0x124
	public Vector3 lastLocalPositionRS; // 0x130
	public bool curRS; // 0x13C
	public bool lastRS; // 0x13D
	public Vector3 lateTickStartPosition; // 0x140
	public Collider referenceCol; // 0x150
	public bool referenceSystemNewAttached; // 0x158
	protected Transform _transform; // 0x160
	public ControlData controlData; // 0x168
	public Action onFallOnGround; // 0x170
	public float dropGravityAcceleration = 9.81f; // 0x178
	protected float _gravityScale; // 0x17C
	private static readonly int[] _headFreeStyle; // 0x00
	protected VCMoveCollider _moveCollider; // 0x188
	private bool _moveColliderEnable = true; // 0x190
	protected VelocityDetectPlugin _velocityDetect; // 0x198
	private Dictionary<int, bool> _animatorParamCache; // 0x1A8
	protected MoveVelocityForcePlugin _velocityForceMove; // 0x1B0
	private Vector3 _currentVelocityForce; // 0x1B8
	private int _lastGetVelocityForceFrame = -1; // 0x1C4
	protected bool _keepInAirVelocityForce; // 0x1C8
	public BaseMoveSyncPlugin syncPlugin; // 0x1D0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899495B0-0x00000001899495D0 */ get => VCBaseComponentTypeIDs.VCBaseMove; } // 0x0000000183B42F80-0x0000000183B43020 
	public ConfigMove configMove { /* [XID] */ /* 0x0000000189845E10-0x0000000189845E50 */ get; /* [XID] */ /* 0x0000000189850220-0x0000000189850260 */ set; } // 0x0000000183B40C30-0x0000000183B40C90 0x0000000183B3E110-0x0000000183B3E180
	public bool needFaceToAnimParam { /* [XID] */ /* 0x000000018987B080-0x000000018987B0C0 */ get; /* [XID] */ /* 0x00000001898704B0-0x00000001898704F0 */ set; } // 0x0000000183B3DD40-0x0000000183B3DDA0 0x0000000183B3FC50-0x0000000183B3FCC0
	public bool IsInAirflowAcc { /* [XID] */ /* 0x00000001899E3F20-0x00000001899E3F60 */ get; /* [XID] */ /* 0x00000001899EE550-0x00000001899EE590 */ set; } // 0x0000000183B3F5F0-0x0000000183B3F650 0x0000000183B40B20-0x0000000183B40B90
	public MoveVelocityForcePlugin VelocityForceMove { /* [XID] */ /* 0x0000000189A8B840-0x0000000189A8B860 */ get => _velocityForceMove; /* [XID] */ /* 0x00000001896169F0-0x0000000189616A10 */ set => _velocityForceMove = value; } // 0x0000000183B410F0-0x0000000183B411A0 0x0000000183B40C90-0x0000000183B40D40
	public virtual bool KeepInAirVelocityForce { /* [XID] */ /* 0x0000000189B1FED0-0x0000000189B1FEF0 */ get => _keepInAirVelocityForce; /* [XID] */ /* 0x0000000189B00CB0-0x0000000189B00CD0 */ set => _keepInAirVelocityForce = value; } // 0x0000000183B42ED0-0x0000000183B42F80 0x0000000183B43020-0x0000000183B430D0

	// Nested types
	public enum BaseMoveState // TypeDefIndex: 11824
	{
		Undefined = 0,
		Move = 1,
		Climb = 2,
		Air = 3,
		Fly = 4,
		Combat = 5,
		Swim = 6,
		SwimJump = 7,
		Else = 8
	}

	// Methods
	// [XID] // 0x000000018985A860-0x000000018985A880
	public void SetLastLocalPositionRS() 
	{
		lastRS = curRS;
		lastLocalPositionRS.x = curLocalPositionRS.x;
		lastLocalPositionRS.z = curLocalPositionRS.z;
		curRS = referenceSystem != null;
		Vector3 originPos = _transform.position;
		Vector3 relativePos = Vector3.zero;
		if (curRS)
		{
			BaseEntity refEntity = referenceSystem.GetEntity();
			relativePos = refEntity.GetRelativePosition();
		}
		curLocalPositionRS = originPos - relativePos;
	} // 0x0000000183B407F0-0x0000000183B40A20
	  // [XID] // 0x00000001898618B0-0x00000001898618D0
	public void ClearReferenceSystem() 
	{
		referenceSystemId = 0;
		referenceSystem = null;
		referenceCol = null;
	} // 0x0000000183B3E5C0-0x0000000183B3E670
	// [XID] // 0x00000001898691F0-0x0000000189869210
	protected bool IsInHeadFreeStyle(int freeStyleType) => ExtensionMethods.Contains(_headFreeStyle,freeStyleType); // 0x0000000183B3E220-0x0000000183B3E320
	// [XID] // 0x000000018971E980-0x000000018971E9A0
	public VCMoveCollider GetMoveCollider() => _moveCollider; // 0x0000000183B40E40-0x0000000183B40EF0
	// [XID] // 0x0000000189866050-0x0000000189866070
	public void SetMoveColEnabled(bool enable) 
	{
		_moveColliderEnable = enable;
		RefreshMoveColEnable();
	} // 0x0000000183B40670-0x0000000183B40730
	// [XID] // 0x000000018986D7C0-0x000000018986D7E0
	protected void RefreshMoveColEnable() 
	{
		_moveCollider.SetMoveColEnabled(_moveColliderEnable);
	} // 0x0000000183B3FCC0-0x0000000183B3FD80
	// [XID] // 0x000000018989B350-0x000000018989B370
	public virtual void EnableCrashDamage(bool enable) 
	{
		_velocityDetect.EnableCrashDamage(enable);
	} // 0x0000000183B3F3C0-0x0000000183B3F480
	// [XID] // 0x00000001898A2790-0x00000001898A27B0
	public virtual void ResetTarget(uint targetRuntimeID, uint targetLockPointIndex) {} // 0x0000000183B41CC0-0x0000000183B41D80
	// [XID] // 0x000000018965BAF0-0x000000018965BB10
	public override void Init() 
	{
		base.Init();
		bIgnoreIntervalTick = true;
		_transform = _entity.transform;
		VCBaseInputController input = _entity.GetVisualComponent<VCBaseInputController>(VCBaseComponentTypeIDs.VCBaseInputController);
		controlData = input.controlData;
	} // 0x0000000183B40220-0x0000000183B403A0
	// [XID] // 0x000000018996E780-0x000000018996E7A0
	public override void PreInit() 
	{
		initCallback += InitVelocityForce;
	} // 0x0000000183B428A0-0x0000000183B429B0
	// [XID] // 0x00000001898B9100-0x00000001898B9120
	protected virtual void InitMoveCollider() {} // 0x0000000183B40B90-0x0000000183B40C30
	// [XID] // 0x00000001898C0680-0x00000001898C06A0
	public virtual Vector3 GetMoveVelocity() => default; // 0x0000000183B3FF00-0x0000000183B40010
	// [XID] // 0x00000001899B72C0-0x00000001899B72E0
	public VCMoveData GetMoveData() => _moveData; // 0x0000000183B412E0-0x0000000183B41390
	// [XID] // 0x00000001898CF6A0-0x00000001898CF6C0
	public virtual EntityCommonMoveData GetEntityCommonMoveData() => default; // 0x0000000183B41620-0x0000000183B416C0
	// [XID] // 0x00000001898D6ED0-0x00000001898D6EF0
	public virtual BaseMoveState GetMoveState() => BaseMoveState.Undefined; // 0x0000000183B41240-0x0000000183B412E0
	// [XID] // 0x00000001898DECF0-0x00000001898DED10
	public virtual bool IsInTag(int tagHash) => default; // 0x0000000183B41390-0x0000000183B41440
	// [XID] // 0x000000018997D660-0x000000018997D680
	public virtual bool IsOnDynamicSceneProp() => referenceSystem != null; // 0x0000000183B3ED40-0x0000000183B3EDF0
	// [XID] // 0x00000001898EDC70-0x00000001898EDC90
	public virtual void SetAnimatorDeltaMode(bool value) {} // 0x0000000183B3F650-0x0000000183B3F700
	// [IDTag] // 0x00000001898F55F0-0x00000001898F5630
	// [XID] // 0x00000001898F55F0-0x00000001898F5630
	public virtual void AddVelocity(VelocityForceType velocityType, Vector3 velocity, float time = 0f /* Metadata: 0x00AEAC4E */) {} // 0x0000000183B3FB70-0x0000000183B3FC50
	// [IDTag] // 0x00000001898FFF40-0x00000001898FFF80
	// [XID] // 0x00000001898FFF40-0x00000001898FFF80
	public virtual void AddVelocity(VelocityForceType velocityType, Vector3 velocity, Vector3 targetPos, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly = false /* Metadata: 0x00AEAC52 */, float time = 0f /* Metadata: 0x00AEAC53 */) {} // 0x0000000183B3FA30-0x0000000183B3FB70
	// [XID] // 0x000000018990A4B0-0x000000018990A4D0
	public void RemoveVelocity(VelocityForceType velocityType) 
	{
		_velocityForceMove.UnsetForce(velocityType);
	} // 0x0000000183B40730-0x0000000183B407F0
	// [XID] // 0x0000000189911ED0-0x0000000189911EF0
	public virtual bool IsInCombatMove() => default; // 0x0000000183B42800-0x0000000183B428A0
	// [XID] // 0x00000001899199C0-0x00000001899199E0
	public virtual bool isInMovePureStandbyAndStayInPlace() => default; // 0x0000000183B41C20-0x0000000183B41CC0
	// [XID] // 0x0000000189920EB0-0x0000000189920ED0
	public virtual bool IsNonAnimatorMode() => default; // 0x0000000183B40EF0-0x0000000183B40F90
	// [XID] // 0x00000001899B16A0-0x00000001899B16C0
	public virtual void SetNonAnimatorMode(bool value, bool animatorAlways) {} // 0x0000000183B41030-0x0000000183B410F0
	// [XID] // 0x00000001899C0410-0x00000001899C0430
	public virtual void SetNonMoveMode(bool value) {} // 0x0000000183B3EAF0-0x0000000183B3EBA0
	// [XID] // 0x0000000189AC6230-0x0000000189AC6250
	public virtual bool IsInAirState() => default; // 0x0000000183B3F320-0x0000000183B3F3C0
	// [XID] // 0x0000000189BD11F0-0x0000000189BD1210
	public virtual bool IsInFlyState() => default; // 0x0000000183B40010-0x0000000183B400B0
	// [XID] // 0x0000000189946410-0x0000000189946430
	public virtual bool IsInPerform() => default; // 0x0000000183B42440-0x0000000183B424E0
	// [XID] // 0x00000001899F4BC0-0x00000001899F4BE0
	public virtual bool CanUseAirSkill() => default; // 0x0000000183B3F0A0-0x0000000183B3F140
	// [XID] // 0x00000001899FC1E0-0x00000001899FC200
	public virtual bool CanDoJump() => default; // 0x0000000183B411A0-0x0000000183B41240
	// [XID] // 0x000000018995C9A0-0x000000018995C9C0
	public virtual void StopSprint() {} // 0x0000000183B3F550-0x0000000183B3F5F0
	// [XID] // 0x0000000189A0AC10-0x0000000189A0AC30
	public virtual bool IsInForbiddenToggleMoveState() => default; // 0x0000000183B3F8F0-0x0000000183B3F990
	// [XID] // 0x0000000189A12480-0x0000000189A124A0
	public virtual bool IsInMove() => default; // 0x0000000183B3E070-0x0000000183B3E110
	// [XID] // 0x0000000189A19870-0x0000000189A19890
	public virtual bool IsInSprint() => default; // 0x0000000183B3EA50-0x0000000183B3EAF0
	// [XID] // 0x0000000189A2FA30-0x0000000189A2FA50
	public virtual bool IsInCrouch() => default; // 0x0000000183B3E470-0x0000000183B3E510
	// [XID] // 0x0000000189982610-0x0000000189982630
	public virtual bool IsInPureMove() => default; // 0x0000000183B3EDF0-0x0000000183B3EE90
	// [XID] // 0x0000000189989DB0-0x0000000189989DD0
	public virtual bool IsInIdle() => default; // 0x0000000183B3F140-0x0000000183B3F1E0
	// [XID] // 0x0000000189BC9AA0-0x0000000189BC9AC0
	public virtual bool IsInClimb() => default; // 0x0000000183B3F280-0x0000000183B3F320
	// [XID] // 0x00000001899991C0-0x00000001899991E0
	public virtual bool IsInSwim() => default; // 0x0000000183B3DF60-0x0000000183B3E000
	// [XID] // 0x00000001899A0A50-0x00000001899A0A70
	public virtual bool IsInCombatMoveOnWater() => default; // 0x0000000183B405D0-0x0000000183B40670
	// [XID] // 0x00000001899B8B20-0x00000001899B8B40
	public virtual void FitToDrownPosition() {} // 0x0000000183B3ECA0-0x0000000183B3ED40
	// [XID] // 0x0000000189A46220-0x0000000189A46240
	public virtual bool IsInStandby2Climb() => default; // 0x0000000183B40F90-0x0000000183B41030
	// [XID] // 0x0000000189A4D910-0x0000000189A4D930
	public virtual bool IsInGoUpstairs() => default; // 0x0000000183B416C0-0x0000000183B41760
	// [XID] // 0x0000000189A55130-0x0000000189A55150
	public virtual bool IsInRunningTurn() => default; // 0x0000000183B3F1E0-0x0000000183B3F280
	// [XID] // 0x00000001899C6600-0x00000001899C6620
	public virtual float GetGroundDist() => default; // 0x0000000183B400B0-0x0000000183B40160
	// [XID] // 0x0000000189AFF590-0x0000000189AFF5B0
	public float GetGravityScale() => _gravityScale; // 0x0000000183B403A0-0x0000000183B40450
	// [XID] // 0x00000001899D5120-0x00000001899D5140
	protected virtual void SyncAnimatorMoveSpeed() {} // 0x0000000183B3E180-0x0000000183B3E220
	// [XID] // 0x00000001896A6A20-0x00000001896A6A40
	protected virtual void SyncAnimatorAttackSpeed() {} // 0x0000000183B40A80-0x0000000183B40B20
	// [XID] // 0x00000001899F8DB0-0x00000001899F8DD0
	public virtual void SyncGravityScale() {} // 0x0000000183B3DC40-0x0000000183B3DCE0
	// [XID] // 0x0000000189A003B0-0x0000000189A003D0
	public virtual void SetCombatAir() {} // 0x0000000183B3EE90-0x0000000183B3EF30
	// [XID] // 0x0000000189908F50-0x0000000189908F70
	public virtual void SetMotionFlag(VCMoveData.MotionFlag moveState) {} // 0x0000000183B3E510-0x0000000183B3E5C0
	// [XID] // 0x0000000189A0F140-0x0000000189A0F160
	public virtual VCMoveData.MotionFlag GetMotionFlag() => VCMoveData.MotionFlag.Idle; // 0x0000000183B3F990-0x0000000183B3FA30
	// [XID] // 0x000000018978A020-0x000000018978A040
	public virtual void SetLodLevel(uint lod) 
	{
		syncPlugin.SetLodLevel(lod);
	} // 0x0000000183B40160-0x0000000183B40220
	  // [XID] // 0x0000000189A64370-0x0000000189A64390
	private bool HasAnimatorParam(int nameHash)
	{
		if (!_animatorParamCache.ContainsKey(nameHash))
		{
			Animator animator = _entity.GetAnimator();
			_animatorParamCache.Add(nameHash,animator.HasParameter(nameHash));
		}
		return _animatorParamCache[nameHash];
	}// 0x0000000183B41810-0x0000000183B419A0
	// [IDTag] // 0x0000000189A25270-0x0000000189A252B0
	// [XID] // 0x0000000189A25270-0x0000000189A252B0
	public virtual void TrySteer(bool isMoving, float joystickAngle) {} // 0x0000000183B42740-0x0000000183B42800
	// [IDTag] // 0x0000000189A2F830-0x0000000189A2F870
	// [XID] // 0x0000000189A2F830-0x0000000189A2F870
	public virtual void TrySteer(Vector3 targetDir) {} // 0x0000000183B42680-0x0000000183B42740
	// [XID] // 0x0000000189A3A070-0x0000000189A3A090
	public virtual void SetTargetSteer(Vector3 targetDir) 
	{
		_moveData.targetSteerDir.x = targetDir.x;
		_moveData.targetSteerDir.z = targetDir.z;
	} // 0x0000000183B424E0-0x0000000183B425C0
	// [XID] // 0x0000000189A6BC60-0x0000000189A6BC80
	public virtual void SetTargetSteerExactly(Vector3 targetDir, Vector3 targetPos)
	{
		_moveData.targetSteerDir.x = targetDir.x;
		_moveData.targetSteerDir.z = targetDir.z;
	} // 0x0000000183B40D40-0x0000000183B40E40
	// [IDTag] // 0x0000000189A48F50-0x0000000189A48F90
	// [XID] // 0x0000000189A48F50-0x0000000189A48F90
	public virtual void TrySteerAir(Vector3 targetDir) {} // 0x0000000183B41A80-0x0000000183B41B40
	// [IDTag] // 0x0000000189A53630-0x0000000189A53670
	// [XID] // 0x0000000189A53630-0x0000000189A53670
	public virtual void TrySteerAir(Vector3 targetDir, Vector3 targetPointForTilt) {} // 0x0000000183B41B40-0x0000000183B41C20
	// [XID] // 0x0000000189A82560-0x0000000189A82580
	public virtual void TrySteerNoAnimatorMove(Vector3 targetDir) {} // 0x0000000183B42030-0x0000000183B420F0
	// [XID] // 0x0000000189A659E0-0x0000000189A65A00
	public virtual void TrySteerWithAngle(Vector3 targetDir, VCMoveData.MotionDirection motionDir) {} // 0x0000000183B3F480-0x0000000183B3F550
	// [XID] // 0x0000000189A6D0F0-0x0000000189A6D110
	public virtual void TrySteerWithAngleExactly(Vector3 targetDir, VCMoveData.MotionDirection motionDir, Vector3 targetPosition) {} // 0x0000000183B3EBA0-0x0000000183B3ECA0
	// [XID] // 0x0000000189A747C0-0x0000000189A747E0
	public virtual void TryStop() {} // 0x0000000183B3DBA0-0x0000000183B3DC40
	// [XID] // 0x0000000189A7C300-0x0000000189A7C320
	public virtual void DoStop() {} // 0x0000000183B41E40-0x0000000183B41EE0
	// [XID] // 0x0000000189A99140-0x0000000189A99160
	public virtual void TrySlip() {} // 0x0000000183B3FE60-0x0000000183B3FF00
	// [XID] // 0x0000000189A8B650-0x0000000189A8B670
	public virtual void DoJump() {} // 0x0000000183B41440-0x0000000183B414E0
	// [XID] // 0x0000000189A92C40-0x0000000189A92C60
	public virtual void DoTurnDir(Vector3 turnTargetPos) {} // 0x0000000183B425C0-0x0000000183B42680
	// [IDTag] // 0x0000000189A9A700-0x0000000189A9A740
	// [XID] // 0x0000000189A9A700-0x0000000189A9A740
	public virtual void DoBlink(Vector3 dir, float dist) {} // 0x0000000183B420F0-0x0000000183B421D0
	// [IDTag] // 0x0000000189AA4A20-0x0000000189AA4A60
	// [XID] // 0x0000000189AA4A20-0x0000000189AA4A60
	public virtual void DoBlink(bool preferInput, float dist) {} // 0x0000000183B421D0-0x0000000183B42290
	// [XID] // 0x0000000189AC6170-0x0000000189AC6190
	public virtual bool DoBlinkPosition(Vector3 pos) => default; // 0x0000000183B41D80-0x0000000183B41E40
	// [XID] // 0x0000000189AB6A30-0x0000000189AB6A50
	public virtual void TryTeleport(Vector3 pos) 
	{
		_entity.SetAbsolutePosition(pos);
	} // 0x0000000183B3E960-0x0000000183B3EA50
	// [XID] // 0x00000001898FE8D0-0x00000001898FE8F0
	public virtual bool DoingFreeStyle() => default; // 0x0000000183B3E720-0x0000000183B3E7C0
	// [XID] // 0x0000000189AC6090-0x0000000189AC60B0
	public virtual void DoFreeStyle(int freeStyleType, bool forceInterrupt, float? freeStyleParam = default) 
	{
		_entity.ForceCacheFreeStyle(freeStyleType);
	} // 0x0000000183B42360-0x0000000183B42440
	// [XID] // 0x0000000189B7DCA0-0x0000000189B7DCC0
	public virtual void NotifySitOnChair(Vector3 position, Vector3 rotationEular) {} // 0x0000000183B3FD80-0x0000000183B3FE60
	// [XID] // 0x0000000189941B30-0x0000000189941B50
	public virtual int GetCurFreeStyle() => -1; // 0x0000000183B41580-0x0000000183B41620
	// [XID] // 0x0000000189ADCD30-0x0000000189ADCD50
	public virtual void ResetFreeStyle() {} // 0x0000000183B41EE0-0x0000000183B41F80
	// [XID] // 0x0000000189933120-0x0000000189933140
	public virtual void ResetFreeStyleOnly() {} // 0x0000000183B3E3D0-0x0000000183B3E470
	// [XID] // 0x0000000189AEBD30-0x0000000189AEBD50
	public virtual void SetFreeStateTrigger() {} // 0x0000000183B414E0-0x0000000183B41580
	// [XID] // 0x0000000189AF3760-0x0000000189AF3780
	public virtual void SetFreeLoopState(int loopState) {} // 0x0000000183B41760-0x0000000183B41810
	// [XID] // 0x0000000189AFAFA0-0x0000000189AFAFC0
	public virtual void SetPassThroughCharacter(bool passThrough) 
	{
		_moveCollider.SetPassThroughCharacter(passThrough);
	} // 0x0000000183B3EF30-0x0000000183B3F000
	  // [XID] // 0x0000000189999340-0x0000000189999360
	public Vector3 GetVelocityForceMove()
	{
		Vector3 finalVel = Vector3.zero;
		if (_lastGetVelocityForceFrame < Time.frameCount)
		{
			finalVel = _velocityForceMove.curFinalVelocity;
			finalVel *= _entity.TimeScale;
			_currentVelocityForce.x = finalVel.x;
			_currentVelocityForce.z = finalVel.z;
			_lastGetVelocityForceFrame = Time.frameCount;
		}
		return finalVel.XZ();
	}// 0x0000000183B3F700-0x0000000183B3F8F0
	// [XID] // 0x0000000189976390-0x00000001899763B0
	protected virtual void InitVelocityForce() 
	{
		_velocityForceMove = new MoveVelocityForcePlugin();
		AddPlugin(_velocityForceMove);
	} // 0x0000000183B404F0-0x0000000183B405D0
	// [XID] // 0x00000001899FC2A0-0x00000001899FC2C0
	public virtual void ForceSetAirMove(bool enable) {} // 0x0000000183B3E320-0x0000000183B3E3D0
	// [XID] // 0x0000000189A4C050-0x0000000189A4C070
	public virtual bool GetIsAirMove() => default; // 0x0000000183B3F000-0x0000000183B3F0A0
	// [XID] // 0x0000000189B3D5E0-0x0000000189B3D600
	public override void Clear(BaseEntity.ClearReason clearReason)
	{
		if (_entity.rigidbody)
		{
			if (_entity.GetIsKinematicRigidbody())
			{
				_entity.rigidbody.velocity = Vector3.zero;
				_entity.rigidbody.isKinematic = true;
				_entity.rigidbody.detectCollisions = false;
			}
		}
	} // 0x0000000183B3E7C0-0x0000000183B3E960
	// [XID] // 0x0000000189B454A0-0x0000000189B454C0
	public override void ReInit(BaseEntity.ReInitReason reason)
    {
        base.ReInit(reason);
        _transform = _entity.transform;
        _entity.GetVisualComponent<VCBaseInputController>(VCBaseComponentTypeIDs.VCBaseInputController);
        if (_entity.rigidbody)
        {
            if (!_entity.GetIsKinematicRigidbody())
            {
                _entity.rigidbody.position = _entity.transform.position;
                if (_entity.rigidbody.isKinematic)
                {
                    _entity.rigidbody.velocity = Vector3.zero;
                }
                _entity.rigidbody.isKinematic = false;
            }
            _entity.rigidbody.detectCollisions = true;
        }
    } // 0x0000000183B429B0-0x0000000183B42C30
	// [IDTag] // 0x0000000189B4CA50-0x0000000189B4CA90
	// [XID] // 0x0000000189B4CA50-0x0000000189B4CA90
	public virtual void RefreshGroundInfo(float deltaTime, Bounds bounds, bool forceUp, uint rockGadgetId) {} // 0x0000000183B3DDA0-0x0000000183B3DEA0
	// [IDTag] // 0x0000000189B571A0-0x0000000189B571E0
	// [XID] // 0x0000000189B571A0-0x0000000189B571E0
	public virtual void RefreshGroundInfo(float deltaTime, bool forceUp) {} // 0x0000000183B3DEA0-0x0000000183B3DF60
																			// [XID] // 0x0000000189B61780-0x0000000189B617A0
	public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift)
	{
		if (VelocityForceMove != null)
		{
			VelocityForceMove.ShiftWorld(newShift, oldShift);
		}
	}// 0x0000000183B42C30-0x0000000183B42D80
	// [XID] // 0x0000000189B69370-0x0000000189B69390
	public virtual bool TryInitialSyncMove(ref MoveSyncTask syncTask, bool setPosition) => true; // 0x0000000183B42290-0x0000000183B42360
	// [XID] // 0x0000000189B70810-0x0000000189B70830
	public virtual bool CanInitFsmStateWithSyncTask(ref MoveSyncTask syncTask) => true; // 0x0000000183B41F80-0x0000000183B42030
	// [XID] // 0x0000000189B16DC0-0x0000000189B16DE0
	public virtual void CreateSyncTaskByTimeInterval() {} // 0x0000000183B40450-0x0000000183B404F0
}

