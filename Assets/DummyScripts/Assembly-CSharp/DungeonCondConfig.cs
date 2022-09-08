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
public class DungeonCondConfig : IAutoAllocRecycle // TypeDefIndex: 15548
{
	// Fields
	protected DungeonCondType _condType; // 0x10
	protected SimpleSafeInt32[] _param; // 0x18

	// Properties
	public DungeonCondType condType { /* [XID] */ /* 0x0000000189823590-0x00000001898235B0 */ get => default; /* [XID] */ /* 0x000000018982AF90-0x000000018982AFB0 */ protected set {} } // 0x0000000183788760-0x0000000183788800 0x0000000183787EB0-0x0000000183787F60
	public SimpleSafeInt32[] param { /* [XID] */ /* 0x0000000189832570-0x0000000189832590 */ get => default; /* [XID] */ /* 0x0000000189839B20-0x0000000189839B40 */ protected set {} } // 0x00000001837889F0-0x0000000183788A90 0x0000000183788940-0x00000001837889F0

	// Constructors
	public DungeonCondConfig() {} // 0x0000000183788B30-0x0000000183788B90

	// Methods
	// [XID] // 0x0000000189841020-0x0000000189841040
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001837880A0-0x00000001837883F0
	// [XID] // 0x00000001898484A0-0x00000001898484C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1EC6 */, bool useObjectPool = false /* Metadata: 0x00AF1ECA */) => default; // 0x00000001837883F0-0x0000000183788760
	[BlackList] // 0x000000018984FC00-0x000000018984FC40
	// [XID] // 0x000000018984FC00-0x000000018984FC40
	public virtual void AutoAllocTypeFields() {} // 0x0000000183787F60-0x0000000183788000
	[BlackList] // 0x000000018985A270-0x000000018985A2B0
	// [XID] // 0x000000018985A270-0x000000018985A2B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183788000-0x00000001837880A0
	[BlackList] // 0x0000000189864630-0x0000000189864670
	// [XID] // 0x0000000189864630-0x0000000189864670
	public virtual void ReturnToObjectPool() {} // 0x0000000183788A90-0x0000000183788B30
	[BlackList] // 0x000000018986EB70-0x000000018986EBB0
	// [XID] // 0x000000018986EB70-0x000000018986EBB0
	public virtual void OnPoolAllocated() {} // 0x00000001837888A0-0x0000000183788940
	[BlackList] // 0x00000001898791D0-0x0000000189879210
	// [XID] // 0x00000001898791D0-0x0000000189879210
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183788800-0x00000001837888A0
}

