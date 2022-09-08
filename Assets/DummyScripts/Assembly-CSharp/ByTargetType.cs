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
public class ByTargetType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17370
{
	// Fields
	private AbilityTargetting _targetType; // 0x18
	private bool _isTarget; // 0x1C

	// Properties
	public AbilityTargetting targetType { /* [XID] */ /* 0x0000000189859FD0-0x0000000189859FF0 */ get => default; /* [XID] */ /* 0x0000000189861130-0x0000000189861150 */ private set {} } // 0x0000000184A89A00-0x0000000184A89AA0 0x0000000184A88400-0x0000000184A884B0
	public bool isTarget { /* [XID] */ /* 0x00000001898688F0-0x0000000189868910 */ get => default; /* [XID] */ /* 0x000000018986FD60-0x000000018986FD80 */ private set {} } // 0x0000000184A88DA0-0x0000000184A88E40 0x0000000184A882D0-0x0000000184A88380

	// Constructors
	public ByTargetType() {} // 0x0000000184A8A9A0-0x0000000184A8AE00

	// Methods
	// [XID] // 0x0000000189877470-0x0000000189877490
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A8A7F0-0x0000000184A8A900
	// [XID] // 0x000000018987ECE0-0x000000018987ED00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A8A400-0x0000000184A8A4B0
	// [XID] // 0x00000001898861C0-0x00000001898861E0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6BEF */) => default; // 0x0000000184A8A010-0x0000000184A8A0F0
	// [XID] // 0x000000018988D460-0x000000018988D480
	public override int GetHashNum() => default; // 0x0000000184A88CD0-0x0000000184A88DA0
	// [XID] // 0x0000000189894B30-0x0000000189894B50
	public override void InitEmpty() {} // 0x0000000184A89AA0-0x0000000184A89B40
	[BlackList] // 0x000000018989C120-0x000000018989C160
	// [XID] // 0x000000018989C120-0x000000018989C160
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A893F0-0x0000000184A89770
	// [XID] // 0x00000001898A68A0-0x00000001898A68C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A884B0-0x0000000184A88790
	[BlackList] // 0x00000001898ADFD0-0x00000001898AE010
	// [XID] // 0x00000001898ADFD0-0x00000001898AE010
	public static new ByTargetType ParseFromJson(JSONNode node) => default; // 0x0000000184A8A150-0x0000000184A8A3A0
	// [XID] // 0x00000001898B86C0-0x00000001898B86E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BF0 */, bool useObjectPool = false /* Metadata: 0x00AF6BF4 */) => default; // 0x0000000184A89D10-0x0000000184A8A010
	// [XID] // 0x00000001898BFE80-0x00000001898BFEA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BF5 */, bool useObjectPool = false /* Metadata: 0x00AF6BF9 */) => default; // 0x0000000184A88F20-0x0000000184A891C0
	// [XID] // 0x00000001898C7720-0x00000001898C7740
	public static new ByTargetType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BFA */, bool useObjectPool = false /* Metadata: 0x00AF6BFE */) => default; // 0x0000000184A89770-0x0000000184A89990
	[BlackList] // 0x00000001898CED50-0x00000001898CED90
	// [XID] // 0x00000001898CED50-0x00000001898CED90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A88790-0x0000000184A88A60
	// [XID] // 0x00000001898D9650-0x00000001898D9670
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A8A560-0x0000000184A8A7F0
	[BlackList] // 0x00000001898E1390-0x00000001898E13D0
	// [XID] // 0x00000001898E1390-0x00000001898E13D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A89C20-0x0000000184A89D10
	// [XID] // 0x00000001898EBCF0-0x00000001898EBD10
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184A891C0-0x0000000184A892F0
	[BlackList] // 0x00000001898F3560-0x00000001898F35A0
	// [XID] // 0x00000001898F3560-0x00000001898F35A0
	public override void AutoAllocTypeFields() {} // 0x0000000184A88A60-0x0000000184A88B00
	[BlackList] // 0x00000001898FDE00-0x00000001898FDE40
	// [XID] // 0x00000001898FDE00-0x00000001898FDE40
	public override void AutoRecycleTypeFields() {} // 0x0000000184A88B00-0x0000000184A88BB0
	[BlackList] // 0x0000000189908850-0x0000000189908890
	// [XID] // 0x0000000189908850-0x0000000189908890
	public override void ReturnToObjectPool() {} // 0x0000000184A8A900-0x0000000184A8A9A0
}

