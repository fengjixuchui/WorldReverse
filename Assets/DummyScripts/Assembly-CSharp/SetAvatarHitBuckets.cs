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
public class SetAvatarHitBuckets : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16711
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAvatarHitBucketSetting _overrideAvatarHitBucketSetting; // 0x68

	// Properties
	public ConfigAvatarHitBucketSetting overrideAvatarHitBucketSetting { /* [XID] */ /* 0x00000001899222C0-0x00000001899222E0 */ get => default; /* [XID] */ /* 0x0000000189929A80-0x0000000189929AA0 */ private set {} } // 0x0000000184619E20-0x0000000184619EC0 0x00000001846196B0-0x0000000184619760
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899B54C0-0x00000001899B54E0 */ get => default; } // 0x000000018461A250-0x000000018461A2F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899BCC10-0x00000001899BCC30 */ get => default; } // 0x00000001846197D0-0x0000000184619870 

	// Constructors
	public SetAvatarHitBuckets() {} // 0x000000018461A960-0x000000018461A9C0

	// Methods
	// [XID] // 0x0000000189931000-0x0000000189931020
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018461A740-0x000000018461A820
	// [XID] // 0x0000000189938470-0x0000000189938490
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018461A350-0x000000018461A430
	// [XID] // 0x000000018993FE60-0x000000018993FE80
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF43DE */) => default; // 0x0000000184619EC0-0x0000000184619FA0
	// [XID] // 0x00000001899474E0-0x0000000189947500
	public override int GetHashNum() => default; // 0x0000000184618980-0x0000000184618A50
	// [XID] // 0x000000018994EC40-0x000000018994EC60
	public override void InitEmpty() {} // 0x0000000184619870-0x0000000184619940
	[BlackList] // 0x0000000189956180-0x00000001899561C0
	// [XID] // 0x0000000189956180-0x00000001899561C0
	public override bool FromJson(JSONNode node) => default; // 0x00000001846190A0-0x0000000184619420
	// [XID] // 0x0000000189960BC0-0x0000000189960BE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184618110-0x0000000184618350
	[BlackList] // 0x0000000189968380-0x00000001899683C0
	// [XID] // 0x0000000189968380-0x00000001899683C0
	public static new SetAvatarHitBuckets ParseFromJson(JSONNode node) => default; // 0x000000018461A000-0x000000018461A250
	// [XID] // 0x0000000189972C70-0x0000000189972C90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43DF */, bool useObjectPool = false /* Metadata: 0x00AF43E3 */) => default; // 0x0000000184619B20-0x0000000184619E20
	// [XID] // 0x000000018997A5D0-0x000000018997A5F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43E4 */, bool useObjectPool = false /* Metadata: 0x00AF43E8 */) => default; // 0x0000000184618BA0-0x0000000184618E40
	// [XID] // 0x0000000189981EE0-0x0000000189981F00
	public static new SetAvatarHitBuckets ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF43E9 */, bool useObjectPool = false /* Metadata: 0x00AF43ED */) => default; // 0x0000000184619420-0x0000000184619640
	[BlackList] // 0x0000000189989700-0x0000000189989740
	// [XID] // 0x0000000189989700-0x0000000189989740
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184618350-0x0000000184618620
	// [XID] // 0x00000001899942B0-0x00000001899942D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018461A510-0x000000018461A740
	[BlackList] // 0x000000018999BAE0-0x000000018999BB20
	// [XID] // 0x000000018999BAE0-0x000000018999BB20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184619A20-0x0000000184619B20
	// [XID] // 0x00000001899A65B0-0x00000001899A65D0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018461A820-0x000000018461A8C0
	// [XID] // 0x00000001899ADD60-0x00000001899ADD80
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184618E40-0x0000000184618FA0
	[BlackList] // 0x00000001899C4600-0x00000001899C4640
	// [XID] // 0x00000001899C4600-0x00000001899C4640
	public override void AutoAllocTypeFields() {} // 0x0000000184618620-0x00000001846186C0
	[BlackList] // 0x00000001899CEB60-0x00000001899CEBA0
	// [XID] // 0x00000001899CEB60-0x00000001899CEBA0
	public override void AutoRecycleTypeFields() {} // 0x00000001846186C0-0x00000001846187F0
	[BlackList] // 0x00000001899D9010-0x00000001899D9050
	// [XID] // 0x00000001899D9010-0x00000001899D9050
	public override void ReturnToObjectPool() {} // 0x000000018461A8C0-0x000000018461A960
}

