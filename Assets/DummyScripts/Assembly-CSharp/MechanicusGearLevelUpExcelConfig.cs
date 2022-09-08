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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MechanicusGearLevelUpExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16218
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected SimpleSafeUInt32 gearIDRawNum; // 0x14
	protected SimpleSafeUInt32 gearLevelRawNum; // 0x18
	protected SimpleSafeUInt32 gearLevelUpMoneyRawNum; // 0x1C
	protected uint _gearNameTextMapHash; // 0x20
	protected uint _gearShortNameTextMapHash; // 0x24
	protected uint _descTextMapHash; // 0x28
	protected string _gearIconPath; // 0x30
	protected SimpleSafeUInt32 attackRawNum; // 0x38
	protected SimpleSafeUInt32 attackSpeedRawNum; // 0x3C
	protected SimpleSafeUInt32 attackRangeRawNum; // 0x40
	protected SimpleSafeUInt32 build_costRawNum; // 0x44
	protected SimpleSafeUInt32 demolition_refundRawNum; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SGVConfig[] _globalValueParam; // 0x50
	protected SimpleSafeUInt32[] _effectList; // 0x58

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001899AC850-0x00000001899AC870 */ get => default; /* [XID] */ /* 0x00000001899B3FC0-0x00000001899B3FE0 */ protected set {} } // 0x0000000183A4EA70-0x0000000183A4EB40 0x0000000183A4C530-0x0000000183A4C610
	public uint gearID { /* [XID] */ /* 0x00000001899BB490-0x00000001899BB4B0 */ get => default; /* [XID] */ /* 0x00000001899C2FE0-0x00000001899C3000 */ protected set {} } // 0x0000000183A4E460-0x0000000183A4E530 0x0000000183A50480-0x0000000183A50560
	public uint gearLevel { /* [XID] */ /* 0x00000001899CA380-0x00000001899CA3A0 */ get => default; /* [XID] */ /* 0x00000001899D1C00-0x00000001899D1C20 */ protected set {} } // 0x0000000183A4CB20-0x0000000183A4CBF0 0x0000000183A4FF80-0x0000000183A50060
	public uint gearLevelUpMoney { /* [XID] */ /* 0x00000001899D90B0-0x00000001899D90D0 */ get => default; /* [XID] */ /* 0x00000001899E0840-0x00000001899E0860 */ protected set {} } // 0x0000000183A4CA50-0x0000000183A4CB20 0x0000000183A4FE00-0x0000000183A4FEE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint gearNameTextMapHash { /* [XID] */ /* 0x00000001899E8320-0x00000001899E8340 */ get => default; /* [XID] */ /* 0x00000001899EF8F0-0x00000001899EF910 */ protected set {} } // 0x0000000183A4C900-0x0000000183A4C9A0 0x0000000183A4E610-0x0000000183A4E6C0
	public string gearName { /* [XID] */ /* 0x00000001899F70F0-0x00000001899F7110 */ get => default; } // 0x0000000183A4E6C0-0x0000000183A4E840 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint gearShortNameTextMapHash { /* [XID] */ /* 0x00000001899FE7D0-0x00000001899FE7F0 */ get => default; /* [XID] */ /* 0x0000000189A060B0-0x0000000189A060D0 */ protected set {} } // 0x0000000183A4CCC0-0x0000000183A4CD60 0x0000000183A50290-0x0000000183A50340
	public string gearShortName { /* [XID] */ /* 0x0000000189A0D5C0-0x0000000189A0D5E0 */ get => default; } // 0x0000000183A4E8F0-0x0000000183A4EA70 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A14D00-0x0000000189A14D20 */ get => default; /* [XID] */ /* 0x0000000189A1BF10-0x0000000189A1BF30 */ protected set {} } // 0x0000000183A4FEE0-0x0000000183A4FF80 0x0000000183A4C9A0-0x0000000183A4CA50
	public string desc { /* [XID] */ /* 0x0000000189A23780-0x0000000189A237A0 */ get => default; } // 0x0000000183A4ECB0-0x0000000183A4EE30 
	public string gearIconPath { /* [XID] */ /* 0x0000000189A2AC00-0x0000000189A2AC20 */ get => default; /* [XID] */ /* 0x0000000189A32140-0x0000000189A32160 */ protected set {} } // 0x0000000183A4EC10-0x0000000183A4ECB0 0x0000000183A50110-0x0000000183A501C0
	public uint attack { /* [XID] */ /* 0x0000000189A39AF0-0x0000000189A39B10 */ get => default; /* [XID] */ /* 0x0000000189A41370-0x0000000189A41390 */ protected set {} } // 0x0000000183A4EB40-0x0000000183A4EC10 0x0000000183A50560-0x0000000183A50640
	public uint attackSpeed { /* [XID] */ /* 0x0000000189A489D0-0x0000000189A489F0 */ get => default; /* [XID] */ /* 0x0000000189A50160-0x0000000189A50180 */ protected set {} } // 0x0000000183A4FC50-0x0000000183A4FD20 0x0000000183A4FD20-0x0000000183A4FE00
	public uint attackRange { /* [XID] */ /* 0x0000000189A576F0-0x0000000189A57710 */ get => default; /* [XID] */ /* 0x0000000189A5F230-0x0000000189A5F250 */ protected set {} } // 0x0000000183A4CBF0-0x0000000183A4CCC0 0x0000000183A4E530-0x0000000183A4E610
	public uint build_cost { /* [XID] */ /* 0x0000000189A66AC0-0x0000000189A66AE0 */ get => default; /* [XID] */ /* 0x0000000189A6E420-0x0000000189A6E440 */ protected set {} } // 0x0000000183A501C0-0x0000000183A50290 0x0000000183A4EE30-0x0000000183A4EF10
	public uint demolition_refund { /* [XID] */ /* 0x0000000189A75AD0-0x0000000189A75AF0 */ get => default; /* [XID] */ /* 0x0000000189A7D6F0-0x0000000189A7D710 */ protected set {} } // 0x0000000183A4C830-0x0000000183A4C900 0x0000000183A4EF10-0x0000000183A4EFF0
	public SGVConfig[] globalValueParam { /* [XID] */ /* 0x0000000189A84EA0-0x0000000189A84EC0 */ get => default; /* [XID] */ /* 0x0000000189A8C7D0-0x0000000189A8C7F0 */ protected set {} } // 0x0000000183A4EFF0-0x0000000183A4F090 0x0000000183A4E840-0x0000000183A4E8F0
	public SimpleSafeUInt32[] effectList { /* [XID] */ /* 0x0000000189A93BF0-0x0000000189A93C10 */ get => default; /* [XID] */ /* 0x0000000189A9B680-0x0000000189A9B6A0 */ protected set {} } // 0x0000000183A4C490-0x0000000183A4C530 0x0000000183A50060-0x0000000183A50110

	// Constructors
	public MechanicusGearLevelUpExcelConfig() {} // 0x0000000183A506E0-0x0000000183A50740

	// Methods
	// [IDTag] // 0x0000000189AA29A0-0x0000000189AA29E0
	// [XID] // 0x0000000189AA29A0-0x0000000189AA29E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183A4CD60-0x0000000183A4D960
	// [IDTag] // 0x0000000189AAD1C0-0x0000000189AAD200
	// [XID] // 0x0000000189AAD1C0-0x0000000189AAD200
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183A4D960-0x0000000183A4E460
	// [XID] // 0x0000000189AB7AC0-0x0000000189AB7AE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF34A5 */, bool useObjectPool = false /* Metadata: 0x00AF34A9 */) => default; // 0x0000000183A4F090-0x0000000183A4FC50
	[BlackList] // 0x0000000189ABF510-0x0000000189ABF550
	// [XID] // 0x0000000189ABF510-0x0000000189ABF550
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A4C610-0x0000000183A4C6B0
	[BlackList] // 0x0000000189AC9EE0-0x0000000189AC9F20
	// [XID] // 0x0000000189AC9EE0-0x0000000189AC9F20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A4C6B0-0x0000000183A4C830
	[BlackList] // 0x0000000189AD4C00-0x0000000189AD4C40
	// [XID] // 0x0000000189AD4C00-0x0000000189AD4C40
	public virtual void ReturnToObjectPool() {} // 0x0000000183A50640-0x0000000183A506E0
	[BlackList] // 0x0000000189ADF770-0x0000000189ADF7B0
	// [XID] // 0x0000000189ADF770-0x0000000189ADF7B0
	public virtual void OnPoolAllocated() {} // 0x0000000183A503E0-0x0000000183A50480
	[BlackList] // 0x0000000189AE9C70-0x0000000189AE9CB0
	// [XID] // 0x0000000189AE9C70-0x0000000189AE9CB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A50340-0x0000000183A503E0
}

