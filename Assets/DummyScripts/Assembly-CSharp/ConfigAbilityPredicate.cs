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
public class ConfigAbilityPredicate : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17174
{
	// Fields
	private AbilityTargetting _target; // 0x10

	// Properties
	public AbilityTargetting target { /* [XID] */ /* 0x0000000189634290-0x00000001896342B0 */ get => default; /* [XID] */ /* 0x000000018963BA40-0x000000018963BA60 */ private set {} } // 0x0000000182B5EDF0-0x0000000182B5EE90 0x0000000182B5EE90-0x0000000182B5EF40

	// Constructors
	public ConfigAbilityPredicate() {} // 0x0000000182B603E0-0x0000000182B60450

	// Methods
	// [XID] // 0x0000000189643180-0x00000001896431A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B60120-0x0000000182B60200
	// [XID] // 0x000000018964A800-0x000000018964A820
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B5FEC0-0x0000000182B5FF70
	// [XID] // 0x0000000189846000-0x0000000189846020
	public virtual ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6597 */) => default; // 0x0000000182B5FBE0-0x0000000182B5FCC0
	// [XID] // 0x0000000189659790-0x00000001896597B0
	public virtual int GetHashNum() => default; // 0x0000000182B5ED20-0x0000000182B5EDF0
	// [XID] // 0x0000000189660F30-0x0000000189660F50
	public virtual void InitEmpty() {} // 0x0000000182B5F750-0x0000000182B5F7F0
	[BlackList] // 0x0000000189668880-0x00000001896688C0
	// [XID] // 0x0000000189668880-0x00000001896688C0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000182B5F200-0x0000000182B5F580
	// [XID] // 0x00000001896732C0-0x00000001896732E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182B5E730-0x0000000182B5E910
	[BlackList] // 0x000000018967AA80-0x000000018967AAC0
	// [XID] // 0x000000018967AA80-0x000000018967AAC0
	public static ConfigAbilityPredicate ParseFromJson(JSONNode node) => default; // 0x0000000182B5FCC0-0x0000000182B5FEC0
	// [XID] // 0x00000001896852C0-0x00000001896852E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6598 */, bool useObjectPool = false /* Metadata: 0x00AF659C */) => default; // 0x0000000182B5F8E0-0x0000000182B5FBE0
	// [XID] // 0x000000018985C0E0-0x000000018985C100
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF659D */, bool useObjectPool = false /* Metadata: 0x00AF65A1 */) => default; // 0x0000000182B5EF40-0x0000000182B5F110
	// [XID] // 0x0000000189694900-0x0000000189694920
	public static ConfigAbilityPredicate ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF65A2 */, bool useObjectPool = false /* Metadata: 0x00AF65A6 */) => default; // 0x0000000182B5F580-0x0000000182B5F750
	[BlackList] // 0x000000018969BFC0-0x000000018969C000
	// [XID] // 0x000000018969BFC0-0x000000018969C000
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B5E910-0x0000000182B5EBE0
	// [XID] // 0x00000001896A62B0-0x00000001896A62D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B5FF70-0x0000000182B60120
	[BlackList] // 0x00000001896AD7B0-0x00000001896AD7F0
	// [XID] // 0x00000001896AD7B0-0x00000001896AD7F0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B5F7F0-0x0000000182B5F8E0
	// [XID] // 0x00000001896B7DF0-0x00000001896B7E10
	public virtual bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182B5F110-0x0000000182B5F200
	[BlackList] // 0x00000001896BEE10-0x00000001896BEE50
	// [XID] // 0x00000001896BEE10-0x00000001896BEE50
	public virtual void AutoAllocTypeFields() {} // 0x0000000182B5EBE0-0x0000000182B5EC80
	[BlackList] // 0x00000001896C9350-0x00000001896C9390
	// [XID] // 0x00000001896C9350-0x00000001896C9390
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182B5EC80-0x0000000182B5ED20
	[BlackList] // 0x00000001896D3740-0x00000001896D3780
	// [XID] // 0x00000001896D3740-0x00000001896D3780
	public virtual void ReturnToObjectPool() {} // 0x0000000182B60340-0x0000000182B603E0
	[BlackList] // 0x00000001896DE120-0x00000001896DE160
	// [XID] // 0x00000001896DE120-0x00000001896DE160
	public virtual void OnPoolAllocated() {} // 0x0000000182B602A0-0x0000000182B60340
	[BlackList] // 0x00000001896E8560-0x00000001896E85A0
	// [XID] // 0x00000001896E8560-0x00000001896E85A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182B60200-0x0000000182B602A0
}

