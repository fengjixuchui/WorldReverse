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
public class MatchExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15805
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected MatchSubType _matchSubType; // 0x14
	protected SimpleSafeUInt32 minPlayerNumRawNum; // 0x18
	protected SimpleSafeUInt32 maxPlayerNumRawNum; // 0x1C
	protected SimpleSafeUInt32 confirmTimeRawNum; // 0x20
	protected bool _isContinueMatch; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897C2070-0x00000001897C2090 */ get => default; /* [XID] */ /* 0x00000001897C98E0-0x00000001897C9900 */ protected set {} } // 0x0000000182B5E560-0x0000000182B5E630 0x0000000182B5DA40-0x0000000182B5DB20
	public MatchSubType matchSubType { /* [XID] */ /* 0x00000001897D0F30-0x00000001897D0F50 */ get => default; /* [XID] */ /* 0x00000001897D8E30-0x00000001897D8E50 */ protected set {} } // 0x0000000182B5D9A0-0x0000000182B5DA40 0x0000000182B5CD20-0x0000000182B5CDD0
	public uint minPlayerNum { /* [XID] */ /* 0x00000001897E0070-0x00000001897E0090 */ get => default; /* [XID] */ /* 0x00000001897E7750-0x00000001897E7770 */ protected set {} } // 0x0000000182B5CDD0-0x0000000182B5CEA0 0x0000000182B5CEA0-0x0000000182B5CF80
	public uint maxPlayerNum { /* [XID] */ /* 0x00000001897EF310-0x00000001897EF330 */ get => default; /* [XID] */ /* 0x00000001897F6900-0x00000001897F6920 */ protected set {} } // 0x0000000182B5D8D0-0x0000000182B5D9A0 0x0000000182B5E340-0x0000000182B5E420
	public uint confirmTime { /* [XID] */ /* 0x00000001897FE000-0x00000001897FE020 */ get => default; /* [XID] */ /* 0x00000001898057D0-0x00000001898057F0 */ protected set {} } // 0x0000000182B5CF80-0x0000000182B5D050 0x0000000182B5E260-0x0000000182B5E340
	public bool isContinueMatch { /* [XID] */ /* 0x000000018980CE30-0x000000018980CE50 */ get => default; /* [XID] */ /* 0x0000000189814670-0x0000000189814690 */ protected set {} } // 0x0000000182B5E110-0x0000000182B5E1B0 0x0000000182B5E1B0-0x0000000182B5E260

	// Constructors
	public MatchExcelConfig() {} // 0x0000000182B5E6D0-0x0000000182B5E730

	// Methods
	// [IDTag] // 0x000000018981C080-0x000000018981C0C0
	// [XID] // 0x000000018981C080-0x000000018981C0C0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182B5D050-0x0000000182B5D4A0
	// [IDTag] // 0x0000000189826690-0x00000001898266D0
	// [XID] // 0x0000000189826690-0x00000001898266D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182B5D4A0-0x0000000182B5D8D0
	// [XID] // 0x0000000189830CE0-0x0000000189830D00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2676 */, bool useObjectPool = false /* Metadata: 0x00AF267A */) => default; // 0x0000000182B5DB20-0x0000000182B5E110
	[BlackList] // 0x0000000189838440-0x0000000189838480
	// [XID] // 0x0000000189838440-0x0000000189838480
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B5CB70-0x0000000182B5CC10
	[BlackList] // 0x0000000189842B60-0x0000000189842BA0
	// [XID] // 0x0000000189842B60-0x0000000189842BA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B5CC10-0x0000000182B5CD20
	[BlackList] // 0x000000018984CEA0-0x000000018984CEE0
	// [XID] // 0x000000018984CEA0-0x000000018984CEE0
	public virtual void ReturnToObjectPool() {} // 0x0000000182B5E630-0x0000000182B5E6D0
	[BlackList] // 0x0000000189856FC0-0x0000000189857000
	// [XID] // 0x0000000189856FC0-0x0000000189857000
	public virtual void OnPoolAllocated() {} // 0x0000000182B5E4C0-0x0000000182B5E560
	[BlackList] // 0x0000000189861410-0x0000000189861450
	// [XID] // 0x0000000189861410-0x0000000189861450
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B5E420-0x0000000182B5E4C0
}

