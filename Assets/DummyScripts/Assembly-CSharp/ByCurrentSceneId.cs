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
public class ByCurrentSceneId : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17372
{
	// Fields
	private SimpleSafeUInt32[] _sceneIds; // 0x18

	// Properties
	public SimpleSafeUInt32[] sceneIds { /* [XID] */ /* 0x000000018991A930-0x000000018991A950 */ get => default; /* [XID] */ /* 0x00000001899221E0-0x0000000189922200 */ private set {} } // 0x0000000182B5A910-0x0000000182B5A9B0 0x0000000182B5B100-0x0000000182B5B1B0

	// Constructors
	public ByCurrentSceneId() {} // 0x0000000182B5B9C0-0x0000000182B5BA70

	// Methods
	// [XID] // 0x00000001899299E0-0x0000000189929A00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B5B830-0x0000000182B5B920
	// [XID] // 0x0000000189930F80-0x0000000189930FA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B5B460-0x0000000182B5B540
	// [XID] // 0x0000000189938370-0x0000000189938390
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6BFF */) => default; // 0x0000000182B5AFC0-0x0000000182B5B0A0
	// [XID] // 0x000000018993FCE0-0x000000018993FD00
	public override int GetHashNum() => default; // 0x0000000182B59D20-0x0000000182B59DF0
	// [XID] // 0x00000001899473A0-0x00000001899473C0
	public override void InitEmpty() {} // 0x0000000182B5AA20-0x0000000182B5AAF0
	[BlackList] // 0x000000018994EB00-0x000000018994EB40
	// [XID] // 0x000000018994EB00-0x000000018994EB40
	public override bool FromJson(JSONNode node) => default; // 0x0000000182B5A370-0x0000000182B5A6F0
	// [XID] // 0x0000000189959210-0x0000000189959230
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182B595B0-0x0000000182B597E0
	[BlackList] // 0x0000000189960A80-0x0000000189960AC0
	// [XID] // 0x0000000189960A80-0x0000000189960AC0
	public static new ByCurrentSceneId ParseFromJson(JSONNode node) => default; // 0x0000000182B5B1B0-0x0000000182B5B400
	// [XID] // 0x000000018996B110-0x000000018996B130
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C00 */, bool useObjectPool = false /* Metadata: 0x00AF6C04 */) => default; // 0x0000000182B5ACC0-0x0000000182B5AFC0
	// [XID] // 0x0000000189972BB0-0x0000000189972BD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C05 */, bool useObjectPool = false /* Metadata: 0x00AF6C09 */) => default; // 0x0000000182B59ED0-0x0000000182B5A140
	// [XID] // 0x000000018997A4D0-0x000000018997A4F0
	public static new ByCurrentSceneId ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C0A */, bool useObjectPool = false /* Metadata: 0x00AF6C0E */) => default; // 0x0000000182B5A6F0-0x0000000182B5A910
	[BlackList] // 0x0000000189981CE0-0x0000000189981D20
	// [XID] // 0x0000000189981CE0-0x0000000189981D20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B597E0-0x0000000182B59AB0
	// [XID] // 0x000000018998C3D0-0x000000018998C3F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B5B5F0-0x0000000182B5B830
	[BlackList] // 0x00000001899940D0-0x0000000189994110
	// [XID] // 0x00000001899940D0-0x0000000189994110
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B5ABD0-0x0000000182B5ACC0
	// [XID] // 0x000000018999EAD0-0x000000018999EAF0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182B5A140-0x0000000182B5A270
	[BlackList] // 0x00000001899A64D0-0x00000001899A6510
	// [XID] // 0x00000001899A64D0-0x00000001899A6510
	public override void AutoAllocTypeFields() {} // 0x0000000182B59AB0-0x0000000182B59B50
	[BlackList] // 0x00000001899B0E10-0x00000001899B0E50
	// [XID] // 0x00000001899B0E10-0x00000001899B0E50
	public override void AutoRecycleTypeFields() {} // 0x0000000182B59B50-0x0000000182B59C00
	[BlackList] // 0x00000001899BB210-0x00000001899BB250
	// [XID] // 0x00000001899BB210-0x00000001899BB250
	public override void ReturnToObjectPool() {} // 0x0000000182B5B920-0x0000000182B5B9C0
}

