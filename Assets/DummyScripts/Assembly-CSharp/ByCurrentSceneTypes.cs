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
public class ByCurrentSceneTypes : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17368
{
	// Fields
	private SceneType[] _SceneTypes; // 0x18

	// Properties
	public SceneType[] SceneTypes { /* [XID] */ /* 0x00000001897A7920-0x00000001897A7940 */ get => default; /* [XID] */ /* 0x00000001897AF3D0-0x00000001897AF3F0 */ private set {} } // 0x000000018169EE00-0x000000018169EEA0 0x000000018169EF10-0x000000018169EFC0

	// Constructors
	public ByCurrentSceneTypes() {} // 0x000000018169FEB0-0x000000018169FF10

	// Methods
	// [XID] // 0x00000001897B7230-0x00000001897B7250
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018169FD20-0x000000018169FE10
	// [XID] // 0x00000001897BF130-0x00000001897BF150
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018169F950-0x000000018169FA30
	// [XID] // 0x00000001897C66E0-0x00000001897C6700
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6BDF */) => default; // 0x000000018169F560-0x000000018169F640
	// [XID] // 0x00000001897CDF00-0x00000001897CDF20
	public override int GetHashNum() => default; // 0x000000018169E210-0x000000018169E2E0
	// [XID] // 0x00000001897D5470-0x00000001897D5490
	public override void InitEmpty() {} // 0x000000018169EFC0-0x000000018169F090
	[BlackList] // 0x00000001897DCB70-0x00000001897DCBB0
	// [XID] // 0x00000001897DCB70-0x00000001897DCBB0
	public override bool FromJson(JSONNode node) => default; // 0x000000018169E860-0x000000018169EBE0
	// [XID] // 0x00000001897E7310-0x00000001897E7330
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018169DAA0-0x000000018169DCD0
	[BlackList] // 0x00000001897EEFF0-0x00000001897EF030
	// [XID] // 0x00000001897EEFF0-0x00000001897EF030
	public static new ByCurrentSceneTypes ParseFromJson(JSONNode node) => default; // 0x000000018169F6A0-0x000000018169F8F0
	// [XID] // 0x00000001897F9A40-0x00000001897F9A60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BE0 */, bool useObjectPool = false /* Metadata: 0x00AF6BE4 */) => default; // 0x000000018169F260-0x000000018169F560
	// [XID] // 0x0000000189800FC0-0x0000000189800FE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BE5 */, bool useObjectPool = false /* Metadata: 0x00AF6BE9 */) => default; // 0x000000018169E3C0-0x000000018169E630
	// [XID] // 0x0000000189808400-0x0000000189808420
	public static new ByCurrentSceneTypes ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BEA */, bool useObjectPool = false /* Metadata: 0x00AF6BEE */) => default; // 0x000000018169EBE0-0x000000018169EE00
	[BlackList] // 0x000000018980FF70-0x000000018980FFB0
	// [XID] // 0x000000018980FF70-0x000000018980FFB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018169DCD0-0x000000018169DFA0
	// [XID] // 0x000000018981A6E0-0x000000018981A700
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018169FAE0-0x000000018169FD20
	[BlackList] // 0x0000000189821ED0-0x0000000189821F10
	// [XID] // 0x0000000189821ED0-0x0000000189821F10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018169F170-0x000000018169F260
	// [XID] // 0x000000018982C530-0x000000018982C550
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x000000018169E630-0x000000018169E760
	[BlackList] // 0x0000000189833AA0-0x0000000189833AE0
	// [XID] // 0x0000000189833AA0-0x0000000189833AE0
	public override void AutoAllocTypeFields() {} // 0x000000018169DFA0-0x000000018169E040
	[BlackList] // 0x000000018983DDE0-0x000000018983DE20
	// [XID] // 0x000000018983DDE0-0x000000018983DE20
	public override void AutoRecycleTypeFields() {} // 0x000000018169E040-0x000000018169E0F0
	[BlackList] // 0x0000000189848260-0x00000001898482A0
	// [XID] // 0x0000000189848260-0x00000001898482A0
	public override void ReturnToObjectPool() {} // 0x000000018169FE10-0x000000018169FEB0
}

