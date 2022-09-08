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
public class ShopmallRecommendConfig : IAutoAllocRecycle // TypeDefIndex: 16136
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected SimpleSafeUInt32 subTabIdRawNum; // 0x18
	protected ShopRecommendTabType _tabType; // 0x1C
	protected ShopType _shopType; // 0x20
	protected SimpleSafeUInt32[] _goodsIdVec; // 0x28
	protected SimpleSafeUInt32[] _configIdVec; // 0x30
	protected LogicType _condComb; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ShopmallRecommendCond[] _condVec; // 0x40
	protected SimpleSafeUInt32 orderRawNum; // 0x48
	protected ShopRecommendTagType _tagType; // 0x4C
	protected string _oneCardIconName; // 0x50
	protected string[] _colShowIconName; // 0x58

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189A36D90-0x0000000189A36DB0 */ get => default; /* [XID] */ /* 0x0000000189A3E390-0x0000000189A3E3B0 */ protected set {} } // 0x00000001839D6C00-0x00000001839D6CD0 0x00000001839D8050-0x00000001839D8130
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189A45A20-0x0000000189A45A40 */ get => default; /* [XID] */ /* 0x0000000189A4D180-0x0000000189A4D1A0 */ protected set {} } // 0x00000001839D4B50-0x00000001839D4BF0 0x00000001839D7FA0-0x00000001839D8050
	public string name { /* [XID] */ /* 0x0000000189A548B0-0x0000000189A548D0 */ get => default; } // 0x00000001839D84A0-0x00000001839D8620 
	public uint subTabId { /* [XID] */ /* 0x0000000189A5C340-0x0000000189A5C360 */ get => default; /* [XID] */ /* 0x0000000189A63D30-0x0000000189A63D50 */ protected set {} } // 0x00000001839D7ED0-0x00000001839D7FA0 0x00000001839D83C0-0x00000001839D84A0
	public ShopRecommendTabType tabType { /* [XID] */ /* 0x0000000189A6B5D0-0x0000000189A6B5F0 */ get => default; /* [XID] */ /* 0x0000000189A72D40-0x0000000189A72D60 */ protected set {} } // 0x00000001839D6B60-0x00000001839D6C00 0x00000001839D6AB0-0x00000001839D6B60
	public ShopType shopType { /* [XID] */ /* 0x0000000189A7A8B0-0x0000000189A7A8D0 */ get => default; /* [XID] */ /* 0x0000000189A81D90-0x0000000189A81DB0 */ protected set {} } // 0x00000001839D6A10-0x00000001839D6AB0 0x00000001839D4A00-0x00000001839D4AB0
	public SimpleSafeUInt32[] goodsIdVec { /* [XID] */ /* 0x0000000189A89870-0x0000000189A89890 */ get => default; /* [XID] */ /* 0x0000000189A90F50-0x0000000189A90F70 */ protected set {} } // 0x00000001839D7040-0x00000001839D70E0 0x00000001839D8130-0x00000001839D81E0
	public SimpleSafeUInt32[] configIdVec { /* [XID] */ /* 0x0000000189A98820-0x0000000189A98840 */ get => default; /* [XID] */ /* 0x0000000189A9FC90-0x0000000189A9FCB0 */ protected set {} } // 0x00000001839D6D70-0x00000001839D6E10 0x00000001839D6EB0-0x00000001839D6F60
	public LogicType condComb { /* [XID] */ /* 0x0000000189AA73A0-0x0000000189AA73C0 */ get => default; /* [XID] */ /* 0x0000000189AAEAE0-0x0000000189AAEB00 */ protected set {} } // 0x00000001839D81E0-0x00000001839D8280 0x00000001839D7D70-0x00000001839D7E20
	public ShopmallRecommendCond[] condVec { /* [XID] */ /* 0x0000000189AB6420-0x0000000189AB6440 */ get => default; /* [XID] */ /* 0x0000000189ABDEF0-0x0000000189ABDF10 */ protected set {} } // 0x00000001839D4AB0-0x00000001839D4B50 0x00000001839D7CC0-0x00000001839D7D70
	public uint order { /* [XID] */ /* 0x0000000189AC5A10-0x0000000189AC5A30 */ get => default; /* [XID] */ /* 0x0000000189ACCF80-0x0000000189ACCFA0 */ protected set {} } // 0x00000001839D4BF0-0x00000001839D4CC0 0x00000001839D6F60-0x00000001839D7040
	public ShopRecommendTagType tagType { /* [XID] */ /* 0x0000000189AD4C80-0x0000000189AD4CA0 */ get => default; /* [XID] */ /* 0x0000000189ADC580-0x0000000189ADC5A0 */ protected set {} } // 0x00000001839D4CC0-0x00000001839D4D60 0x00000001839D70E0-0x00000001839D7190
	public string oneCardIconName { /* [XID] */ /* 0x0000000189AE3F10-0x0000000189AE3F30 */ get => default; /* [XID] */ /* 0x0000000189AEB7B0-0x0000000189AEB7D0 */ protected set {} } // 0x00000001839D6E10-0x00000001839D6EB0 0x00000001839D7190-0x00000001839D7240
	public string[] colShowIconName { /* [XID] */ /* 0x0000000189AF30F0-0x0000000189AF3110 */ get => default; /* [XID] */ /* 0x0000000189AFA9C0-0x0000000189AFA9E0 */ protected set {} } // 0x00000001839D6CD0-0x00000001839D6D70 0x00000001839D7E20-0x00000001839D7ED0

	// Constructors
	public ShopmallRecommendConfig() {} // 0x00000001839D86C0-0x00000001839D8720

	// Methods
	// [IDTag] // 0x0000000189B01F90-0x0000000189B01FD0
	// [XID] // 0x0000000189B01F90-0x0000000189B01FD0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001839D5B50-0x00000001839D6A10
	// [IDTag] // 0x0000000189B0C570-0x0000000189B0C5B0
	// [XID] // 0x0000000189B0C570-0x0000000189B0C5B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839D4D60-0x00000001839D5B50
	// [XID] // 0x0000000189B167F0-0x0000000189B16810
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3227 */, bool useObjectPool = false /* Metadata: 0x00AF322B */) => default; // 0x00000001839D7240-0x00000001839D7CC0
	[BlackList] // 0x0000000189B1DEF0-0x0000000189B1DF30
	// [XID] // 0x0000000189B1DEF0-0x0000000189B1DF30
	public virtual void AutoAllocTypeFields() {} // 0x00000001839D4830-0x00000001839D48D0
	[BlackList] // 0x0000000189B28590-0x0000000189B285D0
	// [XID] // 0x0000000189B28590-0x0000000189B285D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001839D48D0-0x00000001839D4A00
	[BlackList] // 0x0000000189B32A80-0x0000000189B32AC0
	// [XID] // 0x0000000189B32A80-0x0000000189B32AC0
	public virtual void ReturnToObjectPool() {} // 0x00000001839D8620-0x00000001839D86C0
	[BlackList] // 0x0000000189B3CF00-0x0000000189B3CF40
	// [XID] // 0x0000000189B3CF00-0x0000000189B3CF40
	public virtual void OnPoolAllocated() {} // 0x00000001839D8320-0x00000001839D83C0
	[BlackList] // 0x0000000189B47C00-0x0000000189B47C40
	// [XID] // 0x0000000189B47C00-0x0000000189B47C40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839D8280-0x00000001839D8320
}

