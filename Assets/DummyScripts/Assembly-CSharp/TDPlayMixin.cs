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
public class TDPlayMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17141
{
	// Fields
	private TDPlayTowerType _towerType; // 0x30
	private SimpleSafeFloat baseCDRawNum; // 0x34
	private SimpleSafeFloat baseAttackRangeRawNum; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onFireActions; // 0x40
	private string _towerModifierName; // 0x48
	private SimpleSafeUInt32[] _bulletIDs; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x58
	private string[] _partRootNames; // 0x60
	private ControlPartTargetType _targetType; // 0x68

	// Properties
	public TDPlayTowerType towerType { /* [XID] */ /* 0x0000000189A42870-0x0000000189A42890 */ get => default; /* [XID] */ /* 0x0000000189A49DC0-0x0000000189A49DE0 */ private set {} } // 0x00000001823AC8D0-0x00000001823AC970 0x00000001823AF7D0-0x00000001823AF880
	public float baseCD { /* [XID] */ /* 0x0000000189A51790-0x0000000189A517B0 */ get => default; /* [XID] */ /* 0x0000000189A58F80-0x0000000189A58FA0 */ private set {} } // 0x00000001823AC9F0-0x00000001823ACAD0 0x00000001823AEF10-0x00000001823AEFF0
	public float baseAttackRange { /* [XID] */ /* 0x0000000189A608A0-0x0000000189A608C0 */ get => default; /* [XID] */ /* 0x0000000189A686B0-0x0000000189A686D0 */ private set {} } // 0x00000001823AEFF0-0x00000001823AF0D0 0x00000001823AECD0-0x00000001823AEDB0
	public ConfigAbilityAction[] onFireActions { /* [XID] */ /* 0x0000000189A6FA80-0x0000000189A6FAA0 */ get => default; /* [XID] */ /* 0x0000000189A77210-0x0000000189A77230 */ private set {} } // 0x00000001823ACBA0-0x00000001823ACC40 0x00000001823ACD40-0x00000001823ACDF0
	public string towerModifierName { /* [XID] */ /* 0x0000000189A7EBA0-0x0000000189A7EBC0 */ get => default; /* [XID] */ /* 0x0000000189A863D0-0x0000000189A863F0 */ private set {} } // 0x00000001823AD5D0-0x00000001823AD670 0x00000001823AFB10-0x00000001823AFBC0
	public SimpleSafeUInt32[] bulletIDs { /* [XID] */ /* 0x0000000189A8DD90-0x0000000189A8DDB0 */ get => default; /* [XID] */ /* 0x0000000189A953B0-0x0000000189A953D0 */ private set {} } // 0x00000001823ADFE0-0x00000001823AE080 0x00000001823AEDB0-0x00000001823AEE60
	public ConfigBornType born { /* [XID] */ /* 0x0000000189A9CBB0-0x0000000189A9CBD0 */ get => default; /* [XID] */ /* 0x0000000189AA4380-0x0000000189AA43A0 */ private set {} } // 0x00000001823ACC40-0x00000001823ACCE0 0x00000001823AFA60-0x00000001823AFB10
	public string[] partRootNames { /* [XID] */ /* 0x0000000189AAB870-0x0000000189AAB890 */ get => default; /* [XID] */ /* 0x0000000189AB3180-0x0000000189AB31A0 */ private set {} } // 0x00000001823ADDA0-0x00000001823ADE40 0x00000001823AEE60-0x00000001823AEF10
	public ControlPartTargetType targetType { /* [XID] */ /* 0x0000000189ABAE50-0x0000000189ABAE70 */ get => default; /* [XID] */ /* 0x0000000189AC26E0-0x0000000189AC2700 */ private set {} } // 0x00000001823ADF40-0x00000001823ADFE0 0x00000001823AB940-0x00000001823AB9F0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B46320-0x0000000189B46340 */ get => default; } // 0x00000001823AD6F0-0x00000001823AD790 

	// Constructors
	public TDPlayMixin() {} // 0x00000001823AFC60-0x00000001823AFD10

	// Methods
	// [XID] // 0x0000000189AC9D40-0x0000000189AC9D60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001823AF880-0x00000001823AFA60
	// [XID] // 0x0000000189AD1670-0x0000000189AD1690
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001823AEB80-0x00000001823AECD0
	// [XID] // 0x0000000189AD9390-0x0000000189AD93B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6481 */) => default; // 0x00000001823AE790-0x00000001823AE870
	// [XID] // 0x0000000189AE0EA0-0x0000000189AE0EC0
	public override int GetHashNum() => default; // 0x00000001823ACAD0-0x00000001823ACBA0
	// [XID] // 0x0000000189AE82B0-0x0000000189AE82D0
	public override void InitEmpty() {} // 0x00000001823AE080-0x00000001823AE1E0
	[BlackList] // 0x0000000189AF01B0-0x0000000189AF01F0
	// [XID] // 0x0000000189AF01B0-0x0000000189AF01F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001823AD790-0x00000001823ADB10
	// [XID] // 0x0000000189AFA7A0-0x0000000189AFA7C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001823AB9F0-0x00000001823AC330
	[BlackList] // 0x0000000189B01D30-0x0000000189B01D70
	// [XID] // 0x0000000189B01D30-0x0000000189B01D70
	public static new TDPlayMixin ParseFromJson(JSONNode node) => default; // 0x00000001823AE8D0-0x00000001823AEB20
	// [XID] // 0x0000000189B0C2F0-0x0000000189B0C310
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6482 */, bool useObjectPool = false /* Metadata: 0x00AF6486 */) => default; // 0x00000001823AE3B0-0x00000001823AE6B0
	// [XID] // 0x0000000189B13890-0x0000000189B138B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6487 */, bool useObjectPool = false /* Metadata: 0x00AF648B */) => default; // 0x00000001823ACE70-0x00000001823AD550
	// [XID] // 0x0000000189B1AEE0-0x0000000189B1AF00
	public static new TDPlayMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF648C */, bool useObjectPool = false /* Metadata: 0x00AF6490 */) => default; // 0x00000001823ADB80-0x00000001823ADDA0
	[BlackList] // 0x0000000189B225D0-0x0000000189B22610
	// [XID] // 0x0000000189B225D0-0x0000000189B22610
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001823AC330-0x00000001823AC600
	// [XID] // 0x0000000189B2CA90-0x0000000189B2CAB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823AF0D0-0x00000001823AF7D0
	[BlackList] // 0x0000000189B33EC0-0x0000000189B33F00
	// [XID] // 0x0000000189B33EC0-0x0000000189B33F00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001823AE2C0-0x00000001823AE3B0
	// [XID] // 0x0000000189B3E8A0-0x0000000189B3E8C0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001823AE6B0-0x00000001823AE790
	[BlackList] // 0x0000000189B4D880-0x0000000189B4D8C0
	// [XID] // 0x0000000189B4D880-0x0000000189B4D8C0
	public override void AutoAllocTypeFields() {} // 0x00000001823AC600-0x00000001823AC6A0
	[BlackList] // 0x0000000189B583B0-0x0000000189B583F0
	// [XID] // 0x0000000189B583B0-0x0000000189B583F0
	public override void AutoRecycleTypeFields() {} // 0x00000001823AC6A0-0x00000001823AC830
	[BlackList] // 0x0000000189B626E0-0x0000000189B62720
	// [XID] // 0x0000000189B626E0-0x0000000189B62720
	public override void ReturnToObjectPool() {} // 0x00000001823AFBC0-0x00000001823AFC60
}

