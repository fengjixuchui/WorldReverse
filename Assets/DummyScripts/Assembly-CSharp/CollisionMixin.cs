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
public class CollisionMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16947
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCollision _collision; // 0x30
	private SimpleSafeFloat minShockSpeedRawNum; // 0x38
	private SimpleSafeFloat cdRawNum; // 0x3C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onCollision; // 0x40

	// Properties
	public ConfigCollision collision { /* [XID] */ /* 0x0000000189846EB0-0x0000000189846ED0 */ get => default; /* [XID] */ /* 0x000000018984E4C0-0x000000018984E4E0 */ private set {} } // 0x0000000185450E00-0x0000000185450EA0 0x000000018544E8D0-0x000000018544E980
	public float minShockSpeed { /* [XID] */ /* 0x0000000189855610-0x0000000189855630 */ get => default; /* [XID] */ /* 0x000000018985CB10-0x000000018985CB30 */ private set {} } // 0x000000018544EC50-0x000000018544ED30 0x0000000185450790-0x0000000185450870
	public float cd { /* [XID] */ /* 0x00000001898644B0-0x00000001898644D0 */ get => default; /* [XID] */ /* 0x000000018986BA00-0x000000018986BA20 */ private set {} } // 0x0000000185450EA0-0x0000000185450F80 0x000000018544FFC0-0x00000001854500A0
	public ConfigAbilityAction[] onCollision { /* [XID] */ /* 0x0000000189872CD0-0x0000000189872CF0 */ get => default; /* [XID] */ /* 0x000000018987A9B0-0x000000018987A9D0 */ private set {} } // 0x0000000185450950-0x00000001854509F0 0x000000018544FE10-0x000000018544FEC0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898FDEE0-0x00000001898FDF00 */ get => default; } // 0x000000018544F760-0x000000018544F800 

	// Constructors
	public CollisionMixin() {} // 0x0000000185451580-0x0000000185451630

	// Methods
	// [XID] // 0x0000000189881AA0-0x0000000189881AC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185451380-0x00000001854514E0
	// [XID] // 0x0000000189889160-0x0000000189889180
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185450D00-0x0000000185450E00
	// [XID] // 0x0000000189890540-0x0000000189890560
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E67 */) => default; // 0x0000000185450870-0x0000000185450950
	// [XID] // 0x0000000189897A40-0x0000000189897A60
	public override int GetHashNum() => default; // 0x000000018544F080-0x000000018544F150
	// [XID] // 0x000000018989EEA0-0x000000018989EEC0
	public override void InitEmpty() {} // 0x00000001854500A0-0x00000001854501E0
	[BlackList] // 0x00000001898A6980-0x00000001898A69C0
	// [XID] // 0x00000001898A6980-0x00000001898A69C0
	public override bool FromJson(JSONNode node) => default; // 0x000000018544F800-0x000000018544FB80
	// [XID] // 0x00000001898B0FE0-0x00000001898B1000
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018544E3A0-0x000000018544E8D0
	[BlackList] // 0x00000001898B8780-0x00000001898B87C0
	// [XID] // 0x00000001898B8780-0x00000001898B87C0
	public static new CollisionMixin ParseFromJson(JSONNode node) => default; // 0x0000000185450A50-0x0000000185450CA0
	// [XID] // 0x00000001898C2DC0-0x00000001898C2DE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E68 */, bool useObjectPool = false /* Metadata: 0x00AF5E6C */) => default; // 0x00000001854503B0-0x00000001854506B0
	// [XID] // 0x00000001898CA720-0x00000001898CA740
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E6D */, bool useObjectPool = false /* Metadata: 0x00AF5E71 */) => default; // 0x000000018544F230-0x000000018544F660
	// [XID] // 0x00000001898D1EB0-0x00000001898D1ED0
	public static new CollisionMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E72 */, bool useObjectPool = false /* Metadata: 0x00AF5E76 */) => default; // 0x000000018544FBF0-0x000000018544FE10
	[BlackList] // 0x00000001898D96F0-0x00000001898D9730
	// [XID] // 0x00000001898D96F0-0x00000001898D9730
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018544E980-0x000000018544EC50
	// [XID] // 0x00000001898E4360-0x00000001898E4380
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185450F80-0x0000000185451380
	[BlackList] // 0x00000001898EBD70-0x00000001898EBDB0
	// [XID] // 0x00000001898EBD70-0x00000001898EBDB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001854502C0-0x00000001854503B0
	// [XID] // 0x00000001898F67A0-0x00000001898F67C0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001854506B0-0x0000000185450790
	[BlackList] // 0x00000001899056A0-0x00000001899056E0
	// [XID] // 0x00000001899056A0-0x00000001899056E0
	public override void AutoAllocTypeFields() {} // 0x000000018544ED30-0x000000018544EDD0
	[BlackList] // 0x000000018990FEF0-0x000000018990FF30
	// [XID] // 0x000000018990FEF0-0x000000018990FF30
	public override void AutoRecycleTypeFields() {} // 0x000000018544EDD0-0x000000018544EF60
	[BlackList] // 0x000000018991A9D0-0x000000018991AA10
	// [XID] // 0x000000018991A9D0-0x000000018991AA10
	public override void ReturnToObjectPool() {} // 0x00000001854514E0-0x0000000185451580
}

