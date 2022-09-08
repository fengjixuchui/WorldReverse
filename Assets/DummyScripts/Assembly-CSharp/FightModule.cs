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

public sealed class FightModule : BaseModule // TypeDefIndex: 21475
{
	// Fields
	private bool _disableAvatarSkillByServer; // 0x10
	private bool _disableAvatarSkillByClient; // 0x11
	private LevelSyncAbilityPlugin _abilitySyncPlugin; // 0x18
	private LevelSyncCombatPlugin _combatSyncPlugin; // 0x20
	private List<CollisionResult> _massiveEntityOpList; // 0x28
	private Action<BaseEntity, EvtBeingHitInfo> _onServerEvtBeingHit; // 0x30
	private Action<BaseEntity, EvtSyncEntityPositionInfo> _onServerEvtSyncEntityPosition; // 0x38
	private Action<BaseEntity, EvtAnimatorStateChangedInfo> _onServerEvtAnimatorStateChanged; // 0x40
	private Action<BaseEntity, EvtAnimatorParameterInfo> _onServerEvtAnimatorParameterChanged; // 0x48
	private Action<MessageBase> onServerEvtEntityRenderersChangedHandler; // 0x50
	private Action<BaseEntity, EvtFaceToDirInfo> _onServerEvtFaceToDir; // 0x58
	private Action<BaseEntity, EvtSyncTransform> _onServerEvtSyncTransform; // 0x60
	private Action<BaseEntity, EvtSetAttackTargetInfo> _onServerEvtSetAttackTarget; // 0x68
	private static Action<EvtEntityReadyPost> _onEntityReadyPostCallback; // 0x00
	private Action<BaseEntity, EvtRushMoveInfo> _onServerEvtRushMove; // 0x70
	private Action<BaseEntity, EvtCombatSteerMotionInfo> _onServerEvtCombatSteerMotionInfo; // 0x78
	private Action<BaseEntity, EvtCombatForceSetPosInfo> _onServerEvtCombatForceSetPosInfo; // 0x80
	private Action<BaseEntity, EvtCompensatePosDiffInfo> _onServerEvtCompensatePosDiffInfo; // 0x88
	private Action<BaseEntity, EvtFixedRushMove> _onServerEvtFixedRushMove; // 0x90
	private Action<BaseEntity, EvtMonsterDoBlink> _onServerEvtMonsterDoBlink; // 0x98
	private Action<MessageBase> entityAuthorityChangeNotifyHandler; // 0xA0
	public bool isDuringBeingHitCalculate; // 0xA8
	public List<SendPacketData> delaySendList; // 0xB0
	public Stack<MPActorAbilityPlugin> currentInitiatingAbilityPluginStack; // 0xB8
	private Action<MessageBase> _onMonsterPointArrayRouteUpdateNotify; // 0xC0

	// Properties
	public bool disableAvatarSkillByServer { /* [XID] */ /* 0x0000000189BC6FB0-0x0000000189BC6FD0 */ get => default; /* [XID] */ /* 0x0000000189BBF3F0-0x0000000189BBF410 */ private set {} } // 0x00000001818ED290-0x00000001818ED330 0x00000001818DD300-0x00000001818DD3E0
	public bool disableAvatarSkillByClient { /* [XID] */ /* 0x0000000189BD6040-0x0000000189BD6060 */ get => default; /* [XID] */ /* 0x0000000189BCECE0-0x0000000189BCED00 */ set {} } // 0x00000001818E6FC0-0x00000001818E7060 0x00000001818ECA90-0x00000001818ECB70
	public bool disableAvatarSkill { /* [XID] */ /* 0x0000000189BDDC00-0x0000000189BDDC20 */ get => default; } // 0x00000001818EC750-0x00000001818EC820 
	public LevelSyncAbilityPlugin abilitySyncPlugin { /* [XID] */ /* 0x00000001895F1CF0-0x00000001895F1D10 */ get => default; } // 0x00000001818D55C0-0x00000001818D56D0 
	public LevelSyncCombatPlugin combatSyncPlugin { /* [XID] */ /* 0x0000000189670E90-0x0000000189670EB0 */ get => default; } // 0x00000001818D61A0-0x00000001818D62B0 

	// Constructors
	public FightModule() {} // 0x00000001818EFAA0-0x00000001818EFE10
	static FightModule() {} // 0x00000001818EF9D0-0x00000001818EFAA0

	// Methods
	// [XID] // 0x00000001895EA780-0x00000001895EA7A0
	private void OnAvatarSkillEnableChanged() {} // 0x00000001818EB890-0x00000001818EBA20
	// [XID] // 0x0000000189600D60-0x0000000189600D80
	public override bool OnPacket(Packet pkt) => default; // 0x00000001818D6E60-0x00000001818D7B50
	// [XID] // 0x00000001896086D0-0x00000001896086F0
	private void OnSyncAiInfoNotify(EntityAiSyncNotify entityAiSyncNotify) {} // 0x00000001818DF7D0-0x00000001818DFA90
	// [XID] // 0x000000018960FEF0-0x000000018960FF10
	private void OnMassiveEntityElementBatchOpNotify(MassiveEntityElementOpBatchNotify notify) {} // 0x00000001818DD500-0x00000001818DD920
	// [XID] // 0x0000000189617230-0x0000000189617250
	private void OnServerEvtBeingHitCombine(EvtBeingHitsCombineNotify messageBeingHitsCombine, uint cleintSequenceId) {} // 0x00000001818D8750-0x00000001818D8AE0
	// [XID] // 0x000000018961EE20-0x000000018961EE40
	private void OnCombatInvocationsNotify(UnionCombatInvocationsNotify notify, uint clientSequenceId) {} // 0x00000001818E06C0-0x00000001818E0A50
	private void DoServerCombat<T>(T message, uint entityRuntimeID, DualClientSequenceId clientSequenceId, Action<BaseEntity, T> OnEvtImpAction)
		where T : MessageBase {}
	// [XID] // 0x00000001896261A0-0x00000001896261C0
	private void DoSingleCombatInvoke(UnionCombatInvokeEntry invoke, DualClientSequenceId clientSequenceId) {} // 0x00000001818ED800-0x00000001818EE420
	private void OnServerEvtNotify<T>(T message, uint entityRuntimeID, uint clientSequenceId, Action<BaseEntity, T> OnEvtImpAction)
		where T : MessageBase, IMessage<T>, new() {}
	// [XID] // 0x000000018962DBB0-0x000000018962DBD0
	public void OnServerEvtBeingHit(BaseEntity entity, EvtBeingHitInfo evtBeingHit) {} // 0x00000001818DC390-0x00000001818DC6D0
	// [XID] // 0x000000018993C190-0x000000018993C1B0
	public void OnServerEvtSyncEntityPosition(BaseEntity entity, EvtSyncEntityPositionInfo evtSyncEntityPositionInfo) {} // 0x00000001818E6CB0-0x00000001818E6FC0
	// [XID] // 0x000000018984A450-0x000000018984A470
	public void OnServerEvtAnimatorStateChanged(BaseEntity entity, EvtAnimatorStateChangedInfo evtAnimatorStateChanged) {} // 0x00000001818E8190-0x00000001818E8610
	// [IDTag] // 0x00000001896443F0-0x0000000189644430
	// [XID] // 0x00000001896443F0-0x0000000189644430
	private void OnServerEvtAnimatorParameterChanged(EvtAnimatorParameterInfo message, uint clientSequenceId) {} // 0x00000001818DABF0-0x00000001818DB4A0
	// [IDTag] // 0x000000018964EA60-0x000000018964EAA0
	// [XID] // 0x000000018964EA60-0x000000018964EAA0
	public void OnServerEvtAnimatorParameterChanged(BaseEntity entity, EvtAnimatorParameterInfo evtAnimatorParameter) {} // 0x00000001818DA450-0x00000001818DABF0
	// [XID] // 0x0000000189659270-0x0000000189659290
	public void OnServerEvtEntityRenderersChangedProxy(EvtEntityRenderersChangedNotify evtEntityRenderersChanged) {} // 0x00000001818EAC80-0x00000001818EADA0
	// [XID] // 0x00000001896608F0-0x0000000189660910
	public void OnServerEvtEntityRenderersChanged(MessageBase imessage) {} // 0x00000001818DCD10-0x00000001818DCEB0
	// [XID] // 0x0000000189668300-0x0000000189668320
	public void OnServerEvtFaceToDir(BaseEntity entity, EvtFaceToDirInfo evtFaceToDir) {} // 0x00000001818E4060-0x00000001818E41B0
	// [XID] // 0x000000018966FDD0-0x000000018966FDF0
	public void OnServerEvtSyncTransform(BaseEntity entity, EvtSyncTransform evtFaceToDir) {} // 0x00000001818DFA90-0x00000001818DFBF0
	// [XID] // 0x00000001896775E0-0x0000000189677600
	public void OnServerEvtSetAttackTarget(BaseEntity entity, EvtSetAttackTargetInfo evtSetAttackTarget) {} // 0x00000001818D8F80-0x00000001818D91F0
	// [XID] // 0x000000018967EBC0-0x000000018967EBE0
	private void OnMonsterForceAlert(MonsterForceAlertNotify monsterForceAlertNotify) {} // 0x00000001818E0500-0x00000001818E06C0
	// [XID] // 0x00000001896864B0-0x00000001896864D0
	private static void OnEntityReadyPostCallback(EvtEntityReadyPost evt) {} // 0x00000001818E0430-0x00000001818E0500
	// [XID] // 0x000000018968E310-0x000000018968E330
	public void OnServerEvtRushMove(BaseEntity entity, EvtRushMoveInfo evtRushMove) {} // 0x00000001818DD920-0x00000001818DE700
	// [XID] // 0x0000000189695BB0-0x0000000189695BD0
	public void OnServerEvtCombatSteerMotionInfo(BaseEntity entity, EvtCombatSteerMotionInfo evtSteer) {} // 0x00000001818E28B0-0x00000001818E2A70
	// [XID] // 0x000000018969D2E0-0x000000018969D300
	public void OnServerEvtCombatForceSetPosInfo(BaseEntity entity, EvtCombatForceSetPosInfo evtForceSet) {} // 0x00000001818EA250-0x00000001818EA3B0
	// [XID] // 0x0000000189943570-0x0000000189943590
	public void OnServerEvtCompensatePosDiffInfo(BaseEntity entity, EvtCompensatePosDiffInfo evtCompensatePos) {} // 0x00000001818E8DE0-0x00000001818E9050
	// [XID] // 0x000000018994AC40-0x000000018994AC60
	public void OnServerEvtFixedRushMove(BaseEntity entity, EvtFixedRushMove evtFixedRushMove) {} // 0x00000001818ECB70-0x00000001818ECF30
	// [XID] // 0x0000000189999380-0x00000001899993A0
	public void OnServerEvtMonsterDoBlink(BaseEntity entity, EvtMonsterDoBlink evtMonsterDoBlink) {} // 0x00000001818D91F0-0x00000001818D93A0
	// [XID] // 0x00000001896BA410-0x00000001896BA430
	private void OnServerEvtBulletHit(EvtBulletHitNotify evtBulletHitNotify) {} // 0x00000001818DE700-0x00000001818DF7D0
	// [XID] // 0x00000001896C1660-0x00000001896C1680
	private void OnServerEvtBulletDeactive(EvtBulletDeactiveNotify evtBulletDeactiveNotify) {} // 0x00000001818D56D0-0x00000001818D5B40
	// [XID] // 0x00000001896C8DA0-0x00000001896C8DC0
	private void OnServerEvtBulletMove(EvtBulletMoveNotify evtBulletMoveNotify) {} // 0x00000001818D5C70-0x00000001818D60C0
	// [XID] // 0x00000001896D0740-0x00000001896D0760
	private void OnServerEvtEntityStartDieEnd(EvtEntityStartDieEndNotify evtEntityStartDieEndNotify) {} // 0x00000001818EE9C0-0x00000001818EEE20
	// [XID] // 0x00000001896D7C70-0x00000001896D7C90
	private void OnPacketAbilityInvocationFixed(UnionAbilityInvocationFixedNotify notify) {} // 0x00000001818D9870-0x00000001818D9B60
	// [XID] // 0x00000001896DF4C0-0x00000001896DF4E0
	private void OnPacketAbilityInvocations(UnionAbilityInvocationsNotify notify) {} // 0x00000001818D6380-0x00000001818D6650
	// [XID] // 0x00000001896E6860-0x00000001896E6880
	private void OnClientInitFinishNotify(UnionClientAbilityInitFinishNotify notify) {} // 0x00000001818EA630-0x00000001818EA800
	// [XID] // 0x00000001896EDE70-0x00000001896EDE90
	private void OnClientAbilityChangeNotify(UnionClientAbilityChangeNotify notify) {} // 0x00000001818EC580-0x00000001818EC750
	// [XID] // 0x00000001896F5690-0x00000001896F56B0
	private void OnClientAbilitiesInitFinishCombineNotify(UnionClientAbilitiesInitFinishCombineNotify notify) {} // 0x00000001818EA3B0-0x00000001818EA630
	// [XID] // 0x00000001896FCE70-0x00000001896FCE90
	private void DoEntityAblityInitFinish(RepeatedMessageField<UnionAbilityInvokeEntry> invokes) {} // 0x00000001818DA270-0x00000001818DA450
	// [XID] // 0x0000000189704320-0x0000000189704340
	public bool IsOwnerAuthorityChanged(BaseEntity entity) => default; // 0x00000001818E7640-0x00000001818E7900
	// [XID] // 0x000000018970BB90-0x000000018970BBB0
	private void DoAbilityInitFinishInvokeEntry(UnionAbilityInvokeEntry invoke) {} // 0x00000001818E9050-0x00000001818E9610
	// [XID] // 0x0000000189713400-0x0000000189713420
	private void DoAbilityInvokeEntry(UnionAbilityInvokeEntry invoke) {} // 0x00000001818DC0C0-0x00000001818DC390
	// [XID] // 0x000000018971AC80-0x000000018971ACA0
	private void DoAbilityInvokeEntryImpl(UnionAbilityInvokeEntry invoke, BaseEntity entity, bool needCloneInvoke) {} // 0x00000001818E9D80-0x00000001818E9FD0
	// [XID] // 0x0000000189721FC0-0x0000000189721FE0
	private void DispatchSingleAbilityInvoke(LCAbility abilityCom, UnionAbilityInvokeEntry invokeEntry) {} // 0x00000001818E0A50-0x00000001818E16F0
	// [XID] // 0x00000001897296D0-0x00000001897296F0
	private void OnAbilityChangeNotify(AbilityChangeNotify notify) {} // 0x00000001818E8610-0x00000001818E87E0
	// [XID] // 0x0000000189730EE0-0x0000000189730F00
	private void OnServerBuffChangeNotify(ServerBuffChangeNotify sBuffChangeNotify) {} // 0x00000001818E2FB0-0x00000001818E3320
	// [XID] // 0x0000000189738790-0x00000001897387B0
	private void OnServerEvtAvatarEnterFocus(EvtAvatarEnterFocusNotify notify) {} // 0x00000001818E5F00-0x00000001818E6260
	// [XID] // 0x00000001897404D0-0x00000001897404F0
	private void OnServerEvtAvatarExitFocus(EvtAvatarExitFocusNotify notify) {} // 0x00000001818E4E60-0x00000001818E50D0
	// [XID] // 0x0000000189747870-0x0000000189747890
	private void OnServerEvtAvatarUpdateFocus(EvtAvatarUpdateFocusNotify notify) {} // 0x00000001818D8C90-0x00000001818D8F80
	// [XID] // 0x000000018974EFF0-0x000000018974F010
	private void OnEntityAuthorityChangeNotify(EntityAuthorityChangeNotify notify) {} // 0x00000001818EA800-0x00000001818EAA80
	// [XID] // 0x0000000189756720-0x0000000189756740
	public void OnEntityAuthorityChangeNotifyHandler(MessageBase imessage) {} // 0x00000001818DBCF0-0x00000001818DC0C0
	// [XID] // 0x000000018975DB50-0x000000018975DB70
	private void OnAbilityInvocationFailNotify(AbilityInvocationFailNotify notify) {} // 0x00000001818E3560-0x00000001818E3960
	// [XID] // 0x0000000189765140-0x0000000189765160
	private void OnHostPlayerNotify(HostPlayerNotify notify) {} // 0x00000001818E9FD0-0x00000001818EA250
	// [XID] // 0x000000018976CC00-0x000000018976CC20
	private void OnServerLogNotify(ServerLogNotify notify) {} // 0x00000001818E22C0-0x00000001818E25F0
	// [XID] // 0x0000000189774040-0x0000000189774060
	private void OnTriggerCreateGadgetToEquipPartNotify(TriggerCreateGadgetToEquipPartNotify notify) {} // 0x00000001818E5320-0x00000001818E5710
	// [XID] // 0x000000018977B780-0x000000018977B7A0
	private void OnCreateMassiveEntityRsp(CreateMassiveEntityRsp rsp) {} // 0x00000001818E0240-0x00000001818E0390
	// [XID] // 0x0000000189783210-0x0000000189783230
	private void OnCreateMassiveEntityNotify(CreateMassiveEntityNotify notify) {} // 0x00000001818E7900-0x00000001818E7FF0
	// [XID] // 0x000000018978A820-0x000000018978A840
	private void OnDestroyMassiveEntityNotify(DestroyMassiveEntityNotify notify) {} // 0x00000001818E9780-0x00000001818E9D80
	// [XID] // 0x0000000189791E80-0x0000000189791EA0
	private void OnMassiveEntityStateChangedNotify(MassiveEntityStateChangedNotify notify) {} // 0x00000001818DC6D0-0x00000001818DCD10
	// [XID] // 0x0000000189799550-0x0000000189799570
	private void OnServerEvtAvatarSitDown(EvtAvatarSitDownNotify notify) {} // 0x00000001818E5790-0x00000001818E5AB0
	// [XID] // 0x00000001897A1440-0x00000001897A1460
	private void OnServerEvtAvatarStandUp(EvtAvatarStandUpNotify notify) {} // 0x00000001818E73F0-0x00000001818E7640
	// [XID] // 0x00000001897A8B80-0x00000001897A8BA0
	private void OnQueryPathRsp(QueryPathRsp queryPathRsp) {} // 0x00000001818E46B0-0x00000001818E4E60
	// [XID] // 0x00000001897B04A0-0x00000001897B04C0
	private void OnSyncTeamEntity(SyncTeamEntityNotify notify) {} // 0x00000001818E3A90-0x00000001818E3DB0
	// [XID] // 0x00000001897B82C0-0x00000001897B82E0
	private void OnDeleteTeamEntity(DelTeamEntityNotify notify) {} // 0x00000001818E1FA0-0x00000001818E22C0
	// [XID] // 0x00000001897C0300-0x00000001897C0320
	private void OnSyncScenePlayTeamEntity(SyncScenePlayTeamEntityNotify notify) {} // 0x00000001818E25F0-0x00000001818E28B0
	// [XID] // 0x00000001897C7B30-0x00000001897C7B50
	private void OnDeleteScenePlayTeamEntity(DelScenePlayTeamEntityNotify notify) {} // 0x00000001818EB530-0x00000001818EB890
	// [XID] // 0x00000001897CEDF0-0x00000001897CEE10
	private void OnWindSeedClientNotify(WindSeedClientNotify notify) {} // 0x00000001818E7FF0-0x00000001818E8190
	// [XID] // 0x00000001897D65C0-0x00000001897D65E0
	private void OnCanUseSkillNotify(CanUseSkillNotify notify) {} // 0x00000001818D62B0-0x00000001818D6380
	// [XID] // 0x00000001897DDDD0-0x00000001897DDDF0
	public void ResetDisableAvatarSkill() {} // 0x00000001818E7060-0x00000001818E7100
	// [XID] // 0x00000001897E5860-0x00000001897E5880
	public void OnLuaSetOptionNotify(LuaSetOptionNotify ntf) {} // 0x00000001818EEE20-0x00000001818EF110
	// [XID] // 0x00000001897ED350-0x00000001897ED370
	public void SendFightEvent(BaseEvent evt) {} // 0x00000001818E2A70-0x00000001818E2B90
	// [XID] // 0x00000001897F4AB0-0x00000001897F4AD0
	private void SendEvtDoSkillSucc(EvtDoSkillSucc evtDoSkill) {} // 0x00000001818EAA80-0x00000001818EABE0
	// [XID] // 0x00000001897FC5A0-0x00000001897FC5C0
	private void CreateFakeEvtDoSkillSucc(EvtDoSkillSucc evtDoSkill) {} // 0x00000001818EC820-0x00000001818EC9F0
	// [XID] // 0x0000000189803AB0-0x0000000189803AD0
	private void RequestEvtDoSkillSucc(EvtDoSkillSucc evtDoSkill) {} // 0x00000001818E87E0-0x00000001818E8A20
	// [XID] // 0x000000018980AF70-0x000000018980AF90
	private void SendEvtBeingHit(EvtBeingHit evtBeingHit) {} // 0x00000001818ECF30-0x00000001818ED100
	// [XID] // 0x0000000189812600-0x0000000189812620
	public void RequestEvtBeingHit(EvtBeingHit evtBeingHit) {} // 0x00000001818D60C0-0x00000001818D61A0
	// [XID] // 0x000000018981A240-0x000000018981A260
	private void CreateFakeEvtBeingHit(EvtBeingHit evtBeingHit) {} // 0x00000001818D5B40-0x00000001818D5C70
	// [XID] // 0x0000000189821990-0x00000001898219B0
	public void SendGadgetCreated(GadgetEntity gadget) {} // 0x00000001818EF110-0x00000001818EF820
	// [XID] // 0x0000000189828F20-0x0000000189828F40
	public void SendGadgetRemoved(GadgetEntity gadget) {} // 0x00000001818EC1E0-0x00000001818EC580
	// [XID] // 0x0000000189AF4F20-0x0000000189AF4F40
	public void SendServerGadgetRemoved(uint id) {} // 0x00000001818DBBB0-0x00000001818DBCF0
	// [XID] // 0x0000000189837B10-0x0000000189837B30
	public void SendMassiveEntityCreated(List<ClientMassiveEntity> entityCreatedList) {} // 0x00000001818D66D0-0x00000001818D6BD0
	// [XID] // 0x000000018983F270-0x000000018983F290
	public void SendMassiveEntityRemoved(List<ClientMassiveEntity> entityRemovedList) {} // 0x00000001818DFBF0-0x00000001818E00F0
	// [XID] // 0x0000000189846870-0x0000000189846890
	public void SendMassiveEntityStateChanged(List<MassiveEntityState> entityStateList) {} // 0x00000001818E41B0-0x00000001818E46B0
	// [XID] // 0x000000018984DE20-0x000000018984DE40
	public void SendFaceToDir(uint runtimeID, Vector3 forward) {} // 0x00000001818DD3E0-0x00000001818DD500
	// [XID] // 0x0000000189A7AEF0-0x0000000189A7AF10
	public void SendTransform(uint runtimeID, Vector3 pos, Vector3 eulerAngle) {} // 0x00000001818E3DB0-0x00000001818E3F10
	// [XID] // 0x000000018985C690-0x000000018985C6B0
	public void SendMotionInfoDuringSteerAttack(uint runtimeID, Vector3 velocity, Vector3 forward, Vector3 pos) {} // 0x00000001818D8AE0-0x00000001818D8C90
	// [XID] // 0x000000018989F580-0x000000018989F5A0
	public void SendCombatForceSetPos(uint runtimeID, Vector3 targetPos, uint colliderEntityId, uint iceID) {} // 0x00000001818E00F0-0x00000001818E0240
	// [XID] // 0x000000018986B400-0x000000018986B420
	public void SendSetAttackTarget(uint runtimeID, uint attackTargetRuntimeID) {} // 0x00000001818E6260-0x00000001818E6350
	// [XID] // 0x0000000189872730-0x0000000189872750
	public void SendEvtAnimatorStateChanged(BaseEntity entity, uint toStateHash, uint normalizedTimeCompact, int faceAngleCompact, float fadeDuration) {} // 0x00000001818E1E50-0x00000001818E1FA0
	// [XID] // 0x000000018987A350-0x000000018987A370
	public void SendEvtCompensatePosDiff(BaseEntity entity, uint curHash, Vector3 curPos, int faceAngleCompact, uint normalizedTimeCompact) {} // 0x00000001818E9610-0x00000001818E9780
	// [XID] // 0x00000001898814E0-0x0000000189881500
	public void SendEvtAnimatorParameterChanged(BaseEntity entity, AnimatorParameterEntry entry, bool reliable, bool isServerCache) {} // 0x00000001818E3F10-0x00000001818E4060
	// [XID] // 0x00000001896B4040-0x00000001896B4060
	public void SendEvtEntityRenderersChangedNotify(BaseEntity entity, uint allVisibilityStack, Dictionary<string, uint> changedRendererNames) {} // 0x00000001818DB4A0-0x00000001818DBBB0
	// [XID] // 0x000000018988FE20-0x000000018988FE40
	public void SendEvtRushMove(uint runtimeID, Vector3 velocity, float timeRange, int shortNameHash, Vector3 forward, Vector3 pos, Vector3 attackTargetPos, Vector3 rushToPos) {} // 0x00000001818E3320-0x00000001818E3560
	// [XID] // 0x000000018965BB10-0x000000018965BB30
	public void SendEvtBulletHit(BaseEntity bullet, LCBulletCombat bulletCombat) {} // 0x00000001818D9B60-0x00000001818DA270
	// [XID] // 0x000000018989E860-0x000000018989E880
	public void SendEvtBulletDeactive(BaseEntity bullet) {} // 0x00000001818E5AB0-0x00000001818E5F00
	// [XID] // 0x0000000189AC1550-0x0000000189AC1570
	public void SendEvtBulletMoveNotify(BaseEntity bullet) {} // 0x00000001818DCEB0-0x00000001818DD300
	// [XID] // 0x00000001898ADA10-0x00000001898ADA30
	public void SendEvtEntityStartDieEnd(BaseEntity entity, bool immediately, DieStateFlag dieStateFlag) {} // 0x00000001818E2B90-0x00000001818E2FB0
	// [XID] // 0x00000001898B4EA0-0x00000001898B4EC0
	public void SendPacketAbilityInvocationFixed(AbilityInvokeEntry invoke1st, AbilityInvokeEntry invoke2nd, AbilityInvokeEntry invoke3rd, AbilityInvokeEntry invoke4th, AbilityInvokeEntry invoke5th, AbilityInvokeEntry invoke6th) {} // 0x00000001818E6350-0x00000001818E6CB0
	// [XID] // 0x0000000189ACEF10-0x0000000189ACEF30
	public void FlushDelayAbilitySendList() {} // 0x00000001818EF820-0x00000001818EF9D0
	// [XID] // 0x0000000189B55AE0-0x0000000189B55B00
	public void SendPacketAbilityInvocations(List<AbilityEntryProxy> entryProxys) {} // 0x00000001818E16F0-0x00000001818E1E50
	// [XID] // 0x0000000189B379E0-0x0000000189B37A00
	public void SendAbilityInitBeginNotify(BaseEntity entity) {} // 0x00000001818ED100-0x00000001818ED290
	// [XID] // 0x00000001898D2F10-0x00000001898D2F30
	public void SendAbilityInitFinishNotify(BaseEntity entity) {} // 0x00000001818EBA20-0x00000001818EC1E0
	// [XID] // 0x00000001898DA860-0x00000001898DA880
	public void SendEvtAvatarEnterFocusNotify(BaseEntity entity, bool useFocusSticky, bool useAutoFocus, bool useGyro, Vector3 focusForwardNorm, bool normalFocusShoot, bool holdingFocusShoot, bool disableAnim) {} // 0x00000001818EE420-0x00000001818EE9C0
	// [XID] // 0x00000001898E2660-0x00000001898E2680
	public void SendEvtAvatarExitFocusNotify(BaseEntity entity, Vector3 finishforward) {} // 0x00000001818D93A0-0x00000001818D9870
	// [XID] // 0x00000001898EA170-0x00000001898EA190
	public void SendEvtAvatarUpdateFocusNotify(BaseEntity entity, Vector3 focusForward) {} // 0x00000001818ED330-0x00000001818ED800
	// [XID] // 0x00000001898F19B0-0x00000001898F19D0
	public void SendEvtAvatarSitDownNotify(BaseEntity entity, Vector3 position, long chairID) {} // 0x00000001818D7B50-0x00000001818D7F80
	// [XID] // 0x00000001897CB5E0-0x00000001897CB600
	public void SendEvtAvatarStandUpNotify(BaseEntity entity, SceneChairConfig.SitDirection direction, int performID) {} // 0x00000001818EB010-0x00000001818EB3E0
	// [XID] // 0x00000001899009F0-0x0000000189900A10
	public void SendClientAbilityChangeNotify(BaseEntity entity) {} // 0x00000001818E8A20-0x00000001818E8DE0
	// [XID] // 0x0000000189908230-0x0000000189908250
	private void OnServerUpdateGlobalValueNotify(ServerUpdateGlobalValueNotify notify) {} // 0x00000001818E7160-0x00000001818E73F0
	// [XID] // 0x000000018990FA10-0x000000018990FA30
	private void OnServerGlobalValueChangeNotify(ServerGlobalValueChangeNotify notify) {} // 0x00000001818E50D0-0x00000001818E5320
	// [IDTag] // 0x0000000189917460-0x00000001899174A0
	// [XID] // 0x0000000189917460-0x00000001899174A0
	private void SetEntityServerGlobalValueImpl(uint entityId, uint keyHash, float value) {} // 0x00000001818D8020-0x00000001818D8150
	// [IDTag] // 0x0000000189921C20-0x0000000189921C60
	// [XID] // 0x0000000189921C20-0x0000000189921C60
	private void SetEntityServerGlobalValueImpl(BaseEntity entity, uint keyHash, float value) {} // 0x00000001818D8150-0x00000001818D8300
	// [XID] // 0x000000018992C0C0-0x000000018992C0E0
	public void SendPacketCombatInvocations(List<CombatEntryProxy> entryProxys) {} // 0x00000001818D6BD0-0x00000001818D6E60
	// [XID] // 0x0000000189933560-0x0000000189933580
	private void FilterForwardList(RepeatedField<uint> forwardPeerList, bool includeCurPeer = false /* Metadata: 0x00AFF887 */) {} // 0x00000001818EADA0-0x00000001818EB010
	// [XID] // 0x000000018993B210-0x000000018993B230
	private void OnMonsterPointArrayRouteUpdateNotify(MonsterPointArrayRouteUpdateNotify pkt) {} // 0x00000001818E3960-0x00000001818E3A90
	// [XID] // 0x0000000189942320-0x0000000189942340
	private void DoOnMonsterPointArrayRouteUpdateNotify(MessageBase imessage) {} // 0x00000001818EB3E0-0x00000001818EB530
	// [XID] // 0x0000000189949C40-0x0000000189949C60
	private void clearMembers() {} // 0x00000001818EABE0-0x00000001818EAC80
	// [XID] // 0x0000000189951800-0x0000000189951820
	public override void ClearOnLevelDestroy() {} // 0x00000001818D7F80-0x00000001818D8020
	// [XID] // 0x0000000189958D90-0x0000000189958DB0
	public override void ClearOnDisconnect() {} // 0x00000001818EC9F0-0x00000001818ECA90
	// [XID] // 0x0000000189960440-0x0000000189960460
	public override void ClearOnBackHome() {} // 0x00000001818E0390-0x00000001818E0430
	// [XID] // 0x0000000189967E40-0x0000000189967E60
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001818D8300-0x00000001818D8750
}

