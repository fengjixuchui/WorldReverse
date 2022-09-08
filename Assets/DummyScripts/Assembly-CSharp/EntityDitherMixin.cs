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
public class EntityDitherMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17155
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x30
	private SimpleSafeFloat ditherValueRawNum; // 0x38
	private SimpleSafeFloat cutInTimeRawNum; // 0x3C
	private SimpleSafeFloat cutOutTimeRawNum; // 0x40

	// Properties
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x00000001899A6550-0x00000001899A6570 */ get => default; /* [XID] */ /* 0x00000001899ADC60-0x00000001899ADC80 */ private set {} } // 0x00000001817FADC0-0x00000001817FAE60 0x00000001817FA920-0x00000001817FA9D0
	public float ditherValue { /* [XID] */ /* 0x00000001899B5420-0x00000001899B5440 */ get => default; /* [XID] */ /* 0x00000001899BCB10-0x00000001899BCB30 */ private set {} } // 0x00000001817FB390-0x00000001817FB470 0x00000001817F9C80-0x00000001817F9D60
	public float cutInTime { /* [XID] */ /* 0x00000001899C4580-0x00000001899C45A0 */ get => default; /* [XID] */ /* 0x00000001899CBD80-0x00000001899CBDA0 */ private set {} } // 0x00000001817F9000-0x00000001817F90E0 0x00000001817F95B0-0x00000001817F9690
	public float cutOutTime { /* [XID] */ /* 0x00000001899D3290-0x00000001899D32B0 */ get => default; /* [XID] */ /* 0x00000001899DA800-0x00000001899DA820 */ private set {} } // 0x00000001817FA080-0x00000001817FA160 0x00000001817F9690-0x00000001817F9770
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A5DAC0-0x0000000189A5DAE0 */ get => default; } // 0x00000001817F97F0-0x00000001817F9890 

	// Constructors
	public EntityDitherMixin() {} // 0x00000001817FB510-0x00000001817FB570

	// Methods
	// [XID] // 0x00000001899E2220-0x00000001899E2240
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817FB240-0x00000001817FB390
	// [XID] // 0x00000001899E9720-0x00000001899E9740
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001817FACE0-0x00000001817FADC0
	// [XID] // 0x00000001899F0DD0-0x00000001899F0DF0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF64E9 */) => default; // 0x00000001817FA840-0x00000001817FA920
	// [XID] // 0x00000001899F86D0-0x00000001899F86F0
	public override int GetHashNum() => default; // 0x00000001817F8E50-0x00000001817F8F20
	// [XID] // 0x00000001899FFC40-0x00000001899FFC60
	public override void InitEmpty() {} // 0x00000001817FA160-0x00000001817FA290
	[BlackList] // 0x0000000189A07530-0x0000000189A07570
	// [XID] // 0x0000000189A07530-0x0000000189A07570
	public override bool FromJson(JSONNode node) => default; // 0x00000001817F9890-0x00000001817F9C10
	// [XID] // 0x0000000189A11C40-0x0000000189A11C60
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001817F8310-0x00000001817F88B0
	[BlackList] // 0x0000000189A18ED0-0x0000000189A18F10
	// [XID] // 0x0000000189A18ED0-0x0000000189A18F10
	public static new EntityDitherMixin ParseFromJson(JSONNode node) => default; // 0x00000001817FAA30-0x00000001817FAC80
	// [XID] // 0x0000000189A23640-0x0000000189A23660
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64EA */, bool useObjectPool = false /* Metadata: 0x00AF64EE */) => default; // 0x00000001817FA460-0x00000001817FA760
	// [XID] // 0x0000000189A2AA20-0x0000000189A2AA40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64EF */, bool useObjectPool = false /* Metadata: 0x00AF64F3 */) => default; // 0x00000001817F90E0-0x00000001817F9530
	// [XID] // 0x0000000189A32020-0x0000000189A32040
	public static new EntityDitherMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF64F4 */, bool useObjectPool = false /* Metadata: 0x00AF64F8 */) => default; // 0x00000001817F9D60-0x00000001817F9F80
	[BlackList] // 0x0000000189A39930-0x0000000189A39970
	// [XID] // 0x0000000189A39930-0x0000000189A39970
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001817F88B0-0x00000001817F8B80
	// [XID] // 0x0000000189A44250-0x0000000189A44270
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817FAE60-0x00000001817FB240
	[BlackList] // 0x0000000189A4B760-0x0000000189A4B7A0
	// [XID] // 0x0000000189A4B760-0x0000000189A4B7A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817FA370-0x00000001817FA460
	// [XID] // 0x0000000189A56040-0x0000000189A56060
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001817FA760-0x00000001817FA840
	[BlackList] // 0x0000000189A65280-0x0000000189A652C0
	// [XID] // 0x0000000189A65280-0x0000000189A652C0
	public override void AutoAllocTypeFields() {} // 0x00000001817F8B80-0x00000001817F8C20
	[BlackList] // 0x0000000189A6FA40-0x0000000189A6FA80
	// [XID] // 0x0000000189A6FA40-0x0000000189A6FA80
	public override void AutoRecycleTypeFields() {} // 0x00000001817F8C20-0x00000001817F8D30
	[BlackList] // 0x0000000189A7A670-0x0000000189A7A6B0
	// [XID] // 0x0000000189A7A670-0x0000000189A7A6B0
	public override void ReturnToObjectPool() {} // 0x00000001817FB470-0x00000001817FB510
}

