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

public sealed class ShopModule : BaseModule // TypeDefIndex: 21614
{
	// Fields
	private Dictionary<uint, ShopData> _shopDataDic; // 0x10
	private ShopType _curMallShopType; // 0x18
	private uint _initMallSubTabId; // 0x1C
	private List<uint> _curShopTypeList; // 0x20
	private PayData _curPayData; // 0x28
	private InLevelGachaGroupContext _curGachaGroup; // 0x48
	private bool _showMonthlyCard; // 0x50
	private ResinCardDataUpdateNotify _cardData; // 0x60

	// Properties
	public bool showMonthlyCard { /* [XID] */ /* 0x00000001898F6040-0x00000001898F6060 */ get => default; /* [XID] */ /* 0x00000001898FD960-0x00000001898FD980 */ set {} } // 0x0000000181505990-0x0000000181505A30 0x0000000181502DA0-0x0000000181502E50
	public uint monthlyCardRemainDays { /* [XID] */ /* 0x0000000189905160-0x00000001899051A0 */ get; /* [XID] */ /* 0x000000018990F950-0x000000018990F990 */ private set; } // 0x0000000181505C30-0x0000000181505C90 0x000000018150A7F0-0x000000018150A850
	public uint monthlyCardHcoinCount { /* [XID] */ /* 0x000000018991A3D0-0x000000018991A410 */ get; /* [XID] */ /* 0x0000000189924B00-0x0000000189924B40 */ private set; } // 0x0000000181508E10-0x0000000181508E70 0x0000000181509490-0x00000001815094F0

	// Nested types
	private struct PayData // TypeDefIndex: 21615
	{
		// Fields
		public string productID; // 0x00
		public string productName; // 0x08
		public string priceTier; // 0x10
		public ShopType shopType; // 0x18
		public bool isCard; // 0x1C
	}

	// Constructors
	public ShopModule() {} // 0x000000018150A960-0x000000018150AA40

	// Methods
	// [XID] // 0x000000018979FEF0-0x000000018979FF10
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000181502BB0-0x0000000181502DA0
	// [XID] // 0x00000001897A7400-0x00000001897A7420
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x0000000181509940-0x0000000181509A10
	// [IDTag] // 0x00000001897AEEB0-0x00000001897AEEF0
	// [XID] // 0x00000001897AEEB0-0x00000001897AEEF0
	public ShopData GetShopData(uint shopID) => default; // 0x0000000181508420-0x0000000181508540
	// [XID] // 0x00000001897B96B0-0x00000001897B96D0
	public ShopItem GetShopItem(uint goodsId) => default; // 0x0000000181508BF0-0x0000000181508E10
	// [IDTag] // 0x00000001897C16E0-0x00000001897C1720
	// [XID] // 0x00000001897C16E0-0x00000001897C1720
	public ShopData GetShopData(ShopType shopType) => default; // 0x0000000181508540-0x0000000181508600
	// [XID] // 0x00000001897CBCF0-0x00000001897CBD10
	public override bool OnPacket(Packet packet) => default; // 0x0000000181502500-0x00000001815028F0
	// [XID] // 0x00000001897D3720-0x00000001897D3740
	public override bool OnNotify(Notify ntf) => default; // 0x000000018150A1C0-0x000000018150A2D0
	// [XID] // 0x00000001897DB1B0-0x00000001897DB1D0
	public void PayBP(uint scheduleID, string productID, string productName, string priceTier) {} // 0x0000000181509DA0-0x0000000181509F40
	// [XID] // 0x00000001897E2820-0x00000001897E2840
	public void Pay(ShopItem shopItem, ShopType shopType) {} // 0x0000000181507C30-0x0000000181507DD0
	// [XID] // 0x00000001897E9F60-0x00000001897E9F80
	private void OnRechargeRsp(RechargeRsp rsp) {} // 0x0000000181503E70-0x00000001815041C0
	// [XID] // 0x00000001897F1C50-0x00000001897F1C70
	private void SDKPay() {} // 0x0000000181506FB0-0x00000001815070E0
	// [XID] // 0x00000001897F9450-0x00000001897F9470
	public void RequestShopData(ShopType shopType) {} // 0x00000001815094F0-0x00000001815095F0
	// [XID] // 0x0000000189800A50-0x0000000189800A70
	public void RequestActivityShopSheetInfo(ShopType shopType) {} // 0x0000000181509840-0x0000000181509940
	// [XID] // 0x0000000189807FE0-0x0000000189808000
	private string GetBuyCostString(ShopItem selectItem, uint num) => default; // 0x0000000181502200-0x0000000181502500
	// [XID] // 0x000000018980F9B0-0x000000018980F9D0
	public bool BuyShopItem(ShopItem shopItem, ShopType shopType, uint curNum) => default; // 0x0000000181503960-0x0000000181503CA0
	// [XID] // 0x0000000189816FE0-0x0000000189817000
	public bool BuyGoods(ShopType shopType, uint goodsID, uint buyCount, Func<bool> succHandle = null, bool doubleCheck = false /* Metadata: 0x00AFFA74 */) => default; // 0x0000000181505570-0x0000000181505990
	// [XID] // 0x000000018981E850-0x000000018981E870
	private bool RequestBuyGoods(ShopType shopType, ShopItem shopGoods, uint buyCount) => default; // 0x0000000181506850-0x0000000181506C80
	// [XID] // 0x0000000189825D60-0x0000000189825D80
	public override void ClearOnLevelDestroy() {} // 0x00000001815029A0-0x0000000181502A50
	// [XID] // 0x000000018982D4A0-0x000000018982D4C0
	public override void ClearOnDisconnect() {} // 0x0000000181509A10-0x0000000181509AC0
	// [XID] // 0x0000000189834BF0-0x0000000189834C10
	public override void ClearOnBackHome() {} // 0x0000000181505290-0x0000000181505330
	// [XID] // 0x000000018983C2D0-0x000000018983C2F0
	public void OnBuyShopItem(ShopItem itemData, ShopType shopType, List<ShopMaterial> shopMaterialsList) {} // 0x0000000181505A30-0x0000000181505C30
	// [XID] // 0x0000000189843880-0x00000001898438A0
	public void LackOfCostItem(ShopItem itemData, ShopType shopType, uint buyCount) {} // 0x0000000181504F40-0x0000000181505290
	// [XID] // 0x000000018984ADD0-0x000000018984ADF0
	public void LackHcoin(uint lackCount, Action lackHcoinCallback = null, Action lackMcoinCallback = null) {} // 0x0000000181504410-0x0000000181504760
	// [XID] // 0x00000001898520B0-0x00000001898520D0
	public void LackMcoin(Action lackMcoinCallback = null) {} // 0x0000000181503480-0x0000000181503740
	// [XID] // 0x0000000189859B10-0x0000000189859B30
	public void BuyItem(ShopItem shopItem, ShopType shopType, List<ShopMaterial> shopMaterialsList) {} // 0x00000001815081E0-0x0000000181508420
	// [XID] // 0x0000000189860BD0-0x0000000189860BF0
	public void BuyPackage(ShopItem shopItem, ShopType shopType, List<ShopMaterial> shopMaterialsList) {} // 0x0000000181509330-0x0000000181509490
	// [XID] // 0x0000000189868360-0x0000000189868380
	private uint CalCulateMaxCanBuyNum(ShopItem shopItem) => default; // 0x0000000181505330-0x0000000181505570
	// [XID] // 0x000000018986F7E0-0x000000018986F800
	public void HideGacha() {} // 0x0000000181509170-0x0000000181509330
	// [XID] // 0x0000000189876DB0-0x0000000189876DD0
	public bool IsInGachaGroup() => default; // 0x00000001815033C0-0x0000000181503480
	// [XID] // 0x000000018987E8A0-0x000000018987E8C0
	public GachaDataInfo GetCurrentGachaInfo() => default; // 0x0000000181501E90-0x0000000181501F40
	// [XID] // 0x0000000189885D20-0x0000000189885D40
	public void ShowGachaPage(uint tryToShowScheduleID = 0 /* Metadata: 0x00AFFA75 */, float fadeInDuration = 0.5f /* Metadata: 0x00AFFA79 */) {} // 0x00000001815070E0-0x0000000181507270
	// [XID] // 0x000000018988D040-0x000000018988D060
	public void OnItemClick(ItemConfig itemConfig, uint itemCount, bool hideStory = false /* Metadata: 0x00AFFA7D */) {} // 0x0000000181505D10-0x0000000181506260
	// [XID] // 0x00000001898946B0-0x00000001898946D0
	private void OnGetGachaInfoRsp(GetGachaInfoRsp rsp) {} // 0x0000000181503740-0x0000000181503960
	// [XID] // 0x000000018989BCA0-0x000000018989BCC0
	private void OnDoGachaRsp(DoGachaRsp rsp) {} // 0x0000000181502E50-0x0000000181503180
	// [XID] // 0x00000001898A31C0-0x00000001898A31E0
	private void OnConfirmItemExceedLimitDialog(bool confirm) {} // 0x0000000181503DB0-0x0000000181503E70
	// [XID] // 0x00000001898AA5E0-0x00000001898AA600
	private void OnBuyGoodsRsp(BuyGoodsRsp rsp) {} // 0x0000000181507520-0x0000000181507C30
	// [XID] // 0x00000001898B2090-0x00000001898B20B0
	private void OnGetShopRsp(GetShopRsp rsp) {} // 0x00000001815095F0-0x0000000181509840
	// [XID] // 0x00000001898B9D80-0x00000001898B9DA0
	private void OnGetActivityShopSheetInfoRsp(GetActivityShopSheetInfoRsp rsp) {} // 0x0000000181509FD0-0x000000018150A1C0
	// [XID] // 0x00000001898C10E0-0x00000001898C1100
	private void OnGetShopmallDataRsp(GetShopmallDataRsp rsp) {} // 0x0000000181507DD0-0x00000001815081E0
	// [XID] // 0x00000001898C8A00-0x00000001898C8A20
	private void CheckNameCardShopItem(ShopItem shopItem) {} // 0x0000000181501FC0-0x0000000181502200
	// [XID] // 0x00000001898D03C0-0x00000001898D03E0
	private void CheckFurnitureItem(ShopItem shopItem) {} // 0x0000000181504B30-0x0000000181504D40
	// [XID] // 0x0000000189970120-0x0000000189970140
	public void TryToOpenMall(ShopType type = ShopType.SHOP_TYPE_NONE /* Metadata: 0x00AFFA7E */, uint subTabId = 0 /* Metadata: 0x00AFFA82 */) {} // 0x000000018150A850-0x000000018150A960
	// [XID] // 0x00000001898DF690-0x00000001898DF6B0
	public void TryOpenShopExchangeDialog() {} // 0x0000000181501D90-0x0000000181501E90
	// [XID] // 0x00000001898E70F0-0x00000001898E7110
	public void RequestMcoinExchangeHcoin(uint count) {} // 0x0000000181503CA0-0x0000000181503DB0
	// [XID] // 0x00000001898EE8C0-0x00000001898EE8E0
	private void OnMcoinExchangeHcoinRsp(McoinExchangeHcoinRsp rsp) {} // 0x0000000181502A50-0x0000000181502BB0
	// [XID] // 0x000000018992F120-0x000000018992F140
	public uint GetResinCardRemainDays(uint configId) => default; // 0x0000000181506C80-0x0000000181506E90
	// [XID] // 0x0000000189936550-0x0000000189936570
	public bool CanTakeResinCard(uint configId) => default; // 0x0000000181508ED0-0x0000000181509170
	// [XID] // 0x000000018993DFB0-0x000000018993DFD0
	private void ClearCardData() {} // 0x00000001815028F0-0x00000001815029A0
	// [XID] // 0x00000001899456E0-0x0000000189945700
	private void OnCardProductRewardNotify(CardProductRewardNotify notify) {} // 0x0000000181509AC0-0x0000000181509CC0
	// [XID] // 0x000000018994CB50-0x000000018994CB70
	private void OnPlayerRechargeDataNotify(PlayerRechargeDataNotify notify) {} // 0x0000000181504760-0x0000000181504B30
	// [XID] // 0x0000000189954230-0x0000000189954250
	private void OnTakeResinCardDailyRewardRsp(TakeResinCardDailyRewardRsp rsp) {} // 0x000000018150A410-0x000000018150A7F0
	// [XID] // 0x000000018995BB40-0x000000018995BB60
	private void OnResinCardDataUpdateNotify(ResinCardDataUpdateNotify ntf) {} // 0x00000001815041C0-0x0000000181504410
	// [XID] // 0x0000000189963740-0x0000000189963760
	public void RequestTakeResinCardReward(uint configId) {} // 0x0000000181504E00-0x0000000181504F40
	// [XID] // 0x000000018996AB40-0x000000018996AB60
	private void OnOrderFinishNofity(OrderFinishNotify notify) {} // 0x0000000181508600-0x0000000181508B70
	// [XID] // 0x00000001899727B0-0x00000001899727D0
	public bool OpenShop(ShopType shopType) => default; // 0x0000000181501B70-0x0000000181501D90
	// [XID] // 0x0000000189979F70-0x0000000189979F90
	public bool OpenActivityShop(ShopType shopType) => default; // 0x000000018150A2D0-0x000000018150A410
	// [XID] // 0x0000000189981700-0x0000000189981720
	public void OpenHomeWorldShop() {} // 0x0000000181501840-0x0000000181501940
	// [XID] // 0x0000000189988F70-0x0000000189988F90
	public void OpenHomeWorldLimitedShop() {} // 0x0000000181506E90-0x0000000181506FB0
	// [XID] // 0x00000001899907D0-0x00000001899907F0
	public void RequestHomeLimitedShopBuyGoods(ShopItem shopGoods, uint buyCount) {} // 0x0000000181507270-0x0000000181507520
	// [XID] // 0x00000001899982F0-0x0000000189998310
	private void OnHomeLimitedShopBuyGoodsRsp(HomeLimitedShopBuyGoodsRsp rsp) {} // 0x0000000181506260-0x0000000181506850
	// [XID] // 0x000000018999FA50-0x000000018999FA70
	private void OnHomeLimitedShopInfoChangeNotify(HomeLimitedShopInfoChangeNotify ntf) {} // 0x0000000181501940-0x0000000181501B70
	// [XID] // 0x00000001899A7740-0x00000001899A7760
	public void RequestHomeLimitedShopGoodsListInfo() {} // 0x0000000181509CC0-0x0000000181509DA0
	// [XID] // 0x00000001899AEF50-0x00000001899AEF70
	private void OnHomeLimitedShopGoodsListRsp(HomeLimitedShopGoodsListRsp rsp) {} // 0x0000000181503180-0x00000001815033C0
}

