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
public class ByTargetIsSelf : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17214
{
	// Fields
	private bool _isSelf; // 0x18

	// Properties
	public bool isSelf { /* [XID] */ /* 0x0000000189840DC0-0x0000000189840DE0 */ get => default; /* [XID] */ /* 0x00000001898482A0-0x00000001898482C0 */ private set {} } // 0x0000000185096980-0x0000000185096A20 0x0000000185097490-0x0000000185097540

	// Constructors
	public ByTargetIsSelf() {} // 0x0000000185098390-0x0000000185098400

	// Methods
	// [XID] // 0x000000018984FA00-0x000000018984FA20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185098200-0x00000001850982F0
	// [XID] // 0x0000000189856D60-0x0000000189856D80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185097EA0-0x0000000185097F50
	// [XID] // 0x000000018985DE90-0x000000018985DEB0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF66D7 */) => default; // 0x0000000185097AB0-0x0000000185097B90
	// [XID] // 0x00000001898658F0-0x0000000189865910
	public override int GetHashNum() => default; // 0x00000001850967D0-0x00000001850968A0
	// [XID] // 0x000000018986CD70-0x000000018986CD90
	public override void InitEmpty() {} // 0x0000000185097540-0x00000001850975E0
	[BlackList] // 0x00000001898741E0-0x0000000189874220
	// [XID] // 0x00000001898741E0-0x0000000189874220
	public override bool FromJson(JSONNode node) => default; // 0x0000000185096E80-0x0000000185097200
	// [XID] // 0x000000018987ED00-0x000000018987ED20
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185096090-0x0000000185096290
	[BlackList] // 0x0000000189886220-0x0000000189886260
	// [XID] // 0x0000000189886220-0x0000000189886260
	public static new ByTargetIsSelf ParseFromJson(JSONNode node) => default; // 0x0000000185097BF0-0x0000000185097E40
	// [XID] // 0x0000000189890460-0x0000000189890480
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66D8 */, bool useObjectPool = false /* Metadata: 0x00AF66DC */) => default; // 0x00000001850977B0-0x0000000185097AB0
	// [XID] // 0x0000000189897A20-0x0000000189897A40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66DD */, bool useObjectPool = false /* Metadata: 0x00AF66E1 */) => default; // 0x0000000185096A20-0x0000000185096C50
	// [XID] // 0x000000018989EE40-0x000000018989EE60
	public static new ByTargetIsSelf ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF66E2 */, bool useObjectPool = false /* Metadata: 0x00AF66E6 */) => default; // 0x0000000185097200-0x0000000185097420
	[BlackList] // 0x00000001898A6900-0x00000001898A6940
	// [XID] // 0x00000001898A6900-0x00000001898A6940
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185096290-0x0000000185096560
	// [XID] // 0x00000001898B0F60-0x00000001898B0F80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185098000-0x0000000185098200
	[BlackList] // 0x00000001898B86E0-0x00000001898B8720
	// [XID] // 0x00000001898B86E0-0x00000001898B8720
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001850976C0-0x00000001850977B0
	// [XID] // 0x00000001898C2CE0-0x00000001898C2D00
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000185096C50-0x0000000185096D80
	[BlackList] // 0x00000001898CA6A0-0x00000001898CA6E0
	// [XID] // 0x00000001898CA6A0-0x00000001898CA6E0
	public override void AutoAllocTypeFields() {} // 0x0000000185096560-0x0000000185096600
	[BlackList] // 0x00000001898D4EB0-0x00000001898D4EF0
	// [XID] // 0x00000001898D4EB0-0x00000001898D4EF0
	public override void AutoRecycleTypeFields() {} // 0x0000000185096600-0x00000001850966B0
	[BlackList] // 0x00000001898DFB80-0x00000001898DFBC0
	// [XID] // 0x00000001898DFB80-0x00000001898DFBC0
	public override void ReturnToObjectPool() {} // 0x00000001850982F0-0x0000000185098390
}

