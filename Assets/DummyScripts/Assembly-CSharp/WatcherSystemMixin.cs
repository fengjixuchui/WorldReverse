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
public class WatcherSystemMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17094
{
	// Fields
	private SimpleSafeUInt32 watcherIdRawNum; // 0x30
	private WatcherSystemMixinType _mixinType; // 0x34
	private WatcherSystemListenType _listenEntityType; // 0x38
	private string _listenStateId; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x48

	// Properties
	public uint watcherId { /* [XID] */ /* 0x00000001899FCF50-0x00000001899FCF70 */ get => default; /* [XID] */ /* 0x0000000189A04390-0x0000000189A043B0 */ private set {} } // 0x0000000181267AC0-0x0000000181267B90 0x0000000181266E40-0x0000000181266F20
	public WatcherSystemMixinType mixinType { /* [XID] */ /* 0x0000000189A0BAF0-0x0000000189A0BB10 */ get => default; /* [XID] */ /* 0x0000000189A13440-0x0000000189A13460 */ private set {} } // 0x0000000181266D40-0x0000000181266DE0 0x0000000181267A10-0x0000000181267AC0
	public WatcherSystemListenType listenEntityType { /* [XID] */ /* 0x0000000189A1A570-0x0000000189A1A590 */ get => default; /* [XID] */ /* 0x0000000189A21D30-0x0000000189A21D50 */ private set {} } // 0x0000000181268CE0-0x0000000181268D80 0x0000000181266FA0-0x0000000181267050
	public string listenStateId { /* [XID] */ /* 0x0000000189A29280-0x0000000189A292A0 */ get => default; /* [XID] */ /* 0x0000000189A30830-0x0000000189A30850 */ private set {} } // 0x0000000181266B50-0x0000000181266BF0 0x0000000181268A30-0x0000000181268AE0
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x0000000189A381D0-0x0000000189A381F0 */ get => default; /* [XID] */ /* 0x0000000189A3F920-0x0000000189A3F940 */ private set {} } // 0x0000000181268C40-0x0000000181268CE0 0x00000001812686D0-0x0000000181268780
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189AC4040-0x0000000189AC4060 */ get => default; } // 0x00000001812675F0-0x0000000181267690 

	// Constructors
	public WatcherSystemMixin() {} // 0x0000000181269400-0x0000000181269460

	// Methods
	// [XID] // 0x0000000189A47090-0x0000000189A470B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181269200-0x0000000181269360
	// [XID] // 0x0000000189A4E9B0-0x0000000189A4E9D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181268B40-0x0000000181268C40
	// [XID] // 0x0000000189A56080-0x0000000189A560A0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6313 */) => default; // 0x00000001812685F0-0x00000001812686D0
	// [XID] // 0x0000000189A5DB20-0x0000000189A5DB40
	public override int GetHashNum() => default; // 0x0000000181266C70-0x0000000181266D40
	// [XID] // 0x0000000189A652C0-0x0000000189A652E0
	public override void InitEmpty() {} // 0x0000000181267F20-0x0000000181268040
	[BlackList] // 0x0000000189A6C9E0-0x0000000189A6CA20
	// [XID] // 0x0000000189A6C9E0-0x0000000189A6CA20
	public override bool FromJson(JSONNode node) => default; // 0x0000000181267690-0x0000000181267A10
	// [XID] // 0x0000000189A77270-0x0000000189A77290
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181266060-0x0000000181266650
	[BlackList] // 0x0000000189A7EBC0-0x0000000189A7EC00
	// [XID] // 0x0000000189A7EBC0-0x0000000189A7EC00
	public static new WatcherSystemMixin ParseFromJson(JSONNode node) => default; // 0x00000001812687E0-0x0000000181268A30
	// [XID] // 0x0000000189A89670-0x0000000189A89690
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6314 */, bool useObjectPool = false /* Metadata: 0x00AF6318 */) => default; // 0x0000000181268210-0x0000000181268510
	// [XID] // 0x0000000189A90E10-0x0000000189A90E30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6319 */, bool useObjectPool = false /* Metadata: 0x00AF631D */) => default; // 0x0000000181267050-0x00000001812674F0
	// [XID] // 0x0000000189A98600-0x0000000189A98620
	public static new WatcherSystemMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF631E */, bool useObjectPool = false /* Metadata: 0x00AF6322 */) => default; // 0x0000000181267C00-0x0000000181267E20
	[BlackList] // 0x0000000189A9FA30-0x0000000189A9FA70
	// [XID] // 0x0000000189A9FA30-0x0000000189A9FA70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181266650-0x0000000181266920
	// [XID] // 0x0000000189AA9F40-0x0000000189AA9F60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181268D80-0x0000000181269200
	[BlackList] // 0x0000000189AB1D60-0x0000000189AB1DA0
	// [XID] // 0x0000000189AB1D60-0x0000000189AB1DA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181268120-0x0000000181268210
	// [XID] // 0x0000000189ABC780-0x0000000189ABC7A0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181268510-0x00000001812685F0
	[BlackList] // 0x0000000189ACB530-0x0000000189ACB570
	// [XID] // 0x0000000189ACB530-0x0000000189ACB570
	public override void AutoAllocTypeFields() {} // 0x0000000181266920-0x00000001812669C0
	[BlackList] // 0x0000000189AD6460-0x0000000189AD64A0
	// [XID] // 0x0000000189AD6460-0x0000000189AD64A0
	public override void AutoRecycleTypeFields() {} // 0x00000001812669C0-0x0000000181266AB0
	[BlackList] // 0x0000000189AE0EE0-0x0000000189AE0F20
	// [XID] // 0x0000000189AE0EE0-0x0000000189AE0F20
	public override void ReturnToObjectPool() {} // 0x0000000181269360-0x0000000181269400
}

