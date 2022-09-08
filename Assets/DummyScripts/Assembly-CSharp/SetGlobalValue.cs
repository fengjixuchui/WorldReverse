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
public class SetGlobalValue : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16393
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
	public DynamicFloat value { /* [XID] */ /* 0x00000001896BEF90-0x00000001896BEFB0 */ get => default; /* [XID] */ /* 0x00000001896C6910-0x00000001896C6930 */ private set {} } // 0x0000000185099F00-0x0000000185099FA0 0x0000000185099DD0-0x0000000185099E80
	public string key { /* [XID] */ /* 0x00000001896CDF70-0x00000001896CDF90 */ get => default; /* [XID] */ /* 0x00000001896D54E0-0x00000001896D5500 */ private set {} } // 0x0000000185099410-0x00000001850994B0 0x000000018509B2E0-0x000000018509B390
	public bool useLimitRange { /* [XID] */ /* 0x00000001896DCA40-0x00000001896DCA60 */ get => default; /* [XID] */ /* 0x00000001896E43B0-0x00000001896E43D0 */ private set {} } // 0x0000000185099600-0x00000001850996A0 0x000000018509BBA0-0x000000018509BC50
	public bool randomInRange { /* [XID] */ /* 0x00000001896EB7C0-0x00000001896EB7E0 */ get => default; /* [XID] */ /* 0x00000001896F2BD0-0x00000001896F2BF0 */ private set {} } // 0x000000018509A5F0-0x000000018509A690 0x000000018509AED0-0x000000018509AF80
	public DynamicFloat maxValue { /* [XID] */ /* 0x00000001896FA4F0-0x00000001896FA510 */ get => default; /* [XID] */ /* 0x0000000189701C20-0x0000000189701C40 */ private set {} } // 0x000000018509A700-0x000000018509A7B0 0x0000000185099360-0x0000000185099410
	public DynamicFloat minValue { /* [XID] */ /* 0x0000000189709520-0x0000000189709540 */ get => default; /* [XID] */ /* 0x0000000189710D70-0x0000000189710D90 */ private set {} } // 0x000000018509AFE0-0x000000018509B090 0x0000000185099FA0-0x000000018509A050
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189793BE0-0x0000000189793C00 */ get => default; } // 0x000000018509B390-0x000000018509B430 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018979BF50-0x000000018979BF70 */ get => default; } // 0x000000018509A7B0-0x000000018509A850 

	// Constructors
	public SetGlobalValue() {} // 0x000000018509BEB0-0x000000018509BF70

	// Methods
	// [XID] // 0x00000001897180D0-0x00000001897180F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018509BC50-0x000000018509BE10
	// [XID] // 0x000000018971FAB0-0x000000018971FAD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018509B490-0x000000018509B5C0
	// [XID] // 0x0000000189727140-0x0000000189727160
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A10 */) => default; // 0x000000018509ADF0-0x000000018509AED0
	// [XID] // 0x000000018972E710-0x000000018972E730
	public override int GetHashNum() => default; // 0x0000000185099290-0x0000000185099360
	// [XID] // 0x0000000189735EA0-0x0000000189735EC0
	public override void InitEmpty() {} // 0x000000018509A850-0x000000018509A920
	[BlackList] // 0x000000018973DA30-0x000000018973DA70
	// [XID] // 0x000000018973DA30-0x000000018973DA70
	public override bool FromJson(JSONNode node) => default; // 0x000000018509A050-0x000000018509A3D0
	// [XID] // 0x00000001897480A0-0x00000001897480C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185098580-0x0000000185098B60
	[BlackList] // 0x000000018974F850-0x000000018974F890
	// [XID] // 0x000000018974F850-0x000000018974F890
	public static new SetGlobalValue ParseFromJson(JSONNode node) => default; // 0x000000018509B090-0x000000018509B2E0
	// [XID] // 0x0000000189759A60-0x0000000189759A80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A11 */, bool useObjectPool = false /* Metadata: 0x00AF3A15 */) => default; // 0x000000018509AAF0-0x000000018509ADF0
	// [XID] // 0x00000001897616B0-0x00000001897616D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A16 */, bool useObjectPool = false /* Metadata: 0x00AF3A1A */) => default; // 0x00000001850996A0-0x0000000185099BF0
	// [XID] // 0x00000001897689E0-0x0000000189768A00
	public static new SetGlobalValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A1B */, bool useObjectPool = false /* Metadata: 0x00AF3A1F */) => default; // 0x000000018509A3D0-0x000000018509A5F0
	[BlackList] // 0x00000001897700F0-0x0000000189770130
	// [XID] // 0x00000001897700F0-0x0000000189770130
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185098B60-0x0000000185098E30
	// [XID] // 0x000000018977A760-0x000000018977A780
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018509B6A0-0x000000018509BBA0
	[BlackList] // 0x00000001897823A0-0x00000001897823E0
	// [XID] // 0x00000001897823A0-0x00000001897823E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018509AA00-0x000000018509AAF0
	// [XID] // 0x000000018978C710-0x000000018978C730
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185099BF0-0x0000000185099D50
	[BlackList] // 0x00000001897A33C0-0x00000001897A3400
	// [XID] // 0x00000001897A33C0-0x00000001897A3400
	public override void AutoAllocTypeFields() {} // 0x0000000185098E30-0x0000000185098ED0
	[BlackList] // 0x00000001897ADA70-0x00000001897ADAB0
	// [XID] // 0x00000001897ADA70-0x00000001897ADAB0
	public override void AutoRecycleTypeFields() {} // 0x0000000185098ED0-0x0000000185099100
	[BlackList] // 0x00000001897B88A0-0x00000001897B88E0
	// [XID] // 0x00000001897B88A0-0x00000001897B88E0
	public override void ReturnToObjectPool() {} // 0x000000018509BE10-0x000000018509BEB0
}

