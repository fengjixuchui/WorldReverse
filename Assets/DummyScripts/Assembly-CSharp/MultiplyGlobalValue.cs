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
public class MultiplyGlobalValue : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16395
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x68
	private string _key; // 0x70
	private bool _useLimitRange; // 0x78
	private bool _randomInRange; // 0x79
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxValue; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _minValue; // 0x88

	// Properties
	public DynamicFloat value { /* [XID] */ /* 0x00000001897E1780-0x00000001897E17A0 */ get => default; /* [XID] */ /* 0x00000001897E8FB0-0x00000001897E8FD0 */ private set {} } // 0x0000000181F21D60-0x0000000181F21E00 0x0000000181F21C30-0x0000000181F21CE0
	public string key { /* [XID] */ /* 0x00000001897F0BC0-0x00000001897F0BE0 */ get => default; /* [XID] */ /* 0x00000001897F83A0-0x00000001897F83C0 */ private set {} } // 0x0000000181F21270-0x0000000181F21310 0x0000000181F23140-0x0000000181F231F0
	public bool useLimitRange { /* [XID] */ /* 0x00000001897FFAD0-0x00000001897FFAF0 */ get => default; /* [XID] */ /* 0x0000000189807190-0x00000001898071B0 */ private set {} } // 0x0000000181F21460-0x0000000181F21500 0x0000000181F23A00-0x0000000181F23AB0
	public bool randomInRange { /* [XID] */ /* 0x000000018980E750-0x000000018980E770 */ get => default; /* [XID] */ /* 0x0000000189815EF0-0x0000000189815F10 */ private set {} } // 0x0000000181F22450-0x0000000181F224F0 0x0000000181F22D30-0x0000000181F22DE0
	public DynamicFloat maxValue { /* [XID] */ /* 0x000000018981D850-0x000000018981D870 */ get => default; /* [XID] */ /* 0x0000000189824D00-0x0000000189824D20 */ private set {} } // 0x0000000181F22560-0x0000000181F22610 0x0000000181F211C0-0x0000000181F21270
	public DynamicFloat minValue { /* [XID] */ /* 0x000000018982C6F0-0x000000018982C710 */ get => default; /* [XID] */ /* 0x0000000189833C80-0x0000000189833CA0 */ private set {} } // 0x0000000181F22E40-0x0000000181F22EF0 0x0000000181F21E00-0x0000000181F21EB0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898B5730-0x00000001898B5750 */ get => default; } // 0x0000000181F231F0-0x0000000181F23290 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898BD200-0x00000001898BD220 */ get => default; } // 0x0000000181F22610-0x0000000181F226B0 

	// Constructors
	public MultiplyGlobalValue() {} // 0x0000000181F23D10-0x0000000181F23DD0

	// Methods
	// [XID] // 0x000000018983B200-0x000000018983B220
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F23AB0-0x0000000181F23C70
	// [XID] // 0x0000000189842AA0-0x0000000189842AC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181F232F0-0x0000000181F23420
	// [XID] // 0x0000000189849DF0-0x0000000189849E10
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A20 */) => default; // 0x0000000181F22C50-0x0000000181F22D30
	// [XID] // 0x0000000189851430-0x0000000189851450
	public override int GetHashNum() => default; // 0x0000000181F210F0-0x0000000181F211C0
	// [XID] // 0x00000001898589A0-0x00000001898589C0
	public override void InitEmpty() {} // 0x0000000181F226B0-0x0000000181F22780
	[BlackList] // 0x000000018985FA90-0x000000018985FAD0
	// [XID] // 0x000000018985FA90-0x000000018985FAD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181F21EB0-0x0000000181F22230
	// [XID] // 0x000000018986A2A0-0x000000018986A2C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181F203E0-0x0000000181F209C0
	[BlackList] // 0x0000000189871670-0x00000001898716B0
	// [XID] // 0x0000000189871670-0x00000001898716B0
	public static new MultiplyGlobalValue ParseFromJson(JSONNode node) => default; // 0x0000000181F22EF0-0x0000000181F23140
	// [XID] // 0x000000018987BFC0-0x000000018987BFE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A21 */, bool useObjectPool = false /* Metadata: 0x00AF3A25 */) => default; // 0x0000000181F22950-0x0000000181F22C50
	// [XID] // 0x00000001898830F0-0x0000000189883110
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A26 */, bool useObjectPool = false /* Metadata: 0x00AF3A2A */) => default; // 0x0000000181F21500-0x0000000181F21A50
	// [XID] // 0x000000018988A8D0-0x000000018988A8F0
	public static new MultiplyGlobalValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A2B */, bool useObjectPool = false /* Metadata: 0x00AF3A2F */) => default; // 0x0000000181F22230-0x0000000181F22450
	[BlackList] // 0x0000000189891D00-0x0000000189891D40
	// [XID] // 0x0000000189891D00-0x0000000189891D40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F209C0-0x0000000181F20C90
	// [XID] // 0x000000018989C380-0x000000018989C3A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F23500-0x0000000181F23A00
	[BlackList] // 0x00000001898A39C0-0x00000001898A3A00
	// [XID] // 0x00000001898A39C0-0x00000001898A3A00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181F22860-0x0000000181F22950
	// [XID] // 0x00000001898AE250-0x00000001898AE270
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181F21A50-0x0000000181F21BB0
	[BlackList] // 0x00000001898C4940-0x00000001898C4980
	// [XID] // 0x00000001898C4940-0x00000001898C4980
	public override void AutoAllocTypeFields() {} // 0x0000000181F20C90-0x0000000181F20D30
	[BlackList] // 0x00000001898CF010-0x00000001898CF050
	// [XID] // 0x00000001898CF010-0x00000001898CF050
	public override void AutoRecycleTypeFields() {} // 0x0000000181F20D30-0x0000000181F20F60
	[BlackList] // 0x00000001898D9810-0x00000001898D9850
	// [XID] // 0x00000001898D9810-0x00000001898D9850
	public override void ReturnToObjectPool() {} // 0x0000000181F23C70-0x0000000181F23D10
}

