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
public class CookRecipeExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14854
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected SimpleSafeUInt32 rankLevelRawNum; // 0x18
	protected string _icon; // 0x20
	protected uint _descTextMapHash; // 0x28
	protected uint[] _effectDesc; // 0x30
	protected CookFoodType _foodType; // 0x38
	protected CookMethodType _cookMethod; // 0x3C
	protected bool _isDefaultUnlocked; // 0x40
	protected SimpleSafeUInt32 maxProficiencyRawNum; // 0x44
	protected IdCountConfig[] _qualityOutputVec; // 0x48
	protected IdCountConfig[] _inputVec; // 0x50
	protected string _qteParam; // 0x58
	protected SimpleSafeUInt32[] _qteQualityWeightVec; // 0x60

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A04810-0x0000000189A04830 */ get => default; /* [XID] */ /* 0x0000000189A0BF90-0x0000000189A0BFB0 */ protected set {} } // 0x00000001817F3C30-0x00000001817F3D00 0x00000001817F27F0-0x00000001817F28D0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189A13920-0x0000000189A13940 */ get => default; /* [XID] */ /* 0x0000000189A1AA30-0x0000000189A1AA50 */ protected set {} } // 0x00000001817F0060-0x00000001817F0100 0x00000001817F3600-0x00000001817F36B0
	public string name { /* [XID] */ /* 0x0000000189A22390-0x0000000189A223B0 */ get => default; } // 0x00000001817F3DA0-0x00000001817F3F20 
	public uint rankLevel { /* [XID] */ /* 0x0000000189A29740-0x0000000189A29760 */ get => default; /* [XID] */ /* 0x0000000189A30C30-0x0000000189A30C50 */ protected set {} } // 0x00000001817F2240-0x00000001817F2310 0x00000001817F2160-0x00000001817F2240
	public string icon { /* [XID] */ /* 0x0000000189A38650-0x0000000189A38670 */ get => default; /* [XID] */ /* 0x0000000189A3FDC0-0x0000000189A3FDE0 */ protected set {} } // 0x00000001817EFA00-0x00000001817EFAA0 0x00000001817F3760-0x00000001817F3810
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A474B0-0x0000000189A474D0 */ get => default; /* [XID] */ /* 0x0000000189A4ED10-0x0000000189A4ED30 */ protected set {} } // 0x00000001817F3560-0x00000001817F3600 0x00000001817F0100-0x00000001817F01B0
	public string desc { /* [XID] */ /* 0x0000000189A563E0-0x0000000189A56400 */ get => default; } // 0x00000001817F2670-0x00000001817F27F0 
	public uint[] effectDesc { /* [XID] */ /* 0x0000000189A5DE20-0x0000000189A5DE40 */ get => default; /* [XID] */ /* 0x0000000189A656A0-0x0000000189A656C0 */ protected set {} } // 0x00000001817F01B0-0x00000001817F0250 0x00000001817F1DE0-0x00000001817F1E90
	public string[] effectDescLocalized { /* [XID] */ /* 0x0000000189A6CD40-0x0000000189A6CD60 */ get => default; } // 0x00000001817F2310-0x00000001817F2670 
	public CookFoodType foodType { /* [XID] */ /* 0x0000000189A74550-0x0000000189A74570 */ get => default; /* [XID] */ /* 0x0000000189A7BFE0-0x0000000189A7C000 */ protected set {} } // 0x00000001817F20C0-0x00000001817F2160 0x00000001817F36B0-0x00000001817F3760
	public CookMethodType cookMethod { /* [XID] */ /* 0x0000000189A83A00-0x0000000189A83A20 */ get => default; /* [XID] */ /* 0x0000000189A8B1E0-0x0000000189A8B200 */ protected set {} } // 0x00000001817F0250-0x00000001817F02F0 0x00000001817F1F60-0x00000001817F2010
	public bool isDefaultUnlocked { /* [XID] */ /* 0x0000000189A92930-0x0000000189A92950 */ get => default; /* [XID] */ /* 0x0000000189A9A2E0-0x0000000189A9A300 */ protected set {} } // 0x00000001817F1D40-0x00000001817F1DE0 0x00000001817F3810-0x00000001817F38C0
	public uint maxProficiency { /* [XID] */ /* 0x0000000189AA13E0-0x0000000189AA1400 */ get => default; /* [XID] */ /* 0x0000000189AA8B40-0x0000000189AA8B60 */ protected set {} } // 0x00000001817F1E90-0x00000001817F1F60 0x00000001817F38C0-0x00000001817F39A0
	public IdCountConfig[] qualityOutputVec { /* [XID] */ /* 0x0000000189AB0700-0x0000000189AB0720 */ get => default; /* [XID] */ /* 0x0000000189AB7D60-0x0000000189AB7D80 */ protected set {} } // 0x00000001817F39A0-0x00000001817F3A40 0x00000001817F2010-0x00000001817F20C0
	public IdCountConfig[] inputVec { /* [XID] */ /* 0x0000000189ABF830-0x0000000189ABF850 */ get => default; /* [XID] */ /* 0x0000000189AC7220-0x0000000189AC7240 */ protected set {} } // 0x00000001817F03A0-0x00000001817F0440 0x00000001817F3A40-0x00000001817F3AF0
	public string qteParam { /* [XID] */ /* 0x0000000189ACE930-0x0000000189ACE950 */ get => default; /* [XID] */ /* 0x0000000189AD67E0-0x0000000189AD6800 */ protected set {} } // 0x00000001817F3410-0x00000001817F34B0 0x00000001817F34B0-0x00000001817F3560
	public SimpleSafeUInt32[] qteQualityWeightVec { /* [XID] */ /* 0x0000000189ADE160-0x0000000189ADE180 */ get => default; /* [XID] */ /* 0x0000000189AE5B80-0x0000000189AE5BA0 */ protected set {} } // 0x00000001817F3D00-0x00000001817F3DA0 0x00000001817F02F0-0x00000001817F03A0

	// Constructors
	public CookRecipeExcelConfig() {} // 0x00000001817F3FC0-0x00000001817F4020

	// Methods
	// [XID] // 0x00000001899F5AD0-0x00000001899F5AF0
	public static bool CheckCookItemNumEnough(uint recipeId) => default; // 0x00000001817EFE90-0x00000001817F0060
	// [XID] // 0x00000001899FD250-0x00000001899FD270
	public static uint CheckCookFoodMaxNum(uint recipeId) => default; // 0x00000001817EFAA0-0x00000001817EFCD0
	// [IDTag] // 0x0000000189AED020-0x0000000189AED060
	// [XID] // 0x0000000189AED020-0x0000000189AED060
	public virtual bool ParseFromLine(string line) => default; // 0x00000001817F1040-0x00000001817F1D40
	// [IDTag] // 0x0000000189AF7AC0-0x0000000189AF7B00
	// [XID] // 0x0000000189AF7AC0-0x0000000189AF7B00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001817F0440-0x00000001817F1040
	// [XID] // 0x0000000189B02250-0x0000000189B02270
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7DB */, bool useObjectPool = false /* Metadata: 0x00AEF7DF */) => default; // 0x00000001817F28D0-0x00000001817F3410
	[BlackList] // 0x0000000189B09710-0x0000000189B09750
	// [XID] // 0x0000000189B09710-0x0000000189B09750
	public virtual void AutoAllocTypeFields() {} // 0x00000001817EFCD0-0x00000001817EFD70
	[BlackList] // 0x0000000189B13BF0-0x0000000189B13C30
	// [XID] // 0x0000000189B13BF0-0x0000000189B13C30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817EFD70-0x00000001817EFE90
	[BlackList] // 0x0000000189B1E150-0x0000000189B1E190
	// [XID] // 0x0000000189B1E150-0x0000000189B1E190
	public virtual void ReturnToObjectPool() {} // 0x00000001817F3F20-0x00000001817F3FC0
	[BlackList] // 0x0000000189B28870-0x0000000189B288B0
	// [XID] // 0x0000000189B28870-0x0000000189B288B0
	public virtual void OnPoolAllocated() {} // 0x00000001817F3B90-0x00000001817F3C30
	[BlackList] // 0x0000000189B32C80-0x0000000189B32CC0
	// [XID] // 0x0000000189B32C80-0x0000000189B32CC0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817F3AF0-0x00000001817F3B90
}

