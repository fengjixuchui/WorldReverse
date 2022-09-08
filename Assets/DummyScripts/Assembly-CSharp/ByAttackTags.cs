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
public class ByAttackTags : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17246
{
	// Fields
	private string[] _attackTags; // 0x18

	// Properties
	public string[] attackTags { /* [XID] */ /* 0x00000001896ECCC0-0x00000001896ECCE0 */ get => default; /* [XID] */ /* 0x00000001896F44C0-0x00000001896F44E0 */ private set {} } // 0x00000001814FADE0-0x00000001814FAE80 0x00000001814FA9F0-0x00000001814FAAA0

	// Constructors
	public ByAttackTags() {} // 0x00000001814FC900-0x00000001814FC960

	// Methods
	// [XID] // 0x00000001896FBCF0-0x00000001896FBD10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001814FC770-0x00000001814FC860
	// [XID] // 0x0000000189703230-0x0000000189703250
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001814FC3A0-0x00000001814FC480
	// [XID] // 0x000000018970A940-0x000000018970A960
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF67E7 */) => default; // 0x00000001814FBFB0-0x00000001814FC090
	// [XID] // 0x0000000189712410-0x0000000189712430
	public override int GetHashNum() => default; // 0x00000001814FAD10-0x00000001814FADE0
	// [XID] // 0x0000000189719AB0-0x0000000189719AD0
	public override void InitEmpty() {} // 0x00000001814FBA10-0x00000001814FBAE0
	[BlackList] // 0x0000000189720FD0-0x0000000189721010
	// [XID] // 0x0000000189720FD0-0x0000000189721010
	public override bool FromJson(JSONNode node) => default; // 0x00000001814FB400-0x00000001814FB780
	// [XID] // 0x000000018972B450-0x000000018972B470
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001814FA4F0-0x00000001814FA720
	[BlackList] // 0x0000000189732CE0-0x0000000189732D20
	// [XID] // 0x0000000189732CE0-0x0000000189732D20
	public static new ByAttackTags ParseFromJson(JSONNode node) => default; // 0x00000001814FC0F0-0x00000001814FC340
	// [XID] // 0x000000018973D7F0-0x000000018973D810
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67E8 */, bool useObjectPool = false /* Metadata: 0x00AF67EC */) => default; // 0x00000001814FBCB0-0x00000001814FBFB0
	// [XID] // 0x0000000189744C70-0x0000000189744C90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67ED */, bool useObjectPool = false /* Metadata: 0x00AF67F1 */) => default; // 0x00000001814FAF60-0x00000001814FB1D0
	// [XID] // 0x000000018974C8E0-0x000000018974C900
	public static new ByAttackTags ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67F2 */, bool useObjectPool = false /* Metadata: 0x00AF67F6 */) => default; // 0x00000001814FB780-0x00000001814FB9A0
	[BlackList] // 0x0000000189753BE0-0x0000000189753C20
	// [XID] // 0x0000000189753BE0-0x0000000189753C20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001814FA720-0x00000001814FA9F0
	// [XID] // 0x000000018975E0F0-0x000000018975E110
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001814FC530-0x00000001814FC770
	[BlackList] // 0x0000000189765850-0x0000000189765890
	// [XID] // 0x0000000189765850-0x0000000189765890
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001814FBBC0-0x00000001814FBCB0
	// [XID] // 0x000000018976FED0-0x000000018976FEF0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001814FB1D0-0x00000001814FB300
	[BlackList] // 0x00000001897776B0-0x00000001897776F0
	// [XID] // 0x00000001897776B0-0x00000001897776F0
	public override void AutoAllocTypeFields() {} // 0x00000001814FAAA0-0x00000001814FAB40
	[BlackList] // 0x0000000189782160-0x00000001897821A0
	// [XID] // 0x0000000189782160-0x00000001897821A0
	public override void AutoRecycleTypeFields() {} // 0x00000001814FAB40-0x00000001814FABF0
	[BlackList] // 0x000000018978C5D0-0x000000018978C610
	// [XID] // 0x000000018978C5D0-0x000000018978C610
	public override void ReturnToObjectPool() {} // 0x00000001814FC860-0x00000001814FC900
}

