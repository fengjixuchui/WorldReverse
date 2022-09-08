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
public class ClusterTriggerMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16988
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x30
	private SimpleSafeUInt32 configIDRawNum; // 0x38
	private SimpleSafeFloat radiusRawNum; // 0x3C
	private SimpleSafeFloat durationRawNum; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private DynamicFloat[] _valueSteps; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actionQueue; // 0x50

	// Properties
	public ConfigBornType born { /* [XID] */ /* 0x00000001898879E0-0x0000000189887A00 */ get => default; /* [XID] */ /* 0x000000018988ECE0-0x000000018988ED00 */ private set {} } // 0x0000000184A27DC0-0x0000000184A27E60 0x0000000184A2A4F0-0x0000000184A2A5A0
	public uint configID { /* [XID] */ /* 0x0000000189896220-0x0000000189896240 */ get => default; /* [XID] */ /* 0x000000018989D8C0-0x000000018989D8E0 */ private set {} } // 0x0000000184A27CF0-0x0000000184A27DC0 0x0000000184A27400-0x0000000184A274E0
	public float radius { /* [XID] */ /* 0x00000001898A5240-0x00000001898A5260 */ get => default; /* [XID] */ /* 0x00000001898AC7A0-0x00000001898AC7C0 */ private set {} } // 0x0000000184A29D10-0x0000000184A29DF0 0x0000000184A2A5A0-0x0000000184A2A680
	public float duration { /* [XID] */ /* 0x00000001898B3C80-0x00000001898B3CA0 */ get => default; /* [XID] */ /* 0x00000001898BB9B0-0x00000001898BB9D0 */ private set {} } // 0x0000000184A27AC0-0x0000000184A27BA0 0x0000000184A284C0-0x0000000184A285A0
	public DynamicFloat[] valueSteps { /* [XID] */ /* 0x00000001898C2D80-0x00000001898C2DA0 */ get => default; /* [XID] */ /* 0x00000001898CA6E0-0x00000001898CA700 */ private set {} } // 0x0000000184A28F30-0x0000000184A28FD0 0x0000000184A28AC0-0x0000000184A28B70
	public ConfigAbilityAction[] actionQueue { /* [XID] */ /* 0x00000001898D1E70-0x00000001898D1E90 */ get => default; /* [XID] */ /* 0x00000001898D96B0-0x00000001898D96D0 */ private set {} } // 0x0000000184A28E00-0x0000000184A28EA0 0x0000000184A29AF0-0x0000000184A29BA0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018995DC10-0x000000018995DC30 */ get => default; } // 0x0000000184A286A0-0x0000000184A28740 

	// Constructors
	public ClusterTriggerMixin() {} // 0x0000000184A2A720-0x0000000184A2A780

	// Methods
	// [XID] // 0x00000001898E1410-0x00000001898E1430
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A2A360-0x0000000184A2A4F0
	// [XID] // 0x00000001898E8E60-0x00000001898E8E80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A29C00-0x0000000184A29D10
	// [XID] // 0x00000001898F05C0-0x00000001898F05E0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5FA5 */) => default; // 0x0000000184A29760-0x0000000184A29840
	// [XID] // 0x00000001898F7FB0-0x00000001898F7FD0
	public override int GetHashNum() => default; // 0x0000000184A27C20-0x0000000184A27CF0
	// [XID] // 0x00000001898FF670-0x00000001898FF690
	public override void InitEmpty() {} // 0x0000000184A29040-0x0000000184A291B0
	[BlackList] // 0x0000000189906DF0-0x0000000189906E30
	// [XID] // 0x0000000189906DF0-0x0000000189906E30
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A28740-0x0000000184A28AC0
	// [XID] // 0x0000000189911620-0x0000000189911640
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A26CF0-0x0000000184A27400
	[BlackList] // 0x00000001899191E0-0x0000000189919220
	// [XID] // 0x00000001899191E0-0x0000000189919220
	public static new ClusterTriggerMixin ParseFromJson(JSONNode node) => default; // 0x0000000184A298A0-0x0000000184A29AF0
	// [XID] // 0x00000001899239C0-0x00000001899239E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FA6 */, bool useObjectPool = false /* Metadata: 0x00AF5FAA */) => default; // 0x0000000184A29380-0x0000000184A29680
	// [XID] // 0x000000018992B000-0x000000018992B020
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FAB */, bool useObjectPool = false /* Metadata: 0x00AF5FAF */) => default; // 0x0000000184A27F40-0x0000000184A284C0
	// [XID] // 0x0000000189932680-0x00000001899326A0
	public static new ClusterTriggerMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FB0 */, bool useObjectPool = false /* Metadata: 0x00AF5FB4 */) => default; // 0x0000000184A28BE0-0x0000000184A28E00
	[BlackList] // 0x000000018993A070-0x000000018993A0B0
	// [XID] // 0x000000018993A070-0x000000018993A0B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A274E0-0x0000000184A277B0
	// [XID] // 0x00000001899445A0-0x00000001899445C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A29DF0-0x0000000184A2A360
	[BlackList] // 0x000000018994BB80-0x000000018994BBC0
	// [XID] // 0x000000018994BB80-0x000000018994BBC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A29290-0x0000000184A29380
	// [XID] // 0x0000000189956100-0x0000000189956120
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184A29680-0x0000000184A29760
	[BlackList] // 0x00000001899653F0-0x0000000189965430
	// [XID] // 0x00000001899653F0-0x0000000189965430
	public override void AutoAllocTypeFields() {} // 0x0000000184A277B0-0x0000000184A27850
	[BlackList] // 0x000000018996F740-0x000000018996F780
	// [XID] // 0x000000018996F740-0x000000018996F780
	public override void AutoRecycleTypeFields() {} // 0x0000000184A27850-0x0000000184A27A20
	[BlackList] // 0x000000018997A550-0x000000018997A590
	// [XID] // 0x000000018997A550-0x000000018997A590
	public override void ReturnToObjectPool() {} // 0x0000000184A2A680-0x0000000184A2A720
}

