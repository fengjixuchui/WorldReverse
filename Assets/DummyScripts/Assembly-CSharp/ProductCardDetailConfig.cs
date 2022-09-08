/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ProductCardDetailConfig : ProductDetailConfig, IAutoAllocRecycle // TypeDefIndex: 16140
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected CardProductType _cardProductType; // 0x28
	protected uint _itemNameTextMapHash; // 0x2C
	protected string _icon; // 0x30
	protected SimpleSafeUInt32 totalLimitDaysRawNum; // 0x38
	protected SimpleSafeUInt32 daysRawNum; // 0x3C
	protected SimpleSafeUInt32 hcoinPerDayRawNum; // 0x40
	protected SimpleSafeUInt32 mcoinBaseRawNum; // 0x44
	protected Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> _baseItemMap; // 0x48
	protected Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> _perDayItemMap; // 0x50
	protected SimpleSafeUInt32 replaceMcoinNumRawNum; // 0x58
	protected uint _firstRewardTextTextMapHash; // 0x5C
	protected uint _dailyRewardTextTextMapHash; // 0x60
	protected uint _totalRewardTextTextMapHash; // 0x64
	protected uint _totalDaysTextTextMapHash; // 0x68
	protected uint _remainDaysTextTextMapHash; // 0x6C
	protected uint _remainDaysText2TextMapHash; // 0x70
	protected uint _explainTitleTextMapHash; // 0x74
	protected uint _explainDescTextMapHash; // 0x78

	// Properties
	public CardProductType cardProductType { /* [XID] */ /* 0x000000018971FAD0-0x000000018971FAF0 */ get => default; /* [XID] */ /* 0x00000001897271C0-0x00000001897271E0 */ protected set {} } // 0x0000000184D332A0-0x0000000184D33340 0x0000000184D37AC0-0x0000000184D37B70
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint itemNameTextMapHash { /* [XID] */ /* 0x000000018972E750-0x000000018972E770 */ get => default; /* [XID] */ /* 0x0000000189735EE0-0x0000000189735F00 */ protected set {} } // 0x0000000184D37DB0-0x0000000184D37E50 0x0000000184D36540-0x0000000184D365F0
	public string itemName { /* [XID] */ /* 0x000000018973DB30-0x000000018973DB50 */ get => default; } // 0x0000000184D37940-0x0000000184D37AC0 
	public string icon { /* [XID] */ /* 0x0000000189744EB0-0x0000000189744ED0 */ get => default; /* [XID] */ /* 0x000000018974CA60-0x000000018974CA80 */ protected set {} } // 0x0000000184D32EC0-0x0000000184D32F60 0x0000000184D37EB0-0x0000000184D37F60
	public uint totalLimitDays { /* [XID] */ /* 0x0000000189753D80-0x0000000189753DA0 */ get => default; /* [XID] */ /* 0x000000018975B2C0-0x000000018975B2E0 */ protected set {} } // 0x0000000184D37F60-0x0000000184D38030 0x0000000184D382F0-0x0000000184D383D0
	public uint days { /* [XID] */ /* 0x0000000189762C30-0x0000000189762C50 */ get => default; /* [XID] */ /* 0x000000018976A270-0x000000018976A290 */ protected set {} } // 0x0000000184D384B0-0x0000000184D38580 0x0000000184D35DD0-0x0000000184D35EB0
	public uint hcoinPerDay { /* [XID] */ /* 0x0000000189771AF0-0x0000000189771B10 */ get => default; /* [XID] */ /* 0x0000000189779280-0x00000001897792A0 */ protected set {} } // 0x0000000184D32C70-0x0000000184D32D40 0x0000000184D383D0-0x0000000184D384B0
	public uint mcoinBase { /* [XID] */ /* 0x0000000189780A80-0x0000000189780AA0 */ get => default; /* [XID] */ /* 0x0000000189788100-0x0000000189788120 */ protected set {} } // 0x0000000184D334C0-0x0000000184D33590 0x0000000184D38210-0x0000000184D382F0
	public Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> baseItemMap { /* [XID] */ /* 0x000000018978F680-0x000000018978F6A0 */ get => default; /* [XID] */ /* 0x0000000189796ED0-0x0000000189796EF0 */ protected set {} } // 0x0000000184D380D0-0x0000000184D38170 0x0000000184D35F60-0x0000000184D36010
	public Dictionary<SimpleSafeUInt32, SimpleSafeUInt32> perDayItemMap { /* [XID] */ /* 0x000000018979EF30-0x000000018979EF50 */ get => default; /* [XID] */ /* 0x00000001897A65A0-0x00000001897A65C0 */ protected set {} } // 0x0000000184D38030-0x0000000184D380D0 0x0000000184D37B70-0x0000000184D37C20
	public uint replaceMcoinNum { /* [XID] */ /* 0x00000001897ADB30-0x00000001897ADB50 */ get => default; /* [XID] */ /* 0x00000001897B5C90-0x00000001897B5CB0 */ protected set {} } // 0x0000000184D38580-0x0000000184D38650 0x0000000184D37CD0-0x0000000184D37DB0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint firstRewardTextTextMapHash { /* [XID] */ /* 0x00000001897BDA60-0x00000001897BDA80 */ get => default; /* [XID] */ /* 0x00000001897C4E00-0x00000001897C4E20 */ protected set {} } // 0x0000000184D35D30-0x0000000184D35DD0 0x0000000184D331F0-0x0000000184D332A0
	public string firstRewardText { /* [XID] */ /* 0x00000001897CC630-0x00000001897CC650 */ get => default; } // 0x0000000184D38650-0x0000000184D387D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint dailyRewardTextTextMapHash { /* [XID] */ /* 0x00000001897D3F40-0x00000001897D3F60 */ get => default; /* [XID] */ /* 0x00000001897DB790-0x00000001897DB7B0 */ protected set {} } // 0x0000000184D36730-0x0000000184D367D0 0x0000000184D36310-0x0000000184D363C0
	public string dailyRewardText { /* [XID] */ /* 0x00000001897E2FA0-0x00000001897E2FC0 */ get => default; } // 0x0000000184D36010-0x0000000184D36190 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint totalRewardTextTextMapHash { /* [XID] */ /* 0x00000001897EA780-0x00000001897EA7A0 */ get => default; /* [XID] */ /* 0x00000001897F25D0-0x00000001897F25F0 */ protected set {} } // 0x0000000184D35C90-0x0000000184D35D30 0x0000000184D336D0-0x0000000184D33780
	public string totalRewardText { /* [XID] */ /* 0x00000001897F9CE0-0x00000001897F9D00 */ get => default; } // 0x0000000184D32D40-0x0000000184D32EC0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint totalDaysTextTextMapHash { /* [XID] */ /* 0x0000000189801260-0x0000000189801280 */ get => default; /* [XID] */ /* 0x0000000189808620-0x0000000189808640 */ protected set {} } // 0x0000000184D33B90-0x0000000184D33C30 0x0000000184D35EB0-0x0000000184D35F60
	public string totalDaysText { /* [XID] */ /* 0x0000000189810170-0x0000000189810190 */ get => default; } // 0x0000000184D33340-0x0000000184D334C0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint remainDaysTextTextMapHash { /* [XID] */ /* 0x00000001898177C0-0x00000001898177E0 */ get => default; /* [XID] */ /* 0x000000018981F160-0x000000018981F180 */ protected set {} } // 0x0000000184D33630-0x0000000184D336D0 0x0000000184D37C20-0x0000000184D37CD0
	public string remainDaysText { /* [XID] */ /* 0x0000000189826650-0x0000000189826670 */ get => default; } // 0x0000000184D36190-0x0000000184D36310 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint remainDaysText2TextMapHash { /* [XID] */ /* 0x000000018982DD40-0x000000018982DD60 */ get => default; /* [XID] */ /* 0x00000001898353D0-0x00000001898353F0 */ protected set {} } // 0x0000000184D33590-0x0000000184D33630 0x0000000184D33AE0-0x0000000184D33B90
	public string remainDaysText2 { /* [XID] */ /* 0x000000018983CB10-0x000000018983CB30 */ get => default; } // 0x0000000184D337E0-0x0000000184D33960 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint explainTitleTextMapHash { /* [XID] */ /* 0x0000000189844220-0x0000000189844240 */ get => default; /* [XID] */ /* 0x000000018984B690-0x000000018984B6B0 */ protected set {} } // 0x0000000184D36880-0x0000000184D36920 0x0000000184D365F0-0x0000000184D366A0
	public string explainTitle { /* [XID] */ /* 0x0000000189852700-0x0000000189852720 */ get => default; } // 0x0000000184D33960-0x0000000184D33AE0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint explainDescTextMapHash { /* [XID] */ /* 0x000000018985A190-0x000000018985A1B0 */ get => default; /* [XID] */ /* 0x00000001898612F0-0x0000000189861310 */ protected set {} } // 0x0000000184D38170-0x0000000184D38210 0x0000000184D367D0-0x0000000184D36880
	public string explainDesc { /* [XID] */ /* 0x0000000189868AD0-0x0000000189868AF0 */ get => default; } // 0x0000000184D363C0-0x0000000184D36540 

	// Constructors
	public ProductCardDetailConfig() {} // 0x0000000184D38870-0x0000000184D388D0

	// Methods
	// [IDTag] // 0x000000018986FF20-0x000000018986FF60
	// [XID] // 0x000000018986FF20-0x000000018986FF60
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184D33C30-0x0000000184D34C40
	// [IDTag] // 0x000000018987AAB0-0x000000018987AAF0
	// [XID] // 0x000000018987AAB0-0x000000018987AAF0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184D34C40-0x0000000184D35C90
	// [XID] // 0x00000001898849F0-0x0000000189884A10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3245 */, bool useObjectPool = false /* Metadata: 0x00AF3249 */) => default; // 0x0000000184D36980-0x0000000184D37940
	[BlackList] // 0x000000018988C080-0x000000018988C0C0
	// [XID] // 0x000000018988C080-0x000000018988C0C0
	public override void AutoAllocTypeFields() {} // 0x0000000184D32F60-0x0000000184D33000
	[BlackList] // 0x00000001898963C0-0x0000000189896400
	// [XID] // 0x00000001898963C0-0x0000000189896400
	public override void AutoRecycleTypeFields() {} // 0x0000000184D33000-0x0000000184D33150
	[BlackList] // 0x00000001898A07B0-0x00000001898A07F0
	// [XID] // 0x00000001898A07B0-0x00000001898A07F0
	public override void ReturnToObjectPool() {} // 0x0000000184D387D0-0x0000000184D38870
}

