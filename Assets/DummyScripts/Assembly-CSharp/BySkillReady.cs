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
public class BySkillReady : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17256
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x18
	private SimpleSafeUInt32[] _skillSlot; // 0x20

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001899D3270-0x00000001899D3290 */ get => default; /* [XID] */ /* 0x00000001899DA7E0-0x00000001899DA800 */ private set {} } // 0x0000000183CB8C10-0x0000000183CB8CE0 0x0000000183CB9B30-0x0000000183CB9C10
	public SimpleSafeUInt32[] skillSlot { /* [XID] */ /* 0x00000001899E2200-0x00000001899E2220 */ get => default; /* [XID] */ /* 0x00000001899E9700-0x00000001899E9720 */ private set {} } // 0x0000000183CB8B70-0x0000000183CB8C10 0x0000000183CB7D50-0x0000000183CB7E00

	// Constructors
	public BySkillReady() {} // 0x0000000183CB9DC0-0x0000000183CB9E20

	// Methods
	// [XID] // 0x00000001899F0D90-0x00000001899F0DB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183CB9C10-0x0000000183CB9D20
	// [XID] // 0x00000001899F8670-0x00000001899F8690
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183CB96B0-0x0000000183CB9790
	// [XID] // 0x00000001899FFC20-0x00000001899FFC40
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF686F */) => default; // 0x0000000183CB92C0-0x0000000183CB93A0
	// [XID] // 0x0000000189A07510-0x0000000189A07530
	public override int GetHashNum() => default; // 0x0000000183CB7E80-0x0000000183CB7F50
	// [XID] // 0x0000000189A0E9D0-0x0000000189A0E9F0
	public override void InitEmpty() {} // 0x0000000183CB8CE0-0x0000000183CB8DF0
	[BlackList] // 0x0000000189A160E0-0x0000000189A16120
	// [XID] // 0x0000000189A160E0-0x0000000189A16120
	public override bool FromJson(JSONNode node) => default; // 0x0000000183CB8560-0x0000000183CB88E0
	// [XID] // 0x0000000189A20650-0x0000000189A20670
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183CB7510-0x0000000183CB7860
	[BlackList] // 0x0000000189A27AA0-0x0000000189A27AE0
	// [XID] // 0x0000000189A27AA0-0x0000000189A27AE0
	public static new BySkillReady ParseFromJson(JSONNode node) => default; // 0x0000000183CB9400-0x0000000183CB9650
	// [XID] // 0x0000000189A32000-0x0000000189A32020
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6870 */, bool useObjectPool = false /* Metadata: 0x00AF6874 */) => default; // 0x0000000183CB8FC0-0x0000000183CB92C0
	// [XID] // 0x0000000189A39910-0x0000000189A39930
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6875 */, bool useObjectPool = false /* Metadata: 0x00AF6879 */) => default; // 0x0000000183CB8030-0x0000000183CB8330
	// [XID] // 0x0000000189A41150-0x0000000189A41170
	public static new BySkillReady ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF687A */, bool useObjectPool = false /* Metadata: 0x00AF687E */) => default; // 0x0000000183CB88E0-0x0000000183CB8B00
	[BlackList] // 0x0000000189A48830-0x0000000189A48870
	// [XID] // 0x0000000189A48830-0x0000000189A48870
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183CB7860-0x0000000183CB7B30
	// [XID] // 0x0000000189A52E60-0x0000000189A52E80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183CB9840-0x0000000183CB9B30
	[BlackList] // 0x0000000189A5A6F0-0x0000000189A5A730
	// [XID] // 0x0000000189A5A6F0-0x0000000189A5A730
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183CB8ED0-0x0000000183CB8FC0
	// [XID] // 0x0000000189A65200-0x0000000189A65220
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000183CB8330-0x0000000183CB8460
	[BlackList] // 0x0000000189A6C980-0x0000000189A6C9C0
	// [XID] // 0x0000000189A6C980-0x0000000189A6C9C0
	public override void AutoAllocTypeFields() {} // 0x0000000183CB7B30-0x0000000183CB7BD0
	[BlackList] // 0x0000000189A771B0-0x0000000189A771F0
	// [XID] // 0x0000000189A771B0-0x0000000189A771F0
	public override void AutoRecycleTypeFields() {} // 0x0000000183CB7BD0-0x0000000183CB7CB0
	[BlackList] // 0x0000000189A81B70-0x0000000189A81BB0
	// [XID] // 0x0000000189A81B70-0x0000000189A81BB0
	public override void ReturnToObjectPool() {} // 0x0000000183CB9D20-0x0000000183CB9DC0
}

