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
public class ReliquaryAffixExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16019
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 depot_idRawNum; // 0x14
	protected SimpleSafeUInt32 group_idRawNum; // 0x18
	protected FightPropType _propType; // 0x1C
	protected SimpleSafeFloat propValueRawNum; // 0x20
	protected SimpleSafeUInt32 weightRawNum; // 0x24
	protected SimpleSafeUInt32 upgradeWeightRawNum; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x00000001896B51F0-0x00000001896B5210 */ get => default; /* [XID] */ /* 0x00000001896BC3C0-0x00000001896BC3E0 */ protected set {} } // 0x00000001841DC190-0x00000001841DC260 0x00000001841DB680-0x00000001841DB760
	public uint depot_id { /* [XID] */ /* 0x00000001896C3940-0x00000001896C3960 */ get => default; /* [XID] */ /* 0x00000001896CAD90-0x00000001896CADB0 */ protected set {} } // 0x00000001841DA8F0-0x00000001841DA9C0 0x00000001841DC330-0x00000001841DC410
	public uint group_id { /* [XID] */ /* 0x00000001896D2440-0x00000001896D2460 */ get => default; /* [XID] */ /* 0x00000001896D9E70-0x00000001896D9E90 */ protected set {} } // 0x00000001841DC410-0x00000001841DC4E0 0x00000001841DB5A0-0x00000001841DB680
	public FightPropType propType { /* [XID] */ /* 0x00000001896E14B0-0x00000001896E14D0 */ get => default; /* [XID] */ /* 0x00000001896E8700-0x00000001896E8720 */ protected set {} } // 0x00000001841DBFB0-0x00000001841DC050 0x00000001841DB330-0x00000001841DB3E0
	public float propValue { /* [XID] */ /* 0x00000001896EFC20-0x00000001896EFC40 */ get => default; /* [XID] */ /* 0x00000001896F7630-0x00000001896F7650 */ protected set {} } // 0x00000001841DB4C0-0x00000001841DB5A0 0x00000001841DB760-0x00000001841DB840
	public uint weight { /* [XID] */ /* 0x00000001896FF050-0x00000001896FF070 */ get => default; /* [XID] */ /* 0x0000000189706320-0x0000000189706340 */ protected set {} } // 0x00000001841DC260-0x00000001841DC330 0x00000001841DB3E0-0x00000001841DB4C0
	public uint upgradeWeight { /* [XID] */ /* 0x000000018970DC10-0x000000018970DC30 */ get => default; /* [XID] */ /* 0x0000000189715090-0x00000001897150B0 */ protected set {} } // 0x00000001841DBEE0-0x00000001841DBFB0 0x00000001841DA810-0x00000001841DA8F0

	// Constructors
	public ReliquaryAffixExcelConfig() {} // 0x00000001841DC580-0x00000001841DC5E0

	// Methods
	// [IDTag] // 0x000000018971CBC0-0x000000018971CC00
	// [XID] // 0x000000018971CBC0-0x000000018971CC00
	public virtual bool ParseFromLine(string line) => default; // 0x00000001841DAE70-0x00000001841DB330
	// [IDTag] // 0x0000000189727240-0x0000000189727280
	// [XID] // 0x0000000189727240-0x0000000189727280
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001841DA9C0-0x00000001841DAE70
	// [XID] // 0x0000000189731640-0x0000000189731660
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2E0E */, bool useObjectPool = false /* Metadata: 0x00AF2E12 */) => default; // 0x00000001841DB840-0x00000001841DBEE0
	[BlackList] // 0x0000000189738E50-0x0000000189738E90
	// [XID] // 0x0000000189738E50-0x0000000189738E90
	public virtual void AutoAllocTypeFields() {} // 0x00000001841DA610-0x00000001841DA6B0
	[BlackList] // 0x0000000189743730-0x0000000189743770
	// [XID] // 0x0000000189743730-0x0000000189743770
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841DA6B0-0x00000001841DA810
	[BlackList] // 0x000000018974E190-0x000000018974E1D0
	// [XID] // 0x000000018974E190-0x000000018974E1D0
	public virtual void ReturnToObjectPool() {} // 0x00000001841DC4E0-0x00000001841DC580
	[BlackList] // 0x0000000189758370-0x00000001897583B0
	// [XID] // 0x0000000189758370-0x00000001897583B0
	public virtual void OnPoolAllocated() {} // 0x00000001841DC0F0-0x00000001841DC190
	[BlackList] // 0x0000000189762C90-0x0000000189762CD0
	// [XID] // 0x0000000189762C90-0x0000000189762CD0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841DC050-0x00000001841DC0F0
}

