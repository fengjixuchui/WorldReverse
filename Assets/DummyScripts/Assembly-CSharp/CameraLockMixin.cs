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
public class CameraLockMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17037
{
	// Fields
	private string _transName; // 0x30
	private string _cfgPath; // 0x38

	// Properties
	public string transName { /* [XID] */ /* 0x0000000189AB31A0-0x0000000189AB31C0 */ get => default; /* [XID] */ /* 0x0000000189ABAED0-0x0000000189ABAEF0 */ private set {} } // 0x000000018156EF60-0x000000018156F000 0x000000018156D640-0x000000018156D6F0
	public string cfgPath { /* [XID] */ /* 0x0000000189AC2740-0x0000000189AC2760 */ get => default; /* [XID] */ /* 0x0000000189AC9D60-0x0000000189AC9D80 */ private set {} } // 0x000000018156F000-0x000000018156F0A0 0x000000018156EAA0-0x000000018156EB50
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B4D8E0-0x0000000189B4D900 */ get => default; } // 0x000000018156DB70-0x000000018156DC10 

	// Constructors
	public CameraLockMixin() {} // 0x000000018156F4E0-0x000000018156F540

	// Methods
	// [XID] // 0x0000000189AD16B0-0x0000000189AD16D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018156F330-0x000000018156F440
	// [XID] // 0x0000000189AD93D0-0x0000000189AD93F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018156EE60-0x000000018156EF60
	// [XID] // 0x0000000189AE0F20-0x0000000189AE0F40
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6123 */) => default; // 0x000000018156E9C0-0x000000018156EAA0
	// [XID] // 0x0000000189AE82F0-0x0000000189AE8310
	public override int GetHashNum() => default; // 0x000000018156D510-0x000000018156D5E0
	// [XID] // 0x0000000189AF0230-0x0000000189AF0250
	public override void InitEmpty() {} // 0x000000018156E320-0x000000018156E410
	[BlackList] // 0x0000000189AF7680-0x0000000189AF76C0
	// [XID] // 0x0000000189AF7680-0x0000000189AF76C0
	public override bool FromJson(JSONNode node) => default; // 0x000000018156DC10-0x000000018156DF90
	// [XID] // 0x0000000189B01D90-0x0000000189B01DB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018156CCC0-0x000000018156CFD0
	[BlackList] // 0x0000000189B092D0-0x0000000189B09310
	// [XID] // 0x0000000189B092D0-0x0000000189B09310
	public static new CameraLockMixin ParseFromJson(JSONNode node) => default; // 0x000000018156EBB0-0x000000018156EE00
	// [XID] // 0x0000000189B138F0-0x0000000189B13910
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6124 */, bool useObjectPool = false /* Metadata: 0x00AF6128 */) => default; // 0x000000018156E5E0-0x000000018156E8E0
	// [XID] // 0x0000000189B1AF40-0x0000000189B1AF60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6129 */, bool useObjectPool = false /* Metadata: 0x00AF612D */) => default; // 0x000000018156D770-0x000000018156DA70
	// [XID] // 0x0000000189B22690-0x0000000189B226B0
	public static new CameraLockMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF612E */, bool useObjectPool = false /* Metadata: 0x00AF6132 */) => default; // 0x000000018156E000-0x000000018156E220
	[BlackList] // 0x0000000189B29BE0-0x0000000189B29C20
	// [XID] // 0x0000000189B29BE0-0x0000000189B29C20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018156CFD0-0x000000018156D2A0
	// [XID] // 0x0000000189B33F20-0x0000000189B33F40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018156F0A0-0x000000018156F330
	[BlackList] // 0x0000000189B3B7F0-0x0000000189B3B830
	// [XID] // 0x0000000189B3B7F0-0x0000000189B3B830
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018156E4F0-0x000000018156E5E0
	// [XID] // 0x0000000189B46380-0x0000000189B463A0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018156E8E0-0x000000018156E9C0
	[BlackList] // 0x0000000189B551B0-0x0000000189B551F0
	// [XID] // 0x0000000189B551B0-0x0000000189B551F0
	public override void AutoAllocTypeFields() {} // 0x000000018156D2A0-0x000000018156D340
	[BlackList] // 0x0000000189B5FD60-0x0000000189B5FDA0
	// [XID] // 0x0000000189B5FD60-0x0000000189B5FDA0
	public override void AutoRecycleTypeFields() {} // 0x000000018156D340-0x000000018156D3F0
	[BlackList] // 0x0000000189B6A2F0-0x0000000189B6A330
	// [XID] // 0x0000000189B6A2F0-0x0000000189B6A330
	public override void ReturnToObjectPool() {} // 0x000000018156F440-0x000000018156F4E0
}

