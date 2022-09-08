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
public class BattlePassStoryExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15255
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _storyUnlockLevel; // 0x18
	protected SimpleSafeUInt32[] _storyId; // 0x20
	protected uint[] _storyTitle; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x000000018986BC80-0x000000018986BCA0 */ get => default; /* [XID] */ /* 0x0000000189873010-0x0000000189873030 */ protected set {} } // 0x0000000184A2EB70-0x0000000184A2EC40 0x0000000184A2DF40-0x0000000184A2E020
	public SimpleSafeUInt32[] storyUnlockLevel { /* [XID] */ /* 0x000000018987AD30-0x000000018987AD50 */ get => default; /* [XID] */ /* 0x0000000189881C80-0x0000000189881CA0 */ protected set {} } // 0x0000000184A2D0D0-0x0000000184A2D170 0x0000000184A2E4D0-0x0000000184A2E580
	public SimpleSafeUInt32[] storyId { /* [XID] */ /* 0x0000000189889440-0x0000000189889460 */ get => default; /* [XID] */ /* 0x0000000189890800-0x0000000189890820 */ protected set {} } // 0x0000000184A2DEA0-0x0000000184A2DF40 0x0000000184A2DDF0-0x0000000184A2DEA0
	public uint[] storyTitle { /* [XID] */ /* 0x0000000189897D60-0x0000000189897D80 */ get => default; /* [XID] */ /* 0x000000018989F100-0x000000018989F120 */ protected set {} } // 0x0000000184A2E990-0x0000000184A2EA30 0x0000000184A2E8E0-0x0000000184A2E990
	public string[] storyTitleLocalized { /* [XID] */ /* 0x00000001898A6C60-0x00000001898A6C80 */ get => default; } // 0x0000000184A2E580-0x0000000184A2E8E0 

	// Constructors
	public BattlePassStoryExcelConfig() {} // 0x0000000184A2ECE0-0x0000000184A2ED40

	// Methods
	// [IDTag] // 0x00000001898AE470-0x00000001898AE4B0
	// [XID] // 0x00000001898AE470-0x00000001898AE4B0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184A2D790-0x0000000184A2DDF0
	// [IDTag] // 0x00000001898B8B80-0x00000001898B8BC0
	// [XID] // 0x00000001898B8B80-0x00000001898B8BC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184A2D170-0x0000000184A2D790
	// [XID] // 0x00000001898C3160-0x00000001898C3180
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0555 */, bool useObjectPool = false /* Metadata: 0x00AF0559 */) => default; // 0x0000000184A2E020-0x0000000184A2E4D0
	[BlackList] // 0x00000001898CAB40-0x00000001898CAB80
	// [XID] // 0x00000001898CAB40-0x00000001898CAB80
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A2CF50-0x0000000184A2CFF0
	[BlackList] // 0x00000001898D52B0-0x00000001898D52F0
	// [XID] // 0x00000001898D52B0-0x00000001898D52F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A2CFF0-0x0000000184A2D0D0
	[BlackList] // 0x00000001898DFFE0-0x00000001898E0020
	// [XID] // 0x00000001898DFFE0-0x00000001898E0020
	public virtual void ReturnToObjectPool() {} // 0x0000000184A2EC40-0x0000000184A2ECE0
	[BlackList] // 0x00000001898EAA90-0x00000001898EAAD0
	// [XID] // 0x00000001898EAA90-0x00000001898EAAD0
	public virtual void OnPoolAllocated() {} // 0x0000000184A2EAD0-0x0000000184A2EB70
	[BlackList] // 0x00000001898F50E0-0x00000001898F5120
	// [XID] // 0x00000001898F50E0-0x00000001898F5120
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A2EA30-0x0000000184A2EAD0
}

