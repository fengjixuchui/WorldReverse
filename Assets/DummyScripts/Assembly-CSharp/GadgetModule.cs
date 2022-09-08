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
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetModule : CharacterModule // TypeDefIndex: 21486
{
	// Fields
	private Action<MessageBase> gadgetStateNotifyHandler; // 0x18
	private static Action<EvtEntityReadyPost> _onEntityReadyPostCallback; // 0x00
	private List<IdCountConfig> _costItemsTemp; // 0x20
	private const uint InteractOpenStatueCutscenId = 13; // Metadata: 0x00AFF8B0
	public Dictionary<uint, InLevelGadgetIndicator.GadgetIndicatorInfo> gadgetIndicatorDic; // 0x28

	// Properties
	public uint gadgetPlayEntityId { /* [XID] */ /* 0x0000000189666870-0x00000001896668B0 */ get; /* [XID] */ /* 0x00000001896717A0-0x00000001896717E0 */ private set; } // 0x00000001828457B0-0x0000000182845810 0x000000018284A7B0-0x000000018284A810
	public uint mpPlayId { /* [XID] */ /* 0x000000018967BF40-0x000000018967BF80 */ get; /* [XID] */ /* 0x0000000189686470-0x00000001896864B0 */ private set; } // 0x000000018284C9E0-0x000000018284CA40 0x00000001828453D0-0x0000000182845430
	public uint gadgetPlayPrepareEndTime { /* [XID] */ /* 0x0000000189691580-0x00000001896915C0 */ get; /* [XID] */ /* 0x000000018969B8B0-0x000000018969B8F0 */ private set; } // 0x0000000182848CD0-0x0000000182848D30 0x0000000182852600-0x0000000182852660
	public GadgetPlayInfo gadgetPlayInfo { /* [XID] */ /* 0x00000001896A5B40-0x00000001896A5B80 */ get; /* [XID] */ /* 0x00000001896AFDD0-0x00000001896AFE10 */ private set; } // 0x000000018284DE80-0x000000018284DEE0 0x000000018284A470-0x000000018284A4D0
	public uint gadgetPlayStage { /* [XID] */ /* 0x00000001896BA3D0-0x00000001896BA410 */ get; /* [XID] */ /* 0x00000001896C4860-0x00000001896C48A0 */ private set; } // 0x000000018284A3B0-0x000000018284A410 0x0000000182849240-0x00000001828492A0
	public List<uint> gadgetPlayUidList { /* [XID] */ /* 0x00000001896CF140-0x00000001896CF180 */ get; /* [XID] */ /* 0x00000001896D94B0-0x00000001896D94F0 */ private set; } // 0x00000001828487E0-0x0000000182848840 0x000000018284B2F0-0x000000018284B350
	public ElementType gadgetPlayElem { /* [XID] */ /* 0x00000001896E3AD0-0x00000001896E3B10 */ get; /* [XID] */ /* 0x00000001896EDE30-0x00000001896EDE70 */ private set; } // 0x0000000182852290-0x00000001828522F0 0x00000001828548A0-0x0000000182854900
	public uint gadgetPlayElemStartTime { /* [XID] */ /* 0x00000001896F83E0-0x00000001896F8420 */ get; /* [XID] */ /* 0x0000000189702D50-0x0000000189702D90 */ private set; } // 0x0000000182848B80-0x0000000182848BE0 0x0000000182848120-0x0000000182848180
	public uint gadgetPlayElemDuration { /* [XID] */ /* 0x000000018970D530-0x000000018970D570 */ get; /* [XID] */ /* 0x0000000189717880-0x00000001897178C0 */ private set; } // 0x000000018284A5F0-0x000000018284A650 0x000000018284DE20-0x000000018284DE80
	public uint gadgetPlayCostTime { /* [XID] */ /* 0x0000000189721F80-0x0000000189721FC0 */ get; /* [XID] */ /* 0x000000018972C720-0x000000018972C760 */ private set; } // 0x0000000182848D30-0x0000000182848D90 0x0000000182848FD0-0x0000000182849030
	public uint gadgetPlayScore { /* [XID] */ /* 0x0000000189737180-0x00000001897371C0 */ get; /* [XID] */ /* 0x0000000189741940-0x0000000189741980 */ private set; } // 0x00000001828468D0-0x0000000182846930 0x000000018284A410-0x000000018284A470
	public RepeatedMessageField<GadgetPlayUidInfo> gadgetPlayUidInfoList { /* [XID] */ /* 0x000000018974C2D0-0x000000018974C310 */ get; /* [XID] */ /* 0x00000001897566E0-0x0000000189756720 */ private set; } // 0x0000000182853D40-0x0000000182853DA0 0x0000000182853CE0-0x0000000182853D40
	public uint gadgetPlayEndTime { /* [XID] */ /* 0x0000000189760F30-0x0000000189760F50 */ get => default; } // 0x000000018284C200-0x000000018284C3B0 

	// Constructors
	public GadgetModule() {} // 0x0000000182855E60-0x0000000182855F80
	static GadgetModule() {} // 0x0000000182855D90-0x0000000182855E60

	// Methods
	// [XID] // 0x0000000189AF4070-0x0000000189AF4090
	public override bool OnPacket(Packet pkt) => default; // 0x0000000182845A70-0x0000000182845E20
	// [XID] // 0x0000000189AFB7E0-0x0000000189AFB800
	private void DoOnGadgetStateNotify(uint gadgetEntityId, uint gadgetState, bool isEnableInteract) {} // 0x0000000182846340-0x00000001828466F0
	// [XID] // 0x0000000189B02EF0-0x0000000189B02F10
	private void OnGadgetStateNotifyProxy(GadgetStateNotify notify) {} // 0x000000018284A4D0-0x000000018284A5F0
	// [XID] // 0x0000000189B0A620-0x0000000189B0A640
	private void OnGadgetStateNotify(MessageBase imessage) {} // 0x0000000182846F70-0x00000001828471F0
	// [XID] // 0x0000000189B11D80-0x0000000189B11DA0
	public void UpdateGadgetPropsByID(uint entityId, MapField<uint, PropValue> propMap) {} // 0x000000018284BA80-0x000000018284BB70
	// [XID] // 0x0000000189B18FB0-0x0000000189B18FD0
	public void UpdateGadgetPropsListByID(uint entityId, RepeatedMessageField<PropPair> propList) {} // 0x000000018284B350-0x000000018284B440
	// [XID] // 0x0000000189B206B0-0x0000000189B206D0
	public void UpdateGadgetFightPropsByID(uint entityId, MapField<uint, float> propMap, bool doClear = false /* Metadata: 0x00AFF888 */) {} // 0x00000001828456A0-0x00000001828457B0
	// [XID] // 0x0000000189B27DB0-0x0000000189B27DD0
	public void UpdateGadgetFightPropsListByID(uint entityId, RepeatedMessageField<FightPropPair> propList, bool doClear = false /* Metadata: 0x00AFF889 */) {} // 0x000000018284A810-0x000000018284A920
	// [XID] // 0x0000000189B2F0D0-0x0000000189B2F0F0
	public GadgetDataItem GetGadgetDataById(uint entityId) => default; // 0x000000018284B970-0x000000018284BA80
	// [XID] // 0x0000000189B369F0-0x0000000189B36A10
	public override void EntityAppear(SceneEntityInfo entity, VisionType type, uint infoParam) {} // 0x00000001828558B0-0x0000000182855D90
	// [XID] // 0x0000000189B3E1F0-0x0000000189B3E210
	public static bool IsTrifleItem(SceneEntityInfo entityInfo) => default; // 0x0000000182848700-0x00000001828487E0
	// [XID] // 0x0000000189B45F00-0x0000000189B45F20
	private BaseEntity GadgetAppear(SceneEntityInfo entity, BaseEntity baseEntity = null) => default; // 0x000000018284E330-0x0000000182851FB0
	// [XID] // 0x0000000189B4D330-0x0000000189B4D350
	private static void OnEntityReadyPostCallback(EvtEntityReadyPost evt) {} // 0x0000000182848BE0-0x0000000182848CD0
	// [XID] // 0x0000000189B54BF0-0x0000000189B54C10
	private BaseEntity GadgetBorn(GadgetDataItem gadgetDataItem, SceneEntityInfo entity) => default; // 0x0000000182852660-0x00000001828530A0
	// [XID] // 0x00000001898CC4A0-0x00000001898CC4C0
	public BaseEntity CreateGadgetObject(GadgetDataItem gadgetDataItem, Vector3 pos, Vector3 eular, uint? campID, TargetType? campType, bool isItemGadget, uint ownerRuntimeID = 0 /* Metadata: 0x00AFF88A */, uint targetRuntimeID = 0 /* Metadata: 0x00AFF88E */, AbilitySyncStateInfo abilitySyncInfo = null) => default; // 0x0000000182845E20-0x0000000182846190
	// [XID] // 0x0000000189B63CD0-0x0000000189B63CF0
	public override void EntityDisappear(uint entityId, VisionType type) {} // 0x00000001828554C0-0x00000001828558B0
	// [XID] // 0x0000000189B6B460-0x0000000189B6B480
	private void HandleGadgetDie(uint entityId, VisionType type) {} // 0x0000000182848840-0x0000000182848940
	// [XID] // 0x0000000189B72A70-0x0000000189B72A90
	private void HandleGadgetPickUp(uint entityId, VisionType type) {} // 0x000000018284A1F0-0x000000018284A3B0
	// [XID] // 0x0000000189B79FF0-0x0000000189B7A010
	private void HandleGadgetMissing(uint entityId, VisionType type) {} // 0x0000000182847D70-0x0000000182848120
	// [XID] // 0x0000000189B81750-0x0000000189B81770
	private void HandleGadgetEscape(uint entityId, VisionType type) {} // 0x000000018284C6C0-0x000000018284C9E0
	// [XID] // 0x0000000189B88DF0-0x0000000189B88E10
	private void HandleGadgetRemove(uint entityId, VisionType type) {} // 0x0000000182845260-0x00000001828453D0
	// [XID] // 0x00000001896D2A30-0x00000001896D2A50
	public void RequestGadgetInteract(uint entityID, uint configID, InterOpType opType = InterOpType.InterOpFinish /* Metadata: 0x00AFF892 */, ResinCostType resinCostType = ResinCostType.None /* Metadata: 0x00AFF896 */) {} // 0x000000018284A920-0x000000018284B1C0
	// [XID] // 0x0000000189B977B0-0x0000000189B977D0
	private void OnGadgetInteractRsp(GadgetInteractRsp notify) {} // 0x000000018284B440-0x000000018284B850
	// [XID] // 0x0000000189B9EC30-0x0000000189B9EC50
	private void HandleChestInteractRsp(GadgetInteractRsp notify) {} // 0x0000000182851FB0-0x0000000182852290
	// [XID] // 0x0000000189BA6520-0x0000000189BA6540
	private void HandleOpenStatueRsp(GadgetInteractRsp notify) {} // 0x000000018284C3B0-0x000000018284C6C0
	// [XID] // 0x0000000189BAD860-0x0000000189BAD880
	private void HandleMpPlayRewardInteractRsp(GadgetInteractRsp notify) {} // 0x0000000182853DA0-0x00000001828543C0
	// [XID] // 0x0000000189BB4FC0-0x0000000189BB4FE0
	private void GadgetInteractRspErrorHandle(GadgetInteractRsp notify) {} // 0x0000000182849540-0x0000000182849930
	// [XID] // 0x0000000189BBC600-0x0000000189BBC620
	private void DoOnWorktopOptionNotify(WorktopOptionNotify notify) {} // 0x000000018284D4A0-0x000000018284D680
	// [XID] // 0x0000000189BC4260-0x0000000189BC4280
	private void OnWorktopOptionNotify(WorktopOptionNotify notify) {} // 0x0000000182848940-0x0000000182848B80
	// [XID] // 0x0000000189BCBC00-0x0000000189BCBC20
	private void OnSelectWorktopOptionRsp(SelectWorktopOptionRsp rsp) {} // 0x0000000182845890-0x0000000182845A70
	// [XID] // 0x0000000189BD3150-0x0000000189BD3170
	public override void ClearOnLevelDestroy() {} // 0x0000000182846190-0x0000000182846340
	// [XID] // 0x0000000189BDA9B0-0x0000000189BDA9D0
	public override void ClearOnDisconnect() {} // 0x00000001828543C0-0x0000000182854460
	// [XID] // 0x00000001895E73B0-0x00000001895E73D0
	public void CreateEnergy(uint configID, Vector3 pos, Vector3 rot) {} // 0x0000000182849340-0x0000000182849540
	// [XID] // 0x00000001895EECC0-0x00000001895EECE0
	public void RequestSelectWorktopOption(uint optionId, uint gadgetEntityId) {} // 0x000000018284B850-0x000000018284B970
	// [XID] // 0x00000001895F6680-0x00000001895F66A0
	private void DoOnSealBattleBeginNotify(uint SealEntityId, uint SealRadius, uint SealMaxProgress) {} // 0x000000018284E150-0x000000018284E330
	// [XID] // 0x00000001895FDA60-0x00000001895FDA80
	private void OnSealBattleBeginNotify(SealBattleBeginNotify notify) {} // 0x000000018284DEE0-0x000000018284E150
	// [XID] // 0x0000000189605290-0x00000001896052B0
	private void DoOnSealBattleProgressNotify(SealBattleProgressNotify ntf) {} // 0x000000018284CA40-0x000000018284CC10
	// [XID] // 0x000000018960CCC0-0x000000018960CCE0
	private void OnSealBattleProgressNotify(SealBattleProgressNotify notify) {} // 0x0000000182845430-0x00000001828456A0
	// [XID] // 0x0000000189614210-0x0000000189614230
	private void DoOnSealBattleEndNotify(uint SealEntityId, bool IsWin) {} // 0x00000001828546D0-0x00000001828548A0
	// [XID] // 0x000000018961BC30-0x000000018961BC50
	private void OnSealBattleEndNotify(SealBattleEndNotify notify) {} // 0x0000000182848D90-0x0000000182848FD0
	// [XID] // 0x00000001896231A0-0x00000001896231C0
	public void SceneCreateEntityReq(CreateReason reason, CreateEntityInfo.EntityOneofCase entityCase, uint configID, uint level, Vector3 initPos, Vector3 initRot, uint dropID = 0 /* Metadata: 0x00AFF89A */, float scale = 1f /* Metadata: 0x00AFF89E */, uint sceneID = 3 /* Metadata: 0x00AFF8A2 */, string alias = "" /* Metadata: 0x00AFF8A6 */, uint roomID = 0 /* Metadata: 0x00AFF8AA */, bool destroyWhenDisconnect = false /* Metadata: 0x00AFF8AE */, bool canCreateInOtherPlayerWorld = false /* Metadata: 0x00AFF8AF */) {} // 0x000000018284CC10-0x000000018284D4A0
	// [XID] // 0x000000018962A9A0-0x000000018962A9C0
	public void ExecuteGadgetLuaReq(uint entityID, int param1, int param2, int param3) {} // 0x000000018284A650-0x000000018284A7B0
	// [XID] // 0x0000000189632120-0x0000000189632140
	private void OnExecuteGadgetLuaRsp(ExecuteGadgetLuaRsp rsp) {} // 0x000000018284B1C0-0x000000018284B270
	// [XID] // 0x0000000189639BD0-0x0000000189639BF0
	private void OnGadgetGeneralRewardInfoNotify(GadgetGeneralRewardInfoNotify notify) {} // 0x0000000182847590-0x00000001828478A0
	// [XID] // 0x0000000189641080-0x00000001896410A0
	private void OnGadgetTalkChangeNotify(GadgetTalkChangeNotify ntf) {} // 0x0000000182848180-0x0000000182848360
	// [XID] // 0x0000000189648A00-0x0000000189648A20
	public void OnGadgetTouch(LCBaseIntee intee) {} // 0x0000000182849D70-0x000000018284A1F0
	// [XID] // 0x00000001896500E0-0x0000000189650100
	private void OnGadgetTouchCheckSuccessOpenChest(uint entityRuntimeID) {} // 0x00000001828530A0-0x0000000182853CE0
	// [XID] // 0x00000001896579D0-0x00000001896579F0
	private void OnGadgetTouchCheckSuccessOpenStatue(GadgetInteractRsp notify) {} // 0x000000018284BB70-0x000000018284C200
	// [XID] // 0x000000018965F0A0-0x000000018965F0C0
	private void OnBossChestActivateNotify(BossChestActivateNotify ntf) {} // 0x000000018284D680-0x000000018284D9C0
	// [XID] // 0x00000001897682C0-0x00000001897682E0
	public bool IsGadgetPlaying() => default; // 0x00000001828478A0-0x0000000182847A30
	// [XID] // 0x000000018976F890-0x000000018976F8B0
	public void SetGadgetPlayPrepareTime(uint endTime) {} // 0x0000000182846930-0x0000000182846F70
	// [XID] // 0x00000001897771F0-0x0000000189777210
	private void CheckGadgetPlayDisappear(uint entityId) {} // 0x0000000182849030-0x0000000182849240
	// [IDTag] // 0x000000018977E920-0x000000018977E960
	// [XID] // 0x000000018977E920-0x000000018977E960
	public void CheckGadgetPlayInfo() {} // 0x000000018284D9C0-0x000000018284DB80
	// [IDTag] // 0x0000000189789100-0x0000000189789140
	// [XID] // 0x0000000189789100-0x0000000189789140
	public void CheckGadgetPlayInfo(SceneEntityInfo entityInfo) {} // 0x000000018284DB80-0x000000018284DE20
	// [XID] // 0x00000001897935C0-0x00000001897935E0
	public uint GetGadgetPlayStage(IList<uint> progressStageList, uint progress) => default; // 0x0000000182854460-0x0000000182854580
	// [XID] // 0x000000018979B7D0-0x000000018979B7F0
	private void CheckGadgetPlayStage(uint entityId, IList<uint> progressStageList, uint newProgress, uint? oldProgress) {} // 0x00000001828471F0-0x0000000182847590
	// [XID] // 0x00000001897A2C00-0x00000001897A2C20
	private void OnGadgetPlayStartNotify(GadgetPlayStartNotify notify) {} // 0x0000000182854580-0x00000001828546D0
	// [XID] // 0x00000001897AA280-0x00000001897AA2A0
	private void CheckGadgetPlayStart(uint startTime) {} // 0x0000000182849930-0x0000000182849D70
	// [XID] // 0x00000001897B1C70-0x00000001897B1C90
	private void ClearGadgetPlayInfo() {} // 0x00000001828522F0-0x0000000182852600
	// [XID] // 0x00000001897B96F0-0x00000001897B9710
	public void OnGadgetPlayStopNotify(GadgetPlayStopNotify notify) {} // 0x0000000182848360-0x0000000182848700
	// [XID] // 0x00000001897C1720-0x00000001897C1740
	public void OnGadgetPlayDataNotify(GadgetPlayDataNotify notify) {} // 0x0000000182847A30-0x0000000182847D70
	// [XID] // 0x00000001897C91A0-0x00000001897C91C0
	public void OnGadgetPlayUidOpNotify(GadgetPlayUidOpNotify notify) {} // 0x0000000182854900-0x00000001828554C0
	// [XID] // 0x00000001897D0790-0x00000001897D07B0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001828466F0-0x00000001828468D0
}

