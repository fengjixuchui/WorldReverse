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
public class AttachToAbilityStateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17088
{
	// Fields
	private AbilityState[] _abilityStates; // 0x30
	private bool _reject; // 0x38
	private string _modifierName; // 0x40

	// Properties
	public AbilityState[] abilityStates { /* [XID] */ /* 0x00000001898FF650-0x00000001898FF670 */ get => default; /* [XID] */ /* 0x0000000189906DD0-0x0000000189906DF0 */ private set {} } // 0x0000000183917960-0x0000000183917A00 0x0000000183917B30-0x0000000183917BE0
	public bool reject { /* [XID] */ /* 0x000000018990E810-0x000000018990E830 */ get => default; /* [XID] */ /* 0x0000000189915E60-0x0000000189915E80 */ private set {} } // 0x0000000183915FE0-0x0000000183916080 0x00000001839165A0-0x0000000183916650
	public string modifierName { /* [XID] */ /* 0x000000018991D990-0x000000018991D9B0 */ get => default; /* [XID] */ /* 0x00000001899250A0-0x00000001899250C0 */ private set {} } // 0x0000000183917BE0-0x0000000183917C80 0x0000000183916BB0-0x0000000183916C60
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899A9380-0x00000001899A93A0 */ get => default; } // 0x0000000183916180-0x0000000183916220 

	// Constructors
	public AttachToAbilityStateMixin() {} // 0x0000000183917D20-0x0000000183917D80

	// Methods
	// [XID] // 0x000000018992C6C0-0x000000018992C6E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183917A00-0x0000000183917B30
	// [XID] // 0x0000000189933E00-0x0000000189933E20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183917520-0x0000000183917620
	// [XID] // 0x000000018993B950-0x000000018993B970
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF62B3 */) => default; // 0x0000000183917130-0x0000000183917210
	// [XID] // 0x0000000189942AB0-0x0000000189942AD0
	public override int GetHashNum() => default; // 0x0000000183915AB0-0x0000000183915B80
	// [XID] // 0x000000018994A280-0x000000018994A2A0
	public override void InitEmpty() {} // 0x00000001839169E0-0x0000000183916AD0
	[BlackList] // 0x0000000189951D10-0x0000000189951D50
	// [XID] // 0x0000000189951D10-0x0000000189951D50
	public override bool FromJson(JSONNode node) => default; // 0x0000000183916220-0x00000001839165A0
	// [XID] // 0x000000018995C1C0-0x000000018995C1E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001839151A0-0x0000000183915570
	[BlackList] // 0x0000000189963BE0-0x0000000189963C20
	// [XID] // 0x0000000189963BE0-0x0000000189963C20
	public static new AttachToAbilityStateMixin ParseFromJson(JSONNode node) => default; // 0x0000000183917270-0x00000001839174C0
	// [XID] // 0x000000018996DFA0-0x000000018996DFC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF62B4 */, bool useObjectPool = false /* Metadata: 0x00AF62B8 */) => default; // 0x0000000183916D50-0x0000000183917050
	// [XID] // 0x0000000189975B90-0x0000000189975BB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF62B9 */, bool useObjectPool = false /* Metadata: 0x00AF62BD */) => default; // 0x0000000183915C60-0x0000000183915FE0
	// [XID] // 0x000000018997CB90-0x000000018997CBB0
	public static new AttachToAbilityStateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF62BE */, bool useObjectPool = false /* Metadata: 0x00AF62C2 */) => default; // 0x00000001839166C0-0x00000001839168E0
	[BlackList] // 0x0000000189984950-0x0000000189984990
	// [XID] // 0x0000000189984950-0x0000000189984990
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183915570-0x0000000183915840
	// [XID] // 0x000000018998F540-0x000000018998F560
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183917620-0x0000000183917960
	[BlackList] // 0x0000000189996F80-0x0000000189996FC0
	// [XID] // 0x0000000189996F80-0x0000000189996FC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183916C60-0x0000000183916D50
	// [XID] // 0x00000001899A1B30-0x00000001899A1B50
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183917050-0x0000000183917130
	[BlackList] // 0x00000001899B0E50-0x00000001899B0E90
	// [XID] // 0x00000001899B0E50-0x00000001899B0E90
	public override void AutoAllocTypeFields() {} // 0x0000000183915840-0x00000001839158E0
	[BlackList] // 0x00000001899BB270-0x00000001899BB2B0
	// [XID] // 0x00000001899BB270-0x00000001899BB2B0
	public override void AutoRecycleTypeFields() {} // 0x00000001839158E0-0x0000000183915990
	[BlackList] // 0x00000001899C5CB0-0x00000001899C5CF0
	// [XID] // 0x00000001899C5CB0-0x00000001899C5CF0
	public override void ReturnToObjectPool() {} // 0x0000000183917C80-0x0000000183917D20
}

