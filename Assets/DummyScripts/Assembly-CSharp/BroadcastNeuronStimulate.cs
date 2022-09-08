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
public class BroadcastNeuronStimulate : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16725
{
	// Fields
	private NeuronName _neuronName; // 0x68
	private bool _stimulate; // 0x6C
	private SimpleSafeFloat rangeRawNum; // 0x70

	// Properties
	public NeuronName neuronName { /* [XID] */ /* 0x00000001898A7E10-0x00000001898A7E30 */ get => default; /* [XID] */ /* 0x00000001898AF910-0x00000001898AF930 */ private set {} } // 0x0000000184625720-0x00000001846257C0 0x0000000184624CB0-0x0000000184624D60
	public bool stimulate { /* [XID] */ /* 0x00000001898B6EB0-0x00000001898B6ED0 */ get => default; /* [XID] */ /* 0x00000001898BE620-0x00000001898BE640 */ private set {} } // 0x0000000184625550-0x00000001846255F0 0x0000000184623600-0x00000001846236B0
	public float range { /* [XID] */ /* 0x00000001898C5DD0-0x00000001898C5DF0 */ get => default; /* [XID] */ /* 0x00000001898CD5C0-0x00000001898CD5E0 */ private set {} } // 0x00000001846232C0-0x00000001846233A0 0x0000000184623780-0x0000000184623860
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189959350-0x0000000189959370 */ get => default; } // 0x0000000184624FB0-0x0000000184625050 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189960BA0-0x0000000189960BC0 */ get => default; } // 0x0000000184624520-0x00000001846245C0 

	// Constructors
	public BroadcastNeuronStimulate() {} // 0x0000000184625900-0x0000000184625960

	// Methods
	// [XID] // 0x00000001898D4FB0-0x00000001898D4FD0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001846255F0-0x0000000184625720
	// [XID] // 0x00000001898DC910-0x00000001898DC930
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001846250B0-0x0000000184625160
	// [XID] // 0x00000001898E43C0-0x00000001898E43E0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF444E */) => default; // 0x0000000184624B70-0x0000000184624C50
	// [XID] // 0x00000001898EBDF0-0x00000001898EBE10
	public override int GetHashNum() => default; // 0x0000000184623530-0x0000000184623600
	// [XID] // 0x00000001898F36A0-0x00000001898F36C0
	public override void InitEmpty() {} // 0x00000001846245C0-0x0000000184624690
	[BlackList] // 0x00000001898FACE0-0x00000001898FAD20
	// [XID] // 0x00000001898FACE0-0x00000001898FAD20
	public override bool FromJson(JSONNode node) => default; // 0x0000000184623EA0-0x0000000184624220
	// [XID] // 0x00000001899057A0-0x00000001899057C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184622A60-0x0000000184622E70
	[BlackList] // 0x000000018990CFD0-0x000000018990D010
	// [XID] // 0x000000018990CFD0-0x000000018990D010
	public static new BroadcastNeuronStimulate ParseFromJson(JSONNode node) => default; // 0x0000000184624D60-0x0000000184624FB0
	// [XID] // 0x0000000189917B00-0x0000000189917B20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF444F */, bool useObjectPool = false /* Metadata: 0x00AF4453 */) => default; // 0x0000000184624870-0x0000000184624B70
	// [XID] // 0x000000018991F040-0x000000018991F060
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4454 */, bool useObjectPool = false /* Metadata: 0x00AF4458 */) => default; // 0x00000001846238E0-0x0000000184623C40
	// [XID] // 0x0000000189926B00-0x0000000189926B20
	public static new BroadcastNeuronStimulate ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4459 */, bool useObjectPool = false /* Metadata: 0x00AF445D */) => default; // 0x0000000184624220-0x0000000184624440
	[BlackList] // 0x000000018992E0F0-0x000000018992E130
	// [XID] // 0x000000018992E0F0-0x000000018992E130
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184622E70-0x0000000184623140
	// [XID] // 0x0000000189938450-0x0000000189938470
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184625240-0x0000000184625550
	[BlackList] // 0x000000018993FE20-0x000000018993FE60
	// [XID] // 0x000000018993FE20-0x000000018993FE60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184624770-0x0000000184624870
	// [XID] // 0x000000018994A300-0x000000018994A320
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001846257C0-0x0000000184625860
	// [XID] // 0x0000000189951DF0-0x0000000189951E10
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184623C40-0x0000000184623DA0
	[BlackList] // 0x0000000189968340-0x0000000189968380
	// [XID] // 0x0000000189968340-0x0000000189968380
	public override void AutoAllocTypeFields() {} // 0x0000000184623140-0x00000001846231E0
	[BlackList] // 0x0000000189972C30-0x0000000189972C70
	// [XID] // 0x0000000189972C30-0x0000000189972C70
	public override void AutoRecycleTypeFields() {} // 0x00000001846231E0-0x00000001846232C0
	[BlackList] // 0x000000018997CC70-0x000000018997CCB0
	// [XID] // 0x000000018997CC70-0x000000018997CCB0
	public override void ReturnToObjectPool() {} // 0x0000000184625860-0x0000000184625900
}

