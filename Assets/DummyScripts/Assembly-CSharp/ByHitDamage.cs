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
public class ByHitDamage : RelationalOperationPredicate, IAutoAllocRecycle // TypeDefIndex: 17188
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _damage; // 0x20

	// Properties
	public DynamicFloat damage { /* [XID] */ /* 0x0000000189B35560-0x0000000189B35580 */ get => default; /* [XID] */ /* 0x0000000189B3CE20-0x0000000189B3CE40 */ private set {} } // 0x000000018381B060-0x000000018381B100 0x000000018381C730-0x000000018381C7E0

	// Constructors
	public ByHitDamage() {} // 0x000000018381CC40-0x000000018381CCA0

	// Methods
	// [XID] // 0x0000000189B44B70-0x0000000189B44B90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018381CAC0-0x000000018381CBA0
	// [XID] // 0x0000000189B4C3C0-0x0000000189B4C3E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018381C650-0x000000018381C730
	// [XID] // 0x0000000189B539E0-0x0000000189B53A00
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6607 */) => default; // 0x000000018381C260-0x000000018381C340
	// [XID] // 0x0000000189B5B290-0x0000000189B5B2B0
	public override int GetHashNum() => default; // 0x000000018381AF90-0x000000018381B060
	// [XID] // 0x0000000189B626C0-0x0000000189B626E0
	public override void InitEmpty() {} // 0x000000018381BCC0-0x000000018381BD90
	[BlackList] // 0x0000000189B6A290-0x0000000189B6A2D0
	// [XID] // 0x0000000189B6A290-0x0000000189B6A2D0
	public override bool FromJson(JSONNode node) => default; // 0x000000018381B6B0-0x000000018381BA30
	// [XID] // 0x0000000189B746D0-0x0000000189B746F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018381A790-0x000000018381A9D0
	[BlackList] // 0x0000000189B7BCD0-0x0000000189B7BD10
	// [XID] // 0x0000000189B7BCD0-0x0000000189B7BD10
	public static new ByHitDamage ParseFromJson(JSONNode node) => default; // 0x000000018381C3A0-0x000000018381C5F0
	// [XID] // 0x0000000189B866E0-0x0000000189B86700
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6608 */, bool useObjectPool = false /* Metadata: 0x00AF660C */) => default; // 0x000000018381BF60-0x000000018381C260
	// [XID] // 0x0000000189B8D830-0x0000000189B8D850
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF660D */, bool useObjectPool = false /* Metadata: 0x00AF6611 */) => default; // 0x000000018381B1E0-0x000000018381B480
	// [XID] // 0x0000000189B94E10-0x0000000189B94E30
	public static new ByHitDamage ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6612 */, bool useObjectPool = false /* Metadata: 0x00AF6616 */) => default; // 0x000000018381BA30-0x000000018381BC50
	[BlackList] // 0x0000000189B9C540-0x0000000189B9C580
	// [XID] // 0x0000000189B9C540-0x0000000189B9C580
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018381A9D0-0x000000018381ACA0
	// [XID] // 0x0000000189BA6A80-0x0000000189BA6AA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018381C890-0x000000018381CAC0
	[BlackList] // 0x0000000189BADCA0-0x0000000189BADCE0
	// [XID] // 0x0000000189BADCA0-0x0000000189BADCE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018381BE70-0x000000018381BF60
	// [XID] // 0x0000000189BB8300-0x0000000189BB8320
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018381B480-0x000000018381B5B0
	[BlackList] // 0x0000000189BBFAD0-0x0000000189BBFB10
	// [XID] // 0x0000000189BBFAD0-0x0000000189BBFB10
	public override void AutoAllocTypeFields() {} // 0x000000018381ACA0-0x000000018381AD40
	[BlackList] // 0x0000000189BCAAB0-0x0000000189BCAAF0
	// [XID] // 0x0000000189BCAAB0-0x0000000189BCAAF0
	public override void AutoRecycleTypeFields() {} // 0x000000018381AD40-0x000000018381AE70
	[BlackList] // 0x0000000189BD4ED0-0x0000000189BD4F10
	// [XID] // 0x0000000189BD4ED0-0x0000000189BD4F10
	public override void ReturnToObjectPool() {} // 0x000000018381CBA0-0x000000018381CC40
}

