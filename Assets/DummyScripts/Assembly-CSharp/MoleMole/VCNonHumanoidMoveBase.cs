/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using motion4hi;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class VCNonHumanoidMoveBase : VCBaseMove // TypeDefIndex: 11916
	{
		// Fields
		public float maxMoveUphillSlope; // 0x1D8
		public float maxSlipSpeed; // 0x1DC
		public float yawSpeedRatio; // 0x1E0
		[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
		protected uint _moveLodValue; // 0x1E4
		protected uint _closeToGroundFrequency; // 0x1E8
		protected uint _currentCloseToGroundCount; // 0x1EC
		protected Vector3 _lastDetectGroundPos; // 0x1F0
		protected const float KEEP_LAST_GROUND_HEIGHT_MAX_DIST = 0.4f; // Metadata: 0x00AEAF48
		[NonSerialized]
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public float avatarHeight; // 0x1FC
		public float avatarRadius; // 0x200
		protected float _airDistance; // 0x204
		protected Rigidbody _rigidbody; // 0x208
		public bool canSteerInCurrentState; // 0x210
		protected Animator _animator; // 0x218
		protected RuntimeAnimatorController _cacheRuntimeAnimatorCtrl; // 0x220
		protected float _currTilt; // 0x228
		protected float _lastTimeTilt; // 0x22C
		protected ControlData _controlData; // 0x230
		protected AnimatorController _animatorController; // 0x238
		protected bool _isInEmptyAnimatorControllerMode; // 0x240
		protected Vector3 _lastPostion; // 0x244
		protected float _currentGroundHeight; // 0x250
		protected float _currentWaterHeight; // 0x254
		private bool _isInAir; // 0x258
		protected bool _groundHit; // 0x259
		protected bool _waterHit; // 0x25A
		protected RaycastHit _groundHitResult; // 0x260
		protected Vector3 _extraCloseToGroundVelocity; // 0x2A0
		protected Vector3 _cachedPosition; // 0x2AC
		protected Vector3 _startPosition; // 0x2B8
		protected Quaternion _cachedRotation; // 0x2C4
		protected bool _setRotation; // 0x2D4
		public bool exactMove; // 0x2D5
		public Vector3 exactMoveTarget; // 0x2D8
		protected Action<BaseEntity, bool> _onInAirStateChanged; // 0x2E8
		public bool hasExtraGravityChange; // 0x2F0
		public float extraGravityChangeVal; // 0x2F4
		private Vector3 _dampVelocity; // 0x2F8
		protected LCAbilityState _lcAblityState; // 0x308
	
		// Properties
		public override int metaTypeID { /* [XID] */ /* 0x00000001899104D0-0x00000001899104F0 */ get => default; } // 0x0000000183C042D0-0x0000000183C04370 
		public uint moveLodValue { /* [XID] */ /* 0x0000000189688F20-0x0000000189688F40 */ get => default; } // 0x0000000183C04370-0x0000000183C04410 
		public uint closeToGroundFrequency { /* [XID] */ /* 0x0000000189690A40-0x0000000189690A60 */ get => default; } // 0x0000000183C04190-0x0000000183C04230 
		public uint currentCloseToGroundCount { /* [XID] */ /* 0x00000001896982A0-0x00000001896982C0 */ get => default; } // 0x0000000183C04230-0x0000000183C042D0 
	
		// Constructors
		public VCNonHumanoidMoveBase() {} // 0x0000000183C04050-0x0000000183C04190
	
		// Methods
		// [XID] // 0x000000018969F520-0x000000018969F540
		public override void Init() {} // 0x0000000183C00DB0-0x0000000183C00ED0
		// [XID] // 0x00000001896A68E0-0x00000001896A6900
		public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000183C03F90-0x0000000183C04050
		// [XID] // 0x0000000189662E40-0x0000000189662E60
		private void DoInit() {} // 0x0000000183BFCE50-0x0000000183BFD310
		// [XID] // 0x00000001896B5660-0x00000001896B5680
		protected virtual void InitVelocityDetect() {} // 0x0000000183C01080-0x0000000183C01220
		// [XID] // 0x00000001896BC8C0-0x00000001896BC8E0
		protected virtual void GetCacheFromTransform() {} // 0x0000000183BFDF10-0x0000000183BFE090
		// [XID] // 0x000000018991F750-0x000000018991F770
		protected virtual void SaveCacheToTransform() {} // 0x0000000183BFF610-0x0000000183BFF860
		// [XID] // 0x0000000189672610-0x0000000189672630
		protected virtual void InitMoveComponent() {} // 0x0000000183C02750-0x0000000183C029C0
		// [XID] // 0x0000000189927220-0x0000000189927240
		protected override void InitMoveCollider() {} // 0x0000000183C016E0-0x0000000183C01990
		// [XID] // 0x0000000189B60510-0x0000000189B60530
		public override void Destroy() {} // 0x0000000183BFF270-0x0000000183BFF450
		// [XID] // 0x00000001896E19A0-0x00000001896E19C0
		public override float GetGroundDist() => default; // 0x0000000183C003B0-0x0000000183C004A0
		// [XID] // 0x00000001896E8F10-0x00000001896E8F30
		protected virtual void CheckIsInAir() {} // 0x0000000183C00990-0x0000000183C00AB0
		// [XID] // 0x00000001896F0130-0x00000001896F0150
		public override void SetCombatAir() {} // 0x0000000183BFF570-0x0000000183BFF610
		// [XID] // 0x00000001896F79F0-0x00000001896F7A10
		public void SetInAirState(bool inAirState) {} // 0x0000000183BFEB60-0x0000000183BFEC60
		// [XID] // 0x00000001896FF4D0-0x00000001896FF4F0
		public override bool IsInAirState() => default; // 0x0000000183BFFAA0-0x0000000183BFFB50
		// [XID] // 0x000000018974E7F0-0x000000018974E810
		protected virtual void CheckIsFallOnGround(float deltaTime) {} // 0x0000000183C00AB0-0x0000000183C00C10
		// [XID] // 0x000000018970E170-0x000000018970E190
		protected bool IsCliffDistance(float distance) => default; // 0x0000000183BFF920-0x0000000183BFF9E0
		// [XID] // 0x0000000189944D10-0x0000000189944D30
		protected virtual void SetMoveVelocity(Vector3 vel) {} // 0x0000000183BFFC40-0x0000000183BFFD00
		// [XID] // 0x000000018971D1B0-0x000000018971D1D0
		protected void PreUpdateGroudCount(float deltaTime) {} // 0x0000000183C00030-0x0000000183C00100
		// [XID] // 0x0000000189724590-0x00000001897245B0
		protected void PostUpdateGroudCount() {} // 0x0000000183C02FF0-0x0000000183C030A0
		// [XID] // 0x000000018972BB60-0x000000018972BB80
		protected virtual void CalcCurrentGroundHeight() {} // 0x0000000183C004A0-0x0000000183C00990
		// [XID] // 0x00000001897333B0-0x00000001897333D0
		protected virtual void CloseToGround(float deltaTime) {} // 0x0000000183C03DE0-0x0000000183C03F90
		// [XID] // 0x000000018994C3A0-0x000000018994C3C0
		public override void SetLodLevel(uint lod) {} // 0x0000000183C00C80-0x0000000183C00DB0
		// [XID] // 0x0000000189742360-0x0000000189742380
		public override bool IsActive() => default; // 0x0000000183C00ED0-0x0000000183C00FA0
		// [IDTag] // 0x0000000189749F30-0x0000000189749F70
		// [XID] // 0x0000000189749F30-0x0000000189749F70
		public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x0000000183C03CB0-0x0000000183C03DE0
		// [IDTag] // 0x0000000189754610-0x0000000189754650
		// [XID] // 0x0000000189754610-0x0000000189754650
		public override void TrySteer(Vector3 targetDir) {} // 0x0000000183C03B90-0x0000000183C03CB0
		// [IDTag] // 0x000000018975EC10-0x000000018975EC50
		// [XID] // 0x000000018975EC10-0x000000018975EC50
		public override void TrySteerAir(Vector3 targetDir) {} // 0x0000000183C02D90-0x0000000183C02E50
		// [IDTag] // 0x0000000189769030-0x0000000189769070
		// [XID] // 0x0000000189769030-0x0000000189769070
		public override void TrySteerAir(Vector3 targetDir, Vector3 targetPointForTilt) {} // 0x0000000183C02E50-0x0000000183C02F40
		// [XID] // 0x0000000189773700-0x0000000189773720
		public override void TrySteerWithAngle(Vector3 targetDir, VCMoveData.MotionDirection motionDir) {} // 0x0000000183BFFEF0-0x0000000183C00030
		// [XID] // 0x0000000189962F10-0x0000000189962F30
		public override void TryStop() {} // 0x0000000183BFCDA0-0x0000000183BFCE50
		// [XID] // 0x0000000189782AC0-0x0000000189782AE0
		public override void DoStop() {} // 0x0000000183C02F40-0x0000000183C02FF0
		// [XID] // 0x0000000189789CD0-0x0000000189789CF0
		public override bool DoingFreeStyle() => default; // 0x0000000183BFEC60-0x0000000183BFED50
		// [XID] // 0x00000001897914D0-0x00000001897914F0
		public override void DoFreeStyle(int freeStyleType, bool forceInterrupt, float? freeStyleParam = default) {} // 0x0000000183C033F0-0x0000000183C03990
		// [XID] // 0x0000000189980A40-0x0000000189980A60
		public override int GetCurFreeStyle() => default; // 0x0000000183C029C0-0x0000000183C02AB0
		// [XID] // 0x00000001897A0A30-0x00000001897A0A50
		public override void ResetFreeStyle() {} // 0x0000000183C030A0-0x0000000183C03280
		// [XID] // 0x00000001897A80C0-0x00000001897A80E0
		public override void ResetFreeStyleOnly() {} // 0x0000000183BFE4B0-0x0000000183BFE5F0
		// [XID] // 0x00000001899976B0-0x00000001899976D0
		public override void SetFreeStateTrigger() {} // 0x0000000183C024F0-0x0000000183C025F0
		// [XID] // 0x000000018999F230-0x000000018999F250
		public override void SetFreeLoopState(int loopState) {} // 0x0000000183C02AB0-0x0000000183C02BC0
		// [XID] // 0x00000001897BF880-0x00000001897BF8A0
		public override void SetMotionFlag(VCMoveData.MotionFlag moveState) {} // 0x0000000183BFE9D0-0x0000000183BFEB60
		// [XID] // 0x00000001897C7010-0x00000001897C7030
		public override VCMoveData.MotionFlag GetMotionFlag() => default; // 0x0000000183C00160-0x0000000183C00220
		// [XID] // 0x00000001897CE5E0-0x00000001897CE600
		public override bool IsInMove() => default; // 0x0000000183BFDB90-0x0000000183BFDC50
		// [XID] // 0x00000001897D5CD0-0x00000001897D5CF0
		public override bool IsInPureMove() => default; // 0x0000000183BFF4B0-0x0000000183BFF570
		// [XID] // 0x00000001899C4DB0-0x00000001899C4DD0
		public override bool IsInIdle() => default; // 0x0000000183BFF860-0x0000000183BFF920
		// [XID] // 0x00000001897E4D50-0x00000001897E4D70
		protected virtual void StayInPlace() {} // 0x0000000183BFD800-0x0000000183BFD9B0
		// [XID] // 0x00000001899CC390-0x00000001899CC3B0
		public Vector3 GetRigidbodyVelocity() => default; // 0x0000000183C032F0-0x0000000183C033F0
		// [XID] // 0x00000001897F41E0-0x00000001897F4200
		public override Vector3 GetMoveVelocity() => default; // 0x0000000183C00220-0x0000000183C003B0
		// [XID] // 0x00000001897FBC40-0x00000001897FBC60
		public override BaseMoveState GetMoveState() => default; // 0x0000000183C02210-0x0000000183C022B0
		// [XID] // 0x0000000189803150-0x0000000189803170
		public override void OnDisable() {} // 0x0000000183C03990-0x0000000183C03A50
		// [XID] // 0x000000018980A5C0-0x000000018980A5E0
		protected virtual float CalcTiltByYawDelta(float deltaTime, float toDesiredYaw, float tiltCoeff) => default; // 0x0000000183C02660-0x0000000183C02750
		// [XID] // 0x00000001899E9E10-0x00000001899E9E30
		protected float AttenuationTitlt(float deltaTime, bool inAttenuation, float titlt) => default; // 0x0000000183BFD600-0x0000000183BFD800
		// [XID] // 0x00000001898199B0-0x00000001898199D0
		protected virtual void MoveUpdateRotation() {} // 0x0000000183BFE5F0-0x0000000183BFE9D0
		// [XID] // 0x00000001899CF570-0x00000001899CF590
		public void StopVelocityForce(VelocityForceType forceType) {} // 0x0000000183BFE320-0x0000000183BFE400
		// [XID] // 0x00000001898286A0-0x00000001898286C0
		public virtual void SetGroundFollowAnimRotation(bool enable) {} // 0x0000000183C022B0-0x0000000183C02360
		// [XID] // 0x000000018982F930-0x000000018982F950
		protected virtual void SetAvatarHeight() {} // 0x0000000183C01AA0-0x0000000183C01C20
		// [XID] // 0x0000000189837210-0x0000000189837230
		protected void InitAbilityPropertyCallback() {} // 0x0000000183BFEFF0-0x0000000183BFF1A0
		// [XID] // 0x00000001899F1630-0x00000001899F1650
		public override void OnEnable() {} // 0x0000000183C03A50-0x0000000183C03B30
		// [XID] // 0x00000001899F8E90-0x00000001899F8EB0
		protected override void SyncAnimatorMoveSpeed() {} // 0x0000000183BFDC50-0x0000000183BFDDF0
		// [XID] // 0x000000018984D3C0-0x000000018984D3E0
		protected override void SyncAnimatorAttackSpeed() {} // 0x0000000183C01540-0x0000000183C016E0
		// [XID] // 0x0000000189A07BF0-0x0000000189A07C10
		public override void SyncGravityScale() {} // 0x0000000183BFD310-0x0000000183BFD540
		// [XID] // 0x0000000189A16860-0x0000000189A16880
		public override bool IsNonAnimatorMode() => default; // 0x0000000183C019F0-0x0000000183C01AA0
		// [XID] // 0x0000000189A1DD60-0x0000000189A1DD80
		public override void SetNonAnimatorMode(bool value, bool animatorAlways) {} // 0x0000000183C01C20-0x0000000183C021A0
		// [XID] // 0x000000018986A9F0-0x000000018986AA10
		public override void SetNonMoveMode(bool value) {} // 0x0000000183BFEE90-0x0000000183BFEFF0
		// [XID] // 0x0000000189871DF0-0x0000000189871E10
		protected Vector3 GetForwardFromAngleAndDir(Vector3 dir, Vector3 angle) => default; // 0x0000000183BFFD00-0x0000000183BFFEF0
		// [IDTag] // 0x0000000189879600-0x0000000189879640
		// [XID] // 0x0000000189879600-0x0000000189879640
		protected void DetectRigidbodyVelocity() {} // 0x0000000183BFE090-0x0000000183BFE1D0
		// [IDTag] // 0x00000001898836B0-0x00000001898836F0
		// [XID] // 0x00000001898836B0-0x00000001898836F0
		public void DetectRigidbodyVelocity(int tagHash) {} // 0x0000000183BFE1D0-0x0000000183BFE320
		// [XID] // 0x0000000189A43340-0x0000000189A43360
		public float GetCurrTilt() => default; // 0x0000000183C01290-0x0000000183C01340
		// [XID] // 0x0000000189A4A820-0x0000000189A4A840
		public float GetLastTimeCurrTilt() => default; // 0x0000000183BFE400-0x0000000183BFE4B0
	}
}
