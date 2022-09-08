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
public class AddClimateMeter : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16765
{
	// Fields
	private JsonClimateType _climateType; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x70

	// Properties
	public JsonClimateType climateType { /* [XID] */ /* 0x000000018982F1E0-0x000000018982F200 */ get => default; /* [XID] */ /* 0x0000000189836AD0-0x0000000189836AF0 */ private set {} } // 0x00000001847F42A0-0x00000001847F4340 0x00000001847F4340-0x00000001847F43F0
	public DynamicFloat value { /* [XID] */ /* 0x000000018983DF40-0x000000018983DF60 */ get => default; /* [XID] */ /* 0x0000000189845770-0x0000000189845790 */ private set {} } // 0x00000001847F3BF0-0x00000001847F3C90 0x00000001847F3AC0-0x00000001847F3B70
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898C7800-0x00000001898C7820 */ get => default; } // 0x00000001847F4DD0-0x00000001847F4E70 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898CEE90-0x00000001898CEEB0 */ get => default; } // 0x00000001847F43F0-0x00000001847F4490 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001898D6900-0x00000001898D6920 */ get => default; } // 0x00000001847F3420-0x00000001847F34C0 

	// Constructors
	public AddClimateMeter() {} // 0x00000001847F5570-0x00000001847F55D0

	// Methods
	// [XID] // 0x000000018984CC80-0x000000018984CCA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001847F53B0-0x00000001847F54D0
	// [XID] // 0x0000000189853CC0-0x0000000189853CE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847F4F40-0x00000001847F5020
	// [XID] // 0x000000018985B810-0x000000018985B830
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF458E */) => default; // 0x00000001847F4A40-0x00000001847F4B20
	// [XID] // 0x0000000189862D70-0x0000000189862D90
	public override int GetHashNum() => default; // 0x00000001847F3350-0x00000001847F3420
	// [XID] // 0x000000018986A1C0-0x000000018986A1E0
	public override void InitEmpty() {} // 0x00000001847F4490-0x00000001847F4560
	[BlackList] // 0x0000000189871590-0x00000001898715D0
	// [XID] // 0x0000000189871590-0x00000001898715D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001847F3C90-0x00000001847F4010
	// [XID] // 0x000000018987BE80-0x000000018987BEA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001847F2A00-0x00000001847F2D20
	[BlackList] // 0x0000000189882FB0-0x0000000189882FF0
	// [XID] // 0x0000000189882FB0-0x0000000189882FF0
	public static new AddClimateMeter ParseFromJson(JSONNode node) => default; // 0x00000001847F4B80-0x00000001847F4DD0
	// [XID] // 0x000000018988D500-0x000000018988D520
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF458F */, bool useObjectPool = false /* Metadata: 0x00AF4593 */) => default; // 0x00000001847F4740-0x00000001847F4A40
	// [XID] // 0x0000000189894C70-0x0000000189894C90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4594 */, bool useObjectPool = false /* Metadata: 0x00AF4598 */) => default; // 0x00000001847F3610-0x00000001847F3920
	// [XID] // 0x000000018989C280-0x000000018989C2A0
	public static new AddClimateMeter ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4599 */, bool useObjectPool = false /* Metadata: 0x00AF459D */) => default; // 0x00000001847F4010-0x00000001847F4230
	[BlackList] // 0x00000001898A38C0-0x00000001898A3900
	// [XID] // 0x00000001898A38C0-0x00000001898A3900
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001847F2D20-0x00000001847F2FF0
	// [XID] // 0x00000001898AE0F0-0x00000001898AE110
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847F5100-0x00000001847F53B0
	[BlackList] // 0x00000001898B5670-0x00000001898B56B0
	// [XID] // 0x00000001898B5670-0x00000001898B56B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001847F4640-0x00000001847F4740
	// [XID] // 0x00000001898BFF00-0x00000001898BFF20
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001847F3920-0x00000001847F3A40
	[BlackList] // 0x00000001898DE4E0-0x00000001898DE520
	// [XID] // 0x00000001898DE4E0-0x00000001898DE520
	public override void AutoAllocTypeFields() {} // 0x00000001847F2FF0-0x00000001847F3090
	[BlackList] // 0x00000001898E8F20-0x00000001898E8F60
	// [XID] // 0x00000001898E8F20-0x00000001898E8F60
	public override void AutoRecycleTypeFields() {} // 0x00000001847F3090-0x00000001847F31C0
	[BlackList] // 0x00000001898F3660-0x00000001898F36A0
	// [XID] // 0x00000001898F3660-0x00000001898F36A0
	public override void ReturnToObjectPool() {} // 0x00000001847F54D0-0x00000001847F5570
}

