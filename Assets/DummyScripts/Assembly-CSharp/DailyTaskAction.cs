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
public class DailyTaskAction : IAutoAllocRecycle // TypeDefIndex: 15479
{
	// Fields
	protected DailyTaskCondType _condType; // 0x10
	protected SimpleSafeInt32 condParam1RawNum; // 0x14
	protected SimpleSafeInt32 condParam2RawNum; // 0x18
	protected SimpleSafeInt32 condParam3RawNum; // 0x1C
	protected DailyTaskActionType _type; // 0x20
	protected SimpleSafeInt32 param1RawNum; // 0x24
	protected SimpleSafeInt32 param2RawNum; // 0x28
	protected SimpleSafeInt32 param3RawNum; // 0x2C

	// Properties
	public DailyTaskCondType condType { /* [XID] */ /* 0x00000001899283D0-0x00000001899283F0 */ get => default; /* [XID] */ /* 0x000000018992F960-0x000000018992F980 */ protected set {} } // 0x0000000183994F80-0x0000000183995020 0x0000000183993AB0-0x0000000183993B60
	public int condParam1 { /* [XID] */ /* 0x0000000189936E70-0x0000000189936E90 */ get => default; /* [XID] */ /* 0x000000018993EA30-0x000000018993EA50 */ protected set {} } // 0x0000000183993D40-0x0000000183993E10 0x0000000183993E10-0x0000000183993EF0
	public int condParam2 { /* [XID] */ /* 0x00000001899460C0-0x00000001899460E0 */ get => default; /* [XID] */ /* 0x000000018994D5B0-0x000000018994D5D0 */ protected set {} } // 0x0000000183993910-0x00000001839939E0 0x0000000183993FC0-0x00000001839940A0
	public int condParam3 { /* [XID] */ /* 0x0000000189954CC0-0x0000000189954CE0 */ get => default; /* [XID] */ /* 0x000000018995C4E0-0x000000018995C500 */ protected set {} } // 0x0000000183994EB0-0x0000000183994F80 0x0000000183995020-0x0000000183995100
	public DailyTaskActionType type { /* [XID] */ /* 0x0000000189963EE0-0x0000000189963F00 */ get => default; /* [XID] */ /* 0x000000018996B410-0x000000018996B430 */ protected set {} } // 0x00000001839954B0-0x0000000183995550 0x0000000183995100-0x00000001839951B0
	public int param1 { /* [XID] */ /* 0x0000000189972ED0-0x0000000189972EF0 */ get => default; /* [XID] */ /* 0x000000018997A790-0x000000018997A7B0 */ protected set {} } // 0x0000000183993EF0-0x0000000183993FC0 0x00000001839945D0-0x00000001839946B0
	public int param2 { /* [XID] */ /* 0x00000001899821A0-0x00000001899821C0 */ get => default; /* [XID] */ /* 0x0000000189989980-0x00000001899899A0 */ protected set {} } // 0x00000001839946B0-0x0000000183994780 0x0000000183995290-0x0000000183995370
	public int param3 { /* [XID] */ /* 0x00000001899911F0-0x0000000189991210 */ get => default; /* [XID] */ /* 0x0000000189998CF0-0x0000000189998D10 */ protected set {} } // 0x00000001839939E0-0x0000000183993AB0 0x00000001839951B0-0x0000000183995290

	// Constructors
	public DailyTaskAction() {} // 0x00000001839955F0-0x0000000183995650

	// Methods
	// [XID] // 0x00000001899A0570-0x00000001899A0590
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001839940A0-0x00000001839945D0
	// [XID] // 0x00000001899A8080-0x00000001899A80A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1BE1 */, bool useObjectPool = false /* Metadata: 0x00AF1BE5 */) => default; // 0x0000000183994780-0x0000000183994EB0
	[BlackList] // 0x00000001899AF710-0x00000001899AF750
	// [XID] // 0x00000001899AF710-0x00000001899AF750
	public virtual void AutoAllocTypeFields() {} // 0x0000000183993B60-0x0000000183993C00
	[BlackList] // 0x00000001899B9C50-0x00000001899B9C90
	// [XID] // 0x00000001899B9C50-0x00000001899B9C90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183993C00-0x0000000183993D40
	[BlackList] // 0x00000001899C47C0-0x00000001899C4800
	// [XID] // 0x00000001899C47C0-0x00000001899C4800
	public virtual void ReturnToObjectPool() {} // 0x0000000183995550-0x00000001839955F0
	[BlackList] // 0x00000001899CED60-0x00000001899CEDA0
	// [XID] // 0x00000001899CED60-0x00000001899CEDA0
	public virtual void OnPoolAllocated() {} // 0x0000000183995410-0x00000001839954B0
	[BlackList] // 0x00000001899D92B0-0x00000001899D92F0
	// [XID] // 0x00000001899D92B0-0x00000001899D92F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183995370-0x0000000183995410
}

