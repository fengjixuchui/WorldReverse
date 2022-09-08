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
public class ClearEndura : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16699
{
	// Fields
	private SimpleSafeFloat percentRawNum; // 0x68

	// Properties
	public float percent { /* [XID] */ /* 0x0000000189A11DA0-0x0000000189A11DC0 */ get => default; /* [XID] */ /* 0x0000000189A19030-0x0000000189A19050 */ private set {} } // 0x000000018541DF60-0x000000018541E040 0x000000018541FA90-0x000000018541FB70
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AA4440-0x0000000189AA4460 */ get => default; } // 0x000000018541FE20-0x000000018541FEC0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AAB930-0x0000000189AAB950 */ get => default; } // 0x000000018541F350-0x000000018541F3F0 

	// Constructors
	public ClearEndura() {} // 0x00000001854204F0-0x00000001854205B0

	// Methods
	// [XID] // 0x0000000189A207D0-0x0000000189A207F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001854202B0-0x00000001854203B0
	// [XID] // 0x0000000189A27BA0-0x0000000189A27BC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018541FF20-0x000000018541FFD0
	// [XID] // 0x0000000189A2F210-0x0000000189A2F230
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF437E */) => default; // 0x000000018541F9B0-0x000000018541FA90
	// [XID] // 0x0000000189A36C50-0x0000000189A36C70
	public override int GetHashNum() => default; // 0x000000018541E620-0x000000018541E6F0
	// [XID] // 0x0000000189A3E270-0x0000000189A3E290
	public override void InitEmpty() {} // 0x000000018541F3F0-0x000000018541F4D0
	[BlackList] // 0x0000000189A45980-0x0000000189A459C0
	// [XID] // 0x0000000189A45980-0x0000000189A459C0
	public override bool FromJson(JSONNode node) => default; // 0x000000018541ECD0-0x000000018541F050
	// [XID] // 0x0000000189A50020-0x0000000189A50040
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018541DD10-0x000000018541DF60
	[BlackList] // 0x0000000189A57610-0x0000000189A57650
	// [XID] // 0x0000000189A57610-0x0000000189A57650
	public static new ClearEndura ParseFromJson(JSONNode node) => default; // 0x000000018541FBD0-0x000000018541FE20
	// [XID] // 0x0000000189A61F50-0x0000000189A61F70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF437F */, bool useObjectPool = false /* Metadata: 0x00AF4383 */) => default; // 0x000000018541F6B0-0x000000018541F9B0
	// [XID] // 0x0000000189A69DD0-0x0000000189A69DF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4384 */, bool useObjectPool = false /* Metadata: 0x00AF4388 */) => default; // 0x000000018541E840-0x000000018541EA70
	// [XID] // 0x0000000189A71060-0x0000000189A71080
	public static new ClearEndura ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4389 */, bool useObjectPool = false /* Metadata: 0x00AF438D */) => default; // 0x000000018541F050-0x000000018541F270
	[BlackList] // 0x0000000189A78C40-0x0000000189A78C80
	// [XID] // 0x0000000189A78C40-0x0000000189A78C80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018541E040-0x000000018541E310
	// [XID] // 0x0000000189A834A0-0x0000000189A834C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001854200B0-0x00000001854202B0
	[BlackList] // 0x0000000189A8ADE0-0x0000000189A8AE20
	// [XID] // 0x0000000189A8ADE0-0x0000000189A8AE20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018541F5B0-0x000000018541F6B0
	// [XID] // 0x0000000189A95410-0x0000000189A95430
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001854203B0-0x0000000185420450
	// [XID] // 0x0000000189A9CC50-0x0000000189A9CC70
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018541EA70-0x000000018541EBD0
	[BlackList] // 0x0000000189AB32A0-0x0000000189AB32E0
	// [XID] // 0x0000000189AB32A0-0x0000000189AB32E0
	public override void AutoAllocTypeFields() {} // 0x000000018541E310-0x000000018541E3B0
	[BlackList] // 0x0000000189ABDD70-0x0000000189ABDDB0
	// [XID] // 0x0000000189ABDD70-0x0000000189ABDDB0
	public override void AutoRecycleTypeFields() {} // 0x000000018541E3B0-0x000000018541E490
	[BlackList] // 0x0000000189AC8650-0x0000000189AC8690
	// [XID] // 0x0000000189AC8650-0x0000000189AC8690
	public override void ReturnToObjectPool() {} // 0x0000000185420450-0x00000001854204F0
}

