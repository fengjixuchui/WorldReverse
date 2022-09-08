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
public class FleurFairDungeonStatExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15107
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 galleryIdRawNum; // 0x14
	protected FleurFairDungeonStatType _statType; // 0x18
	protected string[] _statParamList; // 0x20
	protected OrderingType _orderingType; // 0x28
	protected FleurFairDungeonStatMethod _statMethod; // 0x2C
	protected SimpleSafeUInt32 priorityRawNum; // 0x30
	protected uint _titleTextMapHash; // 0x34
	protected uint _descTextMapHash; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AECF20-0x0000000189AECF40 */ get => default; /* [XID] */ /* 0x0000000189AF4810-0x0000000189AF4830 */ protected set {} } // 0x00000001823C9610-0x00000001823C96E0 0x00000001823C86E0-0x00000001823C87C0
	public uint galleryId { /* [XID] */ /* 0x0000000189AFBE80-0x0000000189AFBEA0 */ get => default; /* [XID] */ /* 0x0000000189B03730-0x0000000189B03750 */ protected set {} } // 0x00000001823C96E0-0x00000001823C97B0 0x00000001823C9340-0x00000001823C9420
	public FleurFairDungeonStatType statType { /* [XID] */ /* 0x0000000189B0AE60-0x0000000189B0AE80 */ get => default; /* [XID] */ /* 0x0000000189B126E0-0x0000000189B12700 */ protected set {} } // 0x00000001823C97B0-0x00000001823C9850 0x00000001823C72E0-0x00000001823C7390
	public string[] statParamList { /* [XID] */ /* 0x0000000189B19A50-0x0000000189B19A70 */ get => default; /* [XID] */ /* 0x0000000189B20FB0-0x0000000189B20FD0 */ protected set {} } // 0x00000001823C8640-0x00000001823C86E0 0x00000001823C9070-0x00000001823C9120
	public OrderingType orderingType { /* [XID] */ /* 0x0000000189B286F0-0x0000000189B28710 */ get => default; /* [XID] */ /* 0x0000000189B2FB10-0x0000000189B2FB30 */ protected set {} } // 0x00000001823C8420-0x00000001823C84C0 0x00000001823C9420-0x00000001823C94D0
	public FleurFairDungeonStatMethod statMethod { /* [XID] */ /* 0x0000000189B374F0-0x0000000189B37510 */ get => default; /* [XID] */ /* 0x0000000189B3ED60-0x0000000189B3ED80 */ protected set {} } // 0x00000001823C74F0-0x00000001823C7590 0x00000001823C7190-0x00000001823C7240
	public uint priority { /* [XID] */ /* 0x0000000189B46820-0x0000000189B46840 */ get => default; /* [XID] */ /* 0x0000000189B4DD60-0x0000000189B4DD80 */ protected set {} } // 0x00000001823C8FA0-0x00000001823C9070 0x00000001823C8340-0x00000001823C8420
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189B55630-0x0000000189B55650 */ get => default; /* [XID] */ /* 0x0000000189B5CEF0-0x0000000189B5CF10 */ protected set {} } // 0x00000001823C7240-0x00000001823C72E0 0x00000001823C7440-0x00000001823C74F0
	public string title { /* [XID] */ /* 0x0000000189B64610-0x0000000189B64630 */ get => default; } // 0x00000001823C91C0-0x00000001823C9340 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B6BAD0-0x0000000189B6BAF0 */ get => default; /* [XID] */ /* 0x0000000189B733D0-0x0000000189B733F0 */ protected set {} } // 0x00000001823C9120-0x00000001823C91C0 0x00000001823C7390-0x00000001823C7440
	public string desc { /* [XID] */ /* 0x0000000189B7A8D0-0x0000000189B7A8F0 */ get => default; } // 0x00000001823C84C0-0x00000001823C8640 

	// Constructors
	public FleurFairDungeonStatExcelConfig() {} // 0x00000001823C98F0-0x00000001823C9950

	// Methods
	// [IDTag] // 0x0000000189B820D0-0x0000000189B82110
	// [XID] // 0x0000000189B820D0-0x0000000189B82110
	public virtual bool ParseFromLine(string line) => default; // 0x00000001823C7590-0x00000001823C7C90
	// [IDTag] // 0x0000000189B8C2E0-0x0000000189B8C320
	// [XID] // 0x0000000189B8C2E0-0x0000000189B8C320
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001823C7C90-0x00000001823C8340
	// [XID] // 0x0000000189B96850-0x0000000189B96870
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0102 */, bool useObjectPool = false /* Metadata: 0x00AF0106 */) => default; // 0x00000001823C87C0-0x00000001823C8FA0
	[BlackList] // 0x0000000189B9DD80-0x0000000189B9DDC0
	// [XID] // 0x0000000189B9DD80-0x0000000189B9DDC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001823C6FF0-0x00000001823C7090
	[BlackList] // 0x0000000189BA8470-0x0000000189BA84B0
	// [XID] // 0x0000000189BA8470-0x0000000189BA84B0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001823C7090-0x00000001823C7190
	[BlackList] // 0x0000000189BB2A10-0x0000000189BB2A50
	// [XID] // 0x0000000189BB2A10-0x0000000189BB2A50
	public virtual void ReturnToObjectPool() {} // 0x00000001823C9850-0x00000001823C98F0
	[BlackList] // 0x0000000189BBCF40-0x0000000189BBCF80
	// [XID] // 0x0000000189BBCF40-0x0000000189BBCF80
	public virtual void OnPoolAllocated() {} // 0x00000001823C9570-0x00000001823C9610
	[BlackList] // 0x0000000189BC79E0-0x0000000189BC7A20
	// [XID] // 0x0000000189BC79E0-0x0000000189BC7A20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001823C94D0-0x00000001823C9570
}

