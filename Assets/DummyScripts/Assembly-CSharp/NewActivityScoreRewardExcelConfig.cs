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
public class NewActivityScoreRewardExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15901
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x18
	protected SimpleSafeUInt32 scoreRawNum; // 0x1C
	protected uint _activityScoreTipsTextMapHash; // 0x20
	protected uint _activityScoreExtraTipsTextMapHash; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189828100-0x0000000189828120 */ get => default; /* [XID] */ /* 0x000000018982F360-0x000000018982F380 */ protected set {} } // 0x0000000184B59E70-0x0000000184B59F40 0x0000000184B593A0-0x0000000184B59480
	public uint activityId { /* [XID] */ /* 0x0000000189836C90-0x0000000189836CB0 */ get => default; /* [XID] */ /* 0x000000018983E0C0-0x000000018983E0E0 */ protected set {} } // 0x0000000184B59C60-0x0000000184B59D30 0x0000000184B59070-0x0000000184B59150
	public uint rewardID { /* [XID] */ /* 0x0000000189845890-0x00000001898458B0 */ get => default; /* [XID] */ /* 0x000000018984CE20-0x000000018984CE40 */ protected set {} } // 0x0000000184B58FA0-0x0000000184B59070 0x0000000184B58EC0-0x0000000184B58FA0
	public uint score { /* [XID] */ /* 0x0000000189853F80-0x0000000189853FA0 */ get => default; /* [XID] */ /* 0x000000018985B990-0x000000018985B9B0 */ protected set {} } // 0x0000000184B592D0-0x0000000184B593A0 0x0000000184B581B0-0x0000000184B58290
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint activityScoreTipsTextMapHash { /* [XID] */ /* 0x0000000189862F90-0x0000000189862FB0 */ get => default; /* [XID] */ /* 0x000000018986A3E0-0x000000018986A400 */ protected set {} } // 0x0000000184B59A70-0x0000000184B59B10 0x0000000184B58C90-0x0000000184B58D40
	public string activityScoreTips { /* [XID] */ /* 0x0000000189871810-0x0000000189871830 */ get => default; } // 0x0000000184B59150-0x0000000184B592D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint activityScoreExtraTipsTextMapHash { /* [XID] */ /* 0x00000001898790D0-0x00000001898790F0 */ get => default; /* [XID] */ /* 0x0000000189880680-0x00000001898806A0 */ protected set {} } // 0x0000000184B59BC0-0x0000000184B59C60 0x0000000184B59B10-0x0000000184B59BC0
	public string activityScoreExtraTips { /* [XID] */ /* 0x0000000189887C20-0x0000000189887C40 */ get => default; } // 0x0000000184B58D40-0x0000000184B58EC0 

	// Constructors
	public NewActivityScoreRewardExcelConfig() {} // 0x0000000184B59FE0-0x0000000184B5A040

	// Methods
	// [IDTag] // 0x000000018988EF80-0x000000018988EFC0
	// [XID] // 0x000000018988EF80-0x000000018988EFC0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B58440-0x0000000184B58880
	// [IDTag] // 0x0000000189899710-0x0000000189899750
	// [XID] // 0x0000000189899710-0x0000000189899750
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B58880-0x0000000184B58C90
	// [XID] // 0x00000001898A3B80-0x00000001898A3BA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2AAA */, bool useObjectPool = false /* Metadata: 0x00AF2AAE */) => default; // 0x0000000184B59480-0x0000000184B59A70
	[BlackList] // 0x00000001898AAE60-0x00000001898AAEA0
	// [XID] // 0x00000001898AAE60-0x00000001898AAEA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B58290-0x0000000184B58330
	[BlackList] // 0x00000001898B5890-0x00000001898B58D0
	// [XID] // 0x00000001898B5890-0x00000001898B58D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B58330-0x0000000184B58440
	[BlackList] // 0x00000001898C00E0-0x00000001898C0120
	// [XID] // 0x00000001898C00E0-0x00000001898C0120
	public virtual void ReturnToObjectPool() {} // 0x0000000184B59F40-0x0000000184B59FE0
	[BlackList] // 0x00000001898CA9C0-0x00000001898CAA00
	// [XID] // 0x00000001898CA9C0-0x00000001898CAA00
	public virtual void OnPoolAllocated() {} // 0x0000000184B59DD0-0x0000000184B59E70
	[BlackList] // 0x00000001898D5210-0x00000001898D5250
	// [XID] // 0x00000001898D5210-0x00000001898D5250
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B59D30-0x0000000184B59DD0
}

