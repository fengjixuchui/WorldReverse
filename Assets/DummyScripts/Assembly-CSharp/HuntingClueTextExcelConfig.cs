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
public class HuntingClueTextExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15757
{
	// Fields
	protected SimpleSafeUInt32 clueTextIdRawNum; // 0x10
	protected SimpleSafeUInt32[] _reminderIdList; // 0x18

	// Properties
	public uint clueTextId { /* [XID] */ /* 0x00000001899AF6D0-0x00000001899AF6F0 */ get => default; /* [XID] */ /* 0x00000001899B6BB0-0x00000001899B6BD0 */ protected set {} } // 0x0000000180F75020-0x0000000180F750F0 0x0000000180F74F40-0x0000000180F75020
	public SimpleSafeUInt32[] reminderIdList { /* [XID] */ /* 0x00000001899BE6F0-0x00000001899BE710 */ get => default; /* [XID] */ /* 0x00000001899C5F50-0x00000001899C5F70 */ protected set {} } // 0x0000000180F74EA0-0x0000000180F74F40 0x0000000180F74DF0-0x0000000180F74EA0

	// Constructors
	public HuntingClueTextExcelConfig() {} // 0x0000000180F752D0-0x0000000180F75330

	// Methods
	// [IDTag] // 0x00000001899CD6F0-0x00000001899CD730
	// [XID] // 0x00000001899CD6F0-0x00000001899CD730
	public virtual bool ParseFromLine(string line) => default; // 0x0000000180F74260-0x0000000180F74690
	// [IDTag] // 0x00000001899D7B30-0x00000001899D7B70
	// [XID] // 0x00000001899D7B30-0x00000001899D7B70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000180F74690-0x0000000180F74A80
	// [XID] // 0x00000001899E23E0-0x00000001899E2400
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2535 */, bool useObjectPool = false /* Metadata: 0x00AF2539 */) => default; // 0x0000000180F74A80-0x0000000180F74DF0
	[BlackList] // 0x00000001899E98C0-0x00000001899E9900
	// [XID] // 0x00000001899E98C0-0x00000001899E9900
	public virtual void AutoAllocTypeFields() {} // 0x0000000180F740E0-0x0000000180F74180
	[BlackList] // 0x00000001899F4630-0x00000001899F4670
	// [XID] // 0x00000001899F4630-0x00000001899F4670
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180F74180-0x0000000180F74260
	[BlackList] // 0x00000001899FE8F0-0x00000001899FE930
	// [XID] // 0x00000001899FE8F0-0x00000001899FE930
	public virtual void ReturnToObjectPool() {} // 0x0000000180F75230-0x0000000180F752D0
	[BlackList] // 0x0000000189A08DB0-0x0000000189A08DF0
	// [XID] // 0x0000000189A08DB0-0x0000000189A08DF0
	public virtual void OnPoolAllocated() {} // 0x0000000180F75190-0x0000000180F75230
	[BlackList] // 0x0000000189A13660-0x0000000189A136A0
	// [XID] // 0x0000000189A13660-0x0000000189A136A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180F750F0-0x0000000180F75190
}

