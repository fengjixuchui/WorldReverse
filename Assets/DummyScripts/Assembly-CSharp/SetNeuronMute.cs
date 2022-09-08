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
public class SetNeuronMute : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16723
{
	// Fields
	private NeuronName _neuronName; // 0x68
	private bool _enable; // 0x6C

	// Properties
	public NeuronName neuronName { /* [XID] */ /* 0x00000001897DA230-0x00000001897DA250 */ get => default; /* [XID] */ /* 0x00000001897E16A0-0x00000001897E16C0 */ private set {} } // 0x000000018125D920-0x000000018125D9C0 0x000000018125CF40-0x000000018125CFF0
	public bool enable { /* [XID] */ /* 0x00000001897E8F50-0x00000001897E8F70 */ get => default; /* [XID] */ /* 0x00000001897F0B00-0x00000001897F0B20 */ private set {} } // 0x000000018125C4B0-0x000000018125C550 0x000000018125D240-0x000000018125D2F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189872CF0-0x0000000189872D10 */ get => default; } // 0x000000018125D2F0-0x000000018125D390 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018987A9D0-0x000000018987A9F0 */ get => default; } // 0x000000018125C7E0-0x000000018125C880 

	// Constructors
	public SetNeuronMute() {} // 0x000000018125DA60-0x000000018125DAC0

	// Methods
	// [XID] // 0x00000001897F82C0-0x00000001897F82E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018125D810-0x000000018125D920
	// [XID] // 0x00000001897FF9F0-0x00000001897FFA10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018125D3F0-0x000000018125D4A0
	// [XID] // 0x00000001898070B0-0x00000001898070D0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF443E */) => default; // 0x000000018125CE00-0x000000018125CEE0
	// [XID] // 0x000000018980E6B0-0x000000018980E6D0
	public override int GetHashNum() => default; // 0x000000018125BA10-0x000000018125BAE0
	// [XID] // 0x0000000189815E30-0x0000000189815E50
	public override void InitEmpty() {} // 0x000000018125C880-0x000000018125C920
	[BlackList] // 0x000000018981D790-0x000000018981D7D0
	// [XID] // 0x000000018981D790-0x000000018981D7D0
	public override bool FromJson(JSONNode node) => default; // 0x000000018125C130-0x000000018125C4B0
	// [XID] // 0x0000000189827F60-0x0000000189827F80
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018125B180-0x000000018125B460
	[BlackList] // 0x000000018982F200-0x000000018982F240
	// [XID] // 0x000000018982F200-0x000000018982F240
	public static new SetNeuronMute ParseFromJson(JSONNode node) => default; // 0x000000018125CFF0-0x000000018125D240
	// [XID] // 0x0000000189839960-0x0000000189839980
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF443F */, bool useObjectPool = false /* Metadata: 0x00AF4443 */) => default; // 0x000000018125CB00-0x000000018125CE00
	// [XID] // 0x0000000189840E40-0x0000000189840E60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4444 */, bool useObjectPool = false /* Metadata: 0x00AF4448 */) => default; // 0x000000018125BC30-0x000000018125BED0
	// [XID] // 0x0000000189848320-0x0000000189848340
	public static new SetNeuronMute ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4449 */, bool useObjectPool = false /* Metadata: 0x00AF444D */) => default; // 0x000000018125C550-0x000000018125C770
	[BlackList] // 0x000000018984FAA0-0x000000018984FAE0
	// [XID] // 0x000000018984FAA0-0x000000018984FAE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018125B460-0x000000018125B730
	// [XID] // 0x000000018985A0D0-0x000000018985A0F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018125D580-0x000000018125D810
	[BlackList] // 0x0000000189861250-0x0000000189861290
	// [XID] // 0x0000000189861250-0x0000000189861290
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018125CA00-0x000000018125CB00
	// [XID] // 0x000000018986BA60-0x000000018986BA80
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018125BED0-0x000000018125C030
	[BlackList] // 0x0000000189881AC0-0x0000000189881B00
	// [XID] // 0x0000000189881AC0-0x0000000189881B00
	public override void AutoAllocTypeFields() {} // 0x000000018125B730-0x000000018125B7D0
	[BlackList] // 0x000000018988BF80-0x000000018988BFC0
	// [XID] // 0x000000018988BF80-0x000000018988BFC0
	public override void AutoRecycleTypeFields() {} // 0x000000018125B7D0-0x000000018125B880
	[BlackList] // 0x00000001898962A0-0x00000001898962E0
	// [XID] // 0x00000001898962A0-0x00000001898962E0
	public override void ReturnToObjectPool() {} // 0x000000018125D9C0-0x000000018125DA60
}

