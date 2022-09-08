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
public class VelocityForceMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17145
{
	// Fields
	private bool _muteAll; // 0x30
	private bool _useAll; // 0x31
	private VelocityForceType[] _includeForces; // 0x38
	private VelocityForceType[] _excludeForces; // 0x40

	// Properties
	public bool muteAll { /* [XID] */ /* 0x00000001896AA930-0x00000001896AA950 */ get => default; /* [XID] */ /* 0x00000001896B1910-0x00000001896B1930 */ private set {} } // 0x0000000182D81870-0x0000000182D81910 0x0000000182D813B0-0x0000000182D81460
	public bool useAll { /* [XID] */ /* 0x00000001896B9330-0x00000001896B9350 */ get => default; /* [XID] */ /* 0x00000001896C0780-0x00000001896C07A0 */ private set {} } // 0x0000000182D81910-0x0000000182D819B0 0x0000000182D81EF0-0x0000000182D81FA0
	public VelocityForceType[] includeForces { /* [XID] */ /* 0x00000001896C7E90-0x00000001896C7EB0 */ get => default; /* [XID] */ /* 0x00000001896CF7B0-0x00000001896CF7D0 */ private set {} } // 0x0000000182D80720-0x0000000182D807C0 0x0000000182D80AE0-0x0000000182D80B90
	public VelocityForceType[] excludeForces { /* [XID] */ /* 0x00000001896D6AE0-0x00000001896D6B00 */ get => default; /* [XID] */ /* 0x00000001896DE160-0x00000001896DE180 */ private set {} } // 0x0000000182D80B90-0x0000000182D80C30 0x0000000182D81FA0-0x0000000182D82050
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189761550-0x0000000189761570 */ get => default; } // 0x0000000182D80290-0x0000000182D80330 

	// Constructors
	public VelocityForceMixin() {} // 0x0000000182D820F0-0x0000000182D82160

	// Methods
	// [XID] // 0x00000001896E55F0-0x00000001896E5610
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D81DA0-0x0000000182D81EF0
	// [XID] // 0x00000001896ECCE0-0x00000001896ECD00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D81770-0x0000000182D81870
	// [XID] // 0x00000001896F44E0-0x00000001896F4500
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF64A1 */) => default; // 0x0000000182D812D0-0x0000000182D813B0
	// [XID] // 0x00000001896FBD10-0x00000001896FBD30
	public override int GetHashNum() => default; // 0x0000000182D7FBE0-0x0000000182D7FCB0
	// [XID] // 0x0000000189703250-0x0000000189703270
	public override void InitEmpty() {} // 0x0000000182D80C30-0x0000000182D80D20
	[BlackList] // 0x000000018970A960-0x000000018970A9A0
	// [XID] // 0x000000018970A960-0x000000018970A9A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D80330-0x0000000182D806B0
	// [XID] // 0x0000000189714DD0-0x0000000189714DF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D7F220-0x0000000182D7F6A0
	[BlackList] // 0x000000018971C8A0-0x000000018971C8E0
	// [XID] // 0x000000018971C8A0-0x000000018971C8E0
	public static new VelocityForceMixin ParseFromJson(JSONNode node) => default; // 0x0000000182D814C0-0x0000000182D81710
	// [XID] // 0x0000000189726F20-0x0000000189726F40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64A2 */, bool useObjectPool = false /* Metadata: 0x00AF64A6 */) => default; // 0x0000000182D80EF0-0x0000000182D811F0
	// [XID] // 0x000000018972E4B0-0x000000018972E4D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64A7 */, bool useObjectPool = false /* Metadata: 0x00AF64AB */) => default; // 0x0000000182D7FD90-0x0000000182D80190
	// [XID] // 0x0000000189735C20-0x0000000189735C40
	public static new VelocityForceMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64AC */, bool useObjectPool = false /* Metadata: 0x00AF64B0 */) => default; // 0x0000000182D807C0-0x0000000182D809E0
	[BlackList] // 0x000000018973D810-0x000000018973D850
	// [XID] // 0x000000018973D810-0x000000018973D850
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D7F6A0-0x0000000182D7F970
	// [XID] // 0x0000000189747EA0-0x0000000189747EC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D819B0-0x0000000182D81DA0
	[BlackList] // 0x000000018974F5B0-0x000000018974F5F0
	// [XID] // 0x000000018974F5B0-0x000000018974F5F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D80E00-0x0000000182D80EF0
	// [XID] // 0x0000000189759900-0x0000000189759920
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182D811F0-0x0000000182D812D0
	[BlackList] // 0x00000001897687E0-0x0000000189768820
	// [XID] // 0x00000001897687E0-0x0000000189768820
	public override void AutoAllocTypeFields() {} // 0x0000000182D7F970-0x0000000182D7FA10
	[BlackList] // 0x0000000189772F00-0x0000000189772F40
	// [XID] // 0x0000000189772F00-0x0000000189772F40
	public override void AutoRecycleTypeFields() {} // 0x0000000182D7FA10-0x0000000182D7FAC0
	[BlackList] // 0x000000018977D840-0x000000018977D880
	// [XID] // 0x000000018977D840-0x000000018977D880
	public override void ReturnToObjectPool() {} // 0x0000000182D82050-0x0000000182D820F0
}

