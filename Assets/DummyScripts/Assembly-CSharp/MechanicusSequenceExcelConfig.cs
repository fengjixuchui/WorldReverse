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
public class MechanicusSequenceExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16214
{
	// Fields
	protected SimpleSafeUInt32 sequenceIDRawNum; // 0x10
	protected SimpleSafeUInt32 mechanicusIDRawNum; // 0x14
	protected SimpleSafeUInt32 openLevelRawNum; // 0x18
	protected SimpleSafeUInt32[] _openGearList; // 0x20
	protected SimpleSafeUInt32 gearLevelLimiteRawNum; // 0x28
	protected SimpleSafeUInt32 gearMoneyLimiteRawNum; // 0x2C
	protected SimpleSafeUInt32[] _openMapList; // 0x30
	protected SimpleSafeUInt32 activityIDRawNum; // 0x38
	protected SimpleSafeUInt32 condIDRawNum; // 0x3C
	protected SimpleSafeUInt32 rewardPreviewIDRawNum; // 0x40

	// Properties
	public uint sequenceID { /* [XID] */ /* 0x00000001896D0D40-0x00000001896D0D60 */ get => default; /* [XID] */ /* 0x00000001896D8370-0x00000001896D8390 */ protected set {} } // 0x0000000183C0EA90-0x0000000183C0EB60 0x0000000183C0FB20-0x0000000183C0FC00
	public uint mechanicusID { /* [XID] */ /* 0x00000001896DFD20-0x00000001896DFD40 */ get => default; /* [XID] */ /* 0x00000001896E70C0-0x00000001896E70E0 */ protected set {} } // 0x0000000183C0F980-0x0000000183C0FA50 0x0000000183C0ECE0-0x0000000183C0EDC0
	public uint openLevel { /* [XID] */ /* 0x00000001896EE650-0x00000001896EE670 */ get => default; /* [XID] */ /* 0x00000001896F5F00-0x00000001896F5F20 */ protected set {} } // 0x0000000183C0D140-0x0000000183C0D210 0x0000000183C0F8A0-0x0000000183C0F980
	public SimpleSafeUInt32[] openGearList { /* [XID] */ /* 0x00000001896FD730-0x00000001896FD750 */ get => default; /* [XID] */ /* 0x0000000189704B90-0x0000000189704BB0 */ protected set {} } // 0x0000000183C0E850-0x0000000183C0E8F0 0x0000000183C0F710-0x0000000183C0F7C0
	public uint gearLevelLimite { /* [XID] */ /* 0x000000018970C390-0x000000018970C3B0 */ get => default; /* [XID] */ /* 0x0000000189713D20-0x0000000189713D40 */ protected set {} } // 0x0000000183C0FA50-0x0000000183C0FB20 0x0000000183C0D2F0-0x0000000183C0D3D0
	public uint gearMoneyLimite { /* [XID] */ /* 0x000000018971B500-0x000000018971B520 */ get => default; /* [XID] */ /* 0x0000000189722760-0x0000000189722780 */ protected set {} } // 0x0000000183C0E9C0-0x0000000183C0EA90 0x0000000183C0EB60-0x0000000183C0EC40
	public SimpleSafeUInt32[] openMapList { /* [XID] */ /* 0x0000000189729EA0-0x0000000189729EC0 */ get => default; /* [XID] */ /* 0x00000001897315A0-0x00000001897315C0 */ protected set {} } // 0x0000000183C0EC40-0x0000000183C0ECE0 0x0000000183C0FD40-0x0000000183C0FDF0
	public uint activityID { /* [XID] */ /* 0x0000000189738E30-0x0000000189738E50 */ get => default; /* [XID] */ /* 0x0000000189740C40-0x0000000189740C60 */ protected set {} } // 0x0000000183C0E8F0-0x0000000183C0E9C0 0x0000000183C0D210-0x0000000183C0D2F0
	public uint condID { /* [XID] */ /* 0x0000000189748140-0x0000000189748160 */ get => default; /* [XID] */ /* 0x000000018974F8F0-0x000000018974F910 */ protected set {} } // 0x0000000183C0D3D0-0x0000000183C0D4A0 0x0000000183C0F7C0-0x0000000183C0F8A0
	public uint rewardPreviewID { /* [XID] */ /* 0x0000000189756F20-0x0000000189756F40 */ get => default; /* [XID] */ /* 0x000000018975E470-0x000000018975E490 */ protected set {} } // 0x0000000183C0F640-0x0000000183C0F710 0x0000000183C0FDF0-0x0000000183C0FED0

	// Constructors
	public MechanicusSequenceExcelConfig() {} // 0x0000000183C0FF70-0x0000000183C0FFD0

	// Methods
	// [IDTag] // 0x0000000189765B10-0x0000000189765B50
	// [XID] // 0x0000000189765B10-0x0000000189765B50
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183C0D4A0-0x0000000183C0DE70
	// [IDTag] // 0x00000001897701D0-0x0000000189770210
	// [XID] // 0x00000001897701D0-0x0000000189770210
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183C0DE70-0x0000000183C0E850
	// [XID] // 0x000000018977A820-0x000000018977A840
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3487 */, bool useObjectPool = false /* Metadata: 0x00AF348B */) => default; // 0x0000000183C0EDC0-0x0000000183C0F640
	[BlackList] // 0x0000000189782400-0x0000000189782440
	// [XID] // 0x0000000189782400-0x0000000189782440
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C0CF40-0x0000000183C0CFE0
	[BlackList] // 0x000000018978C730-0x000000018978C770
	// [XID] // 0x000000018978C730-0x000000018978C770
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C0CFE0-0x0000000183C0D140
	[BlackList] // 0x0000000189796E50-0x0000000189796E90
	// [XID] // 0x0000000189796E50-0x0000000189796E90
	public virtual void ReturnToObjectPool() {} // 0x0000000183C0FED0-0x0000000183C0FF70
	[BlackList] // 0x00000001897A1BE0-0x00000001897A1C20
	// [XID] // 0x00000001897A1BE0-0x00000001897A1C20
	public virtual void OnPoolAllocated() {} // 0x0000000183C0FCA0-0x0000000183C0FD40
	[BlackList] // 0x00000001897AC380-0x00000001897AC3C0
	// [XID] // 0x00000001897AC380-0x00000001897AC3C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C0FC00-0x0000000183C0FCA0
}

