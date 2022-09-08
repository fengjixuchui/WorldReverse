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
public class BanEntityMark : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16805
{
	// Fields
	private bool _isBan; // 0x68

	// Properties
	public bool isBan { /* [XID] */ /* 0x00000001899BB310-0x00000001899BB330 */ get => default; /* [XID] */ /* 0x00000001899C2E40-0x00000001899C2E60 */ private set {} } // 0x0000000184029DF0-0x0000000184029E90 0x0000000184029AB0-0x0000000184029B60
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A45960-0x0000000189A45980 */ get => default; } // 0x000000018402A620-0x000000018402A6C0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A4D000-0x0000000189A4D020 */ get => default; } // 0x0000000184029BD0-0x0000000184029C70 

	// Constructors
	public BanEntityMark() {} // 0x000000018402AC40-0x000000018402ACA0

	// Methods
	// [XID] // 0x00000001899CA260-0x00000001899CA280
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018402AAB0-0x000000018402ABA0
	// [XID] // 0x00000001899D1AC0-0x00000001899D1AE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018402A720-0x000000018402A7D0
	// [XID] // 0x00000001899D8FF0-0x00000001899D9010
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF46DE */) => default; // 0x000000018402A290-0x000000018402A370
	// [XID] // 0x00000001899E07C0-0x00000001899E07E0
	public override int GetHashNum() => default; // 0x0000000184028E60-0x0000000184028F30
	// [XID] // 0x00000001899E8240-0x00000001899E8260
	public override void InitEmpty() {} // 0x0000000184029C70-0x0000000184029D10
	[BlackList] // 0x00000001899EF750-0x00000001899EF790
	// [XID] // 0x00000001899EF750-0x00000001899EF790
	public override bool FromJson(JSONNode node) => default; // 0x0000000184029510-0x0000000184029890
	// [XID] // 0x00000001899F9EF0-0x00000001899F9F10
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001840286B0-0x00000001840288B0
	[BlackList] // 0x0000000189A012D0-0x0000000189A01310
	// [XID] // 0x0000000189A012D0-0x0000000189A01310
	public static new BanEntityMark ParseFromJson(JSONNode node) => default; // 0x000000018402A3D0-0x000000018402A620
	// [XID] // 0x0000000189A0BB30-0x0000000189A0BB50
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46DF */, bool useObjectPool = false /* Metadata: 0x00AF46E3 */) => default; // 0x0000000184029F90-0x000000018402A290
	// [XID] // 0x0000000189A13480-0x0000000189A134A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46E4 */, bool useObjectPool = false /* Metadata: 0x00AF46E8 */) => default; // 0x0000000184029080-0x00000001840292B0
	// [XID] // 0x0000000189A1A5D0-0x0000000189A1A5F0
	public static new BanEntityMark ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46E9 */, bool useObjectPool = false /* Metadata: 0x00AF46ED */) => default; // 0x0000000184029890-0x0000000184029AB0
	[BlackList] // 0x0000000189A21DF0-0x0000000189A21E30
	// [XID] // 0x0000000189A21DF0-0x0000000189A21E30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001840288B0-0x0000000184028B80
	// [XID] // 0x0000000189A2C190-0x0000000189A2C1B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018402A8B0-0x000000018402AAB0
	[BlackList] // 0x0000000189A33860-0x0000000189A338A0
	// [XID] // 0x0000000189A33860-0x0000000189A338A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184029E90-0x0000000184029F90
	// [XID] // 0x0000000189A3E250-0x0000000189A3E270
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001840292B0-0x0000000184029410
	[BlackList] // 0x0000000189A54730-0x0000000189A54770
	// [XID] // 0x0000000189A54730-0x0000000189A54770
	public override void AutoAllocTypeFields() {} // 0x0000000184028B80-0x0000000184028C20
	[BlackList] // 0x0000000189A5F0F0-0x0000000189A5F130
	// [XID] // 0x0000000189A5F0F0-0x0000000189A5F130
	public override void AutoRecycleTypeFields() {} // 0x0000000184028C20-0x0000000184028CD0
	[BlackList] // 0x0000000189A69D90-0x0000000189A69DD0
	// [XID] // 0x0000000189A69D90-0x0000000189A69DD0
	public override void ReturnToObjectPool() {} // 0x000000018402ABA0-0x000000018402AC40
}

