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

public sealed class NormalActivityModule : BaseModule // TypeDefIndex: 21638
{
	// Fields
	public bool showAllAsterMidMarkEffect; // 0x10
	public uint curTracingAsterMidMarkId; // 0x14
	private Dictionary<uint, uint> _AsterMidMarkDic; // 0x18
	private AsterMidCampInfoNotify _asterMidCampInfo; // 0x20
	private List<NormalActivityInfo> _openActivityList; // 0x28
	private List<uint> _finishedBonusActivityIdList; // 0x30
	private bool _showMainBtn; // 0x38
	private uint _newBeeActivityID; // 0x3C
	private uint _homeworldActivityId; // 0x40

	// Properties
	public Dictionary<uint, uint> AsterMidMarkDic { /* [XID] */ /* 0x0000000189828EA0-0x0000000189828EC0 */ get => default; } // 0x00000001840D8D40-0x00000001840D8DE0 
	public List<NormalActivityInfo> openActivityList { /* [XID] */ /* 0x0000000189853660-0x0000000189853680 */ get => default; } // 0x00000001840D4570-0x00000001840D4610 
	public List<uint> finishedBonusActivityIdList { /* [XID] */ /* 0x000000018985B150-0x000000018985B170 */ get => default; } // 0x00000001840D40F0-0x00000001840D4190 
	public bool showMainBtn { /* [XID] */ /* 0x0000000189862650-0x0000000189862670 */ get => default; } // 0x00000001840D1C90-0x00000001840D1D30 
	public uint newBeeActivityID { /* [XID] */ /* 0x0000000189869A40-0x0000000189869A60 */ get => default; } // 0x00000001840D6740-0x00000001840D67E0 
	public uint homeworldActivityId { /* [XID] */ /* 0x0000000189870D40-0x0000000189870D60 */ get => default; } // 0x00000001840D5090-0x00000001840D5130 

	// Constructors
	public NormalActivityModule() {} // 0x00000001840DDC70-0x00000001840DDD50

	// Methods
	// [XID] // 0x00000001897DDD90-0x00000001897DDDB0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001840D4190-0x00000001840D4270
	// [XID] // 0x00000001897E5820-0x00000001897E5840
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001840DCA10-0x00000001840DCBB0
	// [XID] // 0x00000001897ED2D0-0x00000001897ED2F0
	public uint GetAsterMiddleScore() => default; // 0x00000001840D49E0-0x00000001840D4B40
	// [XID] // 0x00000001897F4A50-0x00000001897F4A70
	public uint GetAsterCredit() => default; // 0x00000001840D7170-0x00000001840D7290
	// [XID] // 0x00000001897FC540-0x00000001897FC560
	public uint GetAsterToken() => default; // 0x00000001840D4610-0x00000001840D4730
	// [XID] // 0x0000000189803A50-0x0000000189803A70
	private bool CheckAsterRedPoint() => default; // 0x00000001840D3440-0x00000001840D35B0
	// [XID] // 0x000000018980AEF0-0x000000018980AF10
	public bool CheckAsterHasWatcherReward(AsterPhase asterPhase) => default; // 0x00000001840D91F0-0x00000001840D9700
	// [XID] // 0x0000000189812580-0x00000001898125A0
	public bool CheckAsterChapterOpen(AsterPhase asterPhase, bool isTask) => default; // 0x00000001840DB8A0-0x00000001840DBFC0
	// [XID] // 0x000000018981A1C0-0x000000018981A1E0
	public bool CheckAsterAvatarReward() => default; // 0x00000001840DAC30-0x00000001840DB100
	// [XID] // 0x0000000189821910-0x0000000189821930
	public void AddAsterLagreMark() {} // 0x00000001840D2970-0x00000001840D2DC0
	// [IDTag] // 0x0000000189830390-0x00000001898303D0
	// [XID] // 0x0000000189830390-0x00000001898303D0
	public void CheckAsterMidMark() {} // 0x00000001840D9B30-0x00000001840D9BE0
	// [IDTag] // 0x000000018983A960-0x000000018983A9A0
	// [XID] // 0x000000018983A960-0x000000018983A9A0
	public void CheckAsterMidMark(AsterMidCampInfoNotify notify) {} // 0x00000001840D9BE0-0x00000001840DA480
	// [XID] // 0x0000000189845170-0x0000000189845190
	public void RequestSelectAsterMidDifficulty(uint difficultyId, uint gadgetEntityId) {} // 0x00000001840D9700-0x00000001840D9890
	// [XID] // 0x000000018984C5E0-0x000000018984C600
	private void OnSelectAsterMidDifficultyRsp(SelectAsterMidDifficultyRsp rsp) {} // 0x00000001840DAAD0-0x00000001840DAC30
	// [XID] // 0x0000000189878770-0x0000000189878790
	public override void InitOnLevelInit() {} // 0x00000001840DA480-0x00000001840DA600
	// [XID] // 0x000000018987FD20-0x000000018987FD40
	public override bool OnPacket(Packet packet) => default; // 0x00000001840D3680-0x00000001840D37A0
	// [XID] // 0x0000000189887340-0x0000000189887360
	public override bool OnNotify(Notify ntf) => default; // 0x00000001840DD5D0-0x00000001840DDA60
	// [XID] // 0x000000018988E4A0-0x000000018988E4C0
	private void OnWatcherFinish(uint watcherId, uint activityId) {} // 0x00000001840D6060-0x00000001840D6180
	// [XID] // 0x0000000189895AC0-0x0000000189895AE0
	private void CheckActivity() {} // 0x00000001840DA730-0x00000001840DA860
	// [XID] // 0x000000018989D160-0x000000018989D180
	public void RemoveBonusActivity(uint bonusId) {} // 0x00000001840DB100-0x00000001840DB250
	// [XID] // 0x00000001898A4A80-0x00000001898A4AA0
	private void OnOpActivityStateNotify(OpActivityStateNotify ntf) {} // 0x00000001840D6390-0x00000001840D6740
	// [IDTag] // 0x00000001898ABF60-0x00000001898ABFA0
	// [XID] // 0x00000001898ABF60-0x00000001898ABFA0
	public void AddActivity(NewActivityType activityType, uint configID, bool hasReward = false /* Metadata: 0x00AFFAC9 */) {} // 0x00000001840D78C0-0x00000001840D7AB0
	// [IDTag] // 0x00000001898B66B0-0x00000001898B66F0
	// [XID] // 0x00000001898B66B0-0x00000001898B66F0
	public bool CheckNormalActivityHasReward(uint activityId) => default; // 0x00000001840D2020-0x00000001840D2210
	// [IDTag] // 0x00000001898C10A0-0x00000001898C10E0
	// [XID] // 0x00000001898C10A0-0x00000001898C10E0
	public bool CheckNormalActivityHasReward(NewActivityType activityType) => default; // 0x00000001840D2210-0x00000001840D2320
	// [IDTag] // 0x00000001898CB790-0x00000001898CB7D0
	// [XID] // 0x00000001898CB790-0x00000001898CB7D0
	public void DelActivity(NewActivityType activityType, uint configID) {} // 0x00000001840D3180-0x00000001840D3340
	// [XID] // 0x00000001898D6030-0x00000001898D6050
	public bool CheckSalesManHasReward(uint activityId) => default; // 0x00000001840D68B0-0x00000001840D6A30
	// [XID] // 0x00000001898DDC80-0x00000001898DDCA0
	public bool CheckTrialAvatarHasReward(uint activityId) => default; // 0x00000001840D1A70-0x00000001840D1C90
	// [IDTag] // 0x00000001898E5560-0x00000001898E55A0
	// [XID] // 0x00000001898E5560-0x00000001898E55A0
	private void AddActivity(uint activityID) {} // 0x00000001840D7AB0-0x00000001840D7EC0
	// [IDTag] // 0x00000001898EFF40-0x00000001898EFF80
	// [XID] // 0x00000001898EFF40-0x00000001898EFF80
	private void DelActivity(uint activityID) {} // 0x00000001840D3340-0x00000001840D3440
	// [XID] // 0x00000001898FA660-0x00000001898FA680
	public void UpdateActivityRewardState(NewActivityType activityType, uint activityID, bool hasReward) {} // 0x00000001840D8640-0x00000001840D87D0
	// [XID] // 0x0000000189902010-0x0000000189902030
	private void UpdateActivity(uint activityID) {} // 0x00000001840DCC50-0x00000001840DD020
	// [XID] // 0x0000000189909820-0x0000000189909840
	public void UpdateFoodeDelivery() {} // 0x00000001840D9A70-0x00000001840D9B30
	// [XID] // 0x0000000189910E30-0x0000000189910E50
	private void UpdateFoodDeiveryRewardState(NewActivityType activityType, bool hasReward) {} // 0x00000001840DB250-0x00000001840DB3D0
	// [XID] // 0x0000000189918970-0x0000000189918990
	public bool CheckFoodDeliveryHasReward() => default; // 0x00000001840D5970-0x00000001840D5B10
	// [XID] // 0x0000000189920110-0x0000000189920130
	private void RefreshState() {} // 0x00000001840D75B0-0x00000001840D77A0
	// [XID] // 0x00000001899279B0-0x00000001899279D0
	public override void ClearOnDisconnect() {} // 0x00000001840DCBB0-0x00000001840DCC50
	// [XID] // 0x000000018992F100-0x000000018992F120
	public override void ClearOnLevelDestroy() {} // 0x00000001840D3EC0-0x00000001840D3F60
	// [XID] // 0x0000000189936530-0x0000000189936550
	public override void ClearOnBackHome() {} // 0x00000001840D5EA0-0x00000001840D5F90
	// [XID] // 0x000000018993DF90-0x000000018993DFB0
	private void OnOpenStateChangeNotify(OpenStateType type, bool active) {} // 0x00000001840D5250-0x00000001840D53F0
	// [XID] // 0x00000001899456C0-0x00000001899456E0
	public void AddCrucibleMark() {} // 0x00000001840D37A0-0x00000001840D3B70
	// [XID] // 0x000000018994CB30-0x000000018994CB50
	public void RemoveActivityMark(NewActivityType activityType, uint activityID) {} // 0x00000001840D2DC0-0x00000001840D2FB0
	// [XID] // 0x0000000189954210-0x0000000189954230
	public void AddSalesmanMark() {} // 0x00000001840D4270-0x00000001840D4570
	// [XID] // 0x000000018995BB20-0x000000018995BB40
	public void AddExpeditionActivityMark() {} // 0x00000001840D1D30-0x00000001840D1E40
	// [XID] // 0x0000000189963720-0x0000000189963740
	public void AddTreasureHuntMark() {} // 0x00000001840D53F0-0x00000001840D5720
	// [XID] // 0x000000018996AB20-0x000000018996AB40
	public void AddBlessingMark() {} // 0x00000001840D7510-0x00000001840D75B0
	// [XID] // 0x0000000189972790-0x00000001899727B0
	public void CheckMiniTomoHiliWeiMark() {} // 0x00000001840D67E0-0x00000001840D68B0
	// [XID] // 0x0000000189979F50-0x0000000189979F70
	public bool OpenQuestFinished() => default; // 0x00000001840DDA60-0x00000001840DDC10
	// [XID] // 0x00000001899816E0-0x0000000189981700
	public bool IsNeverOpenActivity(uint activityID) => default; // 0x00000001840DB3D0-0x00000001840DB550
	// [XID] // 0x0000000189988F50-0x0000000189988F70
	public bool IsOpenActivity(uint activityID) => default; // 0x00000001840D8500-0x00000001840D8640
	// [XID] // 0x00000001899907B0-0x00000001899907D0
	public void SetOpenedActivity(uint activityID) {} // 0x00000001840D5B10-0x00000001840D5EA0
	// [XID] // 0x00000001899982D0-0x00000001899982F0
	public void RefreshActivityIsOpenedByDateTime(uint activityId) {} // 0x00000001840D7EC0-0x00000001840D8210
	// [XID] // 0x000000018999FA30-0x000000018999FA50
	private int CompareActivity(NormalActivityInfo xData, NormalActivityInfo yData) => default; // 0x00000001840D1E40-0x00000001840D2020
	// [XID] // 0x00000001899A7720-0x00000001899A7740
	public bool HasSalemanReward() => default; // 0x00000001840DA600-0x00000001840DA730
	// [XID] // 0x00000001899AEF30-0x00000001899AEF50
	public bool HasSalemanMatEnough() => default; // 0x00000001840D3B70-0x00000001840D3EC0
	// [XID] // 0x00000001899B6290-0x00000001899B62B0
	public bool CheckFlightRewardShow() => default; // 0x00000001840DA860-0x00000001840DAAD0
	// [XID] // 0x00000001899BDEF0-0x00000001899BDF10
	public bool CheckFlightRecordRedPoint(ActivityInfo activityInfo, FlightDailyRecord record) => default; // 0x00000001840D6E50-0x00000001840D7170
	// [XID] // 0x00000001899C5670-0x00000001899C5690
	private void AddDragonSpineBossMark() {} // 0x00000001840DD140-0x00000001840DD540
	// [XID] // 0x00000001899CCD80-0x00000001899CCDA0
	public uint GetDragonSpineShimmeringEssence() => default; // 0x00000001840D77A0-0x00000001840D78C0
	// [XID] // 0x00000001899D42C0-0x00000001899D42E0
	public uint GetDragonSpineWarmEssence() => default; // 0x00000001840DC200-0x00000001840DC320
	// [XID] // 0x00000001899DB970-0x00000001899DB990
	public uint GetDragonSpineWondrousEssence() => default; // 0x00000001840D5130-0x00000001840D5250
	// [XID] // 0x00000001899E31D0-0x00000001899E31F0
	public uint GetTreasureHuntCoin() => default; // 0x00000001840DD020-0x00000001840DD140
	// [XID] // 0x00000001899EA760-0x00000001899EA780
	public void TryAddTowerResetActivity() {} // 0x00000001840D7290-0x00000001840D7510
	// [XID] // 0x00000001899F2270-0x00000001899F2290
	private void OnReunionAddToOpActivityListNotify() {} // 0x00000001840D9070-0x00000001840D91F0
	// [XID] // 0x00000001899F9890-0x00000001899F98B0
	private void OnReunionRemoveFromOpActivityListNotify() {} // 0x00000001840D8FC0-0x00000001840D9070
	// [XID] // 0x0000000189A00C70-0x0000000189A00C90
	public bool CheckEffigyRP() => default; // 0x00000001840D35B0-0x00000001840D3680
	// [XID] // 0x0000000189A08550-0x0000000189A08570
	public bool CheckEffigyReward() => default; // 0x00000001840DC730-0x00000001840DCA10
	// [XID] // 0x0000000189A0FB50-0x0000000189A0FB70
	public bool CheckEffigyFirstReward() => default; // 0x00000001840D4C00-0x00000001840D4E90
	// [XID] // 0x0000000189A16FD0-0x0000000189A16FF0
	public bool CheckEffigyNewDaily() => default; // 0x00000001840D6200-0x00000001840D6390
	// [XID] // 0x0000000189A1E6C0-0x0000000189A1E6E0
	public int GetEffigyLastDailyIndex(EffigyActivityDetailInfo effigyInfo) => default; // 0x00000001840D8DE0-0x00000001840D8F60
	// [XID] // 0x0000000189A25DF0-0x0000000189A25E10
	public void AddWaterSpriteBossMark() {} // 0x00000001840D6A30-0x00000001840D6E50
	// [XID] // 0x0000000189A2D230-0x0000000189A2D250
	public bool CheckLanternRiteRedPoint() => default; // 0x00000001840DB550-0x00000001840DB640
	// [XID] // 0x0000000189A34C90-0x0000000189A34CB0
	public bool CheckLanternRiteMainQuest() => default; // 0x00000001840DBFC0-0x00000001840DC200
	// [XID] // 0x0000000189A3C000-0x0000000189A3C020
	public static bool CheckLanternRiteMiniQuestAccept(ActivityInfo activityInfo, SeaLampSectionExcelConfig sectionData) => default; // 0x00000001840D4730-0x00000001840D49E0
	// [XID] // 0x0000000189A43C90-0x0000000189A43CB0
	public bool CheckLanternRiteMiniQuest() => default; // 0x00000001840D8210-0x00000001840D8480
	// [XID] // 0x0000000189A4B100-0x0000000189A4B120
	public bool CheckLanternRiteChess() => default; // 0x00000001840D2320-0x00000001840D2970
	// [XID] // 0x0000000189A527E0-0x0000000189A52800
	public bool CheckMechanicusGearRedPoint() => default; // 0x00000001840D5720-0x00000001840D5970
	// [XID] // 0x0000000189A5A160-0x0000000189A5A180
	public bool CheckLanternRiteShop() => default; // 0x00000001840D9890-0x00000001840D9A70
	// [XID] // 0x0000000189A619D0-0x0000000189A619F0
	private bool CheckActivityContract(NewActivityType activityType, uint coinId, bool unlockTouch) => default; // 0x00000001840D4E90-0x00000001840D5090
	// [XID] // 0x0000000189A698F0-0x0000000189A69910
	public bool CheckLanternRiteContract() => default; // 0x00000001840D2FB0-0x00000001840D3100
	// [XID] // 0x0000000189A70BC0-0x0000000189A70BE0
	private void ClearFleurFairRedPointOnLogin() {} // 0x00000001840D4B40-0x00000001840D4C00
	// [XID] // 0x0000000189A78520-0x0000000189A78540
	public bool CheckFleurFairDungeonRP() => default; // 0x00000001840D5F90-0x00000001840D6060
	// [XID] // 0x0000000189A7FAB0-0x0000000189A7FAD0
	public bool CheckFleurFairDungeonReward() => default; // 0x00000001840D87D0-0x00000001840D8C60
	// [XID] // 0x0000000189A87800-0x0000000189A87820
	public bool CheckFleurFairDungeonNewGame() => default; // 0x00000001840DC320-0x00000001840DC730
	// [XID] // 0x0000000189A8EFB0-0x0000000189A8EFD0
	public bool CheckHideAndSeekScoreHasReward(uint activityId) => default; // 0x00000001840DB640-0x00000001840DB8A0
	// [XID] // 0x0000000189A96520-0x0000000189A96540
	public bool CheckHideAndSeekReward(uint activityId) => default; // 0x00000001840D8C60-0x00000001840D8D40
	// [XID] // 0x0000000189A9DA90-0x0000000189A9DAB0
	public bool CheckHideAndSeekSkillBtnClicked(uint activityId) => default; // 0x00000001840D3F60-0x00000001840D40F0
}

