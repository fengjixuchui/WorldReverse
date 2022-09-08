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
public class EnableHitBoxByName : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16561
{
	// Fields
	private string[] _hitBoxNames; // 0x68
	private bool _setEnable; // 0x70

	// Properties
	public string[] hitBoxNames { /* [XID] */ /* 0x0000000189652200-0x0000000189652220 */ get => default; /* [XID] */ /* 0x0000000189659890-0x00000001896598B0 */ private set {} } // 0x0000000183389450-0x00000001833894F0 0x000000018338B680-0x000000018338B730
	public bool setEnable { /* [XID] */ /* 0x0000000189661010-0x0000000189661030 */ get => default; /* [XID] */ /* 0x0000000189668A00-0x0000000189668A20 */ private set {} } // 0x000000018338AB70-0x000000018338AC10 0x000000018338B950-0x000000018338BA00
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896F2B30-0x00000001896F2B50 */ get => default; } // 0x000000018338B5E0-0x000000018338B680 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896FA450-0x00000001896FA470 */ get => default; } // 0x000000018338AC10-0x000000018338ACB0 

	// Constructors
	public EnableHitBoxByName() {} // 0x000000018338BF10-0x000000018338BF70

	// Methods
	// [XID] // 0x00000001896705D0-0x00000001896705F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018338BCC0-0x000000018338BDD0
	// [XID] // 0x0000000189677DF0-0x0000000189677E10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018338B790-0x000000018338B870
	// [XID] // 0x000000018967F320-0x000000018967F340
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F3E */) => default; // 0x000000018338B250-0x000000018338B330
	// [XID] // 0x0000000189686BD0-0x0000000189686BF0
	public override int GetHashNum() => default; // 0x0000000183389D90-0x0000000183389E60
	// [XID] // 0x000000018968EA70-0x000000018968EA90
	public override void InitEmpty() {} // 0x000000018338ACB0-0x000000018338AD80
	[BlackList] // 0x00000001896964F0-0x0000000189696530
	// [XID] // 0x00000001896964F0-0x0000000189696530
	public override bool FromJson(JSONNode node) => default; // 0x000000018338A4F0-0x000000018338A870
	// [XID] // 0x00000001896A06B0-0x00000001896A06D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001833894F0-0x00000001833897E0
	[BlackList] // 0x00000001896A7B60-0x00000001896A7BA0
	// [XID] // 0x00000001896A7B60-0x00000001896A7BA0
	public static new EnableHitBoxByName ParseFromJson(JSONNode node) => default; // 0x000000018338B390-0x000000018338B5E0
	// [XID] // 0x00000001896B19F0-0x00000001896B1A10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F3F */, bool useObjectPool = false /* Metadata: 0x00AF3F43 */) => default; // 0x000000018338AF50-0x000000018338B250
	// [XID] // 0x00000001896B93F0-0x00000001896B9410
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F44 */, bool useObjectPool = false /* Metadata: 0x00AF3F48 */) => default; // 0x0000000183389FB0-0x000000018338A290
	// [XID] // 0x00000001896C0800-0x00000001896C0820
	public static new EnableHitBoxByName ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F49 */, bool useObjectPool = false /* Metadata: 0x00AF3F4D */) => default; // 0x000000018338A870-0x000000018338AA90
	[BlackList] // 0x00000001896C7F50-0x00000001896C7F90
	// [XID] // 0x00000001896C7F50-0x00000001896C7F90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001833897E0-0x0000000183389AB0
	// [XID] // 0x00000001896D2380-0x00000001896D23A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018338BA00-0x000000018338BCC0
	[BlackList] // 0x00000001896D9D50-0x00000001896D9D90
	// [XID] // 0x00000001896D9D50-0x00000001896D9D90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018338AE60-0x000000018338AF50
	// [XID] // 0x00000001896E4350-0x00000001896E4370
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018338BDD0-0x000000018338BE70
	// [XID] // 0x00000001896EB760-0x00000001896EB780
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018338A290-0x000000018338A3F0
	[BlackList] // 0x0000000189701B60-0x0000000189701BA0
	// [XID] // 0x0000000189701B60-0x0000000189701BA0
	public override void AutoAllocTypeFields() {} // 0x0000000183389AB0-0x0000000183389B50
	[BlackList] // 0x000000018970C230-0x000000018970C270
	// [XID] // 0x000000018970C230-0x000000018970C270
	public override void AutoRecycleTypeFields() {} // 0x0000000183389B50-0x0000000183389C00
	[BlackList] // 0x00000001897167E0-0x0000000189716820
	// [XID] // 0x00000001897167E0-0x0000000189716820
	public override void ReturnToObjectPool() {} // 0x000000018338BE70-0x000000018338BF10
}

