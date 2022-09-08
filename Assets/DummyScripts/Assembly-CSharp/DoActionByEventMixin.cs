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
public class DoActionByEventMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16900
{
	// Fields
	private AvatarStageType _type; // 0x30
	private OnEventType _onEvent; // 0x34
	private SimpleSafeUInt32[] _pickItemConfigIDs; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityStateToActions[] _onAbilityStateAdded; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityStateToActions[] _onAbilityStateRemoved; // 0x58

	// Properties
	public AvatarStageType type { /* [XID] */ /* 0x000000018983C9D0-0x000000018983C9F0 */ get => default; /* [XID] */ /* 0x00000001898440C0-0x00000001898440E0 */ private set {} } // 0x00000001825F9120-0x00000001825F91C0 0x00000001825F86D0-0x00000001825F8780
	public OnEventType onEvent { /* [XID] */ /* 0x000000018984B4F0-0x000000018984B510 */ get => default; /* [XID] */ /* 0x00000001898525E0-0x0000000189852600 */ private set {} } // 0x00000001825F8E30-0x00000001825F8ED0 0x00000001825F9070-0x00000001825F9120
	public SimpleSafeUInt32[] pickItemConfigIDs { /* [XID] */ /* 0x000000018985A050-0x000000018985A070 */ get => default; /* [XID] */ /* 0x00000001898611F0-0x0000000189861210 */ private set {} } // 0x00000001825F6650-0x00000001825F66F0 0x00000001825F7280-0x00000001825F7330
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x00000001898689D0-0x00000001898689F0 */ get => default; /* [XID] */ /* 0x000000018986FE80-0x000000018986FEA0 */ private set {} } // 0x00000001825F8630-0x00000001825F86D0 0x00000001825F8120-0x00000001825F81D0
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x0000000189877510-0x0000000189877530 */ get => default; /* [XID] */ /* 0x000000018987ED80-0x000000018987EDA0 */ private set {} } // 0x00000001825F8780-0x00000001825F8820 0x00000001825F6350-0x00000001825F6400
	public ConfigAbilityStateToActions[] onAbilityStateAdded { /* [XID] */ /* 0x00000001898862E0-0x0000000189886300 */ get => default; /* [XID] */ /* 0x000000018988D4E0-0x000000018988D500 */ private set {} } // 0x00000001825F73A0-0x00000001825F7440 0x00000001825F78B0-0x00000001825F7960
	public ConfigAbilityStateToActions[] onAbilityStateRemoved { /* [XID] */ /* 0x0000000189894C10-0x0000000189894C30 */ get => default; /* [XID] */ /* 0x000000018989C200-0x000000018989C220 */ private set {} } // 0x00000001825F7660-0x00000001825F7700 0x00000001825F7790-0x00000001825F7840
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189920790-0x00000001899207B0 */ get => default; } // 0x00000001825F6E60-0x00000001825F6F00 

	// Constructors
	public DoActionByEventMixin() {} // 0x00000001825F9260-0x00000001825F92C0

	// Methods
	// [XID] // 0x00000001898A3860-0x00000001898A3880
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825F8ED0-0x00000001825F9070
	// [XID] // 0x00000001898AAC60-0x00000001898AAC80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001825F84E0-0x00000001825F8630
	// [XID] // 0x00000001898B2570-0x00000001898B2590
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5CF9 */) => default; // 0x00000001825F8040-0x00000001825F8120
	// [XID] // 0x00000001898BA3A0-0x00000001898BA3C0
	public override int GetHashNum() => default; // 0x00000001825F6520-0x00000001825F65F0
	// [XID] // 0x00000001898C1700-0x00000001898C1720
	public override void InitEmpty() {} // 0x00000001825F7960-0x00000001825F7A90
	[BlackList] // 0x00000001898C9000-0x00000001898C9040
	// [XID] // 0x00000001898C9000-0x00000001898C9040
	public override bool FromJson(JSONNode node) => default; // 0x00000001825F6F00-0x00000001825F7280
	// [XID] // 0x00000001898D3650-0x00000001898D3670
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001825F57B0-0x00000001825F5EF0
	[BlackList] // 0x00000001898DADE0-0x00000001898DAE20
	// [XID] // 0x00000001898DADE0-0x00000001898DAE20
	public static new DoActionByEventMixin ParseFromJson(JSONNode node) => default; // 0x00000001825F8230-0x00000001825F8480
	// [XID] // 0x00000001898E5D00-0x00000001898E5D20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CFA */, bool useObjectPool = false /* Metadata: 0x00AF5CFE */) => default; // 0x00000001825F7C60-0x00000001825F7F60
	// [XID] // 0x00000001898ED620-0x00000001898ED640
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5CFF */, bool useObjectPool = false /* Metadata: 0x00AF5D03 */) => default; // 0x00000001825F6770-0x00000001825F6D60
	// [XID] // 0x00000001898F4E40-0x00000001898F4E60
	public static new DoActionByEventMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D04 */, bool useObjectPool = false /* Metadata: 0x00AF5D08 */) => default; // 0x00000001825F7440-0x00000001825F7660
	[BlackList] // 0x00000001898FC550-0x00000001898FC590
	// [XID] // 0x00000001898FC550-0x00000001898FC590
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825F5EF0-0x00000001825F61C0
	// [XID] // 0x0000000189906E90-0x0000000189906EB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825F8820-0x00000001825F8E30
	[BlackList] // 0x000000018990E890-0x000000018990E8D0
	// [XID] // 0x000000018990E890-0x000000018990E8D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001825F7B70-0x00000001825F7C60
	// [XID] // 0x0000000189919220-0x0000000189919240
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001825F7F60-0x00000001825F8040
	[BlackList] // 0x0000000189928150-0x0000000189928190
	// [XID] // 0x0000000189928150-0x0000000189928190
	public override void AutoAllocTypeFields() {} // 0x00000001825F61C0-0x00000001825F6260
	[BlackList] // 0x0000000189932720-0x0000000189932760
	// [XID] // 0x0000000189932720-0x0000000189932760
	public override void AutoRecycleTypeFields() {} // 0x00000001825F6260-0x00000001825F6350
	[BlackList] // 0x000000018993CF90-0x000000018993CFD0
	// [XID] // 0x000000018993CF90-0x000000018993CFD0
	public override void ReturnToObjectPool() {} // 0x00000001825F91C0-0x00000001825F9260
}

