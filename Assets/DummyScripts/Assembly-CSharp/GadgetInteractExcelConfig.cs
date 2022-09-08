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
public class GadgetInteractExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15645
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 interactIdRawNum; // 0x10
	protected SimpleSafeUInt32 consumeItemIdRawNum; // 0x14
	protected SimpleSafeUInt32 consumeItemNumRawNum; // 0x18
	protected InteractActionType _actionType; // 0x1C
	protected SimpleSafeUInt32 param1RawNum; // 0x20
	protected SimpleSafeUInt32 param2RawNum; // 0x24
	protected IdCountConfig[] _costItems; // 0x28
	protected uint _uiTitleTextMapHash; // 0x30
	protected uint _uiDescTextMapHash; // 0x34

	// Properties
	public uint interactId { /* [XID] */ /* 0x000000018988D740-0x000000018988D760 */ get => default; /* [XID] */ /* 0x0000000189894E30-0x0000000189894E50 */ protected set {} } // 0x00000001820AA950-0x00000001820AAA20 0x00000001820A9B40-0x00000001820A9C20
	public uint consumeItemId { /* [XID] */ /* 0x0000000189B1E660-0x0000000189B1E680 */ get => default; /* [XID] */ /* 0x00000001898A3C00-0x00000001898A3C20 */ protected set {} } // 0x00000001820A88D0-0x00000001820A89A0 0x00000001820A9DD0-0x00000001820A9EB0
	public uint consumeItemNum { /* [XID] */ /* 0x00000001898AAF00-0x00000001898AAF20 */ get => default; /* [XID] */ /* 0x00000001898B2810-0x00000001898B2830 */ protected set {} } // 0x00000001820AAC80-0x00000001820AAD50 0x00000001820AAA20-0x00000001820AAB00
	public InteractActionType actionType { /* [XID] */ /* 0x00000001898BA5C0-0x00000001898BA5E0 */ get => default; /* [XID] */ /* 0x00000001898C1840-0x00000001898C1860 */ protected set {} } // 0x00000001820AAB00-0x00000001820AABA0 0x00000001820A89A0-0x00000001820A8A50
	public uint param1 { /* [XID] */ /* 0x00000001898C91C0-0x00000001898C91E0 */ get => default; /* [XID] */ /* 0x00000001898D09E0-0x00000001898D0A00 */ protected set {} } // 0x00000001820A8A50-0x00000001820A8B20 0x00000001820A9C20-0x00000001820A9D00
	public uint param2 { /* [XID] */ /* 0x00000001898D80C0-0x00000001898D80E0 */ get => default; /* [XID] */ /* 0x00000001898DFF80-0x00000001898DFFA0 */ protected set {} } // 0x00000001820A9D00-0x00000001820A9DD0 0x00000001820AABA0-0x00000001820AAC80
	public IdCountConfig[] costItems { /* [XID] */ /* 0x00000001898E7A70-0x00000001898E7A90 */ get => default; /* [XID] */ /* 0x00000001898EF100-0x00000001898EF120 */ protected set {} } // 0x00000001820AAD50-0x00000001820AADF0 0x00000001820A9A90-0x00000001820A9B40
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint uiTitleTextMapHash { /* [XID] */ /* 0x00000001898F69C0-0x00000001898F69E0 */ get => default; /* [XID] */ /* 0x00000001898FE120-0x00000001898FE140 */ protected set {} } // 0x00000001820AA030-0x00000001820AA0D0 0x00000001820A8650-0x00000001820A8700
	public string uiTitle { /* [XID] */ /* 0x00000001899059A0-0x00000001899059C0 */ get => default; } // 0x00000001820A8B20-0x00000001820A8CA0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint uiDescTextMapHash { /* [XID] */ /* 0x000000018993A9A0-0x000000018993A9C0 */ get => default; /* [XID] */ /* 0x00000001899149C0-0x00000001899149E0 */ protected set {} } // 0x00000001820AA0D0-0x00000001820AA170 0x00000001820A99E0-0x00000001820A9A90
	public string uiDesc { /* [XID] */ /* 0x000000018991C5C0-0x000000018991C5E0 */ get => default; } // 0x00000001820A9EB0-0x00000001820AA030 

	// Constructors
	public GadgetInteractExcelConfig() {} // 0x00000001820AAFD0-0x00000001820AB030

	// Methods
	// [IDTag] // 0x0000000189923DC0-0x0000000189923E00
	// [XID] // 0x0000000189923DC0-0x0000000189923E00
	public virtual bool ParseFromLine(string line) => default; // 0x00000001820A92E0-0x00000001820A99E0
	// [IDTag] // 0x000000018992E350-0x000000018992E390
	// [XID] // 0x000000018992E350-0x000000018992E390
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001820A8CA0-0x00000001820A92E0
	// [XID] // 0x0000000189938670-0x0000000189938690
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF218E */, bool useObjectPool = false /* Metadata: 0x00AF2192 */) => default; // 0x00000001820AA170-0x00000001820AA950
	[BlackList] // 0x0000000189940000-0x0000000189940040
	// [XID] // 0x0000000189940000-0x0000000189940040
	public virtual void AutoAllocTypeFields() {} // 0x00000001820A8700-0x00000001820A87A0
	[BlackList] // 0x000000018994A4E0-0x000000018994A520
	// [XID] // 0x000000018994A4E0-0x000000018994A520
	public virtual void AutoRecycleTypeFields() {} // 0x00000001820A87A0-0x00000001820A88D0
	[BlackList] // 0x0000000189954C00-0x0000000189954C40
	// [XID] // 0x0000000189954C00-0x0000000189954C40
	public virtual void ReturnToObjectPool() {} // 0x00000001820AAF30-0x00000001820AAFD0
	[BlackList] // 0x000000018995F6F0-0x000000018995F730
	// [XID] // 0x000000018995F6F0-0x000000018995F730
	public virtual void OnPoolAllocated() {} // 0x00000001820AAE90-0x00000001820AAF30
	[BlackList] // 0x0000000189969C80-0x0000000189969CC0
	// [XID] // 0x0000000189969C80-0x0000000189969CC0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001820AADF0-0x00000001820AAE90
}

