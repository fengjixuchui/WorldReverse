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
public class WeaponCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15309
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 weaponIdRawNum; // 0x14
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x18
	protected bool _isDisuse; // 0x1C
	protected bool _showOnlyUnlocked; // 0x1D

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189B37450-0x0000000189B37470 */ get => default; /* [XID] */ /* 0x0000000189B3EC80-0x0000000189B3ECA0 */ protected set {} } // 0x0000000182626D30-0x0000000182626E00 0x0000000182627500-0x00000001826275E0
	public uint weaponId { /* [XID] */ /* 0x0000000189B46780-0x0000000189B467A0 */ get => default; /* [XID] */ /* 0x0000000189B4DCC0-0x0000000189B4DCE0 */ protected set {} } // 0x0000000182627870-0x0000000182627940 0x0000000182626ED0-0x0000000182626FB0
	public uint SortOrder { /* [XID] */ /* 0x0000000189B55530-0x0000000189B55550 */ get => default; /* [XID] */ /* 0x0000000189B5CE30-0x0000000189B5CE50 */ protected set {} } // 0x0000000182626E00-0x0000000182626ED0 0x0000000182626C50-0x0000000182626D30
	public bool isDisuse { /* [XID] */ /* 0x0000000189B64530-0x0000000189B64550 */ get => default; /* [XID] */ /* 0x0000000189B6BA30-0x0000000189B6BA50 */ protected set {} } // 0x00000001826275E0-0x0000000182627680 0x0000000182627680-0x0000000182627730
	public bool showOnlyUnlocked { /* [XID] */ /* 0x0000000189B73310-0x0000000189B73330 */ get => default; /* [XID] */ /* 0x0000000189B7A810-0x0000000189B7A830 */ protected set {} } // 0x0000000182626390-0x0000000182626430 0x0000000182626430-0x00000001826264E0

	// Constructors
	public WeaponCodexExcelConfig() {} // 0x00000001826279E0-0x0000000182627A40

	// Methods
	// [IDTag] // 0x0000000189B82010-0x0000000189B82050
	// [XID] // 0x0000000189B82010-0x0000000189B82050
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182626880-0x0000000182626C50
	// [IDTag] // 0x0000000189B8C280-0x0000000189B8C2C0
	// [XID] // 0x0000000189B8C280-0x0000000189B8C2C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001826264E0-0x0000000182626880
	// [XID] // 0x0000000189B96810-0x0000000189B96830
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0722 */, bool useObjectPool = false /* Metadata: 0x00AF0726 */) => default; // 0x0000000182626FB0-0x0000000182627500
	[BlackList] // 0x0000000189B9DD20-0x0000000189B9DD60
	// [XID] // 0x0000000189B9DD20-0x0000000189B9DD60
	public virtual void AutoAllocTypeFields() {} // 0x00000001826261F0-0x0000000182626290
	[BlackList] // 0x0000000189BA83F0-0x0000000189BA8430
	// [XID] // 0x0000000189BA83F0-0x0000000189BA8430
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182626290-0x0000000182626390
	[BlackList] // 0x0000000189BB29B0-0x0000000189BB29F0
	// [XID] // 0x0000000189BB29B0-0x0000000189BB29F0
	public virtual void ReturnToObjectPool() {} // 0x0000000182627940-0x00000001826279E0
	[BlackList] // 0x0000000189BBCEA0-0x0000000189BBCEE0
	// [XID] // 0x0000000189BBCEA0-0x0000000189BBCEE0
	public virtual void OnPoolAllocated() {} // 0x00000001826277D0-0x0000000182627870
	[BlackList] // 0x0000000189BC7960-0x0000000189BC79A0
	// [XID] // 0x0000000189BC7960-0x0000000189BC79A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182627730-0x00000001826277D0
}

