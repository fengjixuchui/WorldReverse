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
public class MechanicusWatcherExcelConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 16219
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 reward_tokensRawNum; // 0x28
	protected uint _descTextMapHash; // 0x2C

	// Properties
	public uint reward_tokens { /* [XID] */ /* 0x0000000189B124E0-0x0000000189B12500 */ get => default; /* [XID] */ /* 0x0000000189B19770-0x0000000189B19790 */ protected set {} } // 0x0000000181E8E5C0-0x0000000181E8E690 0x0000000181E8DB80-0x0000000181E8DC60
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189B20E70-0x0000000189B20E90 */ get => default; /* [XID] */ /* 0x0000000189B28530-0x0000000189B28550 */ protected set {} } // 0x0000000181E8E4C0-0x0000000181E8E560 0x0000000181E8D250-0x0000000181E8D300
	public string desc { /* [XID] */ /* 0x0000000189B2F8F0-0x0000000189B2F910 */ get => default; } // 0x0000000181E8DC60-0x0000000181E8DDE0 

	// Constructors
	public MechanicusWatcherExcelConfig() {} // 0x0000000181E8E730-0x0000000181E8E790

	// Methods
	// [IDTag] // 0x0000000189B371F0-0x0000000189B37230
	// [XID] // 0x0000000189B371F0-0x0000000189B37230
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181E8D360-0x0000000181E8D7B0
	// [IDTag] // 0x0000000189B41D70-0x0000000189B41DB0
	// [XID] // 0x0000000189B41D70-0x0000000189B41DB0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181E8D7B0-0x0000000181E8DB80
	// [XID] // 0x0000000189B4C580-0x0000000189B4C5A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34AA */, bool useObjectPool = false /* Metadata: 0x00AF34AE */) => default; // 0x0000000181E8DED0-0x0000000181E8E4C0
	[BlackList] // 0x0000000189B53B20-0x0000000189B53B60
	// [XID] // 0x0000000189B53B20-0x0000000189B53B60
	public override void AutoAllocTypeFields() {} // 0x0000000181E8D030-0x0000000181E8D0D0
	[BlackList] // 0x0000000189B5E600-0x0000000189B5E640
	// [XID] // 0x0000000189B5E600-0x0000000189B5E640
	public override void AutoRecycleTypeFields() {} // 0x0000000181E8D0D0-0x0000000181E8D1B0
	[BlackList] // 0x0000000189B68D00-0x0000000189B68D40
	// [XID] // 0x0000000189B68D00-0x0000000189B68D40
	public override void ReturnToObjectPool() {} // 0x0000000181E8E690-0x0000000181E8E730
}

