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

public sealed class LevelSyncCombatPlugin : BaseComponentPlugin // TypeDefIndex: 12123
{
	// Fields
	public const float FLUSH_INTERVAL_SINGLE = 0.1f; // Metadata: 0x00AEB52F
	public const float FLUSH_INTERVAL_MULTIPLAYER = 0f; // Metadata: 0x00AEB533
	private List<CombatEntryProxy> _invokeCombats; // 0x58
	private const int FORCE_FLUSH_CAP = 20; // Metadata: 0x00AEB537
	private float _flushTimeAcc; // 0x60

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B7DB80-0x0000000189B7DBA0 */ get => default; } // 0x000000018347DD80-0x000000018347DE20 

	// Constructors
	public LevelSyncCombatPlugin() {} // 0x000000018347DCF0-0x000000018347DD80

	// Methods
	// [XID] // 0x0000000189B85800-0x0000000189B85820
	public void ClearRecordInvokeEntries() {} // 0x000000018347C540-0x000000018347C5F0
	// [XID] // 0x0000000189B8C5F0-0x0000000189B8C610
	public void AddInvokeEntry(CombatEntryProxy combatEntry) {} // 0x000000018347A4B0-0x000000018347A610
	// [XID] // 0x0000000189B93FB0-0x0000000189B93FD0
	public void OnFrameEndTryFlushInvokes() {} // 0x000000018347B100-0x000000018347B210
	// [XID] // 0x0000000189B9B570-0x0000000189B9B590
	public void TickFlushTimeAcc() {} // 0x000000018347B210-0x000000018347B2B0
	// [XID] // 0x0000000189928A50-0x0000000189928A70
	public void FlushRecordInvokeEntriesAndSend() {} // 0x000000018347A610-0x000000018347A980
	public void AddCombatMessage<T>(T message, CombatTypeArgument argument)
		where T : MessageBase {}
	// [XID] // 0x0000000189BAA100-0x0000000189BAA120
	public void SendEvtBeingHit(EvtBeingHit evtBeingHit) {} // 0x000000018347D640-0x000000018347D9F0
	// [XID] // 0x0000000189BB1920-0x0000000189BB1940
	public void SendSetAttackTarget(uint runtimeID, uint attackTargetRuntimeID) {} // 0x000000018347C5F0-0x000000018347C770
	// [XID] // 0x0000000189BB8940-0x0000000189BB8960
	public void SendEvtAnimatorStateChanged(BaseEntity entity, uint toStateHash, uint normalizedTimeCompact, int faceAngleCompact, float fadeDuration) {} // 0x000000018347B4E0-0x000000018347B7D0
	// [XID] // 0x0000000189BC02E0-0x0000000189BC0300
	public void SendEvtCompensatePosDiff(BaseEntity entity, uint curHash, Vector3 curPos, int faceAngleCompact, uint normalizedTimeCompact) {} // 0x000000018347CDB0-0x000000018347D070
	// [XID] // 0x0000000189B16EC0-0x0000000189B16EE0
	public void SendEvtAnimatorParameterChanged(BaseEntity entity, AnimatorParameterEntry entry, bool reliable, bool isServerCache) {} // 0x000000018347C270-0x000000018347C540
	// [XID] // 0x0000000189BCF850-0x0000000189BCF870
	public void SendFaceToDir(uint runtimeID, Vector3 forward) {} // 0x000000018347AF00-0x000000018347B100
	// [XID] // 0x0000000189A82540-0x0000000189A82560
	public void SendTransform(uint runtimeID, Vector3 pos, Vector3 eulerAngle) {} // 0x000000018347C010-0x000000018347C270
	// [XID] // 0x0000000189BDEA00-0x0000000189BDEA20
	public void SendMotionInfoDuringSteerAttack(uint runtimeID, Vector3 velocity, Vector3 forward, Vector3 pos) {} // 0x000000018347A980-0x000000018347AC40
	// [XID] // 0x00000001898A7100-0x00000001898A7120
	public void SendCombatForceSetPos(uint runtimeID, Vector3 targetPos, uint colliderEntityId, uint iceID) {} // 0x000000018347B2B0-0x000000018347B4E0
	// [XID] // 0x00000001895F28E0-0x00000001895F2900
	public void SendEvtRushMove(uint runtimeID, Vector3 velocity, float timeRange, int shortNameHash, Vector3 forward, Vector3 pos, Vector3 attackTargetPos, Vector3 rushToPos) {} // 0x000000018347BB40-0x000000018347BEF0
	// [XID] // 0x00000001895FA240-0x00000001895FA260
	public void RequestSceneEntityMoveReq(uint entityId, MotionInfo motion, bool isReliable, uint reliableSeq) {} // 0x000000018347C770-0x000000018347CDB0
	// [XID] // 0x0000000189703B40-0x0000000189703B60
	public void NotifyLandVelocity(uint entityId, MotionInfo motion) {} // 0x000000018347D1C0-0x000000018347D640
	// [XID] // 0x0000000189609420-0x0000000189609440
	public void SendSyncEntityPositionByNormalizedTime(BaseEntity entity, uint stateHash, uint normalizedTimeCompact) {} // 0x000000018347AC40-0x000000018347AF00
	// [XID] // 0x0000000189610BA0-0x0000000189610BC0
	public void SendFixedRushMove(BaseEntity entity, float speed, Vector3 targetPos, string overrideCollider, string[] animatorStateIDs, bool needSetIsInAir, bool checkAnimatorStateOnExitOnly) {} // 0x000000018347B7D0-0x000000018347BB40
	// [XID] // 0x0000000189617E70-0x0000000189617E90
	public void SendDoBlink(BaseEntity entity, Vector3 pos, Vector3 forward) {} // 0x000000018347D9F0-0x000000018347DCF0
	// [XID] // 0x000000018961FB50-0x000000018961FB70
	private EntityMoveInfo AllocateMoveInfo() => default; // 0x000000018347BEF0-0x000000018347C010
	// [XID] // 0x0000000189626E30-0x0000000189626E50
	public void CopyMotionInfo(MotionInfo dst, MotionInfo src) {} // 0x000000018347D0E0-0x000000018347D1C0
}

