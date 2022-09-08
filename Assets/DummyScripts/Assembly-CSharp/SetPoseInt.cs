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
public class SetPoseInt : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16541
{
	// Fields
	private string _intID; // 0x68
	private SimpleSafeInt32 valueRawNum; // 0x70

	// Properties
	public string intID { /* [XID] */ /* 0x0000000189A5C260-0x0000000189A5C280 */ get => default; /* [XID] */ /* 0x0000000189A63BF0-0x0000000189A63C10 */ private set {} } // 0x000000018487A200-0x000000018487A2A0 0x000000018487B080-0x000000018487B130
	public int value { /* [XID] */ /* 0x0000000189A6B3D0-0x0000000189A6B3F0 */ get => default; /* [XID] */ /* 0x0000000189A72C40-0x0000000189A72C60 */ private set {} } // 0x000000018487A130-0x000000018487A200 0x0000000184879FD0-0x000000018487A0B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AFEE10-0x0000000189AFEE30 */ get => default; } // 0x000000018487B3E0-0x000000018487B480 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B06600-0x0000000189B06620 */ get => default; } // 0x000000018487A920-0x000000018487A9C0 

	// Constructors
	public SetPoseInt() {} // 0x000000018487BBB0-0x000000018487BC10

	// Methods
	// [XID] // 0x0000000189A7A750-0x0000000189A7A770
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018487B960-0x000000018487BA70
	// [XID] // 0x0000000189A81CB0-0x0000000189A81CD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018487B4E0-0x000000018487B5C0
	// [XID] // 0x0000000189A89770-0x0000000189A89790
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3EA6 */) => default; // 0x000000018487AFA0-0x000000018487B080
	// [XID] // 0x0000000189A90EB0-0x0000000189A90ED0
	public override int GetHashNum() => default; // 0x00000001848798D0-0x00000001848799A0
	// [XID] // 0x0000000189A98700-0x0000000189A98720
	public override void InitEmpty() {} // 0x000000018487A9C0-0x000000018487AAD0
	[BlackList] // 0x0000000189A9FB70-0x0000000189A9FBB0
	// [XID] // 0x0000000189A9FB70-0x0000000189A9FBB0
	public override bool FromJson(JSONNode node) => default; // 0x000000018487A2A0-0x000000018487A620
	// [XID] // 0x0000000189AA9FE0-0x0000000189AAA000
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184878FA0-0x00000001848792F0
	[BlackList] // 0x0000000189AB1DE0-0x0000000189AB1E20
	// [XID] // 0x0000000189AB1DE0-0x0000000189AB1E20
	public static new SetPoseInt ParseFromJson(JSONNode node) => default; // 0x000000018487B190-0x000000018487B3E0
	// [XID] // 0x0000000189ABC880-0x0000000189ABC8A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EA7 */, bool useObjectPool = false /* Metadata: 0x00AF3EAB */) => default; // 0x000000018487ACA0-0x000000018487AFA0
	// [XID] // 0x0000000189AC4140-0x0000000189AC4160
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EAC */, bool useObjectPool = false /* Metadata: 0x00AF3EB0 */) => default; // 0x0000000184879AF0-0x0000000184879DF0
	// [XID] // 0x0000000189ACB670-0x0000000189ACB690
	public static new SetPoseInt ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EB1 */, bool useObjectPool = false /* Metadata: 0x00AF3EB5 */) => default; // 0x000000018487A620-0x000000018487A840
	[BlackList] // 0x0000000189AD30C0-0x0000000189AD3100
	// [XID] // 0x0000000189AD30C0-0x0000000189AD3100
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001848792F0-0x00000001848795C0
	// [XID] // 0x0000000189ADDDC0-0x0000000189ADDDE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018487B6A0-0x000000018487B960
	[BlackList] // 0x0000000189AE5800-0x0000000189AE5840
	// [XID] // 0x0000000189AE5800-0x0000000189AE5840
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018487ABB0-0x000000018487ACA0
	// [XID] // 0x0000000189AF0370-0x0000000189AF0390
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018487BA70-0x000000018487BB10
	// [XID] // 0x0000000189AF77A0-0x0000000189AF77C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184879DF0-0x0000000184879F50
	[BlackList] // 0x0000000189B0DC30-0x0000000189B0DC70
	// [XID] // 0x0000000189B0DC30-0x0000000189B0DC70
	public override void AutoAllocTypeFields() {} // 0x00000001848795C0-0x0000000184879660
	[BlackList] // 0x0000000189B180C0-0x0000000189B18100
	// [XID] // 0x0000000189B180C0-0x0000000189B18100
	public override void AutoRecycleTypeFields() {} // 0x0000000184879660-0x0000000184879740
	[BlackList] // 0x0000000189B22790-0x0000000189B227D0
	// [XID] // 0x0000000189B22790-0x0000000189B227D0
	public override void ReturnToObjectPool() {} // 0x000000018487BB10-0x000000018487BBB0
}

