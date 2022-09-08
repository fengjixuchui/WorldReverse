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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class WindZoneMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16938
{
	// Fields
	private string _shapeName; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _strength; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _attenuation; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _innerRadius; // 0x50
	private bool _reverse; // 0x58
	private TargetType _targetType; // 0x5C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x60
	private string _modifierName; // 0x68
	private SimpleSafeUInt32 maxNumRawNum; // 0x70
	private SimpleSafeFloat forceGrowthRawNum; // 0x74
	private SimpleSafeFloat forceFallenRawNum; // 0x78

	// Properties
	public string shapeName { /* [XID] */ /* 0x0000000189728730-0x0000000189728750 */ get => default; /* [XID] */ /* 0x000000018972FEA0-0x000000018972FEC0 */ private set {} } // 0x0000000181DABA10-0x0000000181DABAB0 0x0000000181DADA20-0x0000000181DADAD0
	public ConfigBornType born { /* [XID] */ /* 0x0000000189737760-0x0000000189737780 */ get => default; /* [XID] */ /* 0x000000018973F280-0x000000018973F2A0 */ private set {} } // 0x0000000181DAA760-0x0000000181DAA800 0x0000000181DADDF0-0x0000000181DADEA0
	public DynamicFloat strength { /* [XID] */ /* 0x0000000189746580-0x00000001897465A0 */ get => default; /* [XID] */ /* 0x000000018974E050-0x000000018974E070 */ private set {} } // 0x0000000181DA8FE0-0x0000000181DA9080 0x0000000181DA9CF0-0x0000000181DA9DA0
	public DynamicFloat attenuation { /* [XID] */ /* 0x0000000189755790-0x00000001897557B0 */ get => default; /* [XID] */ /* 0x000000018975CA90-0x000000018975CAB0 */ private set {} } // 0x0000000181DAC920-0x0000000181DAC9C0 0x0000000181DABBB0-0x0000000181DABC60
	public DynamicFloat innerRadius { /* [XID] */ /* 0x0000000189764240-0x0000000189764260 */ get => default; /* [XID] */ /* 0x000000018976BB00-0x000000018976BB20 */ private set {} } // 0x0000000181DAC1E0-0x0000000181DAC280 0x0000000181DADAD0-0x0000000181DADB80
	public bool reverse { /* [XID] */ /* 0x0000000189773020-0x0000000189773040 */ get => default; /* [XID] */ /* 0x000000018977A5E0-0x000000018977A600 */ private set {} } // 0x0000000181DAA420-0x0000000181DAA4C0 0x0000000181DAA5E0-0x0000000181DAA690
	public TargetType targetType { /* [XID] */ /* 0x00000001897821C0-0x00000001897821E0 */ get => default; /* [XID] */ /* 0x0000000189789560-0x0000000189789580 */ private set {} } // 0x0000000181DABC60-0x0000000181DABD00 0x0000000181DA9100-0x0000000181DA91B0
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x0000000189790C10-0x0000000189790C30 */ get => default; /* [XID] */ /* 0x0000000189798580-0x00000001897985A0 */ private set {} } // 0x0000000181DACFC0-0x0000000181DAD060 0x0000000181DAC740-0x0000000181DAC7F0
	public string modifierName { /* [XID] */ /* 0x00000001897A0410-0x00000001897A0430 */ get => default; /* [XID] */ /* 0x00000001897A7A20-0x00000001897A7A40 */ private set {} } // 0x0000000181DADEA0-0x0000000181DADF40 0x0000000181DAC040-0x0000000181DAC0F0
	public uint maxNum { /* [XID] */ /* 0x00000001897AF470-0x00000001897AF490 */ get => default; /* [XID] */ /* 0x00000001897B72D0-0x00000001897B72F0 */ private set {} } // 0x0000000181DAC7F0-0x0000000181DAC8C0 0x0000000181DAD940-0x0000000181DADA20
	public float forceGrowth { /* [XID] */ /* 0x00000001897BF1F0-0x00000001897BF210 */ get => default; /* [XID] */ /* 0x00000001897C67A0-0x00000001897C67C0 */ private set {} } // 0x0000000181DACEE0-0x0000000181DACFC0 0x0000000181DABD00-0x0000000181DABDE0
	public float forceFallen { /* [XID] */ /* 0x00000001897CDF60-0x00000001897CDF80 */ get => default; /* [XID] */ /* 0x00000001897D5510-0x00000001897D5530 */ private set {} } // 0x0000000181DACE00-0x0000000181DACEE0 0x0000000181DAB6A0-0x0000000181DAB780
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189858860-0x0000000189858880 */ get => default; } // 0x0000000181DAB280-0x0000000181DAB320 

	// Constructors
	public WindZoneMixin() {} // 0x0000000181DADFE0-0x0000000181DAE120

	// Methods
	// [XID] // 0x00000001897DCC50-0x00000001897DCC70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181DADB80-0x0000000181DADDF0
	// [XID] // 0x00000001897E45B0-0x00000001897E45D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181DACC70-0x0000000181DACE00
	// [XID] // 0x00000001897EC0E0-0x00000001897EC100
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E1D */) => default; // 0x0000000181DAC660-0x0000000181DAC740
	// [XID] // 0x00000001897F3A90-0x00000001897F3AB0
	public override int GetHashNum() => default; // 0x0000000181DAA690-0x0000000181DAA760
	// [XID] // 0x00000001897FB490-0x00000001897FB4B0
	public override void InitEmpty() {} // 0x0000000181DABDE0-0x0000000181DABF60
	[BlackList] // 0x00000001898028A0-0x00000001898028E0
	// [XID] // 0x00000001898028A0-0x00000001898028E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181DAB320-0x0000000181DAB6A0
	// [XID] // 0x000000018980CB70-0x000000018980CB90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181DA91B0-0x0000000181DA9CF0
	[BlackList] // 0x0000000189814410-0x0000000189814450
	// [XID] // 0x0000000189814410-0x0000000189814450
	public static new WindZoneMixin ParseFromJson(JSONNode node) => default; // 0x0000000181DAC9C0-0x0000000181DACC10
	// [XID] // 0x000000018981EFA0-0x000000018981EFC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E1E */, bool useObjectPool = false /* Metadata: 0x00AF5E22 */) => default; // 0x0000000181DAC280-0x0000000181DAC580
	// [XID] // 0x00000001898264B0-0x00000001898264D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E23 */, bool useObjectPool = false /* Metadata: 0x00AF5E27 */) => default; // 0x0000000181DAA8E0-0x0000000181DAB180
	// [XID] // 0x000000018982DB20-0x000000018982DB40
	public static new WindZoneMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E28 */, bool useObjectPool = false /* Metadata: 0x00AF5E2C */) => default; // 0x0000000181DAB7F0-0x0000000181DABA10
	[BlackList] // 0x0000000189835210-0x0000000189835250
	// [XID] // 0x0000000189835210-0x0000000189835250
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181DA9DA0-0x0000000181DAA070
	// [XID] // 0x000000018983F890-0x000000018983F8B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181DAD060-0x0000000181DAD940
	[BlackList] // 0x0000000189846ED0-0x0000000189846F10
	// [XID] // 0x0000000189846ED0-0x0000000189846F10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181DAC0F0-0x0000000181DAC1E0
	// [XID] // 0x0000000189851390-0x00000001898513B0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181DAC580-0x0000000181DAC660
	[BlackList] // 0x000000018985F950-0x000000018985F990
	// [XID] // 0x000000018985F950-0x000000018985F990
	public override void AutoAllocTypeFields() {} // 0x0000000181DAA070-0x0000000181DAA110
	[BlackList] // 0x000000018986A160-0x000000018986A1A0
	// [XID] // 0x000000018986A160-0x000000018986A1A0
	public override void AutoRecycleTypeFields() {} // 0x0000000181DAA110-0x0000000181DAA420
	[BlackList] // 0x00000001898742A0-0x00000001898742E0
	// [XID] // 0x00000001898742A0-0x00000001898742E0
	public override void ReturnToObjectPool() {} // 0x0000000181DADF40-0x0000000181DADFE0
}

