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
public class VelocityDetectMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16949
{
	// Fields
	private SimpleSafeFloat minSpeedRawNum; // 0x30
	private SimpleSafeFloat maxSpeedRawNum; // 0x34
	private bool _detectOnStart; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onPoseedge; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onNegedge; // 0x48

	// Properties
	public float minSpeed { /* [XID] */ /* 0x000000018993B970-0x000000018993B990 */ get => default; /* [XID] */ /* 0x0000000189942AD0-0x0000000189942AF0 */ private set {} } // 0x0000000181BF6910-0x0000000181BF69F0 0x0000000181BF6AF0-0x0000000181BF6BD0
	public float maxSpeed { /* [XID] */ /* 0x000000018994A2A0-0x000000018994A2C0 */ get => default; /* [XID] */ /* 0x0000000189951D50-0x0000000189951D70 */ private set {} } // 0x0000000181BF5890-0x0000000181BF5970 0x0000000181BF6C80-0x0000000181BF6D60
	public bool detectOnStart { /* [XID] */ /* 0x00000001899592D0-0x00000001899592F0 */ get => default; /* [XID] */ /* 0x0000000189960B20-0x0000000189960B40 */ private set {} } // 0x0000000181BF64C0-0x0000000181BF6560 0x0000000181BF6BD0-0x0000000181BF6C80
	public ConfigAbilityAction[] onPoseedge { /* [XID] */ /* 0x00000001899682C0-0x00000001899682E0 */ get => default; /* [XID] */ /* 0x000000018996F780-0x000000018996F7A0 */ private set {} } // 0x0000000181BF65C0-0x0000000181BF6660 0x0000000181BF6D60-0x0000000181BF6E10
	public ConfigAbilityAction[] onNegedge { /* [XID] */ /* 0x0000000189977400-0x0000000189977420 */ get => default; /* [XID] */ /* 0x000000018997E7A0-0x000000018997E7C0 */ private set {} } // 0x0000000181BF7410-0x0000000181BF74B0 0x0000000181BF5460-0x0000000181BF5510
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A02D50-0x0000000189A02D70 */ get => default; } // 0x0000000181BF53C0-0x0000000181BF5460 

	// Constructors
	public VelocityDetectMixin() {} // 0x0000000181BF7550-0x0000000181BF75B0

	// Methods
	// [XID] // 0x00000001899861F0-0x0000000189986210
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181BF72A0-0x0000000181BF7410
	// [XID] // 0x000000018998DE00-0x000000018998DE20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181BF69F0-0x0000000181BF6AF0
	// [XID] // 0x00000001899958F0-0x0000000189995910
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E77 */) => default; // 0x0000000181BF63E0-0x0000000181BF64C0
	// [XID] // 0x000000018999D1F0-0x000000018999D210
	public override int GetHashNum() => default; // 0x0000000181BF4C40-0x0000000181BF4D10
	// [XID] // 0x00000001899A4BF0-0x00000001899A4C10
	public override void InitEmpty() {} // 0x0000000181BF5D00-0x0000000181BF5E30
	[BlackList] // 0x00000001899AC730-0x00000001899AC770
	// [XID] // 0x00000001899AC730-0x00000001899AC770
	public override bool FromJson(JSONNode node) => default; // 0x0000000181BF5510-0x0000000181BF5890
	// [XID] // 0x00000001899B6A90-0x00000001899B6AB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181BF4090-0x0000000181BF46A0
	[BlackList] // 0x00000001899BE530-0x00000001899BE570
	// [XID] // 0x00000001899BE530-0x00000001899BE570
	public static new VelocityDetectMixin ParseFromJson(JSONNode node) => default; // 0x0000000181BF6660-0x0000000181BF68B0
	// [XID] // 0x00000001899C8AC0-0x00000001899C8AE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E78 */, bool useObjectPool = false /* Metadata: 0x00AF5E7C */) => default; // 0x0000000181BF6000-0x0000000181BF6300
	// [XID] // 0x00000001899D0490-0x00000001899D04B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E7D */, bool useObjectPool = false /* Metadata: 0x00AF5E81 */) => default; // 0x0000000181BF4DF0-0x0000000181BF52C0
	// [XID] // 0x00000001899D7930-0x00000001899D7950
	public static new VelocityDetectMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E82 */, bool useObjectPool = false /* Metadata: 0x00AF5E86 */) => default; // 0x0000000181BF59E0-0x0000000181BF5C00
	[BlackList] // 0x00000001899DED90-0x00000001899DEDD0
	// [XID] // 0x00000001899DED90-0x00000001899DEDD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BF46A0-0x0000000181BF4970
	// [XID] // 0x00000001899E9760-0x00000001899E9780
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181BF6E10-0x0000000181BF72A0
	[BlackList] // 0x00000001899F0E10-0x00000001899F0E50
	// [XID] // 0x00000001899F0E10-0x00000001899F0E50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181BF5F10-0x0000000181BF6000
	// [XID] // 0x00000001899FB950-0x00000001899FB970
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181BF6300-0x0000000181BF63E0
	[BlackList] // 0x0000000189A0A360-0x0000000189A0A3A0
	// [XID] // 0x0000000189A0A360-0x0000000189A0A3A0
	public override void AutoAllocTypeFields() {} // 0x0000000181BF4970-0x0000000181BF4A10
	[BlackList] // 0x0000000189A14B80-0x0000000189A14BC0
	// [XID] // 0x0000000189A14B80-0x0000000189A14BC0
	public override void AutoRecycleTypeFields() {} // 0x0000000181BF4A10-0x0000000181BF4B20
	[BlackList] // 0x0000000189A1EDF0-0x0000000189A1EE30
	// [XID] // 0x0000000189A1EDF0-0x0000000189A1EE30
	public override void ReturnToObjectPool() {} // 0x0000000181BF74B0-0x0000000181BF7550
}

