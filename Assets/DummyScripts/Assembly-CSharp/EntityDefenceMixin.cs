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
public class EntityDefenceMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16967
{
	// Fields
	private string[] _stateIDs; // 0x30
	private string _defendTriggerID; // 0x38
	private SimpleSafeFloat defendAngleRawNum; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _defendProbability; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _defendProbabilityDelta; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _defendTimeInterval; // 0x58
	private bool _alwaysRecover; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicInt _defendCountInterval; // 0x68

	// Properties
	public string[] stateIDs { /* [XID] */ /* 0x0000000189AA7240-0x0000000189AA7260 */ get => default; /* [XID] */ /* 0x0000000189AAE940-0x0000000189AAE960 */ private set {} } // 0x00000001829D22B0-0x00000001829D2350 0x00000001829D2350-0x00000001829D2400
	public string defendTriggerID { /* [XID] */ /* 0x0000000189AB62A0-0x0000000189AB62C0 */ get => default; /* [XID] */ /* 0x0000000189ABDCD0-0x0000000189ABDCF0 */ private set {} } // 0x00000001829CEEF0-0x00000001829CEF90 0x00000001829D0A90-0x00000001829D0B40
	public float defendAngle { /* [XID] */ /* 0x0000000189AC5850-0x0000000189AC5870 */ get => default; /* [XID] */ /* 0x0000000189ACCD20-0x0000000189ACCD40 */ private set {} } // 0x00000001829D1960-0x00000001829D1A40 0x00000001829CF2F0-0x00000001829CF3D0
	public DynamicFloat defendProbability { /* [XID] */ /* 0x0000000189AD4A40-0x0000000189AD4A60 */ get => default; /* [XID] */ /* 0x0000000189ADC3A0-0x0000000189ADC3C0 */ private set {} } // 0x00000001829D1640-0x00000001829D16E0 0x00000001829D09E0-0x00000001829D0A90
	public DynamicFloat defendProbabilityDelta { /* [XID] */ /* 0x0000000189AE3D90-0x0000000189AE3DB0 */ get => default; /* [XID] */ /* 0x0000000189AEB5D0-0x0000000189AEB5F0 */ private set {} } // 0x00000001829D03C0-0x00000001829D0460 0x00000001829CFDF0-0x00000001829CFEA0
	public DynamicFloat defendTimeInterval { /* [XID] */ /* 0x0000000189AF2F50-0x0000000189AF2F70 */ get => default; /* [XID] */ /* 0x0000000189AFA7E0-0x0000000189AFA800 */ private set {} } // 0x00000001829D0790-0x00000001829D0830 0x00000001829CF5C0-0x00000001829CF670
	public bool alwaysRecover { /* [XID] */ /* 0x0000000189B01DB0-0x0000000189B01DD0 */ get => default; /* [XID] */ /* 0x0000000189B09310-0x0000000189B09330 */ private set {} } // 0x00000001829D0460-0x00000001829D0500 0x00000001829D18B0-0x00000001829D1960
	public DynamicInt defendCountInterval { /* [XID] */ /* 0x0000000189B10D90-0x0000000189B10DB0 */ get => default; /* [XID] */ /* 0x0000000189B18000-0x0000000189B18020 */ private set {} } // 0x00000001829D0CE0-0x00000001829D0D80 0x00000001829D0930-0x00000001829D09E0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B9ACE0-0x0000000189B9AD00 */ get => default; } // 0x00000001829CFFA0-0x00000001829D0040 

	// Constructors
	public EntityDefenceMixin() {} // 0x00000001829D24A0-0x00000001829D25C0

	// Methods
	// [XID] // 0x0000000189B1F6E0-0x0000000189B1F700
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829D20B0-0x00000001829D22B0
	// [XID] // 0x0000000189B26FA0-0x0000000189B26FC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829D1740-0x00000001829D18B0
	// [XID] // 0x0000000189B2E170-0x0000000189B2E190
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5EFF */) => default; // 0x00000001829D12B0-0x00000001829D1390
	// [XID] // 0x0000000189B355E0-0x0000000189B35600
	public override int GetHashNum() => default; // 0x00000001829CF4F0-0x00000001829CF5C0
	// [XID] // 0x0000000189B3CE60-0x0000000189B3CE80
	public override void InitEmpty() {} // 0x00000001829D0B40-0x00000001829D0C60
	[BlackList] // 0x0000000189B44BD0-0x0000000189B44C10
	// [XID] // 0x0000000189B44BD0-0x0000000189B44C10
	public override bool FromJson(JSONNode node) => default; // 0x00000001829D0040-0x00000001829D03C0
	// [XID] // 0x0000000189B4F330-0x0000000189B4F350
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829CE460-0x00000001829CEC20
	[BlackList] // 0x0000000189B56C10-0x0000000189B56C50
	// [XID] // 0x0000000189B56C10-0x0000000189B56C50
	public static new EntityDefenceMixin ParseFromJson(JSONNode node) => default; // 0x00000001829D13F0-0x00000001829D1640
	// [XID] // 0x0000000189B61250-0x0000000189B61270
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F00 */, bool useObjectPool = false /* Metadata: 0x00AF5F04 */) => default; // 0x00000001829D0ED0-0x00000001829D11D0
	// [XID] // 0x0000000189B68B20-0x0000000189B68B40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F05 */, bool useObjectPool = false /* Metadata: 0x00AF5F09 */) => default; // 0x00000001829CF750-0x00000001829CFDF0
	// [XID] // 0x0000000189B70140-0x0000000189B70160
	public static new EntityDefenceMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F0A */, bool useObjectPool = false /* Metadata: 0x00AF5F0E */) => default; // 0x00000001829D0570-0x00000001829D0790
	[BlackList] // 0x0000000189B77530-0x0000000189B77570
	// [XID] // 0x0000000189B77530-0x0000000189B77570
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829CEC20-0x00000001829CEEF0
	// [XID] // 0x0000000189B81DF0-0x0000000189B81E10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829D1A40-0x00000001829D20B0
	[BlackList] // 0x0000000189B89490-0x0000000189B894D0
	// [XID] // 0x0000000189B89490-0x0000000189B894D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829D0DE0-0x00000001829D0ED0
	// [XID] // 0x0000000189B937B0-0x0000000189B937D0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001829D11D0-0x00000001829D12B0
	[BlackList] // 0x0000000189BA2570-0x0000000189BA25B0
	// [XID] // 0x0000000189BA2570-0x0000000189BA25B0
	public override void AutoAllocTypeFields() {} // 0x00000001829CEF90-0x00000001829CF030
	[BlackList] // 0x0000000189BAC590-0x0000000189BAC5D0
	// [XID] // 0x0000000189BAC590-0x0000000189BAC5D0
	public override void AutoRecycleTypeFields() {} // 0x00000001829CF030-0x00000001829CF2F0
	[BlackList] // 0x0000000189BB6C70-0x0000000189BB6CB0
	// [XID] // 0x0000000189BB6C70-0x0000000189BB6CB0
	public override void ReturnToObjectPool() {} // 0x00000001829D2400-0x00000001829D24A0
}

