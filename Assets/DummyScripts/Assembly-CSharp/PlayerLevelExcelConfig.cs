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
public class PlayerLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14884
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 levelRawNum; // 0x14
	protected SimpleSafeUInt32 expRawNum; // 0x18
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x1C
	protected SimpleSafeUInt32 expeditionLimitAddRawNum; // 0x20
	protected SimpleSafeUInt32 unlockWorldLevelRawNum; // 0x24
	protected uint _unlockDescTextMapHash; // 0x28

	// Properties
	public uint maxExp { /* [XID] */ /* 0x00000001898B1380-0x00000001898B13C0 */ get; /* [XID] */ /* 0x00000001898BBCF0-0x00000001898BBD30 */ set; } // 0x0000000180B26A50-0x0000000180B26AB0 0x0000000180B26CD0-0x0000000180B26D30
	public uint level { /* [XID] */ /* 0x00000001898C60F0-0x00000001898C6110 */ get => default; /* [XID] */ /* 0x00000001898CD8C0-0x00000001898CD8E0 */ protected set {} } // 0x0000000180B27740-0x0000000180B27810 0x0000000180B27660-0x0000000180B27740
	public uint exp { /* [XID] */ /* 0x00000001898D53B0-0x00000001898D53D0 */ get => default; /* [XID] */ /* 0x00000001898DCCF0-0x00000001898DCD10 */ protected set {} } // 0x0000000180B27810-0x0000000180B278E0 0x0000000180B26EC0-0x0000000180B26FA0
	public uint rewardId { /* [XID] */ /* 0x00000001898E4720-0x00000001898E4740 */ get => default; /* [XID] */ /* 0x00000001898EC0F0-0x00000001898EC110 */ protected set {} } // 0x0000000180B27590-0x0000000180B27660 0x0000000180B25E40-0x0000000180B25F20
	public uint expeditionLimitAdd { /* [XID] */ /* 0x00000001898F3940-0x00000001898F3960 */ get => default; /* [XID] */ /* 0x00000001898FB040-0x00000001898FB060 */ protected set {} } // 0x0000000180B27AF0-0x0000000180B27BC0 0x0000000180B26D30-0x0000000180B26E10
	public uint unlockWorldLevel { /* [XID] */ /* 0x0000000189902B40-0x0000000189902B60 */ get => default; /* [XID] */ /* 0x000000018990A1A0-0x000000018990A1C0 */ protected set {} } // 0x0000000180B27A20-0x0000000180B27AF0 0x0000000180B26120-0x0000000180B26200
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockDescTextMapHash { /* [XID] */ /* 0x0000000189911B80-0x0000000189911BA0 */ get => default; /* [XID] */ /* 0x0000000189919660-0x0000000189919680 */ protected set {} } // 0x0000000180B26C30-0x0000000180B26CD0 0x0000000180B26E10-0x0000000180B26EC0
	public string unlockDesc { /* [XID] */ /* 0x0000000189920B30-0x0000000189920B50 */ get => default; } // 0x0000000180B26AB0-0x0000000180B26C30 

	// Constructors
	public PlayerLevelExcelConfig() {} // 0x0000000180B27C60-0x0000000180B27CC0

	// Methods
	// [IDTag] // 0x00000001899285B0-0x00000001899285F0
	// [XID] // 0x00000001899285B0-0x00000001899285F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000180B26200-0x0000000180B26640
	// [IDTag] // 0x0000000189932BC0-0x0000000189932C00
	// [XID] // 0x0000000189932BC0-0x0000000189932C00
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000180B26640-0x0000000180B26A50
	// [XID] // 0x000000018993D3B0-0x000000018993D3D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF8E5 */, bool useObjectPool = false /* Metadata: 0x00AEF8E9 */) => default; // 0x0000000180B26FA0-0x0000000180B27590
	[BlackList] // 0x0000000189944A60-0x0000000189944AA0
	// [XID] // 0x0000000189944A60-0x0000000189944AA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000180B25F20-0x0000000180B25FC0
	[BlackList] // 0x000000018994EF60-0x000000018994EFA0
	// [XID] // 0x000000018994EF60-0x000000018994EFA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180B25FC0-0x0000000180B26120
	[BlackList] // 0x0000000189959610-0x0000000189959650
	// [XID] // 0x0000000189959610-0x0000000189959650
	public virtual void ReturnToObjectPool() {} // 0x0000000180B27BC0-0x0000000180B27C60
	[BlackList] // 0x0000000189963F40-0x0000000189963F80
	// [XID] // 0x0000000189963F40-0x0000000189963F80
	public virtual void OnPoolAllocated() {} // 0x0000000180B27980-0x0000000180B27A20
	[BlackList] // 0x000000018996E380-0x000000018996E3C0
	// [XID] // 0x000000018996E380-0x000000018996E3C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180B278E0-0x0000000180B27980
}

