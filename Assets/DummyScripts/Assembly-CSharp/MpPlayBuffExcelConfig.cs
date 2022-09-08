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
public class MpPlayBuffExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15871
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected string _icon; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B65C00-0x0000000189B65C20 */ get => default; /* [XID] */ /* 0x0000000189B6D200-0x0000000189B6D220 */ protected set {} } // 0x000000018227F360-0x000000018227F430 0x000000018227EA90-0x000000018227EB70
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B74870-0x0000000189B74890 */ get => default; /* [XID] */ /* 0x0000000189B7BE90-0x0000000189B7BEB0 */ protected set {} } // 0x000000018227E160-0x000000018227E200 0x000000018227F0C0-0x000000018227F170
	public string name { /* [XID] */ /* 0x0000000189B837E0-0x0000000189B83800 */ get => default; } // 0x000000018227F430-0x000000018227F5B0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B8AB30-0x0000000189B8AB50 */ get => default; /* [XID] */ /* 0x0000000189B921A0-0x0000000189B921C0 */ protected set {} } // 0x000000018227F020-0x000000018227F0C0 0x000000018227E200-0x000000018227E2B0
	public string desc { /* [XID] */ /* 0x0000000189B996E0-0x0000000189B99700 */ get => default; } // 0x000000018227E910-0x000000018227EA90 
	public string icon { /* [XID] */ /* 0x0000000189BA0D10-0x0000000189BA0D30 */ get => default; /* [XID] */ /* 0x0000000189BA8390-0x0000000189BA83B0 */ protected set {} } // 0x000000018227DF40-0x000000018227DFE0 0x000000018227F170-0x000000018227F220

	// Constructors
	public MpPlayBuffExcelConfig() {} // 0x000000018227F650-0x000000018227F6B0

	// Methods
	// [IDTag] // 0x0000000189BAF820-0x0000000189BAF860
	// [XID] // 0x0000000189BAF820-0x0000000189BAF860
	public virtual bool ParseFromLine(string line) => default; // 0x000000018227E5C0-0x000000018227E910
	// [IDTag] // 0x0000000189BB9D00-0x0000000189BB9D40
	// [XID] // 0x0000000189BB9D00-0x0000000189BB9D40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018227E2B0-0x000000018227E5C0
	// [XID] // 0x0000000189BC49E0-0x0000000189BC4A00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF28FB */, bool useObjectPool = false /* Metadata: 0x00AF28FF */) => default; // 0x000000018227EB70-0x000000018227F020
	[BlackList] // 0x0000000189BCC400-0x0000000189BCC440
	// [XID] // 0x0000000189BCC400-0x0000000189BCC440
	public virtual void AutoAllocTypeFields() {} // 0x000000018227DFE0-0x000000018227E080
	[BlackList] // 0x0000000189BD6740-0x0000000189BD6780
	// [XID] // 0x0000000189BD6740-0x0000000189BD6780
	public virtual void AutoRecycleTypeFields() {} // 0x000000018227E080-0x000000018227E160
	[BlackList] // 0x00000001895E6390-0x00000001895E63D0
	// [XID] // 0x00000001895E6390-0x00000001895E63D0
	public virtual void ReturnToObjectPool() {} // 0x000000018227F5B0-0x000000018227F650
	[BlackList] // 0x00000001895F0D40-0x00000001895F0D80
	// [XID] // 0x00000001895F0D40-0x00000001895F0D80
	public virtual void OnPoolAllocated() {} // 0x000000018227F2C0-0x000000018227F360
	[BlackList] // 0x00000001895FB5B0-0x00000001895FB5F0
	// [XID] // 0x00000001895FB5B0-0x00000001895FB5F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018227F220-0x000000018227F2C0
}

