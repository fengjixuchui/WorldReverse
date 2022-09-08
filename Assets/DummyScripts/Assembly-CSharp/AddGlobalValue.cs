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
public class AddGlobalValue : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16391
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
	public DynamicFloat value { /* [XID] */ /* 0x0000000189B90B70-0x0000000189B90B90 */ get => default; /* [XID] */ /* 0x0000000189B97F00-0x0000000189B97F20 */ private set {} } // 0x0000000184263600-0x00000001842636A0 0x00000001842634D0-0x0000000184263580
	public string key { /* [XID] */ /* 0x0000000189B9F330-0x0000000189B9F350 */ get => default; /* [XID] */ /* 0x0000000189BA6BA0-0x0000000189BA6BC0 */ private set {} } // 0x0000000184262B10-0x0000000184262BB0 0x0000000184264A50-0x0000000184264B00
	public bool useLimitRange { /* [XID] */ /* 0x0000000189BADD60-0x0000000189BADD80 */ get => default; /* [XID] */ /* 0x0000000189BB5570-0x0000000189BB5590 */ private set {} } // 0x0000000184262D00-0x0000000184262DA0 0x0000000184265310-0x00000001842653C0
	public bool randomInRange { /* [XID] */ /* 0x0000000189BBCC40-0x0000000189BBCC60 */ get => default; /* [XID] */ /* 0x0000000189BC4900-0x0000000189BC4920 */ private set {} } // 0x0000000184263D60-0x0000000184263E00 0x0000000184264640-0x00000001842646F0
	public DynamicFloat maxValue { /* [XID] */ /* 0x0000000189BCC300-0x0000000189BCC320 */ get => default; /* [XID] */ /* 0x0000000189BD3990-0x0000000189BD39B0 */ private set {} } // 0x0000000184263E70-0x0000000184263F20 0x0000000184262A60-0x0000000184262B10
	public DynamicFloat minValue { /* [XID] */ /* 0x0000000189BDB340-0x0000000189BDB360 */ get => default; /* [XID] */ /* 0x00000001895E7C30-0x00000001895E7C50 */ private set {} } // 0x0000000184264750-0x0000000184264800 0x00000001842636A0-0x0000000184263750
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189673380-0x00000001896733A0 */ get => default; } // 0x0000000184264B00-0x0000000184264BA0 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018967ABE0-0x000000018967AC00 */ get => default; } // 0x0000000184263F20-0x0000000184263FC0 

	// Constructors
	public AddGlobalValue() {} // 0x00000001842656C0-0x0000000184265780

	// Methods
	// [XID] // 0x00000001895EF5C0-0x00000001895EF5E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842653C0-0x0000000184265580
	// [XID] // 0x00000001895F6FC0-0x00000001895F6FE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184264C00-0x0000000184264D30
	// [XID] // 0x00000001895FE360-0x00000001895FE380
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A00 */) => default; // 0x0000000184264560-0x0000000184264640
	// [XID] // 0x0000000189605C30-0x0000000189605C50
	public override int GetHashNum() => default; // 0x0000000184262990-0x0000000184262A60
	// [XID] // 0x000000018960D520-0x000000018960D540
	public override void InitEmpty() {} // 0x0000000184263FC0-0x0000000184264090
	[BlackList] // 0x0000000189614C00-0x0000000189614C40
	// [XID] // 0x0000000189614C00-0x0000000189614C40
	public override bool FromJson(JSONNode node) => default; // 0x0000000184263750-0x0000000184263AD0
	// [XID] // 0x000000018961F4E0-0x000000018961F500
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184261C80-0x0000000184262260
	[BlackList] // 0x0000000189626900-0x0000000189626940
	// [XID] // 0x0000000189626900-0x0000000189626940
	public static new AddGlobalValue ParseFromJson(JSONNode node) => default; // 0x0000000184264800-0x0000000184264A50
	// [XID] // 0x0000000189631360-0x0000000189631380
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A01 */, bool useObjectPool = false /* Metadata: 0x00AF3A05 */) => default; // 0x0000000184264260-0x0000000184264560
	// [XID] // 0x0000000189638D10-0x0000000189638D30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A06 */, bool useObjectPool = false /* Metadata: 0x00AF3A0A */) => default; // 0x0000000184262DA0-0x00000001842632F0
	// [XID] // 0x00000001896401B0-0x00000001896401D0
	public static new AddGlobalValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A0B */, bool useObjectPool = false /* Metadata: 0x00AF3A0F */) => default; // 0x0000000184263AD0-0x0000000184263CF0
	[BlackList] // 0x00000001896479D0-0x0000000189647A10
	// [XID] // 0x00000001896479D0-0x0000000189647A10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184262260-0x0000000184262530
	// [XID] // 0x0000000189652220-0x0000000189652240
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184264E10-0x0000000184265310
	[BlackList] // 0x00000001896598B0-0x00000001896598F0
	// [XID] // 0x00000001896598B0-0x00000001896598F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184264170-0x0000000184264260
	// [XID] // 0x0000000189663F20-0x0000000189663F40
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184265580-0x0000000184265620
	// [XID] // 0x000000018966B640-0x000000018966B660
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001842632F0-0x0000000184263450
	[BlackList] // 0x00000001896824F0-0x0000000189682530
	// [XID] // 0x00000001896824F0-0x0000000189682530
	public override void AutoAllocTypeFields() {} // 0x0000000184262530-0x00000001842625D0
	[BlackList] // 0x000000018968CEC0-0x000000018968CF00
	// [XID] // 0x000000018968CEC0-0x000000018968CF00
	public override void AutoRecycleTypeFields() {} // 0x00000001842625D0-0x0000000184262800
	[BlackList] // 0x0000000189697C40-0x0000000189697C80
	// [XID] // 0x0000000189697C40-0x0000000189697C80
	public override void ReturnToObjectPool() {} // 0x0000000184265620-0x00000001842656C0
}

