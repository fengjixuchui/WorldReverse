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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class VCScenePropAccurateMoveBase : VCBaseMove // TypeDefIndex: 11948
{
	// Fields
	protected Transform _colliderRoot; // 0x1D8
	protected Transform _renderRoot; // 0x1E0
	protected ulong _lastTime; // 0x1E8
	protected ulong _currentTime; // 0x1F0
	protected float _deltaTime; // 0x1F8
	protected ScenePropAccurateMoveType _moveType; // 0x1FC
	public uint lastCalcSceneTime; // 0x200
	public uint currentCalcSceneTime; // 0x204
	protected Dictionary<Transform, PosRotPair> _colliderLastStates; // 0x208
	protected Dictionary<Transform, PosRotPair> _colliderPredictStats; // 0x210
	protected LevelMoveScenePropPlugin _scenePropPlugin; // 0x218
	protected int _lastMoveColliderImmediatelyFrame; // 0x220

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001896B8530-0x00000001896B8550 */ get; } // 0x0000000181291BA0-0x0000000181291C40 

	// Nested types
	protected struct PosRotPair // TypeDefIndex: 11949
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C

		// Constructors
		public PosRotPair(Vector3 position, Quaternion rotation) {
			this.position = default;
			this.rotation = default;
		} // 0x000000018128CD30-0x000000018128CDC0
	}

	// Constructors
	protected VCScenePropAccurateMoveBase() {} // 0x0000000181291AB0-0x0000000181291BA0

	// Methods
	// [XID] // 0x00000001896A9BB0-0x00000001896A9BD0
	public override void Init() {} // 0x0000000181290930-0x0000000181290B50
	// [XID] // 0x00000001896C6FB0-0x00000001896C6FD0
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x00000001812919B0-0x0000000181291AB0
	// [XID] // 0x00000001896CE600-0x00000001896CE620
	public override void Destroy() {} // 0x000000018128FA40-0x000000018128FB40
	// [XID] // 0x00000001896D5AF0-0x00000001896D5B10
	public virtual void InitScenePropAccurateMove() {} // 0x000000018128FD20-0x0000000181290760
	// [XID] // 0x00000001896DCFF0-0x00000001896DD010
	protected override void InitVelocityForce() {} // 0x0000000181290B50-0x0000000181290BF0
	// [XID] // 0x00000001896E49B0-0x00000001896E49D0
	protected override void LateTick(float inDeltaTime) {} // 0x0000000181290E20-0x0000000181291120
	// [XID] // 0x00000001896EBE10-0x00000001896EBE30
	public virtual void MoveColliderToPredictedPositionRotation() {} // 0x000000018128F4F0-0x000000018128F840
	public abstract void CalcMoveState(float CalcMoveState);
	// [XID] // 0x00000001896F3490-0x00000001896F34B0
	public override void TrySteer(bool isMoving, float joystickAngle) {} // 0x00000001812918F0-0x00000001812919B0
	// [XID] // 0x00000001896FAC10-0x00000001896FAC30
	public override void TrySteerWithAngle(Vector3 targetDir, VCMoveData.MotionDirection motionDir) {} // 0x000000018128FC50-0x000000018128FD20
	// [XID] // 0x0000000189702240-0x0000000189702260
	public override void SetPassThroughCharacter(bool passThrough) {} // 0x000000018128FB40-0x000000018128FBF0
	// [XID] // 0x0000000189794260-0x0000000189794280
	public virtual bool GetPosAtTime(uint timeStamp, ref Vector3 pos) => default; // 0x00000001812916C0-0x0000000181291790
	// [XID] // 0x00000001897113F0-0x0000000189711410
	public override void OnEnable() {} // 0x0000000181291840-0x00000001812918F0
	// [XID] // 0x0000000189718920-0x0000000189718940
	public override void OnDisable() {} // 0x0000000181291790-0x0000000181291840
	// [XID] // 0x0000000189754790-0x00000001897547B0
	public virtual Vector3 GetRefferenceSystemMove(Collider col) => default; // 0x0000000181291120-0x0000000181291410
	// [XID] // 0x0000000189727820-0x0000000189727840
	public virtual Vector3 GetRefferenceSystemMoveVelocity(Collider col) => default; // 0x00000001812907C0-0x0000000181290930
	// [XID] // 0x000000018972ED10-0x000000018972ED30
	public virtual Vector3 GetPredictNextPosition() => default; // 0x0000000181291480-0x00000001812916C0
	// [XID] // 0x0000000189736450-0x0000000189736470
	public virtual void MonsterOrNPCDetected() {} // 0x0000000181290C50-0x0000000181290CF0
	// [XID] // 0x0000000189BDD290-0x0000000189BDD2B0
	public virtual void MoveColliderImmediately() {} // 0x0000000181290CF0-0x0000000181290D90
}

