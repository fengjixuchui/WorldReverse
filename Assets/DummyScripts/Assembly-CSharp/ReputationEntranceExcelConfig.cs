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
public class ReputationEntranceExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14906
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 textIdRawNum; // 0x10
	protected ReputationEntranceType _entranceId; // 0x14
	protected SimpleSafeUInt32 cityIdRawNum; // 0x18
	protected LogicType _condComb; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ReputationEntranceCond[] _condVec; // 0x20
	protected uint[] _condNameVec; // 0x28
	protected uint _nameTextMapHash; // 0x30
	protected uint _titleTextMapHash; // 0x34
	protected uint _explainTitleTextMapHash; // 0x38
	protected uint _descTextMapHash; // 0x3C
	protected string _iconName; // 0x40
	protected SimpleSafeUInt32 orderRawNum; // 0x48

	// Properties
	public uint textId { /* [XID] */ /* 0x0000000189799FB0-0x0000000189799FD0 */ get => default; /* [XID] */ /* 0x00000001897A1E60-0x00000001897A1E80 */ protected set {} } // 0x0000000184D3BD60-0x0000000184D3BE30 0x0000000184D38FD0-0x0000000184D390B0
	public ReputationEntranceType entranceId { /* [XID] */ /* 0x00000001897A9680-0x00000001897A96A0 */ get => default; /* [XID] */ /* 0x00000001897B0EE0-0x00000001897B0F00 */ protected set {} } // 0x0000000184D38D70-0x0000000184D38E10 0x0000000184D3C270-0x0000000184D3C320
	public uint cityId { /* [XID] */ /* 0x00000001897B8BA0-0x00000001897B8BC0 */ get => default; /* [XID] */ /* 0x00000001897C0B40-0x00000001897C0B60 */ protected set {} } // 0x0000000184D3C1A0-0x0000000184D3C270 0x0000000184D3ACF0-0x0000000184D3ADD0
	public LogicType condComb { /* [XID] */ /* 0x00000001897C8530-0x00000001897C8550 */ get => default; /* [XID] */ /* 0x00000001897CF990-0x00000001897CF9B0 */ protected set {} } // 0x0000000184D3C320-0x0000000184D3C3C0 0x0000000184D3BCB0-0x0000000184D3BD60
	public ReputationEntranceCond[] condVec { /* [XID] */ /* 0x00000001897D7220-0x00000001897D7240 */ get => default; /* [XID] */ /* 0x00000001897DE7B0-0x00000001897DE7D0 */ protected set {} } // 0x0000000184D390B0-0x0000000184D39150 0x0000000184D3BC00-0x0000000184D3BCB0
	public uint[] condNameVec { /* [XID] */ /* 0x00000001897E62D0-0x00000001897E62F0 */ get => default; /* [XID] */ /* 0x00000001897EDDB0-0x00000001897EDDD0 */ protected set {} } // 0x0000000184D3AC50-0x0000000184D3ACF0 0x0000000184D3BB50-0x0000000184D3BC00
	public string[] condNameVecLocalized { /* [XID] */ /* 0x00000001897F5470-0x00000001897F5490 */ get => default; } // 0x0000000184D3A8F0-0x0000000184D3AC50 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001897FCDA0-0x00000001897FCDC0 */ get => default; /* [XID] */ /* 0x0000000189804430-0x0000000189804450 */ protected set {} } // 0x0000000184D39150-0x0000000184D391F0 0x0000000184D3C050-0x0000000184D3C100
	public string name { /* [XID] */ /* 0x000000018980B8A0-0x000000018980B8C0 */ get => default; } // 0x0000000184D3C5B0-0x0000000184D3C730 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189813040-0x0000000189813060 */ get => default; /* [XID] */ /* 0x000000018981AB60-0x000000018981AB80 */ protected set {} } // 0x0000000184D391F0-0x0000000184D39290 0x0000000184D39410-0x0000000184D394C0
	public string title { /* [XID] */ /* 0x00000001898223F0-0x0000000189822410 */ get => default; } // 0x0000000184D3BED0-0x0000000184D3C050 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint explainTitleTextMapHash { /* [XID] */ /* 0x00000001898298D0-0x00000001898298F0 */ get => default; /* [XID] */ /* 0x0000000189830E40-0x0000000189830E60 */ protected set {} } // 0x0000000184D3B0E0-0x0000000184D3B180 0x0000000184D3ADD0-0x0000000184D3AE80
	public string explainTitle { /* [XID] */ /* 0x00000001898385E0-0x0000000189838600 */ get => default; } // 0x0000000184D394C0-0x0000000184D39640 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018983FBD0-0x000000018983FBF0 */ get => default; /* [XID] */ /* 0x0000000189847290-0x00000001898472B0 */ protected set {} } // 0x0000000184D3BE30-0x0000000184D3BED0 0x0000000184D39290-0x0000000184D39340
	public string desc { /* [XID] */ /* 0x000000018984E920-0x000000018984E940 */ get => default; } // 0x0000000184D3AE80-0x0000000184D3B000 
	public string iconName { /* [XID] */ /* 0x00000001898559F0-0x0000000189855A10 */ get => default; /* [XID] */ /* 0x000000018985CD90-0x000000018985CDB0 */ protected set {} } // 0x0000000184D3C100-0x0000000184D3C1A0 0x0000000184D3C500-0x0000000184D3C5B0
	public uint order { /* [XID] */ /* 0x0000000189864790-0x00000001898647B0 */ get => default; /* [XID] */ /* 0x000000018986BD40-0x000000018986BD60 */ protected set {} } // 0x0000000184D39340-0x0000000184D39410 0x0000000184D3B000-0x0000000184D3B0E0

	// Constructors
	public ReputationEntranceExcelConfig() {} // 0x0000000184D3C7D0-0x0000000184D3C830

	// Methods
	// [XID] // 0x0000000189792A20-0x0000000189792A40
	public string GetLockedText() => default; // 0x0000000184D388D0-0x0000000184D38D70
	// [IDTag] // 0x00000001898730D0-0x0000000189873110
	// [XID] // 0x00000001898730D0-0x0000000189873110
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184D39640-0x0000000184D3A010
	// [IDTag] // 0x000000018987DD00-0x000000018987DD40
	// [XID] // 0x000000018987DD00-0x000000018987DD40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184D3A010-0x0000000184D3A8F0
	// [XID] // 0x0000000189887DA0-0x0000000189887DC0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF988 */, bool useObjectPool = false /* Metadata: 0x00AEF98C */) => default; // 0x0000000184D3B180-0x0000000184D3BB50
	[BlackList] // 0x000000018988F160-0x000000018988F1A0
	// [XID] // 0x000000018988F160-0x000000018988F1A0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D38E10-0x0000000184D38EB0
	[BlackList] // 0x0000000189899930-0x0000000189899970
	// [XID] // 0x0000000189899930-0x0000000189899970
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D38EB0-0x0000000184D38FD0
	[BlackList] // 0x00000001898A3DC0-0x00000001898A3E00
	// [XID] // 0x00000001898A3DC0-0x00000001898A3E00
	public virtual void ReturnToObjectPool() {} // 0x0000000184D3C730-0x0000000184D3C7D0
	[BlackList] // 0x00000001898AE5D0-0x00000001898AE610
	// [XID] // 0x00000001898AE5D0-0x00000001898AE610
	public virtual void OnPoolAllocated() {} // 0x0000000184D3C460-0x0000000184D3C500
	[BlackList] // 0x00000001898B8CA0-0x00000001898B8CE0
	// [XID] // 0x00000001898B8CA0-0x00000001898B8CE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D3C3C0-0x0000000184D3C460
}

