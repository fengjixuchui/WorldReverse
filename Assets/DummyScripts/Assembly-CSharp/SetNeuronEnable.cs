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
public class SetNeuronEnable : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16721
{
	// Fields
	private NeuronName _neuronName; // 0x68
	private bool _enable; // 0x6C

	// Properties
	public NeuronName neuronName { /* [XID] */ /* 0x0000000189701B00-0x0000000189701B20 */ get => default; /* [XID] */ /* 0x0000000189709400-0x0000000189709420 */ private set {} } // 0x0000000180DE36D0-0x0000000180DE3770 0x0000000180DE2CF0-0x0000000180DE2DA0
	public bool enable { /* [XID] */ /* 0x0000000189710CF0-0x0000000189710D10 */ get => default; /* [XID] */ /* 0x0000000189717FF0-0x0000000189718010 */ private set {} } // 0x0000000180DE21F0-0x0000000180DE2290 0x0000000180DE2FF0-0x0000000180DE30A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897A32E0-0x00000001897A3300 */ get => default; } // 0x0000000180DE30A0-0x0000000180DE3140 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897AA880-0x00000001897AA8A0 */ get => default; } // 0x0000000180DE2590-0x0000000180DE2630 

	// Constructors
	public SetNeuronEnable() {} // 0x0000000180DE38B0-0x0000000180DE3910

	// Methods
	// [XID] // 0x000000018971F9F0-0x000000018971FA10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180DE35C0-0x0000000180DE36D0
	// [XID] // 0x0000000189727060-0x0000000189727080
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180DE31A0-0x0000000180DE3250
	// [XID] // 0x000000018972E5D0-0x000000018972E5F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF442E */) => default; // 0x0000000180DE2BB0-0x0000000180DE2C90
	// [XID] // 0x0000000189735D80-0x0000000189735DA0
	public override int GetHashNum() => default; // 0x0000000180DE1750-0x0000000180DE1820
	// [XID] // 0x000000018973D930-0x000000018973D950
	public override void InitEmpty() {} // 0x0000000180DE2630-0x0000000180DE26D0
	[BlackList] // 0x0000000189744D90-0x0000000189744DD0
	// [XID] // 0x0000000189744D90-0x0000000189744DD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000180DE1E70-0x0000000180DE21F0
	// [XID] // 0x000000018974F750-0x000000018974F770
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180DE0EC0-0x0000000180DE11A0
	[BlackList] // 0x0000000189756DA0-0x0000000189756DE0
	// [XID] // 0x0000000189756DA0-0x0000000189756DE0
	public static new SetNeuronEnable ParseFromJson(JSONNode node) => default; // 0x0000000180DE2DA0-0x0000000180DE2FF0
	// [XID] // 0x0000000189761610-0x0000000189761630
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF442F */, bool useObjectPool = false /* Metadata: 0x00AF4433 */) => default; // 0x0000000180DE28B0-0x0000000180DE2BB0
	// [XID] // 0x0000000189768920-0x0000000189768940
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4434 */, bool useObjectPool = false /* Metadata: 0x00AF4438 */) => default; // 0x0000000180DE1970-0x0000000180DE1C10
	// [XID] // 0x000000018976FFD0-0x000000018976FFF0
	public static new SetNeuronEnable ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4439 */, bool useObjectPool = false /* Metadata: 0x00AF443D */) => default; // 0x0000000180DE2290-0x0000000180DE24B0
	[BlackList] // 0x0000000189777750-0x0000000189777790
	// [XID] // 0x0000000189777750-0x0000000189777790
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180DE11A0-0x0000000180DE1470
	// [XID] // 0x00000001897822A0-0x00000001897822C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180DE3330-0x0000000180DE35C0
	[BlackList] // 0x0000000189789600-0x0000000189789640
	// [XID] // 0x0000000189789600-0x0000000189789640
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180DE27B0-0x0000000180DE28B0
	// [XID] // 0x0000000189793B60-0x0000000189793B80
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000180DE3770-0x0000000180DE3810
	// [XID] // 0x000000018979BE50-0x000000018979BE70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000180DE1C10-0x0000000180DE1D70
	[BlackList] // 0x00000001897B2390-0x00000001897B23D0
	// [XID] // 0x00000001897B2390-0x00000001897B23D0
	public override void AutoAllocTypeFields() {} // 0x0000000180DE1470-0x0000000180DE1510
	[BlackList] // 0x00000001897BD920-0x00000001897BD960
	// [XID] // 0x00000001897BD920-0x00000001897BD960
	public override void AutoRecycleTypeFields() {} // 0x0000000180DE1510-0x0000000180DE15C0
	[BlackList] // 0x00000001897C8250-0x00000001897C8290
	// [XID] // 0x00000001897C8250-0x00000001897C8290
	public override void ReturnToObjectPool() {} // 0x0000000180DE3810-0x0000000180DE38B0
}

