/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LCBaseCombat : LCBase // TypeDefIndex: 11707
{
	// Fields
	[NonSerialized]
	public ConfigCombat configCombat; // 0x138
	public Action<LCBaseCombat> onHPChanged; // 0x140
	public bool needCallHpChanged; // 0x148
	private MassiveEntityElementOpBatchNotify _massiveOpBatch; // 0x150
	public DieStateFlag dieStateFlag; // 0x158
	public TargetType targetType; // 0x15C
	protected bool _addToCombatEntities; // 0x160
	protected VCBaseCombat _vcCombat; // 0x168
	protected Dictionary<uint, CombatCollision> _attackeeEntityIds; // 0x170
	protected uint _lastTriggerAttackeeEntityId; // 0x178
	protected int _attackTagTriggeredFrameCount; // 0x17C
	protected HashSet<string> _attackTagTriggeredThisFrame; // 0x180
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected AttackTarget _attackTarget; // 0x188
	protected bool _isSafeDestroied; // 0x198
	private float _recoverEndureTime; // 0x19C
	private LCAttackAttenuationPlugin _attackAttenuation; // 0x1A0
	private static HashSet<System.Type> VCHandleEventRemoteList; // 0x00

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189859070-0x0000000189859090 */ get => default; } // 0x0000000182C4B320-0x0000000182C4B3C0 
	[InspectorCollapsedFoldout] // 0x000000018981F560-0x000000018981F570
	public CombatProperty combatProperty { /* [XID] */ /* 0x0000000189860230-0x0000000189860270 */ get; /* [XID] */ /* 0x000000018986AA10-0x000000018986AA50 */ set; } // 0x0000000182C40A90-0x0000000182C40AF0 0x0000000182C411C0-0x0000000182C41230
	public bool isAlive { /* [XID] */ /* 0x0000000189874A50-0x0000000189874A70 */ get => default; } // 0x0000000182C3CEE0-0x0000000182C3CFA0 
	public uint campID { /* [XID] */ /* 0x000000018987C660-0x000000018987C680 */ get => default; } // 0x0000000182C47730-0x0000000182C47810 
	public virtual bool isInCombat { /* [XID] */ /* 0x00000001899526C0-0x00000001899526E0 */ get => default; } // 0x0000000182C40930-0x0000000182C409D0 
	public ConfigCombatLock combatLock { /* [XID] */ /* 0x0000000189AFDBB0-0x0000000189AFDBF0 */ get; /* [XID] */ /* 0x0000000189B08250-0x0000000189B08290 */ private set; } // 0x0000000182C466C0-0x0000000182C46720 0x0000000182C4A3F0-0x0000000182C4A460

	// Nested types
	public struct AttackTarget // TypeDefIndex: 11708
	{
		// Fields
		public uint runtimeID; // 0x00
		public string lockedPoint; // 0x08

		// Methods
		// [XID] // 0x0000000189B8C670-0x0000000189B8C690
		public void Reset() {} // 0x0000000182C4E1F0-0x0000000182C4E220
	}

	public enum CombatCollsionType // TypeDefIndex: 11709
	{
		NoCollision = 0,
		CollisionScene = 1,
		CollisionEntity = 2
	}

	protected struct CombatCollision // TypeDefIndex: 11710
	{
		// Fields
		public float time; // 0x00
		public Collider collider; // 0x08
		public Vector3 point; // 0x10
		public Vector3 normal; // 0x1C
	}

	// Constructors
	public LCBaseCombat() {} // 0x0000000182C4B270-0x0000000182C4B320
	static LCBaseCombat() {} // 0x0000000182C4B100-0x0000000182C4B270

	// Methods
	// [XID] // 0x000000018988AEF0-0x000000018988AF10
	public override bool IsActive() => default; // 0x0000000182C44730-0x0000000182C44810
	// [XID] // 0x00000001897799A0-0x00000001897799C0
	public override void PreInit() {} // 0x0000000182C4AE40-0x0000000182C4AEF0
	// [XID] // 0x0000000189899D30-0x0000000189899D50
	public override void Init() {} // 0x0000000182C445C0-0x0000000182C44730
	// [XID] // 0x0000000189860450-0x0000000189860470
	public override void ReInit(BaseEntity.ReInitReason reason) {} // 0x0000000182C4AEF0-0x0000000182C4B050
	// [XID] // 0x000000018972D610-0x000000018972D630
	public override void Clear(BaseEntity.ClearReason clearReason) {} // 0x0000000182C3C880-0x0000000182C3CA50
	// [XID] // 0x0000000189A88600-0x0000000189A88620
	public override void Destroy() {} // 0x0000000182C3DDA0-0x0000000182C3E170
	// [XID] // 0x00000001898B74D0-0x00000001898B74F0
	protected static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000182C429F0-0x0000000182C42AC0
	// [XID] // 0x00000001898BECE0-0x00000001898BED00
	protected override bool OnEvent(BaseEvent e) => default; // 0x0000000182C49AF0-0x0000000182C49C90
	// [XID] // 0x00000001898C6520-0x00000001898C6540
	protected static new EventID[] GetSelfOnEventResolvedIDsExcludingBase() => default; // 0x0000000182C42AC0-0x0000000182C42B90
	// [XID] // 0x0000000189743DA0-0x0000000189743DC0
	protected override bool OnEventResolved(BaseEvent e) => default; // 0x0000000182C498B0-0x0000000182C49AF0
	// [XID] // 0x00000001898D5610-0x00000001898D5630
	public void OnBeingHitPostResolved(EvtBeingHit evtBeingHit) {} // 0x0000000182C46B60-0x0000000182C46CB0
	// [XID] // 0x00000001898DCF90-0x00000001898DCFB0
	protected virtual void DoHitOther(EvtHittingOther evtHittingOther) {} // 0x0000000182C49EC0-0x0000000182C4A130
	// [XID] // 0x0000000189626FF0-0x0000000189627010
	protected virtual void DoHitOtherSingle(uint targetID, AttackResult attackResult, bool ignoreCheckCanBeHitInMP) {} // 0x0000000182C404A0-0x0000000182C40890
	// [XID] // 0x00000001898EC350-0x00000001898EC370
	protected void HandleMassiveBeingHit(BaseEntity attackeeEntity, uint attackerID, uint targetID, AttackResult attackResult) {} // 0x0000000182C4AD10-0x0000000182C4AE40
	// [XID] // 0x00000001898F3D60-0x00000001898F3D80
	protected void HandleMassiveBeingHitToLocal(BaseEntity attackeeEntity, uint attackerID, uint targetID, AttackResult attackResult) {} // 0x0000000182C46F20-0x0000000182C47130
	// [XID] // 0x00000001898FB2B0-0x00000001898FB2D0
	protected void HandleMassiveBeingHitToServer(uint attackerID, AttackResult attackResult, ref AttackResultContext resultContext) {} // 0x0000000182C3ABE0-0x0000000182C3AD00
	// [XID] // 0x0000000189902E60-0x0000000189902E80
	public void HandleMassiveBeingHitToServerExternal(uint attackerID, ElementType elementType, float elementDurability, ref AttackResultContext resultContext) {} // 0x0000000182C41230-0x0000000182C41330
	// [XID] // 0x000000018990A4D0-0x000000018990A4F0
	protected void HandleMassiveBeingHitToServerInternal(uint attackerID, ElementType elementType, float elementDurability, ref AttackResultContext resultContext) {} // 0x0000000182C42C00-0x0000000182C43010
	// [XID] // 0x0000000189B61900-0x0000000189B61920
	protected virtual void DoCure(EvtCure evtCure) {} // 0x0000000182C49690-0x0000000182C49780
	// [XID] // 0x00000001899199E0-0x0000000189919A00
	protected virtual void DoBleeding(EvtBleeding evtBleeding) {} // 0x0000000182C3A760-0x0000000182C3AB10
	// [XID] // 0x0000000189920ED0-0x0000000189920EF0
	public Vector3 CalcDamageHitDir(EvtBeingHit evtBeingHit) => default; // 0x0000000182C40AF0-0x0000000182C410C0
	// [XID] // 0x00000001899288F0-0x0000000189928910
	protected virtual void DoAttackLanded(EvtAttackLanded evtAttackLanded) {} // 0x0000000182C43E00-0x0000000182C43ED0
	// [XID] // 0x000000018992FD70-0x000000018992FD90
	public virtual void DoKill(uint killerID, DieStateFlag dieType) {} // 0x0000000182C46CB0-0x0000000182C46F20
	// [XID] // 0x00000001899372B0-0x00000001899372D0
	public void RefreshDieStateFlag() {} // 0x0000000182C43ED0-0x0000000182C44020
	// [XID] // 0x000000018993ED60-0x000000018993ED80
	protected virtual void OnKillDieFlag(DieStateFlag dieType) {} // 0x0000000182C491A0-0x0000000182C49320
	// [XID] // 0x0000000189946430-0x0000000189946450
	public bool IsTarget(LCBaseCombat target, TargetType targetType) => default; // 0x0000000182C465C0-0x0000000182C466C0
	// [XID] // 0x000000018962A220-0x000000018962A240
	public virtual void InitCombatProperty() {} // 0x0000000182C3AD00-0x0000000182C3BCF0
	// [XID] // 0x0000000189B957E0-0x0000000189B95800
	protected virtual void ChangeHP(float newHP) {} // 0x0000000182C4AA90-0x0000000182C4AD10
	// [XID] // 0x0000000189BA4470-0x0000000189BA4490
	protected virtual void ChangeMaxHP(float maxHP) {} // 0x0000000182C467D0-0x0000000182C46A50
	// [XID] // 0x000000018964F8D0-0x000000018964F8F0
	protected virtual void ChangeLevel(int level, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEA712 */) {} // 0x0000000182C3CFA0-0x0000000182C3D1A0
	// [XID] // 0x000000018996B890-0x000000018996B8B0
	protected virtual void RefreshCombatProperty() {} // 0x0000000182C4A350-0x0000000182C4A3F0
	// [IDTag] // 0x0000000189973390-0x00000001899733D0
	// [XID] // 0x0000000189973390-0x00000001899733D0
	public virtual void UpdateCombatProp(PropType type, float value, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEA716 */) {} // 0x0000000182C3FC40-0x0000000182C3FE10
	// [IDTag] // 0x000000018997D480-0x000000018997D4C0
	// [XID] // 0x000000018997D480-0x000000018997D4C0
	public virtual void UpdateCombatProp(FightPropType type, float value, DataPropOp state = DataPropOp.Change /* Metadata: 0x00AEA71A */) {} // 0x0000000182C3E860-0x0000000182C3FC40
	// [XID] // 0x0000000189988230-0x0000000189988250
	protected virtual void ChangeEnergy(ElementType type, float value, DataPropOp state) {} // 0x0000000182C44020-0x0000000182C44400
	// [XID] // 0x000000018998FCC0-0x000000018998FCE0
	public float GetCombatFightProp(FightPropType type) => default; // 0x0000000182C44810-0x0000000182C45790
	// [XID] // 0x00000001897457B0-0x00000001897457D0
	public void FireHitOtherEvent(BaseEntity target, ConfigAttackInfo attackInfo, string animEventId, AbilityIdentifier? abilityIdentifier, uint? gadgetDamageActionIdx, Vector3 hitPoint, Vector3 hitForward, Collider hitCollider, bool ignoreCheckCanBeHitInMP, TargetType? targetType = default) {} // 0x0000000182C3FE10-0x0000000182C402C0
	// [XID] // 0x000000018999F150-0x000000018999F170
	public void FireHitOtherEventTileAttack(BaseEntity[] targetEntities, ConfigAttackInfo attackInfo, string animEventId, AbilityIdentifier? abilityIdentifier, uint? gadgetDamageActionIdx, Vector3[] hitPoints, Vector3 hitForward, Collider hitCollider, bool ignoreCheckCanBeHitInMP, int targetCount = -1 /* Metadata: 0x00AEA71E */) {} // 0x0000000182C41B00-0x0000000182C420F0
	// [XID] // 0x00000001899A6B50-0x00000001899A6B70
	public void FireHitOtherEventList(ref AttackResultContext resultContext, ConfigAttackInfo attackInfo, string animEventId, AbilityIdentifier? abilityIdentifier, uint? gadgetDamageActionIdx, bool ignoreCheckCanBeHitInMP, TargetType? targetType = default) {} // 0x0000000182C43010-0x0000000182C43AD0
	// [IDTag] // 0x00000001899AE3D0-0x00000001899AE410
	// [XID] // 0x00000001899AE3D0-0x00000001899AE410
	public void FireBeingHitEvent(uint attackeeRuntimeID, AttackResult attackResult) {} // 0x0000000182C481F0-0x0000000182C48380
	// [IDTag] // 0x00000001899B8A40-0x00000001899B8A80
	// [XID] // 0x00000001899B8A40-0x00000001899B8A80
	public void FireBeingHitEvent(EvtBeingHitInfo evtBeingHitInfo) {} // 0x0000000182C47E80-0x0000000182C481F0
	// [IDTag] // 0x00000001899C36D0-0x00000001899C3710
	// [XID] // 0x00000001899C36D0-0x00000001899C3710
	public void FireBeingHitEvent(EvtBeingHit evt) {} // 0x0000000182C47CC0-0x0000000182C47E80
	// [XID] // 0x00000001896F6890-0x00000001896F68B0
	public void FireAttackLandedEvent(uint attackerRuntimeID, AttackResult attackResult) {} // 0x0000000182C3CDB0-0x0000000182C3CEE0
	// [XID] // 0x00000001899D5140-0x00000001899D5160
	public void FireAttackLandedToOwner(EvtAttackLanded evtAttackLanded) {} // 0x0000000182C423D0-0x0000000182C42640
	// [XID] // 0x00000001899DC680-0x00000001899DC6A0
	public void DoAttackEvent(string animEventID) {} // 0x0000000182C48EA0-0x0000000182C491A0
	// [XID] // 0x0000000189911FF0-0x0000000189912010
	public virtual void DoSkill(uint skillID) {} // 0x0000000182C42640-0x0000000182C42810
	// [XID] // 0x0000000189919B40-0x0000000189919B60
	public virtual void DoSkillSuccess(uint skillID) {} // 0x0000000182C41A30-0x0000000182C41B00
	// [XID] // 0x00000001899F3100-0x00000001899F3120
	public virtual bool CanDoSkill(uint skillID) => default; // 0x0000000182C3DCD0-0x0000000182C3DDA0
	// [XID] // 0x00000001899FA790-0x00000001899FA7B0
	public virtual void ReleaseSkill(uint skillID) {} // 0x0000000182C45980-0x0000000182C45A30
	// [XID] // 0x0000000189775050-0x0000000189775070
	public BaseEntity GetAttackTargetEntity() => default; // 0x0000000182C47620-0x0000000182C47730
	// [XID] // 0x0000000189A09490-0x0000000189A094B0
	public AttackTarget GetAttackTarget() => default; // 0x0000000182C3C7B0-0x0000000182C3C880
	// [IDTag] // 0x0000000189A10960-0x0000000189A109A0
	// [XID] // 0x0000000189A10960-0x0000000189A109A0
	public Vector3? GetAttackTargetLockPoint(bool bulletAim = false /* Metadata: 0x00AEA722 */) => default; // 0x0000000182C460A0-0x0000000182C46500
	// [IDTag] // 0x0000000189A1AE50-0x0000000189A1AE90
	// [XID] // 0x0000000189A1AE50-0x0000000189A1AE90
	public static Vector3? GetAttackTargetLockPoint(BaseEntity entity, string lockedPoint, bool bulletAim = false /* Metadata: 0x00AEA723 */) => default; // 0x0000000182C45DF0-0x0000000182C460A0
	// [IDTag] // 0x0000000189A252B0-0x0000000189A252F0
	// [XID] // 0x0000000189A252B0-0x0000000189A252F0
	public virtual void SetAttackTarget(uint attackTargetRuntimeID, bool recoverFromServer = false /* Metadata: 0x00AEA724 */) {} // 0x0000000182C45C90-0x0000000182C45DF0
	// [IDTag] // 0x0000000189A2F890-0x0000000189A2F8D0
	// [XID] // 0x0000000189A2F890-0x0000000189A2F8D0
	public virtual void SetAttackTarget(uint attackTargetRuntimeID, string lockPoint) {} // 0x0000000182C45B00-0x0000000182C45C90
	// [XID] // 0x0000000189A3A0B0-0x0000000189A3A0D0
	public virtual void SelectAttackTarget(bool force) {} // 0x0000000182C46720-0x0000000182C467D0
	// [XID] // 0x0000000189970260-0x0000000189970280
	protected bool IsCurAttackTarget(uint runtimeID, string lockPoint) => default; // 0x0000000182C46A50-0x0000000182C46B60
	// [XID] // 0x0000000189A48F90-0x0000000189A48FB0
	public virtual ConfigAttackEvent GetAttackEventConfig(string animEventID) => default; // 0x0000000182C43AD0-0x0000000182C43C20
	// [XID] // 0x00000001898E8020-0x00000001898E8040
	public virtual void SafeDestroySelfEntity(bool forceDestroy = false /* Metadata: 0x00AEA725 */) {} // 0x0000000182C3CA50-0x0000000182C3CC00
	// [XID] // 0x00000001898EF750-0x00000001898EF770
	public virtual void KillByOther() {} // 0x0000000182C420F0-0x0000000182C421A0
	// [XID] // 0x0000000189A5F9F0-0x0000000189A5FA10
	public virtual void KillByTimer() {} // 0x0000000182C47300-0x0000000182C473B0
	// [XID] // 0x0000000189A67310-0x0000000189A67330
	public bool TryAddAttackeeEntityId(TriggerType trigger, float triggerCD, uint id, Collider collider, Vector3 point, Vector3 normal) => default; // 0x0000000182C47130-0x0000000182C47300
	// [XID] // 0x0000000189A6E960-0x0000000189A6E980
	public bool HasAttackeeEntityid(uint id) => default; // 0x0000000182C47810-0x0000000182C478E0
	// [XID] // 0x0000000189A761D0-0x0000000189A761F0
	private bool CheckCanAttackByTriggerType(TriggerType trigger, float triggerCD, uint id) => default; // 0x0000000182C402C0-0x0000000182C404A0
	// [XID] // 0x0000000189A7DBC0-0x0000000189A7DBE0
	private void AddAttackedEntityId(uint id, Collider collider, Vector3 point, Vector3 normal) {} // 0x0000000182C48700-0x0000000182C48970
	// [XID] // 0x0000000189A85470-0x0000000189A85490
	public CombatCollsionType GetLastCollisionType() => default; // 0x0000000182C409D0-0x0000000182C40A90
	// [XID] // 0x0000000189A8CE60-0x0000000189A8CE80
	public Vector3 GetLastCollisionPosition() => default; // 0x0000000182C3C0A0-0x0000000182C3C2C0
	// [XID] // 0x000000018992E970-0x000000018992E990
	public Vector3 GetLastCollisionHitNormal() => default; // 0x0000000182C4A130-0x0000000182C4A350
	// [XID] // 0x0000000189A9BB40-0x0000000189A9BB60
	public Collider GetLastHitCollider() => default; // 0x0000000182C4A900-0x0000000182C4AA90
	// [XID] // 0x0000000189AA3000-0x0000000189AA3020
	public uint GetLastTriggerAttackeeEntityId() => default; // 0x0000000182C40890-0x0000000182C40930
	// [XID] // 0x0000000189AAA510-0x0000000189AAA530
	public bool CheckAttackeeColliderNotChange(uint id, Collider collider) => default; // 0x0000000182C421A0-0x0000000182C422F0
	// [XID] // 0x0000000189944D30-0x0000000189944D50
	public void RemoveAllAttackeeEntities() {} // 0x0000000182C45A30-0x0000000182C45B00
	// [XID] // 0x0000000189AB9800-0x0000000189AB9820
	public bool TryTriggerAttackTag(string attackTag) => default; // 0x0000000182C48510-0x0000000182C48690
	// [XID] // 0x0000000189AC1370-0x0000000189AC1390
	protected override void Tick(float inDeltaTime) {} // 0x0000000182C4B050-0x0000000182C4B100
	// [XID] // 0x0000000189ADB3D0-0x0000000189ADB3F0
	private void InternalUpdateEndure() {} // 0x0000000182C4A460-0x0000000182C4A900
	// [XID] // 0x00000001896240C0-0x00000001896240E0
	public void UpdateEndure(float enBreak) {} // 0x0000000182C3BCF0-0x0000000182C3C020
	// [XID] // 0x000000018994C410-0x000000018994C430
	public void ClearEndure(float percent) {} // 0x0000000182C49320-0x0000000182C49690
	// [XID] // 0x0000000189ADFE00-0x0000000189ADFE20
	public uint CountAttackAttenuation(uint attackerRuntimeID, string group, string tag) => default; // 0x0000000182C44400-0x0000000182C445C0
	// [XID] // 0x0000000189AE7460-0x0000000189AE7480
	public float GetElemDurabilityAttenuation(uint attackerRuntimeID, string group, string tag, uint attackCount) => default; // 0x0000000182C42810-0x0000000182C429F0
	// [XID] // 0x0000000189AEF1D0-0x0000000189AEF1F0
	public float GetEnbreakAttenuation(uint attackerRuntimeID, string group, string tag, uint attackCount) => default; // 0x0000000182C43C20-0x0000000182C43E00
	// [XID] // 0x000000018971E960-0x000000018971E980
	public float GetDamageAttenuation(uint attackerRuntimeID, string group, string tag, uint attackCount) => default; // 0x0000000182C3C2C0-0x0000000182C3C4A0
	// [XID] // 0x0000000189797820-0x0000000189797840
	private void InitCombatLock() {} // 0x0000000182C45790-0x0000000182C45980
	// [XID] // 0x0000000189B19E40-0x0000000189B19E60
	private void DestroyCombatLock() {} // 0x0000000182C422F0-0x0000000182C423D0
	// [XID] // 0x00000001899001F0-0x0000000189900210
	public void GetLockTargetScore(BaseShape2d shape, BaseEntity targetEntity, Vector3 entityForward, Vector3 pushForward, bool checkCamera, SimpleSafeFloat[] weights, float overrideE, ref float? maxScore, ref string lockPoint) {} // 0x0000000182C3D220-0x0000000182C3DCD0
	// [XID] // 0x0000000189968B70-0x0000000189968B90
	private void GetScore(BaseShape2d shape, float? range, Vector3 targetPosition, uint targetRuntimeID, string targetHitBox, bool inCombat, Vector3 entityPosition, Vector3 entityForward, Vector3 pushForward, float pri, float C, float D, float E, float G, ref float? maxScore, ref string lockPoint) {} // 0x0000000182C41330-0x0000000182C41A30
	[Preserve] // 0x0000000189B300D0-0x0000000189B30110
	// [XID] // 0x0000000189B300D0-0x0000000189B30110
	public override string Dump() => default; // 0x0000000182C3E170-0x0000000182C3E860
	// [XID] // 0x0000000189B3A980-0x0000000189B3A9A0
	private void HandleVCCombatRemoteEvent(BaseEvent e) {} // 0x0000000182C479D0-0x0000000182C47CC0
	// [XID] // 0x0000000189962F60-0x0000000189962F80
	protected override bool OnRemoteEvtBeingHit(BaseEvent e) => default; // 0x0000000182C49DA0-0x0000000182C49EC0
	// [XID] // 0x0000000189980B10-0x0000000189980B30
	protected override bool OnEventReconcile(BaseEvent e) => default; // 0x0000000182C49780-0x0000000182C498B0
	// [XID] // 0x000000018998FE00-0x000000018998FE20
	protected override bool OnRemoteEvtBeingHitResolved(BaseEvent e) => default; // 0x0000000182C49C90-0x0000000182C49DA0
	// [XID] // 0x0000000189B58D20-0x0000000189B58D40
	protected virtual void DoDamage(EvtBeingHit evtBeingHit) {} // 0x0000000182C48970-0x0000000182C48EA0
	// [XID] // 0x0000000189B603F0-0x0000000189B60410
	protected virtual void DoDamageResolved(EvtBeingHit evtBeingHit) {} // 0x0000000182C3A190-0x0000000182C3A760
	// [XID] // 0x0000000189B67BB0-0x0000000189B67BD0
	protected virtual void DoDamageResolvedReconcile(AttackResult attackResult, uint otherID) {} // 0x0000000182C48380-0x0000000182C48510
	// [XID] // 0x0000000189B6EE90-0x0000000189B6EEB0
	protected virtual void DoDamageResolvedRemote(EvtBeingHit evtBeingHit) {} // 0x0000000182C3CC70-0x0000000182C3CDB0
	// [XID] // 0x0000000189705330-0x0000000189705350
	protected bool CanChangeHP(CombatProperty prop) => default; // 0x0000000182C3C4A0-0x0000000182C3C730
	// [XID] // 0x0000000189B7DC20-0x0000000189B7DC40
	protected void CheckAlive(uint sourceEntityId) {} // 0x0000000182C473B0-0x0000000182C47620
}

