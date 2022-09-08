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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AvatarCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15202
{
	// Fields
	protected SimpleSafeUInt32 sortIdRawNum; // 0x10
	protected SimpleSafeUInt32 sortFactorRawNum; // 0x14
	protected SimpleSafeUInt32 avatarIdRawNum; // 0x18
	protected string _beginTime; // 0x20

	// Properties
	public uint sortId { /* [XID] */ /* 0x0000000189AD3300-0x0000000189AD3320 */ get => default; /* [XID] */ /* 0x0000000189ADAD80-0x0000000189ADADA0 */ protected set {} } // 0x000000018521DBB0-0x000000018521DC80 0x000000018521DAD0-0x000000018521DBB0
	public uint sortFactor { /* [XID] */ /* 0x0000000189AE2560-0x0000000189AE2580 */ get => default; /* [XID] */ /* 0x0000000189AE9E70-0x0000000189AE9E90 */ protected set {} } // 0x000000018521DC80-0x000000018521DD50 0x000000018521D2C0-0x000000018521D3A0
	public uint avatarId { /* [XID] */ /* 0x0000000189AF1C10-0x0000000189AF1C30 */ get => default; /* [XID] */ /* 0x0000000189AF93D0-0x0000000189AF93F0 */ protected set {} } // 0x000000018521DA00-0x000000018521DAD0 0x000000018521D040-0x000000018521D120
	public string beginTime { /* [XID] */ /* 0x0000000189B00810-0x0000000189B00830 */ get => default; /* [XID] */ /* 0x0000000189B07EF0-0x0000000189B07F10 */ protected set {} } // 0x000000018521DD50-0x000000018521DDF0 0x000000018521DDF0-0x000000018521DEA0

	// Constructors
	public AvatarCodexExcelConfig() {} // 0x000000018521E530-0x000000018521E590

	// Methods
	// [IDTag] // 0x0000000189B0F730-0x0000000189B0F770
	// [XID] // 0x0000000189B0F730-0x0000000189B0F770
	public virtual bool ParseFromLine(string line) => default; // 0x000000018521D3A0-0x000000018521D6F0
	// [IDTag] // 0x0000000189B199B0-0x0000000189B199F0
	// [XID] // 0x0000000189B199B0-0x0000000189B199F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018521D6F0-0x000000018521DA00
	// [XID] // 0x0000000189B24260-0x0000000189B24280
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF03B3 */, bool useObjectPool = false /* Metadata: 0x00AF03B7 */) => default; // 0x000000018521DEA0-0x000000018521E350
	[BlackList] // 0x0000000189B2B5F0-0x0000000189B2B630
	// [XID] // 0x0000000189B2B5F0-0x0000000189B2B630
	public virtual void AutoAllocTypeFields() {} // 0x000000018521D120-0x000000018521D1C0
	[BlackList] // 0x0000000189B358A0-0x0000000189B358E0
	// [XID] // 0x0000000189B358A0-0x0000000189B358E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018521D1C0-0x000000018521D2C0
	[BlackList] // 0x0000000189B40440-0x0000000189B40480
	// [XID] // 0x0000000189B40440-0x0000000189B40480
	public virtual void ReturnToObjectPool() {} // 0x000000018521E490-0x000000018521E530
	[BlackList] // 0x0000000189B4ADF0-0x0000000189B4AE30
	// [XID] // 0x0000000189B4ADF0-0x0000000189B4AE30
	public virtual void OnPoolAllocated() {} // 0x000000018521E3F0-0x000000018521E490
	[BlackList] // 0x0000000189B55570-0x0000000189B555B0
	// [XID] // 0x0000000189B55570-0x0000000189B555B0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018521E350-0x000000018521E3F0
}

