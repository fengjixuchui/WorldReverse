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
public class TriggerThrowEquipPart : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16515
{
	// Fields
	private string _equipPart; // 0x68
	private bool _chaseAttackTarget; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x78

	// Properties
	public string equipPart { /* [XID] */ /* 0x0000000189BCC2C0-0x0000000189BCC2E0 */ get => default; /* [XID] */ /* 0x0000000189BD3950-0x0000000189BD3970 */ private set {} } // 0x00000001829D87E0-0x00000001829D8880 0x00000001829D7DF0-0x00000001829D7EA0
	public bool chaseAttackTarget { /* [XID] */ /* 0x0000000189BDB2E0-0x0000000189BDB300 */ get => default; /* [XID] */ /* 0x00000001895E7BD0-0x00000001895E7BF0 */ private set {} } // 0x00000001829D9820-0x00000001829D98C0 0x00000001829D8C20-0x00000001829D8CD0
	public ConfigBornType born { /* [XID] */ /* 0x00000001895EF560-0x00000001895EF580 */ get => default; /* [XID] */ /* 0x00000001895F6F60-0x00000001895F6F80 */ private set {} } // 0x00000001829D7C70-0x00000001829D7D10 0x00000001829D9E20-0x00000001829D9ED0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896824D0-0x00000001896824F0 */ get => default; } // 0x00000001829D9620-0x00000001829D96C0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189689E90-0x0000000189689EB0 */ get => default; } // 0x00000001829D8B80-0x00000001829D8C20 

	// Constructors
	public TriggerThrowEquipPart() {} // 0x00000001829DA010-0x00000001829DA070

	// Methods
	// [XID] // 0x00000001895FE300-0x00000001895FE320
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829D9CE0-0x00000001829D9E20
	// [XID] // 0x0000000189605BB0-0x0000000189605BD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829D9720-0x00000001829D9820
	// [XID] // 0x000000018960D4E0-0x000000018960D500
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3DD6 */) => default; // 0x00000001829D9290-0x00000001829D9370
	// [XID] // 0x0000000189614BA0-0x0000000189614BC0
	public override int GetHashNum() => default; // 0x00000001829D7B30-0x00000001829D7C00
	// [XID] // 0x000000018961C4A0-0x000000018961C4C0
	public override void InitEmpty() {} // 0x00000001829D8CD0-0x00000001829D8DC0
	[BlackList] // 0x0000000189623840-0x0000000189623880
	// [XID] // 0x0000000189623840-0x0000000189623880
	public override bool FromJson(JSONNode node) => default; // 0x00000001829D8460-0x00000001829D87E0
	// [XID] // 0x000000018962E130-0x000000018962E150
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829D7130-0x00000001829D74F0
	[BlackList] // 0x0000000189635DD0-0x0000000189635E10
	// [XID] // 0x0000000189635DD0-0x0000000189635E10
	public static new TriggerThrowEquipPart ParseFromJson(JSONNode node) => default; // 0x00000001829D93D0-0x00000001829D9620
	// [XID] // 0x0000000189640190-0x00000001896401B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DD7 */, bool useObjectPool = false /* Metadata: 0x00AF3DDB */) => default; // 0x00000001829D8F90-0x00000001829D9290
	// [XID] // 0x00000001896479B0-0x00000001896479D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DDC */, bool useObjectPool = false /* Metadata: 0x00AF3DE0 */) => default; // 0x00000001829D7EA0-0x00000001829D8200
	// [XID] // 0x000000018964F040-0x000000018964F060
	public static new TriggerThrowEquipPart ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DE1 */, bool useObjectPool = false /* Metadata: 0x00AF3DE5 */) => default; // 0x00000001829D8880-0x00000001829D8AA0
	[BlackList] // 0x00000001896568F0-0x0000000189656930
	// [XID] // 0x00000001896568F0-0x0000000189656930
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829D74F0-0x00000001829D77C0
	// [XID] // 0x0000000189661030-0x0000000189661050
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829D99A0-0x00000001829D9CE0
	[BlackList] // 0x0000000189668A40-0x0000000189668A80
	// [XID] // 0x0000000189668A40-0x0000000189668A80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829D8EA0-0x00000001829D8F90
	// [XID] // 0x0000000189673340-0x0000000189673360
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001829D9ED0-0x00000001829D9F70
	// [XID] // 0x000000018967AB80-0x000000018967ABA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001829D8200-0x00000001829D8360
	[BlackList] // 0x0000000189691C70-0x0000000189691CB0
	// [XID] // 0x0000000189691C70-0x0000000189691CB0
	public override void AutoAllocTypeFields() {} // 0x00000001829D77C0-0x00000001829D7860
	[BlackList] // 0x000000018969C1A0-0x000000018969C1E0
	// [XID] // 0x000000018969C1A0-0x000000018969C1E0
	public override void AutoRecycleTypeFields() {} // 0x00000001829D7860-0x00000001829D79A0
	[BlackList] // 0x00000001896A63F0-0x00000001896A6430
	// [XID] // 0x00000001896A63F0-0x00000001896A6430
	public override void ReturnToObjectPool() {} // 0x00000001829D9F70-0x00000001829DA010
}

