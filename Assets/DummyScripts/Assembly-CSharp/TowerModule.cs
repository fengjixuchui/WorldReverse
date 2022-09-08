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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerModule : BaseModule // TypeDefIndex: 21625
{
	// Fields
	private uint _towerScheduleId; // 0x10
	private ulong _scheduleStartTime; // 0x18
	private ulong _nextOpenTime; // 0x20
	private uint _totalStarNum; // 0x28
	private bool _allDataGot; // 0x2C
	private bool _haveRecord; // 0x2D
	private uint _currFloorId; // 0x30
	private uint _currLevelIndex; // 0x34
	private uint _bestFloorIndex; // 0x38
	private uint _bestLevelIndex; // 0x3C
	private uint _playingFloorId; // 0x40
	private uint _playingLevelIndex; // 0x44
	private List<uint> _currFloorBuffList; // 0x48
	private bool _needSelectBuff; // 0x50
	private bool _teamChanged; // 0x51
	private List<uint> _buffToSelect; // 0x58
	private List<TowerTeamData> _towerTeamList; // 0x60
	private List<uint> _finishStarList; // 0x68
	private List<ItemParam> _rewardList; // 0x70
	public uint continueState; // 0x78
	public TowerStopReason towerStopReason; // 0x7C
	private Dictionary<uint, TowerFloorData> _towerFloorDic; // 0x80
	private Dictionary<uint, TowerLevelData> _towerLevelDic; // 0x88
	private Dictionary<uint, uint> _floorOpenTimeDic; // 0x90
	private InLevelTowerBeginPageContext _towerBeginPageContext; // 0x98
	private InLevelTowerEndExitContext _towerEnd; // 0xA0
	private InLevelTowerEndWinContext _towerWin; // 0xA8
	private uint _currPointID; // 0xB0
	private uint _nextFloorId; // 0xB4
	private uint _dungeonID; // 0xB8
	private DungeonExcelConfig _dungeonConfig; // 0xC0
	private Action onTowerMiddleLevelChange; // 0xC8
	private Dictionary<uint, uint> _skipFloorGrantedRewardItem; // 0xF8
	private List<TowerMonthlyDetail> _towerMonthlyDetailList; // 0x100
	private static readonly string author; // 0x00
	public List<TowerLevelStarCondData> levelStarCondList; // 0x108
	private GeneralDialogContext _generalDialog; // 0x110
	private uint _pointToTransport; // 0x118

	// Properties
	public List<uint> finishStarList { /* [XID] */ /* 0x0000000189751C10-0x0000000189751C30 */ get => default; } // 0x0000000181C35C70-0x0000000181C35D10 
	public List<ItemParam> rewardList { /* [XID] */ /* 0x0000000189759340-0x0000000189759360 */ get => default; } // 0x0000000181C325D0-0x0000000181C32670 
	public bool isFinishedEntranceFloor { /* [XID] */ /* 0x0000000189760E90-0x0000000189760ED0 */ get; /* [XID] */ /* 0x000000018976B380-0x000000018976B3C0 */ private set; } // 0x0000000181C31280-0x0000000181C312E0 0x0000000181C35D10-0x0000000181C35D80
	public bool isFirstInteract { /* [XID] */ /* 0x00000001897758C0-0x0000000189775900 */ get; /* [XID] */ /* 0x0000000189780060-0x00000001897800A0 */ private set; } // 0x0000000181C35A50-0x0000000181C35AB0 0x0000000181C32F10-0x0000000181C32F80
	public TowerMonthlyBrief monthlyBrief { /* [XID] */ /* 0x000000018978A7A0-0x000000018978A7E0 */ get; /* [XID] */ /* 0x0000000189794B80-0x0000000189794BC0 */ private set; } // 0x0000000181C349C0-0x0000000181C34A20 0x0000000181C32C60-0x0000000181C32CD0
	public TowerMonthlyBrief lastScheduleMonthlyBrief { /* [XID] */ /* 0x000000018979FEB0-0x000000018979FEF0 */ get; /* [XID] */ /* 0x00000001897AA240-0x00000001897AA280 */ private set; } // 0x0000000181C32290-0x0000000181C322F0 0x0000000181C367E0-0x0000000181C36850
	public uint skipToFloorIndex { /* [XID] */ /* 0x00000001897B5530-0x00000001897B5570 */ get; /* [XID] */ /* 0x00000001897C0280-0x00000001897C02C0 */ private set; } // 0x0000000181C30890-0x0000000181C308F0 0x0000000181C32BF0-0x0000000181C32C60
	public uint commemorativeRewardId { /* [XID] */ /* 0x00000001897CA790-0x00000001897CA7D0 */ get; /* [XID] */ /* 0x00000001897D4E70-0x00000001897D4EB0 */ private set; } // 0x0000000181C32D70-0x0000000181C32DD0 0x0000000181C361A0-0x0000000181C36210
	public uint validTowerRecordNum { /* [XID] */ /* 0x00000001897DF550-0x00000001897DF590 */ get; /* [XID] */ /* 0x00000001897E9F20-0x00000001897E9F60 */ private set; } // 0x0000000181C33950-0x0000000181C339B0 0x0000000181C335D0-0x0000000181C33640
	public Dictionary<uint, uint> skipFloorGrantedRewardItem { /* [XID] */ /* 0x00000001897F4A70-0x00000001897F4A90 */ get => default; } // 0x0000000181C35780-0x0000000181C35830 
	public List<TowerMonthlyDetail> towerMonthlyDetailList { /* [XID] */ /* 0x00000001897FC560-0x00000001897FC580 */ get => default; } // 0x0000000181C37A30-0x0000000181C37AE0 
	public uint currPointID { /* [XID] */ /* 0x000000018994B630-0x000000018994B650 */ get => default; } // 0x0000000181C36A50-0x0000000181C36AF0 
	public List<uint> currFloorBuffList { /* [XID] */ /* 0x0000000189952F10-0x0000000189952F30 */ get => default; } // 0x0000000181C36210-0x0000000181C362B0 
	public List<uint> buffToSelect { /* [XID] */ /* 0x000000018995A490-0x000000018995A4B0 */ get => default; } // 0x0000000181C37400-0x0000000181C374A0 
	public uint towerScheduleId { /* [XID] */ /* 0x0000000189961F50-0x0000000189961F70 */ get => default; } // 0x0000000181C35830-0x0000000181C358D0 
	public bool haveRecord { /* [XID] */ /* 0x0000000189969480-0x00000001899694A0 */ get => default; } // 0x0000000181C37AE0-0x0000000181C37B80 
	public uint currFloorId { /* [XID] */ /* 0x0000000189978A70-0x0000000189978A90 */ get => default; } // 0x0000000181C34C50-0x0000000181C34CF0 
	public uint currFloorIndex { /* [XID] */ /* 0x000000018997FAF0-0x000000018997FB10 */ get => default; } // 0x0000000181C33CE0-0x0000000181C33DC0 
	public uint currLevelIndex { /* [XID] */ /* 0x00000001899873F0-0x0000000189987410 */ get => default; } // 0x0000000181C36740-0x0000000181C367E0 
	public uint bestFloorIndex { /* [XID] */ /* 0x0000000189996A60-0x0000000189996A80 */ get => default; } // 0x0000000181C32CD0-0x0000000181C32D70 
	public uint bestLevelIndex { /* [XID] */ /* 0x000000018999E590-0x000000018999E5B0 */ get => default; } // 0x0000000181C35F60-0x0000000181C36000 
	public uint playingFloorId { /* [XID] */ /* 0x00000001899A5FB0-0x00000001899A5FD0 */ get => default; } // 0x0000000181C312E0-0x0000000181C31380 
	public uint playingFloorIndex { /* [XID] */ /* 0x00000001899AD5C0-0x00000001899AD5E0 */ get => default; } // 0x0000000181C36AF0-0x0000000181C36BD0 
	public uint playingLevelIndex { /* [XID] */ /* 0x00000001899B4E40-0x00000001899B4E60 */ get => default; } // 0x0000000181C34410-0x0000000181C344B0 
	public bool teamChanged { /* [XID] */ /* 0x0000000189A33070-0x0000000189A33090 */ get => default; } // 0x0000000181C359B0-0x0000000181C35A50 

	// Nested types
	public enum TowerStopReason // TypeDefIndex: 21626
	{
		No = 0,
		NoPass = 1,
		NoStar = 2,
		NotStarted = 3,
		TheEnd = 4
	}

	public enum TowerFloorType // TypeDefIndex: 21627
	{
		Default = 0,
		Entry = 1,
		Loop = 2,
		All = 3
	}

	// Constructors
	public TowerModule() {} // 0x0000000181C37BF0-0x0000000181C37E40
	static TowerModule() {} // 0x0000000181C37B80-0x0000000181C37BF0

	// Methods
	// [XID] // 0x0000000189742FE0-0x0000000189743000
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000181C310B0-0x0000000181C31280
	// [XID] // 0x000000018974ABA0-0x000000018974ABC0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000181C36F40-0x0000000181C37010
	// [XID] // 0x0000000189803A70-0x0000000189803A90
	public override void ClearOnLevelDestroy() {} // 0x0000000181C30DB0-0x0000000181C30E50
	// [XID] // 0x000000018980AF10-0x000000018980AF30
	public override void ClearOnDisconnect() {} // 0x0000000181C37010-0x0000000181C370B0
	// [XID] // 0x00000001898125A0-0x00000001898125C0
	public override void ClearOnBackHome() {} // 0x0000000181C33640-0x0000000181C337E0
	// [XID] // 0x000000018981A1E0-0x000000018981A200
	public override bool OnPacket(Packet packet) => default; // 0x0000000181C308F0-0x0000000181C30C20
	// [XID] // 0x0000000189821930-0x0000000189821950
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181C37320-0x0000000181C37400
	// [XID] // 0x0000000189828EC0-0x0000000189828EE0
	public void AddMiddleLevelChangeAction(Action action) {} // 0x0000000181C371F0-0x0000000181C37320
	// [XID] // 0x00000001898303D0-0x00000001898303F0
	private void OnMiddleLevelChange() {} // 0x0000000181C30E50-0x0000000181C30FB0
	// [XID] // 0x0000000189837A90-0x0000000189837AB0
	public bool IsInTower() => default; // 0x0000000181C34350-0x0000000181C34410
	// [XID] // 0x000000018983F230-0x000000018983F250
	public void ClearTowerInfo() {} // 0x0000000181C347C0-0x0000000181C34870
	// [XID] // 0x0000000189846830-0x0000000189846850
	private void OnEnterTowerLevel() {} // 0x0000000181C346B0-0x0000000181C347C0
	// [XID] // 0x000000018984DDE0-0x000000018984DE00
	private void CheckInTowerAction() {} // 0x0000000181C31710-0x0000000181C319C0
	// [XID] // 0x0000000189854E90-0x0000000189854EB0
	private void OnTowerBriefDataNotify(TowerBriefDataNotify ntf) {} // 0x0000000181C302E0-0x0000000181C304A0
	// [XID] // 0x000000018985C630-0x000000018985C650
	public void RequestTowerAllData(bool isInteract = false /* Metadata: 0x00AFFA93 */) {} // 0x0000000181C31380-0x0000000181C31480
	// [XID] // 0x0000000189864010-0x0000000189864030
	private void OnTowerAllDataRsp(TowerAllDataRsp rsp) {} // 0x0000000181C31AA0-0x0000000181C32290
	// [XID] // 0x000000018986B3E0-0x000000018986B400
	private void OnTowerFloorRecordChangeNotify(TowerFloorRecordChangeNotify ntf) {} // 0x0000000181C34FC0-0x0000000181C350E0
	// [XID] // 0x0000000189872710-0x0000000189872730
	private void OnTowerDailyRecordChangeNotify(TowerCurLevelRecordChangeNotify ntf) {} // 0x0000000181C34A20-0x0000000181C34AF0
	// [XID] // 0x000000018987A330-0x000000018987A350
	private void OnTowerDailyRewardProgressChangeNotify(TowerDailyRewardProgressChangeNotify ntf) {} // 0x0000000181C342A0-0x0000000181C34350
	// [XID] // 0x00000001898814C0-0x00000001898814E0
	public void RequestTowerTeamSelect(uint floorId, List<TowerTeamData> towerTeamList) {} // 0x0000000181C31480-0x0000000181C31710
	// [XID] // 0x0000000189888A40-0x0000000189888A60
	private void OnTowerTeamSelectRsp(TowerTeamSelectRsp rsp) {} // 0x0000000181C323D0-0x0000000181C32530
	// [XID] // 0x000000018988FDC0-0x000000018988FDE0
	public void RequestTowerEnterLevel(uint pointId) {} // 0x0000000181C36C80-0x0000000181C36D90
	// [XID] // 0x0000000189897360-0x0000000189897380
	private void OnTowerEnterLevelRsp(TowerEnterLevelRsp rsp) {} // 0x0000000181C35AB0-0x0000000181C35C70
	// [XID] // 0x000000018989E840-0x000000018989E860
	public void RequestTowerBuffSelect(uint buffId) {} // 0x0000000181C32670-0x0000000181C32770
	// [XID] // 0x00000001898A6360-0x00000001898A6380
	private void OnTowerBuffSelectRsp(TowerBuffSelectRsp rsp) {} // 0x0000000181C331A0-0x0000000181C33350
	// [XID] // 0x00000001898AD9F0-0x00000001898ADA10
	public void RequestTowerSurrender() {} // 0x0000000181C319C0-0x0000000181C31AA0
	// [XID] // 0x00000001898B4E80-0x00000001898B4EA0
	private void OnTowerSurrenderRsp(TowerSurrenderRsp rsp) {} // 0x0000000181C32970-0x0000000181C32AD0
	// [XID] // 0x00000001898BC9B0-0x00000001898BC9D0
	public void RequestTowerGetFloorStarReward(uint floorId) {} // 0x0000000181C30FB0-0x0000000181C310B0
	// [XID] // 0x00000001898C40B0-0x00000001898C40D0
	private void OnTowerGetFloorStarRewardRsp(TowerGetFloorStarRewardRsp rsp) {} // 0x0000000181C33470-0x0000000181C335D0
	// [XID] // 0x00000001898CB7D0-0x00000001898CB7F0
	public void RequestTowerRecordHandbook() {} // 0x0000000181C358D0-0x0000000181C359B0
	// [XID] // 0x00000001898D2EF0-0x00000001898D2F10
	private void OnTowerRecordHandbookRsp(TowerRecordHandbookRsp rsp) {} // 0x0000000181C34D50-0x0000000181C34FC0
	// [XID] // 0x00000001898DA840-0x00000001898DA860
	private void OnTowerLevelStarCond(TowerLevelStarCondNotify ntf) {} // 0x0000000181C36D90-0x0000000181C36F40
	// [XID] // 0x00000001898E2640-0x00000001898E2660
	public void OnTowerLevelEndNotify(TowerLevelEndNotify ntf) {} // 0x0000000181C36000-0x0000000181C361A0
	// [XID] // 0x00000001898EA150-0x00000001898EA170
	public List<uint> GetFloorList(TowerFloorType type = TowerFloorType.Default /* Metadata: 0x00AFFA94 */) => default; // 0x0000000181C374A0-0x0000000181C377B0
	// [XID] // 0x00000001898F1970-0x00000001898F1990
	private void RefreshReason(TowerLevelEndNotify ntf) {} // 0x0000000181C36850-0x0000000181C36A50
	// [XID] // 0x00000001898F90B0-0x00000001898F90D0
	private void ClearLevelEndData() {} // 0x0000000181C322F0-0x0000000181C323D0
	// [XID] // 0x0000000189900990-0x00000001899009B0
	public void ShowWin() {} // 0x0000000181C32AD0-0x0000000181C32BF0
	// [XID] // 0x00000001899081D0-0x00000001899081F0
	public void ShowEnd(bool canRestart) {} // 0x0000000181C304A0-0x0000000181C305D0
	// [XID] // 0x000000018990F930-0x000000018990F950
	public void DoExit() {} // 0x0000000181C350E0-0x0000000181C351D0
	// [XID] // 0x0000000189917420-0x0000000189917440
	public void TryNextFloor() {} // 0x0000000181C32DD0-0x0000000181C32F10
	// [XID] // 0x000000018991EA80-0x000000018991EAA0
	public void TryRestart() {} // 0x0000000181C370B0-0x0000000181C37160
	// [XID] // 0x0000000189926340-0x0000000189926360
	public void TryNextLevel() {} // 0x0000000181C36BD0-0x0000000181C36C80
	// [XID] // 0x000000018992DA50-0x000000018992DA70
	private void RefreshTowerFloorRecord(IList<TowerFloorRecord> floorList) {} // 0x0000000181C351D0-0x0000000181C35780
	// [XID] // 0x0000000189934F10-0x0000000189934F30
	private void RefreshTowerDailyRecord(TowerCurLevelRecord record) {} // 0x0000000181C377B0-0x0000000181C37A30
	// [XID] // 0x000000018993CA50-0x000000018993CA70
	private void CheckBestRecordRefresh(TowerFloorRecord floorRecord) {} // 0x0000000181C337E0-0x0000000181C33950
	// [XID] // 0x0000000189944020-0x0000000189944040
	private void RefreshBestRecord(uint floorIndex, uint levelIndex) {} // 0x0000000181C30220-0x0000000181C302E0
	// [XID] // 0x0000000189971060-0x0000000189971080
	public string GetDailyRecordText(bool fullText) => default; // 0x0000000181C30C20-0x0000000181C30DB0
	// [XID] // 0x000000018998EFE0-0x000000018998F000
	public bool IsInMultiNumFloor() => default; // 0x0000000181C34B70-0x0000000181C34C50
	// [XID] // 0x00000001899BC590-0x00000001899BC5B0
	public uint GetTowerFloorStarCount(uint floorId) => default; // 0x0000000181C33EB0-0x0000000181C34050
	// [XID] // 0x00000001899C3EE0-0x00000001899C3F00
	public uint GetTowerAllStarCount() => default; // 0x0000000181C32F80-0x0000000181C331A0
	// [XID] // 0x00000001899CB710-0x00000001899CB730
	public ulong GetTowerStartTime() => default; // 0x0000000181C33C40-0x0000000181C33CE0
	// [XID] // 0x00000001899D2AD0-0x00000001899D2AF0
	public ulong GetTowerRefreshTime() => default; // 0x0000000181C32530-0x0000000181C325D0
	// [XID] // 0x00000001899DA160-0x00000001899DA180
	public TowerFloorData GetTowerFloorData(uint floorId) => default; // 0x0000000181C33DC0-0x0000000181C33EB0
	// [XID] // 0x00000001899E1C50-0x00000001899E1C70
	public TowerLevelExcelConfig GetPlayingTowerLevelConfig() => default; // 0x0000000181C32770-0x0000000181C32890
	// [XID] // 0x00000001899E9010-0x00000001899E9030
	public TowerLevelExcelConfig GetCurrTowerLevelConfig() => default; // 0x0000000181C33350-0x0000000181C33470
	// [XID] // 0x00000001899F0930-0x00000001899F0950
	public TowerLevelData GetTowerLevelData(uint levelId) => default; // 0x0000000181C341B0-0x0000000181C342A0
	// [XID] // 0x00000001899F8010-0x00000001899F8030
	public uint GetTowerFloorOpenTime(uint floorId) => default; // 0x0000000181C305D0-0x0000000181C306B0
	// [XID] // 0x00000001899FF6A0-0x00000001899FF6C0
	public TowerTeamData GetTowerTeamDataById(uint id) => default; // 0x0000000181C34870-0x0000000181C349C0
	// [XID] // 0x0000000189A06EC0-0x0000000189A06EE0
	public void ShowQuitTowerDialog() {} // 0x0000000181C35D80-0x0000000181C35F60
	// [XID] // 0x0000000189A0E590-0x0000000189A0E5B0
	private void ConfirmQuitTower(bool keepCurrent) {} // 0x0000000181C30730-0x0000000181C30890
	// [XID] // 0x0000000189A15BE0-0x0000000189A15C00
	public void ShowInTowerTransportDialog(uint pointID, bool isToPacketAnchor) {} // 0x0000000181C339B0-0x0000000181C33BC0
	// [XID] // 0x0000000189A1D010-0x0000000189A1D030
	private void ConfirmDoTransport(bool keepCurrent) {} // 0x0000000181C344B0-0x0000000181C346B0
	// [XID] // 0x0000000189A24650-0x0000000189A24670
	private void ConfirmDoTransportToPacketAnchor(bool keepCurrent) {} // 0x0000000181C34050-0x0000000181C341B0
	// [XID] // 0x0000000189A2BAF0-0x0000000189A2BB10
	public string GetStrFromCondition(TowerCondition condition) => default; // 0x0000000181C362B0-0x0000000181C36740
}

