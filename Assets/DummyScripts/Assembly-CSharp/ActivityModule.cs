/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityModule : BaseModule // TypeDefIndex: 21396
{
	// Fields
	private List<uint> _backupRegionSearchInfoUid; // 0x10
	private List<RepeatedMessageField<RegionSearchInfo>> _backupRegionSearchInfo; // 0x18
	private ArenaChallengeFinishNotify _finishInfo; // 0x20
	public uint arenaGadgetEntityId; // 0x28
	private Dictionary<uint, ActivityWatcherInfo> _arenaWatcherInfoDic; // 0x30
	private RepeatedMessageField<ActivityScheduleInfo> _activityScheduleList; // 0x38
	private Dictionary<uint, ActivityInfo> _activityInfos; // 0x40
	private List<uint> _workList; // 0x48
	private List<SimpleItemStruct> _itemAdded; // 0x58
	private Dictionary<uint, HashSet<uint>> _curCondIdDic; // 0x68
	private bool _isFlightInterrupt; // 0x70
	private bool _hasReceivedNewPic; // 0x71
	private bool _isInBlessingQuest; // 0x72
	private HashSet<uint> _activatedSaleIdList; // 0x78
	private EffigyChallengeInfoNotify _effigyChallengeInfo; // 0x80
	private List<Vector3> _treasureMapPosList; // 0x88
	public static bool LOCK_SEA_LAMP_BETA; // 0x00
	private bool _activityExpeditionActive; // 0x90
	private ExpeditionActivityDetailInfo _expeditionActivityInfo; // 0x98
	private Dictionary<uint, ulong> _regionIdToTimeStampDic; // 0xA0
	private List<Tuple<uint, uint>> _assistInfoList; // 0xA8
	private List<uint> _occupiedAvatarList; // 0xB0
	private uint _challengeAreaMarkRuntimeID; // 0xB8
	private uint _expeditionChallengeCurrentChallengeId; // 0xBC
	private ChannellerSlabLoopDungeonChallengeInfoNotify _CSLoopDungeonChallengeInfo; // 0xC0
	private RepeatedPrimitiveField<uint> _CSOneOffDungeonBuffList; // 0xC8
	private Dictionary<uint, List<uint>> _miniTomoDay2Assignments; // 0xD0
	private List<uint> _miniTomoHiliWeis; // 0xD8
	private const NewActivityType MINITOMO_ACTIVITY_TYPE = NewActivityType.NEW_ACTIVITY_FIND_HILICHURL; // Metadata: 0x00AFF7AE
	private bool _isShowHiliWeiMark; // 0xE0
	private uint _miniTomoHiliWeiAreaMarkID; // 0xE4
	private RepeatedMessageField<MistTrialLevelData> _mistTrialLevelInfoList; // 0xE8
	private Dictionary<uint, List<Tuple<ActivityMistTrialWatcherListDataExcelConfig, ActivityWatcherInfo>>> _level2WatcherInfoDic; // 0xF0
	private RepeatedMessageField<MistTrialMissionInfo> _mistTrialWatcherInfoList; // 0xF8

	// Properties
	public ArenaChallengeFinishNotify finishInfo { /* [XID] */ /* 0x000000018989D1E0-0x000000018989D200 */ get => default; } // 0x000000018109B970-0x000000018109BA10 
	public Dictionary<uint, ActivityWatcherInfo> arenaWatcherInfoDic { /* [XID] */ /* 0x00000001898BB4F0-0x00000001898BB510 */ get => default; } // 0x00000001810B3C90-0x00000001810B3D30 
	public RepeatedMessageField<ActivityScheduleInfo> activityScheduleList { /* [XID] */ /* 0x00000001898D1910-0x00000001898D1930 */ get => default; } // 0x00000001810B1FE0-0x00000001810B2080 
	public Dictionary<uint, ActivityInfo> activityInfos { /* [XID] */ /* 0x00000001898D90B0-0x00000001898D90D0 */ get => default; } // 0x00000001810AF360-0x00000001810AF400 
	public uint remainFlySeaLampNum { /* [XID] */ /* 0x00000001898E0D30-0x00000001898E0D70 */ get; /* [XID] */ /* 0x00000001898EB730-0x00000001898EB770 */ private set; } // 0x0000000181098360-0x00000001810983C0 0x000000018109EEB0-0x000000018109EF10
	public uint curTracingActivityID { /* [XID] */ /* 0x00000001898F60E0-0x00000001898F6120 */ get; /* [XID] */ /* 0x0000000189900A10-0x0000000189900A50 */ set; } // 0x000000018109F170-0x000000018109F1D0 0x00000001810A7730-0x00000001810A7790
	public uint trialAvatarIndexId { /* [XID] */ /* 0x0000000189A9DAD0-0x0000000189A9DB10 */ get; /* [XID] */ /* 0x0000000189AA7FC0-0x0000000189AA8000 */ set; } // 0x00000001810B49E0-0x00000001810B4A40 0x000000018109DC40-0x000000018109DCA0
	private BlessingActivityDetailInfo blessingInfo { /* [XID] */ /* 0x0000000189BC2DD0-0x0000000189BC2DF0 */ get => default; } // 0x00000001810ADFE0-0x00000001810AE0E0 
	public bool hasReceivedNewPic { /* [XID] */ /* 0x0000000189BCA530-0x0000000189BCA550 */ get => default; /* [XID] */ /* 0x0000000189BD1BA0-0x0000000189BD1BC0 */ set {} } // 0x00000001810B6B70-0x00000001810B6C10 0x00000001810A7790-0x00000001810A7850
	public bool hasBlessingQuestFinishRP { /* [XID] */ /* 0x0000000189BD9170-0x0000000189BD91B0 */ get; /* [XID] */ /* 0x00000001895E8CD0-0x00000001895E8D10 */ set; } // 0x00000001810B1430-0x00000001810B1490 0x00000001810B0790-0x00000001810B07F0
	public bool hasBlessingReward { /* [XID] */ /* 0x00000001895FAC90-0x00000001895FACB0 */ get => default; } // 0x00000001810A2DE0-0x00000001810A30F0 
	public uint blessingScanNum { /* [XID] */ /* 0x0000000189609E10-0x0000000189609E30 */ get => default; } // 0x000000018109E180-0x000000018109E250 
	public MapField<uint, uint> blessingPicNumMap { /* [XID] */ /* 0x0000000189611640-0x0000000189611660 */ get => default; } // 0x00000001810B1360-0x00000001810B1430 
	public uint blessingScanTypeId { /* [XID] */ /* 0x0000000189618F40-0x0000000189618F60 */ get => default; } // 0x00000001810A8070-0x00000001810A8140 
	public uint blessingRedeemRewardNum { /* [XID] */ /* 0x0000000189620480-0x00000001896204A0 */ get => default; } // 0x00000001810AC930-0x00000001810ACA00 
	public bool isBlessingActivated { /* [XID] */ /* 0x0000000189627930-0x0000000189627950 */ get => default; } // 0x00000001810A8E60-0x00000001810A8F30 
	public bool isBlessingClosed { /* [XID] */ /* 0x000000018962F330-0x000000018962F350 */ get => default; } // 0x000000018109C8E0-0x000000018109C9B0 
	public EffigyChallengeInfoNotify effigyChallengeInfo { /* [XID] */ /* 0x00000001896B6100-0x00000001896B6120 */ get => default; /* [XID] */ /* 0x00000001896BD380-0x00000001896BD3A0 */ set {} } // 0x000000018109E810-0x000000018109E8C0 0x00000001810AAC70-0x00000001810AAD60
	public List<Vector3> treasureMapPosList { /* [XID] */ /* 0x00000001896F8420-0x00000001896F8440 */ get => default; } // 0x00000001810A8BB0-0x00000001810A8C60 
	public bool activityExpeditionActive { /* [XID] */ /* 0x000000018979D130-0x000000018979D150 */ get => default; } // 0x000000018109D990-0x000000018109DA40 
	public ExpeditionActivityDetailInfo expeditionActivityInfo { /* [XID] */ /* 0x00000001897A4430-0x00000001897A4450 */ get => default; } // 0x00000001810B3E10-0x00000001810B3EC0 
	public List<Tuple<uint, uint>> assistInfoList { /* [XID] */ /* 0x00000001897F0300-0x00000001897F0320 */ get => default; } // 0x0000000181099000-0x00000001810990E0 
	public List<uint> occupiedAvatarList { /* [XID] */ /* 0x00000001897F7A70-0x00000001897F7A90 */ get => default; } // 0x00000001810B5000-0x00000001810B50E0 
	public uint expeditionChallengeCurrentChallengeId { /* [XID] */ /* 0x00000001898156B0-0x00000001898156D0 */ get => default; } // 0x00000001810B2490-0x00000001810B2530 
	public ChannellerSlabLoopDungeonChallengeInfoNotify CSLoopDungeonChallengeInfo { /* [XID] */ /* 0x00000001898A1920-0x00000001898A1940 */ get => default; /* [XID] */ /* 0x00000001898A9150-0x00000001898A9170 */ set {} } // 0x00000001810B6FB0-0x00000001810B7060 0x00000001810A9C80-0x00000001810A9DA0
	public RepeatedPrimitiveField<uint> CSOneOffDungeonBuffList { /* [XID] */ /* 0x00000001898ECDA0-0x00000001898ECDC0 */ get => default; } // 0x00000001810B4200-0x00000001810B42B0 
	public RepeatedMessageField<MistTrialLevelData> mistTrialLevelInfoList { /* [XID] */ /* 0x00000001899EC0F0-0x00000001899EC110 */ get => default; } // 0x00000001810ABA70-0x00000001810ABB20 
	public Dictionary<uint, List<Tuple<ActivityMistTrialWatcherListDataExcelConfig, ActivityWatcherInfo>>> level2WatcherInfoDic { /* [XID] */ /* 0x00000001899FB3D0-0x00000001899FB3F0 */ get => default; } // 0x00000001810993C0-0x0000000181099480 
	public RepeatedMessageField<MistTrialMissionInfo> mistTrialWatcherInfoList { /* [XID] */ /* 0x0000000189A2EC40-0x0000000189A2EC60 */ get => default; } // 0x00000001810AEA60-0x00000001810AEB10 

	// Constructors
	public ActivityModule() {} // 0x00000001810B89B0-0x00000001810B8DD0
	static ActivityModule() {} // 0x00000001810B8950-0x00000001810B89B0

	// Methods
	// [XID] // 0x0000000189869AC0-0x0000000189869AE0
	public void FetchBackupRegionSearchInfo(out List<uint> uid, out List<RepeatedMessageField<RegionSearchInfo>> result) {
		uid = default;
		result = default;
	} // 0x00000001810AD410-0x00000001810AD530
	// [XID] // 0x0000000189870E40-0x0000000189870E60
	private void OnRegionSearchNotify(RegionSearchNotify ntf) {} // 0x00000001810B6420-0x00000001810B66B0
	// [XID] // 0x00000001898787F0-0x0000000189878810
	public void RequestCurrentWorldRegionSearchInfo() {} // 0x00000001810AE200-0x00000001810AE2E0
	// [XID] // 0x000000018987FDA0-0x000000018987FDC0
	public void RequestRegionReward(uint searchId, uint regionId) {} // 0x00000001810A50C0-0x00000001810A51E0
	// [XID] // 0x00000001898873A0-0x00000001898873C0
	private void OnTakeRegionSearchRewardRsp(TakeRegionSearchRewardRsp rsp) {} // 0x00000001810ACB20-0x00000001810ACFC0
	// [XID] // 0x000000018988E520-0x000000018988E540
	public uint IsArenaChallengeLevelOpen(uint levelId) => default; // 0x00000001810B8720-0x00000001810B8950
	// [XID] // 0x0000000189895B20-0x0000000189895B40
	public bool IsArenaChallengeGuidQuestFinish() => default; // 0x00000001810B2080-0x00000001810B21D0
	// [XID] // 0x00000001898A4B40-0x00000001898A4B60
	private void OnArenaChallengeFinishNotify(ArenaChallengeFinishNotify ntf) {} // 0x00000001810AEB10-0x00000001810AF070
	// [XID] // 0x00000001898ABFC0-0x00000001898ABFE0
	private void OnStartArenaChallengeLevelRsp(StartArenaChallengeLevelRsp rsp) {} // 0x00000001810AC3D0-0x00000001810AC5C0
	// [XID] // 0x00000001898B3680-0x00000001898B36A0
	private void OnArenaChallengeInfoNotify(ActivityInfo activityInfo) {} // 0x00000001810B6EF0-0x00000001810B6FB0
	// [XID] // 0x00000001898C2760-0x00000001898C2780
	private void RefreshArenaChallengeWatcherInfoDic(uint watcherId = 0 /* Metadata: 0x00AFF79D */) {} // 0x000000018109FA50-0x000000018109FDB0
	// [XID] // 0x00000001898CA1C0-0x00000001898CA1E0
	public bool IsArenaChallenge(uint groupId) => default; // 0x00000001810B2D60-0x00000001810B2FD0
	// [IDTag] // 0x000000018990AEF0-0x000000018990AF30
	// [XID] // 0x000000018990AEF0-0x000000018990AF30
	public ActivityInfo GetActivityInfo(NewActivityType type) => default; // 0x00000001810B1140-0x00000001810B1360
	// [IDTag] // 0x0000000189915920-0x0000000189915960
	// [XID] // 0x0000000189915920-0x0000000189915960
	public ActivityInfo GetActivityInfo(uint activityId) => default; // 0x00000001810B1050-0x00000001810B1140
	// [XID] // 0x0000000189920170-0x0000000189920190
	public ActivityScheduleInfo GetActivityScheduleInfo(NewActivityType type) => default; // 0x0000000181097F00-0x0000000181098080
	// [IDTag] // 0x00000001899279F0-0x0000000189927A30
	// [XID] // 0x00000001899279F0-0x0000000189927A30
	public uint GetActivityCoinNum(uint materialId) => default; // 0x000000018109FDB0-0x00000001810A00F0
	// [IDTag] // 0x0000000189932040-0x0000000189932080
	// [XID] // 0x0000000189932040-0x0000000189932080
	public uint GetActivityCoinNum(uint activityId, uint materialId) => default; // 0x00000001810A00F0-0x00000001810A0340
	// [XID] // 0x000000018993CA70-0x000000018993CA90
	public uint GetActivityCoin(uint itemID, NewActivityType activityType) => default; // 0x00000001810B75D0-0x00000001810B77D0
	// [XID] // 0x00000001899440C0-0x00000001899440E0
	public override void ClearOnBackHome() {} // 0x00000001810A46B0-0x00000001810A47F0
	// [XID] // 0x000000018994B650-0x000000018994B670
	public override void ClearOnDisconnect() {} // 0x00000001810B56F0-0x00000001810B5790
	// [XID] // 0x0000000189952F30-0x0000000189952F50
	public override void ClearOnLevelDestroy() {} // 0x000000018109BDB0-0x000000018109BE70
	// [XID] // 0x000000018995A4B0-0x000000018995A4D0
	public override bool OnPacket(Packet packet) => default; // 0x000000018109A5C0-0x000000018109B870
	// [XID] // 0x0000000189961F70-0x0000000189961F90
	private void OnServerAnnounceNotify(ServerAnnounceNotify ntf) {} // 0x00000001810A3650-0x00000001810A38E0
	// [XID] // 0x00000001899694A0-0x00000001899694C0
	private void OnServerAnnounceRevokeNotify(ServerAnnounceRevokeNotify ntf) {} // 0x000000018109EF10-0x000000018109F170
	// [XID] // 0x0000000189971100-0x0000000189971120
	private void FireActivityUpdateNotify(uint activityId) {} // 0x000000018109E6A0-0x000000018109E810
	// [XID] // 0x0000000189978AD0-0x0000000189978AF0
	private void OnGetActivityScheduleRsp(GetActivityScheduleRsp rsp) {} // 0x0000000181097780-0x0000000181097830
	// [XID] // 0x000000018997FB50-0x000000018997FB70
	private void OnActivityScheduleInfoNotify(ActivityScheduleInfoNotify rsp) {} // 0x00000001810A33E0-0x00000001810A3650
	// [IDTag] // 0x0000000189987410-0x0000000189987450
	// [XID] // 0x0000000189987410-0x0000000189987450
	private void RequestActivityInfo(List<uint> activityIds) {} // 0x00000001810A1AF0-0x00000001810A1C10
	// [IDTag] // 0x00000001899920A0-0x00000001899920E0
	// [XID] // 0x00000001899920A0-0x00000001899920E0
	public void RequestActivityInfo() {} // 0x00000001810A1C10-0x00000001810A1E20
	// [XID] // 0x000000018999CD30-0x000000018999CD50
	private void OnActivityCondStateChangeNotify(ActivityCondStateChangeNotify ntf) {} // 0x00000001810B4020-0x00000001810B4120
	// [XID] // 0x00000001899A45B0-0x00000001899A45D0
	private void UpdateActivityScheduleList(ActivityInfo activityInfo) {} // 0x00000001810B2880-0x00000001810B2B50
	// [XID] // 0x00000001899ABFD0-0x00000001899ABFF0
	private void OnGetActivityInfoRsp(GetActivityInfoRsp rsp) {} // 0x00000001810A5F70-0x00000001810A6920
	// [XID] // 0x00000001899B3840-0x00000001899B3860
	private void OnActivityCoinInfoNotify(ActivityCoinInfoNotify ntf) {} // 0x0000000181099950-0x0000000181099F40
	// [XID] // 0x00000001899BAC40-0x00000001899BAC60
	public void NotifyActivityPlayOpenAnim(ActivityInfo activityInfo) {} // 0x00000001810B7060-0x00000001810B71B0
	// [XID] // 0x00000001899C2630-0x00000001899C2650
	private void OnActivityInfoNotify(ActivityInfoNotify ntf) {} // 0x00000001810A8270-0x00000001810A8BB0
	// [XID] // 0x00000001899C9CC0-0x00000001899C9CE0
	private void OnActivityChange(uint activityId, bool isOpen) {} // 0x00000001810B3760-0x00000001810B3A70
	// [XID] // 0x00000001899D1540-0x00000001899D1560
	private void OnActivityCloseHint(uint activituyId, uint activityType) {} // 0x00000001810A30F0-0x00000001810A3200
	// [IDTag] // 0x00000001899D8A30-0x00000001899D8A70
	// [XID] // 0x00000001899D8A30-0x00000001899D8A70
	public static void OnActivityClose(uint activityId, uint myActivityId, Action Close) {} // 0x00000001810B5E50-0x00000001810B5FC0
	// [XID] // 0x00000001899E3230-0x00000001899E3250
	public void RequestActivityTakeWatcherReward(uint activityID, uint wactherID) {} // 0x000000018109D4A0-0x000000018109D5C0
	// [XID] // 0x00000001899EA7C0-0x00000001899EA7E0
	public void RequestActivityTakeWatcherRewardBatch(uint activityID, List<uint> watcherIDList) {} // 0x000000018109BE70-0x000000018109BFE0
	// [XID] // 0x00000001899F2310-0x00000001899F2330
	private void OnActivityTakeWatcherRewardBatchRsp(ActivityTakeWatcherRewardBatchRsp rsp) {} // 0x00000001810B50E0-0x00000001810B5620
	// [XID] // 0x00000001899F98F0-0x00000001899F9910
	private void OnActivityTakeWatcherRewardRsp(ActivityTakeWatcherRewardRsp rsp) {} // 0x00000001810AF9C0-0x00000001810AFD00
	// [XID] // 0x0000000189A00CD0-0x0000000189A00CF0
	private void OnActivityUpdateWatcherNotify(ActivityUpdateWatcherNotify ntf) {} // 0x00000001810A0480-0x00000001810A0D00
	// [XID] // 0x0000000189A085B0-0x0000000189A085D0
	public void OnShowTemplateReminderNotify(uint tempId, NewActivityType activityType) {} // 0x00000001810B4910-0x00000001810B49E0
	// [XID] // 0x0000000189A0FBB0-0x0000000189A0FBD0
	private void ModifySamLampPhaseId(ActivityInfo activityInfo) {} // 0x00000001810B6A50-0x00000001810B6B70
	// [XID] // 0x0000000189A17030-0x0000000189A17050
	public void RequestSeaLampFlyLampReq(uint itemId, uint num) {} // 0x00000001810AF400-0x00000001810AF9C0
	// [XID] // 0x0000000189A1E740-0x0000000189A1E760
	private void CheckSeaLampContributionAndProgressAdd(uint addContribution, uint addProgress) {} // 0x000000018109A020-0x000000018109A1B0
	// [XID] // 0x0000000189A25E30-0x0000000189A25E50
	private void OnSeaLampFlyLampRsp(SeaLampFlyLampRsp rsp) {} // 0x00000001810AD840-0x00000001810AD9A0
	// [XID] // 0x0000000189A2D270-0x0000000189A2D290
	private void OnSeaLampFlyLampNotify(SeaLampFlyLampNotify rsp) {} // 0x00000001810ABB20-0x00000001810ABEF0
	// [XID] // 0x0000000189A34CD0-0x0000000189A34CF0
	public void RequestSeaLampTakeContributionRewardReq(uint activityId, uint configId) {} // 0x00000001810B8300-0x00000001810B8420
	// [XID] // 0x0000000189A3C040-0x0000000189A3C060
	private void OnSeaLampTakeContributionRewardRsp(SeaLampTakeContributionRewardRsp rsp) {} // 0x00000001810AB800-0x00000001810ABA70
	// [XID] // 0x0000000189A43CF0-0x0000000189A43D10
	public void RequestSeaLampTakePhaseRewardReq(uint activityId, uint phaseId) {} // 0x00000001810B7BE0-0x00000001810B7D00
	// [XID] // 0x0000000189A4B160-0x0000000189A4B180
	private void OnSeaLampTakePhaseRewardRsp(SeaLampTakePhaseRewardRsp rsp) {} // 0x00000001810A7AE0-0x00000001810A7DA0
	// [XID] // 0x0000000189A52840-0x0000000189A52860
	public void RequestSeaLampContributeItemReq(uint activityId, Dictionary<uint, uint> itemDict) {} // 0x00000001810B7EE0-0x00000001810B8180
	// [XID] // 0x0000000189A5A1E0-0x0000000189A5A200
	private void OnSeaLampContributeItemRsp(SeaLampContributeItemRsp rsp) {} // 0x00000001810987B0-0x0000000181098A50
	// [XID] // 0x0000000189A61A10-0x0000000189A61A30
	public static LampPhaseExcelConfig GetLampPhaseExcelData(uint phase) => default; // 0x0000000181098230-0x0000000181098360
	// [XID] // 0x0000000189A69970-0x0000000189A69990
	public bool CheckSeaLampContributionReward() => default; // 0x00000001810A6920-0x00000001810A6BD0
	// [XID] // 0x0000000189A70C00-0x0000000189A70C20
	public bool CheckSeaLampPhaseReward() => default; // 0x00000001810B16B0-0x00000001810B18F0
	// [XID] // 0x0000000189A78560-0x0000000189A78580
	public bool CheckSeaLampTab2() => default; // 0x00000001810B0200-0x00000001810B02F0
	// [XID] // 0x0000000189A7FAF0-0x0000000189A7FB10
	public bool CheckSeaLampTab3() => default; // 0x00000001810B6960-0x00000001810B6A50
	// [XID] // 0x0000000189A87840-0x0000000189A87860
	public int GetLastSeaLampOpenedQuestIndex() => default; // 0x0000000181097CF0-0x0000000181097F00
	// [XID] // 0x0000000189A8EFF0-0x0000000189A8F010
	public void EnterTrialAvatarActivityDungeonReq(uint activityID, uint trialIndex) {} // 0x00000001810A8140-0x00000001810A8270
	// [XID] // 0x0000000189A965A0-0x0000000189A965C0
	public void ReceivedTrialAvatarActivityRewardReq(uint trialIndex) {} // 0x00000001810B0E20-0x00000001810B0F20
	// [XID] // 0x0000000189AB2C00-0x0000000189AB2C20
	private void OnEnterTrialAvatarActivityDungeonRsp(EnterTrialAvatarActivityDungeonRsp rsp) {} // 0x00000001810A7970-0x00000001810A7AE0
	// [XID] // 0x0000000189ABA740-0x0000000189ABA760
	private void OnTrialAvatarInDungeonIndexNotify(TrialAvatarInDungeonIndexNotify ntf) {} // 0x00000001810A59A0-0x00000001810A5AA0
	// [XID] // 0x0000000189AC2050-0x0000000189AC2070
	private void OnReceivedTrialAvatarActivityRewardRsp(ReceivedTrialAvatarActivityRewardRsp rsp) {} // 0x00000001810B02F0-0x00000001810B0630
	// [XID] // 0x0000000189AC96A0-0x0000000189AC96C0
	public void OnTrialAvatarFirstPassDungeonNotify(TrialAvatarFirstPassDungeonNotify ntf) {} // 0x00000001810B21D0-0x00000001810B2490
	// [XID] // 0x0000000189AD1030-0x0000000189AD1050
	public bool IsTarCondIdValid(uint activityId, uint condId) => default; // 0x00000001810A10D0-0x00000001810A11E0
	// [XID] // 0x0000000189AD8E10-0x0000000189AD8E30
	private void OnActivityOpen(uint activityId) {} // 0x00000001810AD9A0-0x00000001810ADAB0
	// [IDTag] // 0x0000000189AE08E0-0x0000000189AE0920
	// [XID] // 0x0000000189AE08E0-0x0000000189AE0920
	private void OnActivityClose(uint activityId) {} // 0x00000001810B5CB0-0x00000001810B5E50
	// [XID] // 0x0000000189AEAFB0-0x0000000189AEAFD0
	private void UpdateActivityCond(uint activityId, IList<uint> meetList, IList<uint> expireList) {} // 0x00000001810B44D0-0x00000001810B4710
	// [XID] // 0x0000000189AF28C0-0x0000000189AF28E0
	private void InitActivityCond(IList<ActivityInfo> activityInfos) {} // 0x00000001810A9270-0x00000001810A9510
	// [XID] // 0x0000000189AFA1E0-0x0000000189AFA200
	public void SalesmanDeliverItemReq(uint scheduleId) {} // 0x00000001810AC830-0x00000001810AC930
	// [XID] // 0x0000000189B01760-0x0000000189B01780
	public void SalesmanTakeRewardReq(uint scheduleId, uint position) {} // 0x00000001810AAD60-0x00000001810AAE80
	// [XID] // 0x0000000189B08CB0-0x0000000189B08CD0
	public void GetAuthSalesmanInfoReq(uint scheduleId) {} // 0x00000001810A9B80-0x00000001810A9C80
	// [XID] // 0x0000000189B10750-0x0000000189B10770
	public void SalesmanTakeSpecialRewardReq(uint scheduleId) {} // 0x00000001810A71F0-0x00000001810A72F0
	// [XID] // 0x0000000189B17880-0x0000000189B178A0
	private void OnSalesmanTakeSpecialRewardRsp(SalesmanTakeSpecialRewardRsp rsp) {} // 0x00000001810A0E70-0x00000001810A10D0
	// [XID] // 0x0000000189B1F140-0x0000000189B1F160
	private void OnGetAuthSalesmanInfoRsp(GetAuthSalesmanInfoRsp rsp) {} // 0x00000001810AE850-0x00000001810AEA60
	// [XID] // 0x0000000189B26A10-0x0000000189B26A30
	private void OnSalesmanTakeRewardRsp(SalesmanTakeRewardRsp rsp) {} // 0x000000018109DCA0-0x000000018109DE90
	// [XID] // 0x0000000189B2DBE0-0x0000000189B2DC00
	private void OnSalesmanDeliverItemRsp(SalesmanDeliverItemRsp rsp) {} // 0x000000018109EC80-0x000000018109EEB0
	// [XID] // 0x0000000189B35010-0x0000000189B35030
	private void OnAsterMidCampInfoNotify(AsterMidCampInfoNotify notify) {} // 0x00000001810A9A90-0x00000001810A9B80
	// [XID] // 0x0000000189B3C8E0-0x0000000189B3C900
	private void OnAsterMidInfoNotify(AsterMidInfoNotify asterMidInfoNotify) {} // 0x000000018109D0B0-0x000000018109D280
	// [XID] // 0x0000000189B44690-0x0000000189B446B0
	private void OnAsterLittleInfoNotify(AsterLittleInfoNotify asterLittleInfoNotify) {} // 0x000000018109BAE0-0x000000018109BCB0
	// [XID] // 0x0000000189B4BE20-0x0000000189B4BE40
	private void OnAsterProgressInfoNotify(AsterProgressInfoNotify asterProgressInfoNotify) {} // 0x00000001810AC200-0x00000001810AC3D0
	// [XID] // 0x0000000189B532D0-0x0000000189B532F0
	private void OnTakeAsterSpecialRewardRsp(TakeAsterSpecialRewardRsp rsp) {} // 0x000000018109DE90-0x000000018109E180
	// [XID] // 0x0000000189B5AC70-0x0000000189B5AC90
	public void TakeAsterSpecialRewardReq(uint scheduleId) {} // 0x000000018109BCB0-0x000000018109BDB0
	// [XID] // 0x0000000189B62070-0x0000000189B62090
	private void OnAsterMiscInfoNotify(AsterMiscInfoNotify asterMiscInfoNotify) {} // 0x00000001810A98B0-0x00000001810A9A90
	// [XID] // 0x0000000189B69CD0-0x0000000189B69CF0
	private void OnAsterLargeInfoNotify(AsterLargeInfoNotify asterLargeInfoNotify) {} // 0x00000001810A24D0-0x00000001810A26A0
	// [XID] // 0x0000000189B71240-0x0000000189B71260
	private void OnFlightActivitySettleNotify(FlightActivitySettleNotify flightSettleNotify) {} // 0x00000001810A70D0-0x00000001810A71F0
	// [XID] // 0x0000000189B788C0-0x0000000189B788E0
	public void FlightActivityRestartReq(uint scheduleId, uint groupId, bool isInterrupt) {} // 0x00000001810B3360-0x00000001810B34A0
	// [XID] // 0x0000000189B7FDF0-0x0000000189B7FE10
	private void OnFlightActivityRestartRsp(FlightActivityRestartRsp rsp) {} // 0x00000001810A4AC0-0x00000001810A4C20
	// [XID] // 0x0000000189B878C0-0x0000000189B878E0
	public bool IsFlightChallenge(uint groupId) => default; // 0x00000001810B3110-0x00000001810B3360
	// [XID] // 0x0000000189B8EA00-0x0000000189B8EA20
	private void OnTakeFoodDeliveryRewardRsp(TakeDeliveryDailyRewardRsp rsp) {} // 0x00000001810B8420-0x00000001810B8720
	// [XID] // 0x0000000189B95EA0-0x0000000189B95EC0
	private void OnFoodDeliveryNotify(FinishDeliveryNotify notify) {} // 0x00000001810B4B80-0x00000001810B5000
	// [XID] // 0x0000000189B9D460-0x0000000189B9D480
	private void OnDragonSpineChapterOpenNotify(DragonSpineChapterOpenNotify openNotify) {} // 0x000000018109F1D0-0x000000018109F4B0
	// [XID] // 0x0000000189BA4E70-0x0000000189BA4E90
	private void OnDragonSpineChapterProgressChangeNotify(DragonSpineChapterProgressChangeNotify changeNotify) {} // 0x00000001810A9510-0x00000001810A9800
	// [XID] // 0x0000000189BAC050-0x0000000189BAC070
	private void OnDragonSpineChapterFinishNotify(DragonSpineChapterFinishNotify finishNotify) {} // 0x00000001810AE4E0-0x00000001810AE850
	// [XID] // 0x0000000189BB3850-0x0000000189BB3870
	private void OnDragonSpineCoinChangeNotify(DragonSpineCoinChangeNotify coinNotify) {} // 0x000000018109D740-0x000000018109D990
	// [XID] // 0x0000000189BBADE0-0x0000000189BBAE00
	private void OnDragonSpineInfoNotify(ActivityInfo activityInfo) {} // 0x00000001810A8C60-0x00000001810A8E60
	// [XID] // 0x00000001895F3370-0x00000001895F3390
	public void ClearBlessingData() {} // 0x00000001810AB010-0x00000001810AB0F0
	// [XID] // 0x00000001896025A0-0x00000001896025C0
	private void BlessingUpdate() {} // 0x00000001810B8180-0x00000001810B8300
	// [XID] // 0x0000000189636DC0-0x0000000189636DE0
	private void OnBlessingInfoNotify(ActivityInfo activityInfo) {} // 0x00000001810A8FF0-0x00000001810A9270
	// [XID] // 0x000000018963E2E0-0x000000018963E300
	public void RequestBlessingScan(uint entityId) {} // 0x00000001810AD530-0x00000001810AD630
	// [XID] // 0x0000000189645BC0-0x0000000189645BE0
	private void OnBlessingScanRsp(BlessingScanRsp rsp) {} // 0x00000001810A6BD0-0x00000001810A6F90
	// [XID] // 0x000000018964D420-0x000000018964D440
	public void RequestBlessingGiveFriendPic(uint uid, uint picId) {} // 0x00000001810A7850-0x00000001810A7970
	// [XID] // 0x0000000189654C60-0x0000000189654C80
	private void OnBlessingGiveFriendPicRsp(BlessingGiveFriendPicRsp rsp) {} // 0x00000001810A51E0-0x00000001810A5490
	// [XID] // 0x000000018965C1F0-0x000000018965C210
	public void RequestBlessingAcceptGivePic(uint uid, uint index) {} // 0x00000001810AC710-0x00000001810AC830
	// [XID] // 0x00000001896639E0-0x0000000189663A00
	private void OnBlessingAcceptGivePicRsp(BlessingAcceptGivePicRsp rsp) {} // 0x00000001810B71B0-0x00000001810B74C0
	// [XID] // 0x000000018966B240-0x000000018966B260
	public void RequestBlessingAcceptAllGivePic() {} // 0x00000001810AF070-0x00000001810AF150
	// [XID] // 0x0000000189672EC0-0x0000000189672EE0
	private void OnBlessingAcceptAllGivePicRsp(BlessingAcceptAllGivePicRsp rsp) {} // 0x00000001810A72F0-0x00000001810A7730
	// [XID] // 0x000000018967A530-0x000000018967A550
	private void OnBlessingRecvFriendPicNotify(BlessingRecvFriendPicNotify ntf) {} // 0x00000001810990E0-0x0000000181099210
	// [XID] // 0x0000000189681DB0-0x0000000189681DD0
	public void RequestBlessingRedeemReward() {} // 0x00000001810B4120-0x00000001810B4200
	// [XID] // 0x0000000189689820-0x0000000189689840
	private void OnBlessingRedeemRewardRsp(BlessingRedeemRewardRsp rsp) {} // 0x00000001810A1EE0-0x00000001810A22A0
	// [XID] // 0x00000001896915C0-0x00000001896915E0
	private void InitSaleIds(IList<uint> activatedSaleIdList) {} // 0x00000001810995B0-0x0000000181099790
	// [XID] // 0x0000000189698C30-0x0000000189698C50
	private void OnActivatedSaleIdChangeNotify(ActivitySaleChangeNotify ntf) {} // 0x0000000181099210-0x00000001810993C0
	// [XID] // 0x00000001896A00F0-0x00000001896A0110
	public NewActivitySaleExcelConfig GetSaleWeaponData(uint itemId) => default; // 0x00000001810B1490-0x00000001810B1550
	// [XID] // 0x00000001896A7420-0x00000001896A7440
	public void RequestStartEffigyChallenge(uint pointId) {} // 0x00000001810B3580-0x00000001810B3760
	// [XID] // 0x00000001896AE940-0x00000001896AE960
	private void OnStartEffigyChallengeRsp(StartEffigyChallengeRsp rsp) {} // 0x00000001810B2530-0x00000001810B2690
	// [XID] // 0x00000001896C48A0-0x00000001896C48C0
	private void OnEffigyChallengeInfoNotify(EffigyChallengeInfoNotify notify) {} // 0x00000001810A5490-0x00000001810A5540
	// [XID] // 0x00000001896CBE30-0x00000001896CBE50
	private void OnEffigyChallengeResultNotify(EffigyChallengeResultNotify ntf) {} // 0x00000001810AC5C0-0x00000001810AC710
	// [XID] // 0x00000001896D31A0-0x00000001896D31C0
	public void RequestTakeEffigyFirstPassReward(uint challengeId) {} // 0x0000000181098080-0x0000000181098180
	// [XID] // 0x00000001896DAD80-0x00000001896DADA0
	private void OnTakeEffigyFirstPassRewardRsp(TakeEffigyFirstPassRewardRsp rsp) {} // 0x000000018109A460-0x000000018109A5C0
	// [XID] // 0x00000001896E24E0-0x00000001896E2500
	public void RequestTakeEffigyReward(uint rewardIndex) {} // 0x0000000181097830-0x0000000181097930
	// [XID] // 0x00000001896E99A0-0x00000001896E99C0
	private void OnTakeEffigyRewardRsp(TakeEffigyRewardRsp rsp) {} // 0x00000001810B0A40-0x00000001810B0E20
	// [XID] // 0x00000001896F0B80-0x00000001896F0BA0
	private void OnSelectEffigyChallengeConditionRsp(SelectEffigyChallengeConditionRsp rsp) {} // 0x000000018109EB20-0x000000018109EC80
	// [XID] // 0x00000001896FFD60-0x00000001896FFD80
	private void OnTreasureMapDetectorDataNotify(TreasureMapDetectorDataNotify ntf) {} // 0x00000001810A1570-0x00000001810A1AF0
	// [XID] // 0x0000000189707460-0x0000000189707480
	private void OnTreasureMapRegionInfoNotify(TreasureMapRegionInfoNotify newRegionInfo) {} // 0x000000018109F4B0-0x000000018109FA50
	// [XID] // 0x000000018970ED00-0x000000018970ED20
	private void OnTreasureMapBonusChallengeNotify(TreasureMapBonusChallengeNotify newBonus) {} // 0x00000001810ACFC0-0x00000001810AD3B0
	// [XID] // 0x0000000189716100-0x0000000189716120
	private void OnTreasureMapCurrencyNotify(TreasureMapCurrencyNotify newCurrency) {} // 0x00000001810A6F90-0x00000001810A70D0
	// [XID] // 0x000000018971DB60-0x000000018971DB80
	private void OnTreasureMapRegionActiveNotify(TreasureMapRegionActiveNotify regionActiveNotify) {} // 0x00000001810B5FC0-0x00000001810B6420
	// [XID] // 0x0000000189725040-0x0000000189725060
	private void OnTreasureMapMpChallengeNotify(TreasureMapMpChallengeNotify mpChallengeNotify) {} // 0x00000001810B7D00-0x00000001810B7EE0
	// [XID] // 0x000000018972C760-0x000000018972C780
	private void OnTreasureMapGuideTaskDoneNotify(TreasureMapGuideTaskDoneNotify guideTaskDoneNotify) {} // 0x0000000181099480-0x00000001810995B0
	// [XID] // 0x0000000189733E70-0x0000000189733E90
	private void TreasureMapNewRegionOpenedRedPointShow() {} // 0x0000000181099790-0x00000001810998D0
	// [XID] // 0x000000018973B5F0-0x000000018973B610
	private void OnSeaLampCoinNotify(SeaLampCoinNotify notify) {} // 0x00000001810B4A40-0x00000001810B4B80
	// [XID] // 0x00000001897430A0-0x00000001897430C0
	private void CheckSeaLamp(SeaLampActivityInfo oldInfo, SeaLampActivityInfo newInfo) {} // 0x00000001810AB450-0x00000001810AB780
	// [XID] // 0x000000018974AC00-0x000000018974AC20
	public SeaLampSectionExcelConfig GetSeaLampCurrentSectionConfig(ActivityInfo activityInfo) => default; // 0x000000018109DA40-0x000000018109DC40
	// [XID] // 0x0000000189751C90-0x0000000189751CB0
	public void OnSeaLampMechanicusNotify(ActivityInfo activityInfo) {} // 0x00000001810B6D80-0x00000001810B6EF0
	// [XID] // 0x00000001897593A0-0x00000001897593C0
	private void OnSeaLampPopularityNotify(SeaLampPopularityNotify notify) {} // 0x00000001810B2FD0-0x00000001810B3110
	// [XID] // 0x0000000189760F50-0x0000000189760F70
	public uint GetSeaLampPopularity() => default; // 0x0000000181099F40-0x000000018109A020
	// [XID] // 0x00000001897682E0-0x0000000189768300
	public uint GetSeaLampCoin() => default; // 0x00000001810B34A0-0x00000001810B3580
	// [XID] // 0x000000018976F8B0-0x000000018976F8D0
	public static uint GetSeaLampMiniQuestOpenTime(ActivityInfo activityInfo, SeaLampSectionMiniQuestExcelConfig questInfo) => default; // 0x00000001810A4140-0x00000001810A4240
	// [XID] // 0x0000000189777210-0x0000000189777230
	public void RequestActivitySelectAvatarCard(uint activityId, uint rewardId) {} // 0x00000001810ACA00-0x00000001810ACB20
	// [XID] // 0x000000018977E960-0x000000018977E980
	private void OnActivitySelectAvatarCardRsp(ActivitySelectAvatarCardRsp rsp) {} // 0x00000001810A4C20-0x00000001810A4DD0
	// [XID] // 0x00000001897860E0-0x0000000189786100
	public uint GetWaterSpriteCoin(uint itemID) => default; // 0x00000001810A38E0-0x00000001810A39F0
	// [XID] // 0x000000018978D770-0x000000018978D790
	private void OnActivityWaterSpriteNotify(ActivityInfo activityInfo) {} // 0x00000001810A5AA0-0x00000001810A5C30
	// [XID] // 0x0000000189794C00-0x0000000189794C20
	private void OnWaterSpritePhaseFinishNotify(WaterSpritePhaseFinishNotify ntf) {} // 0x00000001810A9DA0-0x00000001810AA060
	// [XID] // 0x00000001897AB9A0-0x00000001897AB9C0
	private void OnExpeditionInfoNotify(ActivityInfo ntf) {} // 0x0000000181098D90-0x0000000181099000
	// [XID] // 0x00000001897B3900-0x00000001897B3920
	private void OnGetExpeditionAssisInfoListRsp(GetExpeditionAssistInfoListRsp rsp) {} // 0x00000001810A43A0-0x00000001810A45B0
	// [XID] // 0x00000001897BB6F0-0x00000001897BB710
	private void OnExpeditionStartRsp(ExpeditionStartRsp rsp) {} // 0x00000001810B2B50-0x00000001810B2D60
	// [XID] // 0x00000001897C2F50-0x00000001897C2F70
	private void OnExpeditionRecallRsp(ExpeditionRecallRsp rsp) {} // 0x00000001810B2690-0x00000001810B2880
	// [XID] // 0x00000001897CA810-0x00000001897CA830
	private void OnExpeditionTakeRewardRsp(ExpeditionTakeRewardRsp rsp) {} // 0x00000001810ADC30-0x00000001810ADFE0
	// [XID] // 0x00000001897D1D50-0x00000001897D1D70
	private void OnExpeditionActivityNotify(ActivityInfoNotify ntf) {} // 0x00000001810A5C30-0x00000001810A5F70
	// [XID] // 0x00000001897D9BF0-0x00000001897D9C10
	private void OnExpeditionChallengeEnterRegionNotify(ExpeditionChallengeEnterRegionNotify ntf) {} // 0x00000001810B58A0-0x00000001810B5BB0
	// [XID] // 0x00000001897E0F20-0x00000001897E0F40
	private void OnExpeditionChallengeFinishedNotify(ExpeditionChallengeFinishedNotify ntf) {} // 0x000000018109C7A0-0x000000018109C8E0
	// [XID] // 0x00000001897E85F0-0x00000001897E8610
	public bool hasUnClaimedOrNotFinishPath() => default; // 0x000000018109E250-0x000000018109E460
	// [XID] // 0x00000001897FF0D0-0x00000001897FF0F0
	private void UpdateOccupiedActivityAvatarAndAssistInfoList() {} // 0x000000018109C9B0-0x000000018109CD60
	// [XID] // 0x0000000189806850-0x0000000189806870
	private List<SimpleItemStruct> CreateSimpleItemStructListByRewardId(uint rewardId) => default; // 0x00000001810AE2E0-0x00000001810AE4E0
	// [XID] // 0x000000018980E010-0x000000018980E030
	private void OnSetCurExpeditionChallengeIdRsp(SetCurExpeditionChallengeIdRsp rsp) {} // 0x00000001810A39F0-0x00000001810A3C90
	// [XID] // 0x000000018981D100-0x000000018981D120
	public void AddExpeditionChallengeAreaMark(uint challengeId) {} // 0x00000001810AFDE0-0x00000001810B0200
	// [XID] // 0x0000000189824560-0x0000000189824580
	public void RemoveChallengeAreaMark() {} // 0x00000001810ADAB0-0x00000001810ADC30
	// [XID] // 0x000000018982BFF0-0x000000018982C010
	private void ClearExpeditionActivityData() {} // 0x00000001810A1E20-0x00000001810A1EE0
	// [XID] // 0x0000000189833500-0x0000000189833520
	public void AddExpeditionActivityMark() {} // 0x0000000181098180-0x0000000181098230
	// [XID] // 0x000000018983A9E0-0x000000018983AA00
	public bool hasActivityExpeditionReward() => default; // 0x00000001810AD630-0x00000001810AD840
	// [XID] // 0x0000000189841FC0-0x0000000189841FE0
	public bool hasNewActivityExpeditionChallenge() => default; // 0x00000001810A7DA0-0x00000001810A8070
	// [XID] // 0x00000001898494C0-0x00000001898494E0
	public void GetFleurFairMark() {} // 0x000000018109CD60-0x000000018109D0B0
	// [XID] // 0x0000000189850CA0-0x0000000189850CC0
	private void CheckFleurFairContentClose(ActivityInfo activityInfo) {} // 0x00000001810A45B0-0x00000001810A46B0
	// [XID] // 0x00000001898580A0-0x00000001898580C0
	public uint GetCurFleurFairSectionId() => default; // 0x00000001810A26A0-0x00000001810A2990
	// [XID] // 0x000000018985F170-0x000000018985F190
	public FleurFairDungeonExcelConfig GetFleurFairDungeonData(uint activityId, uint sectionId) => default; // 0x00000001810B42B0-0x00000001810B44D0
	// [XID] // 0x00000001898669B0-0x00000001898669D0
	public ActivityAbilityGroupExcelConfig GetAbilityGroup(uint index) => default; // 0x00000001810A3200-0x00000001810A33E0
	// [XID] // 0x000000018986E250-0x000000018986E270
	public void ActivityTakeScoreRewardReq(uint activityID, uint rewardConfigId) {} // 0x00000001810AE0E0-0x00000001810AE200
	// [XID] // 0x0000000189875720-0x0000000189875740
	public void ActivityTakeAllScoreRewardReq(uint activityID) {} // 0x00000001810AB0F0-0x00000001810AB1F0
	// [XID] // 0x000000018987D270-0x000000018987D290
	public void HideAndSeekSelectSkillReq(List<uint> skillIDList) {} // 0x00000001810B4710-0x00000001810B4910
	// [XID] // 0x00000001898841B0-0x00000001898841D0
	private void OnActivityTakeAllScoreRewardRsp(ActivityTakeAllScoreRewardRsp rsp) {} // 0x00000001810A3EF0-0x00000001810A4050
	// [XID] // 0x000000018988B8E0-0x000000018988B900
	private void OnHideAndSeekSelectSkillRsp(HideAndSeekSelectSkillRsp rsp) {} // 0x00000001810AA6C0-0x00000001810AAB60
	// [XID] // 0x0000000189892FD0-0x0000000189892FF0
	private void OnActivityTakeScoreRewardRsp(ActivityTakeScoreRewardRsp rsp) {} // 0x00000001810A1410-0x00000001810A1570
	// [XID] // 0x000000018989A6D0-0x000000018989A6F0
	private void OnCommonPlayerTipsNotify(CommonPlayerTipsNotify notify) {} // 0x00000001810983C0-0x00000001810987B0
	// [XID] // 0x00000001898B0AC0-0x00000001898B0AE0
	public void RequestStartCSLoopDungeon(uint pointId) {} // 0x0000000181098A50-0x0000000181098C30
	// [XID] // 0x00000001898B8180-0x00000001898B81A0
	private void OnStartCSLoopDungeonRsp(ChannellerSlabEnterLoopDungeonRsp rsp) {} // 0x00000001810B0630-0x00000001810B0790
	// [XID] // 0x00000001898BF840-0x00000001898BF860
	private void OnCSLoopDungeonChallengeInfoNotify(ChannellerSlabLoopDungeonChallengeInfoNotify notify) {} // 0x00000001810A9800-0x00000001810A98B0
	// [XID] // 0x00000001898C7120-0x00000001898C7140
	public void RequestTakeCSLoopDungeonFirstPassReward(uint stageId) {} // 0x00000001810B5BB0-0x00000001810B5CB0
	// [XID] // 0x00000001898CE630-0x00000001898CE650
	private void OnTakeCSLoopDungeonFirstPassRewardRsp(ChannellerSlabLoopDungeonTakeFirstPassRewardRsp rsp) {} // 0x00000001810A4240-0x00000001810A43A0
	// [XID] // 0x00000001898D6090-0x00000001898D60B0
	public void RequestTakeCSLoopDungeonReward(uint rewardIndex) {} // 0x00000001810A2990-0x00000001810A2A90
	// [XID] // 0x00000001898DDCE0-0x00000001898DDD00
	private void OnTakeCSLoopDungeonRewardRsp(ChannellerSlabLoopDungeonTakeScoreRewardRsp rsp) {} // 0x00000001810B3EC0-0x00000001810B4020
	// [XID] // 0x00000001898E55C0-0x00000001898E55E0
	private void OnCSLoopDungeonSelectConditionRsp(ChannellerSlabLoopDungeonSelectConditionRsp rsp) {} // 0x00000001810A2C80-0x00000001810A2DE0
	// [XID] // 0x00000001898F46E0-0x00000001898F4700
	private void OnCSOneOffDungeonInfoNotify(ChannellerSlabOneOffDungeonInfoNotify ntf) {} // 0x00000001810B3D30-0x00000001810B3E10
	// [XID] // 0x00000001898FBF70-0x00000001898FBF90
	private void OnCSOneOffDungeonInfoRsp(ChannellerSlabOneOffDungeonInfoRsp rsp) {} // 0x00000001810AAE80-0x00000001810AB010
	// [XID] // 0x0000000189903A70-0x0000000189903A90
	private void OnChannellerSlabWearBuffRsp(ChannellerSlabWearBuffRsp rsp) {} // 0x00000001810B1550-0x00000001810B16B0
	// [XID] // 0x000000018990AED0-0x000000018990AEF0
	private void OnChannellerSlabTakeoffBuffRsp(ChannellerSlabTakeoffBuffRsp rsp) {} // 0x0000000181098C30-0x0000000181098D90
	// [XID] // 0x0000000189912B80-0x0000000189912BA0
	private void OnChannellerSlabCampIndexNotify(ChannelerSlabStageActiveChallengeIndexNotify notify) {} // 0x00000001810B18F0-0x00000001810B1FE0
	// [XID] // 0x000000018991A490-0x000000018991A4B0
	private void OnChannelerSlabOneoffDungeonNotify(ChannelerSlabStageOneoffDungeonNotify notify) {} // 0x000000018109A1B0-0x000000018109A460
	// [XID] // 0x0000000189921C60-0x0000000189921C80
	private void OnChannellerSlabSaveAssistInfoRsp(ChannellerSlabSaveAssistInfoRsp rsp) {} // 0x0000000181097620-0x0000000181097780
	// [XID] // 0x0000000189929380-0x00000001899293A0
	private void OnChannellerSlabCheckEnterLoopDungeonRsp(ChannellerSlabCheckEnterLoopDungeonRsp rsp) {} // 0x0000000181097B80-0x0000000181097CF0
	// [XID] // 0x0000000189930A40-0x0000000189930A60
	private void OnChannellerSlabShowTemplateReminder(uint tempId) {} // 0x00000001810A3C90-0x00000001810A3EF0
	// [XID] // 0x0000000189937E10-0x0000000189937E30
	private void ClearMiniTomoActivityData() {} // 0x00000001810A2B80-0x00000001810A2C80
	// [XID] // 0x000000018993F8A0-0x000000018993F8C0
	public uint GetPlayerMiniTomoDayIndex() => default; // 0x00000001810AFD00-0x00000001810AFDE0
	// [XID] // 0x0000000189946F80-0x0000000189946FA0
	public void CheckShowMiniTomoHiliWeiMark() {} // 0x00000001810A8F30-0x00000001810A8FF0
	// [XID] // 0x000000018994E600-0x000000018994E620
	private void RemoveMiniTomoHiliWeiMark() {} // 0x000000018109D5C0-0x000000018109D740
	// [XID] // 0x0000000189955C40-0x0000000189955C60
	private void AddMiniTomoHiliWeiMark() {} // 0x00000001810B77D0-0x00000001810B7BE0
	// [XID] // 0x000000018995D720-0x000000018995D740
	private void CheckInitMiniTomoAssignmentsDic() {} // 0x00000001810A5540-0x00000001810A59A0
	// [XID] // 0x0000000189964DB0-0x0000000189964DD0
	private int MiniTomoAssignmentIdSortFunc(uint x, uint y) => default; // 0x00000001810A2A90-0x00000001810A2B80
	// [XID] // 0x000000018996C310-0x000000018996C330
	public uint GetMiniTomoAssignmentId(uint dayIndex, int index) => default; // 0x00000001810A0340-0x00000001810A0480
	// [XID] // 0x0000000189973E10-0x0000000189973E30
	public int GetMiniTomoAssignmentsCount(uint dayIndex) => default; // 0x00000001810B5790-0x00000001810B58A0
	// [XID] // 0x000000018997B5D0-0x000000018997B5F0
	public bool IsMiniTomoAssignmentSubQuestFinish(uint dayIndex, int index) => default; // 0x0000000181097930-0x0000000181097A80
	// [XID] // 0x0000000189983010-0x0000000189983030
	public bool IsMiniTomoAssignmentFinish(uint dayIndex, int index) => default; // 0x00000001810B0F20-0x00000001810B1050
	// [XID] // 0x000000018998A7C0-0x000000018998A7E0
	private void CheckInitMiniTomoHiliWeiDic() {} // 0x000000018109E460-0x000000018109E6A0
	// [XID] // 0x0000000189992080-0x00000001899920A0
	private int MiniTomoHiliWeiIdSortFunc(uint x, uint y) => default; // 0x00000001810A4050-0x00000001810A4140
	// [XID] // 0x0000000189999DF0-0x0000000189999E10
	public uint GetMiniTomoHiliWeiId(int dayIndex) => default; // 0x00000001810B74C0-0x00000001810B75D0
	// [XID] // 0x00000001899A14F0-0x00000001899A1510
	public int GetMiniTomoHiliWeiCount() => default; // 0x000000018109D3E0-0x000000018109D4A0
	// [XID] // 0x00000001899A8F00-0x00000001899A8F20
	public bool IsMiniTomoHiliWeiFinish(int dayIndex) => default; // 0x00000001810A11E0-0x00000001810A1410
	// [XID] // 0x00000001899B08B0-0x00000001899B08D0
	public bool IsMiniTomoHiliWeiRewardTaken(int dayIndex) => default; // 0x00000001810B3A70-0x00000001810B3C90
	// [XID] // 0x00000001899B7C50-0x00000001899B7C70
	public bool IsMiniTomoHiliWeiRewardNeedTake(int dayIndex) => default; // 0x00000001810B07F0-0x00000001810B0A40
	// [XID] // 0x00000001899BF670-0x00000001899BF690
	public bool IsPlayerNeedFindMiniTomoHiliWei() => default; // 0x00000001810A4DD0-0x00000001810A5040
	// [XID] // 0x00000001899C7010-0x00000001899C7030
	private void OnFindHilichurlFinishSecondQuestNotify(FindHilichurlFinishSecondQuestNotify notify) {} // 0x00000001810AAB60-0x00000001810AAC70
	// [XID] // 0x00000001899CE4B0-0x00000001899CE4D0
	private void OnFindHilichurlAcceptQuestNotify(FindHilichurlAcceptQuestNotify notify) {} // 0x000000018109BA10-0x000000018109BAE0
	// [XID] // 0x00000001899D5C50-0x00000001899D5C70
	public void ShowMiniTomoRedPoint() {} // 0x000000018109B870-0x000000018109B970
	// [XID] // 0x00000001899DD020-0x00000001899DD040
	public void RemoveMiniTomoRedPoint() {} // 0x0000000181097A80-0x0000000181097B80
	// [XID] // 0x00000001899E4BE0-0x00000001899E4C00
	public void ShowActivityMiniTomoHintDialog(uint hiliWeiId) {} // 0x00000001810B6C10-0x00000001810B6D80
	// [XID] // 0x00000001899F3AF0-0x00000001899F3B10
	private void OnActivityMistTrialInfoNotify(ActivityInfo activityInfo) {} // 0x000000018109D280-0x000000018109D3E0
	// [XID] // 0x0000000189A025F0-0x0000000189A02610
	private void UpdateMistTrialLevel2WatcherInfoDic(bool isTakeRewardRsp = false /* Metadata: 0x00AFF7A1 */) {} // 0x00000001810AA060-0x00000001810AA6C0
	// [XID] // 0x0000000189A09D80-0x0000000189A09DA0
	public uint GetMistTrialCurrentTrialId() => default; // 0x000000018109E8C0-0x000000018109EB20
	// [XID] // 0x0000000189A115C0-0x0000000189A115E0
	public uint GetMistTrialCurrentLevelId() => default; // 0x00000001810AB1F0-0x00000001810AB450
	// [XID] // 0x0000000189A189D0-0x0000000189A189F0
	public bool CheckMistTrialLevelHasReward(uint levelId = 0 /* Metadata: 0x00AFF7A2 */) => default; // 0x00000001810A47F0-0x00000001810A4AC0
	// [XID] // 0x0000000189A20050-0x0000000189A20070
	private void OnMistTrialSelectAvatarAndEnterDungeonRsp(MistTrialSelectAvatarAndEnterDungeonRsp rsp) {} // 0x00000001810AF150-0x00000001810AF360
	// [XID] // 0x0000000189A273E0-0x0000000189A27400
	public void RequestMistTrialGetChallengeMission() {} // 0x00000001810B66B0-0x00000001810B67C0
	// [XID] // 0x0000000189A36510-0x0000000189A36530
	private void OnMistTrialGetChallengeMissionRsp(MistTrialGetChallengeMissionRsp rsp) {} // 0x00000001810A22A0-0x00000001810A24D0
	// [XID] // 0x0000000189A3DB30-0x0000000189A3DB50
	public bool CheckMistTrialHasNewLevel(uint levelId = 0 /* Metadata: 0x00AFF7A6 */) => default; // 0x00000001810ABEF0-0x00000001810AC200
	// [XID] // 0x0000000189A45270-0x0000000189A45290
	public bool GetMistTrialLevelOpenTime(uint levelId, out uint openTime, out bool isOpen) {
		openTime = default;
		isOpen = default;
		return default;
	} // 0x00000001810A0D00-0x00000001810A0E70
	// [XID] // 0x0000000189A4C980-0x0000000189A4C9A0
	public bool IsMistTrialDungeon(uint dungeonID = 0 /* Metadata: 0x00AFF7AA */) => default; // 0x00000001810B67C0-0x00000001810B6960
	// [XID] // 0x0000000189A541B0-0x0000000189A541D0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018109BFE0-0x000000018109C7A0
	// [XID] // 0x0000000189A5BBC0-0x0000000189A5BBE0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001810B5620-0x00000001810B56F0
}

