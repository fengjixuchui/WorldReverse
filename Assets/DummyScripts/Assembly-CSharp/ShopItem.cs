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

public class ShopItem : IReusable // TypeDefIndex: 21684
{
	// Fields
	private List<ShopMaterial> _costItems; // 0x10
	private ShopGoods _goods; // 0x18
	private ShopMcoinProduct _mcoins; // 0x20
	private ShopCardProduct _card; // 0x28
	private ShopItemType _type; // 0x30
	private bool _isPackage; // 0x34
	public double weightOrder; // 0x38
	private bool _isInRefreshShop; // 0x40

	// Properties
	public List<ShopMaterial> shopMatList { /* [XID] */ /* 0x000000018969A010-0x000000018969A030 */ get => default; } // 0x00000001831C1350-0x00000001831C13F0 
	public ShopItemPayType type { /* [XID] */ /* 0x00000001896AFD10-0x00000001896AFD30 */ get => default; } // 0x00000001831C43C0-0x00000001831C4480 
	public ShopGoods goods { /* [XID] */ /* 0x00000001896BE870-0x00000001896BE890 */ get => default; } // 0x00000001831C0EF0-0x00000001831C0F90 
	public ShopMcoinProduct mcoins { /* [XID] */ /* 0x00000001896C6170-0x00000001896C6190 */ get => default; } // 0x00000001831C4320-0x00000001831C43C0 
	public ShopCardProduct card { /* [XID] */ /* 0x00000001896CD770-0x00000001896CD790 */ get => default; } // 0x00000001831C2020-0x00000001831C20C0 
	public CardProductType cardProductType { /* [XID] */ /* 0x00000001896D4BA0-0x00000001896D4BC0 */ get => default; } // 0x00000001831BFA50-0x00000001831BFB10 
	public ProductCardDetailConfig cardConfig { /* [XID] */ /* 0x00000001896DC220-0x00000001896DC240 */ get => default; } // 0x00000001831C3FF0-0x00000001831C40E0 
	public IdCountStrConfig cardFirstReward { /* [XID] */ /* 0x00000001896E39B0-0x00000001896E39D0 */ get => default; } // 0x00000001831BFBC0-0x00000001831BFE60 
	public IdCountStrConfig cardDailyReward { /* [XID] */ /* 0x00000001896EADE0-0x00000001896EAE00 */ get => default; } // 0x00000001831C3950-0x00000001831C3BF0 
	public bool isInRefreshShop { /* [XID] */ /* 0x00000001896F21B0-0x00000001896F21D0 */ get => default; /* [XID] */ /* 0x00000001896F9B70-0x00000001896F9B90 */ set {} } // 0x00000001831C02B0-0x00000001831C0350 0x00000001831BFB10-0x00000001831BFBC0
	public uint firstCostID { /* [XID] */ /* 0x00000001897013C0-0x00000001897013E0 */ get => default; } // 0x00000001831C0400-0x00000001831C04F0 
	public bool needRecharge { /* [XID] */ /* 0x0000000189708B80-0x0000000189708BA0 */ get => default; } // 0x00000001831C1B60-0x00000001831C1C10 
	public uint firstCostCount { /* [XID] */ /* 0x0000000189710460-0x0000000189710480 */ get => default; } // 0x00000001831C1C10-0x00000001831C1D00 
	public string productPriceTier { /* [XID] */ /* 0x00000001897177E0-0x0000000189717800 */ get => default; } // 0x00000001831C1A50-0x00000001831C1B60 
	public uint orignCount { /* [XID] */ /* 0x000000018971F310-0x000000018971F330 */ get => default; } // 0x00000001831C08D0-0x00000001831C09A0 
	public bool isPackage { /* [XID] */ /* 0x00000001897268E0-0x0000000189726900 */ get => default; /* [XID] */ /* 0x000000018972DE70-0x000000018972DE90 */ set {} } // 0x00000001831C3130-0x00000001831C31E0 0x00000001831C3720-0x00000001831C37D0
	public bool isCard { /* [XID] */ /* 0x0000000189735510-0x0000000189735530 */ get => default; } // 0x00000001831C0350-0x00000001831C0400 
	public bool isMcoin { /* [XID] */ /* 0x000000018973D070-0x000000018973D090 */ get => default; } // 0x00000001831C2D30-0x00000001831C2DE0 
	public bool isAudit { /* [XID] */ /* 0x0000000189744590-0x00000001897445B0 */ get => default; } // 0x00000001831C09A0-0x00000001831C0A60 
	public string productName { /* [XID] */ /* 0x000000018974C250-0x000000018974C270 */ get => default; } // 0x00000001831C0A60-0x00000001831C0E10 
	public string productID { /* [XID] */ /* 0x00000001897534E0-0x0000000189753500 */ get => default; } // 0x00000001831C1240-0x00000001831C1350 
	public uint configID { /* [XID] */ /* 0x000000018975AA40-0x000000018975AA60 */ get => default; } // 0x00000001831C01E0-0x00000001831C02B0 
	public uint goodsID { /* [XID] */ /* 0x00000001897625B0-0x00000001897625D0 */ get => default; } // 0x00000001831BFF30-0x00000001831BFFF0 
	public string itemIconName { /* [XID] */ /* 0x0000000189769C30-0x0000000189769C50 */ get => default; } // 0x00000001831C2800-0x00000001831C29E0 
	public uint itemRank { /* [XID] */ /* 0x0000000189771220-0x0000000189771240 */ get => default; } // 0x00000001831C0F90-0x00000001831C1090 
	public string itemName { /* [XID] */ /* 0x0000000189778AA0-0x0000000189778AC0 */ get => default; } // 0x00000001831C2DE0-0x00000001831C2FC0 
	public uint shopGoodId { /* [XID] */ /* 0x0000000189780040-0x0000000189780060 */ get => default; } // 0x00000001831C4480-0x00000001831C4540 
	public uint subTabId { /* [XID] */ /* 0x0000000189787900-0x0000000189787920 */ get => default; } // 0x00000001831C3290-0x00000001831C3370 
	public uint itemID { /* [XID] */ /* 0x000000018978EF20-0x000000018978EF40 */ get => default; } // 0x00000001831C0E10-0x00000001831C0EF0 
	public uint itemCount { /* [XID] */ /* 0x0000000189796790-0x00000001897967B0 */ get => default; } // 0x00000001831C3470-0x00000001831C3550 
	public uint beginTime { /* [XID] */ /* 0x000000018979E870-0x000000018979E890 */ get => default; } // 0x00000001831C1F60-0x00000001831C2020 
	public uint endTime { /* [XID] */ /* 0x00000001897A5F80-0x00000001897A5FA0 */ get => default; } // 0x00000001831C1D00-0x00000001831C1DC0 
	public uint buyLimit { /* [XID] */ /* 0x00000001897AD450-0x00000001897AD470 */ get => default; } // 0x00000001831C2FC0-0x00000001831C3080 
	public ShopRefreshType refreshType { /* [XID] */ /* 0x00000001897B5510-0x00000001897B5530 */ get => default; } // 0x00000001831C1090-0x00000001831C1240 
	public uint boughtNum { /* [XID] */ /* 0x00000001897BD130-0x00000001897BD150 */ get => default; } // 0x00000001831C13F0-0x00000001831C14B0 
	public uint maxNum { /* [XID] */ /* 0x00000001897C4500-0x00000001897C4520 */ get => default; } // 0x00000001831C31E0-0x00000001831C3290 
	public bool useItemExchange { /* [XID] */ /* 0x00000001897CBCD0-0x00000001897CBCF0 */ get => default; } // 0x00000001831C37D0-0x00000001831C3950 
	public ulong nextRefreshTime { /* [XID] */ /* 0x00000001897D3700-0x00000001897D3720 */ get => default; } // 0x00000001831C4260-0x00000001831C4320 
	public uint minlevel { /* [XID] */ /* 0x00000001897DB190-0x00000001897DB1B0 */ get => default; } // 0x00000001831C1DC0-0x00000001831C1E80 
	public bool isLimitToBuy { /* [XID] */ /* 0x00000001897E2800-0x00000001897E2820 */ get => default; } // 0x00000001831C3370-0x00000001831C3470 
	public bool isLimitByDisableType { /* [XID] */ /* 0x00000001897E9F00-0x00000001897E9F20 */ get => default; } // 0x00000001831C20C0-0x00000001831C2170 
	public bool isLimitByLevel { /* [XID] */ /* 0x00000001897F1C30-0x00000001897F1C50 */ get => default; } // 0x00000001831C2700-0x00000001831C2800 
	public bool isLimitByNum { /* [XID] */ /* 0x00000001897F9430-0x00000001897F9450 */ get => default; } // 0x00000001831C1E80-0x00000001831C1F60 
	public bool isLimitByObj { /* [XID] */ /* 0x0000000189800A30-0x0000000189800A50 */ get => default; } // 0x00000001831C04F0-0x00000001831C0770 
	public bool isLimitByBeginTime { /* [XID] */ /* 0x0000000189807FC0-0x0000000189807FE0 */ get => default; } // 0x00000001831C3BF0-0x00000001831C3D70 
	public bool isTimeLimitItem { /* [XID] */ /* 0x000000018980F990-0x000000018980F9B0 */ get => default; } // 0x00000001831C3080-0x00000001831C3130 
	public bool isLimitByEndTime { /* [XID] */ /* 0x0000000189816FC0-0x0000000189816FE0 */ get => default; } // 0x00000001831C40E0-0x00000001831C4260 
	public bool isLimitByTreasureMapRegion { /* [XID] */ /* 0x000000018981E830-0x000000018981E850 */ get => default; } // 0x00000001831C3D70-0x00000001831C3FF0 
	public bool isLimitByHomeworldLevel { /* [XID] */ /* 0x0000000189825D40-0x0000000189825D60 */ get => default; } // 0x00000001831C25D0-0x00000001831C2700 
	public bool isLimitByFleurFairWatcher { /* [XID] */ /* 0x000000018982D480-0x000000018982D4A0 */ get => default; } // 0x00000001831C2170-0x00000001831C25D0 
	public uint maxLevel { /* [XID] */ /* 0x0000000189834B90-0x0000000189834BB0 */ get => default; } // 0x00000001831C0770-0x00000001831C0820 
	public ShopGoodsDisableType disableType { /* [XID] */ /* 0x000000018983C2B0-0x000000018983C2D0 */ get => default; } // 0x00000001831BF990-0x00000001831BFA50 
	public string disableTypeTextMapID { /* [XID] */ /* 0x0000000189843860-0x0000000189843880 */ get => default; } // 0x00000001831C29E0-0x00000001831C2AA0 

	// Constructors
	public ShopItem() {} // 0x00000001831C4540-0x00000001831C45F0

	// Methods
	// [IDTag] // 0x00000001896591B0-0x00000001896591F0
	// [XID] // 0x00000001896591B0-0x00000001896591F0
	public static ShopItem Create(ShopGoods shopGoods) => default; // 0x00000001831C1890-0x00000001831C1970
	// [IDTag] // 0x0000000189663980-0x00000001896639C0
	// [XID] // 0x0000000189663980-0x00000001896639C0
	public static ShopItem Create(HomeLimitedShopGoods shopGoods) => default; // 0x00000001831C17B0-0x00000001831C1890
	// [IDTag] // 0x000000018966DF30-0x000000018966DF70
	// [XID] // 0x000000018966DF30-0x000000018966DF70
	public static ShopItem Create(ShopCardProduct shopGoods) => default; // 0x00000001831C16D0-0x00000001831C17B0
	// [IDTag] // 0x0000000189678F50-0x0000000189678F90
	// [XID] // 0x0000000189678F50-0x0000000189678F90
	public static ShopItem Create(ShopMcoinProduct shopGoods) => default; // 0x00000001831C1970-0x00000001831C1A50
	// [XID] // 0x0000000189683490-0x00000001896834B0
	public virtual void BeforeRecycle() {} // 0x00000001831BFE60-0x00000001831BFF30
	// [XID] // 0x000000018968B050-0x000000018968B070
	protected virtual void Recycle() {} // 0x00000001831C0820-0x00000001831C08D0
	// [XID] // 0x0000000189692D50-0x0000000189692D70
	public void Destroy() {} // 0x00000001831C0120-0x00000001831C01E0
	// [XID] // 0x00000001896A1800-0x00000001896A1820
	public void UpdateWeightOrder(float order) {} // 0x00000001831BF030-0x00000001831BF1B0
	// [XID] // 0x00000001896A8CA0-0x00000001896A8CC0
	private float GetNormalizeLeftTime() => default; // 0x00000001831C3550-0x00000001831C3720
	// [XID] // 0x00000001896B7740-0x00000001896B7760
	private bool hasDiscount() => default; // 0x00000001831BFFF0-0x00000001831C0120
	// [XID] // 0x000000018984ADB0-0x000000018984ADD0
	public bool CanBuy(uint count) => default; // 0x00000001831C2BF0-0x00000001831C2D30
	// [XID] // 0x0000000189852070-0x0000000189852090
	public uint LackHcoinCount(uint count) => default; // 0x00000001831C2AA0-0x00000001831C2BF0
	// [IDTag] // 0x0000000189859A90-0x0000000189859AD0
	// [XID] // 0x0000000189859A90-0x0000000189859AD0
	public virtual void Refresh(ShopGoods shopGoods) {} // 0x00000001831BF390-0x00000001831BF680
	// [IDTag] // 0x0000000189863FB0-0x0000000189863FF0
	// [XID] // 0x0000000189863FB0-0x0000000189863FF0
	public virtual void Refresh(HomeLimitedShopGoods shopGoods) {} // 0x00000001831BF680-0x00000001831BF990
	// [XID] // 0x000000018986E1D0-0x000000018986E1F0
	public void RebuildGoodsWeight() {} // 0x00000001831C14B0-0x00000001831C16D0
	// [IDTag] // 0x00000001898756A0-0x00000001898756E0
	// [XID] // 0x00000001898756A0-0x00000001898756E0
	public virtual void Refresh(ShopMcoinProduct shopMcoin) {} // 0x00000001831BF2A0-0x00000001831BF390
	// [IDTag] // 0x000000018987FCC0-0x000000018987FD00
	// [XID] // 0x000000018987FCC0-0x000000018987FD00
	public virtual void Refresh(ShopCardProduct shopCard) {} // 0x00000001831BF1B0-0x00000001831BF2A0
}

