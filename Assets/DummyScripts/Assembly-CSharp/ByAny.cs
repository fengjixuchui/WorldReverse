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
public class ByAny : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17208
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x18

	// Properties
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x00000001896492A0-0x00000001896492C0 */ get => default; /* [XID] */ /* 0x0000000189650870-0x0000000189650890 */ private set {} } // 0x0000000184AD4340-0x0000000184AD43E0 0x0000000184AD3EA0-0x0000000184AD3F50

	// Constructors
	public ByAny() {} // 0x0000000184AD4860-0x0000000184AD48C0

	// Methods
	// [XID] // 0x00000001896580D0-0x00000001896580F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184AD46D0-0x0000000184AD47C0
	// [XID] // 0x000000018965F6A0-0x000000018965F6C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184AD4260-0x0000000184AD4340
	// [XID] // 0x0000000189667050-0x0000000189667070
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF66A7 */) => default; // 0x0000000184AD3DC0-0x0000000184AD3EA0
	// [XID] // 0x000000018966E720-0x000000018966E740
	public override int GetHashNum() => default; // 0x0000000184AD2BC0-0x0000000184AD2C90
	// [XID] // 0x0000000189676320-0x0000000189676340
	public override void InitEmpty() {} // 0x0000000184AD3820-0x0000000184AD38F0
	[BlackList] // 0x000000018967DB60-0x000000018967DBA0
	// [XID] // 0x000000018967DB60-0x000000018967DBA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184AD3210-0x0000000184AD3590
	// [XID] // 0x0000000189688760-0x0000000189688780
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184AD2450-0x0000000184AD2680
	[BlackList] // 0x0000000189690100-0x0000000189690140
	// [XID] // 0x0000000189690100-0x0000000189690140
	public static new ByAny ParseFromJson(JSONNode node) => default; // 0x0000000184AD3FB0-0x0000000184AD4200
	// [XID] // 0x000000018969A5F0-0x000000018969A610
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66A8 */, bool useObjectPool = false /* Metadata: 0x00AF66AC */) => default; // 0x0000000184AD3AC0-0x0000000184AD3DC0
	// [XID] // 0x00000001896A1F60-0x00000001896A1F80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66AD */, bool useObjectPool = false /* Metadata: 0x00AF66B1 */) => default; // 0x0000000184AD2D70-0x0000000184AD2FE0
	// [XID] // 0x00000001896A92C0-0x00000001896A92E0
	public static new ByAny ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66B2 */, bool useObjectPool = false /* Metadata: 0x00AF66B6 */) => default; // 0x0000000184AD3590-0x0000000184AD37B0
	[BlackList] // 0x00000001896B0430-0x00000001896B0470
	// [XID] // 0x00000001896B0430-0x00000001896B0470
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AD2680-0x0000000184AD2950
	// [XID] // 0x00000001896BAC30-0x00000001896BAC50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184AD4490-0x0000000184AD46D0
	[BlackList] // 0x00000001896C1D60-0x00000001896C1DA0
	// [XID] // 0x00000001896C1D60-0x00000001896C1DA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184AD39D0-0x0000000184AD3AC0
	// [XID] // 0x00000001896CC510-0x00000001896CC530
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184AD2FE0-0x0000000184AD3110
	[BlackList] // 0x00000001896D3700-0x00000001896D3740
	// [XID] // 0x00000001896D3700-0x00000001896D3740
	public override void AutoAllocTypeFields() {} // 0x0000000184AD2950-0x0000000184AD29F0
	[BlackList] // 0x00000001896DE0E0-0x00000001896DE120
	// [XID] // 0x00000001896DE0E0-0x00000001896DE120
	public override void AutoRecycleTypeFields() {} // 0x0000000184AD29F0-0x0000000184AD2AA0
	[BlackList] // 0x00000001896E8520-0x00000001896E8560
	// [XID] // 0x00000001896E8520-0x00000001896E8560
	public override void ReturnToObjectPool() {} // 0x0000000184AD47C0-0x0000000184AD4860
}

