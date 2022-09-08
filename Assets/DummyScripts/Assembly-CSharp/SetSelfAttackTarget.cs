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
public class SetSelfAttackTarget : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16579
{
	// Fields
	private bool _turnToTargetImmediately; // 0x68
	private bool _turnToTargetKeepUpAxisDirection; // 0x69

	// Properties
	public bool turnToTargetImmediately { /* [XID] */ /* 0x00000001897D3DE0-0x00000001897D3E00 */ get => default; /* [XID] */ /* 0x00000001897DB730-0x00000001897DB750 */ private set {} } // 0x0000000185522020-0x00000001855220C0 0x0000000185520AE0-0x0000000185520B90
	public bool turnToTargetKeepUpAxisDirection { /* [XID] */ /* 0x00000001897E2EC0-0x00000001897E2EE0 */ get => default; /* [XID] */ /* 0x00000001897EA6E0-0x00000001897EA700 */ private set {} } // 0x0000000185522120-0x00000001855221C0 0x0000000185520A30-0x0000000185520AE0
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018987BF20-0x000000018987BF40 */ get => default; } // 0x0000000185522410-0x00000001855224B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189883070-0x0000000189883090 */ get => default; } // 0x0000000185521930-0x00000001855219D0 

	// Constructors
	public SetSelfAttackTarget() {} // 0x0000000185522D20-0x0000000185522D80

	// Methods
	// [XID] // 0x00000001897F2470-0x00000001897F2490
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185522AD0-0x0000000185522BE0
	// [XID] // 0x00000001897F9BC0-0x00000001897F9BE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185522510-0x00000001855225C0
	// [XID] // 0x0000000189801160-0x0000000189801180
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3FCA */) => default; // 0x0000000185521F40-0x0000000185522020
	// [XID] // 0x0000000189808520-0x0000000189808540
	public override int GetHashNum() => default; // 0x0000000185520960-0x0000000185520A30
	// [XID] // 0x00000001898100D0-0x00000001898100F0
	public override void InitEmpty() {} // 0x00000001855219D0-0x0000000185521A70
	[BlackList] // 0x00000001898176C0-0x0000000189817700
	// [XID] // 0x00000001898176C0-0x0000000189817700
	public override bool FromJson(JSONNode node) => default; // 0x0000000185521200-0x0000000185521580
	// [XID] // 0x0000000189822030-0x0000000189822050
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001855200E0-0x00000001855203B0
	[BlackList] // 0x0000000189829590-0x00000001898295D0
	// [XID] // 0x0000000189829590-0x00000001898295D0
	public static new SetSelfAttackTarget ParseFromJson(JSONNode node) => default; // 0x00000001855221C0-0x0000000185522410
	// [XID] // 0x0000000189833C20-0x0000000189833C40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FCB */, bool useObjectPool = false /* Metadata: 0x00AF3FCF */) => default; // 0x0000000185521C40-0x0000000185521F40
	// [XID] // 0x000000018983B160-0x000000018983B180
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FD0 */, bool useObjectPool = false /* Metadata: 0x00AF3FD4 */) => default; // 0x0000000185520CE0-0x0000000185520F80
	// [XID] // 0x0000000189842A00-0x0000000189842A20
	public static new SetSelfAttackTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FD5 */, bool useObjectPool = false /* Metadata: 0x00AF3FD9 */) => default; // 0x0000000185521630-0x0000000185521850
	[BlackList] // 0x0000000189849CF0-0x0000000189849D30
	// [XID] // 0x0000000189849CF0-0x0000000189849D30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001855203B0-0x0000000185520680
	// [XID] // 0x0000000189853DC0-0x0000000189853DE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001855226A0-0x0000000185522930
	[BlackList] // 0x000000018985B8B0-0x000000018985B8F0
	// [XID] // 0x000000018985B8B0-0x000000018985B8F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185521B50-0x0000000185521C40
	// [XID] // 0x0000000189865A50-0x0000000189865A70
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185522BE0-0x0000000185522C80
	// [XID] // 0x000000018986CF70-0x000000018986CF90
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185520F80-0x0000000185521100
	// [XID] // 0x0000000189874380-0x00000001898743A0
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x0000000185522930-0x0000000185522AD0
	[BlackList] // 0x000000018988A810-0x000000018988A850
	// [XID] // 0x000000018988A810-0x000000018988A850
	public override void AutoAllocTypeFields() {} // 0x0000000185520680-0x0000000185520720
	[BlackList] // 0x0000000189894C90-0x0000000189894CD0
	// [XID] // 0x0000000189894C90-0x0000000189894CD0
	public override void AutoRecycleTypeFields() {} // 0x0000000185520720-0x00000001855207D0
	[BlackList] // 0x000000018989EF60-0x000000018989EFA0
	// [XID] // 0x000000018989EF60-0x000000018989EFA0
	public override void ReturnToObjectPool() {} // 0x0000000185522C80-0x0000000185522D20
}

