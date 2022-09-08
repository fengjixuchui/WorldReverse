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
public class ChangePropTypeValueMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17004
{
	// Fields
	private string _propType; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _energyCostDelta; // 0x38

	// Properties
	public string propType { /* [XID] */ /* 0x00000001898714B0-0x00000001898714D0 */ get => default; /* [XID] */ /* 0x0000000189878E50-0x0000000189878E70 */ private set {} } // 0x0000000182FF9CD0-0x0000000182FF9D70 0x0000000182FF8830-0x0000000182FF88E0
	public DynamicFloat energyCostDelta { /* [XID] */ /* 0x0000000189880480-0x00000001898804A0 */ get => default; /* [XID] */ /* 0x00000001898879C0-0x00000001898879E0 */ private set {} } // 0x0000000182FF9B30-0x0000000182FF9BD0 0x0000000182FF97D0-0x0000000182FF9880
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018990B590-0x000000018990B5B0 */ get => default; } // 0x0000000182FF8790-0x0000000182FF8830 

	// Constructors
	public ChangePropTypeValueMixin() {} // 0x0000000182FFA1F0-0x0000000182FFA250

	// Methods
	// [XID] // 0x000000018988ECC0-0x000000018988ECE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182FFA020-0x0000000182FFA150
	// [XID] // 0x0000000189896200-0x0000000189896220
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182FF9BD0-0x0000000182FF9CD0
	// [XID] // 0x000000018989D8A0-0x000000018989D8C0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF601D */) => default; // 0x0000000182FF9690-0x0000000182FF9770
	// [XID] // 0x00000001898A5220-0x00000001898A5240
	public override int GetHashNum() => default; // 0x0000000182FF81B0-0x0000000182FF8280
	// [XID] // 0x00000001898AC780-0x00000001898AC7A0
	public override void InitEmpty() {} // 0x0000000182FF8FF0-0x0000000182FF90E0
	[BlackList] // 0x00000001898B3C40-0x00000001898B3C80
	// [XID] // 0x00000001898B3C40-0x00000001898B3C80
	public override bool FromJson(JSONNode node) => default; // 0x0000000182FF88E0-0x0000000182FF8C60
	// [XID] // 0x00000001898BE5E0-0x00000001898BE600
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182FF78B0-0x0000000182FF7BE0
	[BlackList] // 0x00000001898C5D50-0x00000001898C5D90
	// [XID] // 0x00000001898C5D50-0x00000001898C5D90
	public static new ChangePropTypeValueMixin ParseFromJson(JSONNode node) => default; // 0x0000000182FF9880-0x0000000182FF9AD0
	// [XID] // 0x00000001898D0780-0x00000001898D07A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF601E */, bool useObjectPool = false /* Metadata: 0x00AF6022 */) => default; // 0x0000000182FF92B0-0x0000000182FF95B0
	// [XID] // 0x00000001898D7E80-0x00000001898D7EA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6023 */, bool useObjectPool = false /* Metadata: 0x00AF6027 */) => default; // 0x0000000182FF8360-0x0000000182FF8690
	// [XID] // 0x00000001898DFC80-0x00000001898DFCA0
	public static new ChangePropTypeValueMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6028 */, bool useObjectPool = false /* Metadata: 0x00AF602C */) => default; // 0x0000000182FF8CD0-0x0000000182FF8EF0
	[BlackList] // 0x00000001898E76B0-0x00000001898E76F0
	// [XID] // 0x00000001898E76B0-0x00000001898E76F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FF7BE0-0x0000000182FF7EB0
	// [XID] // 0x00000001898F1E70-0x00000001898F1E90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182FF9D70-0x0000000182FFA020
	[BlackList] // 0x00000001898F96B0-0x00000001898F96F0
	// [XID] // 0x00000001898F96B0-0x00000001898F96F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182FF91C0-0x0000000182FF92B0
	// [XID] // 0x0000000189903FD0-0x0000000189903FF0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182FF95B0-0x0000000182FF9690
	[BlackList] // 0x0000000189913260-0x00000001899132A0
	// [XID] // 0x0000000189913260-0x00000001899132A0
	public override void AutoAllocTypeFields() {} // 0x0000000182FF7EB0-0x0000000182FF7F50
	[BlackList] // 0x000000018991D9B0-0x000000018991D9F0
	// [XID] // 0x000000018991D9B0-0x000000018991D9F0
	public override void AutoRecycleTypeFields() {} // 0x0000000182FF7F50-0x0000000182FF8090
	[BlackList] // 0x00000001899280D0-0x0000000189928110
	// [XID] // 0x00000001899280D0-0x0000000189928110
	public override void ReturnToObjectPool() {} // 0x0000000182FFA150-0x0000000182FFA1F0
}

