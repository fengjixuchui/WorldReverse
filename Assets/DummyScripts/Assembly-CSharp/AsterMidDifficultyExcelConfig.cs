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
public class AsterMidDifficultyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15019
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _world_level_vec; // 0x18
	protected SimpleSafeUInt32 drop_idRawNum; // 0x20
	protected SimpleSafeUInt32 reward_idRawNum; // 0x24
	protected SimpleSafeUInt32 resinRawNum; // 0x28
	protected SimpleSafeUInt16 recommendLevelRawNum; // 0x2C
	protected SimpleSafeUInt32 monsterLevelRawNum; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x000000018969C380-0x000000018969C3A0 */ get => default; /* [XID] */ /* 0x00000001896A3860-0x00000001896A3880 */ protected set {} } // 0x000000018334E900-0x000000018334E9D0 0x000000018334D970-0x000000018334DA50
	public SimpleSafeUInt32[] world_level_vec { /* [XID] */ /* 0x00000001896AAD10-0x00000001896AAD30 */ get => default; /* [XID] */ /* 0x00000001896B1D30-0x00000001896B1D50 */ protected set {} } // 0x000000018334CB10-0x000000018334CBB0 0x000000018334D8C0-0x000000018334D970
	public uint drop_id { /* [XID] */ /* 0x00000001896B97D0-0x00000001896B97F0 */ get => default; /* [XID] */ /* 0x00000001896C0AE0-0x00000001896C0B00 */ protected set {} } // 0x000000018334C970-0x000000018334CA40 0x000000018334E530-0x000000018334E610
	public uint reward_id { /* [XID] */ /* 0x00000001896C81D0-0x00000001896C81F0 */ get => default; /* [XID] */ /* 0x00000001896CFB30-0x00000001896CFB50 */ protected set {} } // 0x000000018334E610-0x000000018334E6E0 0x000000018334E6E0-0x000000018334E7C0
	public uint resin { /* [XID] */ /* 0x00000001896D6DE0-0x00000001896D6E00 */ get => default; /* [XID] */ /* 0x00000001896DE540-0x00000001896DE560 */ protected set {} } // 0x000000018334DA50-0x000000018334DB20 0x000000018334E450-0x000000018334E530
	public ushort recommendLevel { /* [XID] */ /* 0x00000001896E5970-0x00000001896E5990 */ get => default; /* [XID] */ /* 0x00000001896ECFC0-0x00000001896ECFE0 */ protected set {} } // 0x000000018334CA40-0x000000018334CB10 0x000000018334E1C0-0x000000018334E2A0
	public uint monsterLevel { /* [XID] */ /* 0x00000001896F4880-0x00000001896F48A0 */ get => default; /* [XID] */ /* 0x00000001896FC070-0x00000001896FC090 */ protected set {} } // 0x000000018334E380-0x000000018334E450 0x000000018334E2A0-0x000000018334E380

	// Constructors
	public AsterMidDifficultyExcelConfig() {} // 0x000000018334EA70-0x000000018334EAD0

	// Methods
	// [IDTag] // 0x0000000189703650-0x0000000189703690
	// [XID] // 0x0000000189703650-0x0000000189703690
	public virtual bool ParseFromLine(string line) => default; // 0x000000018334D230-0x000000018334D8C0
	// [IDTag] // 0x000000018970DDB0-0x000000018970DDF0
	// [XID] // 0x000000018970DDB0-0x000000018970DDF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018334CBB0-0x000000018334D230
	// [XID] // 0x0000000189718390-0x00000001897183B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFEA3 */, bool useObjectPool = false /* Metadata: 0x00AEFEA7 */) => default; // 0x000000018334DB20-0x000000018334E1C0
	[BlackList] // 0x000000018971FD10-0x000000018971FD50
	// [XID] // 0x000000018971FD10-0x000000018971FD50
	public virtual void AutoAllocTypeFields() {} // 0x000000018334C770-0x000000018334C810
	[BlackList] // 0x000000018972A100-0x000000018972A140
	// [XID] // 0x000000018972A100-0x000000018972A140
	public virtual void AutoRecycleTypeFields() {} // 0x000000018334C810-0x000000018334C970
	[BlackList] // 0x0000000189734850-0x0000000189734890
	// [XID] // 0x0000000189734850-0x0000000189734890
	public virtual void ReturnToObjectPool() {} // 0x000000018334E9D0-0x000000018334EA70
	[BlackList] // 0x000000018973F660-0x000000018973F6A0
	// [XID] // 0x000000018973F660-0x000000018973F6A0
	public virtual void OnPoolAllocated() {} // 0x000000018334E860-0x000000018334E900
	[BlackList] // 0x0000000189749B80-0x0000000189749BC0
	// [XID] // 0x0000000189749B80-0x0000000189749BC0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018334E7C0-0x000000018334E860
}

