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
public class ServerMonsterLog : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16813
{
	// Fields
	private SimpleSafeInt32[] _paramList; // 0x68

	// Properties
	public SimpleSafeInt32[] paramList { /* [XID] */ /* 0x0000000189628050-0x0000000189628070 */ get => default; /* [XID] */ /* 0x000000018962F8E0-0x000000018962F900 */ private set {} } // 0x00000001828BECB0-0x00000001828BED50 0x00000001828BF160-0x00000001828BF210
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896BACD0-0x00000001896BACF0 */ get => default; } // 0x00000001828C0300-0x00000001828C03A0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896C1DE0-0x00000001896C1E00 */ get => default; } // 0x00000001828BF920-0x00000001828BF9C0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001896C9430-0x00000001896C9450 */ get => default; } // 0x00000001828BEB40-0x00000001828BEBE0 

	// Constructors
	public ServerMonsterLog() {} // 0x00000001828C0B80-0x00000001828C0BE0

	// Methods
	// [XID] // 0x0000000189637480-0x00000001896374A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828C09F0-0x00000001828C0AE0
	// [XID] // 0x000000018963EA20-0x000000018963EA40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001828C0470-0x00000001828C0550
	// [XID] // 0x0000000189646160-0x0000000189646180
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF4716 */) => default; // 0x00000001828BFF70-0x00000001828C0050
	// [XID] // 0x000000018964D940-0x000000018964D960
	public override int GetHashNum() => default; // 0x00000001828BEA70-0x00000001828BEB40
	// [XID] // 0x0000000189655100-0x0000000189655120
	public override void InitEmpty() {} // 0x00000001828BF9C0-0x00000001828BFA90
	[BlackList] // 0x000000018965C980-0x000000018965C9C0
	// [XID] // 0x000000018965C980-0x000000018965C9C0
	public override bool FromJson(JSONNode node) => default; // 0x00000001828BF310-0x00000001828BF690
	// [XID] // 0x0000000189667130-0x0000000189667150
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001828BE290-0x00000001828BE4C0
	[BlackList] // 0x000000018966E860-0x000000018966E8A0
	// [XID] // 0x000000018966E860-0x000000018966E8A0
	public static new ServerMonsterLog ParseFromJson(JSONNode node) => default; // 0x00000001828C00B0-0x00000001828C0300
	// [XID] // 0x00000001896796B0-0x00000001896796D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4717 */, bool useObjectPool = false /* Metadata: 0x00AF471B */) => default; // 0x00000001828BFC70-0x00000001828BFF70
	// [XID] // 0x0000000189680E20-0x0000000189680E40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF471C */, bool useObjectPool = false /* Metadata: 0x00AF4720 */) => default; // 0x00000001828BEDD0-0x00000001828BF040
	// [XID] // 0x0000000189688840-0x0000000189688860
	public static new ServerMonsterLog ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4721 */, bool useObjectPool = false /* Metadata: 0x00AF4725 */) => default; // 0x00000001828BF690-0x00000001828BF8B0
	[BlackList] // 0x0000000189690220-0x0000000189690260
	// [XID] // 0x0000000189690220-0x0000000189690260
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001828BE4C0-0x00000001828BE790
	// [XID] // 0x000000018969A690-0x000000018969A6B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828C07B0-0x00000001828C09F0
	[BlackList] // 0x00000001896A1FE0-0x00000001896A2020
	// [XID] // 0x00000001896A1FE0-0x00000001896A2020
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001828BFB70-0x00000001828BFC70
	// [XID] // 0x00000001896AC290-0x00000001896AC2B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001828BF040-0x00000001828BF160
	// [XID] // 0x00000001896B3530-0x00000001896B3550
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001828C0630-0x00000001828C07B0
	[BlackList] // 0x00000001896D0CA0-0x00000001896D0CE0
	// [XID] // 0x00000001896D0CA0-0x00000001896D0CE0
	public override void AutoAllocTypeFields() {} // 0x00000001828BE790-0x00000001828BE830
	[BlackList] // 0x00000001896DB2E0-0x00000001896DB320
	// [XID] // 0x00000001896DB2E0-0x00000001896DB320
	public override void AutoRecycleTypeFields() {} // 0x00000001828BE830-0x00000001828BE8E0
	[BlackList] // 0x00000001896E5670-0x00000001896E56B0
	// [XID] // 0x00000001896E5670-0x00000001896E56B0
	public override void ReturnToObjectPool() {} // 0x00000001828C0AE0-0x00000001828C0B80
}

