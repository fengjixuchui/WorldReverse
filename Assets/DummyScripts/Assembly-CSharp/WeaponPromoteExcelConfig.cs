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
public class WeaponPromoteExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16275
{
	// Fields
	protected SimpleSafeUInt32 weaponPromoteIdRawNum; // 0x10
	protected SimpleSafeUInt32 promoteLevelRawNum; // 0x14
	protected IdCountConfig[] _costItems; // 0x18
	protected SimpleSafeUInt32 coinCostRawNum; // 0x20
	protected PropValConfig[] _addProps; // 0x28
	protected SimpleSafeUInt32 unlockMaxLevelRawNum; // 0x30
	protected SimpleSafeUInt32 requiredPlayerLevelRawNum; // 0x34

	// Properties
	public uint weaponPromoteId { /* [XID] */ /* 0x0000000189980320-0x0000000189980340 */ get => default; /* [XID] */ /* 0x0000000189987B70-0x0000000189987B90 */ protected set {} } // 0x0000000182A055A0-0x0000000182A05670 0x0000000182A063A0-0x0000000182A06480
	public uint promoteLevel { /* [XID] */ /* 0x000000018998F6E0-0x000000018998F700 */ get => default; /* [XID] */ /* 0x0000000189997100-0x0000000189997120 */ protected set {} } // 0x0000000182A06D50-0x0000000182A06E20 0x0000000182A053F0-0x0000000182A054D0
	public IdCountConfig[] costItems { /* [XID] */ /* 0x000000018999ED10-0x000000018999ED30 */ get => default; /* [XID] */ /* 0x00000001899A6630-0x00000001899A6650 */ protected set {} } // 0x0000000182A06FA0-0x0000000182A07040 0x0000000182A06530-0x0000000182A065E0
	public uint coinCost { /* [XID] */ /* 0x00000001899ADDA0-0x00000001899ADDC0 */ get => default; /* [XID] */ /* 0x00000001899B5540-0x00000001899B5560 */ protected set {} } // 0x0000000182A05070-0x0000000182A05140 0x0000000182A06E20-0x0000000182A06F00
	public PropValConfig[] addProps { /* [XID] */ /* 0x00000001899BCD30-0x00000001899BCD50 */ get => default; /* [XID] */ /* 0x00000001899C4700-0x00000001899C4720 */ protected set {} } // 0x0000000182A06F00-0x0000000182A06FA0 0x0000000182A06480-0x0000000182A06530
	public uint unlockMaxLevel { /* [XID] */ /* 0x00000001899CBF40-0x00000001899CBF60 */ get => default; /* [XID] */ /* 0x00000001899D3470-0x00000001899D3490 */ protected set {} } // 0x0000000182A065E0-0x0000000182A066B0 0x0000000182A05670-0x0000000182A05750
	public uint requiredPlayerLevel { /* [XID] */ /* 0x00000001899DAA00-0x00000001899DAA20 */ get => default; /* [XID] */ /* 0x00000001899E2340-0x00000001899E2360 */ protected set {} } // 0x0000000182A054D0-0x0000000182A055A0 0x0000000182A05140-0x0000000182A05220

	// Constructors
	public WeaponPromoteExcelConfig() {} // 0x0000000182A07220-0x0000000182A07280

	// Methods
	// [IDTag] // 0x00000001899E9820-0x00000001899E9860
	// [XID] // 0x00000001899E9820-0x00000001899E9860
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182A05D20-0x0000000182A063A0
	// [IDTag] // 0x00000001899F4510-0x00000001899F4550
	// [XID] // 0x00000001899F4510-0x00000001899F4550
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182A05750-0x0000000182A05D20
	// [XID] // 0x00000001899FE7B0-0x00000001899FE7D0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF362B */, bool useObjectPool = false /* Metadata: 0x00AF362F */) => default; // 0x0000000182A066B0-0x0000000182A06D50
	[BlackList] // 0x0000000189A06070-0x0000000189A060B0
	// [XID] // 0x0000000189A06070-0x0000000189A060B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A05220-0x0000000182A052C0
	[BlackList] // 0x0000000189A10230-0x0000000189A10270
	// [XID] // 0x0000000189A10230-0x0000000189A10270
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A052C0-0x0000000182A053F0
	[BlackList] // 0x0000000189A1A670-0x0000000189A1A6B0
	// [XID] // 0x0000000189A1A670-0x0000000189A1A6B0
	public virtual void ReturnToObjectPool() {} // 0x0000000182A07180-0x0000000182A07220
	[BlackList] // 0x0000000189A24C10-0x0000000189A24C50
	// [XID] // 0x0000000189A24C10-0x0000000189A24C50
	public virtual void OnPoolAllocated() {} // 0x0000000182A070E0-0x0000000182A07180
	[BlackList] // 0x0000000189A2F2F0-0x0000000189A2F330
	// [XID] // 0x0000000189A2F2F0-0x0000000189A2F330
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A07040-0x0000000182A070E0
}

