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
public class ByTargetElement : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17216
{
	// Fields
	private ElementType _elementType; // 0x18

	// Properties
	public ElementType elementType { /* [XID] */ /* 0x00000001898F1D90-0x00000001898F1DB0 */ get => default; /* [XID] */ /* 0x00000001898F9610-0x00000001898F9630 */ private set {} } // 0x0000000182372C80-0x0000000182372D20 0x0000000182373AE0-0x0000000182373B90

	// Constructors
	public ByTargetElement() {} // 0x0000000182374330-0x0000000182374390

	// Methods
	// [XID] // 0x0000000189901010-0x0000000189901030
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001823741A0-0x0000000182374290
	// [XID] // 0x00000001899088F0-0x0000000189908910
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182373E40-0x0000000182373EF0
	// [XID] // 0x000000018990FEB0-0x000000018990FED0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF66E7 */) => default; // 0x00000001823739A0-0x0000000182373A80
	// [XID] // 0x0000000189917AA0-0x0000000189917AC0
	public override int GetHashNum() => default; // 0x0000000182372770-0x0000000182372840
	// [XID] // 0x000000018991EFA0-0x000000018991EFC0
	public override void InitEmpty() {} // 0x0000000182373430-0x00000001823734D0
	[BlackList] // 0x0000000189926A00-0x0000000189926A40
	// [XID] // 0x0000000189926A00-0x0000000189926A40
	public override bool FromJson(JSONNode node) => default; // 0x0000000182372E20-0x00000001823731A0
	// [XID] // 0x0000000189930FA0-0x0000000189930FC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182372010-0x0000000182372230
	[BlackList] // 0x00000001899383D0-0x0000000189938410
	// [XID] // 0x00000001899383D0-0x0000000189938410
	public static new ByTargetElement ParseFromJson(JSONNode node) => default; // 0x0000000182373B90-0x0000000182373DE0
	// [XID] // 0x0000000189942A90-0x0000000189942AB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66E8 */, bool useObjectPool = false /* Metadata: 0x00AF66EC */) => default; // 0x00000001823736A0-0x00000001823739A0
	// [XID] // 0x000000018994A260-0x000000018994A280
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66ED */, bool useObjectPool = false /* Metadata: 0x00AF66F1 */) => default; // 0x0000000182372920-0x0000000182372B50
	// [XID] // 0x0000000189951CF0-0x0000000189951D10
	public static new ByTargetElement ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66F2 */, bool useObjectPool = false /* Metadata: 0x00AF66F6 */) => default; // 0x00000001823731A0-0x00000001823733C0
	[BlackList] // 0x0000000189959270-0x00000001899592B0
	// [XID] // 0x0000000189959270-0x00000001899592B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182372230-0x0000000182372500
	// [XID] // 0x0000000189963B80-0x0000000189963BA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182373FA0-0x00000001823741A0
	[BlackList] // 0x000000018996B130-0x000000018996B170
	// [XID] // 0x000000018996B130-0x000000018996B170
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001823735B0-0x00000001823736A0
	// [XID] // 0x0000000189975B70-0x0000000189975B90
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182372B50-0x0000000182372C80
	[BlackList] // 0x000000018997CB50-0x000000018997CB90
	// [XID] // 0x000000018997CB50-0x000000018997CB90
	public override void AutoAllocTypeFields() {} // 0x0000000182372500-0x00000001823725A0
	[BlackList] // 0x0000000189987970-0x00000001899879B0
	// [XID] // 0x0000000189987970-0x00000001899879B0
	public override void AutoRecycleTypeFields() {} // 0x00000001823725A0-0x0000000182372650
	[BlackList] // 0x00000001899926B0-0x00000001899926F0
	// [XID] // 0x00000001899926B0-0x00000001899926F0
	public override void ReturnToObjectPool() {} // 0x0000000182374290-0x0000000182374330
}

