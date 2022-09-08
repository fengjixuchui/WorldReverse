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
public class SetAISkillCDAvailableNow : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16609
{
	// Fields
	private SimpleSafeUInt32[] _skillIDs; // 0x68

	// Properties
	public SimpleSafeUInt32[] skillIDs { /* [XID] */ /* 0x000000018999EC10-0x000000018999EC30 */ get => default; /* [XID] */ /* 0x00000001899A65D0-0x00000001899A65F0 */ private set {} } // 0x00000001831CC7C0-0x00000001831CC860 0x00000001831CC710-0x00000001831CC7C0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A292E0-0x0000000189A29300 */ get => default; } // 0x00000001831CC530-0x00000001831CC5D0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A308B0-0x0000000189A308D0 */ get => default; } // 0x00000001831CBB60-0x00000001831CBC00 

	// Constructors
	public SetAISkillCDAvailableNow() {} // 0x00000001831CCD10-0x00000001831CCD70

	// Methods
	// [XID] // 0x00000001899ADD80-0x00000001899ADDA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001831CCB80-0x00000001831CCC70
	// [XID] // 0x00000001899B54E0-0x00000001899B5500
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001831CC630-0x00000001831CC710
	// [XID] // 0x00000001899BCC70-0x00000001899BCC90
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF40BA */) => default; // 0x00000001831CC1A0-0x00000001831CC280
	// [XID] // 0x00000001899C4640-0x00000001899C4660
	public override int GetHashNum() => default; // 0x00000001831CAE60-0x00000001831CAF30
	// [XID] // 0x00000001899CBE60-0x00000001899CBE80
	public override void InitEmpty() {} // 0x00000001831CBC00-0x00000001831CBCD0
	[BlackList] // 0x00000001899D3390-0x00000001899D33D0
	// [XID] // 0x00000001899D3390-0x00000001899D33D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001831CB550-0x00000001831CB8D0
	// [XID] // 0x00000001899DD760-0x00000001899DD780
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001831CA680-0x00000001831CA8B0
	[BlackList] // 0x00000001899E54A0-0x00000001899E54E0
	// [XID] // 0x00000001899E54A0-0x00000001899E54E0
	public static new SetAISkillCDAvailableNow ParseFromJson(JSONNode node) => default; // 0x00000001831CC2E0-0x00000001831CC530
	// [XID] // 0x00000001899EF7B0-0x00000001899EF7D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40BB */, bool useObjectPool = false /* Metadata: 0x00AF40BF */) => default; // 0x00000001831CBEA0-0x00000001831CC1A0
	// [XID] // 0x00000001899F6FF0-0x00000001899F7010
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40C0 */, bool useObjectPool = false /* Metadata: 0x00AF40C4 */) => default; // 0x00000001831CB080-0x00000001831CB2F0
	// [XID] // 0x00000001899FE770-0x00000001899FE790
	public static new SetAISkillCDAvailableNow ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40C5 */, bool useObjectPool = false /* Metadata: 0x00AF40C9 */) => default; // 0x00000001831CB8D0-0x00000001831CBAF0
	[BlackList] // 0x0000000189A05FD0-0x0000000189A06010
	// [XID] // 0x0000000189A05FD0-0x0000000189A06010
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001831CA8B0-0x00000001831CAB80
	// [XID] // 0x0000000189A101D0-0x0000000189A101F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001831CC940-0x00000001831CCB80
	[BlackList] // 0x0000000189A17790-0x0000000189A177D0
	// [XID] // 0x0000000189A17790-0x0000000189A177D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001831CBDB0-0x00000001831CBEA0
	// [XID] // 0x0000000189A21ED0-0x0000000189A21EF0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001831CB2F0-0x00000001831CB450
	[BlackList] // 0x0000000189A38250-0x0000000189A38290
	// [XID] // 0x0000000189A38250-0x0000000189A38290
	public override void AutoAllocTypeFields() {} // 0x00000001831CAB80-0x00000001831CAC20
	[BlackList] // 0x0000000189A42990-0x0000000189A429D0
	// [XID] // 0x0000000189A42990-0x0000000189A429D0
	public override void AutoRecycleTypeFields() {} // 0x00000001831CAC20-0x00000001831CACD0
	[BlackList] // 0x0000000189A4D040-0x0000000189A4D080
	// [XID] // 0x0000000189A4D040-0x0000000189A4D080
	public override void ReturnToObjectPool() {} // 0x00000001831CCC70-0x00000001831CCD10
}

