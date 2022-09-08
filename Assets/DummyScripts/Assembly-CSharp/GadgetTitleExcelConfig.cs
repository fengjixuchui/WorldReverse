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
public class GadgetTitleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15649
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 gadgetIdRawNum; // 0x10
	protected uint _titleTextMapHash; // 0x14

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x0000000189AFAAE0-0x0000000189AFAB00 */ get => default; /* [XID] */ /* 0x0000000189B020B0-0x0000000189B020D0 */ protected set {} } // 0x00000001832657F0-0x00000001832658C0 0x0000000183265710-0x00000001832657F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189B094F0-0x0000000189B09510 */ get => default; /* [XID] */ /* 0x0000000189B11030-0x0000000189B11050 */ protected set {} } // 0x0000000183265130-0x00000001832651D0 0x00000001832651D0-0x0000000183265280
	public string title { /* [XID] */ /* 0x0000000189B182C0-0x0000000189B182E0 */ get => default; } // 0x0000000183265C20-0x0000000183265DA0 

	// Constructors
	public GadgetTitleExcelConfig() {} // 0x0000000183265F80-0x0000000183265FE0

	// Methods
	// [IDTag] // 0x0000000189B1F960-0x0000000189B1F9A0
	// [XID] // 0x0000000189B1F960-0x0000000189B1F9A0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183265280-0x00000001832654F0
	// [IDTag] // 0x0000000189B29F00-0x0000000189B29F40
	// [XID] // 0x0000000189B29F00-0x0000000189B29F40
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001832654F0-0x0000000183265710
	// [XID] // 0x0000000189B34180-0x0000000189B341A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF21AC */, bool useObjectPool = false /* Metadata: 0x00AF21B0 */) => default; // 0x00000001832658C0-0x0000000183265C20
	[BlackList] // 0x0000000189B3BB90-0x0000000189B3BBD0
	// [XID] // 0x0000000189B3BB90-0x0000000189B3BBD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183264FC0-0x0000000183265060
	[BlackList] // 0x0000000189B466A0-0x0000000189B466E0
	// [XID] // 0x0000000189B466A0-0x0000000189B466E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183265060-0x0000000183265130
	[BlackList] // 0x0000000189B50EA0-0x0000000189B50EE0
	// [XID] // 0x0000000189B50EA0-0x0000000189B50EE0
	public virtual void ReturnToObjectPool() {} // 0x0000000183265EE0-0x0000000183265F80
	[BlackList] // 0x0000000189B5B590-0x0000000189B5B5D0
	// [XID] // 0x0000000189B5B590-0x0000000189B5B5D0
	public virtual void OnPoolAllocated() {} // 0x0000000183265E40-0x0000000183265EE0
	[BlackList] // 0x0000000189B65C60-0x0000000189B65CA0
	// [XID] // 0x0000000189B65C60-0x0000000189B65CA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183265DA0-0x0000000183265E40
}

