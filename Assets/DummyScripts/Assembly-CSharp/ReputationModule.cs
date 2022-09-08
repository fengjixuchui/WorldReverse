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

public sealed class ReputationModule : BaseModule // TypeDefIndex: 21644
{
	// Fields
	private uint _cityId; // 0x10
	private CityReputationInfo _cityReputationInfo; // 0x18
	private List<uint> _rewardCityList; // 0x20
	private Dictionary<uint, uint> _cityReputationLevelDic; // 0x30
	private Action _releaseCallback; // 0x38
	private CityConfig _cityConfig; // 0x40
	private RepeatedMessageField<HuntingOfferData> _huntingOfferList; // 0x50
	private HuntingPair _ongoingHuntingPair; // 0x58
	private HuntingOngoingNotify _ongoingNotify; // 0x60
	public HuntingData huntingData; // 0x68
	private uint _huntingAreaMarkID; // 0x80
	private int _effectHandler; // 0x84

	// Properties
	public List<uint> rewardCityList { /* [XID] */ /* 0x00000001896C00B0-0x00000001896C00D0 */ get => default; } // 0x0000000182DA3DE0-0x0000000182DA3E80 
	public bool hasNewQuest { /* [XID] */ /* 0x00000001896C7930-0x00000001896C7950 */ get => default; } // 0x0000000182DA9690-0x0000000182DA97C0 
	public bool hasNewRequest { /* [XID] */ /* 0x00000001896CF100-0x00000001896CF140 */ get; /* [XID] */ /* 0x00000001896D9470-0x00000001896D94B0 */ private set; } // 0x0000000182DA8BE0-0x0000000182DA8C40 0x0000000182DA1C50-0x0000000182DA1CB0
	public bool hasNewHunting { /* [XID] */ /* 0x00000001896E39F0-0x00000001896E3A30 */ get; /* [XID] */ /* 0x00000001896EDD90-0x00000001896EDDD0 */ private set; } // 0x0000000182DA8280-0x0000000182DA82E0 0x0000000182DA3C90-0x0000000182DA3CF0
	public int requestDialogIndex { /* [XID] */ /* 0x00000001897B3840-0x00000001897B3880 */ get; /* [XID] */ /* 0x00000001897BEBF0-0x00000001897BEC30 */ set; } // 0x0000000182DA29D0-0x0000000182DA2A30 0x0000000182DA2EB0-0x0000000182DA2F10
	public bool IsHuntingOpen { /* [XID] */ /* 0x00000001898814A0-0x00000001898814C0 */ get => default; } // 0x0000000182DA4F90-0x0000000182DA5060 
	public bool IsQuestOpen { /* [XID] */ /* 0x0000000189888A20-0x0000000189888A40 */ get => default; } // 0x0000000182DA7810-0x0000000182DA78E0 
	public bool IsRequestOpen { /* [XID] */ /* 0x000000018988FDA0-0x000000018988FDC0 */ get => default; } // 0x0000000182DA1A30-0x0000000182DA1B00 
	public bool IsExploreOpen { /* [XID] */ /* 0x0000000189897340-0x0000000189897360 */ get => default; } // 0x0000000182DA1960-0x0000000182DA1A30 
	public bool isHuntingAccepted { /* [XID] */ /* 0x0000000189952ED0-0x0000000189952F10 */ get; /* [XID] */ /* 0x000000018995D680-0x000000018995D6C0 */ private set; } // 0x0000000182DA4C50-0x0000000182DA4CB0 0x0000000182DA94B0-0x0000000182DA9510
	public bool isHuntingStarted { /* [XID] */ /* 0x0000000189967DA0-0x0000000189967DE0 */ get; /* [XID] */ /* 0x0000000189972750-0x0000000189972790 */ private set; } // 0x0000000182DA3370-0x0000000182DA33D0 0x0000000182DA7A40-0x0000000182DA7AA0

	// Nested types
	public struct HuntingData // TypeDefIndex: 21645
	{
		// Fields
		public uint refreshId; // 0x00
		public uint monsterConfigId; // 0x04
		public uint failTime; // 0x08
		public uint finishClueCount; // 0x0C
		public uint totalClueCount; // 0x10
	}

	// Constructors
	public ReputationModule() {} // 0x0000000182DAA4F0-0x0000000182DAA600

	// Methods
	// [XID] // 0x00000001896B1330-0x00000001896B1350
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000182DA2B90-0x0000000182DA2DC0
	// [XID] // 0x00000001896B8DF0-0x00000001896B8E10
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000182DA9510-0x0000000182DA95F0
	// [XID] // 0x00000001896F8380-0x00000001896F83A0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182DA9B60-0x0000000182DA9C70
	// [XID] // 0x00000001896FFD00-0x00000001896FFD20
	public override bool OnPacket(Packet packet) => default; // 0x0000000182DA2570-0x0000000182DA29D0
	// [XID] // 0x0000000189707400-0x0000000189707420
	public override void ClearOnBackHome() {} // 0x0000000182DA4E20-0x0000000182DA4F90
	// [XID] // 0x000000018970ECA0-0x000000018970ECC0
	public override void ClearOnLevelDestroy() {} // 0x0000000182DA2AF0-0x0000000182DA2B90
	// [XID] // 0x00000001897160A0-0x00000001897160C0
	public override void ClearOnDisconnect() {} // 0x0000000182DA95F0-0x0000000182DA9690
	// [XID] // 0x000000018971DAE0-0x000000018971DB00
	public void RequestGetCityReputationInfo(uint cityId) {} // 0x0000000182DA5740-0x0000000182DA5880
	// [XID] // 0x0000000189724F40-0x0000000189724F60
	public void OnGetCityReputationInfoRsp(GetCityReputationInfoRsp rsp) {} // 0x0000000182DA2FF0-0x0000000182DA3370
	// [XID] // 0x000000018972C6C0-0x000000018972C6E0
	public void RequestTakeCityReputationLevelReward(uint cityId, uint level) {} // 0x0000000182DA78E0-0x0000000182DA7A40
	// [XID] // 0x0000000189733E10-0x0000000189733E30
	private void OnTakeCityReputationLevelRewardRsp(TakeCityReputationLevelRewardRsp rsp) {} // 0x0000000182DA69F0-0x0000000182DA6B70
	// [XID] // 0x000000018973B570-0x000000018973B590
	private void OnCityReputationLevelupNotify(CityReputationLevelupNotify ntf) {} // 0x0000000182DA46F0-0x0000000182DA48B0
	// [XID] // 0x0000000189742FC0-0x0000000189742FE0
	public void RequestGetCityReputationSimpleInfo() {} // 0x0000000182DA60F0-0x0000000182DA6340
	// [XID] // 0x000000018974AB80-0x000000018974ABA0
	private void OnGetCityReputationMapInfoRsp(GetCityReputationMapInfoRsp rsp) {} // 0x0000000182DA8C40-0x0000000182DA9030
	// [XID] // 0x0000000189751BF0-0x0000000189751C10
	private void OnCityReputationDataNotify(CityReputationDataNotify ntf) {} // 0x0000000182DA6BF0-0x0000000182DA6E90
	// [XID] // 0x0000000189759320-0x0000000189759340
	public void RequestTakeCityReputationParentQuest(uint cityId, List<uint> parentQuestList) {} // 0x0000000182DA4300-0x0000000182DA44B0
	// [XID] // 0x0000000189760E70-0x0000000189760E90
	private void OnTakeCityReputationParentQuestRsp(TakeCityReputationParentQuestRsp rsp) {} // 0x0000000182DA5B10-0x0000000182DA5C80
	// [XID] // 0x0000000189768240-0x0000000189768260
	public void RequestAcceptCityReputationRequest(uint requestId) {} // 0x0000000182DA8520-0x0000000182DA86A0
	// [XID] // 0x000000018976F810-0x000000018976F830
	private void OnAcceptCityReputationRequestRsp(AcceptCityReputationRequestRsp rsp) {} // 0x0000000182DAA030-0x0000000182DAA250
	// [XID] // 0x0000000189777170-0x0000000189777190
	public void RequestCancelCityReputationRequest(uint requestId) {} // 0x0000000182DA72A0-0x0000000182DA7410
	// [XID] // 0x000000018977E8A0-0x000000018977E8C0
	private void OnCancelCityReputationRequestRsp(CancelCityReputationRequestRsp rsp) {} // 0x0000000182DA1380-0x0000000182DA1580
	// [XID] // 0x0000000189786060-0x0000000189786080
	public void RequestTakeCityReputationExploreReward(uint cityId, List<uint> exploreIdList) {} // 0x0000000182DA5960-0x0000000182DA5B10
	// [XID] // 0x000000018978D710-0x000000018978D730
	public void OnTakeCityReputationExploreRewardRsp(TakeCityReputationExploreRewardRsp rsp) {} // 0x0000000182DAA380-0x0000000182DAA4F0
	// [XID] // 0x0000000189794B60-0x0000000189794B80
	private void ShowItemList(RepeatedMessageField<ItemParam> itemParams) {} // 0x0000000182DA6FC0-0x0000000182DA72A0
	// [XID] // 0x000000018979D0D0-0x000000018979D0F0
	public void TryToOpenReputationPage(Action releaseCallback = null) {} // 0x0000000182DA5630-0x0000000182DA5740
	// [XID] // 0x00000001897A43D0-0x00000001897A43F0
	public CityReputationInfo GetCityReputationInfo(uint cityId) => default; // 0x0000000182DA8460-0x0000000182DA8520
	// [XID] // 0x00000001897AB940-0x00000001897AB960
	public CityReputationInfo GetCurCityReputationInfo() => default; // 0x0000000182DA4BA0-0x0000000182DA4C50
	// [XID] // 0x00000001897C9160-0x00000001897C9180
	public uint GetRequestIdFromIndex(int index) => default; // 0x0000000182DA6E90-0x0000000182DA6FC0
	// [XID] // 0x00000001897D0750-0x00000001897D0770
	public int GetRequestCount() => default; // 0x0000000182DA2DC0-0x0000000182DA2EB0
	// [XID] // 0x00000001897D8480-0x00000001897D84A0
	public uint GetReputationLevel(uint cityId) => default; // 0x0000000182DA8930-0x0000000182DA8A00
	// [XID] // 0x00000001897DF530-0x00000001897DF550
	public uint GetCurrentExp(uint cityId) => default; // 0x0000000182DA3FD0-0x0000000182DA40A0
	// [XID] // 0x00000001897E6D90-0x00000001897E6DB0
	public ReputationLevelExcelConfig GetCurrLevelConfig(uint cityId) => default; // 0x0000000182DA44B0-0x0000000182DA4580
	// [XID] // 0x00000001897EEA60-0x00000001897EEA80
	public bool IsCityMaxLevel(uint cityId) => default; // 0x0000000182DA4D50-0x0000000182DA4E20
	// [XID] // 0x00000001897F61E0-0x00000001897F6200
	public uint GetNeedExp(uint cityId) => default; // 0x0000000182DA2F10-0x0000000182DA2FF0
	// [XID] // 0x00000001897FD820-0x00000001897FD840
	public void GetResidentProgress(out uint current, out uint max) {
		current = default;
		max = default;
	} // 0x0000000182DA8160-0x0000000182DA8280
	// [XID] // 0x0000000189805030-0x0000000189805050
	public void GetExploreProgress(out uint current) {
		current = default;
	} // 0x0000000182DA5880-0x0000000182DA5960
	// [XID] // 0x000000018980C550-0x000000018980C570
	public void GetHuntingProgress(out uint current, out uint max) {
		current = default;
		max = default;
	} // 0x0000000182DA9120-0x0000000182DA92A0
	// [XID] // 0x0000000189813CE0-0x0000000189813D00
	public void GetQuestProgress(out uint current, out uint max) {
		current = default;
		max = default;
	} // 0x0000000182DA40A0-0x0000000182DA4300
	// [XID] // 0x000000018981B860-0x000000018981B880
	public RewardState GetLevelRewardState(uint cityId, uint level) => default; // 0x0000000182DAA250-0x0000000182DAA380
	// [XID] // 0x0000000189822DF0-0x0000000189822E10
	public RewardState GetQuestRewardState(uint cityId, uint parentQuestId) => default; // 0x0000000182DA7FD0-0x0000000182DA8160
	// [XID] // 0x000000018982A770-0x000000018982A790
	public RewardState GetExploreRewardState(uint cityId, uint exploreId, uint needProgress) => default; // 0x0000000182DA1660-0x0000000182DA17E0
	// [XID] // 0x0000000189831B20-0x0000000189831B40
	public RewardState GetRequestRewardState(uint requestId) => default; // 0x0000000182DA33D0-0x0000000182DA3620
	// [XID] // 0x00000001898391A0-0x00000001898391C0
	public static MarkIconType CityId2MarkIconType(uint cityId) => default; // 0x0000000182DA2A30-0x0000000182DA2AF0
	// [XID] // 0x0000000189840810-0x0000000189840830
	private static uint MarkIconType2CityId(MarkIconType iconType) => default; // 0x0000000182DA2060-0x0000000182DA2120
	// [IDTag] // 0x0000000189847D20-0x0000000189847D60
	// [XID] // 0x0000000189847D20-0x0000000189847D60
	public bool HasLevelReward(MarkIconType iconType) => default; // 0x0000000182DA9980-0x0000000182DA9A50
	// [XID] // 0x0000000189852090-0x00000001898520B0
	public string LevelRewardText(MarkIconType iconType) => default; // 0x0000000182DA36E0-0x0000000182DA3800
	// [IDTag] // 0x0000000189859AD0-0x0000000189859B10
	// [XID] // 0x0000000189859AD0-0x0000000189859B10
	public bool HasLevelReward(uint cityId) => default; // 0x0000000182DA9A50-0x0000000182DA9B60
	// [XID] // 0x0000000189863FF0-0x0000000189864010
	public bool HasHuntingReward() => default; // 0x0000000182DA1EE0-0x0000000182DA1FE0
	// [XID] // 0x000000018986B3C0-0x000000018986B3E0
	public bool HasRequestReward() => default; // 0x0000000182DA4CB0-0x0000000182DA4D50
	// [XID] // 0x00000001898726F0-0x0000000189872710
	public bool HasQuestReward() => default; // 0x0000000182DA11F0-0x0000000182DA1380
	// [XID] // 0x000000018987A310-0x000000018987A330
	public bool HasExploreReward() => default; // 0x0000000182DA6340-0x0000000182DA65D0
	// [XID] // 0x000000018989E820-0x000000018989E840
	public void TryToOpenQuestPage(uint questId) {} // 0x0000000182DA3AE0-0x0000000182DA3C90
	// [XID] // 0x0000000189B26050-0x0000000189B26070
	public uint GetCityReputationLevel(uint cityId) => default; // 0x0000000182DA1580-0x0000000182DA1660
	// [XID] // 0x0000000189B3C090-0x0000000189B3C0B0
	public bool IsCityReputationOpen(uint cityId) => default; // 0x0000000182DA3800-0x0000000182DA3920
	// [XID] // 0x00000001898B4E60-0x00000001898B4E80
	public bool CheckInNextRefreshTime() => default; // 0x0000000182DA4580-0x0000000182DA46F0
	// [XID] // 0x00000001898BC990-0x00000001898BC9B0
	private bool CheckCanTakeHunting() => default; // 0x0000000182DA97C0-0x0000000182DA98F0
	// [XID] // 0x00000001898C4090-0x00000001898C40B0
	private bool CheckCanTakeRequest() => default; // 0x0000000182DA9C70-0x0000000182DA9DA0
	// [XID] // 0x00000001898CB770-0x00000001898CB790
	public RepeatedMessageField<HuntingOfferData> GetHuntingData(uint cityId) => default; // 0x0000000182DA5C80-0x0000000182DA5D40
	// [XID] // 0x00000001898D2ED0-0x00000001898D2EF0
	public RewardState GetHuntingRewardState(HuntingOfferData huntingData) => default; // 0x0000000182DA9030-0x0000000182DA9120
	// [XID] // 0x00000001898DA820-0x00000001898DA840
	public void RequestGetCityHuntingOffer(uint cityId) {} // 0x0000000182DA54F0-0x0000000182DA5630
	// [XID] // 0x00000001898E2620-0x00000001898E2640
	private void OnGetCityHuntingOfferRsp(GetCityHuntingOfferRsp rsp) {} // 0x0000000182DA48B0-0x0000000182DA4BA0
	// [XID] // 0x00000001898EA130-0x00000001898EA150
	public void RequestTakeHuntingOffer(uint cityId, uint refreshId, uint monsterConfigId) {} // 0x0000000182DA7470-0x0000000182DA7810
	// [XID] // 0x00000001898F1950-0x00000001898F1970
	private void OnTakeHuntingOfferRsp(TakeHuntingOfferRsp rsp) {} // 0x0000000182DA65D0-0x0000000182DA69F0
	// [XID] // 0x00000001898F9090-0x00000001898F90B0
	public void RequestGetHuntingOfferReward(uint cityId, uint refreshId, uint monsterConfigId) {} // 0x0000000182DA8A00-0x0000000182DA8BE0
	// [XID] // 0x0000000189900970-0x0000000189900990
	private void OnGetHuntingOfferRewardRsp(GetHuntingOfferRewardRsp rsp) {} // 0x0000000182DA2380-0x0000000182DA2570
	// [XID] // 0x00000001899081B0-0x00000001899081D0
	public void RequestHuntingGiveUp(uint refreshId, uint monsterConfigId) {} // 0x0000000182DA1CB0-0x0000000182DA1EE0
	// [XID] // 0x000000018990F910-0x000000018990F930
	private void OnHuntingGiveUpRsp(HuntingGiveUpRsp rsp) {} // 0x0000000182DA50E0-0x0000000182DA53B0
	// [XID] // 0x0000000189917400-0x0000000189917420
	private void OnHuntingStartNotify(HuntingStartNotify ntf) {} // 0x0000000182DA86A0-0x0000000182DA8930
	// [XID] // 0x000000018991EA60-0x000000018991EA80
	private void OnHuntingRevealClueNotify(HuntingRevealClueNotify ntf) {} // 0x0000000182DA7AA0-0x0000000182DA7D00
	// [XID] // 0x0000000189926320-0x0000000189926340
	private void OnHuntingRevealFinalNotify(HuntingRevealFinalNotify ntf) {} // 0x0000000182DA2120-0x0000000182DA2380
	// [XID] // 0x000000018992DA30-0x000000018992DA50
	private void OnHuntingSuccessNotify(HuntingSuccessNotify ntf) {} // 0x0000000182DA3E80-0x0000000182DA3FD0
	// [XID] // 0x0000000189934EF0-0x0000000189934F10
	private void OnHuntingFailNotify(HuntingFailNotify ntf) {} // 0x0000000182DA1B00-0x0000000182DA1C50
	// [XID] // 0x000000018993CA30-0x000000018993CA50
	private void OnHuntingOngoingNotify(HuntingOngoingNotify ntf) {} // 0x0000000182DA3620-0x0000000182DA36E0
	// [XID] // 0x0000000189944000-0x0000000189944020
	public void DoHuntingOngoingNotify() {} // 0x0000000182DA7D00-0x0000000182DA7FD0
	// [XID] // 0x000000018994B610-0x000000018994B630
	private void ClearHunting() {} // 0x0000000182DA82E0-0x0000000182DA8460
	// [XID] // 0x000000018997C690-0x000000018997C6B0
	private void TryAddHuntingAreaMark() {} // 0x0000000182DA3CF0-0x0000000182DA3DE0
	// [XID] // 0x00000001899843D0-0x00000001899843F0
	public void AddHuntingAreaMark(uint refreshId) {} // 0x0000000182DA5D40-0x0000000182DA60F0
	// [XID] // 0x000000018998BEB0-0x000000018998BED0
	public void RemoveHuntingAreaMark() {} // 0x0000000182DA17E0-0x0000000182DA1960
	// [XID] // 0x0000000189993B30-0x0000000189993B50
	private void CreateHuntingClueGadget(Vector position) {} // 0x0000000182DA9DA0-0x0000000182DAA030
	// [XID] // 0x000000018999B400-0x000000018999B420
	private void RemoveHuntingClueGadget() {} // 0x0000000182DA53B0-0x0000000182DA54F0
	// [XID] // 0x00000001899A2BB0-0x00000001899A2BD0
	private void ShowHuntingClueReminder(uint monsterConfigId) {} // 0x0000000182DA92A0-0x0000000182DA94B0
	// [XID] // 0x00000001899AA5C0-0x00000001899AA5E0
	private uint GetRandomReminderId(uint monsterConfigId) => default; // 0x0000000182DA3920-0x0000000182DA3AE0
}

