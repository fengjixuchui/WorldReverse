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
public class ByAttackType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17318
{
	// Fields
	private AttackType _attackType; // 0x18

	// Properties
	public AttackType attackType { /* [XID] */ /* 0x0000000189896160-0x0000000189896180 */ get => default; /* [XID] */ /* 0x000000018989D760-0x000000018989D780 */ private set {} } // 0x0000000183CE97E0-0x0000000183CE9880 0x0000000183CE8D30-0x0000000183CE8DE0

	// Constructors
	public ByAttackType() {} // 0x0000000183CEA740-0x0000000183CEA7A0

	// Methods
	// [XID] // 0x00000001898A5180-0x00000001898A51A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183CEA5B0-0x0000000183CEA6A0
	// [XID] // 0x00000001898AC660-0x00000001898AC680
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183CEA250-0x0000000183CEA300
	// [XID] // 0x00000001898B3BC0-0x00000001898B3BE0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6A5B */) => default; // 0x0000000183CE9E60-0x0000000183CE9F40
	// [XID] // 0x00000001898BB930-0x00000001898BB950
	public override int GetHashNum() => default; // 0x0000000183CE8B80-0x0000000183CE8C50
	// [XID] // 0x00000001898C2C60-0x00000001898C2C80
	public override void InitEmpty() {} // 0x0000000183CE98F0-0x0000000183CE9990
	[BlackList] // 0x00000001898CA640-0x00000001898CA680
	// [XID] // 0x00000001898CA640-0x00000001898CA680
	public override bool FromJson(JSONNode node) => default; // 0x0000000183CE9240-0x0000000183CE95C0
	// [XID] // 0x00000001898D4E70-0x00000001898D4E90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183CE8420-0x0000000183CE8640
	[BlackList] // 0x00000001898DC810-0x00000001898DC850
	// [XID] // 0x00000001898DC810-0x00000001898DC850
	public static new ByAttackType ParseFromJson(JSONNode node) => default; // 0x0000000183CE9FA0-0x0000000183CEA1F0
	// [XID] // 0x00000001898E75F0-0x00000001898E7610
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A5C */, bool useObjectPool = false /* Metadata: 0x00AF6A60 */) => default; // 0x0000000183CE9B60-0x0000000183CE9E60
	// [XID] // 0x00000001898EEDE0-0x00000001898EEE00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A61 */, bool useObjectPool = false /* Metadata: 0x00AF6A65 */) => default; // 0x0000000183CE8DE0-0x0000000183CE9010
	// [XID] // 0x00000001898F6720-0x00000001898F6740
	public static new ByAttackType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A66 */, bool useObjectPool = false /* Metadata: 0x00AF6A6A */) => default; // 0x0000000183CE95C0-0x0000000183CE97E0
	[BlackList] // 0x00000001898FDE40-0x00000001898FDE80
	// [XID] // 0x00000001898FDE40-0x00000001898FDE80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183CE8640-0x0000000183CE8910
	// [XID] // 0x0000000189908890-0x00000001899088B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183CEA3B0-0x0000000183CEA5B0
	[BlackList] // 0x000000018990FE30-0x000000018990FE70
	// [XID] // 0x000000018990FE30-0x000000018990FE70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183CE9A70-0x0000000183CE9B60
	// [XID] // 0x000000018991A950-0x000000018991A970
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000183CE9010-0x0000000183CE9140
	[BlackList] // 0x0000000189922200-0x0000000189922240
	// [XID] // 0x0000000189922200-0x0000000189922240
	public override void AutoAllocTypeFields() {} // 0x0000000183CE8910-0x0000000183CE89B0
	[BlackList] // 0x000000018992C660-0x000000018992C6A0
	// [XID] // 0x000000018992C660-0x000000018992C6A0
	public override void AutoRecycleTypeFields() {} // 0x0000000183CE89B0-0x0000000183CE8A60
	[BlackList] // 0x0000000189936AB0-0x0000000189936AF0
	// [XID] // 0x0000000189936AB0-0x0000000189936AF0
	public override void ReturnToObjectPool() {} // 0x0000000183CEA6A0-0x0000000183CEA740
}

