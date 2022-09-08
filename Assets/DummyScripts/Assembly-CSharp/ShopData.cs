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

public class ShopData : IReusable // TypeDefIndex: 21680
{
	// Fields
	private Dictionary<uint, ShopItem> _goodsDic; // 0x10
	private Dictionary<uint, ShopItem> _configDict; // 0x18
	private List<ShopItem> _goodsList; // 0x20
	private ShopType _shopType; // 0x28
	private ulong _refreshTime; // 0x30
	private uint _cityID; // 0x38
	private uint _cityReputationLevel; // 0x3C

	// Properties
	public uint shopID { /* [XID] */ /* 0x0000000189B63C50-0x0000000189B63C70 */ get => default; } // 0x0000000183AAD400-0x0000000183AAD4A0 
	public uint cityID { /* [XID] */ /* 0x0000000189B6B3E0-0x0000000189B6B400 */ get => default; } // 0x0000000183AAD590-0x0000000183AAD630 
	public uint cityReputationLevel { /* [XID] */ /* 0x0000000189B729F0-0x0000000189B72A10 */ get => default; } // 0x0000000183AACC70-0x0000000183AACD10 
	public ShopType shopType { /* [XID] */ /* 0x0000000189B79F70-0x0000000189B79F90 */ get => default; } // 0x0000000183AAC5E0-0x0000000183AAC680 
	public List<ShopItem> goodsList { /* [XID] */ /* 0x0000000189B816D0-0x0000000189B816F0 */ get => default; } // 0x0000000183AAC770-0x0000000183AAC810 
	public int goodsCount { /* [XID] */ /* 0x0000000189B88D50-0x0000000189B88D70 */ get => default; } // 0x0000000183AACBB0-0x0000000183AACC70 
	public bool allHavePrice { /* [XID] */ /* 0x0000000189B902C0-0x0000000189B902E0 */ get => default; } // 0x0000000183AAD040-0x0000000183AAD280 
	public bool isRefreshShop { /* [XID] */ /* 0x0000000189B97710-0x0000000189B97730 */ get => default; } // 0x0000000183AACF90-0x0000000183AAD040 
	public ulong refreshTime { /* [XID] */ /* 0x0000000189B9EBD0-0x0000000189B9EBF0 */ get => default; } // 0x0000000183AABC70-0x0000000183AABD10 

	// Constructors
	public ShopData() {} // 0x0000000183AAD9E0-0x0000000183AADAC0

	// Methods
	// [XID] // 0x0000000189B5C5B0-0x0000000189B5C5D0
	public static ShopData Create(uint shopID) => default; // 0x0000000183AAC940-0x0000000183AAC9F0
	// [XID] // 0x0000000189BA64C0-0x0000000189BA64E0
	private bool FilterGoods(string goodsID, int type) => default; // 0x0000000183AACDD0-0x0000000183AACEA0
	// [XID] // 0x0000000189BAD820-0x0000000189BAD840
	public void RefreshHomeLimitedShop(HomeLimitedShop shopData) {} // 0x0000000183AAC320-0x0000000183AAC4E0
	// [XID] // 0x0000000189BB4F40-0x0000000189BB4F60
	public void UpdateHomeLimitedShop(HomeLimitedShop shopData) {} // 0x0000000183AAC9F0-0x0000000183AACBB0
	// [XID] // 0x0000000189BBC560-0x0000000189BBC580
	public void Refresh(Shop shopData) {} // 0x0000000183AAB240-0x0000000183AABC70
	// [XID] // 0x0000000189BC4220-0x0000000189BC4240
	public bool IsEmptyShop() => default; // 0x0000000183AACD10-0x0000000183AACDD0
	// [XID] // 0x0000000189BCBBC0-0x0000000189BCBBE0
	public static int GoodCompare(ShopItem item1, ShopItem item2) => default; // 0x0000000183AAC4E0-0x0000000183AAC5E0
	// [XID] // 0x0000000189BD30F0-0x0000000189BD3110
	public void SortGoods() {} // 0x0000000183AAC810-0x0000000183AAC940
	// [XID] // 0x0000000189BDA950-0x0000000189BDA970
	public uint GetDefaultShopItemID() => default; // 0x0000000183AAB150-0x0000000183AAB240
	// [XID] // 0x00000001895E7350-0x00000001895E7370
	public ShopItem GetShopItem(uint goodsID) => default; // 0x0000000183AACEA0-0x0000000183AACF90
	// [XID] // 0x00000001895EEC60-0x00000001895EEC80
	public ShopItem GetConfigShopItem(uint configID) => default; // 0x0000000183AAD4A0-0x0000000183AAD590
	// [XID] // 0x00000001895F6620-0x00000001895F6640
	public ShopItem GetShopItemByIndex(int index) => default; // 0x0000000183AAC680-0x0000000183AAC770
	// [XID] // 0x00000001895FDA00-0x00000001895FDA20
	public List<ShopItem> GetShopItemByItemID(uint itemID) => default; // 0x0000000183AAD280-0x0000000183AAD400
	// [IDTag] // 0x0000000189605210-0x0000000189605250
	// [XID] // 0x0000000189605210-0x0000000189605250
	public void UpdateShopGoods(ShopGoods shopGoods) {} // 0x0000000183AAD760-0x0000000183AAD890
	// [IDTag] // 0x000000018960FE30-0x000000018960FE70
	// [XID] // 0x000000018960FE30-0x000000018960FE70
	public void UpdateShopGoods(HomeLimitedShopGoods shopGoods) {} // 0x0000000183AAD630-0x0000000183AAD760
	// [IDTag] // 0x000000018961A420-0x000000018961A460
	// [XID] // 0x000000018961A420-0x000000018961A460
	public void UpdateShopGoods(ShopCardProduct shopCard) {} // 0x0000000183AAD890-0x0000000183AAD9E0
	// [XID] // 0x0000000189624870-0x0000000189624890
	public void UpdateMcoinGoods(ShopMcoinProduct shopProduct) {} // 0x0000000183AAC130-0x0000000183AAC280
	// [XID] // 0x000000018962BFD0-0x000000018962BFF0
	public virtual void BeforeRecycle() {} // 0x0000000183AABD10-0x0000000183AAC070
	// [XID] // 0x0000000189633B70-0x0000000189633B90
	protected virtual void Recycle() {} // 0x0000000183AAC280-0x0000000183AAC320
	// [XID] // 0x000000018963B3F0-0x000000018963B410
	public void Destroy() {} // 0x0000000183AAC070-0x0000000183AAC130
}

