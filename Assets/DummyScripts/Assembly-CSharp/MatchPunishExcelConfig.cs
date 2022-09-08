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
public class MatchPunishExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15809
{
	// Fields
	protected SimpleSafeUInt32 timesRawNum; // 0x10
	protected SimpleSafeUInt32 punishTimeRawNum; // 0x14

	// Properties
	public uint times { /* [XID] */ /* 0x0000000189AF7900-0x0000000189AF7920 */ get => default; /* [XID] */ /* 0x0000000189AFEEB0-0x0000000189AFEED0 */ protected set {} } // 0x000000018550EF60-0x000000018550F030 0x000000018550F4D0-0x000000018550F5B0
	public uint punishTime { /* [XID] */ /* 0x0000000189B06720-0x0000000189B06740 */ get => default; /* [XID] */ /* 0x0000000189B0DE50-0x0000000189B0DE70 */ protected set {} } // 0x000000018550EE90-0x000000018550EF60 0x000000018550EDB0-0x000000018550EE90

	// Constructors
	public MatchPunishExcelConfig() {} // 0x000000018550F650-0x000000018550F6B0

	// Methods
	// [IDTag] // 0x0000000189B151B0-0x0000000189B151F0
	// [XID] // 0x0000000189B151B0-0x0000000189B151F0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018550E920-0x000000018550EB90
	// [IDTag] // 0x0000000189B1F920-0x0000000189B1F960
	// [XID] // 0x0000000189B1F920-0x0000000189B1F960
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018550EB90-0x000000018550EDB0
	// [XID] // 0x0000000189B29EC0-0x0000000189B29EE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2694 */, bool useObjectPool = false /* Metadata: 0x00AF2698 */) => default; // 0x000000018550F030-0x000000018550F390
	[BlackList] // 0x0000000189B315B0-0x0000000189B315F0
	// [XID] // 0x0000000189B315B0-0x0000000189B315F0
	public virtual void AutoAllocTypeFields() {} // 0x000000018550E7A0-0x000000018550E840
	[BlackList] // 0x0000000189B3BB30-0x0000000189B3BB70
	// [XID] // 0x0000000189B3BB30-0x0000000189B3BB70
	public virtual void AutoRecycleTypeFields() {} // 0x000000018550E840-0x000000018550E920
	[BlackList] // 0x0000000189B46620-0x0000000189B46660
	// [XID] // 0x0000000189B46620-0x0000000189B46660
	public virtual void ReturnToObjectPool() {} // 0x000000018550F5B0-0x000000018550F650
	[BlackList] // 0x0000000189B50E20-0x0000000189B50E60
	// [XID] // 0x0000000189B50E20-0x0000000189B50E60
	public virtual void OnPoolAllocated() {} // 0x000000018550F430-0x000000018550F4D0
	[BlackList] // 0x0000000189B5B4D0-0x0000000189B5B510
	// [XID] // 0x0000000189B5B4D0-0x0000000189B5B510
	public virtual void OnBeforePoolRecycled() {} // 0x000000018550F390-0x000000018550F430
}

