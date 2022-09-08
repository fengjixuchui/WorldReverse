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
public class SyncToStageScript : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16651
{
	// Fields
	private string _alias; // 0x68

	// Properties
	public string alias { /* [XID] */ /* 0x00000001898BFF20-0x00000001898BFF40 */ get => default; /* [XID] */ /* 0x00000001898C7840-0x00000001898C7860 */ private set {} } // 0x0000000182500C10-0x0000000182500CB0 0x00000001825016E0-0x0000000182501790
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189953430-0x0000000189953450 */ get => default; } // 0x0000000182501A40-0x0000000182501AE0 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018995AC10-0x000000018995AC30 */ get => default; } // 0x0000000182500FB0-0x0000000182501050 

	// Constructors
	public SyncToStageScript() {} // 0x0000000182502130-0x0000000182502190

	// Methods
	// [XID] // 0x00000001898CEEF0-0x00000001898CEF10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182501F00-0x0000000182501FF0
	// [XID] // 0x00000001898D6920-0x00000001898D6940
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182501B40-0x0000000182501C20
	// [XID] // 0x00000001898DE520-0x00000001898DE540
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF420A */) => default; // 0x0000000182501600-0x00000001825016E0
	// [XID] // 0x00000001898E5D80-0x00000001898E5DA0
	public override int GetHashNum() => default; // 0x00000001825001A0-0x0000000182500270
	// [XID] // 0x00000001898ED680-0x00000001898ED6A0
	public override void InitEmpty() {} // 0x0000000182501050-0x0000000182501120
	[BlackList] // 0x00000001898F4E60-0x00000001898F4EA0
	// [XID] // 0x00000001898F4E60-0x00000001898F4EA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182500890-0x0000000182500C10
	// [XID] // 0x00000001898FF6F0-0x00000001898FF710
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001824FF9C0-0x00000001824FFBF0
	[BlackList] // 0x0000000189906EF0-0x0000000189906F30
	// [XID] // 0x0000000189906EF0-0x0000000189906F30
	public static new SyncToStageScript ParseFromJson(JSONNode node) => default; // 0x00000001825017F0-0x0000000182501A40
	// [XID] // 0x00000001899116E0-0x0000000189911700
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF420B */, bool useObjectPool = false /* Metadata: 0x00AF420F */) => default; // 0x0000000182501300-0x0000000182501600
	// [XID] // 0x00000001899192A0-0x00000001899192C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4210 */, bool useObjectPool = false /* Metadata: 0x00AF4214 */) => default; // 0x00000001825003C0-0x0000000182500630
	// [XID] // 0x0000000189920830-0x0000000189920850
	public static new SyncToStageScript ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4215 */, bool useObjectPool = false /* Metadata: 0x00AF4219 */) => default; // 0x0000000182500CB0-0x0000000182500ED0
	[BlackList] // 0x0000000189928190-0x00000001899281D0
	// [XID] // 0x0000000189928190-0x00000001899281D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001824FFBF0-0x00000001824FFEC0
	// [XID] // 0x00000001899327C0-0x00000001899327E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182501D00-0x0000000182501F00
	[BlackList] // 0x000000018993A1B0-0x000000018993A1F0
	// [XID] // 0x000000018993A1B0-0x000000018993A1F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182501200-0x0000000182501300
	// [XID] // 0x0000000189944620-0x0000000189944640
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182501FF0-0x0000000182502090
	// [XID] // 0x000000018994BC20-0x000000018994BC40
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182500630-0x0000000182500790
	[BlackList] // 0x0000000189962750-0x0000000189962790
	// [XID] // 0x0000000189962750-0x0000000189962790
	public override void AutoAllocTypeFields() {} // 0x00000001824FFEC0-0x00000001824FFF60
	[BlackList] // 0x000000018996CAF0-0x000000018996CB30
	// [XID] // 0x000000018996CAF0-0x000000018996CB30
	public override void AutoRecycleTypeFields() {} // 0x00000001824FFF60-0x0000000182500010
	[BlackList] // 0x0000000189977500-0x0000000189977540
	// [XID] // 0x0000000189977500-0x0000000189977540
	public override void ReturnToObjectPool() {} // 0x0000000182502090-0x0000000182502130
}

