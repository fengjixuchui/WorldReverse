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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigGlobalSwitch : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18109
{
	// Fields
	private bool _enableMultiPlayer; // 0x10
	private bool _enableAnimatorInterleave; // 0x11
	private bool _enableMixinModifierDetachCallback; // 0x12
	private bool _enablePacketProcessTimeLimit; // 0x13
	private bool _enableUITempFix; // 0x14
	private bool _enableEquipDataItemFix; // 0x15
	private bool _cacheEntityLightDeActive; // 0x16
	private bool _enablemaxDelayPacketMs; // 0x17
	private SimpleSafeUInt32 maxDelayPacketMsRawNum; // 0x18
	private bool _enableForceSyncPostion; // 0x1C
	private SimpleSafeFloat maxForceDistanceRawNum; // 0x20
	private bool _enableAbilityInvokeAfterReady; // 0x24

	// Properties
	public bool enableMultiPlayer { /* [XID] */ /* 0x0000000189A21B10-0x0000000189A21B30 */ get => default; /* [XID] */ /* 0x0000000189A290A0-0x0000000189A290C0 */ private set {} } // 0x0000000183D84B20-0x0000000183D84BC0 0x0000000183D83530-0x0000000183D835E0
	public bool enableAnimatorInterleave { /* [XID] */ /* 0x0000000189A306B0-0x0000000189A306D0 */ get => default; /* [XID] */ /* 0x0000000189A38050-0x0000000189A38070 */ private set {} } // 0x0000000183D82A60-0x0000000183D82B00 0x0000000183D86170-0x0000000183D86220
	public bool enableMixinModifierDetachCallback { /* [XID] */ /* 0x0000000189A3F7C0-0x0000000189A3F7E0 */ get => default; /* [XID] */ /* 0x0000000189A46E10-0x0000000189A46E30 */ private set {} } // 0x0000000183D86220-0x0000000183D862C0 0x0000000183D85380-0x0000000183D85430
	public bool enablePacketProcessTimeLimit { /* [XID] */ /* 0x00000001896C1000-0x00000001896C1020 */ get => default; /* [XID] */ /* 0x0000000189A55DC0-0x0000000189A55DE0 */ private set {} } // 0x0000000183D84500-0x0000000183D845A0 0x0000000183D84450-0x0000000183D84500
	public bool enableUITempFix { /* [XID] */ /* 0x0000000189A5D740-0x0000000189A5D760 */ get => default; /* [XID] */ /* 0x0000000189A64FC0-0x0000000189A64FE0 */ private set {} } // 0x0000000183D83C60-0x0000000183D83D00 0x0000000183D845A0-0x0000000183D84650
	public bool enableEquipDataItemFix { /* [XID] */ /* 0x0000000189A6C720-0x0000000189A6C740 */ get => default; /* [XID] */ /* 0x0000000189A73FD0-0x0000000189A73FF0 */ private set {} } // 0x0000000183D84E50-0x0000000183D84EF0 0x0000000183D84650-0x0000000183D84700
	public bool cacheEntityLightDeActive { /* [XID] */ /* 0x0000000189A7B9C0-0x0000000189A7B9E0 */ get => default; /* [XID] */ /* 0x0000000189A83220-0x0000000189A83240 */ private set {} } // 0x0000000183D83BC0-0x0000000183D83C60 0x0000000183D852D0-0x0000000183D85380
	public bool enablemaxDelayPacketMs { /* [XID] */ /* 0x0000000189A8AB20-0x0000000189A8AB40 */ get => default; /* [XID] */ /* 0x0000000189A92390-0x0000000189A923B0 */ private set {} } // 0x0000000183D84A80-0x0000000183D84B20 0x0000000183D85430-0x0000000183D854E0
	public uint maxDelayPacketMs { /* [XID] */ /* 0x0000000189A99D40-0x0000000189A99D60 */ get => default; /* [XID] */ /* 0x0000000189AA0D20-0x0000000189AA0D40 */ private set {} } // 0x0000000183D85580-0x0000000183D85650 0x0000000183D851F0-0x0000000183D852D0
	public bool enableForceSyncPostion { /* [XID] */ /* 0x0000000189AA8340-0x0000000189AA8360 */ get => default; /* [XID] */ /* 0x0000000189AB0040-0x0000000189AB0060 */ private set {} } // 0x0000000183D854E0-0x0000000183D85580 0x0000000183D83B10-0x0000000183D83BC0
	public float maxForceDistance { /* [XID] */ /* 0x0000000189AB7810-0x0000000189AB7830 */ get => default; /* [XID] */ /* 0x0000000189ABF210-0x0000000189ABF230 */ private set {} } // 0x0000000183D82980-0x0000000183D82A60 0x0000000183D84CC0-0x0000000183D84DA0
	public bool enableAbilityInvokeAfterReady { /* [XID] */ /* 0x0000000189AC6C20-0x0000000189AC6C40 */ get => default; /* [XID] */ /* 0x0000000189ACE450-0x0000000189ACE470 */ private set {} } // 0x0000000183D838B0-0x0000000183D83950 0x0000000183D84DA0-0x0000000183D84E50

	// Constructors
	public ConfigGlobalSwitch() {} // 0x0000000183D86360-0x0000000183D86440

	// Methods
	// [XID] // 0x0000000189AD6260-0x0000000189AD6280
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D85E20-0x0000000183D86030
	// [XID] // 0x0000000189ADDBC0-0x0000000189ADDBE0
	public void InitEmpty() {} // 0x0000000183D84BC0-0x0000000183D84CC0
	[BlackList] // 0x0000000189AE5540-0x0000000189AE5580
	// [XID] // 0x0000000189AE5540-0x0000000189AE5580
	public bool FromJson(JSONNode node) => default; // 0x0000000183D84700-0x0000000183D84A80
	// [XID] // 0x0000000189AEFFB0-0x0000000189AEFFD0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183D82B00-0x0000000183D83530
	// [XID] // 0x0000000189AF7440-0x0000000189AF7460
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B59 */, bool useObjectPool = false /* Metadata: 0x00AF8B5D */) => default; // 0x0000000183D84EF0-0x0000000183D851F0
	// [XID] // 0x0000000189AFEAF0-0x0000000189AFEB10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B5E */, bool useObjectPool = false /* Metadata: 0x00AF8B62 */) => default; // 0x0000000183D83D00-0x0000000183D84450
	[BlackList] // 0x0000000189B06260-0x0000000189B062A0
	// [XID] // 0x0000000189B06260-0x0000000189B062A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D835E0-0x0000000183D838B0
	// [XID] // 0x0000000189B10AF0-0x0000000189B10B10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D85650-0x0000000183D85E20
	[BlackList] // 0x0000000189B17C20-0x0000000189B17C60
	// [XID] // 0x0000000189B17C20-0x0000000189B17C60
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D83950-0x0000000183D839F0
	[BlackList] // 0x0000000189B223B0-0x0000000189B223F0
	// [XID] // 0x0000000189B223B0-0x0000000189B223F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D839F0-0x0000000183D83B10
	[BlackList] // 0x0000000189B2C8F0-0x0000000189B2C930
	// [XID] // 0x0000000189B2C8F0-0x0000000189B2C930
	public virtual void ReturnToObjectPool() {} // 0x0000000183D862C0-0x0000000183D86360
	[BlackList] // 0x0000000189B36E70-0x0000000189B36EB0
	// [XID] // 0x0000000189B36E70-0x0000000189B36EB0
	public virtual void OnPoolAllocated() {} // 0x0000000183D860D0-0x0000000183D86170
	[BlackList] // 0x0000000189B41930-0x0000000189B41970
	// [XID] // 0x0000000189B41930-0x0000000189B41970
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D86030-0x0000000183D860D0
}

