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
public class ReleaseAIActionPoint : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16719
{
	// Fields
	private ActionPointType _pointType; // 0x68

	// Properties
	public ActionPointType pointType { /* [XID] */ /* 0x000000018963A3D0-0x000000018963A3F0 */ get => default; /* [XID] */ /* 0x0000000189641920-0x0000000189641940 */ private set {} } // 0x00000001849FA200-0x00000001849FA2A0 0x00000001849F9C70-0x00000001849F9D20
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896CC5B0-0x00000001896CC5D0 */ get => default; } // 0x00000001849FA550-0x00000001849FA5F0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896D3820-0x00000001896D3840 */ get => default; } // 0x00000001849F9A50-0x00000001849F9AF0 

	// Constructors
	public ReleaseAIActionPoint() {} // 0x00000001849FAC10-0x00000001849FAC70

	// Methods
	// [XID] // 0x0000000189649380-0x00000001896493A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849FA9E0-0x00000001849FAAD0
	// [XID] // 0x0000000189650930-0x0000000189650950
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849FA650-0x00000001849FA700
	// [XID] // 0x00000001896581D0-0x00000001896581F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF441E */) => default; // 0x00000001849FA120-0x00000001849FA200
	// [XID] // 0x000000018965F720-0x000000018965F740
	public override int GetHashNum() => default; // 0x00000001849F8D20-0x00000001849F8DF0
	// [XID] // 0x0000000189667170-0x0000000189667190
	public override void InitEmpty() {} // 0x00000001849F9AF0-0x00000001849F9B90
	[BlackList] // 0x000000018966E900-0x000000018966E940
	// [XID] // 0x000000018966E900-0x000000018966E940
	public override bool FromJson(JSONNode node) => default; // 0x00000001849F93D0-0x00000001849F9750
	// [XID] // 0x0000000189679710-0x0000000189679730
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001849F8550-0x00000001849F8770
	[BlackList] // 0x0000000189680EA0-0x0000000189680EE0
	// [XID] // 0x0000000189680EA0-0x0000000189680EE0
	public static new ReleaseAIActionPoint ParseFromJson(JSONNode node) => default; // 0x00000001849FA300-0x00000001849FA550
	// [XID] // 0x000000018968B8D0-0x000000018968B8F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF441F */, bool useObjectPool = false /* Metadata: 0x00AF4423 */) => default; // 0x00000001849F9E20-0x00000001849FA120
	// [XID] // 0x0000000189693420-0x0000000189693440
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4424 */, bool useObjectPool = false /* Metadata: 0x00AF4428 */) => default; // 0x00000001849F8F40-0x00000001849F9170
	// [XID] // 0x000000018969A6D0-0x000000018969A6F0
	public static new ReleaseAIActionPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4429 */, bool useObjectPool = false /* Metadata: 0x00AF442D */) => default; // 0x00000001849F9750-0x00000001849F9970
	[BlackList] // 0x00000001896A2060-0x00000001896A20A0
	// [XID] // 0x00000001896A2060-0x00000001896A20A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001849F8770-0x00000001849F8A40
	// [XID] // 0x00000001896AC2D0-0x00000001896AC2F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849FA7E0-0x00000001849FA9E0
	[BlackList] // 0x00000001896B35B0-0x00000001896B35F0
	// [XID] // 0x00000001896B35B0-0x00000001896B35F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001849F9D20-0x00000001849F9E20
	// [XID] // 0x00000001896BD860-0x00000001896BD880
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001849FAAD0-0x00000001849FAB70
	// [XID] // 0x00000001896C4FF0-0x00000001896C5010
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001849F9170-0x00000001849F92D0
	[BlackList] // 0x00000001896DB340-0x00000001896DB380
	// [XID] // 0x00000001896DB340-0x00000001896DB380
	public override void AutoAllocTypeFields() {} // 0x00000001849F8A40-0x00000001849F8AE0
	[BlackList] // 0x00000001896E56B0-0x00000001896E56F0
	// [XID] // 0x00000001896E56B0-0x00000001896E56F0
	public override void AutoRecycleTypeFields() {} // 0x00000001849F8AE0-0x00000001849F8B90
	[BlackList] // 0x00000001896EFB40-0x00000001896EFB80
	// [XID] // 0x00000001896EFB40-0x00000001896EFB80
	public override void ReturnToObjectPool() {} // 0x00000001849FAB70-0x00000001849FAC10
}

