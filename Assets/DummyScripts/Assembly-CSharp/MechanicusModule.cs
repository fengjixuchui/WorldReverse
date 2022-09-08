/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusModule : BaseModule // TypeDefIndex: 21564
{
	// Fields
	private MechanicusInfo _mechanicusInfo; // 0x10
	public uint mechanicusOpenQuestID; // 0x18
	private uint _curSequenceID; // 0x1C
	private uint _curMechanicueCoin; // 0x20
	private uint _finishMaxDifficultLevel; // 0x24
	private uint _punishOverTime; // 0x28
	private InBattleMechanicusInfo _inBattleMechanicusInfo; // 0x30
	private InBattleMechanicusSettleNotify _inBattleMechanicusSettleNtf; // 0x38
	private ActivityCountdownWidgetContext _countDownWidgetContext; // 0x40
	private TheatreMechanicusBuildingPageContext _buildingPage; // 0x48
	private TheatreMechanicusCardSelectionPageContext _cardSelectionPage; // 0x50
	public uint currBuildingsNum; // 0x58
	public uint maxBuildingsNum; // 0x5C
	private int _currRound; // 0x60
	private bool _hasCurrRoundNotifiedStageKill; // 0x64
	private GeneralDialogContext _finishBuildingStageDialog; // 0x68

	// Properties
	public MechanicusInfo mechanicusInfo { /* [XID] */ /* 0x00000001898FBF50-0x00000001898FBF70 */ get => default; } // 0x0000000181B92D00-0x0000000181B92DA0 
	public uint curSequenceID { /* [XID] */ /* 0x00000001899309E0-0x0000000189930A00 */ get => default; } // 0x0000000181B918B0-0x0000000181B91950 
	public uint curMechanicueCoin { /* [XID] */ /* 0x0000000189937DF0-0x0000000189937E10 */ get => default; } // 0x0000000181B8F610-0x0000000181B8F6B0 
	public uint finishMaxDifficultLevel { /* [XID] */ /* 0x000000018993F880-0x000000018993F8A0 */ get => default; } // 0x0000000181B90E00-0x0000000181B90EA0 
	public uint punishOverTime { /* [XID] */ /* 0x0000000189946F60-0x0000000189946F80 */ get => default; } // 0x0000000181B8FFD0-0x0000000181B90070 
	public InBattleMechanicusInfo inBattleMechanicusInfo { /* [XID] */ /* 0x00000001899E4B80-0x00000001899E4BA0 */ get => default; } // 0x0000000181B91750-0x0000000181B917F0 
	public InBattleMechanicusSettleNotify inBattleMechanicusSettleNtf { /* [XID] */ /* 0x00000001899EC0B0-0x00000001899EC0D0 */ get => default; } // 0x0000000181B91BB0-0x0000000181B91C50 

	// Nested types
	public enum MechanicusRefreshType // TypeDefIndex: 21565
	{
		All = 0,
		LeftMonsterNum = 1,
		ExcapedMonsterNum = 2,
		BuildingNum = 3,
		BuildingPoints = 4
	}

	// Constructors
	public MechanicusModule() {} // 0x0000000181B94BE0-0x0000000181B94CA0

	// Methods
	// [XID] // 0x0000000189903A50-0x0000000189903A70
	public uint GetMechanicusID() => default; // 0x0000000181B92AE0-0x0000000181B92B90
	// [XID] // 0x000000018990AEB0-0x000000018990AED0
	public MechanicusExcelConfig GetMechanicusConfig() => default; // 0x0000000181B936C0-0x0000000181B93780
	// [XID] // 0x0000000189912B60-0x0000000189912B80
	public uint GetNextSequenceID() => default; // 0x0000000181B92050-0x0000000181B92270
	// [XID] // 0x000000018991A430-0x000000018991A450
	public uint GetFirstUnLockSequenceIDByLevel(uint level) => default; // 0x0000000181B901F0-0x0000000181B90400
	// [XID] // 0x0000000189921C00-0x0000000189921C20
	public uint GetMechanicusTecchDifficultLevel() => default; // 0x0000000181B8E500-0x0000000181B8E5C0
	// [XID] // 0x0000000189929360-0x0000000189929380
	public uint GetGearUnlockSequenceID(uint gearID) => default; // 0x0000000181B942C0-0x0000000181B944C0
	// [XID] // 0x000000018994E580-0x000000018994E5A0
	public override bool OnPacket(Packet packet) => default; // 0x0000000181B8F000-0x0000000181B8F470
	// [XID] // 0x0000000189955C00-0x0000000189955C20
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181B93EF0-0x0000000181B942C0
	// [XID] // 0x000000018995D6E0-0x000000018995D700
	public void GetMechanicusInfoReq() {} // 0x0000000181B94630-0x0000000181B94710
	// [XID] // 0x0000000189964D50-0x0000000189964D70
	public void MechanicusUnlockGearReq(uint gearID) {} // 0x0000000181B93410-0x0000000181B93550
	// [XID] // 0x000000018996C2F0-0x000000018996C310
	public void MechanicusLevelupGearReq(uint gearID) {} // 0x0000000181B8FBA0-0x0000000181B8FCE0
	// [XID] // 0x0000000189973DF0-0x0000000189973E10
	public void EnterMechanicusDungeonReq(uint difficultLevel) {} // 0x0000000181B91AB0-0x0000000181B91BB0
	// [XID] // 0x000000018997B5B0-0x000000018997B5D0
	public void MechanicusCandidateTeamCreateReq(uint difficultLevel) {} // 0x0000000181B94AE0-0x0000000181B94BE0
	// [XID] // 0x0000000189982FD0-0x0000000189982FF0
	private void OnGetMechanicusInfoRsp(GetMechanicusInfoRsp rsp) {} // 0x0000000181B94710-0x0000000181B94AE0
	// [XID] // 0x000000018998A780-0x000000018998A7A0
	private void OnMechanicusUnlockGearRsp(MechanicusUnlockGearRsp rsp) {} // 0x0000000181B8E5C0-0x0000000181B8E960
	// [XID] // 0x0000000189992020-0x0000000189992040
	private void OnMechanicusLevelupGearRsp(MechanicusLevelupGearRsp rsp) {} // 0x0000000181B925A0-0x0000000181B92990
	// [XID] // 0x0000000189999DB0-0x0000000189999DD0
	private void OnEnterMechanicusDungeonRsp(EnterMechanicusDungeonRsp rsp) {} // 0x0000000181B93D90-0x0000000181B93EF0
	// [XID] // 0x00000001899A1490-0x00000001899A14B0
	private void OnMechanicusCandidateTeamCreateRsp(MechanicusCandidateTeamCreateRsp rsp) {} // 0x0000000181B90400-0x0000000181B90560
	// [XID] // 0x00000001899A8EC0-0x00000001899A8EE0
	private void OnMechanicusSequenceOpenNotify(MechanicusSequenceOpenNotify ntf) {} // 0x0000000181B90070-0x0000000181B90120
	// [XID] // 0x00000001899B0850-0x00000001899B0870
	private void OnMechanicusCoinNotify(MechanicusCoinNotify ntf) {} // 0x0000000181B91950-0x0000000181B91AB0
	// [XID] // 0x00000001899B7BF0-0x00000001899B7C10
	private void OnMechanicusCloseNotify(MechanicusCloseNotify ntf) {} // 0x0000000181B93C50-0x0000000181B93D00
	// [XID] // 0x00000001899BF610-0x00000001899BF630
	public uint GetGearLevel(uint gearID) => default; // 0x0000000181B8F850-0x0000000181B8F9C0
	// [XID] // 0x00000001899C6FB0-0x00000001899C6FD0
	public uint GetCoinCount() => default; // 0x0000000181B90560-0x0000000181B90600
	// [XID] // 0x00000001899CE450-0x00000001899CE470
	public override void ClearOnBackHome() {} // 0x0000000181B910B0-0x0000000181B91150
	// [XID] // 0x00000001899D5C10-0x00000001899D5C30
	public override void ClearOnDisconnect() {} // 0x0000000181B93BB0-0x0000000181B93C50
	// [XID] // 0x00000001899DCFC0-0x00000001899DCFE0
	public override void ClearOnLevelDestroy() {} // 0x0000000181B8FCE0-0x0000000181B8FDA0
	// [XID] // 0x00000001899F3A90-0x00000001899F3AB0
	public bool IsInTheatreMechanicusDungeon() => default; // 0x0000000181B93290-0x0000000181B93410
	// [XID] // 0x00000001899FB370-0x00000001899FB390
	public bool IsTheatreMechanicusInBattle() => default; // 0x0000000181B917F0-0x0000000181B918B0
	// [XID] // 0x0000000189A02590-0x0000000189A025B0
	public bool IsTheatreMechanicusSettled() => default; // 0x0000000181B931D0-0x0000000181B93290
	// [XID] // 0x0000000189A09D20-0x0000000189A09D40
	public void ClearTheatreMechanicusSettleInfo() {} // 0x0000000181B8E460-0x0000000181B8E500
	// [XID] // 0x0000000189A11560-0x0000000189A11580
	public uint GetSelfBuildingPoints() => default; // 0x0000000181B938C0-0x0000000181B93AD0
	// [XID] // 0x0000000189A18970-0x0000000189A18990
	public void SendFoundationReq(uint entityId, FoundationOpType opType, uint buildingId = 0 /* Metadata: 0x00AFF940 */) {} // 0x0000000181B93780-0x0000000181B938C0
	// [XID] // 0x0000000189A1FFF0-0x0000000189A20010
	private void OnFoundationRsp(FoundationRsp rsp) {} // 0x0000000181B92F10-0x0000000181B93110
	// [XID] // 0x0000000189A27380-0x0000000189A273A0
	private void OnFoundationNotify(FoundationNotify ntf) {} // 0x0000000181B90810-0x0000000181B90CE0
	// [XID] // 0x0000000189A2EBC0-0x0000000189A2EBE0
	public void ShowTheatreMechanicusBuildingPage(BaseEntity entity) {} // 0x0000000181B911D0-0x0000000181B91570
	// [XID] // 0x0000000189A364D0-0x0000000189A364F0
	public void OnMechanicusInfo(MultistagePlayInfoNotify ntf) {} // 0x0000000181B8E960-0x0000000181B8EF80
	// [XID] // 0x0000000189A3DAB0-0x0000000189A3DAD0
	public void OnMultistagePlayStageEndNotify(MultistagePlayStageEndNotify ntf) {} // 0x0000000181B91CD0-0x0000000181B92050
	// [XID] // 0x0000000189A45230-0x0000000189A45250
	public void OnMultistagePlayEndNotify(MultistagePlayEndNotify ntf) {} // 0x0000000181B93110-0x0000000181B931D0
	// [XID] // 0x0000000189A4C940-0x0000000189A4C960
	public void ShowMultistagePlayFinishStageDialog() {} // 0x0000000181B92B90-0x0000000181B92D00
	// [XID] // 0x0000000189A54170-0x0000000189A54190
	private void OnInBattleMechanicusExcapeMonsterNotify(InBattleMechanicusExcapeMonsterNotify ntf) {} // 0x0000000181B8F6B0-0x0000000181B8F850
	// [XID] // 0x0000000189A5BB80-0x0000000189A5BBA0
	private void OnInBattleMechanicusLeftMonsterNotify(InBattleMechanicusLeftMonsterNotify ntf) {} // 0x0000000181B8F470-0x0000000181B8F610
	// [XID] // 0x0000000189A63310-0x0000000189A63330
	private void OnInBattleMechanicusBuildingPointsNotify(InBattleMechanicusBuildingPointsNotify ntf) {} // 0x0000000181B92270-0x0000000181B92540
	// [XID] // 0x0000000189A6AE30-0x0000000189A6AE50
	private void OnInBattleMechanicusSettleNotify(InBattleMechanicusSettleNotify ntf) {} // 0x0000000181B92DA0-0x0000000181B92F10
	// [XID] // 0x0000000189A724E0-0x0000000189A72500
	public void ShowTheatreMechanicusEndPage(InBattleMechanicusSettleNotify ntf) {} // 0x0000000181B90CE0-0x0000000181B90E00
	// [XID] // 0x0000000189A7A0F0-0x0000000189A7A110
	public void SendInBattleMechanicusPickCardReq(uint cardId) {} // 0x0000000181B93550-0x0000000181B936C0
	// [XID] // 0x0000000189A81590-0x0000000189A815B0
	private void OnInBattleMechanicusPickCardRsp(InBattleMechanicusPickCardRsp rsp) {} // 0x0000000181B90600-0x0000000181B90810
	// [XID] // 0x0000000189A88FF0-0x0000000189A89010
	private void OnInBattleMechanicusPickCardNotify(InBattleMechanicusPickCardNotify ntf) {} // 0x0000000181B91570-0x0000000181B91750
	// [XID] // 0x0000000189A907F0-0x0000000189A90810
	public void SendInBattleMechanicusConfirmCardReq(uint cardId) {} // 0x0000000181B944C0-0x0000000181B94630
	// [XID] // 0x0000000189A98010-0x0000000189A98030
	private void OnInBattleMechanicusConfirmCardRsp(InBattleMechanicusConfirmCardRsp rsp) {} // 0x0000000181B90EA0-0x0000000181B910B0
	// [XID] // 0x0000000189A9F3F0-0x0000000189A9F410
	private void OnInBattleMechanicusConfirmCardNotify(InBattleMechanicusConfirmCardNotify ntf) {} // 0x0000000181B8F9C0-0x0000000181B8FBA0
	// [XID] // 0x0000000189AA6C00-0x0000000189AA6C20
	private void OnInBattleMechanicusCardResultNotify(InBattleMechanicusCardResultNotify ntf) {} // 0x0000000181B92990-0x0000000181B92AE0
	// [XID] // 0x0000000189AAE350-0x0000000189AAE370
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000181B8FDA0-0x0000000181B8FFD0
	// [XID] // 0x0000000189AB5BA0-0x0000000189AB5BC0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000181B93AD0-0x0000000181B93BB0
}

