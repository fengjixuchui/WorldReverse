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
public class CombineExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15339
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 combineIdRawNum; // 0x10
	protected SimpleSafeUInt32 playerLevelRawNum; // 0x14
	protected bool _isDefaultShow; // 0x18
	protected SimpleSafeUInt32 combineTypeRawNum; // 0x1C
	protected SimpleSafeUInt32 subCombineTypeRawNum; // 0x20
	protected SimpleSafeUInt32 resultItemIdRawNum; // 0x24
	protected SimpleSafeUInt32 resultItemCountRawNum; // 0x28
	protected SimpleSafeUInt32 scoinCostRawNum; // 0x2C
	protected RandomItemConfig[] _randomItems; // 0x30
	protected IdCountConfig[] _materialItems; // 0x38
	protected uint _effectDescTextMapHash; // 0x40
	protected RecipeType _recipeType; // 0x44

	// Properties
	public uint combineId { /* [XID] */ /* 0x00000001898CBFB0-0x00000001898CBFD0 */ get => default; /* [XID] */ /* 0x00000001898D3810-0x00000001898D3830 */ protected set {} } // 0x000000018311F0E0-0x000000018311F1B0 0x000000018311F280-0x000000018311F360
	public uint playerLevel { /* [XID] */ /* 0x00000001898DB0A0-0x00000001898DB0C0 */ get => default; /* [XID] */ /* 0x00000001898E2DA0-0x00000001898E2DC0 */ protected set {} } // 0x000000018311FF50-0x0000000183120020 0x000000018311D8F0-0x000000018311D9D0
	public bool isDefaultShow { /* [XID] */ /* 0x00000001898EAA50-0x00000001898EAA70 */ get => default; /* [XID] */ /* 0x00000001898F21B0-0x00000001898F21D0 */ protected set {} } // 0x000000018311F360-0x000000018311F400 0x0000000183120350-0x0000000183120400
	public uint combineType { /* [XID] */ /* 0x00000001898F9950-0x00000001898F9970 */ get => default; /* [XID] */ /* 0x0000000189901310-0x0000000189901330 */ protected set {} } // 0x000000018311DCA0-0x000000018311DD70 0x000000018311EF20-0x000000018311F000
	public uint subCombineType { /* [XID] */ /* 0x0000000189908AF0-0x0000000189908B10 */ get => default; /* [XID] */ /* 0x00000001899100F0-0x0000000189910110 */ protected set {} } // 0x000000018311FE80-0x000000018311FF50 0x0000000183120020-0x0000000183120100
	public uint resultItemId { /* [XID] */ /* 0x0000000189917C80-0x0000000189917CA0 */ get => default; /* [XID] */ /* 0x000000018991F1C0-0x000000018991F1E0 */ protected set {} } // 0x0000000183120400-0x00000001831204D0 0x000000018311F000-0x000000018311F0E0
	public uint resultItemCount { /* [XID] */ /* 0x0000000189926C80-0x0000000189926CA0 */ get => default; /* [XID] */ /* 0x000000018992E3F0-0x000000018992E410 */ protected set {} } // 0x0000000183120100-0x00000001831201D0 0x000000018311D380-0x000000018311D460
	public uint scoinCost { /* [XID] */ /* 0x0000000189935710-0x0000000189935730 */ get => default; /* [XID] */ /* 0x000000018993D1F0-0x000000018993D210 */ protected set {} } // 0x000000018311F1B0-0x000000018311F280 0x00000001831201D0-0x00000001831202B0
	public RandomItemConfig[] randomItems { /* [XID] */ /* 0x0000000189944940-0x0000000189944960 */ get => default; /* [XID] */ /* 0x000000018994BEA0-0x000000018994BEC0 */ protected set {} } // 0x000000018311DB50-0x000000018311DBF0 0x000000018311D460-0x000000018311D510
	public IdCountConfig[] materialItems { /* [XID] */ /* 0x0000000189953590-0x00000001899535B0 */ get => default; /* [XID] */ /* 0x000000018995AD30-0x000000018995AD50 */ protected set {} } // 0x00000001831202B0-0x0000000183120350 0x000000018311D700-0x000000018311D7B0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint effectDescTextMapHash { /* [XID] */ /* 0x0000000189962930-0x0000000189962950 */ get => default; /* [XID] */ /* 0x0000000189969D00-0x0000000189969D20 */ protected set {} } // 0x000000018311D7B0-0x000000018311D850 0x000000018311F400-0x000000018311F4B0
	public string effectDesc { /* [XID] */ /* 0x0000000189971A40-0x0000000189971A60 */ get => default; } // 0x000000018311D9D0-0x000000018311DB50 
	public RecipeType recipeType { /* [XID] */ /* 0x0000000189979350-0x0000000189979370 */ get => default; /* [XID] */ /* 0x0000000189980480-0x00000001899804A0 */ protected set {} } // 0x000000018311D850-0x000000018311D8F0 0x000000018311DBF0-0x000000018311DCA0

	// Constructors
	public CombineExcelConfig() {} // 0x00000001831206B0-0x0000000183120710

	// Methods
	// [IDTag] // 0x0000000189987D50-0x0000000189987D90
	// [XID] // 0x0000000189987D50-0x0000000189987D90
	public virtual bool ParseFromLine(string line) => default; // 0x000000018311E5D0-0x000000018311EF20
	// [IDTag] // 0x0000000189992AF0-0x0000000189992B30
	// [XID] // 0x0000000189992AF0-0x0000000189992B30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018311DD70-0x000000018311E5D0
	// [XID] // 0x000000018999D4F0-0x000000018999D510
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF07FC */, bool useObjectPool = false /* Metadata: 0x00AF0800 */) => default; // 0x000000018311F4B0-0x000000018311FE80
	[BlackList] // 0x00000001899A4DD0-0x00000001899A4E10
	// [XID] // 0x00000001899A4DD0-0x00000001899A4E10
	public virtual void AutoAllocTypeFields() {} // 0x000000018311D510-0x000000018311D5B0
	[BlackList] // 0x00000001899AF750-0x00000001899AF790
	// [XID] // 0x00000001899AF750-0x00000001899AF790
	public virtual void AutoRecycleTypeFields() {} // 0x000000018311D5B0-0x000000018311D700
	[BlackList] // 0x00000001899B9CB0-0x00000001899B9CF0
	// [XID] // 0x00000001899B9CB0-0x00000001899B9CF0
	public virtual void ReturnToObjectPool() {} // 0x0000000183120610-0x00000001831206B0
	[BlackList] // 0x00000001899C4800-0x00000001899C4840
	// [XID] // 0x00000001899C4800-0x00000001899C4840
	public virtual void OnPoolAllocated() {} // 0x0000000183120570-0x0000000183120610
	[BlackList] // 0x00000001899CEDA0-0x00000001899CEDE0
	// [XID] // 0x00000001899CEDA0-0x00000001899CEDE0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001831204D0-0x0000000183120570
}

