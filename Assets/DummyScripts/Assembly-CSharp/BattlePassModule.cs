/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassModule : BaseModule // TypeDefIndex: 21408
{
	// Fields
	private bool _haveSchedule; // 0x10
	private BPSchedule _currSchedule; // 0x18
	private Dictionary<uint, HashSet<uint>> _freeRewardTakenDic; // 0x20
	private Dictionary<uint, HashSet<uint>> _paidRewardTakenDic; // 0x28
	private Dictionary<uint, Dictionary<uint, BPMissionStruct>> _missionDic; // 0x30

	// Properties
	public bool haveSchedule { /* [XID] */ /* 0x0000000189B9A6A0-0x0000000189B9A6C0 */ get => default; } // 0x000000018377A8B0-0x000000018377A950 
	public BPSchedule currSchedule { /* [XID] */ /* 0x0000000189BA1E90-0x0000000189BA1EB0 */ get => default; } // 0x000000018377A0D0-0x000000018377A170 

	// Constructors
	public BattlePassModule() {} // 0x000000018377D230-0x000000018377D330

	// Methods
	// [XID] // 0x0000000189BA9280-0x0000000189BA92A0
	public override void ClearOnLevelDestroy() {} // 0x0000000183779930-0x00000001837799D0
	// [XID] // 0x0000000189BB0A10-0x0000000189BB0A30
	public override void ClearOnDisconnect() {} // 0x000000018377C030-0x000000018377C0D0
	// [XID] // 0x0000000189BB7D00-0x0000000189BB7D20
	public override void ClearOnBackHome() {} // 0x000000018377A170-0x000000018377A210
	// [XID] // 0x0000000189BBF410-0x0000000189BBF430
	public override bool OnPacket(Packet packet) => default; // 0x0000000183779590-0x0000000183779840
	// [XID] // 0x0000000189BC6FD0-0x0000000189BC6FF0
	private void ClearBattlePassData(bool clearSchedule = true /* Metadata: 0x00AFF7B4 */) {} // 0x0000000183779FC0-0x000000018377A0D0
	// [XID] // 0x0000000189BCED00-0x0000000189BCED20
	private void OnBattlePassAllDataNotify(BattlePassAllDataNotify ntf) {} // 0x000000018377A5F0-0x000000018377A720
	// [XID] // 0x0000000189BD6060-0x0000000189BD6080
	private void OnBattlePassMissionUpdateNotify(BattlePassMissionUpdateNotify ntf) {} // 0x000000018377C840-0x000000018377C9A0
	// [XID] // 0x0000000189BDDC20-0x0000000189BDDC40
	private void OnBattlePassCurScheduleUpdateNotify(BattlePassCurScheduleUpdateNotify ntf) {} // 0x000000018377B750-0x000000018377BAA0
	// [XID] // 0x00000001895EA7A0-0x00000001895EA7C0
	private void UpdateCurrentBPSchedule(BattlePassSchedule schedule) {} // 0x000000018377CED0-0x000000018377D230
	// [XID] // 0x00000001895F1D10-0x00000001895F1D30
	private void UpdateRewardTakenState(BattlePassSchedule schedule) {} // 0x000000018377C9A0-0x000000018377CD70
	// [XID] // 0x00000001895F9690-0x00000001895F96B0
	private void UpdateBPMission(RepeatedMessageField<BattlePassMission> missionList) {} // 0x000000018377BB80-0x000000018377BE80
	// [XID] // 0x0000000189600D80-0x0000000189600DA0
	private void OnBattlePassMissionDelNotify(BattlePassMissionDelNotify ntf) {} // 0x0000000183779D70-0x0000000183779ED0
	// [XID] // 0x00000001896086F0-0x0000000189608710
	private void DeleteBPMission(RepeatedField<uint> missionList) {} // 0x000000018377B530-0x000000018377B750
	// [XID] // 0x000000018960FF10-0x000000018960FF30
	public BattlePassRewardTakeOption CreateBPRewardOption(BattlePassUnlockStatus unlockStatus, uint level, uint rewardId, uint optionIndex) => default; // 0x000000018377AC40-0x000000018377AE00
	// [XID] // 0x0000000189617270-0x0000000189617290
	public void RequestTakeBattlePassReward(List<BattlePassRewardTakeOption> rewardOptionList) {} // 0x000000018377A350-0x000000018377A4A0
	// [XID] // 0x000000018961EE60-0x000000018961EE80
	private void OnTakeBattlePassRewardRsp(TakeBattlePassRewardRsp rsp) {} // 0x000000018377C230-0x000000018377C530
	// [XID] // 0x00000001896261E0-0x0000000189626200
	public void RequestTakeBattlePassMissionPoint(List<uint> missionIdList) {} // 0x000000018377A4A0-0x000000018377A5F0
	// [XID] // 0x000000018962DBF0-0x000000018962DC10
	private void OnTakeBattlePassMissionPointRsp(TakeBattlePassMissionPointRsp rsp) {} // 0x000000018377B3D0-0x000000018377B530
	// [XID] // 0x00000001896357B0-0x00000001896357D0
	public void RequestGetBattlePassProduct(ProductPlayType productType) {} // 0x000000018377B090-0x000000018377B190
	// [XID] // 0x000000018963CE90-0x000000018963CEB0
	private void OnGetBattlePassProductRsp(GetBattlePassProductRsp rsp) {} // 0x000000018377B190-0x000000018377B3D0
	// [XID] // 0x0000000189644450-0x0000000189644470
	private void OnBattlePassBuySuccNotify(BattlePassBuySuccNotify ntf) {} // 0x000000018377AA70-0x000000018377ABC0
	// [XID] // 0x000000018964BC90-0x000000018964BCB0
	public void RequestSetBattlePassViewed() {} // 0x000000018377A950-0x000000018377AA70
	// [XID] // 0x00000001896532C0-0x00000001896532E0
	private void OnSetBattlePassViewedRsp(SetBattlePassViewedRsp rsp) {} // 0x000000018377C0D0-0x000000018377C230
	// [XID] // 0x000000018965AB50-0x000000018965AB70
	public void RequestBuyBattlePassLevel(uint buyLevel) {} // 0x000000018377AF30-0x000000018377B030
	// [XID] // 0x0000000189661FE0-0x0000000189662000
	private void OnBuyBattlePassLevelRsp(BuyBattlePassLevelRsp rsp) {} // 0x000000018377CD70-0x000000018377CED0
	// [XID] // 0x0000000189669BC0-0x0000000189669BE0
	public bool CheckBPRewardTaken(bool isFree, uint level, uint rewardId) => default; // 0x000000018377A720-0x000000018377A8B0
	// [XID] // 0x0000000189671800-0x0000000189671820
	public Dictionary<uint, BPMissionStruct> GetBPMissionListByType(uint missionType) => default; // 0x0000000183779840-0x0000000183779930
	// [XID] // 0x0000000189678FF0-0x0000000189679010
	public bool HaveFinishedMission() => default; // 0x0000000183779ED0-0x0000000183779FC0
	// [XID] // 0x0000000189680750-0x0000000189680770
	public bool HaveFinishedMissionByIndex(uint index) => default; // 0x0000000183779B50-0x0000000183779D70
	// [XID] // 0x00000001896882A0-0x00000001896882C0
	public bool HaveFinishedReward() => default; // 0x000000018377C530-0x000000018377C840
	// [XID] // 0x000000018968FB80-0x000000018968FBA0
	public bool CheckRewardCanTake(bool isFree, uint level, uint rewardId) => default; // 0x000000018377A210-0x000000018377A350
	// [XID] // 0x0000000189697540-0x0000000189697560
	public bool CheckBPMaxLevel() => default; // 0x000000018377BAA0-0x000000018377BB80
	// [XID] // 0x000000018969EA70-0x000000018969EA90
	public static List<uint> GetBPRewardConfigList(SimpleSafeUInt32[] array) => default; // 0x000000018377BE80-0x000000018377C030
	// [XID] // 0x00000001896A5BC0-0x00000001896A5BE0
	public bool CheckBpMissionActive(uint missionId) => default; // 0x000000018377AE00-0x000000018377AF30
	// [XID] // 0x00000001896AD2F0-0x00000001896AD310
	public bool HaveUnfinishedActivityMissionByIndex(uint index) => default; // 0x0000000183779300-0x0000000183779590
	// [XID] // 0x00000001896B4A50-0x00000001896B4A70
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001837799D0-0x0000000183779B50
}

