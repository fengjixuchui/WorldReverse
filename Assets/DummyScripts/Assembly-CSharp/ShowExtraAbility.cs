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
public class ShowExtraAbility : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16779
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x68

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001897E2E60-0x00000001897E2E80 */ get => default; /* [XID] */ /* 0x00000001897EA680-0x00000001897EA6A0 */ private set {} } // 0x00000001849225B0-0x0000000184922680 0x0000000184923480-0x0000000184923560
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018986CEB0-0x000000018986CED0 */ get => default; } // 0x0000000184922FC0-0x0000000184923060 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898742E0-0x0000000189874300 */ get => default; } // 0x0000000184922510-0x00000001849225B0 

	// Constructors
	public ShowExtraAbility() {} // 0x00000001849236F0-0x0000000184923750

	// Methods
	// [XID] // 0x00000001897F2410-0x00000001897F2430
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184923560-0x0000000184923650
	// [XID] // 0x00000001897F9B40-0x00000001897F9B60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849230C0-0x0000000184923170
	// [XID] // 0x00000001898010A0-0x00000001898010C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF45FE */) => default; // 0x0000000184922C30-0x0000000184922D10
	// [XID] // 0x0000000189808480-0x00000001898084A0
	public override int GetHashNum() => default; // 0x0000000184921810-0x00000001849218E0
	// [XID] // 0x0000000189810050-0x0000000189810070
	public override void InitEmpty() {} // 0x0000000184922680-0x0000000184922750
	[BlackList] // 0x00000001898175E0-0x0000000189817620
	// [XID] // 0x00000001898175E0-0x0000000189817620
	public override bool FromJson(JSONNode node) => default; // 0x0000000184921F00-0x0000000184922280
	// [XID] // 0x0000000189821FB0-0x0000000189821FD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184920FD0-0x0000000184921230
	[BlackList] // 0x00000001898294B0-0x00000001898294F0
	// [XID] // 0x00000001898294B0-0x00000001898294F0
	public static new ShowExtraAbility ParseFromJson(JSONNode node) => default; // 0x0000000184922D70-0x0000000184922FC0
	// [XID] // 0x0000000189833BA0-0x0000000189833BC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF45FF */, bool useObjectPool = false /* Metadata: 0x00AF4603 */) => default; // 0x0000000184922930-0x0000000184922C30
	// [XID] // 0x000000018983B0C0-0x000000018983B0E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4604 */, bool useObjectPool = false /* Metadata: 0x00AF4608 */) => default; // 0x0000000184921A30-0x0000000184921CA0
	// [XID] // 0x0000000189842960-0x0000000189842980
	public static new ShowExtraAbility ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4609 */, bool useObjectPool = false /* Metadata: 0x00AF460D */) => default; // 0x0000000184922280-0x00000001849224A0
	[BlackList] // 0x0000000189849C10-0x0000000189849C50
	// [XID] // 0x0000000189849C10-0x0000000189849C50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184921230-0x0000000184921500
	// [XID] // 0x0000000189853CA0-0x0000000189853CC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184923250-0x0000000184923480
	[BlackList] // 0x000000018985B7D0-0x000000018985B810
	// [XID] // 0x000000018985B7D0-0x000000018985B810
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184922830-0x0000000184922930
	// [XID] // 0x00000001898659B0-0x00000001898659D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184921CA0-0x0000000184921E00
	[BlackList] // 0x000000018987BE40-0x000000018987BE80
	// [XID] // 0x000000018987BE40-0x000000018987BE80
	public override void AutoAllocTypeFields() {} // 0x0000000184921500-0x00000001849215A0
	[BlackList] // 0x0000000189886300-0x0000000189886340
	// [XID] // 0x0000000189886300-0x0000000189886340
	public override void AutoRecycleTypeFields() {} // 0x00000001849215A0-0x0000000184921680
	[BlackList] // 0x0000000189890580-0x00000001898905C0
	// [XID] // 0x0000000189890580-0x00000001898905C0
	public override void ReturnToObjectPool() {} // 0x0000000184923650-0x00000001849236F0
}

