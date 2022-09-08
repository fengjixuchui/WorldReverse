/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ShopGoodsExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16111
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 goodsIdRawNum; // 0x10
	protected uint _subTagNameTextMapHash; // 0x14
	protected SimpleSafeUInt32 subTabIdRawNum; // 0x18
	protected SimpleSafeUInt32 shopTypeRawNum; // 0x1C
	protected SimpleSafeUInt32 itemIdRawNum; // 0x20
	protected SimpleSafeUInt32 rotateIdRawNum; // 0x24
	protected SimpleSafeUInt32 showIdRawNum; // 0x28
	protected SimpleSafeUInt32 itemCountRawNum; // 0x2C
	protected SimpleSafeUInt32 costScoinRawNum; // 0x30
	protected SimpleSafeUInt32 costHcoinRawNum; // 0x34
	protected SimpleSafeUInt32 costMcoinRawNum; // 0x38
	protected SimpleSafeFloat discountRateRawNum; // 0x3C
	protected SimpleSafeUInt32 originalPriceRawNum; // 0x40
	protected IdCountConfig[] _costItems; // 0x48
	protected SimpleSafeUInt32 buyLimitRawNum; // 0x50
	protected ShopRefreshType _refreshType; // 0x54
	protected SimpleSafeUInt32 refreshParamRawNum; // 0x58
	protected SimpleSafeUInt32 displayDaysBeforeSellRawNum; // 0x5C
	protected string _beginTime; // 0x60
	protected string _endTime; // 0x68
	protected bool _isBuyOnce; // 0x70
	protected ShopPrecondition _precondition; // 0x74
	protected SimpleSafeUInt32 preconditionParamRawNum; // 0x78
	protected string[] _preconditionParamList; // 0x80
	protected SimpleSafeUInt32 minShowLevelRawNum; // 0x88
	protected SimpleSafeUInt32 minPlayerLevelRawNum; // 0x8C
	protected SimpleSafeUInt32 maxPlayerLevelRawNum; // 0x90
	protected SimpleSafeUInt32 sortLevelRawNum; // 0x94
	protected SimpleSafeUInt32 secondarySheetIdRawNum; // 0x98
	protected SimpleSafeUInt32 chooseOneGroupIdRawNum; // 0x9C
	protected SimpleSafeUInt32[] _platformTypeList; // 0xA0

	// Properties
	public uint goodsId { /* [XID] */ /* 0x000000018983DFC0-0x000000018983DFE0 */ get => default; /* [XID] */ /* 0x0000000189845850-0x0000000189845870 */ protected set {} } // 0x00000001825D3460-0x00000001825D3530 0x00000001825D73D0-0x00000001825D74B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint subTagNameTextMapHash { /* [XID] */ /* 0x000000018984CDE0-0x000000018984CE00 */ get => default; /* [XID] */ /* 0x0000000189853EC0-0x0000000189853EE0 */ protected set {} } // 0x00000001825D9C80-0x00000001825D9D20 0x00000001825D95E0-0x00000001825D9690
	public string subTagName { /* [XID] */ /* 0x000000018985B950-0x000000018985B970 */ get => default; } // 0x00000001825D9690-0x00000001825D9810 
	public uint subTabId { /* [XID] */ /* 0x0000000189862F10-0x0000000189862F30 */ get => default; /* [XID] */ /* 0x000000018986A380-0x000000018986A3A0 */ protected set {} } // 0x00000001825D8DB0-0x00000001825D8E80 0x00000001825D9D20-0x00000001825D9E00
	public uint shopType { /* [XID] */ /* 0x00000001898717B0-0x00000001898717D0 */ get => default; /* [XID] */ /* 0x0000000189878F90-0x0000000189878FB0 */ protected set {} } // 0x00000001825D6600-0x00000001825D66D0 0x00000001825D31D0-0x00000001825D32B0
	public uint itemId { /* [XID] */ /* 0x0000000189880620-0x0000000189880640 */ get => default; /* [XID] */ /* 0x0000000189887BE0-0x0000000189887C00 */ protected set {} } // 0x00000001825D38A0-0x00000001825D3970 0x00000001825D66D0-0x00000001825D67B0
	public uint rotateId { /* [XID] */ /* 0x000000018988EEA0-0x000000018988EEC0 */ get => default; /* [XID] */ /* 0x0000000189896400-0x0000000189896420 */ protected set {} } // 0x00000001825D9E00-0x00000001825D9ED0 0x00000001825D9990-0x00000001825D9A70
	public uint showId { /* [XID] */ /* 0x000000018989DA40-0x000000018989DA60 */ get => default; /* [XID] */ /* 0x00000001898A5300-0x00000001898A5320 */ protected set {} } // 0x00000001825D2BF0-0x00000001825D2CC0 0x00000001825D6E20-0x00000001825D6F00
	public uint itemCount { /* [XID] */ /* 0x00000001898AC8A0-0x00000001898AC8C0 */ get => default; /* [XID] */ /* 0x00000001898B3DC0-0x00000001898B3DE0 */ protected set {} } // 0x00000001825D9020-0x00000001825D90F0 0x00000001825D6520-0x00000001825D6600
	public uint costScoin { /* [XID] */ /* 0x00000001898BBA90-0x00000001898BBAB0 */ get => default; /* [XID] */ /* 0x00000001898C2FA0-0x00000001898C2FC0 */ protected set {} } // 0x00000001825D9280-0x00000001825D9350 0x00000001825D2B10-0x00000001825D2BF0
	public uint costHcoin { /* [XID] */ /* 0x00000001898CA8E0-0x00000001898CA900 */ get => default; /* [XID] */ /* 0x00000001898D1FF0-0x00000001898D2010 */ protected set {} } // 0x00000001825D9BB0-0x00000001825D9C80 0x00000001825D3530-0x00000001825D3610
	public uint costMcoin { /* [XID] */ /* 0x00000001898D98D0-0x00000001898D98F0 */ get => default; /* [XID] */ /* 0x00000001898E1610-0x00000001898E1630 */ protected set {} } // 0x00000001825D9510-0x00000001825D95E0 0x00000001825D98B0-0x00000001825D9990
	public float discountRate { /* [XID] */ /* 0x00000001898E90A0-0x00000001898E90C0 */ get => default; /* [XID] */ /* 0x00000001898F08A0-0x00000001898F08C0 */ protected set {} } // 0x00000001825D90F0-0x00000001825D91D0 0x00000001825D9ED0-0x00000001825D9FB0
	public uint originalPrice { /* [XID] */ /* 0x00000001898F8210-0x00000001898F8230 */ get => default; /* [XID] */ /* 0x00000001898FF830-0x00000001898FF850 */ protected set {} } // 0x00000001825D8B30-0x00000001825D8C00 0x00000001825D37C0-0x00000001825D38A0
	public IdCountConfig[] costItems { /* [XID] */ /* 0x0000000189906FD0-0x0000000189906FF0 */ get => default; /* [XID] */ /* 0x000000018990E9F0-0x000000018990EA10 */ protected set {} } // 0x00000001825D9810-0x00000001825D98B0 0x00000001825D6920-0x00000001825D69D0
	public uint buyLimit { /* [XID] */ /* 0x0000000189916060-0x0000000189916080 */ get => default; /* [XID] */ /* 0x000000018991DB10-0x000000018991DB30 */ protected set {} } // 0x00000001825D8C00-0x00000001825D8CD0 0x00000001825D3AD0-0x00000001825D3BB0
	public ShopRefreshType refreshType { /* [XID] */ /* 0x00000001899252A0-0x00000001899252C0 */ get => default; /* [XID] */ /* 0x000000018992C8C0-0x000000018992C8E0 */ protected set {} } // 0x00000001825D6880-0x00000001825D6920 0x00000001825D6FA0-0x00000001825D7050
	public uint refreshParam { /* [XID] */ /* 0x0000000189933F00-0x0000000189933F20 */ get => default; /* [XID] */ /* 0x000000018993BAD0-0x000000018993BAF0 */ protected set {} } // 0x00000001825D8E80-0x00000001825D8F50 0x00000001825D2A30-0x00000001825D2B10
	public uint displayDaysBeforeSell { /* [XID] */ /* 0x0000000189942C10-0x0000000189942C30 */ get => default; /* [XID] */ /* 0x000000018994A400-0x000000018994A420 */ protected set {} } // 0x00000001825D3020-0x00000001825D30F0 0x00000001825D8CD0-0x00000001825D8DB0
	public string beginTime { /* [XID] */ /* 0x0000000189951EF0-0x0000000189951F10 */ get => default; /* [XID] */ /* 0x0000000189959470-0x0000000189959490 */ protected set {} } // 0x00000001825D6F00-0x00000001825D6FA0 0x00000001825D70F0-0x00000001825D71A0
	public string endTime { /* [XID] */ /* 0x0000000189960D20-0x0000000189960D40 */ get => default; /* [XID] */ /* 0x00000001899684A0-0x00000001899684C0 */ protected set {} } // 0x00000001825D6D80-0x00000001825D6E20 0x00000001825D3A20-0x00000001825D3AD0
	public bool isBuyOnce { /* [XID] */ /* 0x000000018996F980-0x000000018996F9A0 */ get => default; /* [XID] */ /* 0x0000000189977740-0x0000000189977760 */ protected set {} } // 0x00000001825D71A0-0x00000001825D7240 0x00000001825D91D0-0x00000001825D9280
	public ShopPrecondition precondition { /* [XID] */ /* 0x000000018997E9A0-0x000000018997E9C0 */ get => default; /* [XID] */ /* 0x0000000189986330-0x0000000189986350 */ protected set {} } // 0x00000001825D7050-0x00000001825D70F0 0x00000001825D3970-0x00000001825D3A20
	public uint preconditionParam { /* [XID] */ /* 0x000000018998DF00-0x000000018998DF20 */ get => default; /* [XID] */ /* 0x0000000189995A70-0x0000000189995A90 */ protected set {} } // 0x00000001825D6B30-0x00000001825D6C00 0x00000001825D32B0-0x00000001825D3390
	public string[] preconditionParamList { /* [XID] */ /* 0x000000018999D390-0x000000018999D3B0 */ get => default; /* [XID] */ /* 0x00000001899A4D10-0x00000001899A4D30 */ protected set {} } // 0x00000001825D69D0-0x00000001825D6A80 0x00000001825D6A80-0x00000001825D6B30
	public uint minShowLevel { /* [XID] */ /* 0x00000001899AC890-0x00000001899AC8B0 */ get => default; /* [XID] */ /* 0x00000001899B4060-0x00000001899B4080 */ protected set {} } // 0x00000001825D3390-0x00000001825D3460 0x00000001825D6440-0x00000001825D6520
	public uint minPlayerLevel { /* [XID] */ /* 0x00000001899BB4B0-0x00000001899BB4D0 */ get => default; /* [XID] */ /* 0x00000001899C3000-0x00000001899C3020 */ protected set {} } // 0x00000001825D9FB0-0x00000001825DA080 0x00000001825D72F0-0x00000001825D73D0
	public uint maxPlayerLevel { /* [XID] */ /* 0x00000001899CA3E0-0x00000001899CA400 */ get => default; /* [XID] */ /* 0x00000001899D1C20-0x00000001899D1C40 */ protected set {} } // 0x00000001825D67B0-0x00000001825D6880 0x00000001825D3610-0x00000001825D36F0
	public uint sortLevel { /* [XID] */ /* 0x00000001899D90D0-0x00000001899D90F0 */ get => default; /* [XID] */ /* 0x00000001899E0880-0x00000001899E08A0 */ protected set {} } // 0x00000001825D36F0-0x00000001825D37C0 0x00000001825D30F0-0x00000001825D31D0
	public uint secondarySheetId { /* [XID] */ /* 0x00000001899E8360-0x00000001899E8380 */ get => default; /* [XID] */ /* 0x00000001899EF970-0x00000001899EF990 */ protected set {} } // 0x00000001825D8F50-0x00000001825D9020 0x00000001825D9350-0x00000001825D9430
	public uint chooseOneGroupId { /* [XID] */ /* 0x00000001899F7130-0x00000001899F7150 */ get => default; /* [XID] */ /* 0x00000001899FE850-0x00000001899FE870 */ protected set {} } // 0x00000001825D6CB0-0x00000001825D6D80 0x00000001825D9430-0x00000001825D9510
	public SimpleSafeUInt32[] platformTypeList { /* [XID] */ /* 0x0000000189A060F0-0x0000000189A06110 */ get => default; /* [XID] */ /* 0x0000000189A0D600-0x0000000189A0D620 */ protected set {} } // 0x00000001825D7240-0x00000001825D72F0 0x00000001825D6C00-0x00000001825D6CB0

	// Constructors
	public ShopGoodsExcelConfig() {} // 0x00000001825DA120-0x00000001825DA180

	// Methods
	// [IDTag] // 0x0000000189A14D40-0x0000000189A14D80
	// [XID] // 0x0000000189A14D40-0x0000000189A14D80
	public virtual bool ParseFromLine(string line) => default; // 0x00000001825D4F20-0x00000001825D6440
	// [IDTag] // 0x0000000189A1EF70-0x0000000189A1EFB0
	// [XID] // 0x0000000189A1EF70-0x0000000189A1EFB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001825D3BB0-0x00000001825D4F20
	// [XID] // 0x0000000189A293C0-0x0000000189A293E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF317C */, bool useObjectPool = false /* Metadata: 0x00AF3180 */) => default; // 0x00000001825D74B0-0x00000001825D8B30
	[BlackList] // 0x0000000189A30970-0x0000000189A309B0
	// [XID] // 0x0000000189A30970-0x0000000189A309B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001825D2CC0-0x00000001825D2D60
	[BlackList] // 0x0000000189A3B160-0x0000000189A3B1A0
	// [XID] // 0x0000000189A3B160-0x0000000189A3B1A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001825D2D60-0x00000001825D3020
	[BlackList] // 0x0000000189A45A40-0x0000000189A45A80
	// [XID] // 0x0000000189A45A40-0x0000000189A45A80
	public virtual void ReturnToObjectPool() {} // 0x00000001825DA080-0x00000001825DA120
	[BlackList] // 0x0000000189A50180-0x0000000189A501C0
	// [XID] // 0x0000000189A50180-0x0000000189A501C0
	public virtual void OnPoolAllocated() {} // 0x00000001825D9B10-0x00000001825D9BB0
	[BlackList] // 0x0000000189A5A890-0x0000000189A5A8D0
	// [XID] // 0x0000000189A5A890-0x0000000189A5A8D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001825D9A70-0x00000001825D9B10
}

