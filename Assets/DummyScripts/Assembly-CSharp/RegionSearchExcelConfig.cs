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
public class RegionSearchExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15156
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _searchNameTextMapHash; // 0x14
	protected uint _searchDescTextMapHash; // 0x18
	protected uint _searchCompleteTextMapHash; // 0x1C
	protected SimpleSafeUInt32 tutorialIdRawNum; // 0x20
	protected string _markIconTypeName; // 0x28
	protected RegionSearchType _searchType; // 0x30
	protected SimpleSafeUInt32 materialIdRawNum; // 0x34
	protected bool _isClearMaterial; // 0x38
	protected SimpleSafeUInt32 searchGroupIdRawNum; // 0x3C
	protected SimpleSafeUInt32 reviseLevelRawNum; // 0x40
	protected string _abilityGroup; // 0x48

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189972F50-0x0000000189972F70 */ get => default; /* [XID] */ /* 0x000000018997A810-0x000000018997A830 */ protected set {} } // 0x0000000184185AB0-0x0000000184185B80 0x0000000184184900-0x00000001841849E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint searchNameTextMapHash { /* [XID] */ /* 0x00000001899821E0-0x0000000189982200 */ get => default; /* [XID] */ /* 0x0000000189989A00-0x0000000189989A20 */ protected set {} } // 0x0000000184184710-0x00000001841847B0 0x0000000184185B80-0x0000000184185C30
	public string searchName { /* [XID] */ /* 0x0000000189991270-0x0000000189991290 */ get => default; } // 0x00000001841840E0-0x0000000184184260 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint searchDescTextMapHash { /* [XID] */ /* 0x0000000189998D50-0x0000000189998D70 */ get => default; /* [XID] */ /* 0x00000001899A05F0-0x00000001899A0610 */ protected set {} } // 0x0000000184184410-0x00000001841844B0 0x0000000184182DF0-0x0000000184182EA0
	public string searchDesc { /* [XID] */ /* 0x00000001899A80E0-0x00000001899A8100 */ get => default; } // 0x0000000184185750-0x00000001841858D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint searchCompleteTextMapHash { /* [XID] */ /* 0x00000001899AF7F0-0x00000001899AF810 */ get => default; /* [XID] */ /* 0x00000001899B6CD0-0x00000001899B6CF0 */ protected set {} } // 0x00000001841856B0-0x0000000184185750 0x0000000184185480-0x0000000184185530
	public string searchComplete { /* [XID] */ /* 0x00000001899BE7B0-0x00000001899BE7D0 */ get => default; } // 0x0000000184183E90-0x0000000184184010 
	public uint tutorialId { /* [XID] */ /* 0x00000001899C5FD0-0x00000001899C5FF0 */ get => default; /* [XID] */ /* 0x00000001899CD7D0-0x00000001899CD7F0 */ protected set {} } // 0x0000000184184560-0x0000000184184630 0x0000000184185530-0x0000000184185610
	public string markIconTypeName { /* [XID] */ /* 0x00000001899D4C70-0x00000001899D4C90 */ get => default; /* [XID] */ /* 0x00000001899DC2F0-0x00000001899DC310 */ protected set {} } // 0x0000000184185610-0x00000001841856B0 0x00000001841844B0-0x0000000184184560
	public RegionSearchType searchType { /* [XID] */ /* 0x00000001899E3B50-0x00000001899E3B70 */ get => default; /* [XID] */ /* 0x00000001899EAFE0-0x00000001899EB000 */ protected set {} } // 0x00000001841858D0-0x0000000184185970 0x0000000184182EA0-0x0000000184182F50
	public uint materialId { /* [XID] */ /* 0x00000001899F2BE0-0x00000001899F2C00 */ get => default; /* [XID] */ /* 0x00000001899FA250-0x00000001899FA270 */ protected set {} } // 0x0000000184184340-0x0000000184184410 0x0000000184184260-0x0000000184184340
	public bool isClearMaterial { /* [XID] */ /* 0x0000000189A015D0-0x0000000189A015F0 */ get => default; /* [XID] */ /* 0x0000000189A08FF0-0x0000000189A09010 */ protected set {} } // 0x00000001841847B0-0x0000000184184850 0x0000000184184850-0x0000000184184900
	public uint searchGroupId { /* [XID] */ /* 0x0000000189A10510-0x0000000189A10530 */ get => default; /* [XID] */ /* 0x0000000189A17AD0-0x0000000189A17AF0 */ protected set {} } // 0x00000001841853B0-0x0000000184185480 0x0000000184182B40-0x0000000184182C20
	public uint reviseLevel { /* [XID] */ /* 0x0000000189A1F170-0x0000000189A1F190 */ get => default; /* [XID] */ /* 0x0000000189A26760-0x0000000189A26780 */ protected set {} } // 0x0000000184184010-0x00000001841840E0 0x0000000184184630-0x0000000184184710
	public string abilityGroup { /* [XID] */ /* 0x0000000189A2DAB0-0x0000000189A2DAD0 */ get => default; /* [XID] */ /* 0x0000000189A356D0-0x0000000189A356F0 */ protected set {} } // 0x0000000184182F50-0x0000000184182FF0 0x0000000184182FF0-0x00000001841830A0

	// Constructors
	public RegionSearchExcelConfig() {} // 0x0000000184185CD0-0x0000000184185D30

	// Methods
	// [IDTag] // 0x0000000189A3CB20-0x0000000189A3CB60
	// [XID] // 0x0000000189A3CB20-0x0000000189A3CB60
	public virtual bool ParseFromLine(string line) => default; // 0x00000001841830A0-0x0000000184183790
	// [IDTag] // 0x0000000189A473D0-0x0000000189A47410
	// [XID] // 0x0000000189A473D0-0x0000000189A47410
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184183790-0x0000000184183E90
	// [XID] // 0x0000000189A51C30-0x0000000189A51C50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF025B */, bool useObjectPool = false /* Metadata: 0x00AF025F */) => default; // 0x00000001841849E0-0x00000001841853B0
	[BlackList] // 0x0000000189A59340-0x0000000189A59380
	// [XID] // 0x0000000189A59340-0x0000000189A59380
	public virtual void AutoAllocTypeFields() {} // 0x0000000184182C20-0x0000000184182CC0
	[BlackList] // 0x0000000189A63E90-0x0000000189A63ED0
	// [XID] // 0x0000000189A63E90-0x0000000189A63ED0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184182CC0-0x0000000184182DF0
	[BlackList] // 0x0000000189A6E600-0x0000000189A6E640
	// [XID] // 0x0000000189A6E600-0x0000000189A6E640
	public virtual void ReturnToObjectPool() {} // 0x0000000184185C30-0x0000000184185CD0
	[BlackList] // 0x0000000189A78F40-0x0000000189A78F80
	// [XID] // 0x0000000189A78F40-0x0000000189A78F80
	public virtual void OnPoolAllocated() {} // 0x0000000184185A10-0x0000000184185AB0
	[BlackList] // 0x0000000189A838C0-0x0000000189A83900
	// [XID] // 0x0000000189A838C0-0x0000000189A83900
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184185970-0x0000000184185A10
}

