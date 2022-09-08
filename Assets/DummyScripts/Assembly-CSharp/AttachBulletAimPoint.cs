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
public class AttachBulletAimPoint : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16625
{
	// Fields
	private string _bulletAimPoint; // 0x68

	// Properties
	public string bulletAimPoint { /* [XID] */ /* 0x00000001899D7990-0x00000001899D79B0 */ get => default; /* [XID] */ /* 0x00000001899DEE70-0x00000001899DEE90 */ private set {} } // 0x00000001833D00A0-0x00000001833D0140 0x00000001833CEA60-0x00000001833CEB10
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A69DF0-0x0000000189A69E10 */ get => default; } // 0x00000001833D03F0-0x00000001833D0490 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A71080-0x0000000189A710A0 */ get => default; } // 0x00000001833CF970-0x00000001833CFA10 

	// Constructors
	public AttachBulletAimPoint() {} // 0x00000001833D0AE0-0x00000001833D0B40

	// Methods
	// [XID] // 0x00000001899E6A50-0x00000001899E6A70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833D08B0-0x00000001833D09A0
	// [XID] // 0x00000001899EE020-0x00000001899EE040
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001833D04F0-0x00000001833D05D0
	// [XID] // 0x00000001899F5870-0x00000001899F5890
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF413A */) => default; // 0x00000001833CFFC0-0x00000001833D00A0
	// [XID] // 0x00000001899FCFD0-0x00000001899FCFF0
	public override int GetHashNum() => default; // 0x00000001833CEC00-0x00000001833CECD0
	// [XID] // 0x0000000189A04470-0x0000000189A04490
	public override void InitEmpty() {} // 0x00000001833CFA10-0x00000001833CFAE0
	[BlackList] // 0x0000000189A0BB70-0x0000000189A0BBB0
	// [XID] // 0x0000000189A0BB70-0x0000000189A0BBB0
	public override bool FromJson(JSONNode node) => default; // 0x00000001833CF2F0-0x00000001833CF670
	// [XID] // 0x0000000189A161A0-0x0000000189A161C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001833CE370-0x00000001833CE5A0
	[BlackList] // 0x0000000189A1D720-0x0000000189A1D760
	// [XID] // 0x0000000189A1D720-0x0000000189A1D760
	public static new AttachBulletAimPoint ParseFromJson(JSONNode node) => default; // 0x00000001833D01A0-0x00000001833D03F0
	// [XID] // 0x0000000189A27C20-0x0000000189A27C40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF413B */, bool useObjectPool = false /* Metadata: 0x00AF413F */) => default; // 0x00000001833CFCC0-0x00000001833CFFC0
	// [XID] // 0x0000000189A2F250-0x0000000189A2F270
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4140 */, bool useObjectPool = false /* Metadata: 0x00AF4144 */) => default; // 0x00000001833CEE20-0x00000001833CF090
	// [XID] // 0x0000000189A36CB0-0x0000000189A36CD0
	public static new AttachBulletAimPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4145 */, bool useObjectPool = false /* Metadata: 0x00AF4149 */) => default; // 0x00000001833CF670-0x00000001833CF890
	[BlackList] // 0x0000000189A3E290-0x0000000189A3E2D0
	// [XID] // 0x0000000189A3E290-0x0000000189A3E2D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001833CE5A0-0x00000001833CE870
	// [XID] // 0x0000000189A48910-0x0000000189A48930
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833D06B0-0x00000001833D08B0
	[BlackList] // 0x0000000189A50060-0x0000000189A500A0
	// [XID] // 0x0000000189A50060-0x0000000189A500A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001833CFBC0-0x00000001833CFCC0
	// [XID] // 0x0000000189A5A7D0-0x0000000189A5A7F0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001833D09A0-0x00000001833D0A40
	// [XID] // 0x0000000189A61F70-0x0000000189A61F90
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001833CF090-0x00000001833CF1F0
	[BlackList] // 0x0000000189A78C80-0x0000000189A78CC0
	// [XID] // 0x0000000189A78C80-0x0000000189A78CC0
	public override void AutoAllocTypeFields() {} // 0x00000001833CE870-0x00000001833CE910
	[BlackList] // 0x0000000189A834E0-0x0000000189A83520
	// [XID] // 0x0000000189A834E0-0x0000000189A83520
	public override void AutoRecycleTypeFields() {} // 0x00000001833CE910-0x00000001833CE9C0
	[BlackList] // 0x0000000189A8DE70-0x0000000189A8DEB0
	// [XID] // 0x0000000189A8DE70-0x0000000189A8DEB0
	public override void ReturnToObjectPool() {} // 0x00000001833D0A40-0x00000001833D0AE0
}

