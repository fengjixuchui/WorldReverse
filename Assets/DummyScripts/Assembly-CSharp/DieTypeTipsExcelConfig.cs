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
public class DieTypeTipsExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14861
{
	// Fields
	private static Random _random; // 0x00
	private int _count; // 0x10
	public static Func<uint, string> getLocalizedTextHandler; // 0x08
	protected SimpleSafeUInt32 idRawNum; // 0x14
	protected PlayerDieType _dieType; // 0x18
	protected SimpleSafeUInt32 monsterIDRawNum; // 0x1C
	protected uint[] _tips; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189AB06E0-0x0000000189AB0700 */ get => default; /* [XID] */ /* 0x0000000189AB7D40-0x0000000189AB7D60 */ protected set {} } // 0x0000000183820F50-0x0000000183821020 0x00000001838202E0-0x00000001838203C0
	public PlayerDieType dieType { /* [XID] */ /* 0x0000000189ABF810-0x0000000189ABF830 */ get => default; /* [XID] */ /* 0x0000000189AC7200-0x0000000189AC7220 */ protected set {} } // 0x0000000183820CC0-0x0000000183820D60 0x0000000183820870-0x0000000183820920
	public uint monsterID { /* [XID] */ /* 0x0000000189ACE910-0x0000000189ACE930 */ get => default; /* [XID] */ /* 0x0000000189AD67C0-0x0000000189AD67E0 */ protected set {} } // 0x000000018381FC20-0x000000018381FCF0 0x0000000183820200-0x00000001838202E0
	public uint[] tips { /* [XID] */ /* 0x0000000189ADE140-0x0000000189ADE160 */ get => default; /* [XID] */ /* 0x0000000189AE5B60-0x0000000189AE5B80 */ protected set {} } // 0x000000018381F2B0-0x000000018381F350 0x0000000183820D60-0x0000000183820E10
	public string[] tipsLocalized { /* [XID] */ /* 0x0000000189AED000-0x0000000189AED020 */ get => default; } // 0x0000000183820920-0x0000000183820CC0 

	// Constructors
	public DieTypeTipsExcelConfig() {} // 0x0000000183821140-0x00000001838211B0
	static DieTypeTipsExcelConfig() {} // 0x00000001838210C0-0x0000000183821140

	// Methods
	// [XID] // 0x0000000189AA13C0-0x0000000189AA13E0
	public string GetTip() => default; // 0x000000018381FF70-0x0000000183820200
	// [XID] // 0x0000000189AA8B20-0x0000000189AA8B40
	private void RemoveInvalid() {} // 0x000000018381FCF0-0x000000018381FF70
	// [IDTag] // 0x0000000189AF4950-0x0000000189AF4990
	// [XID] // 0x0000000189AF4950-0x0000000189AF4990
	public virtual bool ParseFromLine(string line) => default; // 0x000000018381F350-0x000000018381F7E0
	// [IDTag] // 0x0000000189AFF050-0x0000000189AFF090
	// [XID] // 0x0000000189AFF050-0x0000000189AFF090
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018381F7E0-0x000000018381FC20
	// [XID] // 0x0000000189B096F0-0x0000000189B09710
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF812 */, bool useObjectPool = false /* Metadata: 0x00AEF816 */) => default; // 0x00000001838203C0-0x0000000183820870
	[BlackList] // 0x0000000189B111F0-0x0000000189B11230
	// [XID] // 0x0000000189B111F0-0x0000000189B11230
	public virtual void AutoAllocTypeFields() {} // 0x000000018381F120-0x000000018381F1C0
	[BlackList] // 0x0000000189B1B420-0x0000000189B1B460
	// [XID] // 0x0000000189B1B420-0x0000000189B1B460
	public virtual void AutoRecycleTypeFields() {} // 0x000000018381F1C0-0x000000018381F2B0
	[BlackList] // 0x0000000189B259E0-0x0000000189B25A20
	// [XID] // 0x0000000189B259E0-0x0000000189B25A20
	public virtual void ReturnToObjectPool() {} // 0x0000000183821020-0x00000001838210C0
	[BlackList] // 0x0000000189B2FBD0-0x0000000189B2FC10
	// [XID] // 0x0000000189B2FBD0-0x0000000189B2FC10
	public virtual void OnPoolAllocated() {} // 0x0000000183820EB0-0x0000000183820F50
	[BlackList] // 0x0000000189B3A4D0-0x0000000189B3A510
	// [XID] // 0x0000000189B3A4D0-0x0000000189B3A510
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183820E10-0x0000000183820EB0
}

