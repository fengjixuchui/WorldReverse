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
public class RegistToStageScript : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16649
{
	// Fields
	private string _alias; // 0x68

	// Properties
	public string alias { /* [XID] */ /* 0x00000001897F9B80-0x00000001897F9BA0 */ get => default; /* [XID] */ /* 0x0000000189801120-0x0000000189801140 */ private set {} } // 0x0000000183EBEE90-0x0000000183EBEF30 0x0000000183EBF960-0x0000000183EBFA10
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018988A7F0-0x000000018988A810 */ get => default; } // 0x0000000183EBFCC0-0x0000000183EBFD60 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189891C80-0x0000000189891CA0 */ get => default; } // 0x0000000183EBF230-0x0000000183EBF2D0 

	// Constructors
	public RegistToStageScript() {} // 0x0000000183EC03B0-0x0000000183EC0410

	// Methods
	// [XID] // 0x00000001898084E0-0x0000000189808500
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183EC0180-0x0000000183EC0270
	// [XID] // 0x0000000189810090-0x00000001898100B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183EBFDC0-0x0000000183EBFEA0
	// [XID] // 0x0000000189817660-0x0000000189817680
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF41FA */) => default; // 0x0000000183EBF880-0x0000000183EBF960
	// [XID] // 0x000000018981F000-0x000000018981F020
	public override int GetHashNum() => default; // 0x0000000183EBE420-0x0000000183EBE4F0
	// [XID] // 0x0000000189826590-0x00000001898265B0
	public override void InitEmpty() {} // 0x0000000183EBF2D0-0x0000000183EBF3A0
	[BlackList] // 0x000000018982DBA0-0x000000018982DBE0
	// [XID] // 0x000000018982DBA0-0x000000018982DBE0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183EBEB10-0x0000000183EBEE90
	// [XID] // 0x0000000189838240-0x0000000189838260
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183EBDC40-0x0000000183EBDE70
	[BlackList] // 0x000000018983F8D0-0x000000018983F910
	// [XID] // 0x000000018983F8D0-0x000000018983F910
	public static new RegistToStageScript ParseFromJson(JSONNode node) => default; // 0x0000000183EBFA70-0x0000000183EBFCC0
	// [XID] // 0x0000000189849C90-0x0000000189849CB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41FB */, bool useObjectPool = false /* Metadata: 0x00AF41FF */) => default; // 0x0000000183EBF580-0x0000000183EBF880
	// [XID] // 0x00000001898513B0-0x00000001898513D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4200 */, bool useObjectPool = false /* Metadata: 0x00AF4204 */) => default; // 0x0000000183EBE640-0x0000000183EBE8B0
	// [XID] // 0x00000001898588E0-0x0000000189858900
	public static new RegistToStageScript ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4205 */, bool useObjectPool = false /* Metadata: 0x00AF4209 */) => default; // 0x0000000183EBEF30-0x0000000183EBF150
	[BlackList] // 0x000000018985F9B0-0x000000018985F9F0
	// [XID] // 0x000000018985F9B0-0x000000018985F9F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183EBDE70-0x0000000183EBE140
	// [XID] // 0x000000018986A200-0x000000018986A220
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183EBFF80-0x0000000183EC0180
	[BlackList] // 0x0000000189871610-0x0000000189871650
	// [XID] // 0x0000000189871610-0x0000000189871650
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183EBF480-0x0000000183EBF580
	// [XID] // 0x000000018987BEE0-0x000000018987BF00
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183EC0270-0x0000000183EC0310
	// [XID] // 0x0000000189883010-0x0000000189883030
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183EBE8B0-0x0000000183EBEA10
	[BlackList] // 0x0000000189899510-0x0000000189899550
	// [XID] // 0x0000000189899510-0x0000000189899550
	public override void AutoAllocTypeFields() {} // 0x0000000183EBE140-0x0000000183EBE1E0
	[BlackList] // 0x00000001898A3900-0x00000001898A3940
	// [XID] // 0x00000001898A3900-0x00000001898A3940
	public override void AutoRecycleTypeFields() {} // 0x0000000183EBE1E0-0x0000000183EBE290
	[BlackList] // 0x00000001898AE150-0x00000001898AE190
	// [XID] // 0x00000001898AE150-0x00000001898AE190
	public override void ReturnToObjectPool() {} // 0x0000000183EC0310-0x0000000183EC03B0
}

