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
public class ChannellerSlabLoopDungeonConditionExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15050
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _descTextMapHash; // 0x14
	protected ChannellerSlabCondition _conditionType; // 0x18
	protected string _icon; // 0x20
	protected SimpleSafeUInt32 conditionParam1RawNum; // 0x28
	protected SimpleSafeUInt32 conditionParam2RawNum; // 0x2C
	protected SimpleSafeUInt32 exclusiveIdRawNum; // 0x30
	protected SimpleSafeInt32 scoreRawNum; // 0x34

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189620CE0-0x0000000189620D00 */ get => default; /* [XID] */ /* 0x0000000189628310-0x0000000189628330 */ protected set {} } // 0x0000000183A0D650-0x0000000183A0D720 0x0000000183A0CAC0-0x0000000183A0CBA0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018962FC20-0x000000018962FC40 */ get => default; /* [XID] */ /* 0x00000001896377E0-0x0000000189637800 */ protected set {} } // 0x0000000183A0D3C0-0x0000000183A0D460 0x0000000183A0B9A0-0x0000000183A0BA50
	public string desc { /* [XID] */ /* 0x000000018963EC80-0x000000018963ECA0 */ get => default; } // 0x0000000183A0C7C0-0x0000000183A0C940 
	public ChannellerSlabCondition conditionType { /* [XID] */ /* 0x0000000189646480-0x00000001896464A0 */ get => default; /* [XID] */ /* 0x000000018964DCA0-0x000000018964DCC0 */ protected set {} } // 0x0000000183A0C720-0x0000000183A0C7C0 0x0000000183A0C940-0x0000000183A0C9F0
	public string icon { /* [XID] */ /* 0x00000001896554E0-0x0000000189655500 */ get => default; /* [XID] */ /* 0x000000018965CC80-0x000000018965CCA0 */ protected set {} } // 0x0000000183A0B640-0x0000000183A0B6E0 0x0000000183A0D460-0x0000000183A0D510
	public uint conditionParam1 { /* [XID] */ /* 0x00000001896641C0-0x00000001896641E0 */ get => default; /* [XID] */ /* 0x000000018966B860-0x000000018966B880 */ protected set {} } // 0x0000000183A0C4A0-0x0000000183A0C570 0x0000000183A0C640-0x0000000183A0C720
	public uint conditionParam2 { /* [XID] */ /* 0x0000000189673600-0x0000000189673620 */ get => default; /* [XID] */ /* 0x000000018967AEA0-0x000000018967AEC0 */ protected set {} } // 0x0000000183A0C570-0x0000000183A0C640 0x0000000183A0B480-0x0000000183A0B560
	public uint exclusiveId { /* [XID] */ /* 0x00000001896826F0-0x0000000189682710 */ get => default; /* [XID] */ /* 0x000000018968A1B0-0x000000018968A1D0 */ protected set {} } // 0x0000000183A0B8D0-0x0000000183A0B9A0 0x0000000183A0D2E0-0x0000000183A0D3C0
	public int score { /* [XID] */ /* 0x0000000189691F90-0x0000000189691FB0 */ get => default; /* [XID] */ /* 0x00000001896994A0-0x00000001896994C0 */ protected set {} } // 0x0000000183A0C9F0-0x0000000183A0CAC0 0x0000000183A0B560-0x0000000183A0B640

	// Constructors
	public ChannellerSlabLoopDungeonConditionExcelConfig() {} // 0x0000000183A0D7C0-0x0000000183A0D820

	// Methods
	// [IDTag] // 0x00000001896A08F0-0x00000001896A0930
	// [XID] // 0x00000001896A08F0-0x00000001896A0930
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183A0BF70-0x0000000183A0C4A0
	// [IDTag] // 0x00000001896AACD0-0x00000001896AAD10
	// [XID] // 0x00000001896AACD0-0x00000001896AAD10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183A0BA50-0x0000000183A0BF70
	// [XID] // 0x00000001896B5350-0x00000001896B5370
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF69 */, bool useObjectPool = false /* Metadata: 0x00AEFF6D */) => default; // 0x0000000183A0CBA0-0x0000000183A0D2E0
	[BlackList] // 0x00000001896BC540-0x00000001896BC580
	// [XID] // 0x00000001896BC540-0x00000001896BC580
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A0B6E0-0x0000000183A0B780
	[BlackList] // 0x00000001896C6B10-0x00000001896C6B50
	// [XID] // 0x00000001896C6B10-0x00000001896C6B50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A0B780-0x0000000183A0B8D0
	[BlackList] // 0x00000001896D0F00-0x00000001896D0F40
	// [XID] // 0x00000001896D0F00-0x00000001896D0F40
	public virtual void ReturnToObjectPool() {} // 0x0000000183A0D720-0x0000000183A0D7C0
	[BlackList] // 0x00000001896DB560-0x00000001896DB5A0
	// [XID] // 0x00000001896DB560-0x00000001896DB5A0
	public virtual void OnPoolAllocated() {} // 0x0000000183A0D5B0-0x0000000183A0D650
	[BlackList] // 0x00000001896E5930-0x00000001896E5970
	// [XID] // 0x00000001896E5930-0x00000001896E5970
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A0D510-0x0000000183A0D5B0
}

