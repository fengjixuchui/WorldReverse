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
public class ChannellerSlabDungeonExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15043
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 stageIDRawNum; // 0x10
	protected SimpleSafeUInt32 dungeonIDRawNum; // 0x14
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x18
	protected SimpleSafeUInt32 pointIDRawNum; // 0x1C
	protected SimpleSafeFloat[] _pos; // 0x20
	protected uint _titleTextMapHash; // 0x28
	protected uint _descTextMapHash; // 0x2C

	// Properties
	public uint stageID { /* [XID] */ /* 0x00000001896C6B50-0x00000001896C6B70 */ get => default; /* [XID] */ /* 0x00000001896CE250-0x00000001896CE270 */ protected set {} } // 0x00000001829C2570-0x00000001829C2640 0x00000001829C45E0-0x00000001829C46C0
	public uint dungeonID { /* [XID] */ /* 0x00000001896D5800-0x00000001896D5820 */ get => default; /* [XID] */ /* 0x00000001896DCC20-0x00000001896DCC40 */ protected set {} } // 0x00000001829C42F0-0x00000001829C43C0 0x00000001829C3B80-0x00000001829C3C60
	public uint rewardID { /* [XID] */ /* 0x00000001896E45F0-0x00000001896E4610 */ get => default; /* [XID] */ /* 0x00000001896EBA40-0x00000001896EBA60 */ protected set {} } // 0x00000001829C37B0-0x00000001829C3880 0x00000001829C36D0-0x00000001829C37B0
	public uint pointID { /* [XID] */ /* 0x00000001896F2F70-0x00000001896F2F90 */ get => default; /* [XID] */ /* 0x00000001896FA7B0-0x00000001896FA7D0 */ protected set {} } // 0x00000001829C3600-0x00000001829C36D0 0x00000001829C3880-0x00000001829C3960
	public SimpleSafeFloat[] pos { /* [XID] */ /* 0x0000000189701E40-0x0000000189701E60 */ get => default; /* [XID] */ /* 0x00000001897096E0-0x0000000189709700 */ protected set {} } // 0x00000001829C3960-0x00000001829C3A00 0x00000001829C2640-0x00000001829C26F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189710F90-0x0000000189710FB0 */ get => default; /* [XID] */ /* 0x0000000189718370-0x0000000189718390 */ protected set {} } // 0x00000001829C26F0-0x00000001829C2790 0x00000001829C2840-0x00000001829C28F0
	public string title { /* [XID] */ /* 0x000000018971FCF0-0x000000018971FD10 */ get => default; } // 0x00000001829C4460-0x00000001829C45E0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001897273C0-0x00000001897273E0 */ get => default; /* [XID] */ /* 0x000000018972E930-0x000000018972E950 */ protected set {} } // 0x00000001829C43C0-0x00000001829C4460 0x00000001829C2790-0x00000001829C2840
	public string desc { /* [XID] */ /* 0x00000001897360A0-0x00000001897360C0 */ get => default; } // 0x00000001829C3A00-0x00000001829C3B80 

	// Constructors
	public ChannellerSlabDungeonExcelConfig() {} // 0x00000001829C48A0-0x00000001829C4900

	// Methods
	// [IDTag] // 0x000000018973DD70-0x000000018973DDB0
	// [XID] // 0x000000018973DD70-0x000000018973DDB0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001829C2F70-0x00000001829C3600
	// [IDTag] // 0x0000000189748260-0x00000001897482A0
	// [XID] // 0x0000000189748260-0x00000001897482A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001829C28F0-0x00000001829C2F70
	// [XID] // 0x00000001897526D0-0x00000001897526F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF46 */, bool useObjectPool = false /* Metadata: 0x00AEFF4A */) => default; // 0x00000001829C3C60-0x00000001829C42F0
	[BlackList] // 0x0000000189759C60-0x0000000189759CA0
	// [XID] // 0x0000000189759C60-0x0000000189759CA0
	public virtual void AutoAllocTypeFields() {} // 0x00000001829C23C0-0x00000001829C2460
	[BlackList] // 0x00000001897644C0-0x0000000189764500
	// [XID] // 0x00000001897644C0-0x0000000189764500
	public virtual void AutoRecycleTypeFields() {} // 0x00000001829C2460-0x00000001829C2570
	[BlackList] // 0x000000018976EAA0-0x000000018976EAE0
	// [XID] // 0x000000018976EAA0-0x000000018976EAE0
	public virtual void ReturnToObjectPool() {} // 0x00000001829C4800-0x00000001829C48A0
	[BlackList] // 0x0000000189779400-0x0000000189779440
	// [XID] // 0x0000000189779400-0x0000000189779440
	public virtual void OnPoolAllocated() {} // 0x00000001829C4760-0x00000001829C4800
	[BlackList] // 0x0000000189783D30-0x0000000189783D70
	// [XID] // 0x0000000189783D30-0x0000000189783D70
	public virtual void OnBeforePoolRecycled() {} // 0x00000001829C46C0-0x00000001829C4760
}

