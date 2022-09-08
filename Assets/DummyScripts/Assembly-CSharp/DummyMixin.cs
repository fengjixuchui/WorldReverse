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
public class DummyMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17135
{
	// Fields
	private ConfigAbilityAction[][] _actionList; // 0x30

	// Properties
	public ConfigAbilityAction[][] actionList { /* [XID] */ /* 0x000000018978F580-0x000000018978F5A0 */ get => default; /* [XID] */ /* 0x0000000189796D30-0x0000000189796D50 */ private set {} } // 0x00000001822F39E0-0x00000001822F3A80 0x00000001822F3830-0x00000001822F38E0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018981BEC0-0x000000018981BEE0 */ get => default; } // 0x00000001822F3A80-0x00000001822F3B20 

	// Constructors
	public DummyMixin() {} // 0x00000001822F5150-0x00000001822F51B0

	// Methods
	// [XID] // 0x000000018979EE50-0x000000018979EE70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822F4FC0-0x00000001822F50B0
	// [XID] // 0x00000001897A6420-0x00000001897A6440
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001822F4CA0-0x00000001822F4D80
	// [XID] // 0x00000001897AD970-0x00000001897AD990
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6451 */) => default; // 0x00000001822F48B0-0x00000001822F4990
	// [XID] // 0x00000001897B5A70-0x00000001897B5A90
	public override int GetHashNum() => default; // 0x00000001822F3410-0x00000001822F34E0
	// [XID] // 0x00000001897BD7E0-0x00000001897BD800
	public override void InitEmpty() {} // 0x00000001822F4230-0x00000001822F4300
	[BlackList] // 0x00000001897C4BA0-0x00000001897C4BE0
	// [XID] // 0x00000001897C4BA0-0x00000001897C4BE0
	public override bool FromJson(JSONNode node) => default; // 0x00000001822F3B20-0x00000001822F3EA0
	// [XID] // 0x00000001897CF3F0-0x00000001897CF410
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822F2CA0-0x00000001822F2ED0
	[BlackList] // 0x00000001897D6CC0-0x00000001897D6D00
	// [XID] // 0x00000001897D6CC0-0x00000001897D6D00
	public static new DummyMixin ParseFromJson(JSONNode node) => default; // 0x00000001822F49F0-0x00000001822F4C40
	// [XID] // 0x00000001897E1580-0x00000001897E15A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6452 */, bool useObjectPool = false /* Metadata: 0x00AF6456 */) => default; // 0x00000001822F44D0-0x00000001822F47D0
	// [XID] // 0x00000001897E8DD0-0x00000001897E8DF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6457 */, bool useObjectPool = false /* Metadata: 0x00AF645B */) => default; // 0x00000001822F35C0-0x00000001822F3830
	// [XID] // 0x00000001897F0A20-0x00000001897F0A40
	public static new DummyMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF645C */, bool useObjectPool = false /* Metadata: 0x00AF6460 */) => default; // 0x00000001822F3F10-0x00000001822F4130
	[BlackList] // 0x00000001897F8120-0x00000001897F8160
	// [XID] // 0x00000001897F8120-0x00000001897F8160
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001822F2ED0-0x00000001822F31A0
	// [XID] // 0x00000001898027A0-0x00000001898027C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822F4D80-0x00000001822F4FC0
	[BlackList] // 0x0000000189809E50-0x0000000189809E90
	// [XID] // 0x0000000189809E50-0x0000000189809E90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001822F43E0-0x00000001822F44D0
	// [XID] // 0x0000000189814390-0x00000001898143B0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001822F47D0-0x00000001822F48B0
	[BlackList] // 0x0000000189823370-0x00000001898233B0
	// [XID] // 0x0000000189823370-0x00000001898233B0
	public override void AutoAllocTypeFields() {} // 0x00000001822F31A0-0x00000001822F3240
	[BlackList] // 0x000000018982DA60-0x000000018982DAA0
	// [XID] // 0x000000018982DA60-0x000000018982DAA0
	public override void AutoRecycleTypeFields() {} // 0x00000001822F3240-0x00000001822F32F0
	[BlackList] // 0x0000000189838100-0x0000000189838140
	// [XID] // 0x0000000189838100-0x0000000189838140
	public override void ReturnToObjectPool() {} // 0x00000001822F50B0-0x00000001822F5150
}

