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
public class BattlePassLevelExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15251
{
	// Fields
	protected SimpleSafeUInt32 levelRawNum; // 0x10
	protected SimpleSafeUInt32 levelUpNeedPointRawNum; // 0x14

	// Properties
	public uint level { /* [XID] */ /* 0x0000000189614F20-0x0000000189614F40 */ get => default; /* [XID] */ /* 0x000000018961C6A0-0x000000018961C6C0 */ protected set {} } // 0x00000001827805E0-0x00000001827806B0 0x0000000182780500-0x00000001827805E0
	public uint levelUpNeedPoint { /* [XID] */ /* 0x0000000189623B40-0x0000000189623B60 */ get => default; /* [XID] */ /* 0x000000018962B360-0x000000018962B380 */ protected set {} } // 0x00000001827800D0-0x00000001827801A0 0x000000018277FFF0-0x00000001827800D0

	// Constructors
	public BattlePassLevelExcelConfig() {} // 0x0000000182780890-0x00000001827808F0

	// Methods
	// [IDTag] // 0x0000000189632B00-0x0000000189632B40
	// [XID] // 0x0000000189632B00-0x0000000189632B40
	public virtual bool ParseFromLine(string line) => default; // 0x000000018277FD80-0x000000018277FFF0
	// [IDTag] // 0x000000018963D6B0-0x000000018963D6F0
	// [XID] // 0x000000018963D6B0-0x000000018963D6F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018277FB60-0x000000018277FD80
	// [XID] // 0x0000000189647B90-0x0000000189647BB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF053C */, bool useObjectPool = false /* Metadata: 0x00AF0540 */) => default; // 0x00000001827801A0-0x0000000182780500
	[BlackList] // 0x000000018964F260-0x000000018964F2A0
	// [XID] // 0x000000018964F260-0x000000018964F2A0
	public virtual void AutoAllocTypeFields() {} // 0x000000018277F9E0-0x000000018277FA80
	[BlackList] // 0x0000000189659A50-0x0000000189659A90
	// [XID] // 0x0000000189659A50-0x0000000189659A90
	public virtual void AutoRecycleTypeFields() {} // 0x000000018277FA80-0x000000018277FB60
	[BlackList] // 0x0000000189664160-0x00000001896641A0
	// [XID] // 0x0000000189664160-0x00000001896641A0
	public virtual void ReturnToObjectPool() {} // 0x00000001827807F0-0x0000000182780890
	[BlackList] // 0x000000018966EC60-0x000000018966ECA0
	// [XID] // 0x000000018966EC60-0x000000018966ECA0
	public virtual void OnPoolAllocated() {} // 0x0000000182780750-0x00000001827807F0
	[BlackList] // 0x0000000189679970-0x00000001896799B0
	// [XID] // 0x0000000189679970-0x00000001896799B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001827806B0-0x0000000182780750
}

