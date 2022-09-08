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
public class EnableHitAutoRedirect : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16697
{
	// Fields
	private bool _setEnable; // 0x68

	// Properties
	public bool setEnable { /* [XID] */ /* 0x0000000189948E60-0x0000000189948E80 */ get => default; /* [XID] */ /* 0x0000000189950670-0x0000000189950690 */ private set {} } // 0x0000000181413D70-0x0000000181413E10 0x0000000181414A50-0x0000000181414B00
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899DBFD0-0x00000001899DBFF0 */ get => default; } // 0x00000001814147C0-0x0000000181414860 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899E3930-0x00000001899E3950 */ get => default; } // 0x0000000181413E10-0x0000000181413EB0 

	// Constructors
	public EnableHitAutoRedirect() {} // 0x0000000181414F30-0x0000000181414F90

	// Methods
	// [XID] // 0x0000000189957BA0-0x0000000189957BC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181414D00-0x0000000181414DF0
	// [XID] // 0x000000018995F410-0x000000018995F430
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001814148C0-0x0000000181414970
	// [XID] // 0x0000000189966D30-0x0000000189966D50
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF436E */) => default; // 0x0000000181414430-0x0000000181414510
	// [XID] // 0x000000018996E020-0x000000018996E040
	public override int GetHashNum() => default; // 0x0000000181413040-0x0000000181413110
	// [XID] // 0x0000000189975C30-0x0000000189975C50
	public override void InitEmpty() {} // 0x0000000181413EB0-0x0000000181413F50
	[BlackList] // 0x000000018997CCB0-0x000000018997CCF0
	// [XID] // 0x000000018997CCB0-0x000000018997CCF0
	public override bool FromJson(JSONNode node) => default; // 0x00000001814136F0-0x0000000181413A70
	// [XID] // 0x00000001899879F0-0x0000000189987A10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181412890-0x0000000181412A90
	[BlackList] // 0x000000018998F5E0-0x000000018998F620
	// [XID] // 0x000000018998F5E0-0x000000018998F620
	public static new EnableHitAutoRedirect ParseFromJson(JSONNode node) => default; // 0x0000000181414570-0x00000001814147C0
	// [XID] // 0x000000018999A550-0x000000018999A570
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF436F */, bool useObjectPool = false /* Metadata: 0x00AF4373 */) => default; // 0x0000000181414130-0x0000000181414430
	// [XID] // 0x00000001899A1C30-0x00000001899A1C50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4374 */, bool useObjectPool = false /* Metadata: 0x00AF4378 */) => default; // 0x0000000181413260-0x0000000181413490
	// [XID] // 0x00000001899A9420-0x00000001899A9440
	public static new EnableHitAutoRedirect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4379 */, bool useObjectPool = false /* Metadata: 0x00AF437D */) => default; // 0x0000000181413A70-0x0000000181413C90
	[BlackList] // 0x00000001899B0EF0-0x00000001899B0F30
	// [XID] // 0x00000001899B0EF0-0x00000001899B0F30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181412A90-0x0000000181412D60
	// [XID] // 0x00000001899BB330-0x00000001899BB350
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181414B00-0x0000000181414D00
	[BlackList] // 0x00000001899C2E60-0x00000001899C2EA0
	// [XID] // 0x00000001899C2E60-0x00000001899C2EA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181414030-0x0000000181414130
	// [XID] // 0x00000001899CD4D0-0x00000001899CD4F0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181414DF0-0x0000000181414E90
	// [XID] // 0x00000001899D49B0-0x00000001899D49D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181413490-0x00000001814135F0
	[BlackList] // 0x00000001899EAD80-0x00000001899EADC0
	// [XID] // 0x00000001899EAD80-0x00000001899EADC0
	public override void AutoAllocTypeFields() {} // 0x0000000181412D60-0x0000000181412E00
	[BlackList] // 0x00000001899F57D0-0x00000001899F5810
	// [XID] // 0x00000001899F57D0-0x00000001899F5810
	public override void AutoRecycleTypeFields() {} // 0x0000000181412E00-0x0000000181412EB0
	[BlackList] // 0x00000001899FFD40-0x00000001899FFD80
	// [XID] // 0x00000001899FFD40-0x00000001899FFD80
	public override void ReturnToObjectPool() {} // 0x0000000181414E90-0x0000000181414F30
}

