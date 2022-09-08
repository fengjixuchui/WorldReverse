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
public class DoActionByTeamStatusMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17061
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x38

	// Properties
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x00000001899FFC60-0x00000001899FFC80 */ get => default; /* [XID] */ /* 0x0000000189A07570-0x0000000189A07590 */ private set {} } // 0x00000001835FB6C0-0x00000001835FB760 0x00000001835F9AA0-0x00000001835F9B50
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x0000000189A0E9F0-0x0000000189A0EA10 */ get => default; /* [XID] */ /* 0x0000000189A16120-0x0000000189A16140 */ private set {} } // 0x00000001835FB620-0x00000001835FB6C0 0x00000001835FB160-0x00000001835FB210
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A99EE0-0x0000000189A99F00 */ get => default; } // 0x00000001835FA230-0x00000001835FA2D0 

	// Constructors
	public DoActionByTeamStatusMixin() {} // 0x00000001835FBC00-0x00000001835FBC60

	// Methods
	// [XID] // 0x0000000189A1D6A0-0x0000000189A1D6C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835FBA50-0x00000001835FBB60
	// [XID] // 0x0000000189A24AB0-0x0000000189A24AD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835FB520-0x00000001835FB620
	// [XID] // 0x0000000189A2C0D0-0x0000000189A2C0F0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF61E3 */) => default; // 0x00000001835FB080-0x00000001835FB160
	// [XID] // 0x0000000189A33820-0x0000000189A33840
	public override int GetHashNum() => default; // 0x00000001835F9C70-0x00000001835F9D40
	// [XID] // 0x0000000189A3AFE0-0x0000000189A3B000
	public override void InitEmpty() {} // 0x00000001835FA9E0-0x00000001835FAAD0
	[BlackList] // 0x0000000189A42890-0x0000000189A428D0
	// [XID] // 0x0000000189A42890-0x0000000189A428D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001835FA2D0-0x00000001835FA650
	// [XID] // 0x0000000189A4CF80-0x0000000189A4CFA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001835F9350-0x00000001835F9670
	[BlackList] // 0x0000000189A54690-0x0000000189A546D0
	// [XID] // 0x0000000189A54690-0x0000000189A546D0
	public static new DoActionByTeamStatusMixin ParseFromJson(JSONNode node) => default; // 0x00000001835FB270-0x00000001835FB4C0
	// [XID] // 0x0000000189A5F0D0-0x0000000189A5F0F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61E4 */, bool useObjectPool = false /* Metadata: 0x00AF61E8 */) => default; // 0x00000001835FACA0-0x00000001835FAFA0
	// [XID] // 0x0000000189A669C0-0x0000000189A669E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61E9 */, bool useObjectPool = false /* Metadata: 0x00AF61ED */) => default; // 0x00000001835F9E20-0x00000001835FA130
	// [XID] // 0x0000000189A6E260-0x0000000189A6E280
	public static new DoActionByTeamStatusMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61EE */, bool useObjectPool = false /* Metadata: 0x00AF61F2 */) => default; // 0x00000001835FA6C0-0x00000001835FA8E0
	[BlackList] // 0x0000000189A757F0-0x0000000189A75830
	// [XID] // 0x0000000189A757F0-0x0000000189A75830
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835F9670-0x00000001835F9940
	// [XID] // 0x0000000189A80100-0x0000000189A80120
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835FB760-0x00000001835FBA50
	[BlackList] // 0x0000000189A87DE0-0x0000000189A87E20
	// [XID] // 0x0000000189A87DE0-0x0000000189A87E20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835FABB0-0x00000001835FACA0
	// [XID] // 0x0000000189A924D0-0x0000000189A924F0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001835FAFA0-0x00000001835FB080
	[BlackList] // 0x0000000189AA0EC0-0x0000000189AA0F00
	// [XID] // 0x0000000189AA0EC0-0x0000000189AA0F00
	public override void AutoAllocTypeFields() {} // 0x00000001835F9940-0x00000001835F99E0
	[BlackList] // 0x0000000189AAB890-0x0000000189AAB8D0
	// [XID] // 0x0000000189AAB890-0x0000000189AAB8D0
	public override void AutoRecycleTypeFields() {} // 0x00000001835F99E0-0x00000001835F9AA0
	[BlackList] // 0x0000000189AB6200-0x0000000189AB6240
	// [XID] // 0x0000000189AB6200-0x0000000189AB6240
	public override void ReturnToObjectPool() {} // 0x00000001835FBB60-0x00000001835FBC00
}

