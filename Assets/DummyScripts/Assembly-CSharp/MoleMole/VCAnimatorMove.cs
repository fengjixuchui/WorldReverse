/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class VCAnimatorMove : VCNonHumanoidMoveBase // TypeDefIndex: 11785
	{
		// Fields
		private EntityCommonMoveCache _cache; // 0x310
		private EntityCommonMoveData _data; // 0x318
		protected bool _isInSlip; // 0x320
		protected WaterResult _isInWater; // 0x324
		protected const float ALMOST_IN_OUT_WATER_RATIO = 0.1f; // Metadata: 0x00AEAB1C
		private const string DO_SKILL = "DoSkill"; // Metadata: 0x00AEAB20
		private Vector3 _teleportToPoint; // 0x328
		private Vector3 _teleportToFwd; // 0x334
		protected bool _isInAirMove; // 0x341
		public bool forceSetAirMove; // 0x342
		public bool remoteForceUseAnimatorVel; // 0x343
		protected const float AIR_TILT_DISTANCE_THRESHOLD = 1f; // Metadata: 0x00AEAB2B
		protected bool _airMoveFollowAnimation; // 0x354
		protected bool _disableAnimatorTranslation; // 0x355
		protected MoveSmoothedSpeedPlugin _smoothSpeed; // 0x358
		private bool _moveOnGround; // 0x360
		private bool _moveOnWater; // 0x361
		private float _moveOnWaterDepth; // 0x364
		protected float _targetYCoordinate; // 0x368
		protected bool _hasTargetY; // 0x36C
		private bool _targetWater; // 0x36D
		private float _modelHeight; // 0x370
		private float _predictWaterHeight; // 0x374
		private float _predictGroundHeight; // 0x378
		private bool _predictWaterHit; // 0x37C
		private bool _predictGroundHit; // 0x37D
		private FacingMoveType _facingMoveType; // 0x380
		private MonsterSizeType _monsterSizeType; // 0x384
		private PositionModifyState _defaultPositionModifyState; // 0x388
		private Dictionary<uint, PositionModifyState> _positionModifyStateMap; // 0x390
		private int _returnDirectlyCount; // 0x398
		private const int MAX_RETURN_DIRECTLY_COUNT = 30; // Metadata: 0x00AEAB2F
		private bool _groundFollowAnimRotation; // 0x39C
		private float _groundRotationScale; // 0x3A0
		protected Transform _bip001; // 0x3A8
		protected Quaternion _lastBipRotation; // 0x3B0
		private bool _setMoveOnWaterBeforePrepare; // 0x3C0
		private bool _preSetMoveOnWaterVal; // 0x3C1
		private float _pushColRadiusRatio; // 0x3C4
		private LevelMoveScenePropPlugin _scenePropPlugin; // 0x3C8
		private int dropHash; // 0x3D4
		public static bool disableLogic; // 0x00
		protected bool _currentIsIce; // 0x3D8
		protected long _currentIceId; // 0x3E0
		private const float MAX_TILT = 25f; // Metadata: 0x00AEAB33
		private const float TILT_COEF = 20f; // Metadata: 0x00AEAB37
		private const float TILT_SPEED_COEFF = 70f; // Metadata: 0x00AEAB3B
		private float _groundRayTempExtraLength; // 0x3E8
		private bool _isUsingAnimatorDeltaMode; // 0x3ED
		public bool canSyncMove; // 0x3EE
		private bool _syncFirstEnter; // 0x3EF
		private bool _syncFirstEnterNeedMove; // 0x3F0
		private bool _lastCanSyncMove; // 0x3F1
		private float _cannotSyncMoveTime; // 0x3F4
		private const float CANNOT_SYNC_MOVE_NOTIFY_TIME = 5f; // Metadata: 0x00AEAB3F
		private Vector3 _syncAirMoveVelocity; // 0x3F8
		private Vector3 _syncVelocity; // 0x404
		private VCSyncAnimator _vcSyncAnimator; // 0x410
		private MotionState _lastNonStandbyMotion; // 0x418
		private string SYNC_STATE_TEXT_FORMAT; // 0x420
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x0000000189885120-0x0000000189885140 */ get => default; } // 0x00000001821B53B0-0x00000001821B5450 
		public bool applyGravityInAir { /* [XID] */ /* 0x00000001898A9D80-0x00000001898A9DC0 */ get; /* [XID] */ /* 0x00000001898B43B0-0x00000001898B43F0 */ private set; } // 0x00000001821B5020-0x00000001821B5080 0x00000001821B5660-0x00000001821B56D0
		public bool enableAirTilt { /* [XID] */ /* 0x00000001898BECA0-0x00000001898BECE0 */ get; /* [XID] */ /* 0x00000001898C9720-0x00000001898C9760 */ private set; } // 0x00000001821B5130-0x00000001821B5190 0x00000001821B5780-0x00000001821B57F0
		public Vector3 targetPointForTilt { /* [XID] */ /* 0x00000001898D3C90-0x00000001898D3CD0 */ get; /* [XID] */ /* 0x00000001898DED10-0x00000001898DED50 */ private set; } // 0x00000001821B55E0-0x00000001821B5660 0x00000001821B58D0-0x00000001821B5950
		public bool airMoveFollowAnimation { /* [XID] */ /* 0x000000018961FC30-0x000000018961FC50 */ get => default; } // 0x00000001821B4F70-0x00000001821B5020 
		public bool disableAnimatorTranslation { /* [XID] */ /* 0x0000000189626F70-0x0000000189626F90 */ get => default; /* [XID] */ /* 0x000000018962E900-0x000000018962E920 */ set {} } // 0x00000001821B5080-0x00000001821B5130 0x00000001821B56D0-0x00000001821B5780
		public bool groundFollowAnimRotation { /* [XID] */ /* 0x00000001898FFFA0-0x00000001898FFFC0 */ get => default; } // 0x00000001821B51F0-0x00000001821B52A0 
		public float groundRotationScale { /* [XID] */ /* 0x00000001899076E0-0x0000000189907700 */ get => default; } // 0x00000001821B5300-0x00000001821B53B0 
		public LevelMoveScenePropPlugin scenePropPlugin { /* [XID] */ /* 0x00000001896451A0-0x00000001896451C0 */ get => default; } // 0x00000001821B5450-0x00000001821B55E0 
		public bool enableVelocityDetect { /* [XID] */ /* 0x000000018994AAE0-0x000000018994AB20 */ get; /* [XID] */ /* 0x0000000189955160-0x00000001899551A0 */ private set; } // 0x00000001821B5190-0x00000001821B51F0 0x00000001821B57F0-0x00000001821B5860
		public bool groundInfoRefreshed { /* [XID] */ /* 0x0000000189ABCD00-0x0000000189ABCD40 */ get; /* [XID] */ /* 0x0000000189AC76F0-0x0000000189AC7730 */ private set; } // 0x00000001821B52A0-0x00000001821B5300 0x00000001821B5860-0x00000001821B58D0
	
		// Constructors
		public VCAnimatorMove() {} // 0x00000001821B4E40-0x00000001821B4F70
		static VCAnimatorMove() {} // 0x00000001821B4DE0-0x00000001821B4E40
	
		// Methods
		// [XID] // 0x000000018988C6E0-0x000000018988C700
		private void PrepareData() {} // 0x00000001821A6520-0x00000001821A7940
		// [XID] // 0x0000000189893C50-0x0000000189893C70
		public override void OnEntityReady() {} // 0x00000001821B3990-0x00000001821B3AA0
		// [XID] // 0x0000000189B58EA0-0x0000000189B58EC0
		public override void OnSafeDispatch() {} // 0x00000001821B3AA0-0x00000001821B3BF0
		// [XID] // 0x0000000189BC0460-0x0000000189BC0480
		public override void Destroy() {} // 0x00000001821A9890-0x00000001821A9B10
		// [XID] // 0x000000018964CD20-0x000000018964CD40
		public override void Init() {} // 0x00000001821AEB00-0x00000001821AEBF0
		// [XID] // 0x000000018991E0B0-0x000000018991E0D0
		public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001821B45B0-0x00000001821B4670
		// [XID] // 0x0000000189925960-0x0000000189925980
		public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x00000001821A8AD0-0x00000001821A8B80
		// [XID] // 0x000000018992CE30-0x000000018992CE50
		private new void DoInit() {} // 0x00000001821A4F00-0x00000001821A5870
		// [XID] // 0x000000018977C7C0-0x000000018977C7E0
		private void AdjustCollider() {} // 0x00000001821B3080-0x00000001821B3590
		// [XID] // 0x000000018993C050-0x000000018993C070
		protected override void InitMoveCollider() {} // 0x00000001821AF8A0-0x00000001821AFC20
		// [XID] // 0x00000001899433F0-0x0000000189943410
		protected override void InitVelocityDetect() {} // 0x00000001821AF0F0-0x00000001821AF240
		// [XID] // 0x000000018995FB90-0x000000018995FBB0
		public override void EnableCrashDamage(bool enable) {} // 0x00000001821AAE60-0x00000001821AAF50
		// [XID] // 0x0000000189967490-0x00000001899674B0
		public override bool IsInSwim() => default; // 0x00000001821A6230-0x00000001821A62E0
		// [XID] // 0x000000018981F7E0-0x000000018981F800
		public override void TrySteer(Vector3 targetDir) {} // 0x00000001821B4320-0x00000001821B4400
		// [IDTag] // 0x0000000189976210-0x0000000189976250
		// [XID] // 0x0000000189976210-0x0000000189976250
		public override void TrySteerAir(Vector3 targetDir) {} // 0x00000001821B1620-0x00000001821B1790
		// [IDTag] // 0x0000000189980860-0x00000001899808A0
		// [XID] // 0x0000000189980860-0x00000001899808A0
		public override void TrySteerAir(Vector3 targetDir, Vector3 targetPointForTilt) {} // 0x00000001821B1420-0x00000001821B1620
		// [XID] // 0x000000018998B520-0x000000018998B540
		public void ChangeAuthority() {} // 0x00000001821AF240-0x00000001821AF330
		// [XID] // 0x0000000189993100-0x0000000189993120
		public override void TrySteerNoAnimatorMove(Vector3 targetDir) {} // 0x00000001821B2930-0x00000001821B2A10
		// [XID] // 0x000000018999ABF0-0x000000018999AC10
		public override void TrySteerWithAngle(Vector3 targetDir, VCMoveData.MotionDirection motionDir) {} // 0x00000001821AAF50-0x00000001821AB0C0
		// [XID] // 0x0000000189890D80-0x0000000189890DA0
		public override void TrySteerWithAngleExactly(Vector3 targetDir, VCMoveData.MotionDirection motionDir, Vector3 targetPosition) {} // 0x00000001821A93D0-0x00000001821A9560
		// [XID] // 0x0000000189898360-0x0000000189898380
		public override void TryTeleport(Vector3 pos) {} // 0x00000001821A8B80-0x00000001821A8D30
		// [XID] // 0x000000018990A650-0x000000018990A670
		private bool IsFaceAngleAlmostUp(Vector2 faceAngle) => default; // 0x00000001821B3670-0x00000001821B3780
		// [XID] // 0x00000001899B8A00-0x00000001899B8A20
		protected void CheckInSlip() {} // 0x00000001821AB650-0x00000001821AB760
		// [XID] // 0x00000001899C02F0-0x00000001899C0310
		protected bool IsInSlip() => default; // 0x00000001821AB0C0-0x00000001821AB170
		// [XID] // 0x00000001899C7B90-0x00000001899C7BB0
		protected float GetSlope(Vector3 normal) => default; // 0x00000001821AEFB0-0x00000001821AF0F0
		// [XID] // 0x00000001899CF350-0x00000001899CF370
		protected override void CheckIsInAir() {} // 0x00000001821AD990-0x00000001821ADAD0
		// [XID] // 0x00000001899D6810-0x00000001899D6830
		public bool IsHasNegitiveForce() => default; // 0x00000001821AF7D0-0x00000001821AF8A0
		// [XID] // 0x0000000189921010-0x0000000189921030
		protected override void SetMoveVelocity(Vector3 vel) {} // 0x00000001821AAD70-0x00000001821AAE60
		// [XID] // 0x0000000189928A10-0x0000000189928A30
		protected bool CheckWallAndCliff(float deltaTime, Vector3 vel) => default; // 0x00000001821B21C0-0x00000001821B2930
		// [XID] // 0x00000001899ECD00-0x00000001899ECD20
		protected override void SetAvatarHeight() {} // 0x00000001821AFED0-0x00000001821B0010
		// [XID] // 0x00000001899F4A60-0x00000001899F4A80
		protected WaterResult CheckAlmostInOutWater(Vector3 vel) => default; // 0x00000001821AEDE0-0x00000001821AEFB0
		// [XID] // 0x00000001899464D0-0x00000001899464F0
		public bool HasStruggle() => default; // 0x00000001821AF4E0-0x00000001821AF5B0
		// [XID] // 0x0000000189A034B0-0x0000000189A034D0
		protected override void CheckIsFallOnGround(float deltaTime) {} // 0x00000001821ADAD0-0x00000001821ADE60
		// [XID] // 0x0000000189B2D260-0x0000000189B2D280
		private bool CanSwim() => default; // 0x00000001821A7940-0x00000001821A7B10
		// [IDTag] // 0x0000000189A122A0-0x0000000189A122E0
		// [XID] // 0x0000000189A122A0-0x0000000189A122E0
		public override void AddVelocity(VelocityForceType velocityType, Vector3 velocity, float time = 0f /* Metadata: 0x00AEAB0D */) {} // 0x00000001821ACB20-0x00000001821ACCC0
		// [IDTag] // 0x0000000189A1C430-0x0000000189A1C470
		// [XID] // 0x0000000189A1C430-0x0000000189A1C470
		public override void AddVelocity(VelocityForceType velocityType, Vector3 velocity, Vector3 targetPos, HashSet<int> stateIds, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly = false /* Metadata: 0x00AEAB11 */, float time = 0f /* Metadata: 0x00AEAB12 */) {} // 0x00000001821AC970-0x00000001821ACB20
		// [XID] // 0x0000000189A26AD0-0x0000000189A26AF0
		private void Retreat(Vector3 retreatDir) {} // 0x00000001821A4AF0-0x00000001821A4CB0
		// [XID] // 0x00000001899E5D80-0x00000001899E5DA0
		private void HitAir(Vector3 retreatDir) {} // 0x00000001821AABA0-0x00000001821AAD70
		// [XID] // 0x0000000189A359C0-0x0000000189A359E0
		private void FreeForce(VelocityForceType velocityForceType, float rushTime, Vector3 rushVel) {} // 0x00000001821ACCC0-0x00000001821ACE20
		// [XID] // 0x00000001896C1080-0x00000001896C10A0
		private void FixedRushMoveForce(Vector3 rushVel, Vector3? targetPos, HashSet<int> animatorStateIDs, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly) {} // 0x00000001821A4CB0-0x00000001821A4F00
		// [XID] // 0x0000000189791630-0x0000000189791650
		private void DrownWater() {} // 0x00000001821AAA20-0x00000001821AAB40
		// [XID] // 0x0000000189832AA0-0x0000000189832AC0
		protected Vector3 ApplyGravity(float deltaTime, Vector3 vel) => default; // 0x00000001821AB760-0x00000001821ABC60
		// [XID] // 0x0000000189AF7F90-0x0000000189AF7FB0
		protected override void CalcCurrentGroundHeight() {} // 0x00000001821ACED0-0x00000001821AD910
		// [XID] // 0x0000000189A5ADA0-0x0000000189A5ADC0
		private bool IsBeHitInAir() => default; // 0x00000001821B3830-0x00000001821B3990
		// [XID] // 0x0000000189A62600-0x0000000189A62620
		protected void MoveUpdateTilt(float deltaTime) {} // 0x00000001821B3BF0-0x00000001821B4120
		// [XID] // 0x0000000189A6A400-0x0000000189A6A420
		protected override float CalcTiltByYawDelta(float deltaTime, float toDesiredYaw, float tiltCoeff) => default; // 0x00000001821B0630-0x00000001821B0840
		// [XID] // 0x0000000189A71810-0x0000000189A71830
		protected override void MoveUpdateRotation() {} // 0x00000001821A8670-0x00000001821A8990
		// [XID] // 0x0000000189A792D0-0x0000000189A792F0
		protected void SetFaceWithSteerDir(Vector3 steerDir) {} // 0x00000001821A7C60-0x00000001821A8090
		// [XID] // 0x0000000189B06C70-0x0000000189B06C90
		public void DisableGravityInAir() {} // 0x00000001821B0840-0x00000001821B0920
		// [XID] // 0x0000000189B15670-0x0000000189B15690
		public override bool DoBlinkPosition(Vector3 pos) => default; // 0x00000001821B1790-0x00000001821B1850
		// [XID] // 0x0000000189B1D110-0x0000000189B1D130
		public bool TryBlinkPosition(BlinkHitSceneTestType hitSceneTestType, Vector3 pos, Vector3 fwd, float limitedY, bool ignoreWater = false /* Metadata: 0x00AEAB16 */) => default; // 0x00000001821ABC60-0x00000001821AC830
		// [XID] // 0x0000000189A97430-0x0000000189A97450
		public void SetTeleportToPoint(Vector3 pos) {} // 0x00000001821A6450-0x00000001821A6520
		// [XID] // 0x0000000189A9E810-0x0000000189A9E830
		public void SetTeleportToForward(Vector3 fwd) {} // 0x00000001821AC830-0x00000001821AC900
		// [XID] // 0x0000000189AA61C0-0x0000000189AA61E0
		public Vector3 GetTeleportToPoint() => default; // 0x00000001821B3590-0x00000001821B3670
		// [XID] // 0x0000000189AAD7E0-0x0000000189AAD800
		public Vector3 GetTeleportToForward() => default; // 0x00000001821A7B80-0x00000001821A7C60
		// [XID] // 0x0000000189AB5020-0x0000000189AB5040
		public void SetGroundRotationScale(float value) {} // 0x00000001821B0180-0x00000001821B0230
		// [IDTag] // 0x0000000189AD1EE0-0x0000000189AD1F20
		// [XID] // 0x0000000189AD1EE0-0x0000000189AD1F20
		public override void RefreshGroundInfo(float deltaTime, bool forceUp) {} // 0x00000001821A5D50-0x00000001821A61A0
		// [IDTag] // 0x0000000189ADCD70-0x0000000189ADCDB0
		// [XID] // 0x0000000189ADCD70-0x0000000189ADCDB0
		public override void RefreshGroundInfo(float deltaTime, Bounds bounds, bool forceUp, uint rockGadgetId) {} // 0x00000001821A58D0-0x00000001821A5D50
		// [XID] // 0x00000001896FC5F0-0x00000001896FC610
		public void SyncRefreshedGroundInfoToEntityCommonMoveData(ref EntityCommonMoveData data) {} // 0x00000001821A8D30-0x00000001821A8F70
		// [XID] // 0x000000018970B390-0x000000018970B3B0
		private void RefreshGroundInfoImp(float deltaTime) {} // 0x00000001821B00D0-0x00000001821B0180
		// [XID] // 0x0000000189712B50-0x0000000189712B70
		public override void ForceSetAirMove(bool enable) {} // 0x00000001821A8330-0x00000001821A8510
		// [XID] // 0x0000000189AFDB90-0x0000000189AFDBB0
		public override bool GetIsAirMove() => default; // 0x00000001821AA910-0x00000001821AA9C0
		// [XID] // 0x0000000189ACD8E0-0x0000000189ACD900
		public bool IsOnWater() => default; // 0x00000001821A8510-0x00000001821A85C0
		// [XID] // 0x0000000189B0C9E0-0x0000000189B0CA00
		protected override void CloseToGround(float deltaTime) {} // 0x00000001821B4400-0x00000001821B45B0
		// [XID] // 0x0000000189B13FA0-0x0000000189B13FC0
		public float GetWaterMoveDepth() => default; // 0x00000001821A8F70-0x00000001821A9020
		// [XID] // 0x0000000189B1B850-0x0000000189B1B870
		public void ForceSetFollowAnimationTransform(bool enabled) {} // 0x00000001821B3780-0x00000001821B3830
		// [XID] // 0x000000018981C740-0x000000018981C760
		public override void SetGroundFollowAnimRotation(bool enable) {} // 0x00000001821B0230-0x00000001821B02E0
		// [XID] // 0x0000000189B2A440-0x0000000189B2A460
		public override void SetAnimatorDeltaMode(bool value) {} // 0x00000001821AB490-0x00000001821AB5F0
		// [XID] // 0x0000000189B31960-0x0000000189B31980
		public bool IsUsingAnimatorDeltaMode() => default; // 0x00000001821A85C0-0x00000001821A8670
		// [XID] // 0x0000000189B38DF0-0x0000000189B38E10
		protected virtual void UpdateAnimatorDeltaMove() {} // 0x00000001821A95E0-0x00000001821A9890
		// [XID] // 0x0000000189B409B0-0x0000000189B409D0
		public void flushParams(ref EntityCommonMoveData data) {} // 0x00000001821B2A10-0x00000001821B2BC0
		// [XID] // 0x0000000189B48290-0x0000000189B482B0
		public override bool TryInitialSyncMove(ref MoveSyncTask syncTask, bool setPosition) => default; // 0x00000001821B2BC0-0x00000001821B3080
		// [XID] // 0x0000000189B4FB10-0x0000000189B4FB30
		public override void CreateSyncTaskByTimeInterval() {} // 0x00000001821AEC60-0x00000001821AEDE0
		// [XID] // 0x0000000189721760-0x0000000189721780
		public MotionState GetCurrentSyncMotionState() => default; // 0x00000001821A62E0-0x00000001821A6450
		// [XID] // 0x0000000189B5EBE0-0x0000000189B5EC00
		private void SyncLateTick(float deltaTime) {} // 0x00000001821B0D60-0x00000001821B1340
		// [XID] // 0x0000000189B66220-0x0000000189B66240
		private bool GetNextSyncOrder() => default; // 0x00000001821A9020-0x00000001821A9360
		// [XID] // 0x00000001897DAAF0-0x00000001897DAB10
		private void SetAnimSync(MotionState motionState) {} // 0x00000001821A8090-0x00000001821A8210
		// [XID] // 0x0000000189B74DF0-0x0000000189B74E10
		private void ProcessCurrentMoveTask(float deltaTime) {} // 0x00000001821B1850-0x00000001821B21C0
		// [XID] // 0x0000000189BD1170-0x0000000189BD1190
		public bool CheckCannotSyncMoveNotify(float deltaTime) => default; // 0x00000001821AFC20-0x00000001821AFE00
		// [XID] // 0x0000000189BDFFD0-0x0000000189BDFFF0
		private void CheckCanSyncMoveFirstEnter() {} // 0x00000001821B4120-0x00000001821B42C0
		// [XID] // 0x0000000189B8AEA0-0x0000000189B8AEC0
		public override EntityCommonMoveData GetEntityCommonMoveData() => default; // 0x00000001821B0A40-0x00000001821B0AF0
		// [XID] // 0x0000000189B92640-0x0000000189B92660
		public string GetSyncStateText() => default; // 0x00000001821AB170-0x00000001821AB490
		// [XID] // 0x0000000189B99B80-0x0000000189B99BA0
		public void ChangeMoveOnWater(bool enable) {} // 0x00000001821AFE00-0x00000001821AFED0
		// [XID] // 0x0000000189BA1220-0x0000000189BA1240
		public override bool ShiftWorld(Vector3 newShift, Vector3 oldShift) => default; // 0x00000001821B4670-0x00000001821B4DE0
		[Preserve] // 0x0000000189BA8880-0x0000000189BA88C0
		// [XID] // 0x0000000189BA8880-0x0000000189BA88C0
		public override string Dump() => default; // 0x00000001821A9B10-0x00000001821AA910
		// [XID] // 0x0000000189B51490-0x0000000189B514B0
		public string ReportCurrentInfo(string head = " " /* Metadata: 0x00AEAB17 */) => default; // 0x00000001821ADE60-0x00000001821AEB00
	}
}
